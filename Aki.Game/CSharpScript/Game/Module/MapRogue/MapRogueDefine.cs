using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055AF RID: 21935
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueDefine
	{
		// Token: 0x06037EAF RID: 229039 RVA: 0x00D3FC12 File Offset: 0x00D3DE12
		public static int GridLocationToIndex(int x, int y, int width)
		{
			return y * width + x;
		}

		// Token: 0x06037EB0 RID: 229040 RVA: 0x00D3FC1C File Offset: 0x00D3DE1C
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

		// Token: 0x06037EB1 RID: 229041 RVA: 0x00D3FC4C File Offset: 0x00D3DE4C
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

		// Token: 0x06037EB2 RID: 229042 RVA: 0x00D3FC98 File Offset: 0x00D3DE98
		public static bool InAxisAlignedDiamond(int x, int y, IGridRangeInfo info)
		{
			double num = Math.Abs((double)x - info.CenterX) / info.RadiusX;
			double num2 = Math.Abs((double)y - info.CenterY) / info.RadiusY;
			return num + num2 <= 1.0;
		}

		// Token: 0x06037EB3 RID: 229043 RVA: 0x00D3FCE4 File Offset: 0x00D3DEE4
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

		// Token: 0x0401D602 RID: 120322
		public const int TYPE_EVENT_WEIGHT = 1000000;

		// Token: 0x0401D603 RID: 120323
		public const int THOUSANDTH_RATIO = 1000;
	}
}
