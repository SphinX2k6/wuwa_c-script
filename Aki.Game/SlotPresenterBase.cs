using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010D1 RID: 4305
[NullableContext(1)]
[Nullable(0)]
public abstract class SlotPresenterBase<[Nullable(0)] T> : ISlotPresenter where T : FormationSlotBase
{
	// Token: 0x0600AB89 RID: 43913
	protected abstract T CreateSlotView(int position, IFormationProvider provider);

	// Token: 0x0600AB8A RID: 43914
	protected abstract FormationRoleDragItem CreateDragRoleItem();

	// Token: 0x0600AB8B RID: 43915 RVA: 0x00329898 File Offset: 0x00327A98
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

	// Token: 0x0600AB8C RID: 43916
	protected abstract void DestroyItem(T item);

	// Token: 0x0600AB8D RID: 43917 RVA: 0x003298EB File Offset: 0x00327AEB
	public void Add(T item)
	{
		this.Items.Add(item);
	}

	// Token: 0x0600AB8E RID: 43918 RVA: 0x003298FC File Offset: 0x00327AFC
	[NullableContext(2)]
	public T GetByPosition(int position)
	{
		if (position <= 0 || position > this.Items.Count)
		{
			return default(T);
		}
		return this.Items[position - 1];
	}

	// Token: 0x0600AB8F RID: 43919 RVA: 0x00329933 File Offset: 0x00327B33
	public void Refresh(int position, IRoleSlotDisplayData data)
	{
		T t = this.GetByPosition(position);
		if (t == null)
		{
			return;
		}
		t.Refresh(data);
	}

	// Token: 0x0600AB90 RID: 43920 RVA: 0x0032994C File Offset: 0x00327B4C
	public void Reset(int position)
	{
		T t = this.GetByPosition(position);
		if (t == null)
		{
			return;
		}
		t.ResetRole();
	}

	// Token: 0x0600AB91 RID: 43921 RVA: 0x00329964 File Offset: 0x00327B64
	public void ResetAll()
	{
		foreach (T t in this.Items)
		{
			t.ResetRole();
		}
	}

	// Token: 0x0600AB92 RID: 43922 RVA: 0x003299BC File Offset: 0x00327BBC
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

	// Token: 0x0600AB93 RID: 43923 RVA: 0x00329A07 File Offset: 0x00327C07
	public void ActivateDragData()
	{
		if (this.DragData != null)
		{
			FormationViewDragController.InitDragData(this.DragData);
		}
	}

	// Token: 0x0600AB94 RID: 43924 RVA: 0x00329A1C File Offset: 0x00327C1C
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

	// Token: 0x0600AB95 RID: 43925 RVA: 0x00329B10 File Offset: 0x00327D10
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

	// Token: 0x0600AB96 RID: 43926 RVA: 0x00329B88 File Offset: 0x00327D88
	public void OnTick(float delta)
	{
		foreach (T t in this.Items)
		{
			t.OnTick(delta);
		}
	}

	// Token: 0x0600AB97 RID: 43927 RVA: 0x00329BE0 File Offset: 0x00327DE0
	public virtual void OnHandleLoadScene()
	{
	}

	// Token: 0x0600AB98 RID: 43928 RVA: 0x00329BE2 File Offset: 0x00327DE2
	public virtual void OnHandleReleaseScene()
	{
	}

	// Token: 0x04006348 RID: 25416
	protected readonly List<T> Items = new List<T>();

	// Token: 0x04006349 RID: 25417
	[Nullable(2)]
	protected FormationDragData DragData;

	// Token: 0x02007354 RID: 29524
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040258F7 RID: 153847
		[Nullable(new byte[]
		{
			0,
			2
		})]
		public static Action<ULGUIPointerEventData, int, int, int> <0>__OnFormationRoleViewPointDown;

		// Token: 0x040258F8 RID: 153848
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<UUIItem, int, int, int> <1>__OnFormationRoleViewGamePadDown;

		// Token: 0x040258F9 RID: 153849
		[Nullable(0)]
		public static Func<bool> <2>__CanFormationRoleViewStartDrag;

		// Token: 0x040258FA RID: 153850
		[Nullable(0)]
		public static Action <3>__OnFormationRoleViewStartDrag;

		// Token: 0x040258FB RID: 153851
		[Nullable(new byte[]
		{
			0,
			2
		})]
		public static Action<ULGUIPointerEventData> <4>__OnFormationRoleViewMoveDrag;

		// Token: 0x040258FC RID: 153852
		[Nullable(0)]
		public static Action<bool> <5>__OnFormationRoleViewEndDrag;
	}
}
