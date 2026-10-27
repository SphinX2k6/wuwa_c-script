using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200329F RID: 12959
[NullableContext(1)]
[Nullable(0)]
public class SquadPropComponent : EntityComponent, ISquadAttributeSet, IStaticVariableResetter
{
	// Token: 0x0601C0B3 RID: 114867 RVA: 0x007CBAB4 File Offset: 0x007C9CB4
	static SquadPropComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SquadPropComponent.CreateStaticDefaultValue), new Action(SquadPropComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601C0B4 RID: 114868 RVA: 0x007CBB1A File Offset: 0x007C9D1A
	public static void CreateStaticDefaultValue()
	{
		SquadPropComponent.ModifierHandleGenerator = 100;
	}

	// Token: 0x0601C0B5 RID: 114869 RVA: 0x007CBB23 File Offset: 0x007C9D23
	public static void ResetStaticDefaultValue()
	{
		SquadPropComponent.ModifierHandleGenerator = 100;
	}

	// Token: 0x0601C0B6 RID: 114870 RVA: 0x007CBB2C File Offset: 0x007C9D2C
	public bool IsWritableAttribute(ESquadAttributeType attrId)
	{
		return SquadAttributeTypes.squadWritableAttributeIds.Contains(attrId);
	}

	// Token: 0x0601C0B7 RID: 114871 RVA: 0x007CBB39 File Offset: 0x007C9D39
	public bool IsLocalAttribute(ESquadAttributeType attrId)
	{
		return SquadAttributeTypes.squadLocalAttributeIds.Contains(attrId);
	}

	// Token: 0x0601C0B8 RID: 114872 RVA: 0x007CBB48 File Offset: 0x007C9D48
	[NullableContext(2)]
	public static SquadPropComponent GetByEntity(Entity entity)
	{
		int? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent creatureDataComponent = entity.CheckGetComponent<CreatureDataComponent>();
			num = ((creatureDataComponent != null) ? new int?(creatureDataComponent.GetPlayerId()) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		if (valueOrDefault <= 0)
		{
			return null;
		}
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(valueOrDefault);
		if (playerEntity == null)
		{
			return null;
		}
		return playerEntity.GetComponent<SquadPropComponent>();
	}

	// Token: 0x0601C0B9 RID: 114873 RVA: 0x007CBBA8 File Offset: 0x007C9DA8
	[NullableContext(2)]
	protected override bool OnCreate(IEntityArgs args = null)
	{
		for (int i = 0; i < 3; i++)
		{
			this.BaseValues[i] = 0f;
			this.CurrentValues[i] = 0f;
			this.ModifierLists[i] = new Dictionary<int, ISquadModifier>();
		}
		return true;
	}

	// Token: 0x0601C0BA RID: 114874 RVA: 0x007CBBE9 File Offset: 0x007C9DE9
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
		this.InitFromPbData();
		return true;
	}

	// Token: 0x0601C0BB RID: 114875 RVA: 0x007CBC0F File Offset: 0x007C9E0F
	protected override void OnActivate()
	{
		this.InitFromPbData();
	}

	// Token: 0x0601C0BC RID: 114876 RVA: 0x007CBC17 File Offset: 0x007C9E17
	protected override bool OnEnd()
	{
		this.CurrentValueListenerMap.Clear();
		this.AnyCurrentValueListenerSet.Clear();
		return true;
	}

	// Token: 0x0601C0BD RID: 114877 RVA: 0x007CBC30 File Offset: 0x007C9E30
	protected override bool OnClear()
	{
		Array.Clear(this.BaseValues, 0, this.BaseValues.Length);
		Array.Clear(this.CurrentValues, 0, this.CurrentValues.Length);
		Array.Clear(this.ModifierLists, 0, this.ModifierLists.Length);
		return true;
	}

	// Token: 0x0601C0BE RID: 114878 RVA: 0x007CBC70 File Offset: 0x007C9E70
	private void InitFromPbData()
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		EntityComponentPb entityComponentPb;
		SquadPropComponentPb squadPropComponentPb = (creatureDataComponent != null && creatureDataComponent.ComponentDataMap.TryGetValue("SquadPropComponentPb", out entityComponentPb)) ? ((entityComponentPb != null) ? entityComponentPb.SquadPropComponentPb : null) : null;
		if (((squadPropComponentPb != null) ? squadPropComponentPb.Attributes : null) != null)
		{
			this.ApplyAttributes(squadPropComponentPb.Attributes);
		}
	}

	// Token: 0x0601C0BF RID: 114879 RVA: 0x007CBCCC File Offset: 0x007C9ECC
	public void ApplyAttributes(IReadOnlyList<GameplayAttributeData> attributes)
	{
		foreach (GameplayAttributeData gameplayAttributeData in attributes)
		{
			int attributeType = gameplayAttributeData.AttributeType;
			if (attributeType != 0)
			{
				this.SyncValueFromServer((ESquadAttributeType)attributeType, (float)gameplayAttributeData.BaseValue, (float)gameplayAttributeData.CurrentValue);
			}
		}
	}

	// Token: 0x0601C0C0 RID: 114880 RVA: 0x007CBD2C File Offset: 0x007C9F2C
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.SquadPropChangedNotify, true, false)]
	public static void SquadPropChangedNotify(Entity entity, [Nullable(1)] SquadPropChangedNotify data, CombatCommon combatCommon = null)
	{
		SquadPropComponent squadPropComponent = (entity != null) ? entity.GetComponent<SquadPropComponent>() : null;
		if (squadPropComponent != null && data.Attributes != null)
		{
			squadPropComponent.ApplyAttributes(data.Attributes);
		}
	}

	// Token: 0x0601C0C1 RID: 114881 RVA: 0x007CBD60 File Offset: 0x007C9F60
	public void SyncValueFromServer(ESquadAttributeType attrId, float baseValue, float currentValue)
	{
		if (attrId <= ESquadAttributeType.None || attrId >= ESquadAttributeType.Max)
		{
			return;
		}
		if (this.IsLocalAttribute(attrId))
		{
			return;
		}
		if (this.BaseValues[(int)attrId] != baseValue)
		{
			this.BaseValues[(int)attrId] = baseValue;
		}
		float oldValue = this.CurrentValues[(int)attrId];
		this.CurrentValues[(int)attrId] = currentValue;
		this.DispatchCurrentValueEvent(attrId, currentValue, oldValue);
		ESquadAttributeType attrId2;
		if (SquadAttributeTypes.squadAttrIdsMaxToAttrId.TryGetValue(attrId, out attrId2))
		{
			this.UpdateCurAndDispatch(attrId2);
		}
	}

	// Token: 0x0601C0C2 RID: 114882 RVA: 0x007CBDC8 File Offset: 0x007C9FC8
	public void SetBaseValue(ESquadAttributeType attrId, float value)
	{
		if (attrId <= ESquadAttributeType.None || attrId >= ESquadAttributeType.Max)
		{
			return;
		}
		if (!this.IsWritableAttribute(attrId))
		{
			return;
		}
		float num = value;
		if (!SquadAttributeTypes.squadAttrsNotClampZero.Contains(attrId))
		{
			num = Math.Max(num, 0f);
		}
		if (SquadAttributeTypes.squadStateAttributeIds.Contains(attrId))
		{
			float? maxValue = this.GetMaxValue(attrId);
			if (maxValue != null)
			{
				num = Math.Min(num, maxValue.Value);
			}
		}
		num = (float)Math.Floor((double)num);
		this.BaseValues[(int)attrId] = num;
		this.UpdateCurAndDispatch(attrId);
	}

	// Token: 0x0601C0C3 RID: 114883 RVA: 0x007CBE48 File Offset: 0x007CA048
	public void AddBaseValue(ESquadAttributeType attrId, float value)
	{
		this.SetBaseValue(attrId, this.BaseValues[(int)attrId] + value);
	}

	// Token: 0x0601C0C4 RID: 114884 RVA: 0x007CBE5B File Offset: 0x007CA05B
	public float GetBaseValue(ESquadAttributeType attrId)
	{
		return this.BaseValues[(int)attrId];
	}

	// Token: 0x0601C0C5 RID: 114885 RVA: 0x007CBE65 File Offset: 0x007CA065
	public float GetCurrentValue(ESquadAttributeType attrId)
	{
		return this.CurrentValues[(int)attrId];
	}

	// Token: 0x0601C0C6 RID: 114886 RVA: 0x007CBE70 File Offset: 0x007CA070
	private float? GetMaxValue(ESquadAttributeType attrId)
	{
		ESquadAttributeType attrId2;
		if (SquadAttributeTypes.squadAttrIdsWithMax.TryGetValue(attrId, out attrId2))
		{
			return new float?(this.GetCurrentValue(attrId2));
		}
		return null;
	}

	// Token: 0x0601C0C7 RID: 114887 RVA: 0x007CBEA4 File Offset: 0x007CA0A4
	public SquadAttributeSnapshot TakeSnapshot()
	{
		SquadAttributeSnapshot squadAttributeSnapshot = new SquadAttributeSnapshot();
		Array.Copy(this.BaseValues, squadAttributeSnapshot.BaseValues, 3);
		Array.Copy(this.CurrentValues, squadAttributeSnapshot.CurrentValues, 3);
		return squadAttributeSnapshot;
	}

	// Token: 0x0601C0C8 RID: 114888 RVA: 0x007CBEDC File Offset: 0x007CA0DC
	private void UpdateCurAndDispatch(ESquadAttributeType attrId)
	{
		float num = this.CurrentValues[(int)attrId];
		this.UpdateCurrentValue(attrId);
		float num2 = this.CurrentValues[(int)attrId];
		this.DispatchCurrentValueEvent(attrId, num2, num);
		ESquadAttributeType attrId2;
		if (num2 != num && SquadAttributeTypes.squadAttrIdsMaxToAttrId.TryGetValue(attrId, out attrId2))
		{
			this.UpdateCurAndDispatch(attrId2);
		}
	}

	// Token: 0x0601C0C9 RID: 114889 RVA: 0x007CBF28 File Offset: 0x007CA128
	private void UpdateCurrentValue(ESquadAttributeType attrId)
	{
		if (!this.IsWritableAttribute(attrId))
		{
			return;
		}
		float num = SquadAttributeTypes.squadStateAttributeIds.Contains(attrId) ? this.BaseValues[(int)attrId] : this.EvaluateModifiers(attrId);
		num = Math.Max(num, 0f);
		float? maxValue = this.GetMaxValue(attrId);
		if (maxValue != null)
		{
			num = Math.Min(num, maxValue.Value);
		}
		if (this.CurrentValues[(int)attrId] == num)
		{
			return;
		}
		this.CurrentValues[(int)attrId] = num;
	}

	// Token: 0x0601C0CA RID: 114890 RVA: 0x007CBFA0 File Offset: 0x007CA1A0
	public int AddModifier(ESquadAttributeType attrId, ISquadModifier modifier)
	{
		if (attrId <= ESquadAttributeType.None || attrId >= ESquadAttributeType.Max)
		{
			return -1;
		}
		if (!this.IsWritableAttribute(attrId))
		{
			return -1;
		}
		if (SquadAttributeTypes.squadStateAttributeIds.Contains(attrId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			string message = "[SquadProp] 禁止给状态属性添加Modifier（状态属性Cur直接取Base，Modifier不生效）";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("attrId", attrId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return -1;
		}
		int num = SquadPropComponent.ModifierHandleGenerator++;
		this.ModifierLists[(int)attrId] = (this.ModifierLists[(int)attrId] ?? new Dictionary<int, ISquadModifier>());
		this.ModifierLists[(int)attrId][num] = modifier;
		this.UpdateCurAndDispatch(attrId);
		return num;
	}

	// Token: 0x0601C0CB RID: 114891 RVA: 0x007CC03D File Offset: 0x007CA23D
	public void RemoveModifier(ESquadAttributeType attrId, int handle)
	{
		Dictionary<int, ISquadModifier> dictionary = this.ModifierLists[(int)attrId];
		if (dictionary != null && dictionary.Remove(handle))
		{
			this.UpdateCurAndDispatch(attrId);
		}
	}

	// Token: 0x0601C0CC RID: 114892 RVA: 0x007CC05D File Offset: 0x007CA25D
	public IEnumerable<ISquadModifier> GetAllModifiers(ESquadAttributeType attrId)
	{
		SquadPropComponent.<GetAllModifiers>d__32 <GetAllModifiers>d__ = new SquadPropComponent.<GetAllModifiers>d__32(-2);
		<GetAllModifiers>d__.<>4__this = this;
		<GetAllModifiers>d__.<>3__attrId = attrId;
		return <GetAllModifiers>d__;
	}

	// Token: 0x0601C0CD RID: 114893 RVA: 0x007CC074 File Offset: 0x007CA274
	private float EvaluateModifiers(ESquadAttributeType attrId)
	{
		float num = this.BaseValues[(int)attrId];
		Dictionary<int, ISquadModifier> dictionary = this.ModifierLists[(int)attrId];
		if (dictionary == null || dictionary.Count == 0)
		{
			return num;
		}
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		bool flag = false;
		int num5 = int.MaxValue;
		float result = 0f;
		foreach (KeyValuePair<int, ISquadModifier> keyValuePair in dictionary)
		{
			ISquadModifier value = keyValuePair.Value;
			SquadAddValueModifier squadAddValueModifier = value as SquadAddValueModifier;
			if (squadAddValueModifier == null)
			{
				SquadAddRateModifier squadAddRateModifier = value as SquadAddRateModifier;
				if (squadAddRateModifier == null)
				{
					SquadAdvancedMulModifier squadAdvancedMulModifier = value as SquadAdvancedMulModifier;
					if (squadAdvancedMulModifier == null)
					{
						SquadOverrideModifier squadOverrideModifier = value as SquadOverrideModifier;
						if (squadOverrideModifier != null)
						{
							if (keyValuePair.Key < num5)
							{
								flag = true;
								num5 = keyValuePair.Key;
								result = squadOverrideModifier.Value;
							}
						}
					}
					else
					{
						num3 += squadAdvancedMulModifier.Value;
					}
				}
				else
				{
					num2 += squadAddRateModifier.Value;
				}
			}
			else
			{
				num4 += squadAddValueModifier.Value;
			}
		}
		if (flag)
		{
			return result;
		}
		return (float)Math.Floor((double)((num * (num2 * 0.0001f + 1f) + num4) * (num3 * 0.0001f + 1f)));
	}

	// Token: 0x0601C0CE RID: 114894 RVA: 0x007CC1C0 File Offset: 0x007CA3C0
	public void AddListener(ESquadAttributeType attrId, SquadAttrChangeListener callback)
	{
		HashSet<SquadAttrChangeListener> hashSet;
		if (!this.CurrentValueListenerMap.TryGetValue(attrId, out hashSet))
		{
			hashSet = new HashSet<SquadAttrChangeListener>();
			this.CurrentValueListenerMap[attrId] = hashSet;
		}
		hashSet.Add(callback);
	}

	// Token: 0x0601C0CF RID: 114895 RVA: 0x007CC1F8 File Offset: 0x007CA3F8
	public void AddListeners(ESquadAttributeType[] attrIds, SquadAttrChangeListener callback)
	{
		foreach (ESquadAttributeType attrId in attrIds)
		{
			this.AddListener(attrId, callback);
		}
	}

	// Token: 0x0601C0D0 RID: 114896 RVA: 0x007CC224 File Offset: 0x007CA424
	public bool RemoveListener(ESquadAttributeType attrId, SquadAttrChangeListener callback)
	{
		HashSet<SquadAttrChangeListener> hashSet;
		return this.CurrentValueListenerMap.TryGetValue(attrId, out hashSet) && hashSet.Remove(callback);
	}

	// Token: 0x0601C0D1 RID: 114897 RVA: 0x007CC24C File Offset: 0x007CA44C
	public void RemoveListeners(ESquadAttributeType[] attrIds, SquadAttrChangeListener callback)
	{
		foreach (ESquadAttributeType attrId in attrIds)
		{
			this.RemoveListener(attrId, callback);
		}
	}

	// Token: 0x0601C0D2 RID: 114898 RVA: 0x007CC276 File Offset: 0x007CA476
	public void AddGeneralListener(SquadAttrChangeListener listener)
	{
		this.AnyCurrentValueListenerSet.Add(listener);
	}

	// Token: 0x0601C0D3 RID: 114899 RVA: 0x007CC285 File Offset: 0x007CA485
	public void RemoveGeneralListener(SquadAttrChangeListener listener)
	{
		this.AnyCurrentValueListenerSet.Remove(listener);
	}

	// Token: 0x0601C0D4 RID: 114900 RVA: 0x007CC294 File Offset: 0x007CA494
	public void DispatchCurrentValueEvent(ESquadAttributeType attrId, float newValue, float oldValue)
	{
		if (oldValue == newValue)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.GHY;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 4);
		defaultInterpolatedStringHandler.AppendLiteral("[SquadProp] 属性变化 PlayerId=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.PlayerId);
		defaultInterpolatedStringHandler.AppendLiteral(" attrId=");
		defaultInterpolatedStringHandler.AppendFormatted<ESquadAttributeType>(attrId);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(oldValue);
		defaultInterpolatedStringHandler.AppendLiteral(" -> ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(newValue);
		instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		this.DispatchCurrentValueEventImplement(attrId, newValue, oldValue);
	}

	// Token: 0x0601C0D5 RID: 114901 RVA: 0x007CC32C File Offset: 0x007CA52C
	protected void DispatchCurrentValueEventImplement(ESquadAttributeType attrId, float newValue, float oldValue)
	{
		HashSet<SquadAttrChangeListener> hashSet;
		if (this.CurrentValueListenerMap.TryGetValue(attrId, out hashSet))
		{
			Stat value;
			if (!SquadPropComponent.StatCurrentAttrEventMap.TryGetValue(attrId, out value))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Squad CurrentAttr#");
				defaultInterpolatedStringHandler.AppendFormatted<ESquadAttributeType>(attrId);
				defaultInterpolatedStringHandler.AppendLiteral(" event");
				value = Stat.CreateNoFlameGraph(defaultInterpolatedStringHandler.ToStringAndClear(), "STATGROUP_KuroBattle", "");
				SquadPropComponent.StatCurrentAttrEventMap[attrId] = value;
			}
			SquadAttrChangeListener[] array = new SquadAttrChangeListener[hashSet.Count];
			hashSet.CopyTo(array);
			foreach (SquadAttrChangeListener squadAttrChangeListener in array)
			{
				if (hashSet.Contains(squadAttrChangeListener))
				{
					try
					{
						squadAttrChangeListener(attrId, newValue, oldValue);
					}
					catch (Exception ex)
					{
						CombatLog instance = CombatLog.Instance;
						CombatLog.EDebugModule flag = CombatLog.EDebugModule.Attribute;
						Entity entity = base.Entity;
						string message = "小队属性回调异常";
						Exception e = ex;
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("属性", attrId);
						instance.ErrorWithStack(flag, entity, message, e, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}
			}
		}
		SquadAttrChangeListener[] array3 = new SquadAttrChangeListener[this.AnyCurrentValueListenerSet.Count];
		this.AnyCurrentValueListenerSet.CopyTo(array3);
		foreach (SquadAttrChangeListener squadAttrChangeListener2 in array3)
		{
			if (this.AnyCurrentValueListenerSet.Contains(squadAttrChangeListener2))
			{
				try
				{
					squadAttrChangeListener2(attrId, newValue, oldValue);
				}
				catch (Exception ex2)
				{
					CombatLog instance2 = CombatLog.Instance;
					CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Attribute;
					Entity entity2 = base.Entity;
					string message2 = "小队属性全局回调异常";
					Exception e2 = ex2;
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("属性", attrId);
					instance2.ErrorWithStack(flag2, entity2, message2, e2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
		}
	}

	// Token: 0x0601C0D6 RID: 114902 RVA: 0x007CC4D4 File Offset: 0x007CA6D4
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		SquadPropComponent squadPropComponent = (SquadPropComponent)componentTemplate;
		if (base.CanResetComponentProperty("PlayerId"))
		{
			this.PlayerId = squadPropComponent.PlayerId;
		}
		return (!base.CanResetComponentProperty("CurrentValueListenerMap") || squadPropComponent.CurrentValueListenerMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<ESquadAttributeType, HashSet<SquadAttrChangeListener>>>(this.CurrentValueListenerMap), "CurrentValueListenerMap")) && (!base.CanResetComponentProperty("AnyCurrentValueListenerSet") || squadPropComponent.AnyCurrentValueListenerSet == null || base.CheckClearObject(EntityComponentSystem.ClearObject<SquadAttrChangeListener>(this.AnyCurrentValueListenerSet), "AnyCurrentValueListenerSet"));
	}

	// Token: 0x0400DDAB RID: 56747
	public int PlayerId;

	// Token: 0x0400DDAC RID: 56748
	private readonly float[] BaseValues = new float[3];

	// Token: 0x0400DDAD RID: 56749
	private readonly float[] CurrentValues = new float[3];

	// Token: 0x0400DDAE RID: 56750
	private readonly Dictionary<int, ISquadModifier>[] ModifierLists = new Dictionary<int, ISquadModifier>[3];

	// Token: 0x0400DDAF RID: 56751
	private static int ModifierHandleGenerator;

	// Token: 0x0400DDB0 RID: 56752
	protected readonly Dictionary<ESquadAttributeType, HashSet<SquadAttrChangeListener>> CurrentValueListenerMap = new Dictionary<ESquadAttributeType, HashSet<SquadAttrChangeListener>>();

	// Token: 0x0400DDB1 RID: 56753
	protected readonly HashSet<SquadAttrChangeListener> AnyCurrentValueListenerSet = new HashSet<SquadAttrChangeListener>();

	// Token: 0x0400DDB2 RID: 56754
	[StaticVariableRuleIgnore]
	private static readonly Stat DispatchCurrentValueEventStat = Stat.Create("SquadPropComponent.DispatchCurrentValueEvent", "STATGROUP_KuroBattle", "");

	// Token: 0x0400DDB3 RID: 56755
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<ESquadAttributeType, Stat> StatCurrentAttrEventMap = new Dictionary<ESquadAttributeType, Stat>();

	// Token: 0x0400DDB4 RID: 56756
	[StaticVariableRuleIgnore]
	private static readonly Stat StatAnyCurrentAttrEvent = Stat.Create("Squad AnyCurrentAttr event", "STATGROUP_KuroBattle", "");
}
