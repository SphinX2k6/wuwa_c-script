using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;

// Token: 0x02001701 RID: 5889
public class MoraleBuffData
{
	// Token: 0x0600E51A RID: 58650 RVA: 0x00433A53 File Offset: 0x00431C53
	[NullableContext(1)]
	public static MoraleBuffData Create(MoraleLvPower cfg)
	{
		MoraleBuffData moraleBuffData = new MoraleBuffData(cfg);
		moraleBuffData.Init();
		return moraleBuffData;
	}

	// Token: 0x0600E51B RID: 58651 RVA: 0x00433A61 File Offset: 0x00431C61
	private MoraleBuffData(MoraleLvPower cfg)
	{
		this.Id = cfg.Id;
		this.Config = cfg;
	}

	// Token: 0x0600E51C RID: 58652 RVA: 0x00433A7D File Offset: 0x00431C7D
	private void Init()
	{
		this.EndStageLv = this.Config.LvStage;
	}

	// Token: 0x0600E51D RID: 58653 RVA: 0x00433A90 File Offset: 0x00431C90
	public void SetStartStageLv(int lv)
	{
		this.StartStageLv = lv;
	}

	// Token: 0x0600E51E RID: 58654 RVA: 0x00433A99 File Offset: 0x00431C99
	public void SetIndex(int index)
	{
		this.Index = index;
	}

	// Token: 0x0600E51F RID: 58655 RVA: 0x00433AA4 File Offset: 0x00431CA4
	public EMoraleBuffState GetActiveState()
	{
		int lvStage = this.Config.LvStage;
		int moraleLevel = MoraleBattleModel.Instance.GetMoraleLevel();
		if (moraleLevel >= lvStage)
		{
			return EMoraleBuffState.Active;
		}
		int tempMoraleLevel = MoraleBattleModel.Instance.GetTempMoraleLevel();
		if (moraleLevel + tempMoraleLevel >= lvStage)
		{
			return EMoraleBuffState.TempActive;
		}
		return EMoraleBuffState.NotActive;
	}

	// Token: 0x0600E520 RID: 58656 RVA: 0x00433AE2 File Offset: 0x00431CE2
	public bool IsActive()
	{
		return this.GetActiveState() == EMoraleBuffState.Active;
	}

	// Token: 0x0600E521 RID: 58657 RVA: 0x00433AED File Offset: 0x00431CED
	public bool IsTempActive()
	{
		return this.GetActiveState() == EMoraleBuffState.TempActive;
	}

	// Token: 0x0600E522 RID: 58658 RVA: 0x00433AF8 File Offset: 0x00431CF8
	public bool IsNotActive()
	{
		return this.GetActiveState() == EMoraleBuffState.NotActive;
	}

	// Token: 0x0600E523 RID: 58659 RVA: 0x00433B04 File Offset: 0x00431D04
	public bool IsActiveOrTempActive()
	{
		EMoraleBuffState activeState = this.GetActiveState();
		return activeState == EMoraleBuffState.Active || activeState == EMoraleBuffState.TempActive;
	}

	// Token: 0x0600E524 RID: 58660 RVA: 0x00433B22 File Offset: 0x00431D22
	public void SetSelectState(bool isSelect)
	{
		this.IsSelect = isSelect;
	}

	// Token: 0x040082D7 RID: 33495
	public int Id;

	// Token: 0x040082D8 RID: 33496
	public MoraleLvPower Config;

	// Token: 0x040082D9 RID: 33497
	public bool IsSelect;

	// Token: 0x040082DA RID: 33498
	public int StartStageLv;

	// Token: 0x040082DB RID: 33499
	public int EndStageLv;

	// Token: 0x040082DC RID: 33500
	public int Index;
}
