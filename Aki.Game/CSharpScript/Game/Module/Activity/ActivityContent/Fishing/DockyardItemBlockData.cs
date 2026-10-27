using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065AE RID: 26030
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardItemBlockData
	{
		// Token: 0x1700957D RID: 38269
		// (get) Token: 0x06041488 RID: 267400 RVA: 0x00FD2387 File Offset: 0x00FD0587
		private List<List<int>> OriginalPosData
		{
			get
			{
				return this.Data.PosDoublyList;
			}
		}

		// Token: 0x06041489 RID: 267401 RVA: 0x00FD2394 File Offset: 0x00FD0594
		public DockyardItemBlockData(DockyardItemBlockOriginalData data)
		{
			this.Data = data;
			this.OriginalPivot = Vector2D.Create();
			this.TempPivot = Vector2D.Create();
			this.TempOffset = Vector2D.Create();
			this.LeftTopAnchorOffset = Vector2D.Create();
			this.TempPosData = DockyardPanelUtil.RotateOriginalPosData(this.OriginalPosData, data.Rotate).ToList<List<int>>();
			this.LeftTopPosInPanel.ColIndex = data.PosX;
			this.LeftTopPosInPanel.RowIndex = data.PosY;
			this.Rotate = data.Rotate;
			this.CalculatePanelRange(this.PanelRange, this.LeftTopPosInPanel);
			this.RecordLastPanelRange();
			this.CalculateOriginalPivot();
		}

		// Token: 0x0604148A RID: 267402 RVA: 0x00FD24B4 File Offset: 0x00FD06B4
		public void RefreshData(DockyardItemBlockOriginalData data)
		{
			this.Data = data;
		}

		// Token: 0x0604148B RID: 267403 RVA: 0x00FD24BD File Offset: 0x00FD06BD
		public bool IsInUpOrDown()
		{
			return this.Rotate == FishingItemRotate.No || this.Rotate == FishingItemRotate.DirectionLeft;
		}

		// Token: 0x0604148C RID: 267404 RVA: 0x00FD24D2 File Offset: 0x00FD06D2
		private void CalculateOriginalPivot()
		{
			this.OriginalPivot.DeepCopy(DockyardPanelUtil.CalculateOriginalPivot(this.OriginalPosData.Count<List<int>>(), this.OriginalPosData.First<List<int>>().Count<int>()));
		}

		// Token: 0x0604148D RID: 267405 RVA: 0x00FD2500 File Offset: 0x00FD0700
		private void CalculatePanelRange(IPanelPosRange panelRange, IPanelPos panelPos)
		{
			int num;
			int num2;
			if (this.IsInUpOrDown())
			{
				num = this.OriginalPosData.Count<List<int>>();
				num2 = this.OriginalPosData.First<List<int>>().Count<int>();
			}
			else
			{
				num = this.OriginalPosData.First<List<int>>().Count<int>();
				num2 = this.OriginalPosData.Count<List<int>>();
			}
			panelRange.RowStartIndex = panelPos.RowIndex;
			panelRange.RowEndIndex = panelPos.RowIndex + num - 1;
			panelRange.ColStartIndex = panelPos.ColIndex;
			panelRange.ColEndIndex = panelPos.ColIndex + num2 - 1;
		}

		// Token: 0x0604148E RID: 267406 RVA: 0x00FD2590 File Offset: 0x00FD0790
		private int GetLeftTopColIndexInPanel(double positionX, float gridWidth)
		{
			int result;
			if (positionX < 0.0)
			{
				result = ((Math.Abs(positionX % (double)gridWidth) > (double)(gridWidth * 1f / 2f)) ? ((int)Math.Floor(positionX / (double)gridWidth)) : ((int)Math.Ceiling(positionX / (double)gridWidth)));
			}
			else
			{
				result = ((positionX % (double)gridWidth > (double)(gridWidth * 1f / 2f)) ? ((int)Math.Ceiling(positionX / (double)gridWidth)) : ((int)Math.Floor(positionX / (double)gridWidth)));
			}
			return result;
		}

		// Token: 0x0604148F RID: 267407 RVA: 0x00FD260C File Offset: 0x00FD080C
		private int GetLeftTopRowIndexInPanel(double positionY, float gridWidth)
		{
			int result;
			if (positionY > 0.0)
			{
				result = ((Math.Abs(-positionY % (double)gridWidth) > (double)(gridWidth * 1f / 2f)) ? ((int)Math.Floor(-positionY / (double)gridWidth)) : ((int)Math.Ceiling(-positionY / (double)gridWidth)));
			}
			else
			{
				result = ((-positionY % (double)gridWidth > (double)(gridWidth * 1f / 2f)) ? ((int)Math.Ceiling(-positionY / (double)gridWidth)) : ((int)Math.Floor(-positionY / (double)gridWidth)));
			}
			return result;
		}

		// Token: 0x06041490 RID: 267408 RVA: 0x00FD268C File Offset: 0x00FD088C
		private void CalculateLeftTopPosInPanel(Vector2D position, float gridWidth)
		{
			int leftTopColIndexInPanel = this.GetLeftTopColIndexInPanel(position.X, gridWidth);
			int leftTopRowIndexInPanel = this.GetLeftTopRowIndexInPanel(position.Y, gridWidth);
			this.LeftTopPosInPanel.ColIndex = leftTopColIndexInPanel;
			this.LeftTopPosInPanel.RowIndex = leftTopRowIndexInPanel;
			this.CalculatePanelRange(this.PanelRange, this.LeftTopPosInPanel);
		}

		// Token: 0x06041491 RID: 267409 RVA: 0x00FD26E0 File Offset: 0x00FD08E0
		private void RecordLastPanelRange()
		{
			this.LastPanelRange.RowStartIndex = this.PanelRange.RowStartIndex;
			this.LastPanelRange.RowEndIndex = this.PanelRange.RowEndIndex;
			this.LastPanelRange.ColStartIndex = this.PanelRange.ColStartIndex;
			this.LastPanelRange.ColEndIndex = this.PanelRange.ColEndIndex;
		}

		// Token: 0x06041492 RID: 267410 RVA: 0x00FD2748 File Offset: 0x00FD0948
		private Vector2D GetCenterPivotByRotate()
		{
			switch (this.Rotate)
			{
			case FishingItemRotate.No:
				this.TempPivot.Set(this.OriginalPivot.X, this.OriginalPivot.Y);
				break;
			case FishingItemRotate.DirectionDown:
				this.TempPivot.Set(this.OriginalPivot.Y, 1.0 - this.OriginalPivot.X);
				break;
			case FishingItemRotate.DirectionLeft:
				this.TempPivot.Set(1.0 - this.OriginalPivot.X, 1.0 - this.OriginalPivot.Y);
				break;
			case FishingItemRotate.DirectionUp:
				this.TempPivot.Set(1.0 - this.OriginalPivot.Y, this.OriginalPivot.X);
				break;
			}
			return this.TempPivot;
		}

		// Token: 0x06041493 RID: 267411 RVA: 0x00FD2832 File Offset: 0x00FD0A32
		public Vector2D GetTopLeftOffsetByRotate()
		{
			this.TempOffset.Set(0.0, 1.0);
			this.TempPivot = this.GetCenterPivotByRotate();
			return this.TempOffset.SubtractionEqual(this.TempPivot);
		}

		// Token: 0x06041494 RID: 267412 RVA: 0x00FD2870 File Offset: 0x00FD0A70
		public void RotateData()
		{
			ValueTuple<List<List<int>>, FishingItemRotate> valueTuple = DockyardPanelUtil.RotateItemGridData(this.TempPosData, this.Rotate);
			this.TempPosData = valueTuple.Item1;
			this.Rotate = valueTuple.Item2;
		}

		// Token: 0x06041495 RID: 267413 RVA: 0x00FD28A7 File Offset: 0x00FD0AA7
		public List<List<int>> GetGridDataDoubleList()
		{
			return this.TempPosData;
		}

		// Token: 0x06041496 RID: 267414 RVA: 0x00FD28AF File Offset: 0x00FD0AAF
		public IEnumerable<IPanelPos> GetPosDataList()
		{
			return this.Data.PosDataList;
		}

		// Token: 0x06041497 RID: 267415 RVA: 0x00FD28BC File Offset: 0x00FD0ABC
		public float GetRotateValue()
		{
			switch (this.Rotate)
			{
			case FishingItemRotate.No:
				return 0f;
			case FishingItemRotate.DirectionDown:
				return -90f;
			case FishingItemRotate.DirectionLeft:
				return -180f;
			case FishingItemRotate.DirectionUp:
				return -270f;
			default:
				return 0f;
			}
		}

		// Token: 0x06041498 RID: 267416 RVA: 0x00FD2905 File Offset: 0x00FD0B05
		public Vector2D GetOriginalPivot()
		{
			return this.OriginalPivot;
		}

		// Token: 0x06041499 RID: 267417 RVA: 0x00FD2910 File Offset: 0x00FD0B10
		public void RefreshLeftTopPosInBackpack(Vector2D anchorOffset, float blockWidth, float blockHeight, float gridWidth)
		{
			Vector2D topLeftOffsetByRotate = this.GetTopLeftOffsetByRotate();
			if (this.IsInUpOrDown())
			{
				topLeftOffsetByRotate.X *= (double)blockWidth;
				topLeftOffsetByRotate.Y *= (double)blockHeight;
			}
			else
			{
				topLeftOffsetByRotate.X *= (double)blockHeight;
				topLeftOffsetByRotate.Y *= (double)blockWidth;
			}
			anchorOffset.Addition(topLeftOffsetByRotate, topLeftOffsetByRotate);
			this.LeftTopAnchorOffset.DeepCopy(topLeftOffsetByRotate);
			this.RecordLastPanelRange();
			this.CalculateLeftTopPosInPanel(topLeftOffsetByRotate, gridWidth);
		}

		// Token: 0x0604149A RID: 267418 RVA: 0x00FD298E File Offset: 0x00FD0B8E
		public IPanelPosRange GetLeftTopPosRangeByLeftTopPos(Vector2D offset, float gridWidth)
		{
			this.LeftTopAnchorOffset.DeepCopy(offset);
			this.RecordLastPanelRange();
			this.CalculateLeftTopPosInPanel(offset, gridWidth);
			return this.PanelRange;
		}

		// Token: 0x0604149B RID: 267419 RVA: 0x00FD29B0 File Offset: 0x00FD0BB0
		public bool IsValidGridPos(int rowIndex, int colIndex)
		{
			int index = rowIndex - this.LeftTopPosInPanel.RowIndex;
			int index2 = colIndex - this.LeftTopPosInPanel.ColIndex;
			return this.TempPosData[index][index2] == 1;
		}

		// Token: 0x0604149C RID: 267420 RVA: 0x00FD29F0 File Offset: 0x00FD0BF0
		public Vector2D GetCenterPosInBackpack(int rowStartIndex, int colStartIndex)
		{
			this.TempPivot = this.GetCenterPivotByRotate();
			double x = (double)colStartIndex + this.TempPivot.X * (double)this.TempPosData[0].Count;
			double y = (double)rowStartIndex + (1.0 - this.TempPivot.Y) * (double)this.TempPosData.Count;
			return Vector2D.Create(x, y);
		}

		// Token: 0x04021FB9 RID: 139193
		private List<List<int>> TempPosData = new List<List<int>>();

		// Token: 0x04021FBA RID: 139194
		public FishingItemRotate Rotate;

		// Token: 0x04021FBB RID: 139195
		public readonly IPanelPos LeftTopPosInPanel = new PanelPos
		{
			RowIndex = -1,
			ColIndex = -1
		};

		// Token: 0x04021FBC RID: 139196
		public readonly IPanelPosRange PanelRange = new PanelPosRange
		{
			RowStartIndex = -1,
			RowEndIndex = -1,
			ColStartIndex = -1,
			ColEndIndex = -1
		};

		// Token: 0x04021FBD RID: 139197
		public readonly IPanelPosRange LastPanelRange = new PanelPosRange
		{
			RowStartIndex = -1,
			RowEndIndex = -1,
			ColStartIndex = -1,
			ColEndIndex = -1
		};

		// Token: 0x04021FBE RID: 139198
		private readonly Vector2D OriginalPivot;

		// Token: 0x04021FBF RID: 139199
		private Vector2D TempPivot;

		// Token: 0x04021FC0 RID: 139200
		private readonly Vector2D TempOffset;

		// Token: 0x04021FC1 RID: 139201
		public readonly Vector2D LeftTopAnchorOffset;

		// Token: 0x04021FC2 RID: 139202
		public DockyardItemBlockOriginalData Data;
	}
}
