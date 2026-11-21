using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010D3 RID: 4307
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SlotPresenter3D : SlotPresenterBase<FormationRoleItem>
{
	// Token: 0x170011D8 RID: 4568
	// (get) Token: 0x0600AB9F RID: 43935 RVA: 0x00329C1F File Offset: 0x00327E1F
	public List<FormationRoleItem> RoleItems
	{
		get
		{
			return this.Items;
		}
	}

	// Token: 0x0600ABA0 RID: 43936 RVA: 0x00329C27 File Offset: 0x00327E27
	protected override FormationRoleItem CreateSlotView(int position, IFormationProvider provider)
	{
		return new FormationRoleItem(position, provider);
	}

	// Token: 0x0600ABA1 RID: 43937 RVA: 0x00329C30 File Offset: 0x00327E30
	[PreserveBaseOverrides]
	protected new virtual FormationRoleDragAvatarItem CreateDragRoleItem()
	{
		return new FormationRoleDragAvatarItem();
	}

	// Token: 0x0600ABA2 RID: 43938 RVA: 0x00329C38 File Offset: 0x00327E38
	protected override UniTask InitializeDragRoleItemAsync(ISlotPresenterCreateConfig config, FormationDragData dragData)
	{
		UUIItem dragRoleItemMount = config.GetItem(config.DragRoleItemKey);
		dragData.PrepareDragVisuals = (() => this.EnsureDragVisualsAsync(dragData, dragRoleItemMount));
		return UniTask.CompletedTask;
	}

	// Token: 0x0600ABA3 RID: 43939 RVA: 0x00329C8C File Offset: 0x00327E8C
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

	// Token: 0x0600ABA4 RID: 43940 RVA: 0x00329CE0 File Offset: 0x00327EE0
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

	// Token: 0x0600ABA5 RID: 43941 RVA: 0x00329D34 File Offset: 0x00327F34
	private UniTask CreateSlotDragAvatarItemsAsync()
	{
		SlotPresenter3D.<CreateSlotDragAvatarItemsAsync>d__9 <CreateSlotDragAvatarItemsAsync>d__;
		<CreateSlotDragAvatarItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSlotDragAvatarItemsAsync>d__.<>4__this = this;
		<CreateSlotDragAvatarItemsAsync>d__.<>1__state = -1;
		<CreateSlotDragAvatarItemsAsync>d__.<>t__builder.Start<SlotPresenter3D.<CreateSlotDragAvatarItemsAsync>d__9>(ref <CreateSlotDragAvatarItemsAsync>d__);
		return <CreateSlotDragAvatarItemsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600ABA6 RID: 43942 RVA: 0x00329D77 File Offset: 0x00327F77
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

	// Token: 0x0600ABA7 RID: 43943 RVA: 0x00329D98 File Offset: 0x00327F98
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

	// Token: 0x0600ABA8 RID: 43944 RVA: 0x00329DC5 File Offset: 0x00327FC5
	protected override void DestroyItem(FormationRoleItem item)
	{
		item.DestroyDragAvatarItem();
		item.ResetRole();
	}

	// Token: 0x0600ABA9 RID: 43945 RVA: 0x00329DD4 File Offset: 0x00327FD4
	public override void OnHandleLoadScene()
	{
		foreach (FormationRoleItem formationRoleItem in this.Items)
		{
			formationRoleItem.OnHandleLoadScene();
		}
	}

	// Token: 0x0600ABAA RID: 43946 RVA: 0x00329E24 File Offset: 0x00328024
	public override void OnHandleReleaseScene()
	{
		foreach (FormationRoleItem formationRoleItem in this.Items)
		{
			formationRoleItem.OnHandleReleaseScene();
		}
	}

	// Token: 0x0600ABAB RID: 43947 RVA: 0x00329E74 File Offset: 0x00328074
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

	// Token: 0x0400634A RID: 25418
	[Nullable(2)]
	private FormationRoleDragAvatarItem DragRoleItem;

	// Token: 0x0400634B RID: 25419
	private UniTask? DragVisualsCreatePromise;
}
