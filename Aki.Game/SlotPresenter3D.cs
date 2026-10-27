using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C14 RID: 7188
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SlotPresenter3D : SlotPresenterBase<FormationRoleItem>
{
	// Token: 0x170011B2 RID: 4530
	// (get) Token: 0x0600D78B RID: 55179 RVA: 0x0031E8CF File Offset: 0x0031CACF
	public List<FormationRoleItem> RoleItems
	{
		get
		{
			return this.Items;
		}
	}

	// Token: 0x0600D78C RID: 55180 RVA: 0x0031E8D7 File Offset: 0x0031CAD7
	protected override FormationRoleItem CreateSlotView(int position, IFormationProvider provider)
	{
		return new FormationRoleItem(position, provider);
	}

	// Token: 0x0600D78D RID: 55181 RVA: 0x0031E8E0 File Offset: 0x0031CAE0
	[PreserveBaseOverrides]
	protected new virtual FormationRoleDragAvatarItem CreateDragRoleItem()
	{
		return new FormationRoleDragAvatarItem();
	}

	// Token: 0x0600D78E RID: 55182 RVA: 0x0031E8E8 File Offset: 0x0031CAE8
	protected override UniTask InitializeDragRoleItemAsync(ISlotPresenterCreateConfig config, FormationDragData dragData)
	{
		UUIItem dragRoleItemMount = config.GetItem(config.DragRoleItemKey);
		dragData.PrepareDragVisuals = (() => this.EnsureDragVisualsAsync(dragData, dragRoleItemMount));
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D78F RID: 55183 RVA: 0x0031E93C File Offset: 0x0031CB3C
	private UniTask EnsureDragVisualsAsync(FormationDragData dragData, UUIItem mount)
	{
		SlotPresenter3D.<EnsureDragVisualsAsync>d__7 <EnsureDragVisualsAsync>d__;
		<EnsureDragVisualsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnsureDragVisualsAsync>d__.<>4__this = this;
		<EnsureDragVisualsAsync>d__.dragData = dragData;
		<EnsureDragVisualsAsync>d__.mount = mount;
		<EnsureDragVisualsAsync>d__.<>1__state = -1;
		<EnsureDragVisualsAsync>d__.<>t__builder.Start<SlotPresenter3D.<EnsureDragVisualsAsync>d__7>(ref <EnsureDragVisualsAsync>d__);
		return <EnsureDragVisualsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D790 RID: 55184 RVA: 0x0031E990 File Offset: 0x0031CB90
	private UniTask CreateDragVisualsAsync(FormationDragData dragData, UUIItem mount)
	{
		SlotPresenter3D.<CreateDragVisualsAsync>d__8 <CreateDragVisualsAsync>d__;
		<CreateDragVisualsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDragVisualsAsync>d__.<>4__this = this;
		<CreateDragVisualsAsync>d__.dragData = dragData;
		<CreateDragVisualsAsync>d__.mount = mount;
		<CreateDragVisualsAsync>d__.<>1__state = -1;
		<CreateDragVisualsAsync>d__.<>t__builder.Start<SlotPresenter3D.<CreateDragVisualsAsync>d__8>(ref <CreateDragVisualsAsync>d__);
		return <CreateDragVisualsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D791 RID: 55185 RVA: 0x0031E9E4 File Offset: 0x0031CBE4
	private UniTask CreateSlotDragAvatarItemsAsync()
	{
		SlotPresenter3D.<CreateSlotDragAvatarItemsAsync>d__9 <CreateSlotDragAvatarItemsAsync>d__;
		<CreateSlotDragAvatarItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSlotDragAvatarItemsAsync>d__.<>4__this = this;
		<CreateSlotDragAvatarItemsAsync>d__.<>1__state = -1;
		<CreateSlotDragAvatarItemsAsync>d__.<>t__builder.Start<SlotPresenter3D.<CreateSlotDragAvatarItemsAsync>d__9>(ref <CreateSlotDragAvatarItemsAsync>d__);
		return <CreateSlotDragAvatarItemsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D792 RID: 55186 RVA: 0x0031EA27 File Offset: 0x0031CC27
	private void DestroyDragRoleItem(FormationRoleDragAvatarItem item)
	{
		if (!item.IsDestroyOrDestroying)
		{
			item.Destroy(null);
		}
		if (this.DragRoleItem == item)
		{
			this.DragRoleItem = null;
		}
	}

	// Token: 0x0600D793 RID: 55187 RVA: 0x0031EA48 File Offset: 0x0031CC48
	public override void DestroyAll()
	{
		FormationRoleDragAvatarItem dragRoleItem = this.DragRoleItem;
		if (dragRoleItem != null)
		{
			dragRoleItem.Destroy(null);
		}
		this.DragRoleItem = null;
		this.DragVisualsCreatePromise = null;
		base.DestroyAll();
	}

	// Token: 0x0600D794 RID: 55188 RVA: 0x0031EA75 File Offset: 0x0031CC75
	protected override void DestroyItem(FormationRoleItem item)
	{
		item.DestroyDragAvatarItem();
		item.ResetRole();
	}

	// Token: 0x0600D795 RID: 55189 RVA: 0x0031EA84 File Offset: 0x0031CC84
	public override void OnHandleLoadScene()
	{
		foreach (FormationRoleItem formationRoleItem in this.Items)
		{
			formationRoleItem.OnHandleLoadScene();
		}
	}

	// Token: 0x0600D796 RID: 55190 RVA: 0x0031EAD4 File Offset: 0x0031CCD4
	public override void OnHandleReleaseScene()
	{
		foreach (FormationRoleItem formationRoleItem in this.Items)
		{
			formationRoleItem.OnHandleReleaseScene();
		}
	}

	// Token: 0x0600D797 RID: 55191 RVA: 0x0031EB24 File Offset: 0x0031CD24
	[NullableContext(0)]
	public UniTask<long?> RefreshAndWaitModelLoaded(int position, [Nullable(1)] IRoleSlotDisplayData data)
	{
		FormationRoleItem byPosition = base.GetByPosition(position);
		if (byPosition == null)
		{
			return UniTask.FromResult<long?>(null);
		}
		return byPosition.RefreshAndWaitModelLoaded(data);
	}

	// Token: 0x04006278 RID: 25208
	[Nullable(2)]
	private FormationRoleDragAvatarItem DragRoleItem;

	// Token: 0x04006279 RID: 25209
	private UniTask? DragVisualsCreatePromise;
}
