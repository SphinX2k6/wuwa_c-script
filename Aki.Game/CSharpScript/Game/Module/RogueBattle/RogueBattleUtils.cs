using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EA9 RID: 16041
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleUtils
	{
		// Token: 0x06028BAB RID: 166827 RVA: 0x00B6CAD8 File Offset: 0x00B6ACD8
		public static List<IRogueBattleElementInfo> GetTokenSortElementInfo(RogueResGainData data)
		{
			List<IRogueBattleElementInfo> list = new List<IRogueBattleElementInfo>();
			foreach (ElementUnit elementUnit in data.RogueResToken.ElementUnits)
			{
				list.Add(new RogueBattleElementInfo
				{
					ElementId = elementUnit.ElementId,
					Count = elementUnit.Count,
					IsPreview = false
				});
			}
			return list;
		}

		// Token: 0x06028BAC RID: 166828 RVA: 0x00B6CB54 File Offset: 0x00B6AD54
		public static int[] GetTokenSortElementInfoByCount(RogueResGainData data)
		{
			List<IRogueBattleElementInfo> list = new List<IRogueBattleElementInfo>();
			IReadOnlyList<ElementUnit> readOnlyList = new ElementUnit[0];
			if (data.RogueResToken != null)
			{
				readOnlyList = data.RogueResToken.ElementUnits;
			}
			else if (data.RogueResShopToken != null)
			{
				readOnlyList = data.RogueResShopToken.ElementUnits;
			}
			foreach (ElementUnit elementUnit in readOnlyList)
			{
				list.Add(new RogueBattleElementInfo
				{
					ElementId = elementUnit.ElementId,
					Count = elementUnit.Count,
					IsPreview = false
				});
			}
			if (list.Count <= 0)
			{
				return Array.Empty<int>();
			}
			int[] array = new int[list[0].Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = list[0].ElementId;
			}
			return array;
		}

		// Token: 0x06028BAD RID: 166829 RVA: 0x00B6CC40 File Offset: 0x00B6AE40
		public static List<IRogueBattleElementInfo> ConvertElementUnitsToElementInfo(IReadOnlyList<ElementUnit> elementUnits)
		{
			List<IRogueBattleElementInfo> list = new List<IRogueBattleElementInfo>();
			foreach (ElementUnit elementUnit in elementUnits)
			{
				list.Add(new RogueBattleElementInfo
				{
					ElementId = elementUnit.ElementId,
					Count = elementUnit.Count,
					IsPreview = false
				});
			}
			return list;
		}
	}
}
