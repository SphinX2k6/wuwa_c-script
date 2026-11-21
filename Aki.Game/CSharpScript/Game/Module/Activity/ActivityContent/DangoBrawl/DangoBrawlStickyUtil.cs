using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200572F RID: 22319
	[NullableContext(2)]
	[Nullable(0)]
	public static class DangoBrawlStickyUtil
	{
		// Token: 0x06036EC2 RID: 224962 RVA: 0x00F519DD File Offset: 0x00F4FBDD
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

		// Token: 0x06036EC3 RID: 224963 RVA: 0x00F519F4 File Offset: 0x00F4FBF4
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

		// Token: 0x06036EC4 RID: 224964 RVA: 0x00F51A60 File Offset: 0x00F4FC60
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
