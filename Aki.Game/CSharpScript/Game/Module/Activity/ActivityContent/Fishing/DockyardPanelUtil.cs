using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200551E RID: 21790
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardPanelUtil
	{
		// Token: 0x0603608E RID: 221326 RVA: 0x00F15B54 File Offset: 0x00F13D54
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public static ValueTuple<List<List<int>>, FishingItemRotate> RotateItemGridData(List<List<int>> itemBlock, FishingItemRotate currentRotateType)
		{
			int count = itemBlock.Count;
			int count2 = itemBlock[0].Count;
			List<List<int>> list = new List<List<int>>();
			for (int i = 0; i < count2; i++)
			{
				list.Add(new List<int>());
				for (int j = count - 1; j >= 0; j--)
				{
					list[i].Add(itemBlock[j][i]);
				}
			}
			if (currentRotateType == FishingItemRotate.DirectionUp)
			{
				return new ValueTuple<List<List<int>>, FishingItemRotate>(list, FishingItemRotate.No);
			}
			return new ValueTuple<List<List<int>>, FishingItemRotate>(list, currentRotateType + 1);
		}

		// Token: 0x0603608F RID: 221327 RVA: 0x00F15BD4 File Offset: 0x00F13DD4
		public static List<List<int>> RotateOriginalPosData(List<List<int>> posData, FishingItemRotate rotate)
		{
			int count = posData.Count;
			int count2 = posData[0].Count;
			List<List<int>> list = new List<List<int>>();
			if (rotate == FishingItemRotate.No)
			{
				for (int i = 0; i < count; i++)
				{
					list.Add(new List<int>());
					for (int j = 0; j < count2; j++)
					{
						list[i].Add(posData[i][j]);
					}
				}
			}
			else if (rotate == FishingItemRotate.DirectionDown)
			{
				for (int k = 0; k < count2; k++)
				{
					list.Add(new List<int>());
					for (int l = count - 1; l >= 0; l--)
					{
						list[k].Add(posData[l][k]);
					}
				}
			}
			else if (rotate == FishingItemRotate.DirectionLeft)
			{
				for (int m = 0; m < count; m++)
				{
					list.Add(new List<int>());
					for (int n = 0; n < count2; n++)
					{
						list[m].Add(posData[count - 1 - m][count2 - 1 - n]);
					}
				}
			}
			else
			{
				for (int num = 0; num < count2; num++)
				{
					list.Add(new List<int>());
					for (int num2 = 0; num2 < count; num2++)
					{
						list[num].Add(posData[num2][count2 - 1 - num]);
					}
				}
			}
			return list;
		}

		// Token: 0x06036090 RID: 221328 RVA: 0x00F15D37 File Offset: 0x00F13F37
		public static IPanelPosRange CreateAndDeepCopyItemRangePos(IPanelPosRange targetPos)
		{
			PanelPosRange panelPosRange = new PanelPosRange();
			panelPosRange.RowStartIndex = -1;
			panelPosRange.RowEndIndex = -1;
			panelPosRange.ColStartIndex = -1;
			panelPosRange.ColEndIndex = -1;
			DockyardPanelUtil.DeepCopyItemRangePos(panelPosRange, targetPos);
			return panelPosRange;
		}

		// Token: 0x06036091 RID: 221329 RVA: 0x00F15D61 File Offset: 0x00F13F61
		public static void DeepCopyItemRangePos(IPanelPosRange original, IPanelPosRange targetPos)
		{
			original.RowStartIndex = targetPos.RowStartIndex;
			original.RowEndIndex = targetPos.RowEndIndex;
			original.ColStartIndex = targetPos.ColStartIndex;
			original.ColEndIndex = targetPos.ColEndIndex;
		}

		// Token: 0x06036092 RID: 221330 RVA: 0x00F15D94 File Offset: 0x00F13F94
		public static Vector2D CalculateOriginalPivot(int rowLength, int colLength)
		{
			Vector2D vector2D = Vector2D.Create();
			if (rowLength == colLength)
			{
				vector2D.Set(0.5, 0.5);
			}
			else if (Math.Abs(rowLength - colLength) % 2 == 0)
			{
				vector2D.Set(0.5, 0.5);
			}
			else if (colLength % 2 == 1)
			{
				float num = ((float)colLength / 2f - 0.5f) / (float)colLength;
				vector2D.Set((double)num, 0.5);
			}
			else
			{
				float num2 = ((float)rowLength / 2f - 0.5f) / (float)rowLength;
				vector2D.Set(0.5, (double)num2);
			}
			return vector2D;
		}

		// Token: 0x06036093 RID: 221331 RVA: 0x00F15E40 File Offset: 0x00F14040
		public static FishingItemInfo CreateFishingItemInfo(DockyardItemBlockOriginalData data, FishingItemRotate rotate, IPanelPos leftTopPosInPanel)
		{
			FishingItemInfo fishingItemInfo = FishingItemInfo.Create();
			fishingItemInfo.IncrId = data.IncId;
			fishingItemInfo.ItemId = data.ItemId;
			fishingItemInfo.Quality = data.Quality;
			fishingItemInfo.Size = data.Size;
			fishingItemInfo.Price = data.Price;
			fishingItemInfo.Cup = (FishCup)data.Cup;
			fishingItemInfo.Rotate = rotate;
			IntVector2D intVector2D = IntVector2D.Create();
			intVector2D.X = leftTopPosInPanel.ColIndex;
			intVector2D.Y = leftTopPosInPanel.RowIndex;
			fishingItemInfo.Pos = intVector2D;
			return fishingItemInfo;
		}

		// Token: 0x06036094 RID: 221332 RVA: 0x00F15EC6 File Offset: 0x00F140C6
		public static string GetTexturePathByCup(int cup)
		{
			if (cup == 0)
			{
				return UiResourceConfig.Instance.GetResourcePath("T_IconCupSilver");
			}
			if (cup == 1)
			{
				return "";
			}
			return UiResourceConfig.Instance.GetResourcePath("T_IconCupGold");
		}
	}
}
