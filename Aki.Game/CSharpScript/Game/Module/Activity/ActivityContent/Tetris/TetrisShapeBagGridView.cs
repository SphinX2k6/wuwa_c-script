using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006018 RID: 24600
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		2
	})]
	public class TetrisShapeBagGridView : GridProxyAbstract<BlockInstance>
	{
		// Token: 0x0603E4AC RID: 255148 RVA: 0x00F0B8FA File Offset: 0x00F09AFA
		[NullableContext(1)]
		public void SetPoolManager(IGridPoolManager manager)
		{
			this.PoolManager = manager;
			if (this.Shape != null)
			{
				this.Shape.SetPoolManager(manager);
			}
		}

		// Token: 0x0603E4AD RID: 255149 RVA: 0x00F0B918 File Offset: 0x00F09B18
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603E4AE RID: 255150 RVA: 0x00F0B974 File Offset: 0x00F09B74
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisShapeBagGridView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisShapeBagGridView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E4AF RID: 255151 RVA: 0x00F0B9B8 File Offset: 0x00F09BB8
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.OnPointerBeginDragCallBack.Bind((ULGUIPointerEventData eventData) => this.OnBeginDrag(eventData, false));
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
			EventSystem.Instance.Add(EEventName.OnMotorMusicSortDragCancel, new Action(this.OnTetrisShapeBagGridViewDragCancel));
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603E4B0 RID: 255152 RVA: 0x00F0BAC4 File Offset: 0x00F09CC4
		public void PlayRefreshAnimation()
		{
			this.ViewSequencePlayer.PlayLevelSequenceByName("Refresh", false, null, false);
		}

		// Token: 0x0603E4B1 RID: 255153 RVA: 0x00F0BAEC File Offset: 0x00F09CEC
		public override void Refresh(BlockInstance data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.Index = gridIndex;
			this.Shape.RefreshView(data);
			this.UpdateDragEnabled();
		}

		// Token: 0x0603E4B2 RID: 255154 RVA: 0x00F0BB10 File Offset: 0x00F09D10
		private void UpdateDragEnabled()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.RootUIComp.Get().SetRaycastTarget(this.Data != null);
			}
		}

		// Token: 0x0603E4B3 RID: 255155 RVA: 0x00F0BB44 File Offset: 0x00F09D44
		public void SetInteractAble(bool interactAble)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.RootUIComp.Get().SetRaycastTarget(interactAble && this.Data != null);
			}
		}

		// Token: 0x0603E4B4 RID: 255156 RVA: 0x00F0BB7E File Offset: 0x00F09D7E
		private bool CanDrag()
		{
			return this.Data != null;
		}

		// Token: 0x0603E4B5 RID: 255157 RVA: 0x00F0BB8C File Offset: 0x00F09D8C
		private bool OnBeginDrag(ULGUIPointerEventData eventData, bool isInit = false)
		{
			if (!this.CanDrag())
			{
				return false;
			}
			if (this.IsGamePadDragging && !isInit)
			{
				return true;
			}
			this.IsEndDragHandled = false;
			TetrisShapePanel shape = this.Shape;
			if (shape != null)
			{
				shape.SetUiActive(false);
			}
			return this.OnViewBeginDrag != null && this.OnViewBeginDrag(eventData, this.Data);
		}

		// Token: 0x0603E4B6 RID: 255158 RVA: 0x00F0BBE5 File Offset: 0x00F09DE5
		private bool OnDrag(ULGUIPointerEventData eventData)
		{
			return this.OnViewDrag != null && this.OnViewDrag(eventData);
		}

		// Token: 0x0603E4B7 RID: 255159 RVA: 0x00F0BC00 File Offset: 0x00F09E00
		private bool OnEndDrag(ULGUIPointerEventData eventData)
		{
			if (this.IsEndDragHandled)
			{
				return false;
			}
			this.IsEndDragHandled = true;
			TetrisShapePanel shape = this.Shape;
			if (shape != null)
			{
				shape.SetUiActive(true);
			}
			ULGUIPointerEventData arg = this.IsCancelDragPending ? null : eventData;
			this.IsCancelDragPending = false;
			return this.OnViewEndDrag != null && this.OnViewEndDrag(arg, this.Index, this.Data);
		}

		// Token: 0x0603E4B8 RID: 255160 RVA: 0x00F0BC68 File Offset: 0x00F09E68
		private void OnPointerDown()
		{
			if (this.IsGamePadDragging)
			{
				this.IsGamePadDragging = false;
				TetrisPlayView tetrisPlayView = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
				if (tetrisPlayView != null)
				{
					tetrisPlayView.ShowCloseBtn();
				}
				ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
				this.OnEndDrag(pointerEventData);
				return;
			}
			this.IsGamePadDragging = UiNavigationNewController.Instance.IsNavigationMousePositionDragging();
			if (this.IsGamePadDragging)
			{
				ULGUIPointerEventData pointerEventData2 = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
				TetrisPlayView tetrisPlayView2 = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
				if (tetrisPlayView2 != null)
				{
					tetrisPlayView2.HideCloseBtn();
				}
				this.OnBeginDrag(pointerEventData2, true);
				this.OnDrag(pointerEventData2);
			}
		}

		// Token: 0x0603E4B9 RID: 255161 RVA: 0x00F0BD0C File Offset: 0x00F09F0C
		private void OnPointerUp()
		{
			if (!this.IsGamePadDragging)
			{
				return;
			}
			this.IsGamePadDragging = false;
			TetrisPlayView tetrisPlayView = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
			if (tetrisPlayView != null)
			{
				tetrisPlayView.ShowCloseBtn();
			}
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			this.OnEndDrag(pointerEventData);
		}

		// Token: 0x0603E4BA RID: 255162 RVA: 0x00F0BD5C File Offset: 0x00F09F5C
		private void OnTetrisShapeBagGridViewDragCancel()
		{
			if (this.IsGamePadDragging)
			{
				this.IsGamePadDragging = false;
				this.IsCancelDragPending = true;
				TetrisPlayView tetrisPlayView = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
				if (tetrisPlayView != null)
				{
					tetrisPlayView.ShowCloseBtn();
				}
				ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
				this.OnEndDrag(pointerEventData);
			}
		}

		// Token: 0x0603E4BB RID: 255163 RVA: 0x00F0BDB2 File Offset: 0x00F09FB2
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
			this.IsGamePadDragging = false;
			EventSystem.Instance.Remove(EEventName.OnMotorMusicSortDragCancel, new Action(this.OnTetrisShapeBagGridViewDragCancel));
		}

		// Token: 0x040208E6 RID: 133350
		private TetrisShapePanel Shape;

		// Token: 0x040208E7 RID: 133351
		private BlockInstance Data;

		// Token: 0x040208E8 RID: 133352
		private int Index = -1;

		// Token: 0x040208E9 RID: 133353
		private IGridPoolManager PoolManager;

		// Token: 0x040208EA RID: 133354
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x040208EB RID: 133355
		private bool IsGamePadDragging;

		// Token: 0x040208EC RID: 133356
		private bool IsCancelDragPending;

		// Token: 0x040208ED RID: 133357
		private bool IsEndDragHandled;

		// Token: 0x040208EE RID: 133358
		public Func<ULGUIPointerEventData, BlockInstance, bool> OnViewBeginDrag;

		// Token: 0x040208EF RID: 133359
		public Func<ULGUIPointerEventData, bool> OnViewDrag;

		// Token: 0x040208F0 RID: 133360
		public Func<ULGUIPointerEventData, int, BlockInstance, bool> OnViewEndDrag;
	}
}
