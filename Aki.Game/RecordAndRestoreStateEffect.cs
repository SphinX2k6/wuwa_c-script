using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020024AF RID: 9391
[NullableContext(1)]
[Nullable(0)]
public class RecordAndRestoreStateEffect : BuffEffect
{
	// Token: 0x060175DE RID: 95710 RVA: 0x006E0DD8 File Offset: 0x006DEFD8
	public RecordAndRestoreStateEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060175DF RID: 95711 RVA: 0x006E0E34 File Offset: 0x006DF034
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		long[] array = RecordAndRestoreStateEffect.<InitParameters>g__ParseIdList|8_0((extraEffectParameters_ != null && extraEffectParameters_.Length != 0) ? extraEffectParameters_[0] : null);
		this.AttributeIds = new EAttributeType[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.AttributeIds[i] = (EAttributeType)array[i];
		}
		long[] array2 = RecordAndRestoreStateEffect.<InitParameters>g__ParseIdList|8_0((extraEffectParameters_ != null && extraEffectParameters_.Length > 1) ? extraEffectParameters_[1] : null);
		this.FormationAttributeIds = new EFormationAttributeId[array2.Length];
		for (int j = 0; j < array2.Length; j++)
		{
			this.FormationAttributeIds[j] = (EFormationAttributeId)array2[j];
		}
		this.BuffIds = RecordAndRestoreStateEffect.<InitParameters>g__ParseIdList|8_0((extraEffectParameters_ != null && extraEffectParameters_.Length > 2) ? extraEffectParameters_[2] : null);
		int num;
		this.ForceRestore = (extraEffectParameters_ != null && extraEffectParameters_.Length > 3 && int.TryParse(extraEffectParameters_[3], out num) && num == 1);
	}

	// Token: 0x060175E0 RID: 95712 RVA: 0x006E0F08 File Offset: 0x006DF108
	public unsafe override void OnCreated()
	{
		this.RecordedAttributeValues.Clear();
		this.RecordedFormationValues.Clear();
		this.RecordedBuffStacks.Clear();
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		BaseAttributeComponent baseAttributeComponent = (ownerBuffComponent != null) ? ownerBuffComponent.GetAttributeComponent() : null;
		if (baseAttributeComponent != null)
		{
			foreach (EAttributeType eattributeType in this.AttributeIds)
			{
				if (!CharacterAttributeTypes.stateAttributeIds.Contains(eattributeType))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.BuffItem;
					ELogAuthor author = ELogAuthor.GHY;
					string message = "RecordAndRestoreState 仅支持状态属性，已忽略非状态属性";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", this.BuffId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("attrId", eattributeType);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					this.RecordedAttributeValues[eattributeType] = baseAttributeComponent.GetBaseValue(eattributeType);
				}
			}
		}
		IBuffComponent ownerBuffComponent2 = this.OwnerBuffComponent;
		if (ownerBuffComponent2 == null || !ownerBuffComponent2.HasBuffAuthority())
		{
			return;
		}
		foreach (EFormationAttributeId eformationAttributeId in this.FormationAttributeIds)
		{
			this.RecordedFormationValues[eformationAttributeId] = FormationAttributeController.Instance.GetValue(eformationAttributeId);
		}
		foreach (long num in this.BuffIds)
		{
			ActiveBuffInternal buffById = this.OwnerBuffComponent.GetBuffById(num);
			if (buffById != null)
			{
				this.RecordedBuffStacks[num] = buffById.StackCount;
			}
		}
	}

	// Token: 0x060175E1 RID: 95713 RVA: 0x006E1089 File Offset: 0x006DF289
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060175E2 RID: 95714 RVA: 0x006E108C File Offset: 0x006DF28C
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		BaseAttributeComponent baseAttributeComponent = (ownerBuffComponent != null) ? ownerBuffComponent.GetAttributeComponent() : null;
		if (baseAttributeComponent != null)
		{
			foreach (KeyValuePair<EAttributeType, float> keyValuePair in this.RecordedAttributeValues)
			{
				EAttributeType eattributeType;
				float num;
				keyValuePair.Deconstruct(out eattributeType, out num);
				EAttributeType attrId = eattributeType;
				float num2 = num;
				if (this.ForceRestore || num2 > baseAttributeComponent.GetBaseValue(attrId))
				{
					baseAttributeComponent.SetBaseValue(attrId, num2);
				}
			}
		}
		IBuffComponent ownerBuffComponent2 = this.OwnerBuffComponent;
		if (ownerBuffComponent2 == null || !ownerBuffComponent2.HasBuffAuthority())
		{
			return;
		}
		foreach (KeyValuePair<EFormationAttributeId, float> keyValuePair2 in this.RecordedFormationValues)
		{
			float num;
			EFormationAttributeId eformationAttributeId;
			keyValuePair2.Deconstruct(out eformationAttributeId, out num);
			EFormationAttributeId attrId2 = eformationAttributeId;
			float num3 = num;
			if (this.ForceRestore || num3 > FormationAttributeController.Instance.GetValue(attrId2))
			{
				FormationAttributeController.Instance.SetValue(attrId2, num3);
			}
		}
		foreach (KeyValuePair<long, int> keyValuePair3 in this.RecordedBuffStacks)
		{
			long num4;
			int num5;
			keyValuePair3.Deconstruct(out num4, out num5);
			long num6 = num4;
			int value = num5;
			IBuffComponent ownerBuffComponent3 = this.OwnerBuffComponent;
			long buffId = num6;
			AddBuffParam addBuffParam = new AddBuffParam();
			CharacterBuffComponent instigatorBuffComponent = base.InstigatorBuffComponent;
			addBuffParam.InstigatorId = ((instigatorBuffComponent != null) ? instigatorBuffComponent.CreatureDataId : 0L);
			IActiveBuff pendingBuff = base.PendingBuff;
			addBuffParam.PreMessageId = ((pendingBuff != null) ? pendingBuff.MessageId : null);
			addBuffParam.OuterStackCount = new int?(value);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
			defaultInterpolatedStringHandler.AppendLiteral("额外效果RecordAndRestoreState:buff");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
			defaultInterpolatedStringHandler.AppendLiteral("移除时恢复记录的buff");
			addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
			ownerBuffComponent3.AddBuff(buffId, addBuffParam);
		}
	}

	// Token: 0x060175E3 RID: 95715 RVA: 0x006E1294 File Offset: 0x006DF494
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 4);
		defaultInterpolatedStringHandler.AppendLiteral("记录状态(实体状态属性[");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<EAttributeType>(",", this.AttributeIds));
		defaultInterpolatedStringHandler.AppendLiteral("] 队伍属性[");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<EFormationAttributeId>(",", this.FormationAttributeIds));
		defaultInterpolatedStringHandler.AppendLiteral("] buff[");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<long>(",", this.BuffIds));
		defaultInterpolatedStringHandler.AppendLiteral("])，移除时");
		defaultInterpolatedStringHandler.AppendFormatted(this.ForceRestore ? "强制" : "按较大值");
		defaultInterpolatedStringHandler.AppendLiteral("恢复");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060175E4 RID: 95716 RVA: 0x006E1350 File Offset: 0x006DF550
	[CompilerGenerated]
	internal static long[] <InitParameters>g__ParseIdList|8_0([Nullable(2)] string raw)
	{
		if (string.IsNullOrEmpty(raw))
		{
			return Array.Empty<long>();
		}
		string[] array = raw.Split('#', StringSplitOptions.None);
		List<long> list = new List<long>(array.Length);
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			long item;
			if (long.TryParse(array2[i].Trim(), out item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0400C618 RID: 50712
	private EAttributeType[] AttributeIds = Array.Empty<EAttributeType>();

	// Token: 0x0400C619 RID: 50713
	private EFormationAttributeId[] FormationAttributeIds = Array.Empty<EFormationAttributeId>();

	// Token: 0x0400C61A RID: 50714
	private long[] BuffIds = Array.Empty<long>();

	// Token: 0x0400C61B RID: 50715
	private bool ForceRestore;

	// Token: 0x0400C61C RID: 50716
	private readonly Dictionary<EAttributeType, float> RecordedAttributeValues = new Dictionary<EAttributeType, float>();

	// Token: 0x0400C61D RID: 50717
	private readonly Dictionary<EFormationAttributeId, float> RecordedFormationValues = new Dictionary<EFormationAttributeId, float>();

	// Token: 0x0400C61E RID: 50718
	private readonly Dictionary<long, int> RecordedBuffStacks = new Dictionary<long, int>();
}
