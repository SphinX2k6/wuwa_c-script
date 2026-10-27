using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065A0 RID: 26016
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardPanelUtil
	{
		// Token: 0x060413C9 RID: 267209 RVA: 0x00FCEB50 File Offset: 0x00FCCD50
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

		// Token: 0x060413CA RID: 267210 RVA: 0x00FCEBD0 File Offset: 0x00FCCDD0
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

		// Token: 0x060413CB RID: 267211 RVA: 0x00FCED33 File Offset: 0x00FCCF33
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

		// Token: 0x060413CC RID: 267212 RVA: 0x00FCED5D File Offset: 0x00FCCF5D
		public static void DeepCopyItemRangePos(IPanelPosRange original, IPanelPosRange targetPos)
		{
			original.RowStartIndex = targetPos.RowStartIndex;
			original.RowEndIndex = targetPos.RowEndIndex;
			original.ColStartIndex = targetPos.ColStartIndex;
			original.ColEndIndex = targetPos.ColEndIndex;
		}

		// Token: 0x060413CD RID: 267213 RVA: 0x00FCED90 File Offset: 0x00FCCF90
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

		// Token: 0x060413CE RID: 267214 RVA: 0x00FCEE3C File Offset: 0x00FCD03C
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

		// Token: 0x060413CF RID: 267215 RVA: 0x00FCEEC2 File Offset: 0x00FCD0C2
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
