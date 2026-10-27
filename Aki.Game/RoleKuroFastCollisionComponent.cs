using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200314C RID: 12620
[NullableContext(1)]
[Nullable(0)]
public class RoleKuroFastCollisionComponent : BaseKuroFastCollisionComponent
{
	// Token: 0x0601B27D RID: 111229 RVA: 0x007633BC File Offset: 0x007615BC
	public bool CanDodge()
	{
		return this.HasDodgeTag && !this.HasUltimateDodgeTag;
	}

	// Token: 0x0601B27E RID: 111230 RVA: 0x007633D1 File Offset: 0x007615D1
	protected override bool OnStart()
	{
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		return base.OnStart();
	}

	// Token: 0x0601B27F RID: 111231 RVA: 0x007633EC File Offset: 0x007615EC
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

	// Token: 0x0601B280 RID: 111232 RVA: 0x007634A2 File Offset: 0x007616A2
	protected override void OnStopKuroFastCollision()
	{
		if (!this.IsListening)
		{
			return;
		}
		this.IsListening = false;
		this.ClearAllTagCountChangedCallback();
	}

	// Token: 0x0601B281 RID: 111233 RVA: 0x007634BA File Offset: 0x007616BA
	private void OnDodgeTagChanged(int tagId, bool tagExist)
	{
		this.HasDodgeTag = tagExist;
		this.UpdateDodgeState();
	}

	// Token: 0x0601B282 RID: 111234 RVA: 0x007634C9 File Offset: 0x007616C9
	private void OnUltimateDodgeTagChanged(int tagId, bool tagExist)
	{
		this.HasUltimateDodgeTag = tagExist;
		this.UpdateDodgeState();
	}

	// Token: 0x0601B283 RID: 111235 RVA: 0x007634D8 File Offset: 0x007616D8
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

	// Token: 0x0601B284 RID: 111236 RVA: 0x00763514 File Offset: 0x00761714
	private void ClearAllTagCountChangedCallback()
	{
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			tagTask.EndTask();
		}
		this.TagTaskList.Clear();
	}

	// Token: 0x0601B285 RID: 111237 RVA: 0x00763570 File Offset: 0x00761770
	private void UpdateDodgeState()
	{
		UBulletHitWorldEntityManager bulletHitWorldEntityManager = BulletModel.Instance.GetBulletHitWorldEntityManager();
		if (bulletHitWorldEntityManager == null)
		{
			return;
		}
		bulletHitWorldEntityManager.SetEntityCanDodge(base.Entity.Id, this.CanDodge());
	}

	// Token: 0x0601B286 RID: 111238 RVA: 0x007635A4 File Offset: 0x007617A4
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleKuroFastCollisionComponent roleKuroFastCollisionComponent = (RoleKuroFastCollisionComponent)componentTemplate;
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (roleKuroFastCollisionComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HasDodgeTag"))
		{
			this.HasDodgeTag = roleKuroFastCollisionComponent.HasDodgeTag;
		}
		if (base.CanResetComponentProperty("HasUltimateDodgeTag"))
		{
			this.HasUltimateDodgeTag = roleKuroFastCollisionComponent.HasUltimateDodgeTag;
		}
		if (base.CanResetComponentProperty("TagTaskList") && roleKuroFastCollisionComponent.TagTaskList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.TagTaskList), "TagTaskList"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IsListening"))
		{
			this.IsListening = roleKuroFastCollisionComponent.IsListening;
		}
		return true;
	}

	// Token: 0x0400D340 RID: 54080
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x0400D341 RID: 54081
	private bool HasDodgeTag;

	// Token: 0x0400D342 RID: 54082
	private bool HasUltimateDodgeTag;

	// Token: 0x0400D343 RID: 54083
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x0400D344 RID: 54084
	private bool IsListening;
}
