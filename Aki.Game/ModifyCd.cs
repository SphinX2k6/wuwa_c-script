using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020024B1 RID: 9393
[NullableContext(1)]
[Nullable(0)]
public class ModifyCd : BuffEffect
{
	// Token: 0x060175E5 RID: 95717 RVA: 0x006E13AA File Offset: 0x006DF5AA
	public ModifyCd(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060175E6 RID: 95718 RVA: 0x006E13C4 File Offset: 0x006DF5C4
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

	// Token: 0x060175E7 RID: 95719 RVA: 0x006E1430 File Offset: 0x006DF630
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

	// Token: 0x060175E8 RID: 95720 RVA: 0x006E149C File Offset: 0x006DF69C
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060175E9 RID: 95721 RVA: 0x006E14A0 File Offset: 0x006DF6A0
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

	// Token: 0x0400C623 RID: 50723
	public HashSet<long> SkillIdOrGenres = new HashSet<long>();

	// Token: 0x0400C624 RID: 50724
	public int SkillType;

	// Token: 0x0400C625 RID: 50725
	public EModifyCdType ModifyType;

	// Token: 0x0400C626 RID: 50726
	public float ModifyValue;

	// Token: 0x0400C627 RID: 50727
	[Nullable(2)]
	private float[] ModifyValues;
}
