using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x0200477F RID: 18303
	[NullableContext(1)]
	[Nullable(0)]
	public static class WorldMapDefine
	{
		// Token: 0x0602FE12 RID: 196114 RVA: 0x00B190D8 File Offset: 0x00B172D8
		// Note: this type is marked as 'beforefieldinit'.
		unsafe static WorldMapDefine()
		{
			int num = 55;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(40, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(41, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(42, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(43, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(44, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(45, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(46, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(47, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(48, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(49, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(50, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(51, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(53, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(54, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(55, typeof(UUIScrollViewWithScrollbarComponent));
			WorldMapDefine.SecondaryUiPanelComponentsRegisterInfoA = list;
			num2 = 17;
			List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
			span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
			num = 0;
			*span[num] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num++;
			*span[num] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num++;
			*span[num] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num++;
			*span[num] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num++;
			*span[num] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num++;
			*span[num] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num++;
			*span[num] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num++;
			*span[num] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num++;
			*span[num] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			WorldMapDefine.SecondaryUiPanelComponentsRegisterInfoB = list2;
			WorldMapDefine.OnlinePlayerIconPathList = new string[]
			{
				"SP_MapFollowing1",
				"SP_MapFollowing2",
				"SP_MapFollowing3"
			};
			WorldMapDefine.OnlinePlayerIconPathList2 = new string[]
			{
				"SP_IconMap_Mark_1P_UI",
				"SP_IconMap_Mark_2P_UI",
				"SP_IconMap_Mark_3P_UI"
			};
		}

		// Token: 0x04019D06 RID: 105734
		public const string MULTI_MAP_SELECT_ICON_PATH = "SP_MarkMultiMapSelect";

		// Token: 0x04019D07 RID: 105735
		public const string BLOCK_MARK_ICON_PATH = "SP_MarkBlock";

		// Token: 0x04019D08 RID: 105736
		public const string SUB_ICON_PATH = "SP_MarkRecommend";

		// Token: 0x04019D09 RID: 105737
		public const string MULTI_MAP_ICON_PATH = "SP_MarkMultiMap";

		// Token: 0x04019D0A RID: 105738
		public const string TEMPORARY_TELEPORT_NORMAL_ICON_PATH = "SP_MarkTime";

		// Token: 0x04019D0B RID: 105739
		public const string MORALE_FLAG_BOX_ICON_PATH = "SP_MarkGift";

		// Token: 0x04019D0C RID: 105740
		public const string MARK_ITEM_VIEW_PATH = "UiItem_WorldMapMark_Prefab";

		// Token: 0x04019D0D RID: 105741
		public const int MARK_CLICK_RANGE = 50;

		// Token: 0x04019D0E RID: 105742
		public const int DEBUG_SPHERE_DEFAULT_RADIUS = 30;

		// Token: 0x04019D0F RID: 105743
		public const int DEBUG_SPHERE_DEFAULT_SEGMENTS = 30;

		// Token: 0x04019D10 RID: 105744
		public const int DEBUG_SPHERE_DEFAULT_DURATION = 3;

		// Token: 0x04019D11 RID: 105745
		public const float SCALE_STEP = 0.1f;

		// Token: 0x04019D12 RID: 105746
		public const int HUANG_LONG_COUNTRY_ID = 1;

		// Token: 0x04019D13 RID: 105747
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		[StaticVariableRuleIgnore]
		public static List<ValueTuple<int, Type>> SecondaryUiPanelComponentsRegisterInfoA;

		// Token: 0x04019D14 RID: 105748
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		[StaticVariableRuleIgnore]
		public static List<ValueTuple<int, Type>> SecondaryUiPanelComponentsRegisterInfoB;

		// Token: 0x04019D15 RID: 105749
		[StaticVariableRuleIgnore]
		public static readonly string[] OnlinePlayerIconPathList;

		// Token: 0x04019D16 RID: 105750
		[StaticVariableRuleIgnore]
		public static readonly string[] OnlinePlayerIconPathList2;
	}
}
