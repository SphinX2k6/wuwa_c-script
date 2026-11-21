using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020024C9 RID: 9417
[NullableContext(1)]
[Nullable(0)]
public class ShieldSnapshotModify : SnapModifyBuffEffect
{
	// Token: 0x0601762F RID: 95791 RVA: 0x006E2D9E File Offset: 0x006E0F9E
	public ShieldSnapshotModify(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017630 RID: 95792 RVA: 0x006E2DB0 File Offset: 0x006E0FB0
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		float[] extraEffectGrowParameters = parameters.ExtraEffectGrowParameters1;
		float[] extraEffectGrowParameters2 = parameters.ExtraEffectGrowParameters2;
		this.TargetType = new ESnapTargetType?((ESnapTargetType)int.Parse(extraEffectParameters_[0]));
		this.BuffHolderType = new int?(int.Parse(extraEffectParameters_[1]));
		this.ShieldId = int.Parse(extraEffectParameters_[2]);
		this.AttributeId = (EAttributeType)int.Parse(extraEffectParameters_[3]);
		this.CompareFactor = int.Parse(extraEffectParameters_[4]);
		this.ConvertThreshold = float.Parse(extraEffectParameters_[5]);
		this.ConvertLimit = float.Parse(extraEffectParameters_[6]);
		this.ConvertMagnitude = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters, this.Level, 0f);
		this.ConvertRatio = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters2, this.Level, 0f);
		this.NeedCheckCritical = false;
		for (int i = 0; i < this.RequireAndLimits.Requirements.Length; i++)
		{
			if (this.RequireAndLimits.Requirements[i].Type == EExtraEffectRequire.ShouldCritical)
			{
				this.NeedCheckCritical = true;
				return;
			}
		}
	}

	// Token: 0x06017631 RID: 95793 RVA: 0x006E2EA8 File Offset: 0x006E10A8
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		if (parameters.Length < 2)
		{
			return false;
		}
		this.OnExecuteSnap((Dictionary<EAttributeType, float>)parameters[0], (SnapshotPayload)parameters[1]);
		return true;
	}

	// Token: 0x06017632 RID: 95794 RVA: 0x006E2ED4 File Offset: 0x006E10D4
	protected override void OnExecuteSnap(Dictionary<EAttributeType, float> resultMap, SnapshotPayload snapshots)
	{
		float num2;
		float num = resultMap.TryGetValue(this.AttributeId, out num2) ? num2 : 0f;
		int? buffHolderType = this.BuffHolderType;
		int num3 = 0;
		Entity entity;
		if (buffHolderType.GetValueOrDefault() == num3 & buffHolderType != null)
		{
			entity = base.OwnerEntity;
		}
		else
		{
			EntityHandle instigatorEntity = base.InstigatorEntity;
			entity = ((instigatorEntity != null) ? instigatorEntity.Entity : null);
		}
		Entity entity2 = entity;
		if (entity2 != null)
		{
			CharacterShieldComponent component = entity2.GetComponent<CharacterShieldComponent>();
			float num4 = (component != null) ? component.GetShieldValue(this.ShieldId) : 0f;
			bool flag = num4 >= this.ConvertThreshold;
			float num5 = num4;
			if (this.ConvertLimit > 0f)
			{
				num5 = Math.Min(num5, this.ConvertLimit);
			}
			if (this.CompareFactor > 0)
			{
				buffHolderType = this.BuffHolderType;
				num3 = 0;
				ESnapAttributeSourceType targetType = (buffHolderType.GetValueOrDefault() == num3 & buffHolderType != null) ? ESnapAttributeSourceType.BuffHolder : ESnapAttributeSourceType.BuffMaker;
				float attrValue = base.GetAttrValue(snapshots, (EAttributeType)this.CompareFactor, EAttributeRefType.CurrentValue, targetType);
				flag = (num4 >= attrValue * this.ConvertThreshold * 0.0001f);
				if (this.ConvertLimit > 0f)
				{
					num5 = Math.Min(num4, attrValue * this.ConvertLimit * 0.0001f);
				}
			}
			if (flag)
			{
				float num6 = num5 * this.ConvertRatio * 0.0001f + this.ConvertMagnitude;
				resultMap[this.AttributeId] = num + num6;
			}
		}
	}

	// Token: 0x0400C691 RID: 50833
	public int? BuffHolderType;

	// Token: 0x0400C692 RID: 50834
	public int ShieldId;

	// Token: 0x0400C693 RID: 50835
	public EAttributeType AttributeId;

	// Token: 0x0400C694 RID: 50836
	public int CompareFactor;

	// Token: 0x0400C695 RID: 50837
	public float ConvertThreshold;

	// Token: 0x0400C696 RID: 50838
	public float ConvertLimit;

	// Token: 0x0400C697 RID: 50839
	public float ConvertMagnitude;

	// Token: 0x0400C698 RID: 50840
	public float ConvertRatio;
}
