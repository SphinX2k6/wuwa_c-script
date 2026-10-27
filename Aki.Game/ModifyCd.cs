using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002F5D RID: 12125
[NullableContext(1)]
[Nullable(0)]
public class ModifyCd : BuffEffect
{
	// Token: 0x06019CD3 RID: 105683 RVA: 0x006BAABB File Offset: 0x006B8CBB
	public ModifyCd(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019CD4 RID: 105684 RVA: 0x006BAAD8 File Offset: 0x006B8CD8
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			this.SkillIdOrGenres.Add(long.Parse(array[i]));
		}
		this.SkillType = int.Parse(extraEffectParameters_[1]);
		this.ModifyType = (EModifyCdType)int.Parse(extraEffectParameters_[2]);
		this.ModifyValues = parameters.ExtraEffectGrowParameters1;
	}

	// Token: 0x06019CD5 RID: 105685 RVA: 0x006BAB44 File Offset: 0x006B8D44
	public override void OnCreated()
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseSkillCdComponent baseSkillCdComponent = (exactOwnerEntity != null) ? exactOwnerEntity.GetComponent<BaseSkillCdComponent>() : null;
		if (baseSkillCdComponent == null)
		{
			return;
		}
		this.ModifyValue = AbilityUtils.GetLevelValue<float>(this.ModifyValues, this.Level, 0f);
		if (this.ModifyType == EModifyCdType.Multiply || this.ModifyType == EModifyCdType.AddPerTenThousand)
		{
			this.ModifyValue *= 0.0001f;
		}
		baseSkillCdComponent.UpdateModifyCdEffect(true, this);
	}

	// Token: 0x06019CD6 RID: 105686 RVA: 0x006BABB0 File Offset: 0x006B8DB0
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019CD7 RID: 105687 RVA: 0x006BABB4 File Offset: 0x006B8DB4
	public override void OnRemoved(bool bPremature)
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseSkillCdComponent baseSkillCdComponent = (exactOwnerEntity != null) ? exactOwnerEntity.GetComponent<BaseSkillCdComponent>() : null;
		if (baseSkillCdComponent == null)
		{
			return;
		}
		baseSkillCdComponent.UpdateModifyCdEffect(false, this);
	}

	// Token: 0x0400C27A RID: 49786
	public HashSet<long> SkillIdOrGenres = new HashSet<long>();

	// Token: 0x0400C27B RID: 49787
	public int SkillType;

	// Token: 0x0400C27C RID: 49788
	public EModifyCdType ModifyType;

	// Token: 0x0400C27D RID: 49789
	public float ModifyValue;

	// Token: 0x0400C27E RID: 49790
	[Nullable(2)]
	private float[] ModifyValues;
}
