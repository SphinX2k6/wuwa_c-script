using System;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.InstanceDungeon;

// Token: 0x020034A3 RID: 13475
public class UiInteractChatData
{
	// Token: 0x170028B7 RID: 10423
	// (get) Token: 0x0601D56C RID: 120172 RVA: 0x0082D9B7 File Offset: 0x0082BBB7
	public double DurationTime
	{
		get
		{
			return this.CloseTime - this.OpenTime;
		}
	}

	// Token: 0x0601D56D RID: 120173 RVA: 0x0082D9C6 File Offset: 0x0082BBC6
	public void TriggerOpen()
	{
		this.Reset();
		this.IsStart = true;
		this.OpenTime = Time.Instance.ServerTimeStamp;
		this.OldRound = this.GetWaveCount();
		this.UseSkillId = this.GetUseSkillId();
	}

	// Token: 0x0601D56E RID: 120174 RVA: 0x0082D9FD File Offset: 0x0082BBFD
	public void TriggerClose()
	{
		this.CloseTime = Time.Instance.ServerTimeStamp;
		this.NewRound = this.GetWaveCount();
		this.IsStart = false;
	}

	// Token: 0x0601D56F RID: 120175 RVA: 0x0082DA22 File Offset: 0x0082BC22
	public void Reset()
	{
		this.OpenTime = 0.0;
		this.CloseTime = 0.0;
		this.OldRound = 0;
		this.NewRound = 0;
		this.UseSkillId = 0L;
		this.IsStart = false;
	}

	// Token: 0x0601D570 RID: 120176 RVA: 0x0082DA60 File Offset: 0x0082BC60
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

	// Token: 0x0601D571 RID: 120177 RVA: 0x0082DAB0 File Offset: 0x0082BCB0
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

	// Token: 0x0400E71D RID: 59165
	private double OpenTime;

	// Token: 0x0400E71E RID: 59166
	private double CloseTime;

	// Token: 0x0400E71F RID: 59167
	public int OldRound;

	// Token: 0x0400E720 RID: 59168
	public int NewRound;

	// Token: 0x0400E721 RID: 59169
	public bool IsStart;

	// Token: 0x0400E722 RID: 59170
	public long UseSkillId;
}
