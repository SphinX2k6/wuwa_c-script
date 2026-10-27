using System;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.InstanceDungeon;

// Token: 0x020034A6 RID: 13478
public class UiInteractRouletteData
{
	// Token: 0x170028B8 RID: 10424
	// (get) Token: 0x0601D57F RID: 120191 RVA: 0x0082DD79 File Offset: 0x0082BF79
	public double DurationTime
	{
		get
		{
			return this.CloseTime - this.OpenTime;
		}
	}

	// Token: 0x0601D580 RID: 120192 RVA: 0x0082DD88 File Offset: 0x0082BF88
	public void TriggerOpen()
	{
		this.Reset();
		this.IsStart = true;
		this.OpenTime = Time.Instance.ServerTimeStamp;
		this.OldRound = this.GetWaveCount();
		this.UseSkillId = this.GetUseSkillId();
	}

	// Token: 0x0601D581 RID: 120193 RVA: 0x0082DDBF File Offset: 0x0082BFBF
	public void TriggerClose()
	{
		this.CloseTime = Time.Instance.ServerTimeStamp;
		this.NewRound = this.GetWaveCount();
		this.IsStart = false;
	}

	// Token: 0x0601D582 RID: 120194 RVA: 0x0082DDE4 File Offset: 0x0082BFE4
	public void Reset()
	{
		this.OpenTime = 0.0;
		this.CloseTime = 0.0;
		this.OldRound = 0;
		this.NewRound = 0;
		this.UseSkillId = 0L;
		this.IsStart = false;
	}

	// Token: 0x0601D583 RID: 120195 RVA: 0x0082DE24 File Offset: 0x0082C024
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

	// Token: 0x0601D584 RID: 120196 RVA: 0x0082DE74 File Offset: 0x0082C074
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

	// Token: 0x0400E732 RID: 59186
	private double OpenTime;

	// Token: 0x0400E733 RID: 59187
	private double CloseTime;

	// Token: 0x0400E734 RID: 59188
	public int OldRound;

	// Token: 0x0400E735 RID: 59189
	public int NewRound;

	// Token: 0x0400E736 RID: 59190
	public bool IsStart;

	// Token: 0x0400E737 RID: 59191
	public long UseSkillId;
}
