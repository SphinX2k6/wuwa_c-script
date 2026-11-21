using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002810 RID: 10256
[NullableContext(1)]
[Nullable(0)]
public class SquadPropComponent : EntityComponent, ISquadAttributeSet, IStaticVariableResetter
{
	// Token: 0x06019CE1 RID: 105697 RVA: 0x007F2D74 File Offset: 0x007F0F74
	static SquadPropComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SquadPropComponent.CreateStaticDefaultValue), new Action(SquadPropComponent.ResetStaticDefaultValue));
	}

	// Token: 0x06019CE2 RID: 105698 RVA: 0x007F2DDA File Offset: 0x007F0FDA
	public static void CreateStaticDefaultValue()
	{
		SquadPropComponent.ModifierHandleGenerator = 100;
	}

	// Token: 0x06019CE3 RID: 105699 RVA: 0x007F2DE3 File Offset: 0x007F0FE3
	public static void ResetStaticDefaultValue()
	{
		SquadPropComponent.ModifierHandleGenerator = 100;
	}

	// Token: 0x06019CE4 RID: 105700 RVA: 0x007F2DEC File Offset: 0x007F0FEC
	public bool IsWritableAttribute(ESquadAttributeType attrId)
	{
		return SquadAttributeTypes.squadWritableAttributeIds.Contains(attrId);
	}

	// Token: 0x06019CE5 RID: 105701 RVA: 0x007F2DF9 File Offset: 0x007F0FF9
	public bool IsLocalAttribute(ESquadAttributeType attrId)
	{
		return SquadAttributeTypes.squadLocalAttributeIds.Contains(attrId);
	}

	// Token: 0x06019CE6 RID: 105702 RVA: 0x007F2E08 File Offset: 0x007F1008
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

	// Token: 0x06019CE7 RID: 105703 RVA: 0x007F2E68 File Offset: 0x007F1068
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

	// Token: 0x06019CE8 RID: 105704 RVA: 0x007F2EA9 File Offset: 0x007F10A9
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
		this.InitFromPbData();
		return true;
	}

	// Token: 0x06019CE9 RID: 105705 RVA: 0x007F2ECF File Offset: 0x007F10CF
	protected override void OnActivate()
	{
		this.InitFromPbData();
	}

	// Token: 0x06019CEA RID: 105706 RVA: 0x007F2ED7 File Offset: 0x007F10D7
	protected override bool OnEnd()
	{
		this.CurrentValueListenerMap.Clear();
		this.AnyCurrentValueListenerSet.Clear();
		return true;
	}

	// Token: 0x06019CEB RID: 105707 RVA: 0x007F2EF0 File Offset: 0x007F10F0
	protected override bool OnClear()
	{
		Array.Clear(this.BaseValues, 0, this.BaseValues.Length);
		Array.Clear(this.CurrentValues, 0, this.CurrentValues.Length);
		Array.Clear(this.ModifierLists, 0, this.ModifierLists.Length);
		return true;
	}

	// Token: 0x06019CEC RID: 105708 RVA: 0x007F2F30 File Offset: 0x007F1130
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

	// Token: 0x06019CED RID: 105709 RVA: 0x007F2F8C File Offset: 0x007F118C
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

	// Token: 0x06019CEE RID: 105710 RVA: 0x007F2FEC File Offset: 0x007F11EC
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

	// Token: 0x06019CEF RID: 105711 RVA: 0x007F3020 File Offset: 0x007F1220
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

	// Token: 0x06019CF0 RID: 105712 RVA: 0x007F3088 File Offset: 0x007F1288
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

	// Token: 0x06019CF1 RID: 105713 RVA: 0x007F3108 File Offset: 0x007F1308
	public void AddBaseValue(ESquadAttributeType attrId, float value)
	{
		this.SetBaseValue(attrId, this.BaseValues[(int)attrId] + value);
	}

	// Token: 0x06019CF2 RID: 105714 RVA: 0x007F311B File Offset: 0x007F131B
	public float GetBaseValue(ESquadAttributeType attrId)
	{
		return this.BaseValues[(int)attrId];
	}

	// Token: 0x06019CF3 RID: 105715 RVA: 0x007F3125 File Offset: 0x007F1325
	public float GetCurrentValue(ESquadAttributeType attrId)
	{
		return this.CurrentValues[(int)attrId];
	}

	// Token: 0x06019CF4 RID: 105716 RVA: 0x007F3130 File Offset: 0x007F1330
	private float? GetMaxValue(ESquadAttributeType attrId)
	{
		ESquadAttributeType attrId2;
		if (SquadAttributeTypes.squadAttrIdsWithMax.TryGetValue(attrId, out attrId2))
		{
			return new float?(this.GetCurrentValue(attrId2));
		}
		return null;
	}

	// Token: 0x06019CF5 RID: 105717 RVA: 0x007F3164 File Offset: 0x007F1364
	public SquadAttributeSnapshot TakeSnapshot()
	{
		SquadAttributeSnapshot squadAttributeSnapshot = new SquadAttributeSnapshot();
		Array.Copy(this.BaseValues, squadAttributeSnapshot.BaseValues, 3);
		Array.Copy(this.CurrentValues, squadAttributeSnapshot.CurrentValues, 3);
		return squadAttributeSnapshot;
	}

	// Token: 0x06019CF6 RID: 105718 RVA: 0x007F319C File Offset: 0x007F139C
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

	// Token: 0x06019CF7 RID: 105719 RVA: 0x007F31E8 File Offset: 0x007F13E8
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

	// Token: 0x06019CF8 RID: 105720 RVA: 0x007F3260 File Offset: 0x007F1460
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

	// Token: 0x06019CF9 RID: 105721 RVA: 0x007F32FD File Offset: 0x007F14FD
	public void RemoveModifier(ESquadAttributeType attrId, int handle)
	{
		Dictionary<int, ISquadModifier> dictionary = this.ModifierLists[(int)attrId];
		if (dictionary != null && dictionary.Remove(handle))
		{
			this.UpdateCurAndDispatch(attrId);
		}
	}

	// Token: 0x06019CFA RID: 105722 RVA: 0x007F331D File Offset: 0x007F151D
	public IEnumerable<ISquadModifier> GetAllModifiers(ESquadAttributeType attrId)
	{
		SquadPropComponent.<GetAllModifiers>d__32 <GetAllModifiers>d__ = new SquadPropComponent.<GetAllModifiers>d__32(-2);
		<GetAllModifiers>d__.<>4__this = this;
		<GetAllModifiers>d__.<>3__attrId = attrId;
		return <GetAllModifiers>d__;
	}

	// Token: 0x06019CFB RID: 105723 RVA: 0x007F3334 File Offset: 0x007F1534
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

	// Token: 0x06019CFC RID: 105724 RVA: 0x007F3480 File Offset: 0x007F1680
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

	// Token: 0x06019CFD RID: 105725 RVA: 0x007F34B8 File Offset: 0x007F16B8
	public void AddListeners(ESquadAttributeType[] attrIds, SquadAttrChangeListener callback)
	{
		foreach (ESquadAttributeType attrId in attrIds)
		{
			this.AddListener(attrId, callback);
		}
	}

	// Token: 0x06019CFE RID: 105726 RVA: 0x007F34E4 File Offset: 0x007F16E4
	public bool RemoveListener(ESquadAttributeType attrId, SquadAttrChangeListener callback)
	{
		HashSet<SquadAttrChangeListener> hashSet;
		return this.CurrentValueListenerMap.TryGetValue(attrId, out hashSet) && hashSet.Remove(callback);
	}

	// Token: 0x06019CFF RID: 105727 RVA: 0x007F350C File Offset: 0x007F170C
	public void RemoveListeners(ESquadAttributeType[] attrIds, SquadAttrChangeListener callback)
	{
		foreach (ESquadAttributeType attrId in attrIds)
		{
			this.RemoveListener(attrId, callback);
		}
	}

	// Token: 0x06019D00 RID: 105728 RVA: 0x007F3536 File Offset: 0x007F1736
	public void AddGeneralListener(SquadAttrChangeListener listener)
	{
		this.AnyCurrentValueListenerSet.Add(listener);
	}

	// Token: 0x06019D01 RID: 105729 RVA: 0x007F3545 File Offset: 0x007F1745
	public void RemoveGeneralListener(SquadAttrChangeListener listener)
	{
		this.AnyCurrentValueListenerSet.Remove(listener);
	}

	// Token: 0x06019D02 RID: 105730 RVA: 0x007F3554 File Offset: 0x007F1754
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

	// Token: 0x06019D03 RID: 105731 RVA: 0x007F35EC File Offset: 0x007F17EC
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

	// Token: 0x06019D04 RID: 105732 RVA: 0x007F3794 File Offset: 0x007F1994
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		SquadPropComponent squadPropComponent = (SquadPropComponent)componentTemplate;
		this.PlayerId = squadPropComponent.PlayerId;
		return (squadPropComponent.CurrentValueListenerMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentValueListenerMap), "CurrentValueListenerMap")) && (squadPropComponent.AnyCurrentValueListenerSet == null || base.CheckClearObject(EntityComponentSystem.ClearObject<SquadAttrChangeListener>(this.AnyCurrentValueListenerSet), "AnyCurrentValueListenerSet"));
	}

	// Token: 0x1700299B RID: 10651
	// (get) Token: 0x06019D05 RID: 105733 RVA: 0x007F3804 File Offset: 0x007F1A04
	public override bool NeedCreateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700299C RID: 10652
	// (get) Token: 0x06019D06 RID: 105734 RVA: 0x007F3807 File Offset: 0x007F1A07
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700299D RID: 10653
	// (get) Token: 0x06019D07 RID: 105735 RVA: 0x007F380A File Offset: 0x007F1A0A
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700299E RID: 10654
	// (get) Token: 0x06019D08 RID: 105736 RVA: 0x007F380D File Offset: 0x007F1A0D
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E252 RID: 57938
	public int PlayerId;

	// Token: 0x0400E253 RID: 57939
	private readonly float[] BaseValues = new float[3];

	// Token: 0x0400E254 RID: 57940
	private readonly float[] CurrentValues = new float[3];

	// Token: 0x0400E255 RID: 57941
	private readonly Dictionary<int, ISquadModifier>[] ModifierLists = new Dictionary<int, ISquadModifier>[3];

	// Token: 0x0400E256 RID: 57942
	private static int ModifierHandleGenerator;

	// Token: 0x0400E257 RID: 57943
	protected readonly Dictionary<ESquadAttributeType, HashSet<SquadAttrChangeListener>> CurrentValueListenerMap = new Dictionary<ESquadAttributeType, HashSet<SquadAttrChangeListener>>();

	// Token: 0x0400E258 RID: 57944
	protected readonly HashSet<SquadAttrChangeListener> AnyCurrentValueListenerSet = new HashSet<SquadAttrChangeListener>();

	// Token: 0x0400E259 RID: 57945
	[StaticVariableRuleIgnore]
	private static readonly Stat DispatchCurrentValueEventStat = Stat.Create("SquadPropComponent.DispatchCurrentValueEvent", "STATGROUP_KuroBattle", "");

	// Token: 0x0400E25A RID: 57946
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<ESquadAttributeType, Stat> StatCurrentAttrEventMap = new Dictionary<ESquadAttributeType, Stat>();

	// Token: 0x0400E25B RID: 57947
	[StaticVariableRuleIgnore]
	private static readonly Stat StatAnyCurrentAttrEvent = Stat.Create("Squad AnyCurrentAttr event", "STATGROUP_KuroBattle", "");
}
