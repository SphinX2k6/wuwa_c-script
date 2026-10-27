using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020032FE RID: 13054
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleUiComponent : EntityComponent
{
	// Token: 0x0601C700 RID: 116480 RVA: 0x007FB4E5 File Offset: 0x007F96E5
	protected override bool OnStart()
	{
		this.TagComp = base.Entity.GetComponent<VehicleTagComponent>();
		return true;
	}

	// Token: 0x0601C701 RID: 116481 RVA: 0x007FB4FC File Offset: 0x007F96FC
	protected override void OnActivate()
	{
		this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["载具.摩托.滑轨.能够跳跃上轨"], new BaseTagComponent.TTagSwitchedCallback(this.OnJumpTagChange));
		this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中"], new BaseTagComponent.TTagSwitchedCallback(this.OnAirTagChange));
	}

	// Token: 0x0601C702 RID: 116482 RVA: 0x007FB54B File Offset: 0x007F974B
	protected override bool OnEnd()
	{
		this.ClearAllTagTask();
		EventSystem.Instance.RemoveAllTargetUseKey(this);
		return true;
	}

	// Token: 0x0601C703 RID: 116483 RVA: 0x007FB560 File Offset: 0x007F9760
	private void ListenForTagAddOrRemove(int tagId, BaseTagComponent.TTagSwitchedCallback onTagChange)
	{
		if (this.TagComp == null)
		{
			return;
		}
		ITagTask item = this.TagComp.ListenForTagAddOrRemove(new int?(tagId), onTagChange, null);
		this.TagTaskList.Add(item);
		if (this.TagComp.HasTag(tagId))
		{
			onTagChange(tagId, true);
		}
	}

	// Token: 0x0601C704 RID: 116484 RVA: 0x007FB5AC File Offset: 0x007F97AC
	private void ClearAllTagTask()
	{
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			tagTask.EndTask();
		}
		this.TagTaskList.Clear();
	}

	// Token: 0x0601C705 RID: 116485 RVA: 0x007FB608 File Offset: 0x007F9808
	private void OnJumpTagChange(int tagId, bool tagExist)
	{
		this.SetPlayerTagEnable(GameplayTagDefine.EGameplayTagId["UI.摩托.键鼠显示子弹跳按键"], tagExist);
	}

	// Token: 0x0601C706 RID: 116486 RVA: 0x007FB620 File Offset: 0x007F9820
	private void OnAirTagChange(int tagId, bool tagExist)
	{
		this.SetSelfTagEnable(GameplayTagDefine.EGameplayTagId["UI.摩托.可抬升"], tagExist);
		this.SetSelfTagEnable(GameplayTagDefine.EGameplayTagId["UI.摩托.可压低"], tagExist);
	}

	// Token: 0x0601C707 RID: 116487 RVA: 0x007FB650 File Offset: 0x007F9850
	private void SetPlayerTagEnable(int tagId, bool enable)
	{
		int playerId = CreatureModel.Instance.GetPlayerId();
		if (!FormationDataController.Instance.IsPlayerExist(playerId))
		{
			return;
		}
		bool flag = FormationDataController.Instance.HasPlayerTag(playerId, tagId, true);
		if (enable && !flag)
		{
			FormationDataController.Instance.AddPlayerTag(playerId, new int?(tagId));
			return;
		}
		if (!enable && flag)
		{
			FormationDataController.Instance.RemovePlayerTag(playerId, new int?(tagId));
		}
	}

	// Token: 0x0601C708 RID: 116488 RVA: 0x007FB6B8 File Offset: 0x007F98B8
	private void SetSelfTagEnable(int tagId, bool enable)
	{
		if (this.TagComp == null)
		{
			return;
		}
		bool flag = this.TagComp.HasTag(tagId);
		if (enable && !flag)
		{
			this.TagComp.AddTag(new int?(tagId));
			return;
		}
		if (!enable && flag)
		{
			this.TagComp.RemoveTag(new int?(tagId));
		}
	}

	// Token: 0x0601C709 RID: 116489 RVA: 0x007FB710 File Offset: 0x007F9910
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleUiComponent motorcycleUiComponent = (MotorcycleUiComponent)componentTemplate;
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (motorcycleUiComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		return !base.CanResetComponentProperty("TagTaskList") || motorcycleUiComponent.TagTaskList == null || base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.TagTaskList), "TagTaskList");
	}

	// Token: 0x0400E1CC RID: 57804
	[Nullable(2)]
	private VehicleTagComponent TagComp;

	// Token: 0x0400E1CD RID: 57805
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();
}
