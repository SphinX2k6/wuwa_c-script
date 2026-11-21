using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004585 RID: 17797
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueDefine
	{
		// Token: 0x0602CDAD RID: 183725 RVA: 0x00C8D95A File Offset: 0x00C8BB5A
		public static int GridLocationToIndex(int x, int y, int width)
		{
			return y * width + x;
		}

		// Token: 0x0602CDAE RID: 183726 RVA: 0x00C8D964 File Offset: 0x00C8BB64
		public static MapRogueMapPoint IndexToGridLocation(int index, int width)
		{
			int x = index % width;
			int y = (int)Math.Floor((double)index / (double)width);
			return new MapRogueMapPoint
			{
				X = x,
				Y = y
			};
		}

		// Token: 0x0602CDAF RID: 183727 RVA: 0x00C8D994 File Offset: 0x00C8BB94
		public static int[] ParseNumbers(string input, string separator = "#")
		{
			string[] array = input.Split(separator, StringSplitOptions.None);
			List<int> list = new List<int>();
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				int item;
				if (!int.TryParse(array2[i], out item))
				{
					return new int[0];
				}
				list.Add(item);
			}
			return list.ToArray();
		}

		// Token: 0x0602CDB0 RID: 183728 RVA: 0x00C8D9E0 File Offset: 0x00C8BBE0
		public static bool InAxisAlignedDiamond(int x, int y, IGridRangeInfo info)
		{
			double num = Math.Abs((double)x - info.CenterX) / info.RadiusX;
			double num2 = Math.Abs((double)y - info.CenterY) / info.RadiusY;
			return num + num2 <= 1.0;
		}

		// Token: 0x0602CDB1 RID: 183729 RVA: 0x00C8DA2C File Offset: 0x00C8BC2C
		public static GridPopupView popupModelBaseGenerator(MapGridData gridData, MapRogueGameInfo gameInfo)
		{
			GridPopupViewModelBase vm;
			switch (gridData.GridEventType)
			{
			case EGridEventType.Blank:
				vm = new GridPopupViewModelBlank(gridData, gameInfo);
				break;
			case EGridEventType.Event:
				vm = new GridPopupViewModelEvent(gridData, gameInfo);
				break;
			case EGridEventType.Battle:
				vm = new GridPopupViewModelBattle(gridData, gameInfo);
				break;
			case EGridEventType.Boss:
				vm = new GridPopupViewModelBoss(gridData, gameInfo);
				break;
			default:
				vm = new GridPopupViewModelBlank(gridData, gameInfo);
				break;
			}
			return new GridPopupView(vm);
		}

		// Token: 0x0401808D RID: 98445
		public const int TYPE_EVENT_WEIGHT = 1000000;

		// Token: 0x0401808E RID: 98446
		public const int THOUSANDTH_RATIO = 1000;
	}
}
