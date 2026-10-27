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
	// Token: 0x02006A62 RID: 27234
	[NullableContext(1)]
	[Nullable(0)]
	public class SeekTraceContentPanel : UiPanelBase
	{
		// Token: 0x06043B4A RID: 277322 RVA: 0x01092014 File Offset: 0x01090214
		public void SetItemCallback(Action onSelectedItem, Action onPlacedItem)
		{
			this.OnSelectedItem = onSelectedItem;
			this.OnPlacedItem = onPlacedItem;
		}

		// Token: 0x06043B4B RID: 277323 RVA: 0x01092024 File Offset: 0x01090224
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

		// Token: 0x06043B4C RID: 277324 RVA: 0x0109218C File Offset: 0x0109038C
		protected override UniTask OnBeforeStartAsync()
		{
			SeekTraceContentPanel.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SeekTraceContentPanel.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043B4D RID: 277325 RVA: 0x010921D0 File Offset: 0x010903D0
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

		// Token: 0x06043B4E RID: 277326 RVA: 0x01092318 File Offset: 0x01090518
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

		// Token: 0x06043B4F RID: 277327 RVA: 0x010924C4 File Offset: 0x010906C4
		protected override void OnBeforeShow()
		{
			this.PlayOnceNiagara(12, 400, null, null);
		}

		// Token: 0x06043B50 RID: 277328 RVA: 0x010924D8 File Offset: 0x010906D8
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

		// Token: 0x06043B51 RID: 277329 RVA: 0x0109252D File Offset: 0x0109072D
		public void SetInteractEnable(bool enable)
		{
			this.IsInteractEnable = enable;
		}

		// Token: 0x06043B52 RID: 277330 RVA: 0x01092536 File Offset: 0x01090736
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

		// Token: 0x06043B53 RID: 277331 RVA: 0x01092564 File Offset: 0x01090764
		public void OnInputControllerChange()
		{
			if (SeekTraceModel.Instance.SelectedItem != null)
			{
				this.PlaceItem(true, Info.Instance.IsInGamepad());
			}
			this.InitSelectFrame();
		}

		// Token: 0x06043B54 RID: 277332 RVA: 0x01092589 File Offset: 0x01090789
		public void OnSeekTraceSucceed()
		{
			this.PlayOnceNiagara(14, 400, null, null);
		}

		// Token: 0x06043B55 RID: 277333 RVA: 0x0109259C File Offset: 0x0109079C
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

		// Token: 0x06043B56 RID: 277334 RVA: 0x01092630 File Offset: 0x01090830
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

		// Token: 0x06043B57 RID: 277335 RVA: 0x010926F4 File Offset: 0x010908F4
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

		// Token: 0x06043B58 RID: 277336 RVA: 0x0109279D File Offset: 0x0109099D
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

		// Token: 0x06043B59 RID: 277337 RVA: 0x010927D4 File Offset: 0x010909D4
		private void OnFrameSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Move")
			{
				this.InitSelectFrame();
			}
		}

		// Token: 0x06043B5A RID: 277338 RVA: 0x010927EC File Offset: 0x010909EC
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

		// Token: 0x06043B5B RID: 277339 RVA: 0x01092934 File Offset: 0x01090B34
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

		// Token: 0x06043B5C RID: 277340 RVA: 0x010929D0 File Offset: 0x01090BD0
		[NullableContext(2)]
		private void OnPointerEnd(ULGUIPointerEventData eventData)
		{
			this.PlaceItem(false, false);
		}

		// Token: 0x06043B5D RID: 277341 RVA: 0x010929DC File Offset: 0x01090BDC
		public void GamePadMovePosition(int offsetX, int offsetY)
		{
			SeekTraceModel instance = SeekTraceModel.Instance;
			int[] gamePadPosition = this.GamePadPosition;
			int positionX = (gamePadPosition[0] + offsetX + instance.PanelWidth) % instance.PanelWidth;
			int positionY = (gamePadPosition[1] + offsetY + instance.PanelHeight) % instance.PanelHeight;
			this.UpdateGamePadPosition(positionX, positionY);
		}

		// Token: 0x06043B5E RID: 277342 RVA: 0x01092A24 File Offset: 0x01090C24
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

		// Token: 0x06043B5F RID: 277343 RVA: 0x01092A50 File Offset: 0x01090C50
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

		// Token: 0x06043B60 RID: 277344 RVA: 0x01092B04 File Offset: 0x01090D04
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

		// Token: 0x06043B61 RID: 277345 RVA: 0x01092BC0 File Offset: 0x01090DC0
		public void GamePadResetItem()
		{
			this.PlaceItem(true, true);
		}

		// Token: 0x06043B62 RID: 277346 RVA: 0x01092BCC File Offset: 0x01090DCC
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

		// Token: 0x06043B63 RID: 277347 RVA: 0x01092D0C File Offset: 0x01090F0C
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

		// Token: 0x06043B64 RID: 277348 RVA: 0x01092DB4 File Offset: 0x01090FB4
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

		// Token: 0x06043B65 RID: 277349 RVA: 0x01092ED4 File Offset: 0x010910D4
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

		// Token: 0x06043B66 RID: 277350 RVA: 0x01092F48 File Offset: 0x01091148
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

		// Token: 0x06043B67 RID: 277351 RVA: 0x010934E8 File Offset: 0x010916E8
		private SeekTraceGridStateView InitStateItem()
		{
			return new SeekTraceGridStateView();
		}

		// Token: 0x06043B68 RID: 277352 RVA: 0x010934EF File Offset: 0x010916EF
		private SeekTraceGridBackgroundView InitBackgroundItem()
		{
			return new SeekTraceGridBackgroundView();
		}

		// Token: 0x06043B69 RID: 277353 RVA: 0x010934F8 File Offset: 0x010916F8
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

		// Token: 0x06043B6A RID: 277354 RVA: 0x01093544 File Offset: 0x01091744
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

		// Token: 0x040235E6 RID: 144870
		public const int DEFAULT_GRID_SIZE = 5;

		// Token: 0x040235E7 RID: 144871
		public const int NIAGARA_DURATION = 400;

		// Token: 0x040235E8 RID: 144872
		private readonly List<ESeekTraceGridStateViewType> ContentGridStateList = new List<ESeekTraceGridStateViewType>();

		// Token: 0x040235E9 RID: 144873
		private readonly TArray<int> ContentEffectList = new TArray<int>();

		// Token: 0x040235EA RID: 144874
		private readonly TArray<int> ContentEffectStateList = new TArray<int>();

		// Token: 0x040235EB RID: 144875
		private readonly TArray<int> DragEffectList = new TArray<int>();

		// Token: 0x040235EC RID: 144876
		private readonly TArray<int> EffectEmptyList = new TArray<int>();

		// Token: 0x040235ED RID: 144877
		private readonly FName GridArrayName = new FName("GridArray");

		// Token: 0x040235EE RID: 144878
		private readonly FName StateArrayName = new FName("StateArray");

		// Token: 0x040235EF RID: 144879
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SeekTraceGridBackgroundView, bool> BackgroundLayout;

		// Token: 0x040235F0 RID: 144880
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SeekTraceGridStateView, ESeekTraceGridStateViewType> StateLayout;

		// Token: 0x040235F1 RID: 144881
		private readonly int[] ContentNiagaraKeys = new int[]
		{
			5,
			6
		};

		// Token: 0x040235F2 RID: 144882
		private readonly int[] DragNiagaraKeys = new int[]
		{
			9,
			10
		};

		// Token: 0x040235F3 RID: 144883
		private readonly int[] InitNiagaraKeys = new int[]
		{
			5,
			6,
			9,
			10
		};

		// Token: 0x040235F4 RID: 144884
		private bool IsInteractEnable;

		// Token: 0x040235F5 RID: 144885
		private double PositionOffset = 1.0;

		// Token: 0x040235F6 RID: 144886
		private double TopLeftToCenterOffset;

		// Token: 0x040235F7 RID: 144887
		private double CellSize = 1.0;

		// Token: 0x040235F8 RID: 144888
		private bool IsOpenSelectFrame;

		// Token: 0x040235F9 RID: 144889
		private int[] LastFramePosition = new int[]
		{
			-1,
			-1
		};

		// Token: 0x040235FA RID: 144890
		[Nullable(2)]
		private UiSequencePlayer FrameSequencePlayer;

		// Token: 0x040235FB RID: 144891
		private readonly Vector2D TempVector2D = Vector2D.Create();

		// Token: 0x040235FC RID: 144892
		private readonly int[] TempPosition = new int[2];

		// Token: 0x040235FD RID: 144893
		private readonly int[] SelectPositionOffset = new int[2];

		// Token: 0x040235FE RID: 144894
		private readonly int[] ClickStartPosition = new int[2];

		// Token: 0x040235FF RID: 144895
		private readonly int[] GamePadPosition = new int[2];

		// Token: 0x04023600 RID: 144896
		private readonly Vector2D SelectUiOffset = Vector2D.Create();

		// Token: 0x04023601 RID: 144897
		[Nullable(2)]
		private Action OnSelectedItem;

		// Token: 0x04023602 RID: 144898
		[Nullable(2)]
		private Action OnPlacedItem;

		// Token: 0x0200CB80 RID: 52096
		[NullableContext(0)]
		public enum EComponentType
		{
			// Token: 0x0403D6FA RID: 251642
			BackgroundGridLayout,
			// Token: 0x0403D6FB RID: 251643
			BackgroundItem,
			// Token: 0x0403D6FC RID: 251644
			StateGridLayout,
			// Token: 0x0403D6FD RID: 251645
			StateGridItem,
			// Token: 0x0403D6FE RID: 251646
			ContentItem,
			// Token: 0x0403D6FF RID: 251647
			ContentSphereNiagara,
			// Token: 0x0403D700 RID: 251648
			ContentIconNiagara,
			// Token: 0x0403D701 RID: 251649
			DragComponent,
			// Token: 0x0403D702 RID: 251650
			DragItem,
			// Token: 0x0403D703 RID: 251651
			DragSphereNiagara,
			// Token: 0x0403D704 RID: 251652
			DragIconNiagara,
			// Token: 0x0403D705 RID: 251653
			SelectFrameItem,
			// Token: 0x0403D706 RID: 251654
			StartNiagara,
			// Token: 0x0403D707 RID: 251655
			ResetNiagara,
			// Token: 0x0403D708 RID: 251656
			SucceedNiagara
		}
	}
}
