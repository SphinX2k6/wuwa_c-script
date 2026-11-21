using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002870 RID: 10352
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleUiComponent : EntityComponent
{
	// Token: 0x0601A3EE RID: 107502 RVA: 0x00821629 File Offset: 0x0081F829
	protected override bool OnStart()
	{
		this.TagComp = base.Entity.GetComponent<VehicleTagComponent>();
		return true;
	}

	// Token: 0x0601A3EF RID: 107503 RVA: 0x00821640 File Offset: 0x0081F840
	protected override void OnActivate()
	{
		this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["载具.摩托.滑轨.能够跳跃上轨"], new BaseTagComponent.TTagSwitchedCallback(this.OnJumpTagChange));
		this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中"], new BaseTagComponent.TTagSwitchedCallback(this.OnAirTagChange));
	}

	// Token: 0x0601A3F0 RID: 107504 RVA: 0x0082168F File Offset: 0x0081F88F
	protected override bool OnEnd()
	{
		this.ClearAllTagTask();
		EventSystem.Instance.RemoveAllTargetUseKey(this);
		return true;
	}

	// Token: 0x0601A3F1 RID: 107505 RVA: 0x008216A4 File Offset: 0x0081F8A4
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

	// Token: 0x0601A3F2 RID: 107506 RVA: 0x008216F0 File Offset: 0x0081F8F0
	private void ClearAllTagTask()
	{
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			tagTask.EndTask();
		}
		this.TagTaskList.Clear();
	}

	// Token: 0x0601A3F3 RID: 107507 RVA: 0x0082174C File Offset: 0x0081F94C
	private void OnJumpTagChange(int tagId, bool tagExist)
	{
		this.SetPlayerTagEnable(GameplayTagDefine.EGameplayTagId["UI.摩托.键鼠显示子弹跳按键"], tagExist);
	}

	// Token: 0x0601A3F4 RID: 107508 RVA: 0x00821764 File Offset: 0x0081F964
	private void OnAirTagChange(int tagId, bool tagExist)
	{
		this.SetSelfTagEnable(GameplayTagDefine.EGameplayTagId["UI.摩托.可抬升"], tagExist);
		this.SetSelfTagEnable(GameplayTagDefine.EGameplayTagId["UI.摩托.可压低"], tagExist);
	}

	// Token: 0x0601A3F5 RID: 107509 RVA: 0x00821794 File Offset: 0x0081F994
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

	// Token: 0x0601A3F6 RID: 107510 RVA: 0x008217FC File Offset: 0x0081F9FC
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

	// Token: 0x0601A3F7 RID: 107511 RVA: 0x00821854 File Offset: 0x0081FA54
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleUiComponent motorcycleUiComponent = (MotorcycleUiComponent)componentTemplate;
		if (motorcycleUiComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		return motorcycleUiComponent.TagTaskList == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagTaskList), "TagTaskList");
	}

	// Token: 0x17002AF5 RID: 10997
	// (get) Token: 0x0601A3F8 RID: 107512 RVA: 0x008218C1 File Offset: 0x0081FAC1
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AF6 RID: 10998
	// (get) Token: 0x0601A3F9 RID: 107513 RVA: 0x008218C4 File Offset: 0x0081FAC4
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AF7 RID: 10999
	// (get) Token: 0x0601A3FA RID: 107514 RVA: 0x008218C7 File Offset: 0x0081FAC7
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E677 RID: 58999
	[Nullable(2)]
	private VehicleTagComponent TagComp;

	// Token: 0x0400E678 RID: 59000
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();
}
