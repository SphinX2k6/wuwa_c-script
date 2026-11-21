using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Input;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FE0 RID: 12256
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		2
	})]
	public class TetrisShapeBagGridView : GridProxyAbstract<BlockInstance>
	{
		// Token: 0x0601D16F RID: 119151 RVA: 0x008E46F2 File Offset: 0x008E28F2
		[NullableContext(1)]
		public void SetPoolManager(IGridPoolManager manager)
		{
			this.PoolManager = manager;
			TetrisShapePanel shape = this.Shape;
			if (shape == null)
			{
				return;
			}
			shape.SetPoolManager(manager);
		}

		// Token: 0x0601D170 RID: 119152 RVA: 0x008E470C File Offset: 0x008E290C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D171 RID: 119153 RVA: 0x008E4798 File Offset: 0x008E2998
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisShapeBagGridView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisShapeBagGridView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D172 RID: 119154 RVA: 0x008E47DC File Offset: 0x008E29DC
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnBeginDrag));
			}
			UUIButtonComponent button2 = base.GetButton(0);
			if (button2 != null)
			{
				button2.OnPointerDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnDrag));
			}
			UUIButtonComponent button3 = base.GetButton(0);
			if (button3 != null)
			{
				button3.OnPointerEndDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnEndDrag));
			}
			UUIButtonComponent button4 = base.GetButton(0);
			if (button4 != null)
			{
				button4.OnPointDownCallBack.Bind(new Action(this.OnPointerDown));
			}
			UUIButtonComponent button5 = base.GetButton(0);
			if (button5 != null)
			{
				button5.OnPointUpCallBack.Bind(new Action(this.OnPointerUp));
			}
			UUIButtonComponent button6 = base.GetButton(0);
			if (button6 != null)
			{
				button6.OnPointCancelCallBack.Bind(new Action(this.OnPointerUp));
			}
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0601D173 RID: 119155 RVA: 0x008E48CC File Offset: 0x008E2ACC
		public void PlayRefreshAnimation()
		{
			this.ViewSequencePlayer.PlayLevelSequenceByName("Refresh", false, null, false);
		}

		// Token: 0x0601D174 RID: 119156 RVA: 0x008E48F4 File Offset: 0x008E2AF4
		public override void Refresh(BlockInstance data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.Index = gridIndex;
			this.Shape.RefreshView(data);
			this.UpdateDragEnabled();
		}

		// Token: 0x0601D175 RID: 119157 RVA: 0x008E4918 File Offset: 0x008E2B18
		private void UpdateDragEnabled()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.RootUIComp.Get().SetRaycastTarget(this.CanDrag());
			}
		}

		// Token: 0x0601D176 RID: 119158 RVA: 0x008E494C File Offset: 0x008E2B4C
		public void SetInteractable(bool interactable)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.RootUIComp.Get().SetRaycastTarget(interactable && this.CanDrag());
			}
		}

		// Token: 0x0601D177 RID: 119159 RVA: 0x008E4983 File Offset: 0x008E2B83
		public void SetShapeVisible(bool isVisible)
		{
			TetrisShapePanel shape = this.Shape;
			if (shape != null)
			{
				shape.SetUiActive(isVisible);
			}
			if (isVisible)
			{
				TetrisShapePanel shape2 = this.Shape;
				if (shape2 == null)
				{
					return;
				}
				shape2.RefreshView(this.Data);
			}
		}

		// Token: 0x0601D178 RID: 119160 RVA: 0x008E49B0 File Offset: 0x008E2BB0
		public void CancelDrag()
		{
			if (this.DragSessionId != 0L)
			{
				Func<long, ETetrisDragCancelReason, bool> onViewCancelDrag = this.OnViewCancelDrag;
				if (onViewCancelDrag == null)
				{
					return;
				}
				onViewCancelDrag(this.DragSessionId, ETetrisDragCancelReason.Explicit);
			}
		}

		// Token: 0x0601D179 RID: 119161 RVA: 0x008E49D2 File Offset: 0x008E2BD2
		internal void ClearDragRoute(long sessionId)
		{
			if (this.DragSessionId != sessionId)
			{
				return;
			}
			this.DragSessionId = 0L;
			this.DragOriginIndex = -1;
		}

		// Token: 0x0601D17A RID: 119162 RVA: 0x008E49ED File Offset: 0x008E2BED
		internal void SetDragRoute(long sessionId, int originIndex)
		{
			this.DragSessionId = sessionId;
			this.DragOriginIndex = originIndex;
		}

		// Token: 0x0601D17B RID: 119163 RVA: 0x008E4A00 File Offset: 0x008E2C00
		internal bool TryCreatePointerSnapshot(int pointerId, out TetrisPointerSnapshot pointer, out BlockInstance shape)
		{
			shape = this.Data;
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(pointerId, false);
			if (pointerEventData == null)
			{
				pointer = default(TetrisPointerSnapshot);
				return false;
			}
			pointer = this.CreatePointerSnapshot(pointerEventData);
			return true;
		}

		// Token: 0x0601D17C RID: 119164 RVA: 0x008E4A3C File Offset: 0x008E2C3C
		[NullableContext(1)]
		internal bool MatchesNavigationBehavior(ULGUIBehaviour behavior)
		{
			return base.GetButton(0) == behavior;
		}

		// Token: 0x0601D17D RID: 119165 RVA: 0x008E4A48 File Offset: 0x008E2C48
		[NullableContext(1)]
		private TetrisPointerSnapshot CreatePointerSnapshot(ULGUIPointerEventData eventData)
		{
			return new TetrisPointerSnapshot(Info.Instance.InputControllerMainType, eventData.pointerID, eventData.mouseButtonType, eventData.pointerPosition, this.ComponentId, (this.DragSessionId == 0L) ? this.Index : this.DragOriginIndex, eventData.inputType);
		}

		// Token: 0x0601D17E RID: 119166 RVA: 0x008E4A98 File Offset: 0x008E2C98
		public bool CanDrag()
		{
			return this.Data != null;
		}

		// Token: 0x0601D17F RID: 119167 RVA: 0x008E4AA8 File Offset: 0x008E2CA8
		private bool OnBeginDrag(ULGUIPointerEventData eventData)
		{
			if (!this.CanDrag() || eventData == null)
			{
				return false;
			}
			TetrisPointerSnapshot arg = this.CreatePointerSnapshot(eventData);
			Func<TetrisPointerSnapshot, BlockInstance, long> onViewBeginDrag = this.OnViewBeginDrag;
			return ((onViewBeginDrag != null) ? onViewBeginDrag(arg, this.Data) : 0L) != 0L || this.DragSessionId != 0L;
		}

		// Token: 0x0601D180 RID: 119168 RVA: 0x008E4AF4 File Offset: 0x008E2CF4
		private bool OnDrag(ULGUIPointerEventData eventData)
		{
			if (this.DragSessionId == 0L || eventData == null)
			{
				return false;
			}
			TetrisPointerSnapshot arg = this.CreatePointerSnapshot(eventData);
			Func<long, TetrisPointerSnapshot, bool> onViewDrag = this.OnViewDrag;
			return onViewDrag != null && onViewDrag(this.DragSessionId, arg);
		}

		// Token: 0x0601D181 RID: 119169 RVA: 0x008E4B30 File Offset: 0x008E2D30
		private bool OnEndDrag(ULGUIPointerEventData eventData)
		{
			if (this.DragSessionId == 0L)
			{
				return false;
			}
			if (eventData == null)
			{
				Func<long, ETetrisDragCancelReason, bool> onViewCancelDrag = this.OnViewCancelDrag;
				return onViewCancelDrag != null && onViewCancelDrag(this.DragSessionId, ETetrisDragCancelReason.MissingPointerPosition);
			}
			TetrisPointerSnapshot arg = this.CreatePointerSnapshot(eventData);
			Func<long, TetrisPointerSnapshot, bool> onViewEndDrag = this.OnViewEndDrag;
			return onViewEndDrag != null && onViewEndDrag(this.DragSessionId, arg);
		}

		// Token: 0x0601D182 RID: 119170 RVA: 0x008E4B84 File Offset: 0x008E2D84
		private void OnPointerDown()
		{
			TetrisPointerSnapshot arg;
			BlockInstance arg2;
			if (this.TryCreatePointerSnapshot(0, out arg, out arg2))
			{
				Action<TetrisPointerSnapshot, BlockInstance> onViewPointerDown = this.OnViewPointerDown;
				if (onViewPointerDown == null)
				{
					return;
				}
				onViewPointerDown(arg, arg2);
			}
		}

		// Token: 0x0601D183 RID: 119171 RVA: 0x008E4BB0 File Offset: 0x008E2DB0
		private void OnPointerUp()
		{
			TetrisPointerSnapshot obj;
			BlockInstance blockInstance;
			if (!this.TryCreatePointerSnapshot(0, out obj, out blockInstance))
			{
				if (Info.Instance.InputControllerMainType == EInputControllerMainType.Gamepad && this.DragSessionId != 0L)
				{
					Func<long, ETetrisDragCancelReason, bool> onViewCancelDrag = this.OnViewCancelDrag;
					if (onViewCancelDrag == null)
					{
						return;
					}
					onViewCancelDrag(this.DragSessionId, ETetrisDragCancelReason.MissingPointerPosition);
				}
				return;
			}
			Action<TetrisPointerSnapshot> onViewPointerUp = this.OnViewPointerUp;
			if (onViewPointerUp == null)
			{
				return;
			}
			onViewPointerUp(obj);
		}

		// Token: 0x0601D184 RID: 119172 RVA: 0x008E4C0C File Offset: 0x008E2E0C
		protected override void OnBeforeDestroy()
		{
			if (this.DragSessionId != 0L)
			{
				Func<long, ETetrisDragCancelReason, bool> onViewCancelDrag = this.OnViewCancelDrag;
				if (onViewCancelDrag != null)
				{
					onViewCancelDrag(this.DragSessionId, ETetrisDragCancelReason.SourceDestroyed);
				}
			}
			UUIButtonComponent button = base.GetButton(0);
			if (button != null && button.IsValid())
			{
				button.OnPointerBeginDragCallBack.Unbind();
				button.OnPointerDragCallBack.Unbind();
				button.OnPointerEndDragCallBack.Unbind();
				button.OnPointDownCallBack.Unbind();
				button.OnPointUpCallBack.Unbind();
				button.OnPointCancelCallBack.Unbind();
			}
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
			this.DragSessionId = 0L;
			this.DragOriginIndex = -1;
			this.OnViewBeginDrag = null;
			this.OnViewDrag = null;
			this.OnViewEndDrag = null;
			this.OnViewCancelDrag = null;
			this.OnViewPointerDown = null;
			this.OnViewPointerUp = null;
		}

		// Token: 0x0400F52D RID: 62765
		private TetrisShapePanel Shape;

		// Token: 0x0400F52E RID: 62766
		private BlockInstance Data;

		// Token: 0x0400F52F RID: 62767
		private int Index = -1;

		// Token: 0x0400F530 RID: 62768
		private IGridPoolManager PoolManager;

		// Token: 0x0400F531 RID: 62769
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x0400F532 RID: 62770
		private long DragSessionId;

		// Token: 0x0400F533 RID: 62771
		private int DragOriginIndex = -1;

		// Token: 0x0400F534 RID: 62772
		internal Func<TetrisPointerSnapshot, BlockInstance, long> OnViewBeginDrag;

		// Token: 0x0400F535 RID: 62773
		internal Func<long, TetrisPointerSnapshot, bool> OnViewDrag;

		// Token: 0x0400F536 RID: 62774
		internal Func<long, TetrisPointerSnapshot, bool> OnViewEndDrag;

		// Token: 0x0400F537 RID: 62775
		internal Func<long, ETetrisDragCancelReason, bool> OnViewCancelDrag;

		// Token: 0x0400F538 RID: 62776
		internal Action<TetrisPointerSnapshot, BlockInstance> OnViewPointerDown;

		// Token: 0x0400F539 RID: 62777
		internal Action<TetrisPointerSnapshot> OnViewPointerUp;
	}
}
