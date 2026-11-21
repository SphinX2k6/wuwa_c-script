using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200552C RID: 21804
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardItemBlockData
	{
		// Token: 0x170068DF RID: 26847
		// (get) Token: 0x0603614D RID: 221517 RVA: 0x00F1938B File Offset: 0x00F1758B
		private List<List<int>> OriginalPosData
		{
			get
			{
				return this.Data.PosDoublyList;
			}
		}

		// Token: 0x0603614E RID: 221518 RVA: 0x00F19398 File Offset: 0x00F17598
		public DockyardItemBlockData(DockyardItemBlockOriginalData data)
		{
			this.Data = data;
			this.OriginalPivot = Vector2D.Create();
			this.TempPivot = Vector2D.Create();
			this.TempOffset = Vector2D.Create();
			this.LeftTopAnchorOffset = Vector2D.Create();
			this.TempPosData = new List<List<int>>(DockyardPanelUtil.RotateOriginalPosData(this.OriginalPosData, data.Rotate));
			this.LeftTopPosInPanel.ColIndex = data.PosX;
			this.LeftTopPosInPanel.RowIndex = data.PosY;
			this.Rotate = data.Rotate;
			this.CalculatePanelRange(this.PanelRange, this.LeftTopPosInPanel);
			this.RecordLastPanelRange();
			this.CalculateOriginalPivot();
		}

		// Token: 0x0603614F RID: 221519 RVA: 0x00F194B8 File Offset: 0x00F176B8
		public void RefreshData(DockyardItemBlockOriginalData data)
		{
			this.Data = data;
		}

		// Token: 0x06036150 RID: 221520 RVA: 0x00F194C1 File Offset: 0x00F176C1
		public bool IsInUpOrDown()
		{
			return this.Rotate == FishingItemRotate.No || this.Rotate == FishingItemRotate.DirectionLeft;
		}

		// Token: 0x06036151 RID: 221521 RVA: 0x00F194D6 File Offset: 0x00F176D6
		private void CalculateOriginalPivot()
		{
			this.OriginalPivot.DeepCopy(DockyardPanelUtil.CalculateOriginalPivot(this.OriginalPosData.Count, this.OriginalPosData[0].Count));
		}

		// Token: 0x06036152 RID: 221522 RVA: 0x00F19504 File Offset: 0x00F17704
		private void CalculatePanelRange(IPanelPosRange panelRange, IPanelPos panelPos)
		{
			int count;
			int count2;
			if (this.IsInUpOrDown())
			{
				count = this.OriginalPosData.Count;
				count2 = this.OriginalPosData[0].Count;
			}
			else
			{
				count = this.OriginalPosData[0].Count;
				count2 = this.OriginalPosData.Count;
			}
			panelRange.RowStartIndex = panelPos.RowIndex;
			panelRange.RowEndIndex = panelPos.RowIndex + count - 1;
			panelRange.ColStartIndex = panelPos.ColIndex;
			panelRange.ColEndIndex = panelPos.ColIndex + count2 - 1;
		}

		// Token: 0x06036153 RID: 221523 RVA: 0x00F19594 File Offset: 0x00F17794
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

		// Token: 0x06036154 RID: 221524 RVA: 0x00F19610 File Offset: 0x00F17810
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

		// Token: 0x06036155 RID: 221525 RVA: 0x00F19690 File Offset: 0x00F17890
		private void CalculateLeftTopPosInPanel(Vector2D position, float gridWidth)
		{
			int leftTopColIndexInPanel = this.GetLeftTopColIndexInPanel(position.X, gridWidth);
			int leftTopRowIndexInPanel = this.GetLeftTopRowIndexInPanel(position.Y, gridWidth);
			this.LeftTopPosInPanel.ColIndex = leftTopColIndexInPanel;
			this.LeftTopPosInPanel.RowIndex = leftTopRowIndexInPanel;
			this.CalculatePanelRange(this.PanelRange, this.LeftTopPosInPanel);
		}

		// Token: 0x06036156 RID: 221526 RVA: 0x00F196E4 File Offset: 0x00F178E4
		private void RecordLastPanelRange()
		{
			this.LastPanelRange.RowStartIndex = this.PanelRange.RowStartIndex;
			this.LastPanelRange.RowEndIndex = this.PanelRange.RowEndIndex;
			this.LastPanelRange.ColStartIndex = this.PanelRange.ColStartIndex;
			this.LastPanelRange.ColEndIndex = this.PanelRange.ColEndIndex;
		}

		// Token: 0x06036157 RID: 221527 RVA: 0x00F1974C File Offset: 0x00F1794C
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

		// Token: 0x06036158 RID: 221528 RVA: 0x00F19836 File Offset: 0x00F17A36
		public Vector2D GetTopLeftOffsetByRotate()
		{
			this.TempOffset.Set(0.0, 1.0);
			this.TempPivot = this.GetCenterPivotByRotate();
			return this.TempOffset.SubtractionEqual(this.TempPivot);
		}

		// Token: 0x06036159 RID: 221529 RVA: 0x00F19874 File Offset: 0x00F17A74
		public void RotateData()
		{
			ValueTuple<List<List<int>>, FishingItemRotate> valueTuple = DockyardPanelUtil.RotateItemGridData(this.TempPosData, this.Rotate);
			this.TempPosData = valueTuple.Item1;
			this.Rotate = valueTuple.Item2;
		}

		// Token: 0x0603615A RID: 221530 RVA: 0x00F198AB File Offset: 0x00F17AAB
		public List<List<int>> GetGridDataDoubleList()
		{
			return this.TempPosData;
		}

		// Token: 0x0603615B RID: 221531 RVA: 0x00F198B3 File Offset: 0x00F17AB3
		public IEnumerable<IPanelPos> GetPosDataList()
		{
			return this.Data.PosDataList;
		}

		// Token: 0x0603615C RID: 221532 RVA: 0x00F198C0 File Offset: 0x00F17AC0
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

		// Token: 0x0603615D RID: 221533 RVA: 0x00F19909 File Offset: 0x00F17B09
		public Vector2D GetOriginalPivot()
		{
			return this.OriginalPivot;
		}

		// Token: 0x0603615E RID: 221534 RVA: 0x00F19914 File Offset: 0x00F17B14
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

		// Token: 0x0603615F RID: 221535 RVA: 0x00F19992 File Offset: 0x00F17B92
		public IPanelPosRange GetLeftTopPosRangeByLeftTopPos(Vector2D offset, float gridWidth)
		{
			this.LeftTopAnchorOffset.DeepCopy(offset);
			this.RecordLastPanelRange();
			this.CalculateLeftTopPosInPanel(offset, gridWidth);
			return this.PanelRange;
		}

		// Token: 0x06036160 RID: 221536 RVA: 0x00F199B4 File Offset: 0x00F17BB4
		public bool IsValidGridPos(int rowIndex, int colIndex)
		{
			int index = rowIndex - this.LeftTopPosInPanel.RowIndex;
			int index2 = colIndex - this.LeftTopPosInPanel.ColIndex;
			return this.TempPosData[index][index2] == 1;
		}

		// Token: 0x06036161 RID: 221537 RVA: 0x00F199F4 File Offset: 0x00F17BF4
		public Vector2D GetCenterPosInBackpack(int rowStartIndex, int colStartIndex)
		{
			this.TempPivot = this.GetCenterPivotByRotate();
			double x = (double)colStartIndex + this.TempPivot.X * (double)this.TempPosData[0].Count;
			double y = (double)rowStartIndex + (1.0 - this.TempPivot.Y) * (double)this.TempPosData.Count;
			return Vector2D.Create(x, y);
		}

		// Token: 0x0401C8EA RID: 116970
		private List<List<int>> TempPosData = new List<List<int>>();

		// Token: 0x0401C8EB RID: 116971
		public FishingItemRotate Rotate;

		// Token: 0x0401C8EC RID: 116972
		public readonly IPanelPos LeftTopPosInPanel = new PanelPos
		{
			RowIndex = -1,
			ColIndex = -1
		};

		// Token: 0x0401C8ED RID: 116973
		public readonly IPanelPosRange PanelRange = new PanelPosRange
		{
			RowStartIndex = -1,
			RowEndIndex = -1,
			ColStartIndex = -1,
			ColEndIndex = -1
		};

		// Token: 0x0401C8EE RID: 116974
		public readonly IPanelPosRange LastPanelRange = new PanelPosRange
		{
			RowStartIndex = -1,
			RowEndIndex = -1,
			ColStartIndex = -1,
			ColEndIndex = -1
		};

		// Token: 0x0401C8EF RID: 116975
		private readonly Vector2D OriginalPivot;

		// Token: 0x0401C8F0 RID: 116976
		private Vector2D TempPivot;

		// Token: 0x0401C8F1 RID: 116977
		private readonly Vector2D TempOffset;

		// Token: 0x0401C8F2 RID: 116978
		public readonly Vector2D LeftTopAnchorOffset;

		// Token: 0x0401C8F3 RID: 116979
		public DockyardItemBlockOriginalData Data;
	}
}
