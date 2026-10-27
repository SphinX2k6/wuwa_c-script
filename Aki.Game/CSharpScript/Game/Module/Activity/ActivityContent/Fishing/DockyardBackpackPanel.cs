using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200658E RID: 25998
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardBackpackPanel : UiPanelBase
	{
		// Token: 0x060412A5 RID: 266917 RVA: 0x00FCB348 File Offset: 0x00FC9548
		public DockyardBackpackPanel(DockyardBackpackPanelModelBase panelModel)
		{
			this.PanelModel = panelModel;
			this.PanelModel.InitPanel(this);
		}

		// Token: 0x060412A6 RID: 266918 RVA: 0x00FCB404 File Offset: 0x00FC9604
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 8;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.PanelModel.OnSellClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.PanelModel.OnTrawlClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.PanelModel.OnDeleteClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.PanelModel.OnRotateClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.PanelModel.OnConfirmClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.PanelModel.OnAllSellClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.PanelModel.OnBackToWareHouseClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.PanelModel.OnMaskClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060412A7 RID: 266919 RVA: 0x00FCB7C4 File Offset: 0x00FC99C4
		private void InitTickSystem()
		{
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.PanelModel.BackpackTick), "DockyardBackpackPanel", ETickingGroup.TG_PrePhysics, true, 0, true);
			this.TickId = ((ticker != null) ? ticker.Id : -1);
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x060412A8 RID: 266920 RVA: 0x00FCB824 File Offset: 0x00FC9A24
		private void InitOther()
		{
			this.Sell = new DockyardBackpackPanel.ButtonSequencePlayer(base.GetExtendToggle(4).RootUIComp);
			this.Trawl = new DockyardBackpackPanel.ButtonSequencePlayer(base.GetExtendToggle(5).RootUIComp);
			this.Delete = new DockyardBackpackPanel.ButtonSequencePlayer(base.GetButton(6).RootUIComp);
			this.Rotate = new DockyardBackpackPanel.ButtonSequencePlayer(base.GetButton(7).RootUIComp);
			this.Confirm = new DockyardBackpackPanel.ButtonSequencePlayer(base.GetButton(8).RootUIComp);
			this.AllSell = new DockyardBackpackPanel.ButtonSequencePlayer(base.GetButton(10).RootUIComp);
			this.BackToWareHouse = new DockyardBackpackPanel.ButtonSequencePlayer(base.GetButton(11).RootUIComp);
			this.GridItem = base.GetItem(2);
			this.AttachItem = base.GetItem(9);
			this.DragRoot = base.GetItem(3);
			this.ConfirmBtn = base.GetButton(8);
			this.ConfirmBtn.SetCanClickWhenDisable(true);
			this.ConfirmInteractive = this.ConfirmBtn.IsSelfInteractive;
			this.SetQuickSellToggleState();
			this.SetTrawlToggleState();
			this.SetConfirmNiagaraActive(false);
			this.SetQuicklySellRedDotState(false);
		}

		// Token: 0x060412A9 RID: 266921 RVA: 0x00FCB963 File Offset: 0x00FC9B63
		private void SetQuickSellToggleState()
		{
			this.Sell.SetActive(this.PanelModel.IsQuickSellOpen());
			EventSystem.Instance.Emit<bool>(EEventName.OnFishingBackpackQuickSellToggleStateChange, this.PanelModel.IsQuickSellOpen());
		}

		// Token: 0x060412AA RID: 266922 RVA: 0x00FCB996 File Offset: 0x00FC9B96
		private void SetTrawlToggleState()
		{
			this.Trawl.SetActive(this.PanelModel.GetIsTrawlOpen());
		}

		// Token: 0x060412AB RID: 266923 RVA: 0x00FCB9B0 File Offset: 0x00FC9BB0
		private UniTask InitLayout()
		{
			DockyardBackpackPanel.<InitLayout>d__31 <InitLayout>d__;
			<InitLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLayout>d__.<>4__this = this;
			<InitLayout>d__.<>1__state = -1;
			<InitLayout>d__.<>t__builder.Start<DockyardBackpackPanel.<InitLayout>d__31>(ref <InitLayout>d__);
			return <InitLayout>d__.<>t__builder.Task;
		}

		// Token: 0x060412AC RID: 266924 RVA: 0x00FCB9F4 File Offset: 0x00FC9BF4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<DockyardItemBlock> CreateItemBlock(DockyardItemBlockData itemData, UUIItem parentItem)
		{
			DockyardBackpackPanel.<CreateItemBlock>d__32 <CreateItemBlock>d__;
			<CreateItemBlock>d__.<>t__builder = AsyncUniTaskMethodBuilder<DockyardItemBlock>.Create();
			<CreateItemBlock>d__.<>4__this = this;
			<CreateItemBlock>d__.itemData = itemData;
			<CreateItemBlock>d__.parentItem = parentItem;
			<CreateItemBlock>d__.<>1__state = -1;
			<CreateItemBlock>d__.<>t__builder.Start<DockyardBackpackPanel.<CreateItemBlock>d__32>(ref <CreateItemBlock>d__);
			return <CreateItemBlock>d__.<>t__builder.Task;
		}

		// Token: 0x060412AD RID: 266925 RVA: 0x00FCBA48 File Offset: 0x00FC9C48
		private void InitItemBlockState()
		{
			foreach (DockyardBackpackGrid dockyardBackpackGrid in this.Layout.GetLayoutItemList())
			{
				dockyardBackpackGrid.ResetPreviewBgForce();
			}
			foreach (DockyardItemBlock dockyardItemBlock in this.ItemBlockMap.Values)
			{
				dockyardItemBlock.InitAnchorOffset(this.GridItem.Width, this.GridItem.Height, dockyardItemBlock.GetData().LeftTopPosInPanel.RowIndex, dockyardItemBlock.GetData().LeftTopPosInPanel.ColIndex);
				this.RefreshBackpackGridState(dockyardItemBlock);
			}
		}

		// Token: 0x060412AE RID: 266926 RVA: 0x00FCBB20 File Offset: 0x00FC9D20
		private void RefreshTitle()
		{
			int backpackUseSize = DockyardModel.Instance.BackpackUseSize;
			int backpackSize = DockyardModel.Instance.BackpackSize;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Fishing_CabinCapacity", new <>z__ReadOnlyArray<object>(new object[]
			{
				backpackUseSize,
				backpackSize
			}));
		}

		// Token: 0x060412AF RID: 266927 RVA: 0x00FCBB78 File Offset: 0x00FC9D78
		private void RefreshTrawlRedDot()
		{
			bool uiactive = DockyardModel.Instance.GetTrawlDataList().Count > 0;
			UUIItem item = base.GetItem(12);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x060412B0 RID: 266928 RVA: 0x00FCBBAB File Offset: 0x00FC9DAB
		private void SetQuicklySellRedDotState(bool isActive)
		{
			UUIItem item = base.GetItem(14);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isActive);
		}

		// Token: 0x060412B1 RID: 266929 RVA: 0x00FCBBC0 File Offset: 0x00FC9DC0
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardBackpackPanel.<OnBeforeStartAsync>d__37 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardBackpackPanel.<OnBeforeStartAsync>d__37>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060412B2 RID: 266930 RVA: 0x00FCBC04 File Offset: 0x00FC9E04
		private UniTask RefreshPanel()
		{
			DockyardBackpackPanel.<RefreshPanel>d__38 <RefreshPanel>d__;
			<RefreshPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshPanel>d__.<>4__this = this;
			<RefreshPanel>d__.<>1__state = -1;
			<RefreshPanel>d__.<>t__builder.Start<DockyardBackpackPanel.<RefreshPanel>d__38>(ref <RefreshPanel>d__);
			return <RefreshPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060412B3 RID: 266931 RVA: 0x00FCBC48 File Offset: 0x00FC9E48
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			DockyardBackpackPanel.<OnBeforeShowAsyncImplement>d__39 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<DockyardBackpackPanel.<OnBeforeShowAsyncImplement>d__39>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060412B4 RID: 266932 RVA: 0x00FCBC8B File Offset: 0x00FC9E8B
		protected override void OnBeforeShow()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Resume(this.TickId);
			}
			EventSystem.Instance.Add(EEventName.FishingRefreshBackpackData, new Action(this.RefreshBackpackData));
		}

		// Token: 0x060412B5 RID: 266933 RVA: 0x00FCBCC3 File Offset: 0x00FC9EC3
		protected override void OnAfterHide()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
			EventSystem.Instance.Remove(EEventName.FishingRefreshBackpackData, new Action(this.RefreshBackpackData));
		}

		// Token: 0x060412B6 RID: 266934 RVA: 0x00FCBCFB File Offset: 0x00FC9EFB
		private void RefreshBackpackData()
		{
			this.RefreshTitle();
			this.RefreshTrawlRedDot();
		}

		// Token: 0x060412B7 RID: 266935 RVA: 0x00FCBD0C File Offset: 0x00FC9F0C
		protected override void OnBeforeDestroy()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
			this.Sell.Clear();
			this.Trawl.Clear();
			this.Delete.Clear();
			this.Rotate.Clear();
			this.Confirm.Clear();
			this.AllSell.Clear();
			this.BackToWareHouse.Clear();
		}

		// Token: 0x060412B8 RID: 266936 RVA: 0x00FCBD87 File Offset: 0x00FC9F87
		private DockyardBackpackGrid InitItem()
		{
			return new DockyardBackpackGrid(this.PanelModel);
		}

		// Token: 0x060412B9 RID: 266937 RVA: 0x00FCBD94 File Offset: 0x00FC9F94
		private void ChangeBackpackGridShowType(DockyardItemBlock itemBlock, IPanelPosRange rangePos)
		{
			this.OverlapMap.Clear();
			this.SelectItemBlockGridSet.Clear();
			this.UnValidGridOverlapSet.Clear();
			int num = Math.Max(rangePos.RowStartIndex, 0);
			int num2 = Math.Min(rangePos.RowEndIndex, 6);
			int num3 = Math.Max(rangePos.ColStartIndex, 0);
			int num4 = Math.Min(rangePos.ColEndIndex, 7);
			int uniqueId = itemBlock.GetUniqueId();
			bool flag = itemBlock.IsPartOutOfRange(rangePos, 7, 8);
			bool flag2 = false;
			for (int i = num; i <= num2; i++)
			{
				for (int j = num3; j <= num4; j++)
				{
					DockyardBackpackGrid itemGridInLayout = this.GetItemGridInLayout(i, j);
					if (itemGridInLayout != null)
					{
						int itemBlockId = itemGridInLayout.GetItemBlockId();
						if (!itemBlock.IsValidGridPos(i, j))
						{
							if (itemBlockId != -1)
							{
								this.UnValidGridOverlapSet.Add(itemBlockId);
							}
						}
						else
						{
							flag2 = (flag2 || itemGridInLayout.InDisable());
							this.SelectItemBlockGridSet.Add(itemGridInLayout);
							if ((itemBlockId != uniqueId && itemBlockId != -1) || flag)
							{
								List<DockyardBackpackGrid> list;
								if (!this.OverlapMap.TryGetValue(itemBlockId, out list))
								{
									list = new List<DockyardBackpackGrid>();
									this.OverlapMap.Add(itemBlockId, list);
								}
								list.Add(itemGridInLayout);
							}
						}
					}
				}
			}
			this.PanelModel.IsSetFail = (flag || this.OverlapMap.Count > 1 || flag2);
			this.PanelModel.IsDragFail = this.PanelModel.IsOutOfRange;
			if (this.PanelModel.IsInSelectState)
			{
				this.RefreshOverlapGridShowType(uniqueId);
				return;
			}
			this.RefreshOverlapGridFinishType(uniqueId);
		}

		// Token: 0x060412BA RID: 266938 RVA: 0x00FCBF2C File Offset: 0x00FCA12C
		private void ResetBackpackGridShowType(IPanelPosRange rangePos, int itemBlockId)
		{
			int num = (rangePos.RowStartIndex >= 0) ? rangePos.RowStartIndex : 0;
			int num2 = (rangePos.RowEndIndex < 7) ? rangePos.RowEndIndex : 6;
			int num3 = (rangePos.ColStartIndex >= 0) ? rangePos.ColStartIndex : 0;
			int num4 = (rangePos.ColEndIndex < 8) ? rangePos.ColEndIndex : 7;
			for (int i = num; i <= num2; i++)
			{
				for (int j = num3; j <= num4; j++)
				{
					DockyardBackpackGrid itemGridInLayout = this.GetItemGridInLayout(i, j);
					if (itemGridInLayout != null)
					{
						itemGridInLayout.ResetPreviewBg(itemBlockId);
					}
				}
			}
		}

		// Token: 0x060412BB RID: 266939 RVA: 0x00FCBFB4 File Offset: 0x00FCA1B4
		[NullableContext(2)]
		private DockyardItemBlock GetItemBlockById(int id)
		{
			DockyardItemBlock valueOrDefault = this.ItemBlockMap.GetValueOrDefault(id);
			if (valueOrDefault == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Dockyard;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "选择的道具不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ItemBlockId", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return valueOrDefault;
		}

		// Token: 0x060412BC RID: 266940 RVA: 0x00FCC004 File Offset: 0x00FCA204
		[NullableContext(2)]
		private DockyardBackpackGrid GetItemGridInLayout(int rowIndex, int colIndex)
		{
			IPanelPos backpackPosByPos = this.PanelModel.BackpackData.GetBackpackPosByPos(rowIndex, colIndex);
			if (backpackPosByPos == null)
			{
				return null;
			}
			return this.Layout.GetLayoutItemByKey(backpackPosByPos);
		}

		// Token: 0x060412BD RID: 266941 RVA: 0x00FCC038 File Offset: 0x00FCA238
		private void RefreshBackpackGridState(DockyardItemBlock itemBlock)
		{
			IPanelPosRange leftTopPosRangeByPanel = itemBlock.GetLeftTopPosRangeByPanel(this.DragRoot);
			this.ChangeBackpackGridShowType(itemBlock, leftTopPosRangeByPanel);
		}

		// Token: 0x060412BE RID: 266942 RVA: 0x00FCC05C File Offset: 0x00FCA25C
		private void RefreshOverlapGridShowType(int itemBlockId)
		{
			EFishingGridShowType showType = EFishingGridShowType.Preview;
			if (this.PanelModel.IsSetFail)
			{
				showType = EFishingGridShowType.MultiOccupancy;
			}
			else if (this.OverlapMap.Count == 1)
			{
				showType = EFishingGridShowType.SingleOccupancy;
			}
			foreach (DockyardBackpackGrid dockyardBackpackGrid in this.SelectItemBlockGridSet)
			{
				dockyardBackpackGrid.RefreshPreview(itemBlockId, showType);
			}
		}

		// Token: 0x060412BF RID: 266943 RVA: 0x00FCC0D4 File Offset: 0x00FCA2D4
		private void RefreshOverlapGridFinishType(int itemBlockId)
		{
			foreach (DockyardBackpackGrid dockyardBackpackGrid in this.SelectItemBlockGridSet)
			{
				dockyardBackpackGrid.RefreshPreview(itemBlockId, EFishingGridShowType.Finish);
			}
		}

		// Token: 0x060412C0 RID: 266944 RVA: 0x00FCC128 File Offset: 0x00FCA328
		private void PlaySelectItemBlockGridSequence(string sequenceName)
		{
			foreach (DockyardBackpackGrid dockyardBackpackGrid in this.SelectItemBlockGridSet)
			{
				dockyardBackpackGrid.PlaySequence(sequenceName);
			}
		}

		// Token: 0x060412C1 RID: 266945 RVA: 0x00FCC17C File Offset: 0x00FCA37C
		private void TryHandleRotateFail()
		{
			if (this.PanelModel.IsDragFail)
			{
				DockyardItemBlock inSelectItemBlock = this.InSelectItemBlock;
				if (inSelectItemBlock != null)
				{
					inSelectItemBlock.ResetToAppropriatePos(7, 8, this.DragRoot);
				}
				this.PanelModel.RefreshPanel(true);
			}
		}

		// Token: 0x060412C2 RID: 266946 RVA: 0x00FCC1B0 File Offset: 0x00FCA3B0
		private void SetDeleteBtnState(bool isInSelectState)
		{
			this.Delete.SetActive(this.PanelModel.IsDeleteOpen && isInSelectState);
		}

		// Token: 0x060412C3 RID: 266947 RVA: 0x00FCC1CC File Offset: 0x00FCA3CC
		public void SetButtonsState(bool isInSelectState)
		{
			this.SetDeleteBtnState(isInSelectState);
			this.Rotate.SetActive(isInSelectState);
			this.Confirm.SetActive(isInSelectState);
			this.BackToWareHouse.SetActive(isInSelectState && this.PanelModel.GetIsBackToWareHouseOpen());
			base.GetButton(13).RootUIComp.Get().SetUIActive(isInSelectState);
			base.GetItem(16).SetUIActive(isInSelectState);
			EventSystem.Instance.Emit<bool>(EEventName.FishingBackpackBtnStateChange, isInSelectState);
		}

		// Token: 0x060412C4 RID: 266948 RVA: 0x00FCC24E File Offset: 0x00FCA44E
		public void SetAllSellBtnState(bool isInSelectState)
		{
			this.AllSell.SetActive(this.PanelModel.IsAllSellOpen && !isInSelectState);
		}

		// Token: 0x060412C5 RID: 266949 RVA: 0x00FCC270 File Offset: 0x00FCA470
		public void SetItemBlockTextureMaskActive(bool isActive)
		{
			foreach (DockyardItemBlock dockyardItemBlock in this.ItemBlockMap.Values)
			{
				if (dockyardItemBlock.GetData().Data.IncId != this.PanelModel.InSelectedBlockId)
				{
					dockyardItemBlock.SetTextureMaskActive(isActive);
				}
			}
			foreach (DockyardBackpackGrid dockyardBackpackGrid in this.Layout.GetLayoutItemList())
			{
				if (dockyardBackpackGrid.GetItemBlockId() != -1)
				{
					dockyardBackpackGrid.SetSpriteMaskActive(isActive);
				}
			}
		}

		// Token: 0x060412C6 RID: 266950 RVA: 0x00FCC338 File Offset: 0x00FCA538
		public void RefreshAllBackpackGridState(bool checkRangeChange = true)
		{
			IPanelPosRange leftTopPosRangeByPanel = this.InSelectItemBlock.GetLeftTopPosRangeByPanel(this.DragRoot);
			bool flag = this.InSelectItemBlock.IsRangeChange(this.LastLeftTopPos, leftTopPosRangeByPanel);
			if (!flag && checkRangeChange)
			{
				DockyardPanelUtil.DeepCopyItemRangePos(this.LastLeftTopPos, leftTopPosRangeByPanel);
				return;
			}
			bool flag2 = this.InSelectItemBlock.IsOutOfRange(leftTopPosRangeByPanel, 7, 8);
			if (this.PanelModel.IsOutOfRange && flag2)
			{
				DockyardPanelUtil.DeepCopyItemRangePos(this.LastLeftTopPos, leftTopPosRangeByPanel);
				return;
			}
			this.PanelModel.IsMoved = (flag && this.PanelModel.IsInDragState);
			this.PanelModel.IsOutOfRange = flag2;
			this.ResetBackpackGridShowType(this.LastLeftTopPos, this.PanelModel.InSelectedBlockId);
			this.ChangeBackpackGridShowType(this.InSelectItemBlock, leftTopPosRangeByPanel);
			DockyardPanelUtil.DeepCopyItemRangePos(this.LastLeftTopPos, leftTopPosRangeByPanel);
		}

		// Token: 0x060412C7 RID: 266951 RVA: 0x00FCC404 File Offset: 0x00FCA604
		public void HandleDragFail()
		{
			this.InSelectItemBlock.AdsorbToAppropriatePosByAttachItem(this.AppropriatePos.RowStartIndex, this.AppropriatePos.ColStartIndex, this.DragRoot);
			this.PanelModel.RefreshPanel(true);
			this.PlaySelectItemBlockGridSequence("Success");
			if (!this.PanelModel.IsInHighlight)
			{
				this.HandleFinishConfirm();
				return;
			}
			this.SetButtonsState(true);
		}

		// Token: 0x060412C8 RID: 266952 RVA: 0x00FCC46C File Offset: 0x00FCA66C
		public void HandleDragSuccess()
		{
			DockyardPanelUtil.DeepCopyItemRangePos(this.AppropriatePos, this.LastLeftTopPos);
			this.InSelectItemBlock.AdsorbToAppropriatePosByAttachItem(this.AppropriatePos.RowStartIndex, this.AppropriatePos.ColStartIndex, this.DragRoot);
			string sequenceName = this.PanelModel.IsSetFail ? "Fail" : "Success";
			this.PlaySelectItemBlockGridSequence(sequenceName);
			if (!this.PanelModel.IsInHighlight && this.PanelModel.IsMoved)
			{
				this.PanelModel.OnConfirmClick();
				return;
			}
			this.SetButtonsState(true);
		}

		// Token: 0x060412C9 RID: 266953 RVA: 0x00FCC4FF File Offset: 0x00FCA6FF
		public void SetItemBlockToWareHouse()
		{
			this.PanelModel.SetItemBlockToWareHouse(this.InSelectItemBlock.GetData().Data);
			this.DestroySelectItemBlock();
			this.TryRefreshQuicklySellPanel();
		}

		// Token: 0x060412CA RID: 266954 RVA: 0x00FCC528 File Offset: 0x00FCA728
		public bool CanDrag(int id)
		{
			return this.PanelModel.InSelectedBlockId == -1 || this.PanelModel.InSelectedBlockId == id;
		}

		// Token: 0x060412CB RID: 266955 RVA: 0x00FCC548 File Offset: 0x00FCA748
		public void ItemBlockClick(int id)
		{
			this.PanelModel.InSelectedBlockId = id;
			this.PanelModel.IsInSelectState = true;
			this.InSelectItemBlock = this.GetItemBlockById(id);
			this.LastLeftTopPos = this.InSelectItemBlock.GetLeftTopPosRangeByPanel(this.DragRoot);
			DockyardPanelUtil.DeepCopyItemRangePos(this.AppropriatePos, this.LastLeftTopPos);
			this.InSelectItemBlock.SetItemBlockSelectState(true);
			this.InSelectItemBlock.SetUiParent(this.DragRoot);
			this.PanelModel.RefreshPanel(false);
		}

		// Token: 0x060412CC RID: 266956 RVA: 0x00FCC5CC File Offset: 0x00FCA7CC
		public void RotateClick()
		{
			this.InSelectItemBlock.RotateBlock();
			this.PanelModel.RefreshPanel(false);
			this.TryHandleRotateFail();
			string sequenceName = this.PanelModel.IsSetFail ? "Fail" : "Success";
			this.PlaySelectItemBlockGridSequence(sequenceName);
		}

		// Token: 0x060412CD RID: 266957 RVA: 0x00FCC617 File Offset: 0x00FCA817
		public bool CanConfirm()
		{
			return this.ConfirmBtn.IsSelfInteractive;
		}

		// Token: 0x060412CE RID: 266958 RVA: 0x00FCC624 File Offset: 0x00FCA824
		public bool IsOverlap()
		{
			return this.OverlapMap.Count == 1;
		}

		// Token: 0x060412CF RID: 266959 RVA: 0x00FCC634 File Offset: 0x00FCA834
		public void HandleOverlapConfirm()
		{
			this.PanelModel.IsInSelectState = false;
			this.InSelectItemBlock.SetItemBlockSelectState(false);
			this.InSelectItemBlock.SetUiParent(this.AttachItem);
			this.InSelectItemBlock.PlaySelectSequence("PutIn");
			this.PlaySelectItemBlockGridSequence("PutIn");
			this.RefreshBackpackGridState(this.InSelectItemBlock);
			int key = this.OverlapMap.Keys.First<int>();
			foreach (DockyardBackpackGrid dockyardBackpackGrid in this.OverlapMap[key])
			{
				dockyardBackpackGrid.SetItemBlockId(this.PanelModel.InSelectedBlockId);
			}
			this.PanelModel.OnItemBlockClick(this.OverlapMap.Keys.First<int>());
			this.InSelectItemBlock.PlaySelectSequence("Grab");
			this.SetButtonsState(true);
			this.TryRefreshQuicklySellPanel();
		}

		// Token: 0x060412D0 RID: 266960 RVA: 0x00FCC730 File Offset: 0x00FCA930
		public void HandleFinishConfirm()
		{
			this.PanelModel.IsInSelectState = false;
			this.InSelectItemBlock.SetItemBlockSelectState(false);
			this.InSelectItemBlock.SetUiParent(this.AttachItem);
			this.InSelectItemBlock.PlaySelectSequence("PutIn");
			this.PlaySelectItemBlockGridSequence("PutIn");
			this.RefreshBackpackGridState(this.InSelectItemBlock);
			this.PanelModel.InSelectedBlockId = -1;
			this.InSelectItemBlock = null;
			this.TryRefreshQuicklySellPanel();
		}

		// Token: 0x060412D1 RID: 266961 RVA: 0x00FCC7A8 File Offset: 0x00FCA9A8
		public List<FishingItemInfo> GetItemBlockDataList()
		{
			List<FishingItemInfo> list = new List<FishingItemInfo>();
			foreach (DockyardItemBlock dockyardItemBlock in this.ItemBlockMap.Values)
			{
				DockyardItemBlockData data = dockyardItemBlock.GetData();
				FishingItemInfo item = DockyardPanelUtil.CreateFishingItemInfo(data.Data, data.Rotate, data.LeftTopPosInPanel);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060412D2 RID: 266962 RVA: 0x00FCC824 File Offset: 0x00FCAA24
		[NullableContext(2)]
		public DockyardItemBlockOriginalData GetOriginalItemBlockDataByIncId(int incId)
		{
			foreach (DockyardItemBlock dockyardItemBlock in this.ItemBlockMap.Values)
			{
				DockyardItemBlockData data = dockyardItemBlock.GetData();
				if (data.Data.IncId == incId)
				{
					return data.Data;
				}
			}
			return null;
		}

		// Token: 0x060412D3 RID: 266963 RVA: 0x00FCC894 File Offset: 0x00FCAA94
		public List<FishingItemInfo> GetItemBlockDataListExcludeSelected()
		{
			List<FishingItemInfo> list = new List<FishingItemInfo>();
			foreach (DockyardItemBlock dockyardItemBlock in this.ItemBlockMap.Values)
			{
				if (dockyardItemBlock.GetData().Data.IncId != this.PanelModel.InSelectedBlockId)
				{
					DockyardItemBlockData data = dockyardItemBlock.GetData();
					FishingItemInfo item = DockyardPanelUtil.CreateFishingItemInfo(data.Data, data.Rotate, data.LeftTopPosInPanel);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060412D4 RID: 266964 RVA: 0x00FCC934 File Offset: 0x00FCAB34
		public List<int> GetQuicklySellItemIdList()
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int key in this.PanelModel.TempQuicklySellIncIdSet)
			{
				DockyardItemBlock valueOrDefault = this.ItemBlockMap.GetValueOrDefault(key);
				if (valueOrDefault != null)
				{
					hashSet.Add(valueOrDefault.GetItemId());
				}
			}
			return hashSet.ToList<int>();
		}

		// Token: 0x060412D5 RID: 266965 RVA: 0x00FCC9B0 File Offset: 0x00FCABB0
		public void SetConfirmInteractive(bool isInteractive)
		{
			if (this.ConfirmInteractive == isInteractive)
			{
				return;
			}
			this.ConfirmInteractive = isInteractive;
			this.ConfirmBtn.SetSelfInteractive(isInteractive);
		}

		// Token: 0x060412D6 RID: 266966 RVA: 0x00FCC9CF File Offset: 0x00FCABCF
		public void SetConfirmNiagaraActive(bool active)
		{
			base.GetItem(15).SetUIActive(active);
		}

		// Token: 0x060412D7 RID: 266967 RVA: 0x00FCC9E0 File Offset: 0x00FCABE0
		private void ItemBlockMove(float delta)
		{
			bool flag = LguiEventSystemManager.Instance.IsPressComponentIsValid(0);
			bool flag2 = LguiEventSystemManager.Instance.IsNowTriggerPressed(0);
			if (!flag && !flag2)
			{
				DockyardItemBlock inSelectItemBlock = this.InSelectItemBlock;
				if (inSelectItemBlock != null)
				{
					inSelectItemBlock.OnDragEnd(null);
				}
				this.RemoveItemDragTick();
				return;
			}
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, true);
			DockyardItemBlock inSelectItemBlock2 = this.InSelectItemBlock;
			if (inSelectItemBlock2 == null)
			{
				return;
			}
			inSelectItemBlock2.OnDrag(pointerEventData);
		}

		// Token: 0x060412D8 RID: 266968 RVA: 0x00FCCA40 File Offset: 0x00FCAC40
		private void AddItemDragTick()
		{
			this.RemoveItemDragTick();
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.ItemBlockMove), "CheckItemBlockMove", ETickingGroup.TG_PrePhysics, true, 0, true);
			this.ListDragTick = ((ticker != null) ? ticker.Id : -1);
		}

		// Token: 0x060412D9 RID: 266969 RVA: 0x00FCCA79 File Offset: 0x00FCAC79
		private void RemoveItemDragTick()
		{
			if (this.ListDragTick != -1)
			{
				TickSystem.Instance.Remove(this.ListDragTick);
				this.ListDragTick = -1;
			}
		}

		// Token: 0x060412DA RID: 266970 RVA: 0x00FCCA9C File Offset: 0x00FCAC9C
		public void DestroyItemBlockById(int id)
		{
			DockyardItemBlock dockyardItemBlock = this.ItemBlockMap[id];
			this.ResetBackpackGridShowType(dockyardItemBlock.GetData().PanelRange, id);
			this.ItemBlockMap.Remove(id);
			this.PanelModel.BackpackData.DeleteItemBlockData(id);
			dockyardItemBlock.Destroy(null);
		}

		// Token: 0x060412DB RID: 266971 RVA: 0x00FCCAF0 File Offset: 0x00FCACF0
		public void DestroySelectItemBlock()
		{
			this.ResetBackpackGridShowType(this.LastLeftTopPos, this.PanelModel.InSelectedBlockId);
			this.PanelModel.IsInSelectState = false;
			this.ItemBlockMap.Remove(this.PanelModel.InSelectedBlockId);
			this.PanelModel.BackpackData.DeleteItemBlockData(this.PanelModel.InSelectedBlockId);
			DockyardItemBlock inSelectItemBlock = this.InSelectItemBlock;
			if (inSelectItemBlock != null)
			{
				inSelectItemBlock.Destroy(null);
			}
			this.PanelModel.InSelectedBlockId = -1;
			this.InSelectItemBlock = null;
		}

		// Token: 0x060412DC RID: 266972 RVA: 0x00FCCB78 File Offset: 0x00FCAD78
		public UniTask CreateItemBlockByView(DockyardItemBlockOriginalData itemData)
		{
			DockyardBackpackPanel.<CreateItemBlockByView>d__80 <CreateItemBlockByView>d__;
			<CreateItemBlockByView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemBlockByView>d__.<>4__this = this;
			<CreateItemBlockByView>d__.itemData = itemData;
			<CreateItemBlockByView>d__.<>1__state = -1;
			<CreateItemBlockByView>d__.<>t__builder.Start<DockyardBackpackPanel.<CreateItemBlockByView>d__80>(ref <CreateItemBlockByView>d__);
			return <CreateItemBlockByView>d__.<>t__builder.Task;
		}

		// Token: 0x060412DD RID: 266973 RVA: 0x00FCCBC4 File Offset: 0x00FCADC4
		public UniTask CreateItemBlockByViewAndFollow(DockyardItemBlockOriginalData itemData)
		{
			DockyardBackpackPanel.<CreateItemBlockByViewAndFollow>d__81 <CreateItemBlockByViewAndFollow>d__;
			<CreateItemBlockByViewAndFollow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemBlockByViewAndFollow>d__.<>4__this = this;
			<CreateItemBlockByViewAndFollow>d__.itemData = itemData;
			<CreateItemBlockByViewAndFollow>d__.<>1__state = -1;
			<CreateItemBlockByViewAndFollow>d__.<>t__builder.Start<DockyardBackpackPanel.<CreateItemBlockByViewAndFollow>d__81>(ref <CreateItemBlockByViewAndFollow>d__);
			return <CreateItemBlockByViewAndFollow>d__.<>t__builder.Task;
		}

		// Token: 0x060412DE RID: 266974 RVA: 0x00FCCC0F File Offset: 0x00FCAE0F
		public bool IsWareHouseDragToBackpack()
		{
			return this.ListDragTick != -1;
		}

		// Token: 0x060412DF RID: 266975 RVA: 0x00FCCC20 File Offset: 0x00FCAE20
		public void ReplaceSelectItemBlock(DockyardItemBlockOriginalData itemData)
		{
			this.PanelModel.IsInSelectState = false;
			this.PanelModel.BackpackData.DeleteItemBlockData(this.PanelModel.InSelectedBlockId);
			this.ItemBlockMap.Remove(this.PanelModel.InSelectedBlockId);
			this.PanelModel.BackpackData.AddItemBlockData(itemData);
			this.ItemBlockMap.Add(itemData.IncId, this.InSelectItemBlock);
			DockyardItemBlock inSelectItemBlock = this.InSelectItemBlock;
			if (inSelectItemBlock != null)
			{
				inSelectItemBlock.GetData().RefreshData(itemData);
			}
			DockyardBackpackPanelModelBase panelModel = this.PanelModel;
			if (panelModel == null)
			{
				return;
			}
			panelModel.OnItemBlockClick(itemData.IncId);
		}

		// Token: 0x060412E0 RID: 266976 RVA: 0x00FCCCC4 File Offset: 0x00FCAEC4
		private UniTask InitQuicklySellPanel()
		{
			DockyardBackpackPanel.<InitQuicklySellPanel>d__86 <InitQuicklySellPanel>d__;
			<InitQuicklySellPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitQuicklySellPanel>d__.<>4__this = this;
			<InitQuicklySellPanel>d__.<>1__state = -1;
			<InitQuicklySellPanel>d__.<>t__builder.Start<DockyardBackpackPanel.<InitQuicklySellPanel>d__86>(ref <InitQuicklySellPanel>d__);
			return <InitQuicklySellPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060412E1 RID: 266977 RVA: 0x00FCCD08 File Offset: 0x00FCAF08
		public void ShowQuicklySellPanel()
		{
			HashSet<int> failIncIdSet = this.RefreshQuicklySellPanel();
			this.RefreshQuicklySellGridState(failIncIdSet);
			DockyardQuicklySellPanel quicklySellPanel = this.QuicklySellPanel;
			if (quicklySellPanel == null)
			{
				return;
			}
			quicklySellPanel.SetPanelVisible(true);
		}

		// Token: 0x060412E2 RID: 266978 RVA: 0x00FCCD34 File Offset: 0x00FCAF34
		public void HideQuicklySellPanel()
		{
			this.ResetQuicklySellGridState();
			DockyardQuicklySellPanel quicklySellPanel = this.QuicklySellPanel;
			if (quicklySellPanel == null)
			{
				return;
			}
			quicklySellPanel.SetPanelVisible(false);
		}

		// Token: 0x060412E3 RID: 266979 RVA: 0x00FCCD4D File Offset: 0x00FCAF4D
		public void CloseQuicklySellPanel()
		{
			this.PanelModel.RefreshBackpackQuicklySellData();
			this.ResetQuicklySellGridState();
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			}
			this.SetQuickSellToggleState();
			this.SetQuicklySellRedDotState(false);
		}

		// Token: 0x060412E4 RID: 266980 RVA: 0x00FCCD84 File Offset: 0x00FCAF84
		private HashSet<int> RefreshQuicklySellPanel()
		{
			if (this.QuicklySellPanel == null)
			{
				return new HashSet<int>();
			}
			this.PanelModel.TempQuicklySellType = EBackpackQuicklySellType.Full;
			this.PanelModel.TempQuicklySellIncIdSet.Clear();
			HashSet<int> hashSet = new HashSet<int>();
			foreach (DockyardBackpackGrid dockyardBackpackGrid in this.Layout.GetLayoutItemList())
			{
				int itemBlockId = dockyardBackpackGrid.GetItemBlockId();
				if (dockyardBackpackGrid.IsQuicklySell())
				{
					if (itemBlockId == -1)
					{
						this.PanelModel.TempQuicklySellType = EBackpackQuicklySellType.RangeError;
					}
					else
					{
						this.PanelModel.TempQuicklySellIncIdSet.Add(itemBlockId);
						if (this.PanelModel.TempQuicklySellType == EBackpackQuicklySellType.Full && !this.ItemBlockMap[itemBlockId].GetData().Data.IsCanSell)
						{
							this.PanelModel.TempQuicklySellType = EBackpackQuicklySellType.ItemError;
							hashSet.Add(itemBlockId);
						}
					}
				}
			}
			if (!this.PanelModel.IsInSelectState)
			{
				int allSellPrice = this.GetAllSellPrice(hashSet);
				DockyardQuicklySellPanel quicklySellPanel = this.QuicklySellPanel;
				if (quicklySellPanel != null)
				{
					quicklySellPanel.RefreshPanel(allSellPrice, this.PanelModel.TempQuicklySellType);
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Dockyard;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "快速出售总价格";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("allSellPrice", allSellPrice);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.SetQuicklySellRedDotState(this.PanelModel.TempQuicklySellType == EBackpackQuicklySellType.Full);
			return hashSet;
		}

		// Token: 0x060412E5 RID: 266981 RVA: 0x00FCCEF0 File Offset: 0x00FCB0F0
		private int GetAllSellPrice(HashSet<int> failIncIdSet)
		{
			int num = 0;
			foreach (int num2 in this.PanelModel.TempQuicklySellIncIdSet)
			{
				if (!failIncIdSet.Contains(num2))
				{
					int price = this.ItemBlockMap[num2].GetData().Data.Price;
					num += price;
				}
			}
			float quicklySellRatio = DockyardModel.Instance.GetQuicklySellRatio();
			num += (int)Math.Floor((double)((float)num * quicklySellRatio) / 100.0);
			return num;
		}

		// Token: 0x060412E6 RID: 266982 RVA: 0x00FCCF94 File Offset: 0x00FCB194
		private void RefreshQuicklySellGridState(HashSet<int> failIncIdSet)
		{
			foreach (DockyardBackpackGrid dockyardBackpackGrid in this.QuicklySellGridSet)
			{
				int itemBlockId = dockyardBackpackGrid.GetItemBlockId();
				if (failIncIdSet.Contains(itemBlockId) || itemBlockId == -1)
				{
					dockyardBackpackGrid.RefreshQuicklySell(EFishingQuicklySellType.QuicklySellFailure);
				}
				else
				{
					dockyardBackpackGrid.RefreshQuicklySell(EFishingQuicklySellType.QuicklySellSuccess);
				}
			}
		}

		// Token: 0x060412E7 RID: 266983 RVA: 0x00FCD004 File Offset: 0x00FCB204
		private void ResetQuicklySellGridState()
		{
			foreach (DockyardBackpackGrid dockyardBackpackGrid in this.QuicklySellGridSet)
			{
				dockyardBackpackGrid.ResetQuicklySell();
			}
		}

		// Token: 0x060412E8 RID: 266984 RVA: 0x00FCD054 File Offset: 0x00FCB254
		private void TryRefreshQuicklySellPanel()
		{
			if (!this.PanelModel.IsQuickSellOpen())
			{
				return;
			}
			HashSet<int> failIncIdSet = this.RefreshQuicklySellPanel();
			DockyardQuicklySellPanel quicklySellPanel = this.QuicklySellPanel;
			if (quicklySellPanel == null || !quicklySellPanel.IsShowOrShowing)
			{
				return;
			}
			this.RefreshQuicklySellGridState(failIncIdSet);
		}

		// Token: 0x04021F13 RID: 139027
		[Nullable(2)]
		public DockyardItemBlock InSelectItemBlock;

		// Token: 0x04021F14 RID: 139028
		private readonly Dictionary<int, List<DockyardBackpackGrid>> OverlapMap = new Dictionary<int, List<DockyardBackpackGrid>>();

		// Token: 0x04021F15 RID: 139029
		private readonly HashSet<DockyardBackpackGrid> SelectItemBlockGridSet = new HashSet<DockyardBackpackGrid>();

		// Token: 0x04021F16 RID: 139030
		private readonly HashSet<int> UnValidGridOverlapSet = new HashSet<int>();

		// Token: 0x04021F17 RID: 139031
		protected GenericLayout<DockyardBackpackGrid, IPanelPos> Layout;

		// Token: 0x04021F18 RID: 139032
		protected Dictionary<int, DockyardItemBlock> ItemBlockMap = new Dictionary<int, DockyardItemBlock>();

		// Token: 0x04021F19 RID: 139033
		private int TickId = -1;

		// Token: 0x04021F1A RID: 139034
		public readonly DockyardBackpackPanelModelBase PanelModel;

		// Token: 0x04021F1B RID: 139035
		private UUIButtonComponent ConfirmBtn;

		// Token: 0x04021F1C RID: 139036
		private bool ConfirmInteractive;

		// Token: 0x04021F1D RID: 139037
		private UUIItem AttachItem;

		// Token: 0x04021F1E RID: 139038
		public UUIItem DragRoot;

		// Token: 0x04021F1F RID: 139039
		private UUIItem GridItem;

		// Token: 0x04021F20 RID: 139040
		private int ListDragTick = -1;

		// Token: 0x04021F21 RID: 139041
		private IPanelPosRange LastLeftTopPos = new PanelPosRange
		{
			RowStartIndex = -1,
			RowEndIndex = -1,
			ColStartIndex = -1,
			ColEndIndex = -1
		};

		// Token: 0x04021F22 RID: 139042
		private readonly IPanelPosRange AppropriatePos = new PanelPosRange
		{
			RowStartIndex = -1,
			RowEndIndex = -1,
			ColStartIndex = -1,
			ColEndIndex = -1
		};

		// Token: 0x04021F23 RID: 139043
		private DockyardBackpackPanel.ButtonSequencePlayer Sell;

		// Token: 0x04021F24 RID: 139044
		private DockyardBackpackPanel.ButtonSequencePlayer Trawl;

		// Token: 0x04021F25 RID: 139045
		private DockyardBackpackPanel.ButtonSequencePlayer Delete;

		// Token: 0x04021F26 RID: 139046
		private DockyardBackpackPanel.ButtonSequencePlayer Rotate;

		// Token: 0x04021F27 RID: 139047
		private DockyardBackpackPanel.ButtonSequencePlayer Confirm;

		// Token: 0x04021F28 RID: 139048
		private DockyardBackpackPanel.ButtonSequencePlayer AllSell;

		// Token: 0x04021F29 RID: 139049
		private DockyardBackpackPanel.ButtonSequencePlayer BackToWareHouse;

		// Token: 0x04021F2A RID: 139050
		[Nullable(2)]
		protected DockyardQuicklySellPanel QuicklySellPanel;

		// Token: 0x04021F2B RID: 139051
		private readonly HashSet<DockyardBackpackGrid> QuicklySellGridSet = new HashSet<DockyardBackpackGrid>();

		// Token: 0x0200C78A RID: 51082
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C485 RID: 246917
			public const int Title = 0;

			// Token: 0x0403C486 RID: 246918
			public const int Layout = 1;

			// Token: 0x0403C487 RID: 246919
			public const int GridItem = 2;

			// Token: 0x0403C488 RID: 246920
			public const int DragRoot = 3;

			// Token: 0x0403C489 RID: 246921
			public const int SellToggle = 4;

			// Token: 0x0403C48A RID: 246922
			public const int TrawlToggle = 5;

			// Token: 0x0403C48B RID: 246923
			public const int DeleteBtn = 6;

			// Token: 0x0403C48C RID: 246924
			public const int RotateBtn = 7;

			// Token: 0x0403C48D RID: 246925
			public const int ConfirmBtn = 8;

			// Token: 0x0403C48E RID: 246926
			public const int ItemRoot = 9;

			// Token: 0x0403C48F RID: 246927
			public const int AllSellBtn = 10;

			// Token: 0x0403C490 RID: 246928
			public const int BackToWareHouseBtn = 11;

			// Token: 0x0403C491 RID: 246929
			public const int TrawlRedDot = 12;

			// Token: 0x0403C492 RID: 246930
			public const int MaskBtn = 13;

			// Token: 0x0403C493 RID: 246931
			public const int QuickSellNiagara = 14;

			// Token: 0x0403C494 RID: 246932
			public const int ConfirmNiagara = 15;

			// Token: 0x0403C495 RID: 246933
			public const int BottomBtnParent = 16;
		}

		// Token: 0x0200C78B RID: 51083
		[Nullable(0)]
		private class ButtonSequencePlayer
		{
			// Token: 0x06050FA5 RID: 331685 RVA: 0x015E3F12 File Offset: 0x015E2112
			public ButtonSequencePlayer(UUIItem uiItem)
			{
				this.UiItem = uiItem;
				this.SequencePlayer = new UiSequencePlayer(this.UiItem);
			}

			// Token: 0x06050FA6 RID: 331686 RVA: 0x015E3F32 File Offset: 0x015E2132
			public void SetActive(bool active)
			{
				this.UiItem.SetUIActive(active);
				if (active)
				{
					this.SequencePlayer.PlaySequencePurely("Show", false, false);
				}
			}

			// Token: 0x06050FA7 RID: 331687 RVA: 0x015E3F55 File Offset: 0x015E2155
			public void Clear()
			{
				this.SequencePlayer.Clear();
			}

			// Token: 0x0403C496 RID: 246934
			private readonly UiSequencePlayer SequencePlayer;

			// Token: 0x0403C497 RID: 246935
			private readonly UUIItem UiItem;
		}
	}
}
