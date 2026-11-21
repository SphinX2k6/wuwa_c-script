using System;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.InstanceDungeon;

// Token: 0x02002A17 RID: 10775
public class UiInteractChatData
{
	// Token: 0x17002C4F RID: 11343
	// (get) Token: 0x0601B269 RID: 111209 RVA: 0x00854B63 File Offset: 0x00852D63
	public double DurationTime
	{
		get
		{
			return this.CloseTime - this.OpenTime;
		}
	}

	// Token: 0x0601B26A RID: 111210 RVA: 0x00854B72 File Offset: 0x00852D72
	public void TriggerOpen()
	{
		this.Reset();
		this.IsStart = true;
		this.OpenTime = Time.Instance.ServerTimeStamp;
		this.OldRound = this.GetWaveCount();
		this.UseSkillId = this.GetUseSkillId();
	}

	// Token: 0x0601B26B RID: 111211 RVA: 0x00854BA9 File Offset: 0x00852DA9
	public void TriggerClose()
	{
		this.CloseTime = Time.Instance.ServerTimeStamp;
		this.NewRound = this.GetWaveCount();
		this.IsStart = false;
	}

	// Token: 0x0601B26C RID: 111212 RVA: 0x00854BCE File Offset: 0x00852DCE
	public void Reset()
	{
		this.OpenTime = 0.0;
		this.CloseTime = 0.0;
		this.OldRound = 0;
		this.NewRound = 0;
		this.UseSkillId = 0L;
		this.IsStart = false;
	}

	// Token: 0x0601B26D RID: 111213 RVA: 0x00854C0C File Offset: 0x00852E0C
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

	// Token: 0x0601B26E RID: 111214 RVA: 0x00854C5C File Offset: 0x00852E5C
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

	// Token: 0x0400EBD1 RID: 60369
	private double OpenTime;

	// Token: 0x0400EBD2 RID: 60370
	private double CloseTime;

	// Token: 0x0400EBD3 RID: 60371
	public int OldRound;

	// Token: 0x0400EBD4 RID: 60372
	public int NewRound;

	// Token: 0x0400EBD5 RID: 60373
	public bool IsStart;

	// Token: 0x0400EBD6 RID: 60374
	public long UseSkillId;
}
