using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065AD RID: 26029
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardItemBlock : UiPanelBase
	{
		// Token: 0x06041459 RID: 267353 RVA: 0x00FD141C File Offset: 0x00FCF61C
		public DockyardItemBlock(DockyardItemBlockData data)
		{
			this.Data = data;
		}

		// Token: 0x0604145A RID: 267354 RVA: 0x00FD14E0 File Offset: 0x00FCF6E0
		protected unsafe override void OnRegisterComponent()
		{
			this.ParentModel = (this.OpenParam as IDockyardGridInterface);
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604145B RID: 267355 RVA: 0x00FD15C0 File Offset: 0x00FCF7C0
		private UniTask InitLayout()
		{
			DockyardItemBlock.<InitLayout>d__27 <InitLayout>d__;
			<InitLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLayout>d__.<>4__this = this;
			<InitLayout>d__.<>1__state = -1;
			<InitLayout>d__.<>t__builder.Start<DockyardItemBlock.<InitLayout>d__27>(ref <InitLayout>d__);
			return <InitLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0604145C RID: 267356 RVA: 0x00FD1604 File Offset: 0x00FCF804
		private void InitGridItem()
		{
			UUIItem item = base.GetItem(2);
			this.GridWidth = item.Width;
		}

		// Token: 0x0604145D RID: 267357 RVA: 0x00FD1628 File Offset: 0x00FCF828
		private void InitLayoutWidth()
		{
			TWeakObjectPtr<UUIItem> rootUIComp = base.GetLayoutBase(1).RootUIComp;
			List<List<int>> posDoublyList = this.Data.Data.PosDoublyList;
			int count = posDoublyList[0].Count;
			int count2 = posDoublyList.Count;
			rootUIComp.Get().SetWidth((float)count * this.GridWidth);
			this.BlockWidth = this.GridWidth * (float)count;
			this.BlockHeight = this.GridWidth * (float)count2;
		}

		// Token: 0x0604145E RID: 267358 RVA: 0x00FD1698 File Offset: 0x00FCF898
		private void InitSelectItemSize()
		{
			UUIItem item = base.GetItem(0);
			List<List<int>> validDoublyList = this.Data.Data.ValidDoublyList;
			int count = validDoublyList[0].Count;
			float count2 = (float)validDoublyList.Count;
			float num = (float)(count - 1) * this.GridWidth;
			float num2 = (count2 - (float)1) * this.GridWidth;
			item.SetWidth(item.Width + num);
			item.SetHeight(item.Height + num2);
			FVector2D anchorOffset = item.GetAnchorOffset();
			IPanelPos validStartPos = this.Data.Data.ValidStartPos;
			item.SetAnchorOffset(new FVector2D(anchorOffset.X + (float)validStartPos.ColIndex * this.GridWidth + num * 1f / 2f, anchorOffset.Y - (float)validStartPos.RowIndex * this.GridWidth - num2 * 1f / 2f));
		}

		// Token: 0x0604145F RID: 267359 RVA: 0x00FD176C File Offset: 0x00FCF96C
		private void InitRootItemPivot()
		{
			Vector2D originalPivot = this.Data.GetOriginalPivot();
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetPivot(originalPivot.ToUeVector2D(false));
		}

		// Token: 0x06041460 RID: 267360 RVA: 0x00FD179C File Offset: 0x00FCF99C
		private UniTask InitTexture(UUITexture texture)
		{
			DockyardItemBlock.<InitTexture>d__32 <InitTexture>d__;
			<InitTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTexture>d__.<>4__this = this;
			<InitTexture>d__.texture = texture;
			<InitTexture>d__.<>1__state = -1;
			<InitTexture>d__.<>t__builder.Start<DockyardItemBlock.<InitTexture>d__32>(ref <InitTexture>d__);
			return <InitTexture>d__.<>t__builder.Task;
		}

		// Token: 0x06041461 RID: 267361 RVA: 0x00FD17E8 File Offset: 0x00FCF9E8
		private void InitOther()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			Transform itemWorldTrans = this.ItemWorldTrans;
			FTransform ftransform = this.ParentUiItem.K2_GetComponentToWorld();
			itemWorldTrans.FromUeTransform(ftransform);
			base.GetItem(0).SetUIActive(false);
			this.SetTextureMaterialActive(false);
		}

		// Token: 0x06041462 RID: 267362 RVA: 0x00FD1834 File Offset: 0x00FCFA34
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardItemBlock.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardItemBlock.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041463 RID: 267363 RVA: 0x00FD1877 File Offset: 0x00FCFA77
		protected override void OnStart()
		{
			this.RefreshBlockRotate();
		}

		// Token: 0x06041464 RID: 267364 RVA: 0x00FD187F File Offset: 0x00FCFA7F
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x06041465 RID: 267365 RVA: 0x00FD188C File Offset: 0x00FCFA8C
		private DockyardItemBlockGrid InitItem()
		{
			return new DockyardItemBlockGrid
			{
				OpenParam = this
			};
		}

		// Token: 0x06041466 RID: 267366 RVA: 0x00FD189C File Offset: 0x00FCFA9C
		private void RecordLeftTopWorldPos()
		{
			this.Data.RefreshLeftTopPosInBackpack(this.TempAnchorOffset, this.BlockWidth, this.BlockHeight, this.GridWidth);
			Vector2D leftTopAnchorOffset = this.Data.LeftTopAnchorOffset;
			this.TempLeftTopWorldPos.Set(leftTopAnchorOffset.X, leftTopAnchorOffset.Y, 0.0);
			this.ItemWorldTrans.TransformPosition(this.TempLeftTopWorldPos, this.TempLeftTopWorldPos);
		}

		// Token: 0x06041467 RID: 267367 RVA: 0x00FD1910 File Offset: 0x00FCFB10
		private void RefreshTempPanelData(UUIItem panel)
		{
			if (this.TempPanel != panel)
			{
				Transform tempAttachItemWorldTrans = this.TempAttachItemWorldTrans;
				FTransform ftransform = panel.K2_GetComponentToWorld();
				tempAttachItemWorldTrans.FromUeTransform(ftransform);
				FVector2D pivot = panel.GetPivot();
				this.TempSize.Set((double)panel.Width, (double)panel.Height);
				this.TempOffset.Set((double)pivot.X * this.TempSize.X, (double)(1f - pivot.Y) * this.TempSize.Y);
				this.TempPanel = panel;
			}
		}

		// Token: 0x06041468 RID: 267368 RVA: 0x00FD1998 File Offset: 0x00FCFB98
		private Vector2D GetPivotToTopLeftOffset()
		{
			Vector2D topLeftOffsetByRotate = this.Data.GetTopLeftOffsetByRotate();
			if (this.Data.IsInUpOrDown())
			{
				topLeftOffsetByRotate.X *= (double)this.BlockWidth;
				topLeftOffsetByRotate.Y *= (double)this.BlockHeight;
			}
			else
			{
				topLeftOffsetByRotate.X *= (double)this.BlockHeight;
				topLeftOffsetByRotate.Y *= (double)this.BlockWidth;
			}
			return topLeftOffsetByRotate;
		}

		// Token: 0x06041469 RID: 267369 RVA: 0x00FD1A14 File Offset: 0x00FCFC14
		public void OnPointerDown(ULGUIPointerEventData eventData)
		{
			bool flag = this.ParentModel.DragBegin(this.Data.Data.IncId);
			this.RecordLeftTopWorldPos();
			if (this.ParentModel.CanDrag(this.Data.Data.IncId))
			{
				FVector pointerPosition = eventData.pointerPosition;
				LguiUtil.Instance.ConvertPointerPositionToLguiPosition(pointerPosition, this.LastDragPos);
				IDockyardGridInterface parentModel = this.ParentModel;
				if (parentModel != null)
				{
					parentModel.OnItemBlockClick(this.Data.Data.IncId);
				}
			}
			if (flag)
			{
				this.PlaySelectSequence("Grab");
			}
		}

		// Token: 0x0604146A RID: 267370 RVA: 0x00FD1AA5 File Offset: 0x00FCFCA5
		public void OnPointerUp(ULGUIPointerEventData eventData)
		{
			if (this.ParentModel.DragEnd(this.Data.Data.IncId))
			{
				this.PlaySelectSequence("Drop");
			}
		}

		// Token: 0x0604146B RID: 267371 RVA: 0x00FD1ACF File Offset: 0x00FCFCCF
		public void OnDragBegin(ULGUIPointerEventData eventData)
		{
			if (this.ParentModel.DragBegin(this.Data.Data.IncId))
			{
				this.PlaySelectSequence("Grab");
			}
			this.RecordLeftTopWorldPos();
		}

		// Token: 0x0604146C RID: 267372 RVA: 0x00FD1B00 File Offset: 0x00FCFD00
		public void OnDrag(ULGUIPointerEventData eventData)
		{
			if (this.ParentModel.CanDrag(this.Data.Data.IncId))
			{
				FVector pointerPosition = eventData.pointerPosition;
				Vector2D vector2D = Vector2D.Create();
				LguiUtil.Instance.ConvertPointerPositionToLguiPosition(pointerPosition, vector2D);
				double num = vector2D.X - this.LastDragPos.X;
				double num2 = vector2D.Y - this.LastDragPos.Y;
				Vector2D vector2D2 = Vector2D.Create(vector2D.X, vector2D.Y).SubtractionEqual(this.LastDragPos);
				if (vector2D2.X == 0.0 && vector2D2.Y == 0.0)
				{
					return;
				}
				this.TempAnchorOffset.FromUeVector2D(this.RootItem.GetAnchorOffset());
				this.TempAnchorOffset.X += num;
				this.TempAnchorOffset.Y += num2;
				UUIItem rootItem = this.RootItem;
				if (rootItem != null)
				{
					rootItem.SetAnchorOffset(this.TempAnchorOffset.ToUeVector2D(false));
				}
				this.LastDragPos.DeepCopy(vector2D);
				this.RecordLeftTopWorldPos();
			}
		}

		// Token: 0x0604146D RID: 267373 RVA: 0x00FD1C1F File Offset: 0x00FCFE1F
		public void OnDragEnd(ULGUIPointerEventData eventData)
		{
			if (this.ParentModel.DragEnd(this.Data.Data.IncId))
			{
				this.PlaySelectSequence("Drop");
			}
		}

		// Token: 0x0604146E RID: 267374 RVA: 0x00FD1C4C File Offset: 0x00FCFE4C
		public void SetAnchorOffset(double offsetX, double offsetY)
		{
			this.TempAnchorOffset.Set(offsetX, offsetY);
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAnchorOffset(this.TempAnchorOffset.ToUeVector2D(false));
			}
			this.ResetAnchorOffset.DeepCopy(this.TempAnchorOffset);
			this.RecordLeftTopWorldPos();
		}

		// Token: 0x0604146F RID: 267375 RVA: 0x00FD1C9C File Offset: 0x00FCFE9C
		public void SetAnchorOffsetByEventDataPointerPosition(FVector pointerPosition)
		{
			LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(pointerPosition, this.TempLguiCenterPos);
			this.TempPointerPosition.Set(this.TempLguiCenterPos.X, 0.0, this.TempLguiCenterPos.Y);
			UUIItem rootItem = this.RootItem;
			FVector fvector = this.TempPointerPosition.ToUeVectorOld();
			rootItem.SetUIWorldLocation(fvector);
			FVector2D anchorOffset = this.RootItem.GetAnchorOffset();
			this.TempAnchorOffset.Set((double)anchorOffset.X, (double)anchorOffset.Y);
			this.ResetAnchorOffset.DeepCopy(this.TempAnchorOffset);
			this.RecordLeftTopWorldPos();
		}

		// Token: 0x06041470 RID: 267376 RVA: 0x00FD1D3C File Offset: 0x00FCFF3C
		public void InitAnchorOffset(float gridWidth, float gridHeight, int startRowIndex, int startColIndex)
		{
			Vector2D centerPosInBackpack = this.Data.GetCenterPosInBackpack(startRowIndex, startColIndex);
			this.SetAnchorOffset((double)gridWidth * centerPosInBackpack.X, (double)gridHeight * centerPosInBackpack.Y * -1.0);
		}

		// Token: 0x06041471 RID: 267377 RVA: 0x00FD1D7A File Offset: 0x00FCFF7A
		public void RotateBlock()
		{
			this.Data.RotateData();
			this.RefreshBlockRotate();
		}

		// Token: 0x06041472 RID: 267378 RVA: 0x00FD1D90 File Offset: 0x00FCFF90
		private void RefreshBlockRotate()
		{
			float rotateValue = this.Data.GetRotateValue();
			this.TempRotator.Yaw = rotateValue;
			UUIItem rootItem = this.RootItem;
			FRotator frotator = this.TempRotator.ToUeRotator();
			rootItem.SetUIRelativeRotation(frotator);
		}

		// Token: 0x06041473 RID: 267379 RVA: 0x00FD1DD0 File Offset: 0x00FCFFD0
		private void RefreshGridDragActive(bool value)
		{
			foreach (DockyardItemBlockGrid dockyardItemBlockGrid in this.Layout.GetLayoutItemList())
			{
				dockyardItemBlockGrid.RefreshDragItemActive(value);
			}
		}

		// Token: 0x06041474 RID: 267380 RVA: 0x00FD1E28 File Offset: 0x00FD0028
		private void SetTextureMaterialActive(bool value)
		{
			if (value)
			{
				base.GetTexture(3).SetCustomMaterialScalarParameter(this.MaterialOffsetName, 0.012f);
				return;
			}
			base.GetTexture(3).SetCustomMaterialScalarParameter(this.MaterialOffsetName, -1f);
		}

		// Token: 0x06041475 RID: 267381 RVA: 0x00FD1E5C File Offset: 0x00FD005C
		public void PlaySelectSequence(string sequenceName)
		{
			this.SequencePlayer.StopPrevSequence(false, true);
			this.SequencePlayer.PlaySequencePurely(sequenceName, false, false);
		}

		// Token: 0x06041476 RID: 267382 RVA: 0x00FD1E79 File Offset: 0x00FD0079
		public void SetItemBlockSelectState(bool value)
		{
			base.GetItem(0).SetUIActive(value);
			this.RefreshGridDragActive(value);
			this.SetTextureMaterialActive(value);
		}

		// Token: 0x06041477 RID: 267383 RVA: 0x00FD1E98 File Offset: 0x00FD0098
		public void SetUiParent(UUIItem parentItem)
		{
			if (this.ParentUiItem == parentItem)
			{
				return;
			}
			this.ParentUiItem = parentItem;
			this.GetOriginalItem().SetUIParent(parentItem, true);
			Transform itemWorldTrans = this.ItemWorldTrans;
			FTransform ftransform = parentItem.K2_GetComponentToWorld();
			itemWorldTrans.FromUeTransform(ftransform);
		}

		// Token: 0x06041478 RID: 267384 RVA: 0x00FD1ED7 File Offset: 0x00FD00D7
		public IPanelPosRange GetLeftTopPosRangeByOffset(Vector2D leftTopOffset)
		{
			return this.Data.GetLeftTopPosRangeByLeftTopPos(leftTopOffset, this.GridWidth);
		}

		// Token: 0x06041479 RID: 267385 RVA: 0x00FD1EEB File Offset: 0x00FD00EB
		public bool IsValidGridPos(int rowIndex, int colIndex)
		{
			return this.Data.IsValidGridPos(rowIndex, colIndex);
		}

		// Token: 0x0604147A RID: 267386 RVA: 0x00FD1EFC File Offset: 0x00FD00FC
		public void ResetToAppropriatePos(int panelRowCount, int panelColCount, UUIItem attachItem)
		{
			IPanelPosRange leftTopPosRangeByPanel = this.GetLeftTopPosRangeByPanel(attachItem);
			int targetRowIndex;
			if (leftTopPosRangeByPanel.RowEndIndex >= panelRowCount)
			{
				targetRowIndex = leftTopPosRangeByPanel.RowStartIndex - (leftTopPosRangeByPanel.RowEndIndex - panelRowCount);
			}
			else
			{
				targetRowIndex = ((leftTopPosRangeByPanel.RowStartIndex >= 0) ? leftTopPosRangeByPanel.RowStartIndex : 0);
			}
			int targetColIndex;
			if (leftTopPosRangeByPanel.ColEndIndex >= panelColCount)
			{
				targetColIndex = leftTopPosRangeByPanel.ColStartIndex - (leftTopPosRangeByPanel.ColEndIndex - panelColCount);
			}
			else
			{
				targetColIndex = ((leftTopPosRangeByPanel.ColStartIndex >= 0) ? leftTopPosRangeByPanel.ColStartIndex : 0);
			}
			this.AdsorbToAppropriatePosByAttachItem(targetRowIndex, targetColIndex, attachItem);
		}

		// Token: 0x0604147B RID: 267387 RVA: 0x00FD1F7C File Offset: 0x00FD017C
		public void AdsorbToAppropriatePosByAttachItem(int targetRowIndex, int targetColIndex, UUIItem attachItem)
		{
			float num = this.GridWidth * (float)targetColIndex;
			float num2 = this.GridWidth * (float)targetRowIndex;
			Vector2D pivotToTopLeftOffset = this.GetPivotToTopLeftOffset();
			FVector2D pivot = attachItem.GetPivot();
			this.TempPivotWorldPos.Set((double)(num - pivot.X * attachItem.Width) - pivotToTopLeftOffset.X, (double)(-(double)num2 - (1f - pivot.Y) * attachItem.Height) - pivotToTopLeftOffset.Y, 0.0);
			Transform tempAttachItemWorldTrans = this.TempAttachItemWorldTrans;
			FTransform ftransform = attachItem.K2_GetComponentToWorld();
			tempAttachItemWorldTrans.FromUeTransform(ftransform);
			this.TempAttachItemWorldTrans.TransformPosition(this.TempPivotWorldPos, this.TempPivotWorldPos);
			UUIItem rootItem = this.RootItem;
			FVector fvector = this.TempPivotWorldPos.ToUeVectorOld();
			rootItem.SetUIWorldLocation(fvector);
			FVector2D anchorOffset = this.RootItem.GetAnchorOffset();
			this.TempAnchorOffset.Set((double)anchorOffset.X, (double)anchorOffset.Y);
			this.ResetAnchorOffset.DeepCopy(this.TempAnchorOffset);
		}

		// Token: 0x0604147C RID: 267388 RVA: 0x00FD2073 File Offset: 0x00FD0273
		public int GetUniqueId()
		{
			return this.Data.Data.IncId;
		}

		// Token: 0x0604147D RID: 267389 RVA: 0x00FD2085 File Offset: 0x00FD0285
		public int GetItemId()
		{
			return this.Data.Data.ItemId;
		}

		// Token: 0x0604147E RID: 267390 RVA: 0x00FD2097 File Offset: 0x00FD0297
		public DockyardItemBlockData GetData()
		{
			return this.Data;
		}

		// Token: 0x0604147F RID: 267391 RVA: 0x00FD209F File Offset: 0x00FD029F
		public void SetHierarchyIndex(int hierarchyIndex)
		{
			this.RootItem.SetHierarchyIndex(hierarchyIndex);
		}

		// Token: 0x06041480 RID: 267392 RVA: 0x00FD20B0 File Offset: 0x00FD02B0
		public bool IsRangeChange(IPanelPosRange lastLeftTopPos, IPanelPosRange leftTopPos)
		{
			return lastLeftTopPos.RowStartIndex != leftTopPos.RowStartIndex || lastLeftTopPos.RowEndIndex != leftTopPos.RowEndIndex || lastLeftTopPos.ColStartIndex != leftTopPos.ColStartIndex || lastLeftTopPos.ColEndIndex != leftTopPos.ColEndIndex;
		}

		// Token: 0x06041481 RID: 267393 RVA: 0x00FD2100 File Offset: 0x00FD0300
		public bool IsPartOutOfRange(IPanelPosRange pos, int panelRowCount, int panelColCount)
		{
			if (pos.RowStartIndex >= 0 && pos.RowEndIndex < panelRowCount && pos.ColStartIndex >= 0 && pos.ColEndIndex < panelColCount)
			{
				return false;
			}
			for (int i = pos.RowStartIndex; i <= pos.RowEndIndex; i++)
			{
				for (int j = pos.ColStartIndex; j <= pos.ColEndIndex; j++)
				{
					if ((i < 0 || i >= panelRowCount || j < 0 || j >= panelColCount) && this.IsValidGridPos(i, j))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06041482 RID: 267394 RVA: 0x00FD217C File Offset: 0x00FD037C
		public bool IsOutOfRange(IPanelPosRange pos, int panelRowCount, int panelColCount)
		{
			if (pos.RowEndIndex < 0 || pos.RowStartIndex >= panelRowCount || pos.ColEndIndex < 0 || pos.ColStartIndex >= panelColCount)
			{
				return true;
			}
			for (int i = pos.RowStartIndex; i <= pos.RowEndIndex; i++)
			{
				for (int j = pos.ColStartIndex; j <= pos.ColEndIndex; j++)
				{
					if (i >= 0 && i < panelRowCount && j >= 0 && j < panelColCount && this.IsValidGridPos(i, j))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06041483 RID: 267395 RVA: 0x00FD21F8 File Offset: 0x00FD03F8
		public bool IsItemBlockInPanel(UUIItem panel)
		{
			this.RefreshTempPanelData(panel);
			this.TempAttachItemWorldTrans.InverseTransformPosition(this.TempLeftTopWorldPos, this.TempAttachItemPos);
			this.TempAttachItemPos.X += this.TempOffset.X;
			this.TempAttachItemPos.Y -= this.TempOffset.Y;
			return this.TempAttachItemPos.X >= (double)(-(double)this.BlockWidth) && this.TempAttachItemPos.X <= this.TempSize.X && this.TempAttachItemPos.Y >= (double)(-(double)this.BlockHeight) && this.TempAttachItemPos.Y <= this.TempSize.Y;
		}

		// Token: 0x06041484 RID: 267396 RVA: 0x00FD22BC File Offset: 0x00FD04BC
		public IPanelPosRange GetLeftTopPosRangeByPanel(UUIItem panel)
		{
			this.RecordLeftTopWorldPos();
			this.RefreshTempPanelData(panel);
			this.TempAttachItemWorldTrans.InverseTransformPosition(this.TempLeftTopWorldPos, this.TempAttachItemPos);
			this.TempLeftTopLocalPos.Set(this.TempAttachItemPos.X + this.TempOffset.X, this.TempAttachItemPos.Y - this.TempOffset.Y);
			return DockyardPanelUtil.CreateAndDeepCopyItemRangePos(this.GetLeftTopPosRangeByOffset(this.TempLeftTopLocalPos));
		}

		// Token: 0x06041485 RID: 267397 RVA: 0x00FD2338 File Offset: 0x00FD0538
		public int GetValueByPanelPos(IPanelPos panelPos)
		{
			int rowIndex = panelPos.RowIndex;
			int colIndex = panelPos.ColIndex;
			return this.Data.Data.PosDoublyList[rowIndex][colIndex];
		}

		// Token: 0x06041486 RID: 267398 RVA: 0x00FD236F File Offset: 0x00FD056F
		public void SetTextureMaskActive(bool value)
		{
			base.GetTexture(4).SetUIActive(value);
		}

		// Token: 0x06041487 RID: 267399 RVA: 0x00FD237E File Offset: 0x00FD057E
		public void RefreshItemBlockData(DockyardItemBlockData itemData)
		{
			this.Data = itemData;
		}

		// Token: 0x04021FA1 RID: 139169
		private const float MATERIAL_OFFSET_VALUE = 0.012f;

		// Token: 0x04021FA2 RID: 139170
		protected GenericLayout<DockyardItemBlockGrid, IPanelPos> Layout;

		// Token: 0x04021FA3 RID: 139171
		protected IDockyardGridInterface ParentModel;

		// Token: 0x04021FA4 RID: 139172
		private Vector2D TempLguiCenterPos = Vector2D.Create();

		// Token: 0x04021FA5 RID: 139173
		private Rotator TempRotator = Rotator.Create();

		// Token: 0x04021FA6 RID: 139174
		private Vector2D LastDragPos = Vector2D.Create();

		// Token: 0x04021FA7 RID: 139175
		private Vector2D TempAnchorOffset = Vector2D.Create();

		// Token: 0x04021FA8 RID: 139176
		private Vector TempPointerPosition = Vector.Create();

		// Token: 0x04021FA9 RID: 139177
		private Vector2D ResetAnchorOffset = Vector2D.Create();

		// Token: 0x04021FAA RID: 139178
		private Vector TempLeftTopWorldPos = Vector.Create();

		// Token: 0x04021FAB RID: 139179
		private Vector TempPivotWorldPos = Vector.Create();

		// Token: 0x04021FAC RID: 139180
		private Transform ItemWorldTrans = Transform.Create();

		// Token: 0x04021FAD RID: 139181
		private Transform TempAttachItemWorldTrans = Transform.Create();

		// Token: 0x04021FAE RID: 139182
		private Vector TempAttachItemPos = Vector.Create();

		// Token: 0x04021FAF RID: 139183
		private Vector2D TempOffset = Vector2D.Create();

		// Token: 0x04021FB0 RID: 139184
		private Vector2D TempSize = Vector2D.Create();

		// Token: 0x04021FB1 RID: 139185
		private Vector2D TempLeftTopLocalPos = Vector2D.Create();

		// Token: 0x04021FB2 RID: 139186
		private UUIItem TempPanel;

		// Token: 0x04021FB3 RID: 139187
		private FName MaterialOffsetName = new FName("Offset");

		// Token: 0x04021FB4 RID: 139188
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04021FB5 RID: 139189
		private float GridWidth;

		// Token: 0x04021FB6 RID: 139190
		public float BlockWidth;

		// Token: 0x04021FB7 RID: 139191
		public float BlockHeight;

		// Token: 0x04021FB8 RID: 139192
		protected DockyardItemBlockData Data;

		// Token: 0x0200C7B2 RID: 51122
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C52A RID: 247082
			public const int SelectItem = 0;

			// Token: 0x0403C52B RID: 247083
			public const int Layout = 1;

			// Token: 0x0403C52C RID: 247084
			public const int GridItem = 2;

			// Token: 0x0403C52D RID: 247085
			public const int Texture = 3;

			// Token: 0x0403C52E RID: 247086
			public const int TextureMask = 4;
		}
	}
}
