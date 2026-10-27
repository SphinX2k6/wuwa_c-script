using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;

// Token: 0x0200221D RID: 8733
public class MoraleBuffData
{
	// Token: 0x06011084 RID: 69764 RVA: 0x00426EC3 File Offset: 0x004250C3
	[NullableContext(1)]
	public static MoraleBuffData Create(MoraleLvPower cfg)
	{
		MoraleBuffData moraleBuffData = new MoraleBuffData(cfg);
		moraleBuffData.Init();
		return moraleBuffData;
	}

	// Token: 0x06011085 RID: 69765 RVA: 0x00426ED1 File Offset: 0x004250D1
	private MoraleBuffData(MoraleLvPower cfg)
	{
		this.Id = cfg.Id;
		this.Config = cfg;
	}

	// Token: 0x06011086 RID: 69766 RVA: 0x00426EED File Offset: 0x004250ED
	private void Init()
	{
		this.EndStageLv = this.Config.LvStage;
	}

	// Token: 0x06011087 RID: 69767 RVA: 0x00426F00 File Offset: 0x00425100
	public void SetStartStageLv(int lv)
	{
		this.StartStageLv = lv;
	}

	// Token: 0x06011088 RID: 69768 RVA: 0x00426F09 File Offset: 0x00425109
	public void SetIndex(int index)
	{
		this.Index = index;
	}

	// Token: 0x06011089 RID: 69769 RVA: 0x00426F14 File Offset: 0x00425114
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

	// Token: 0x0601108A RID: 69770 RVA: 0x00426F52 File Offset: 0x00425152
	public bool IsActive()
	{
		return this.GetActiveState() == EMoraleBuffState.Active;
	}

	// Token: 0x0601108B RID: 69771 RVA: 0x00426F5D File Offset: 0x0042515D
	public bool IsTempActive()
	{
		return this.GetActiveState() == EMoraleBuffState.TempActive;
	}

	// Token: 0x0601108C RID: 69772 RVA: 0x00426F68 File Offset: 0x00425168
	public bool IsNotActive()
	{
		return this.GetActiveState() == EMoraleBuffState.NotActive;
	}

	// Token: 0x0601108D RID: 69773 RVA: 0x00426F74 File Offset: 0x00425174
	public bool IsActiveOrTempActive()
	{
		EMoraleBuffState activeState = this.GetActiveState();
		return activeState == EMoraleBuffState.Active || activeState == EMoraleBuffState.TempActive;
	}

	// Token: 0x0601108E RID: 69774 RVA: 0x00426F92 File Offset: 0x00425192
	public void SetSelectState(bool isSelect)
	{
		this.IsSelect = isSelect;
	}

	// Token: 0x04008199 RID: 33177
	public int Id;

	// Token: 0x0400819A RID: 33178
	public MoraleLvPower Config;

	// Token: 0x0400819B RID: 33179
	public bool IsSelect;

	// Token: 0x0400819C RID: 33180
	public int StartStageLv;

	// Token: 0x0400819D RID: 33181
	public int EndStageLv;

	// Token: 0x0400819E RID: 33182
	public int Index;
}
