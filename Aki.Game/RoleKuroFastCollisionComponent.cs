using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026B9 RID: 9913
[NullableContext(1)]
[Nullable(0)]
public class RoleKuroFastCollisionComponent : BaseKuroFastCollisionComponent
{
	// Token: 0x06018D80 RID: 101760 RVA: 0x0078ADB8 File Offset: 0x00788FB8
	public bool CanDodge()
	{
		return this.HasDodgeTag && !this.HasUltimateDodgeTag;
	}

	// Token: 0x06018D81 RID: 101761 RVA: 0x0078ADCD File Offset: 0x00788FCD
	protected override bool OnStart()
	{
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		return base.OnStart();
	}

	// Token: 0x06018D82 RID: 101762 RVA: 0x0078ADE8 File Offset: 0x00788FE8
	protected override void OnStartKuroFastCollision()
	{
		if (this.IsListening)
		{
			return;
		}
		this.IsListening = true;
		if (this.TagComp == null)
		{
			return;
		}
		this.HasDodgeTag = this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.无敌.角色闪避"]);
		this.HasUltimateDodgeTag = this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.极限闪避"]);
		this.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.无敌.角色闪避"], new BaseTagComponent.TTagSwitchedCallback(this.OnDodgeTagChanged));
		this.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.极限闪避"], new BaseTagComponent.TTagSwitchedCallback(this.OnUltimateDodgeTagChanged));
		if (this.CanDodge())
		{
			this.UpdateDodgeState();
		}
	}

	// Token: 0x06018D83 RID: 101763 RVA: 0x0078AE9E File Offset: 0x0078909E
	protected override void OnStopKuroFastCollision()
	{
		if (!this.IsListening)
		{
			return;
		}
		this.IsListening = false;
		this.ClearAllTagCountChangedCallback();
	}

	// Token: 0x06018D84 RID: 101764 RVA: 0x0078AEB6 File Offset: 0x007890B6
	private void OnDodgeTagChanged(int tagId, bool tagExist)
	{
		this.HasDodgeTag = tagExist;
		this.UpdateDodgeState();
	}

	// Token: 0x06018D85 RID: 101765 RVA: 0x0078AEC5 File Offset: 0x007890C5
	private void OnUltimateDodgeTagChanged(int tagId, bool tagExist)
	{
		this.HasUltimateDodgeTag = tagExist;
		this.UpdateDodgeState();
	}

	// Token: 0x06018D86 RID: 101766 RVA: 0x0078AED4 File Offset: 0x007890D4
	private void ListenForTagAddOrRemoveChanged(int tagId, BaseTagComponent.TTagSwitchedCallback onTagChange)
	{
		if (this.TagComp == null)
		{
			return;
		}
		ITagTask tagTask = this.TagComp.ListenForTagAddOrRemove(new int?(tagId), onTagChange, null);
		if (tagTask != null)
		{
			this.TagTaskList.Add(tagTask);
		}
	}

	// Token: 0x06018D87 RID: 101767 RVA: 0x0078AF10 File Offset: 0x00789110
	private void ClearAllTagCountChangedCallback()
	{
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			tagTask.EndTask();
		}
		this.TagTaskList.Clear();
	}

	// Token: 0x06018D88 RID: 101768 RVA: 0x0078AF6C File Offset: 0x0078916C
	private void UpdateDodgeState()
	{
		UBulletHitWorldEntityManager bulletHitWorldEntityManager = BulletModel.Instance.GetBulletHitWorldEntityManager();
		if (bulletHitWorldEntityManager == null)
		{
			return;
		}
		bulletHitWorldEntityManager.SetEntityCanDodge(base.Entity.Id, this.CanDodge());
	}

	// Token: 0x06018D89 RID: 101769 RVA: 0x0078AFA0 File Offset: 0x007891A0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleKuroFastCollisionComponent roleKuroFastCollisionComponent = (RoleKuroFastCollisionComponent)componentTemplate;
		if (roleKuroFastCollisionComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		this.HasDodgeTag = roleKuroFastCollisionComponent.HasDodgeTag;
		this.HasUltimateDodgeTag = roleKuroFastCollisionComponent.HasUltimateDodgeTag;
		if (roleKuroFastCollisionComponent.TagTaskList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagTaskList), "TagTaskList"))
		{
			return false;
		}
		this.IsListening = roleKuroFastCollisionComponent.IsListening;
		return true;
	}

	// Token: 0x17002785 RID: 10117
	// (get) Token: 0x06018D8A RID: 101770 RVA: 0x0078B031 File Offset: 0x00789231
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002786 RID: 10118
	// (get) Token: 0x06018D8B RID: 101771 RVA: 0x0078B034 File Offset: 0x00789234
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D7A3 RID: 55203
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x0400D7A4 RID: 55204
	private bool HasDodgeTag;

	// Token: 0x0400D7A5 RID: 55205
	private bool HasUltimateDodgeTag;

	// Token: 0x0400D7A6 RID: 55206
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x0400D7A7 RID: 55207
	private bool IsListening;
}
