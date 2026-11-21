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
	// Token: 0x0200552B RID: 21803
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardItemBlock : UiPanelBase
	{
		// Token: 0x0603611E RID: 221470 RVA: 0x00F18420 File Offset: 0x00F16620
		public DockyardItemBlock(DockyardItemBlockData data)
		{
			this.Data = data;
		}

		// Token: 0x0603611F RID: 221471 RVA: 0x00F184E4 File Offset: 0x00F166E4
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

		// Token: 0x06036120 RID: 221472 RVA: 0x00F185C4 File Offset: 0x00F167C4
		private UniTask InitLayout()
		{
			DockyardItemBlock.<InitLayout>d__27 <InitLayout>d__;
			<InitLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLayout>d__.<>4__this = this;
			<InitLayout>d__.<>1__state = -1;
			<InitLayout>d__.<>t__builder.Start<DockyardItemBlock.<InitLayout>d__27>(ref <InitLayout>d__);
			return <InitLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06036121 RID: 221473 RVA: 0x00F18608 File Offset: 0x00F16808
		private void InitGridItem()
		{
			UUIItem item = base.GetItem(2);
			this.GridWidth = item.Width;
		}

		// Token: 0x06036122 RID: 221474 RVA: 0x00F1862C File Offset: 0x00F1682C
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

		// Token: 0x06036123 RID: 221475 RVA: 0x00F1869C File Offset: 0x00F1689C
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

		// Token: 0x06036124 RID: 221476 RVA: 0x00F18770 File Offset: 0x00F16970
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

		// Token: 0x06036125 RID: 221477 RVA: 0x00F187A0 File Offset: 0x00F169A0
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

		// Token: 0x06036126 RID: 221478 RVA: 0x00F187EC File Offset: 0x00F169EC
		private void InitOther()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			Transform itemWorldTrans = this.ItemWorldTrans;
			FTransform ftransform = this.ParentUiItem.K2_GetComponentToWorld();
			itemWorldTrans.FromUeTransform(ftransform);
			base.GetItem(0).SetUIActive(false);
			this.SetTextureMaterialActive(false);
		}

		// Token: 0x06036127 RID: 221479 RVA: 0x00F18838 File Offset: 0x00F16A38
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardItemBlock.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardItemBlock.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036128 RID: 221480 RVA: 0x00F1887B File Offset: 0x00F16A7B
		protected override void OnStart()
		{
			this.RefreshBlockRotate();
		}

		// Token: 0x06036129 RID: 221481 RVA: 0x00F18883 File Offset: 0x00F16A83
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x0603612A RID: 221482 RVA: 0x00F18890 File Offset: 0x00F16A90
		private DockyardItemBlockGrid InitItem()
		{
			return new DockyardItemBlockGrid
			{
				OpenParam = this
			};
		}

		// Token: 0x0603612B RID: 221483 RVA: 0x00F188A0 File Offset: 0x00F16AA0
		private void RecordLeftTopWorldPos()
		{
			this.Data.RefreshLeftTopPosInBackpack(this.TempAnchorOffset, this.BlockWidth, this.BlockHeight, this.GridWidth);
			Vector2D leftTopAnchorOffset = this.Data.LeftTopAnchorOffset;
			this.TempLeftTopWorldPos.Set(leftTopAnchorOffset.X, leftTopAnchorOffset.Y, 0.0);
			this.ItemWorldTrans.TransformPosition(this.TempLeftTopWorldPos, this.TempLeftTopWorldPos);
		}

		// Token: 0x0603612C RID: 221484 RVA: 0x00F18914 File Offset: 0x00F16B14
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

		// Token: 0x0603612D RID: 221485 RVA: 0x00F1899C File Offset: 0x00F16B9C
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

		// Token: 0x0603612E RID: 221486 RVA: 0x00F18A18 File Offset: 0x00F16C18
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

		// Token: 0x0603612F RID: 221487 RVA: 0x00F18AA9 File Offset: 0x00F16CA9
		public void OnPointerUp(ULGUIPointerEventData eventData)
		{
			if (this.ParentModel.DragEnd(this.Data.Data.IncId))
			{
				this.PlaySelectSequence("Drop");
			}
		}

		// Token: 0x06036130 RID: 221488 RVA: 0x00F18AD3 File Offset: 0x00F16CD3
		public void OnDragBegin(ULGUIPointerEventData eventData)
		{
			if (this.ParentModel.DragBegin(this.Data.Data.IncId))
			{
				this.PlaySelectSequence("Grab");
			}
			this.RecordLeftTopWorldPos();
		}

		// Token: 0x06036131 RID: 221489 RVA: 0x00F18B04 File Offset: 0x00F16D04
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

		// Token: 0x06036132 RID: 221490 RVA: 0x00F18C23 File Offset: 0x00F16E23
		public void OnDragEnd(ULGUIPointerEventData eventData)
		{
			if (this.ParentModel.DragEnd(this.Data.Data.IncId))
			{
				this.PlaySelectSequence("Drop");
			}
		}

		// Token: 0x06036133 RID: 221491 RVA: 0x00F18C50 File Offset: 0x00F16E50
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

		// Token: 0x06036134 RID: 221492 RVA: 0x00F18CA0 File Offset: 0x00F16EA0
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

		// Token: 0x06036135 RID: 221493 RVA: 0x00F18D40 File Offset: 0x00F16F40
		public void InitAnchorOffset(float gridWidth, float gridHeight, int startRowIndex, int startColIndex)
		{
			Vector2D centerPosInBackpack = this.Data.GetCenterPosInBackpack(startRowIndex, startColIndex);
			this.SetAnchorOffset((double)gridWidth * centerPosInBackpack.X, (double)gridHeight * centerPosInBackpack.Y * -1.0);
		}

		// Token: 0x06036136 RID: 221494 RVA: 0x00F18D7E File Offset: 0x00F16F7E
		public void RotateBlock()
		{
			this.Data.RotateData();
			this.RefreshBlockRotate();
		}

		// Token: 0x06036137 RID: 221495 RVA: 0x00F18D94 File Offset: 0x00F16F94
		private void RefreshBlockRotate()
		{
			float rotateValue = this.Data.GetRotateValue();
			this.TempRotator.Yaw = rotateValue;
			UUIItem rootItem = this.RootItem;
			FRotator frotator = this.TempRotator.ToUeRotator();
			rootItem.SetUIRelativeRotation(frotator);
		}

		// Token: 0x06036138 RID: 221496 RVA: 0x00F18DD4 File Offset: 0x00F16FD4
		private void RefreshGridDragActive(bool value)
		{
			foreach (DockyardItemBlockGrid dockyardItemBlockGrid in this.Layout.GetLayoutItemList())
			{
				dockyardItemBlockGrid.RefreshDragItemActive(value);
			}
		}

		// Token: 0x06036139 RID: 221497 RVA: 0x00F18E2C File Offset: 0x00F1702C
		private void SetTextureMaterialActive(bool value)
		{
			if (value)
			{
				base.GetTexture(3).SetCustomMaterialScalarParameter(this.MaterialOffsetName, 0.012f);
				return;
			}
			base.GetTexture(3).SetCustomMaterialScalarParameter(this.MaterialOffsetName, -1f);
		}

		// Token: 0x0603613A RID: 221498 RVA: 0x00F18E60 File Offset: 0x00F17060
		public void PlaySelectSequence(string sequenceName)
		{
			this.SequencePlayer.StopPrevSequence(false, true);
			this.SequencePlayer.PlaySequencePurely(sequenceName, false, false);
		}

		// Token: 0x0603613B RID: 221499 RVA: 0x00F18E7D File Offset: 0x00F1707D
		public void SetItemBlockSelectState(bool value)
		{
			base.GetItem(0).SetUIActive(value);
			this.RefreshGridDragActive(value);
			this.SetTextureMaterialActive(value);
		}

		// Token: 0x0603613C RID: 221500 RVA: 0x00F18E9C File Offset: 0x00F1709C
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

		// Token: 0x0603613D RID: 221501 RVA: 0x00F18EDB File Offset: 0x00F170DB
		public IPanelPosRange GetLeftTopPosRangeByOffset(Vector2D leftTopOffset)
		{
			return this.Data.GetLeftTopPosRangeByLeftTopPos(leftTopOffset, this.GridWidth);
		}

		// Token: 0x0603613E RID: 221502 RVA: 0x00F18EEF File Offset: 0x00F170EF
		public bool IsValidGridPos(int rowIndex, int colIndex)
		{
			return this.Data.IsValidGridPos(rowIndex, colIndex);
		}

		// Token: 0x0603613F RID: 221503 RVA: 0x00F18F00 File Offset: 0x00F17100
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

		// Token: 0x06036140 RID: 221504 RVA: 0x00F18F80 File Offset: 0x00F17180
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

		// Token: 0x06036141 RID: 221505 RVA: 0x00F19077 File Offset: 0x00F17277
		public int GetUniqueId()
		{
			return this.Data.Data.IncId;
		}

		// Token: 0x06036142 RID: 221506 RVA: 0x00F19089 File Offset: 0x00F17289
		public int GetItemId()
		{
			return this.Data.Data.ItemId;
		}

		// Token: 0x06036143 RID: 221507 RVA: 0x00F1909B File Offset: 0x00F1729B
		public DockyardItemBlockData GetData()
		{
			return this.Data;
		}

		// Token: 0x06036144 RID: 221508 RVA: 0x00F190A3 File Offset: 0x00F172A3
		public void SetHierarchyIndex(int hierarchyIndex)
		{
			this.RootItem.SetHierarchyIndex(hierarchyIndex);
		}

		// Token: 0x06036145 RID: 221509 RVA: 0x00F190B4 File Offset: 0x00F172B4
		public bool IsRangeChange(IPanelPosRange lastLeftTopPos, IPanelPosRange leftTopPos)
		{
			return lastLeftTopPos.RowStartIndex != leftTopPos.RowStartIndex || lastLeftTopPos.RowEndIndex != leftTopPos.RowEndIndex || lastLeftTopPos.ColStartIndex != leftTopPos.ColStartIndex || lastLeftTopPos.ColEndIndex != leftTopPos.ColEndIndex;
		}

		// Token: 0x06036146 RID: 221510 RVA: 0x00F19104 File Offset: 0x00F17304
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

		// Token: 0x06036147 RID: 221511 RVA: 0x00F19180 File Offset: 0x00F17380
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

		// Token: 0x06036148 RID: 221512 RVA: 0x00F191FC File Offset: 0x00F173FC
		public bool IsItemBlockInPanel(UUIItem panel)
		{
			this.RefreshTempPanelData(panel);
			this.TempAttachItemWorldTrans.InverseTransformPosition(this.TempLeftTopWorldPos, this.TempAttachItemPos);
			this.TempAttachItemPos.X += this.TempOffset.X;
			this.TempAttachItemPos.Y -= this.TempOffset.Y;
			return this.TempAttachItemPos.X >= (double)(-(double)this.BlockWidth) && this.TempAttachItemPos.X <= this.TempSize.X && this.TempAttachItemPos.Y >= (double)(-(double)this.BlockHeight) && this.TempAttachItemPos.Y <= this.TempSize.Y;
		}

		// Token: 0x06036149 RID: 221513 RVA: 0x00F192C0 File Offset: 0x00F174C0
		public IPanelPosRange GetLeftTopPosRangeByPanel(UUIItem panel)
		{
			this.RecordLeftTopWorldPos();
			this.RefreshTempPanelData(panel);
			this.TempAttachItemWorldTrans.InverseTransformPosition(this.TempLeftTopWorldPos, this.TempAttachItemPos);
			this.TempLeftTopLocalPos.Set(this.TempAttachItemPos.X + this.TempOffset.X, this.TempAttachItemPos.Y - this.TempOffset.Y);
			return DockyardPanelUtil.CreateAndDeepCopyItemRangePos(this.GetLeftTopPosRangeByOffset(this.TempLeftTopLocalPos));
		}

		// Token: 0x0603614A RID: 221514 RVA: 0x00F1933C File Offset: 0x00F1753C
		public int GetValueByPanelPos(IPanelPos panelPos)
		{
			int rowIndex = panelPos.RowIndex;
			int colIndex = panelPos.ColIndex;
			return this.Data.Data.PosDoublyList[rowIndex][colIndex];
		}

		// Token: 0x0603614B RID: 221515 RVA: 0x00F19373 File Offset: 0x00F17573
		public void SetTextureMaskActive(bool value)
		{
			base.GetTexture(4).SetUIActive(value);
		}

		// Token: 0x0603614C RID: 221516 RVA: 0x00F19382 File Offset: 0x00F17582
		public void RefreshItemBlockData(DockyardItemBlockData itemData)
		{
			this.Data = itemData;
		}

		// Token: 0x0401C8D2 RID: 116946
		private const float MATERIAL_OFFSET_VALUE = 0.012f;

		// Token: 0x0401C8D3 RID: 116947
		protected GenericLayout<DockyardItemBlockGrid, IPanelPos> Layout;

		// Token: 0x0401C8D4 RID: 116948
		protected IDockyardGridInterface ParentModel;

		// Token: 0x0401C8D5 RID: 116949
		private Vector2D TempLguiCenterPos = Vector2D.Create();

		// Token: 0x0401C8D6 RID: 116950
		private Rotator TempRotator = Rotator.Create();

		// Token: 0x0401C8D7 RID: 116951
		private Vector2D LastDragPos = Vector2D.Create();

		// Token: 0x0401C8D8 RID: 116952
		private Vector2D TempAnchorOffset = Vector2D.Create();

		// Token: 0x0401C8D9 RID: 116953
		private Vector TempPointerPosition = Vector.Create();

		// Token: 0x0401C8DA RID: 116954
		private Vector2D ResetAnchorOffset = Vector2D.Create();

		// Token: 0x0401C8DB RID: 116955
		private Vector TempLeftTopWorldPos = Vector.Create();

		// Token: 0x0401C8DC RID: 116956
		private Vector TempPivotWorldPos = Vector.Create();

		// Token: 0x0401C8DD RID: 116957
		private Transform ItemWorldTrans = Transform.Create();

		// Token: 0x0401C8DE RID: 116958
		private Transform TempAttachItemWorldTrans = Transform.Create();

		// Token: 0x0401C8DF RID: 116959
		private Vector TempAttachItemPos = Vector.Create();

		// Token: 0x0401C8E0 RID: 116960
		private Vector2D TempOffset = Vector2D.Create();

		// Token: 0x0401C8E1 RID: 116961
		private Vector2D TempSize = Vector2D.Create();

		// Token: 0x0401C8E2 RID: 116962
		private Vector2D TempLeftTopLocalPos = Vector2D.Create();

		// Token: 0x0401C8E3 RID: 116963
		private UUIItem TempPanel;

		// Token: 0x0401C8E4 RID: 116964
		private FName MaterialOffsetName = new FName("Offset");

		// Token: 0x0401C8E5 RID: 116965
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401C8E6 RID: 116966
		private float GridWidth;

		// Token: 0x0401C8E7 RID: 116967
		public float BlockWidth;

		// Token: 0x0401C8E8 RID: 116968
		public float BlockHeight;

		// Token: 0x0401C8E9 RID: 116969
		protected DockyardItemBlockData Data;

		// Token: 0x0200B197 RID: 45463
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036E7B RID: 224891
			public const int SelectItem = 0;

			// Token: 0x04036E7C RID: 224892
			public const int Layout = 1;

			// Token: 0x04036E7D RID: 224893
			public const int GridItem = 2;

			// Token: 0x04036E7E RID: 224894
			public const int Texture = 3;

			// Token: 0x04036E7F RID: 224895
			public const int TextureMask = 4;
		}
	}
}
