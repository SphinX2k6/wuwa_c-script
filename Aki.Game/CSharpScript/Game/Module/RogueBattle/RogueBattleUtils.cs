using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EE0 RID: 20192
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleUtils
	{
		// Token: 0x06033D40 RID: 212288 RVA: 0x00C23564 File Offset: 0x00C21764
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

		// Token: 0x06033D41 RID: 212289 RVA: 0x00C235E0 File Offset: 0x00C217E0
		public static int[] GetTokenSortElementInfoByCount(RogueResGainData data)
		{
			List<IRogueBattleElementInfo> list = new List<IRogueBattleElementInfo>();
			ElementUnit[] array = new ElementUnit[0];
			if (data.RogueResToken != null)
			{
				array = data.RogueResToken.ElementUnits.ToArray<ElementUnit>();
			}
			else if (data.RogueResShopToken != null)
			{
				array = data.RogueResShopToken.ElementUnits.ToArray<ElementUnit>();
			}
			foreach (ElementUnit elementUnit in array)
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
			int[] array3 = new int[list[0].Count];
			for (int j = 0; j < array3.Length; j++)
			{
				array3[j] = list[0].ElementId;
			}
			return array3;
		}

		// Token: 0x06033D42 RID: 212290 RVA: 0x00C236B8 File Offset: 0x00C218B8
		public static List<IRogueBattleElementInfo> ConvertElementUnitsToElementInfo(ElementUnit[] elementUnits)
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
