using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065A9 RID: 26025
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractPanel : UiPanelBase
	{
		// Token: 0x06041400 RID: 267264 RVA: 0x00FCFAA0 File Offset: 0x00FCDCA0
		public DockyardInteractPanel(DockyardInteractPanelModel panelModel)
		{
			this.PanelModel = panelModel;
			this.PanelModel.InitPanel(this);
		}

		// Token: 0x06041401 RID: 267265 RVA: 0x00FCFB2C File Offset: 0x00FCDD2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06041402 RID: 267266 RVA: 0x00FCFBB6 File Offset: 0x00FCDDB6
		private void InitOther()
		{
			this.AttachItem = base.GetItem(2);
		}

		// Token: 0x06041403 RID: 267267 RVA: 0x00FCFBC8 File Offset: 0x00FCDDC8
		private UniTask InitLayout()
		{
			DockyardInteractPanel.<InitLayout>d__11 <InitLayout>d__;
			<InitLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLayout>d__.<>4__this = this;
			<InitLayout>d__.<>1__state = -1;
			<InitLayout>d__.<>t__builder.Start<DockyardInteractPanel.<InitLayout>d__11>(ref <InitLayout>d__);
			return <InitLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06041404 RID: 267268 RVA: 0x00FCFC0C File Offset: 0x00FCDE0C
		private UniTask InitInteractItemBlock(int itemId, IntArray dataList, float gridWidth)
		{
			DockyardInteractPanel.<InitInteractItemBlock>d__12 <InitInteractItemBlock>d__;
			<InitInteractItemBlock>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitInteractItemBlock>d__.<>4__this = this;
			<InitInteractItemBlock>d__.itemId = itemId;
			<InitInteractItemBlock>d__.dataList = dataList;
			<InitInteractItemBlock>d__.gridWidth = gridWidth;
			<InitInteractItemBlock>d__.<>1__state = -1;
			<InitInteractItemBlock>d__.<>t__builder.Start<DockyardInteractPanel.<InitInteractItemBlock>d__12>(ref <InitInteractItemBlock>d__);
			return <InitInteractItemBlock>d__.<>t__builder.Task;
		}

		// Token: 0x06041405 RID: 267269 RVA: 0x00FCFC68 File Offset: 0x00FCDE68
		private UniTask InitAllInteractItemBlock()
		{
			DockyardInteractPanel.<InitAllInteractItemBlock>d__13 <InitAllInteractItemBlock>d__;
			<InitAllInteractItemBlock>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAllInteractItemBlock>d__.<>4__this = this;
			<InitAllInteractItemBlock>d__.<>1__state = -1;
			<InitAllInteractItemBlock>d__.<>t__builder.Start<DockyardInteractPanel.<InitAllInteractItemBlock>d__13>(ref <InitAllInteractItemBlock>d__);
			return <InitAllInteractItemBlock>d__.<>t__builder.Task;
		}

		// Token: 0x06041406 RID: 267270 RVA: 0x00FCFCAC File Offset: 0x00FCDEAC
		private void SetAllInteractItemBlockIncId()
		{
			Dictionary<int, DockyardItemBlockOriginalData> dataMapByInteract = FishingModel.Instance.GetDataMapByInteract(this.PanelModel.ConfigId);
			if (dataMapByInteract != null)
			{
				foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in dataMapByInteract.Values)
				{
					DockyardInteractItemBlock interactItemBlock = this.GetInteractItemBlock(dockyardItemBlockOriginalData.ItemId, dockyardItemBlockOriginalData.PosY, dockyardItemBlockOriginalData.PosX);
					if (interactItemBlock != null)
					{
						interactItemBlock.SetItemData(dockyardItemBlockOriginalData);
					}
				}
			}
		}

		// Token: 0x06041407 RID: 267271 RVA: 0x00FCFD34 File Offset: 0x00FCDF34
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardInteractPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardInteractPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041408 RID: 267272 RVA: 0x00FCFD77 File Offset: 0x00FCDF77
		private DockyardInteractGrid InitItem()
		{
			return new DockyardInteractGrid(this.PanelModel);
		}

		// Token: 0x06041409 RID: 267273 RVA: 0x00FCFD84 File Offset: 0x00FCDF84
		private DockyardInteractGrid GetItemGridInLayout(int rowIndex, int colIndex)
		{
			IPanelPos interactPosByPos = this.PanelModel.GetInteractPosByPos(rowIndex, colIndex);
			if (interactPosByPos == null)
			{
				return null;
			}
			return this.Layout.GetLayoutItemByKey(interactPosByPos);
		}

		// Token: 0x0604140A RID: 267274 RVA: 0x00FCFDB0 File Offset: 0x00FCDFB0
		private unsafe DockyardInteractItemBlock GetInteractItemBlock(int itemId, int rowIndex, int colIndex)
		{
			foreach (DockyardInteractItemBlock dockyardInteractItemBlock in this.InteractItemBlockSet)
			{
				if (dockyardInteractItemBlock.ItemId == itemId && dockyardInteractItemBlock.StartPos.ColIndex == colIndex && dockyardInteractItemBlock.StartPos.RowIndex == rowIndex)
				{
					return dockyardInteractItemBlock;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Dockyard;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "查找不到对应的InteractItemBlock";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ItemId", itemId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RowIndex", rowIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ColIndex", colIndex);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return null;
		}

		// Token: 0x0604140B RID: 267275 RVA: 0x00FCFEA8 File Offset: 0x00FCE0A8
		private void ResetBackpackGridShowType(IPanelPosRange rangePos)
		{
			int num = (rangePos.RowStartIndex >= 0) ? rangePos.RowStartIndex : 0;
			int num2 = (rangePos.RowEndIndex < 3 && rangePos.RowEndIndex >= 0) ? rangePos.RowEndIndex : 2;
			int num3 = (rangePos.ColStartIndex >= 0) ? rangePos.ColStartIndex : 0;
			int num4 = (rangePos.ColEndIndex < 6 && rangePos.ColEndIndex >= 0) ? rangePos.ColEndIndex : 5;
			for (int i = num; i <= num2; i++)
			{
				for (int j = num3; j <= num4; j++)
				{
					DockyardInteractGrid itemGridInLayout = this.GetItemGridInLayout(i, j);
					if (itemGridInLayout != null)
					{
						itemGridInLayout.ResetPreviewBg();
					}
				}
			}
		}

		// Token: 0x0604140C RID: 267276 RVA: 0x00FCFF44 File Offset: 0x00FCE144
		private void ChangeBackpackGridShowType(DockyardItemBlock itemBlock, IPanelPosRange rangePos)
		{
			this.InteractGridSet.Clear();
			int num = Math.Max(rangePos.RowStartIndex, 0);
			int num2 = Math.Min(rangePos.RowEndIndex, 2);
			int num3 = Math.Max(rangePos.ColStartIndex, 0);
			int num4 = Math.Min(rangePos.ColEndIndex, 5);
			int itemId = itemBlock.GetItemId();
			bool flag = itemBlock.IsPartOutOfRange(rangePos, 3, 6);
			bool flag2 = itemBlock.IsOutOfRange(rangePos, 3, 6);
			this.PanelModel.IsAllMatch = (!flag && !flag2);
			this.PanelModel.IsOverlapAnother = (!flag && !flag2);
			for (int i = num; i <= num2; i++)
			{
				for (int j = num3; j <= num4; j++)
				{
					if (itemBlock.IsValidGridPos(i, j))
					{
						DockyardInteractGrid itemGridInLayout = this.GetItemGridInLayout(i, j);
						if (itemGridInLayout != null)
						{
							this.InteractGridSet.Add(itemGridInLayout);
							if (itemGridInLayout.GetTargetItemId() != itemId)
							{
								this.PanelModel.IsAllMatch = false;
							}
							if (!itemGridInLayout.IsFinishInteract)
							{
								this.PanelModel.IsOverlapAnother = false;
							}
						}
					}
				}
			}
			if (this.PanelModel.IsAllMatch)
			{
				DockyardInteractItemBlock interactItemBlock = this.GetInteractItemBlock(itemId, rangePos.RowStartIndex, rangePos.ColStartIndex);
				if (interactItemBlock != null)
				{
					this.PanelModel.IsAllMatch = (interactItemBlock.RotateType == (int)itemBlock.GetData().Rotate);
					this.PanelModel.MatchPos.RowIndex = rangePos.RowStartIndex + interactItemBlock.ValidStartPos.RowIndex;
					this.PanelModel.MatchPos.ColIndex = rangePos.ColStartIndex + interactItemBlock.ValidStartPos.ColIndex;
				}
			}
			this.PanelModel.IsOverlapAnother &= this.PanelModel.IsAllMatch;
			foreach (DockyardInteractGrid dockyardInteractGrid in this.InteractGridSet)
			{
				dockyardInteractGrid.RefreshBgSprite(this.PanelModel.IsAllMatch);
			}
		}

		// Token: 0x0604140D RID: 267277 RVA: 0x00FD0148 File Offset: 0x00FCE348
		private void TryHandleRotateFail()
		{
			if (this.PanelModel.IsOutOfRange)
			{
				this.PanelModel.InSelectItemBlock.ResetToAppropriatePos(3, 6, this.AttachItem);
				this.RefreshAllBackpackGridState(true);
			}
		}

		// Token: 0x0604140E RID: 267278 RVA: 0x00FD0178 File Offset: 0x00FCE378
		private void RefreshBackpackGridState(DockyardItemBlock itemBlock)
		{
			IPanelPosRange leftTopPosRangeByPanel = itemBlock.GetLeftTopPosRangeByPanel(this.AttachItem);
			this.ChangeBackpackGridShowType(itemBlock, leftTopPosRangeByPanel);
		}

		// Token: 0x0604140F RID: 267279 RVA: 0x00FD019C File Offset: 0x00FCE39C
		public void InitAppropriatePos(DockyardItemBlockOriginalData itemData)
		{
			List<List<int>> list = DockyardPanelUtil.RotateOriginalPosData(itemData.PosDoublyList, itemData.Rotate);
			this.AppropriatePos.RowStartIndex = itemData.PosY;
			this.AppropriatePos.RowEndIndex = itemData.PosY + list.Count - 1;
			this.AppropriatePos.ColStartIndex = itemData.PosX;
			this.AppropriatePos.ColEndIndex = itemData.PosX + list[0].Count - 1;
		}

		// Token: 0x06041410 RID: 267280 RVA: 0x00FD0218 File Offset: 0x00FCE418
		public void RefreshAllBackpackGridState(bool checkRangeChange = true)
		{
			IPanelPosRange leftTopPosRangeByPanel = this.PanelModel.InSelectItemBlock.GetLeftTopPosRangeByPanel(this.AttachItem);
			if (!this.PanelModel.InSelectItemBlock.IsRangeChange(this.LastLeftTopPos, leftTopPosRangeByPanel) && checkRangeChange)
			{
				DockyardPanelUtil.DeepCopyItemRangePos(this.LastLeftTopPos, leftTopPosRangeByPanel);
				return;
			}
			bool flag = this.PanelModel.InSelectItemBlock.IsOutOfRange(leftTopPosRangeByPanel, 3, 6);
			if (this.PanelModel.IsOutOfRange && flag)
			{
				DockyardPanelUtil.DeepCopyItemRangePos(this.LastLeftTopPos, leftTopPosRangeByPanel);
				return;
			}
			this.PanelModel.IsOutOfRange = flag;
			this.ResetBackpackGridShowType(this.LastLeftTopPos);
			this.ChangeBackpackGridShowType(this.PanelModel.InSelectItemBlock, leftTopPosRangeByPanel);
			DockyardPanelUtil.DeepCopyItemRangePos(this.LastLeftTopPos, leftTopPosRangeByPanel);
		}

		// Token: 0x06041411 RID: 267281 RVA: 0x00FD02D0 File Offset: 0x00FCE4D0
		public void HandleDragSuccess()
		{
			DockyardPanelUtil.DeepCopyItemRangePos(this.AppropriatePos, this.LastLeftTopPos);
			this.PanelModel.InSelectItemBlock.AdsorbToAppropriatePosByAttachItem(this.AppropriatePos.RowStartIndex, this.AppropriatePos.ColStartIndex, this.AttachItem);
			this.PanelModel.BackpackPanelModel.Panel.SetButtonsState(true);
		}

		// Token: 0x06041412 RID: 267282 RVA: 0x00FD0330 File Offset: 0x00FCE530
		public void HandleDragFail()
		{
			this.PanelModel.InSelectItemBlock.AdsorbToAppropriatePosByAttachItem(this.AppropriatePos.RowStartIndex, this.AppropriatePos.ColStartIndex, this.AttachItem);
			this.RefreshAllBackpackGridState(false);
			this.PanelModel.BackpackPanelModel.Panel.SetButtonsState(true);
			DockyardInteractBackpackPanelModel backpackPanelModel = this.PanelModel.BackpackPanelModel;
			if (backpackPanelModel == null)
			{
				return;
			}
			backpackPanelModel.RefreshPanel(false);
		}

		// Token: 0x06041413 RID: 267283 RVA: 0x00FD039C File Offset: 0x00FCE59C
		public void RotateClick()
		{
			this.PanelModel.InSelectItemBlock.RotateBlock();
			this.RefreshAllBackpackGridState(false);
			this.TryHandleRotateFail();
			DockyardInteractBackpackPanelModel backpackPanelModel = this.PanelModel.BackpackPanelModel;
			if (backpackPanelModel == null)
			{
				return;
			}
			backpackPanelModel.RefreshPanel(false);
		}

		// Token: 0x06041414 RID: 267284 RVA: 0x00FD03D4 File Offset: 0x00FCE5D4
		public void DisableInteractItemBlock(DockyardItemBlockOriginalData itemData, IPanelPos startPos)
		{
			DockyardInteractItemBlock interactItemBlock = this.GetInteractItemBlock(itemData.ItemId, startPos.RowIndex, startPos.ColIndex);
			if (interactItemBlock != null)
			{
				interactItemBlock.SetItemData(null);
			}
		}

		// Token: 0x06041415 RID: 267285 RVA: 0x00FD0404 File Offset: 0x00FCE604
		public void EnableInteractItemBlock(DockyardItemBlockOriginalData itemData)
		{
			DockyardInteractItemBlock interactItemBlock = this.GetInteractItemBlock(itemData.ItemId, this.LastLeftTopPos.RowStartIndex, this.LastLeftTopPos.ColStartIndex);
			if (interactItemBlock != null)
			{
				interactItemBlock.SetItemData(itemData);
			}
		}

		// Token: 0x06041416 RID: 267286 RVA: 0x00FD043E File Offset: 0x00FCE63E
		public void HandleOverlapConfirm()
		{
			this.RefreshBackpackGridState(this.PanelModel.InSelectItemBlock);
			this.PanelModel.ChangeShowItemData();
		}

		// Token: 0x06041417 RID: 267287 RVA: 0x00FD045C File Offset: 0x00FCE65C
		public void HandleFinishConfirm()
		{
			this.RefreshBackpackGridState(this.PanelModel.InSelectItemBlock);
			this.PanelModel.ChangeShowItemData();
			DockyardInteractBackpackPanelModel backpackPanelModel = this.PanelModel.BackpackPanelModel;
			if (backpackPanelModel == null)
			{
				return;
			}
			backpackPanelModel.Panel.DestroySelectItemBlock();
		}

		// Token: 0x06041418 RID: 267288 RVA: 0x00FD0494 File Offset: 0x00FCE694
		public IPanelPos GetLeftTopPanelPos(int itemId)
		{
			if (this.GetInteractItemBlock(itemId, this.LastLeftTopPos.RowStartIndex, this.LastLeftTopPos.ColStartIndex) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Dockyard;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "查找不到对应的InteractItemBlock";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ItemId", itemId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new PanelPos
				{
					RowIndex = -1,
					ColIndex = -1
				};
			}
			return new PanelPos
			{
				RowIndex = this.LastLeftTopPos.RowStartIndex,
				ColIndex = this.LastLeftTopPos.ColStartIndex
			};
		}

		// Token: 0x06041419 RID: 267289 RVA: 0x00FD052A File Offset: 0x00FCE72A
		public void ResetLastBackpackGridShowType()
		{
			this.ResetBackpackGridShowType(this.LastLeftTopPos);
		}

		// Token: 0x04021F81 RID: 139137
		private readonly HashSet<DockyardInteractGrid> InteractGridSet = new HashSet<DockyardInteractGrid>();

		// Token: 0x04021F82 RID: 139138
		private readonly HashSet<DockyardInteractItemBlock> InteractItemBlockSet = new HashSet<DockyardInteractItemBlock>();

		// Token: 0x04021F83 RID: 139139
		protected GenericLayout<DockyardInteractGrid, IPanelPos> Layout;

		// Token: 0x04021F84 RID: 139140
		public UUIItem AttachItem;

		// Token: 0x04021F85 RID: 139141
		private readonly IPanelPosRange LastLeftTopPos = new PanelPosRange
		{
			RowStartIndex = -1,
			RowEndIndex = -1,
			ColStartIndex = -1,
			ColEndIndex = -1
		};

		// Token: 0x04021F86 RID: 139142
		private readonly IPanelPosRange AppropriatePos = new PanelPosRange
		{
			RowStartIndex = -1,
			RowEndIndex = -1,
			ColStartIndex = -1,
			ColEndIndex = -1
		};

		// Token: 0x04021F87 RID: 139143
		protected DockyardInteractPanelModel PanelModel;

		// Token: 0x0200C7A5 RID: 51109
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C4F6 RID: 247030
			public const int Layout = 0;

			// Token: 0x0403C4F7 RID: 247031
			public const int GridItem = 1;

			// Token: 0x0403C4F8 RID: 247032
			public const int AttachItem = 2;
		}
	}
}
