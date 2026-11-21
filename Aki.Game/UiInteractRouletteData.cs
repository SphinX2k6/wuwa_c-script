using System;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.InstanceDungeon;

// Token: 0x02002A1A RID: 10778
public class UiInteractRouletteData
{
	// Token: 0x17002C50 RID: 11344
	// (get) Token: 0x0601B27C RID: 111228 RVA: 0x00854F25 File Offset: 0x00853125
	public double DurationTime
	{
		get
		{
			return this.CloseTime - this.OpenTime;
		}
	}

	// Token: 0x0601B27D RID: 111229 RVA: 0x00854F34 File Offset: 0x00853134
	public void TriggerOpen()
	{
		this.Reset();
		this.IsStart = true;
		this.OpenTime = Time.Instance.ServerTimeStamp;
		this.OldRound = this.GetWaveCount();
		this.UseSkillId = this.GetUseSkillId();
	}

	// Token: 0x0601B27E RID: 111230 RVA: 0x00854F6B File Offset: 0x0085316B
	public void TriggerClose()
	{
		this.CloseTime = Time.Instance.ServerTimeStamp;
		this.NewRound = this.GetWaveCount();
		this.IsStart = false;
	}

	// Token: 0x0601B27F RID: 111231 RVA: 0x00854F90 File Offset: 0x00853190
	public void Reset()
	{
		this.OpenTime = 0.0;
		this.CloseTime = 0.0;
		this.OldRound = 0;
		this.NewRound = 0;
		this.UseSkillId = 0L;
		this.IsStart = false;
	}

	// Token: 0x0601B280 RID: 111232 RVA: 0x00854FD0 File Offset: 0x008531D0
	private int GetWaveCount()
	{
		InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
		if (((instanceDungeonInfo != null) ? instanceDungeonInfo.Tree : null) == null)
		{
			return 0;
		}
		VarDefinePb treeVarByKey = instanceDungeonInfo.Tree.GetTreeVarByKey(EGradingSystemVarType.Wave.ToEnumString());
		if (treeVarByKey == null)
		{
			return 0;
		}
		return (int)MathUtils.Instance.LongToNumber(treeVarByKey.Int);
	}

	// Token: 0x0601B281 RID: 111233 RVA: 0x00855020 File Offset: 0x00853220
	private long GetUseSkillId()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		BaseSkillComponent baseSkillComponent;
		if (getCurrentEntity == null)
		{
			baseSkillComponent = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			baseSkillComponent = ((entity != null) ? entity.GetComponent<BaseSkillComponent>() : null);
		}
		BaseSkillComponent baseSkillComponent2 = baseSkillComponent;
		if (((baseSkillComponent2 != null) ? baseSkillComponent2.CurrentSkill : null) == null)
		{
			return 0L;
		}
		return (long)baseSkillComponent2.CurrentSkill.SkillId;
	}

	// Token: 0x0400EBE6 RID: 60390
	private double OpenTime;

	// Token: 0x0400EBE7 RID: 60391
	private double CloseTime;

	// Token: 0x0400EBE8 RID: 60392
	public int OldRound;

	// Token: 0x0400EBE9 RID: 60393
	public int NewRound;

	// Token: 0x0400EBEA RID: 60394
	public bool IsStart;

	// Token: 0x0400EBEB RID: 60395
	public long UseSkillId;
}
