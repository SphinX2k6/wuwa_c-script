using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02005BBF RID: 23487
	[NullableContext(1)]
	[Nullable(0)]
	public class SeekTraceContentPanel : UiPanelBase
	{
		// Token: 0x06039B98 RID: 236440 RVA: 0x01036848 File Offset: 0x01034A48
		public void SetItemCallback(Action onSelectedItem, Action onPlacedItem)
		{
			this.OnSelectedItem = onSelectedItem;
			this.OnPlacedItem = onPlacedItem;
		}

		// Token: 0x06039B99 RID: 236441 RVA: 0x01036858 File Offset: 0x01034A58
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUINiagara)),
				new ValueTuple<int, Type>(6, typeof(UUINiagara)),
				new ValueTuple<int, Type>(7, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUINiagara)),
				new ValueTuple<int, Type>(10, typeof(UUINiagara)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUINiagara)),
				new ValueTuple<int, Type>(13, typeof(UUINiagara)),
				new ValueTuple<int, Type>(14, typeof(UUINiagara))
			};
		}

		// Token: 0x06039B9A RID: 236442 RVA: 0x010369C0 File Offset: 0x01034BC0
		protected override UniTask OnBeforeStartAsync()
		{
			SeekTraceContentPanel.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SeekTraceContentPanel.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039B9B RID: 236443 RVA: 0x01036A04 File Offset: 0x01034C04
		protected override void OnStart()
		{
			int panelWidth = SeekTraceModel.Instance.PanelWidth;
			if (panelWidth == 0)
			{
				Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.LYY, "SeekTrace初始化时面板大小为0", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			double num = (double)base.GetGridLayout(0).RootUIComp.Get().Width;
			this.CellSize = num / (double)panelWidth;
			this.PositionOffset = (double)panelWidth / 2.0 - 1.0;
			this.TopLeftToCenterOffset = this.PositionOffset + 0.5;
			UUIDraggableComponent draggable = base.GetDraggable(7);
			draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBegin));
			draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
			draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEnd));
			draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBegin));
			draggable.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEnd));
			draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEnd));
			base.GetItem(4).SetUIActive(true);
			base.GetItem(8).SetUIActive(true);
			this.InitSelectFrame();
			this.StartInitNiagara();
		}

		// Token: 0x06039B9C RID: 236444 RVA: 0x01036B4C File Offset: 0x01034D4C
		private void StartInitNiagara()
		{
			Dictionary<int, ULGUINiagaraComponent> dictionary = new Dictionary<int, ULGUINiagaraComponent>();
			foreach (int num in this.InitNiagaraKeys)
			{
				ULGUINiagaraComponent niagaraComponent = base.GetUiNiagara(num).NiagaraComponent;
				if (niagaraComponent == null)
				{
					TimerSystem.Instance.Next(delegate(float _)
					{
						this.StartInitNiagara();
					}, null, null);
					return;
				}
				dictionary[num] = niagaraComponent;
			}
			int panelWidth = SeekTraceModel.Instance.PanelWidth;
			int param = (panelWidth != 5) ? 1 : 0;
			FName parameterName = new FName("NiagaraType");
			FName parameterName2 = new FName("XSize");
			FName parameterName3 = new FName("YSize");
			TArray<int> tarray = new TArray<int>();
			int num2 = panelWidth * panelWidth;
			for (int j = 0; j < num2; j++)
			{
				this.DragEffectList.Add(0);
				this.EffectEmptyList.Add(0);
				tarray.Add(3);
			}
			foreach (KeyValuePair<int, ULGUINiagaraComponent> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				ULGUINiagaraComponent value = keyValuePair.Value;
				value.SetIntParameter(parameterName, param);
				value.SetIntParameter(parameterName2, panelWidth);
				value.SetIntParameter(parameterName3, panelWidth);
				if (key - 5 > 1)
				{
					if (key - 9 <= 1)
					{
						UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayInt32(value, this.GridArrayName, this.EffectEmptyList);
						UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayInt32(value, this.StateArrayName, tarray);
					}
				}
				else
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayInt32(value, this.GridArrayName, this.ContentEffectList);
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayInt32(value, this.StateArrayName, this.ContentEffectStateList);
				}
			}
		}

		// Token: 0x06039B9D RID: 236445 RVA: 0x01036CF8 File Offset: 0x01034EF8
		protected override void OnBeforeShow()
		{
			this.PlayOnceNiagara(12, 400, null, null);
		}

		// Token: 0x06039B9E RID: 236446 RVA: 0x01036D0C File Offset: 0x01034F0C
		protected override void OnBeforeDestroy()
		{
			UUIDraggableComponent draggable = base.GetDraggable(7);
			draggable.OnPointerBeginDragCallBack.Unbind();
			draggable.OnPointerDragCallBack.Unbind();
			draggable.OnPointerEndDragCallBack.Unbind();
			draggable.OnPointerDownCallBack.Unbind();
			draggable.OnPointerCancelCallBack.Unbind();
			draggable.OnPointerUpCallBack.Unbind();
		}

		// Token: 0x06039B9F RID: 236447 RVA: 0x01036D61 File Offset: 0x01034F61
		public void SetInteractEnable(bool enable)
		{
			this.IsInteractEnable = enable;
		}

		// Token: 0x06039BA0 RID: 236448 RVA: 0x01036D6A File Offset: 0x01034F6A
		public void ResetView()
		{
			this.RefreshDragView(false);
			this.PlayOnceNiagara(13, 400, delegate
			{
				foreach (int name in this.ContentNiagaraKeys)
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayInt32(base.GetUiNiagara(name).NiagaraComponent, this.GridArrayName, this.EffectEmptyList);
				}
			}, delegate(float _)
			{
				this.RefreshContentView();
				this.PlayOnceNiagara(12, 400, null, null);
			});
		}

		// Token: 0x06039BA1 RID: 236449 RVA: 0x01036D98 File Offset: 0x01034F98
		public void OnInputControllerChange()
		{
			if (SeekTraceModel.Instance.SelectedItem != null)
			{
				this.PlaceItem(true, Info.Instance.IsInGamepad());
			}
			this.InitSelectFrame();
		}

		// Token: 0x06039BA2 RID: 236450 RVA: 0x01036DBD File Offset: 0x01034FBD
		public void OnSeekTraceSucceed()
		{
			this.PlayOnceNiagara(14, 400, null, null);
		}

		// Token: 0x06039BA3 RID: 236451 RVA: 0x01036DD0 File Offset: 0x01034FD0
		private void InitSelectFrame()
		{
			bool flag = Info.Instance.IsInTouch();
			bool flag2 = !flag;
			this.IsOpenSelectFrame = flag2;
			UUIItem item = base.GetItem(11);
			item.SetUIActive(flag2);
			if (flag)
			{
				UiSequencePlayer frameSequencePlayer = this.FrameSequencePlayer;
				if (frameSequencePlayer != null)
				{
					frameSequencePlayer.Clear();
				}
				this.FrameSequencePlayer = null;
				return;
			}
			if (this.FrameSequencePlayer == null)
			{
				this.FrameSequencePlayer = new UiSequencePlayer(item);
				this.FrameSequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnFrameSequenceEnd));
			}
			this.GamePadPosition[0] = 0;
			this.GamePadPosition[1] = 0;
			this.UpdateSelectFrameByPosition(0, 0);
		}

		// Token: 0x06039BA4 RID: 236452 RVA: 0x01036E64 File Offset: 0x01035064
		public void UpdateKeyBoardSelectFrame()
		{
			if (!Info.Instance.IsInKeyBoard())
			{
				return;
			}
			SeekTraceModel instance = SeekTraceModel.Instance;
			if (instance.SelectedItem != null)
			{
				return;
			}
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return;
			}
			Vector2D cursorPosition = characterController.GetCursorPosition();
			if (cursorPosition == null)
			{
				return;
			}
			Vector2D tempVector2D = this.TempVector2D;
			LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(cursorPosition.ToUeVector2D(false), tempVector2D);
			int num = (int)Math.Ceiling(tempVector2D.X / this.CellSize + this.PositionOffset);
			int num2 = (int)Math.Ceiling(-tempVector2D.Y / this.CellSize + this.PositionOffset);
			int panelWidth = instance.PanelWidth;
			int panelHeight = instance.PanelHeight;
			if (num < 0 || num >= panelWidth || num2 < 0 || num2 >= panelHeight)
			{
				return;
			}
			this.UpdateSelectFrameByPosition(num, num2);
		}

		// Token: 0x06039BA5 RID: 236453 RVA: 0x01036F28 File Offset: 0x01035128
		private void UpdateSelectFrameByPosition(int positionX, int positionY)
		{
			if (positionX == this.LastFramePosition[0] && positionY == this.LastFramePosition[1])
			{
				return;
			}
			UiSequencePlayer frameSequencePlayer = this.FrameSequencePlayer;
			if (frameSequencePlayer != null)
			{
				frameSequencePlayer.StopPrevSequence(false, true);
			}
			UiSequencePlayer frameSequencePlayer2 = this.FrameSequencePlayer;
			if (frameSequencePlayer2 != null)
			{
				frameSequencePlayer2.PlaySequencePurely("Float", false, false);
			}
			this.LastFramePosition[0] = positionX;
			this.LastFramePosition[1] = positionY;
			Vector2D tempVector2D = this.TempVector2D;
			tempVector2D.X = ((double)positionX - this.TopLeftToCenterOffset) * this.CellSize;
			tempVector2D.Y = -((double)positionY - this.TopLeftToCenterOffset) * this.CellSize;
			base.GetItem(11).SetAnchorOffset(tempVector2D.ToUeVector2D(false));
		}

		// Token: 0x06039BA6 RID: 236454 RVA: 0x01036FD1 File Offset: 0x010351D1
		private void ResetSelectFrame()
		{
			if (!this.IsOpenSelectFrame)
			{
				return;
			}
			if (SeekTraceModel.Instance.SelectedItem != null)
			{
				return;
			}
			this.FrameSequencePlayer.StopPrevSequence(false, true);
			this.FrameSequencePlayer.PlaySequencePurely("Move", false, false);
		}

		// Token: 0x06039BA7 RID: 236455 RVA: 0x01037008 File Offset: 0x01035208
		private void OnFrameSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Move")
			{
				this.InitSelectFrame();
			}
		}

		// Token: 0x06039BA8 RID: 236456 RVA: 0x01037020 File Offset: 0x01035220
		[NullableContext(2)]
		private void OnPointerBegin(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			SeekTraceModel instance = SeekTraceModel.Instance;
			if (instance.SelectedItem != null)
			{
				return;
			}
			if (!this.IsInteractEnable)
			{
				return;
			}
			Vector2D tempVector2D = this.TempVector2D;
			LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(eventData.pointerPosition, tempVector2D);
			double num = tempVector2D.X / this.CellSize + this.PositionOffset;
			double num2 = -tempVector2D.Y / this.CellSize + this.PositionOffset;
			int[] tempPosition = this.TempPosition;
			tempPosition[0] = (int)Math.Ceiling(num);
			tempPosition[1] = (int)Math.Ceiling(num2);
			if (!SeekTraceController.SelectItem(tempPosition))
			{
				return;
			}
			int num3 = tempPosition[0];
			int num4 = tempPosition[1];
			this.ClickStartPosition[0] = num3;
			this.ClickStartPosition[1] = num4;
			int[] basePosition = instance.SelectedItem.BasePosition;
			this.SelectPositionOffset[0] = num3 - basePosition[0];
			this.SelectPositionOffset[1] = num4 - basePosition[1];
			this.SelectUiOffset.X = -(num - (double)tempPosition[0] + 0.5) * this.CellSize;
			this.SelectUiOffset.Y = (num2 - (double)tempPosition[1] + 0.5) * this.CellSize;
			this.RefreshDragView(true);
			this.RefreshDragPositionByPointer(tempVector2D, true);
			Action onSelectedItem = this.OnSelectedItem;
			if (onSelectedItem == null)
			{
				return;
			}
			onSelectedItem();
		}

		// Token: 0x06039BA9 RID: 236457 RVA: 0x01037168 File Offset: 0x01035368
		[NullableContext(2)]
		private void OnPointerDrag(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			if (SeekTraceModel.Instance.SelectedItem == null)
			{
				return;
			}
			Vector2D tempVector2D = this.TempVector2D;
			LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(eventData.pointerPosition, tempVector2D);
			int[] tempPosition = this.TempPosition;
			tempPosition[0] = (int)Math.Ceiling(tempVector2D.X / this.CellSize + this.PositionOffset) - this.SelectPositionOffset[0];
			tempPosition[1] = (int)Math.Ceiling(-tempVector2D.Y / this.CellSize + this.PositionOffset) - this.SelectPositionOffset[1];
			SeekTraceController.MoveSelectedItem(tempPosition);
			this.RefreshContentView();
			this.RefreshDragPositionByPointer(tempVector2D, false);
		}

		// Token: 0x06039BAA RID: 236458 RVA: 0x01037204 File Offset: 0x01035404
		[NullableContext(2)]
		private void OnPointerEnd(ULGUIPointerEventData eventData)
		{
			this.PlaceItem(false, false);
		}

		// Token: 0x06039BAB RID: 236459 RVA: 0x01037210 File Offset: 0x01035410
		public void GamePadMovePosition(int offsetX, int offsetY)
		{
			SeekTraceModel instance = SeekTraceModel.Instance;
			int[] gamePadPosition = this.GamePadPosition;
			int positionX = (gamePadPosition[0] + offsetX + instance.PanelWidth) % instance.PanelWidth;
			int positionY = (gamePadPosition[1] + offsetY + instance.PanelHeight) % instance.PanelHeight;
			this.UpdateGamePadPosition(positionX, positionY);
		}

		// Token: 0x06039BAC RID: 236460 RVA: 0x01037258 File Offset: 0x01035458
		private void UpdateGamePadPosition(int positionX, int positionY)
		{
			int[] gamePadPosition = this.GamePadPosition;
			gamePadPosition[0] = positionX;
			gamePadPosition[1] = positionY;
			this.UpdateSelectFrameByPosition(positionX, positionY);
			if (SeekTraceModel.Instance.SelectedItem != null)
			{
				this.MoveGamePadSelectedItem();
			}
		}

		// Token: 0x06039BAD RID: 236461 RVA: 0x01037284 File Offset: 0x01035484
		private void MoveGamePadSelectedItem()
		{
			if (SeekTraceModel.Instance.SelectedItem == null)
			{
				return;
			}
			int num = this.GamePadPosition[0];
			int num2 = this.GamePadPosition[1];
			Vector2D tempVector2D = this.TempVector2D;
			tempVector2D.X = ((double)num - this.TopLeftToCenterOffset - (double)this.ClickStartPosition[0]) * this.CellSize;
			tempVector2D.Y = -((double)num2 - this.TopLeftToCenterOffset - (double)this.ClickStartPosition[1]) * this.CellSize;
			base.GetItem(8).SetAnchorOffset(tempVector2D.ToUeVector2D(false));
			int[] tempPosition = this.TempPosition;
			tempPosition[0] = num - this.SelectPositionOffset[0];
			tempPosition[1] = num2 - this.SelectPositionOffset[1];
			SeekTraceController.MoveSelectedItem(tempPosition);
			this.RefreshContentView();
		}

		// Token: 0x06039BAE RID: 236462 RVA: 0x01037338 File Offset: 0x01035538
		public void GamePadSelectItem()
		{
			if (!this.IsInteractEnable)
			{
				return;
			}
			SeekTraceModel instance = SeekTraceModel.Instance;
			if (instance.SelectedItem != null)
			{
				this.PlaceItem(false, true);
				return;
			}
			if (!SeekTraceController.SelectItem(this.GamePadPosition))
			{
				return;
			}
			int[] gamePadPosition = this.GamePadPosition;
			int[] basePosition = instance.SelectedItem.BasePosition;
			int num = gamePadPosition[0];
			int num2 = gamePadPosition[1];
			this.ClickStartPosition[0] = num;
			this.ClickStartPosition[1] = num2;
			this.SelectPositionOffset[0] = num - basePosition[0];
			this.SelectPositionOffset[1] = num2 - basePosition[1];
			this.MoveGamePadSelectedItem();
			this.RefreshDragView(true);
			this.FrameSequencePlayer.StopPrevSequence(false, true);
			this.FrameSequencePlayer.PlaySequencePurely("Sle", false, false);
			Action onSelectedItem = this.OnSelectedItem;
			if (onSelectedItem == null)
			{
				return;
			}
			onSelectedItem();
		}

		// Token: 0x06039BAF RID: 236463 RVA: 0x010373F4 File Offset: 0x010355F4
		public void GamePadResetItem()
		{
			this.PlaceItem(true, true);
		}

		// Token: 0x06039BB0 RID: 236464 RVA: 0x01037400 File Offset: 0x01035600
		private void PlaceItem(bool resetToStart, bool isGamePad)
		{
			SeekTraceItemData selectedItem = SeekTraceModel.Instance.SelectedItem;
			if (selectedItem == null)
			{
				return;
			}
			int count = selectedItem.FilledIndexSet.Count;
			ESeekTracePlaceResultType? eseekTracePlaceResultType = resetToStart ? null : new ESeekTracePlaceResultType?(SeekTraceController.PlaceSelectedItem());
			ESeekTracePlaceResultType? eseekTracePlaceResultType2 = eseekTracePlaceResultType;
			ESeekTracePlaceResultType eseekTracePlaceResultType3 = ESeekTracePlaceResultType.Succeed;
			if (eseekTracePlaceResultType2.GetValueOrDefault() == eseekTracePlaceResultType3 & eseekTracePlaceResultType2 != null)
			{
				HashSet<int> filledIndexSet = selectedItem.FilledIndexSet;
				if (count != filledIndexSet.Count)
				{
					int itemType = (int)selectedItem.ItemType;
					int num = this.ContentEffectList.Num();
					for (int i = 0; i < num; i++)
					{
						TArray<int> contentEffectList = this.ContentEffectList;
						int index = i;
						int num2 = filledIndexSet.Contains(i) ? itemType : 0;
						contentEffectList.Set(index, num2);
					}
					this.PlayOnceNiagara(12, 400, null, null);
					AudioSystem.Instance.PostEvent("play_ui_seektrace_gem_moved");
				}
			}
			else
			{
				SeekTraceController.MoveSelectedItem(SeekTraceModel.Instance.SelectedStartPosition);
				SeekTraceController.PlaceSelectedItem();
				if (eseekTracePlaceResultType.GetValueOrDefault() == ESeekTracePlaceResultType.OutOfRange)
				{
					this.ResetSelectFrame();
				}
				if (isGamePad)
				{
					this.UpdateGamePadPosition(this.ClickStartPosition[0], this.ClickStartPosition[1]);
				}
			}
			int[] lastFramePosition = this.LastFramePosition;
			lastFramePosition[0] = -1;
			lastFramePosition[1] = -1;
			this.RefreshContentView();
			this.RefreshDragView(false);
			Action onPlacedItem = this.OnPlacedItem;
			if (onPlacedItem == null)
			{
				return;
			}
			onPlacedItem();
		}

		// Token: 0x06039BB1 RID: 236465 RVA: 0x01037540 File Offset: 0x01035740
		private void RefreshDragView(bool enable)
		{
			if (enable)
			{
				SeekTraceItemData selectedItem = SeekTraceModel.Instance.SelectedItem;
				int itemType = (int)selectedItem.ItemType;
				HashSet<int> filledIndexSet = selectedItem.FilledIndexSet;
				for (int i = 0; i < this.DragEffectList.Num(); i++)
				{
					int num = filledIndexSet.Contains(i) ? itemType : 0;
					this.DragEffectList.Set(i, num);
				}
			}
			TArray<int> tarray = enable ? this.DragEffectList : this.EffectEmptyList;
			foreach (int name in this.DragNiagaraKeys)
			{
				UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayInt32(base.GetUiNiagara(name).NiagaraComponent, this.GridArrayName, tarray);
			}
		}

		// Token: 0x06039BB2 RID: 236466 RVA: 0x010375E8 File Offset: 0x010357E8
		private void RefreshDragPositionByPointer(Vector2D pointerPosition, bool playSelectSequence)
		{
			pointerPosition.AdditionEqual(this.SelectUiOffset);
			double num = ((double)UiLayer.Instance.UiRootItem.GetWidth() - this.CellSize) / 2.0;
			double num2 = ((double)UiLayer.Instance.UiRootItem.GetHeight() - this.CellSize) / 2.0;
			double num3 = (double)this.ClickStartPosition[0] * this.CellSize;
			double num4 = (double)this.ClickStartPosition[1] * this.CellSize;
			pointerPosition.X = MathUtils.Instance.Clamp(pointerPosition.X, -num, num);
			pointerPosition.Y = MathUtils.Instance.Clamp(pointerPosition.Y, -num2, num2);
			if (this.IsOpenSelectFrame)
			{
				base.GetItem(11).SetAnchorOffset(pointerPosition.ToUeVector2D(false));
				if (playSelectSequence)
				{
					this.FrameSequencePlayer.StopPrevSequence(false, true);
					this.FrameSequencePlayer.PlaySequencePurely("Sle", false, false);
				}
			}
			pointerPosition.X -= num3;
			pointerPosition.Y += num4;
			base.GetItem(8).SetAnchorOffset(pointerPosition.ToUeVector2D(false));
		}

		// Token: 0x06039BB3 RID: 236467 RVA: 0x01037708 File Offset: 0x01035908
		private void RefreshContentView()
		{
			this.RefreshContentData();
			foreach (int name in this.ContentNiagaraKeys)
			{
				ULGUINiagaraComponent niagaraComponent = base.GetUiNiagara(name).NiagaraComponent;
				UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayInt32(niagaraComponent, this.GridArrayName, this.ContentEffectList);
				UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayInt32(niagaraComponent, this.StateArrayName, this.ContentEffectStateList);
			}
			GenericLayout<SeekTraceGridStateView, ESeekTraceGridStateViewType> stateLayout = this.StateLayout;
			if (stateLayout == null)
			{
				return;
			}
			stateLayout.RefreshByData(this.ContentGridStateList, null, false);
		}

		// Token: 0x06039BB4 RID: 236468 RVA: 0x0103777C File Offset: 0x0103597C
		private void RefreshContentData()
		{
			List<ESeekTraceGridStateViewType> contentGridStateList = this.ContentGridStateList;
			TArray<int> contentEffectList = this.ContentEffectList;
			TArray<int> contentEffectStateList = this.ContentEffectStateList;
			HashSet<int> hashSet = new HashSet<int>();
			SeekTraceModel instance = SeekTraceModel.Instance;
			Dictionary<int, SeekTraceItemData> mainItemMap = instance.MainItemMap;
			SeekTraceItemData selectedItem = instance.SelectedItem;
			foreach (SeekTraceItemData seekTraceItemData in instance.ItemDataList)
			{
				if (seekTraceItemData.IsValid && seekTraceItemData != selectedItem)
				{
					int itemType = (int)seekTraceItemData.ItemType;
					SeekTraceItemData seekTraceItemData2;
					mainItemMap.TryGetValue(itemType, out seekTraceItemData2);
					ESeekTraceGridStateViewType value = ESeekTraceGridStateViewType.None;
					int num = itemType;
					ESeekTraceItemEffectStateType eseekTraceItemEffectStateType = (seekTraceItemData2 != null) ? ((seekTraceItemData2 == seekTraceItemData) ? ESeekTraceItemEffectStateType.Normal : ESeekTraceItemEffectStateType.Dim) : ESeekTraceItemEffectStateType.Normal;
					foreach (int num2 in seekTraceItemData.FilledIndexSet)
					{
						if (num2 < contentGridStateList.Count)
						{
							contentGridStateList[num2] = value;
						}
						else
						{
							while (contentGridStateList.Count <= num2)
							{
								contentGridStateList.Add(ESeekTraceGridStateViewType.None);
							}
							contentGridStateList[num2] = value;
						}
						contentEffectList.Set(num2, num);
						TArray<int> tarray = contentEffectStateList;
						int index = num2;
						int num3 = (int)eseekTraceItemEffectStateType;
						tarray.Set(index, num3);
						hashSet.Add(num2);
					}
				}
			}
			List<bool> enableGridList = instance.EnableGridList;
			if (selectedItem != null)
			{
				HashSet<int> selectedStartFilledIndexSet = instance.SelectedStartFilledIndexSet;
				foreach (int num4 in selectedStartFilledIndexSet)
				{
					if (num4 < contentGridStateList.Count)
					{
						contentGridStateList[num4] = ESeekTraceGridStateViewType.None;
					}
					else
					{
						while (contentGridStateList.Count <= num4)
						{
							contentGridStateList.Add(ESeekTraceGridStateViewType.None);
						}
						contentGridStateList[num4] = ESeekTraceGridStateViewType.None;
					}
					TArray<int> tarray2 = contentEffectList;
					int index2 = num4;
					int num3 = (int)selectedItem.ItemType;
					tarray2.Set(index2, num3);
					TArray<int> tarray3 = contentEffectStateList;
					int index3 = num4;
					num3 = 0;
					tarray3.Set(index3, num3);
					hashSet.Add(num4);
				}
				int[] basePosition = selectedItem.BasePosition;
				int[] selectedStartPosition = instance.SelectedStartPosition;
				if (basePosition[0] != selectedStartPosition[0] || basePosition[1] != selectedStartPosition[1])
				{
					ESeekTraceGridStateViewType eseekTraceGridStateViewType = ESeekTraceGridStateViewType.None;
					bool flag = SeekTraceController.CheckCanPlaceSelectedItem() == ESeekTracePlaceResultType.Succeed;
					if (flag)
					{
						eseekTraceGridStateViewType = ESeekTraceGridStateViewType.LightGreen;
					}
					else
					{
						eseekTraceGridStateViewType = ESeekTraceGridStateViewType.Red;
					}
					int panelWidth = instance.PanelWidth;
					int panelHeight = instance.PanelHeight;
					Dictionary<int, SeekTraceItemData> indexToItemMap = instance.IndexToItemMap;
					Dictionary<int, HashSet<SeekTraceItemData>> preSelectedIndexToItemsMap = instance.PreSelectedIndexToItemsMap;
					int itemType2 = (int)selectedItem.ItemType;
					HashSet<SeekTraceItemData> hashSet2 = new HashSet<SeekTraceItemData>();
					foreach (int num5 in selectedItem.FilledIndexSet)
					{
						int num6 = num5 % panelWidth;
						int num7 = (int)Math.Floor((double)num5 / (double)panelWidth);
						if (num6 >= 0 && num6 < panelWidth && num7 >= 0 && num7 < panelHeight)
						{
							SeekTraceItemData seekTraceItemData3;
							indexToItemMap.TryGetValue(num5, out seekTraceItemData3);
							if (seekTraceItemData3 != null)
							{
								if (num5 < contentGridStateList.Count)
								{
									contentGridStateList[num5] = ESeekTraceGridStateViewType.Red;
								}
								else
								{
									while (contentGridStateList.Count <= num5)
									{
										contentGridStateList.Add(ESeekTraceGridStateViewType.None);
									}
									contentGridStateList[num5] = ESeekTraceGridStateViewType.Red;
								}
							}
							else if (selectedStartFilledIndexSet.Contains(num5))
							{
								if (num5 < contentGridStateList.Count)
								{
									contentGridStateList[num5] = eseekTraceGridStateViewType;
								}
								else
								{
									while (contentGridStateList.Count <= num5)
									{
										contentGridStateList.Add(ESeekTraceGridStateViewType.None);
									}
									contentGridStateList[num5] = eseekTraceGridStateViewType;
								}
							}
							else
							{
								if (num5 < contentGridStateList.Count)
								{
									contentGridStateList[num5] = (enableGridList[num5] ? eseekTraceGridStateViewType : ESeekTraceGridStateViewType.None);
								}
								else
								{
									while (contentGridStateList.Count <= num5)
									{
										contentGridStateList.Add(ESeekTraceGridStateViewType.None);
									}
									contentGridStateList[num5] = (enableGridList[num5] ? eseekTraceGridStateViewType : ESeekTraceGridStateViewType.None);
								}
								TArray<int> tarray4 = contentEffectList;
								int index4 = num5;
								int num3 = 0;
								tarray4.Set(index4, num3);
								TArray<int> tarray5 = contentEffectStateList;
								int index5 = num5;
								num3 = 2;
								tarray5.Set(index5, num3);
								hashSet.Add(num5);
							}
							if (flag)
							{
								HashSet<SeekTraceItemData> hashSet3;
								preSelectedIndexToItemsMap.TryGetValue(num5, out hashSet3);
								if (hashSet3 != null)
								{
									foreach (SeekTraceItemData seekTraceItemData4 in hashSet3)
									{
										if (seekTraceItemData4 != selectedItem && seekTraceItemData4.IsValid && seekTraceItemData4.ItemType == (ESeekTraceItemEffectType)itemType2)
										{
											hashSet2.Add(seekTraceItemData4);
										}
									}
								}
							}
						}
					}
					foreach (SeekTraceItemData seekTraceItemData5 in hashSet2)
					{
						foreach (int num8 in seekTraceItemData5.FilledIndexSet)
						{
							TArray<int> tarray6 = contentEffectStateList;
							int index6 = num8;
							int num3 = 3;
							tarray6.Set(index6, num3);
						}
					}
				}
			}
			for (int i = 0; i < enableGridList.Count; i++)
			{
				if (!hashSet.Contains(i))
				{
					if (i < contentGridStateList.Count)
					{
						contentGridStateList[i] = ESeekTraceGridStateViewType.None;
					}
					else
					{
						while (contentGridStateList.Count <= i)
						{
							contentGridStateList.Add(ESeekTraceGridStateViewType.None);
						}
						contentGridStateList[i] = ESeekTraceGridStateViewType.None;
					}
					TArray<int> tarray7 = contentEffectList;
					int index7 = i;
					int num3 = 0;
					tarray7.Set(index7, num3);
					TArray<int> tarray8 = contentEffectStateList;
					int index8 = i;
					num3 = 2;
					tarray8.Set(index8, num3);
				}
			}
		}

		// Token: 0x06039BB5 RID: 236469 RVA: 0x01037D1C File Offset: 0x01035F1C
		private SeekTraceGridStateView InitStateItem()
		{
			return new SeekTraceGridStateView();
		}

		// Token: 0x06039BB6 RID: 236470 RVA: 0x01037D23 File Offset: 0x01035F23
		private SeekTraceGridBackgroundView InitBackgroundItem()
		{
			return new SeekTraceGridBackgroundView();
		}

		// Token: 0x06039BB7 RID: 236471 RVA: 0x01037D2C File Offset: 0x01035F2C
		[NullableContext(2)]
		private void PlayOnceNiagara(int type, int duration, Action onStart = null, TTimerAction onFinish = null)
		{
			base.GetUiNiagara(type).SetUIActive(true);
			this.StartOnceNiagara(type, delegate
			{
				Action onStart2 = onStart;
				if (onStart2 != null)
				{
					onStart2();
				}
				if (onFinish != null)
				{
					TimerSystem.Instance.Delay(onFinish, (float)duration, null, null, true, 1f);
				}
			});
		}

		// Token: 0x06039BB8 RID: 236472 RVA: 0x01037D78 File Offset: 0x01035F78
		private void StartOnceNiagara(int type, Action onStart)
		{
			if (type != 12 && type != 13 && type != 14)
			{
				onStart();
				return;
			}
			ULGUINiagaraComponent niagaraComponent = base.GetUiNiagara(type).NiagaraComponent;
			if (niagaraComponent == null)
			{
				TimerSystem.Instance.Next(delegate(float _)
				{
					this.StartOnceNiagara(type, onStart);
				}, null, null);
				return;
			}
			niagaraComponent.ResetOverrideParametersAndActivate(true, "");
			int panelWidth = SeekTraceModel.Instance.PanelWidth;
			int param = (panelWidth != 5) ? 1 : 0;
			FName parameterName = new FName("NiagaraType");
			FName parameterName2 = new FName("XSize");
			FName parameterName3 = new FName("YSize");
			niagaraComponent.SetIntParameter(parameterName, param);
			niagaraComponent.SetIntParameter(parameterName2, panelWidth);
			niagaraComponent.SetIntParameter(parameterName3, panelWidth);
			UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayInt32(niagaraComponent, this.GridArrayName, this.ContentEffectList);
			onStart();
		}

		// Token: 0x0401E7D8 RID: 124888
		public const int DEFAULT_GRID_SIZE = 5;

		// Token: 0x0401E7D9 RID: 124889
		public const int NIAGARA_DURATION = 400;

		// Token: 0x0401E7DA RID: 124890
		private readonly List<ESeekTraceGridStateViewType> ContentGridStateList = new List<ESeekTraceGridStateViewType>();

		// Token: 0x0401E7DB RID: 124891
		private readonly TArray<int> ContentEffectList = new TArray<int>();

		// Token: 0x0401E7DC RID: 124892
		private readonly TArray<int> ContentEffectStateList = new TArray<int>();

		// Token: 0x0401E7DD RID: 124893
		private readonly TArray<int> DragEffectList = new TArray<int>();

		// Token: 0x0401E7DE RID: 124894
		private readonly TArray<int> EffectEmptyList = new TArray<int>();

		// Token: 0x0401E7DF RID: 124895
		private readonly FName GridArrayName = new FName("GridArray");

		// Token: 0x0401E7E0 RID: 124896
		private readonly FName StateArrayName = new FName("StateArray");

		// Token: 0x0401E7E1 RID: 124897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SeekTraceGridBackgroundView, bool> BackgroundLayout;

		// Token: 0x0401E7E2 RID: 124898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SeekTraceGridStateView, ESeekTraceGridStateViewType> StateLayout;

		// Token: 0x0401E7E3 RID: 124899
		private readonly int[] ContentNiagaraKeys = new int[]
		{
			5,
			6
		};

		// Token: 0x0401E7E4 RID: 124900
		private readonly int[] DragNiagaraKeys = new int[]
		{
			9,
			10
		};

		// Token: 0x0401E7E5 RID: 124901
		private readonly int[] InitNiagaraKeys = new int[]
		{
			5,
			6,
			9,
			10
		};

		// Token: 0x0401E7E6 RID: 124902
		private bool IsInteractEnable;

		// Token: 0x0401E7E7 RID: 124903
		private double PositionOffset = 1.0;

		// Token: 0x0401E7E8 RID: 124904
		private double TopLeftToCenterOffset;

		// Token: 0x0401E7E9 RID: 124905
		private double CellSize = 1.0;

		// Token: 0x0401E7EA RID: 124906
		private bool IsOpenSelectFrame;

		// Token: 0x0401E7EB RID: 124907
		private int[] LastFramePosition = new int[]
		{
			-1,
			-1
		};

		// Token: 0x0401E7EC RID: 124908
		[Nullable(2)]
		private UiSequencePlayer FrameSequencePlayer;

		// Token: 0x0401E7ED RID: 124909
		private readonly Vector2D TempVector2D = Vector2D.Create();

		// Token: 0x0401E7EE RID: 124910
		private readonly int[] TempPosition = new int[2];

		// Token: 0x0401E7EF RID: 124911
		private readonly int[] SelectPositionOffset = new int[2];

		// Token: 0x0401E7F0 RID: 124912
		private readonly int[] ClickStartPosition = new int[2];

		// Token: 0x0401E7F1 RID: 124913
		private readonly int[] GamePadPosition = new int[2];

		// Token: 0x0401E7F2 RID: 124914
		private readonly Vector2D SelectUiOffset = Vector2D.Create();

		// Token: 0x0401E7F3 RID: 124915
		[Nullable(2)]
		private Action OnSelectedItem;

		// Token: 0x0401E7F4 RID: 124916
		[Nullable(2)]
		private Action OnPlacedItem;

		// Token: 0x0200B75F RID: 46943
		[NullableContext(0)]
		public enum EComponentType
		{
			// Token: 0x04038ADC RID: 232156
			BackgroundGridLayout,
			// Token: 0x04038ADD RID: 232157
			BackgroundItem,
			// Token: 0x04038ADE RID: 232158
			StateGridLayout,
			// Token: 0x04038ADF RID: 232159
			StateGridItem,
			// Token: 0x04038AE0 RID: 232160
			ContentItem,
			// Token: 0x04038AE1 RID: 232161
			ContentSphereNiagara,
			// Token: 0x04038AE2 RID: 232162
			ContentIconNiagara,
			// Token: 0x04038AE3 RID: 232163
			DragComponent,
			// Token: 0x04038AE4 RID: 232164
			DragItem,
			// Token: 0x04038AE5 RID: 232165
			DragSphereNiagara,
			// Token: 0x04038AE6 RID: 232166
			DragIconNiagara,
			// Token: 0x04038AE7 RID: 232167
			SelectFrameItem,
			// Token: 0x04038AE8 RID: 232168
			StartNiagara,
			// Token: 0x04038AE9 RID: 232169
			ResetNiagara,
			// Token: 0x04038AEA RID: 232170
			SucceedNiagara
		}
	}
}
