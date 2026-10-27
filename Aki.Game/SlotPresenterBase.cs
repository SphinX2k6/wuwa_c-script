using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C12 RID: 7186
[NullableContext(1)]
[Nullable(0)]
public abstract class SlotPresenterBase<[Nullable(0)] T> : ISlotPresenter where T : FormationSlotBase
{
	// Token: 0x0600D775 RID: 55157
	protected abstract T CreateSlotView(int position, IFormationProvider provider);

	// Token: 0x0600D776 RID: 55158
	protected abstract FormationRoleDragItem CreateDragRoleItem();

	// Token: 0x0600D777 RID: 55159 RVA: 0x0031E548 File Offset: 0x0031C748
	protected virtual UniTask InitializeDragRoleItemAsync(ISlotPresenterCreateConfig config, FormationDragData dragData)
	{
		SlotPresenterBase<T>.<InitializeDragRoleItemAsync>d__4 <InitializeDragRoleItemAsync>d__;
		<InitializeDragRoleItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeDragRoleItemAsync>d__.<>4__this = this;
		<InitializeDragRoleItemAsync>d__.config = config;
		<InitializeDragRoleItemAsync>d__.dragData = dragData;
		<InitializeDragRoleItemAsync>d__.<>1__state = -1;
		<InitializeDragRoleItemAsync>d__.<>t__builder.Start<SlotPresenterBase<T>.<InitializeDragRoleItemAsync>d__4>(ref <InitializeDragRoleItemAsync>d__);
		return <InitializeDragRoleItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D778 RID: 55160
	protected abstract void DestroyItem(T item);

	// Token: 0x0600D779 RID: 55161 RVA: 0x0031E59B File Offset: 0x0031C79B
	public void Add(T item)
	{
		this.Items.Add(item);
	}

	// Token: 0x0600D77A RID: 55162 RVA: 0x0031E5AC File Offset: 0x0031C7AC
	[NullableContext(2)]
	public T GetByPosition(int position)
	{
		if (position <= 0 || position > this.Items.Count)
		{
			return default(T);
		}
		return this.Items[position - 1];
	}

	// Token: 0x0600D77B RID: 55163 RVA: 0x0031E5E3 File Offset: 0x0031C7E3
	public void Refresh(int position, IRoleSlotDisplayData data)
	{
		T t = this.GetByPosition(position);
		if (t == null)
		{
			return;
		}
		t.Refresh(data);
	}

	// Token: 0x0600D77C RID: 55164 RVA: 0x0031E5FC File Offset: 0x0031C7FC
	public void Reset(int position)
	{
		T t = this.GetByPosition(position);
		if (t == null)
		{
			return;
		}
		t.ResetRole();
	}

	// Token: 0x0600D77D RID: 55165 RVA: 0x0031E614 File Offset: 0x0031C814
	public void ResetAll()
	{
		foreach (T t in this.Items)
		{
			t.ResetRole();
		}
	}

	// Token: 0x0600D77E RID: 55166 RVA: 0x0031E66C File Offset: 0x0031C86C
	public UniTask CreateAllAsync(ISlotPresenterCreateConfig config)
	{
		SlotPresenterBase<T>.<CreateAllAsync>d__11 <CreateAllAsync>d__;
		<CreateAllAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllAsync>d__.<>4__this = this;
		<CreateAllAsync>d__.config = config;
		<CreateAllAsync>d__.<>1__state = -1;
		<CreateAllAsync>d__.<>t__builder.Start<SlotPresenterBase<T>.<CreateAllAsync>d__11>(ref <CreateAllAsync>d__);
		return <CreateAllAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D77F RID: 55167 RVA: 0x0031E6B7 File Offset: 0x0031C8B7
	public void ActivateDragData()
	{
		if (this.DragData != null)
		{
			FormationViewDragController.InitDragData(this.DragData);
		}
	}

	// Token: 0x0600D780 RID: 55168 RVA: 0x0031E6CC File Offset: 0x0031C8CC
	public void BindDragHandlers(T slot)
	{
		FormationSlotBase formationSlotBase = slot;
		Action<ULGUIPointerEventData, int, int, int> onPointDown;
		if ((onPointDown = SlotPresenterBase<T>.<>O.<0>__OnFormationRoleViewPointDown) == null)
		{
			onPointDown = (SlotPresenterBase<T>.<>O.<0>__OnFormationRoleViewPointDown = new Action<ULGUIPointerEventData, int, int, int>(FormationViewDragController.OnFormationRoleViewPointDown));
		}
		formationSlotBase.OnPointDown = onPointDown;
		FormationSlotBase formationSlotBase2 = slot;
		Action<UUIItem, int, int, int> onGamePadDown;
		if ((onGamePadDown = SlotPresenterBase<T>.<>O.<1>__OnFormationRoleViewGamePadDown) == null)
		{
			onGamePadDown = (SlotPresenterBase<T>.<>O.<1>__OnFormationRoleViewGamePadDown = new Action<UUIItem, int, int, int>(FormationViewDragController.OnFormationRoleViewGamePadDown));
		}
		formationSlotBase2.OnGamePadDown = onGamePadDown;
		FormationSlotBase formationSlotBase3 = slot;
		Func<bool> canStartDrag;
		if ((canStartDrag = SlotPresenterBase<T>.<>O.<2>__CanFormationRoleViewStartDrag) == null)
		{
			canStartDrag = (SlotPresenterBase<T>.<>O.<2>__CanFormationRoleViewStartDrag = new Func<bool>(FormationViewDragController.CanFormationRoleViewStartDrag));
		}
		formationSlotBase3.CanStartDrag = canStartDrag;
		FormationSlotBase formationSlotBase4 = slot;
		Action onDragStart;
		if ((onDragStart = SlotPresenterBase<T>.<>O.<3>__OnFormationRoleViewStartDrag) == null)
		{
			onDragStart = (SlotPresenterBase<T>.<>O.<3>__OnFormationRoleViewStartDrag = new Action(FormationViewDragController.OnFormationRoleViewStartDrag));
		}
		formationSlotBase4.OnDragStart = onDragStart;
		FormationSlotBase formationSlotBase5 = slot;
		Action<ULGUIPointerEventData> onDragMove;
		if ((onDragMove = SlotPresenterBase<T>.<>O.<4>__OnFormationRoleViewMoveDrag) == null)
		{
			onDragMove = (SlotPresenterBase<T>.<>O.<4>__OnFormationRoleViewMoveDrag = new Action<ULGUIPointerEventData>(FormationViewDragController.OnFormationRoleViewMoveDrag));
		}
		formationSlotBase5.OnDragMove = onDragMove;
		FormationSlotBase formationSlotBase6 = slot;
		Action<bool> onDragEnd;
		if ((onDragEnd = SlotPresenterBase<T>.<>O.<5>__OnFormationRoleViewEndDrag) == null)
		{
			onDragEnd = (SlotPresenterBase<T>.<>O.<5>__OnFormationRoleViewEndDrag = new Action<bool>(FormationViewDragController.OnFormationRoleViewEndDrag));
		}
		formationSlotBase6.OnDragEnd = onDragEnd;
	}

	// Token: 0x0600D781 RID: 55169 RVA: 0x0031E7C0 File Offset: 0x0031C9C0
	public virtual void DestroyAll()
	{
		foreach (T item in this.Items)
		{
			this.DestroyItem(item);
		}
		this.Items.Clear();
		if (this.DragData != null)
		{
			FormationViewDragController.ClearDragData(this.DragData);
			this.DragData = null;
		}
	}

	// Token: 0x0600D782 RID: 55170 RVA: 0x0031E838 File Offset: 0x0031CA38
	public void OnTick(float delta)
	{
		foreach (T t in this.Items)
		{
			t.OnTick(delta);
		}
	}

	// Token: 0x0600D783 RID: 55171 RVA: 0x0031E890 File Offset: 0x0031CA90
	public virtual void OnHandleLoadScene()
	{
	}

	// Token: 0x0600D784 RID: 55172 RVA: 0x0031E892 File Offset: 0x0031CA92
	public virtual void OnHandleReleaseScene()
	{
	}

	// Token: 0x04006276 RID: 25206
	protected readonly List<T> Items = new List<T>();

	// Token: 0x04006277 RID: 25207
	[Nullable(2)]
	protected FormationDragData DragData;

	// Token: 0x020081CB RID: 33227
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402A5D0 RID: 173520
		[Nullable(new byte[]
		{
			0,
			2
		})]
		public static Action<ULGUIPointerEventData, int, int, int> <0>__OnFormationRoleViewPointDown;

		// Token: 0x0402A5D1 RID: 173521
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<UUIItem, int, int, int> <1>__OnFormationRoleViewGamePadDown;

		// Token: 0x0402A5D2 RID: 173522
		[Nullable(0)]
		public static Func<bool> <2>__CanFormationRoleViewStartDrag;

		// Token: 0x0402A5D3 RID: 173523
		[Nullable(0)]
		public static Action <3>__OnFormationRoleViewStartDrag;

		// Token: 0x0402A5D4 RID: 173524
		[Nullable(new byte[]
		{
			0,
			2
		})]
		public static Action<ULGUIPointerEventData> <4>__OnFormationRoleViewMoveDrag;

		// Token: 0x0402A5D5 RID: 173525
		[Nullable(0)]
		public static Action<bool> <5>__OnFormationRoleViewEndDrag;
	}
}
