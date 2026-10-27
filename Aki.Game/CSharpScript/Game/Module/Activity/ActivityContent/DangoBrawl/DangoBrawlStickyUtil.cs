using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067DF RID: 26591
	[NullableContext(2)]
	[Nullable(0)]
	public static class DangoBrawlStickyUtil
	{
		// Token: 0x0604236C RID: 271212 RVA: 0x01010545 File Offset: 0x0100E745
		public static DangoBrawlBackpackItemData PickReplaceCandidate([Nullable(new byte[]
		{
			2,
			1
		})] List<DangoBrawlBackpackItemData> abandonedFollowers, [Nullable(new byte[]
		{
			2,
			1
		})] List<DangoBrawlBackpackItemData> replacedItems, bool isLayerMode)
		{
			return DangoBrawlStickyUtil.Pick(abandonedFollowers, isLayerMode) ?? DangoBrawlStickyUtil.Pick(replacedItems, isLayerMode);
		}

		// Token: 0x0604236D RID: 271213 RVA: 0x0101055C File Offset: 0x0100E75C
		private static DangoBrawlBackpackItemData Pick([Nullable(new byte[]
		{
			2,
			1
		})] List<DangoBrawlBackpackItemData> candidates, bool isLayerMode)
		{
			if (candidates == null)
			{
				return null;
			}
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = null;
			foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 in candidates)
			{
				if ((!isLayerMode || dangoBrawlBackpackItemData2.MyTemplateType != EDangoBrawlTemplateType.Item) && (dangoBrawlBackpackItemData == null || DangoBrawlStickyUtil.IsBetter(dangoBrawlBackpackItemData2, dangoBrawlBackpackItemData)))
				{
					dangoBrawlBackpackItemData = dangoBrawlBackpackItemData2;
				}
			}
			return dangoBrawlBackpackItemData;
		}

		// Token: 0x0604236E RID: 271214 RVA: 0x010105C8 File Offset: 0x0100E7C8
		[NullableContext(1)]
		private static bool IsBetter(DangoBrawlBackpackItemData a, DangoBrawlBackpackItemData b)
		{
			if (a.MyPanelPosList.Length != b.MyPanelPosList.Length)
			{
				return a.MyPanelPosList.Length > b.MyPanelPosList.Length;
			}
			if (a.MyLeftTopPos.RowIndex != b.MyLeftTopPos.RowIndex)
			{
				return a.MyLeftTopPos.RowIndex < b.MyLeftTopPos.RowIndex;
			}
			return a.MyLeftTopPos.ColIndex < b.MyLeftTopPos.ColIndex;
		}
	}
}
