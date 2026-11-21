using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CEF RID: 7407
public class RoleTowerPropTeamPanel : UiPanelBase
{
	// Token: 0x0601255C RID: 75100 RVA: 0x00568C08 File Offset: 0x00566E08
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0601255D RID: 75101 RVA: 0x00568C90 File Offset: 0x00566E90
	protected override void OnStart()
	{
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(1);
		bool flag;
		if (horizontalLayout == null)
		{
			flag = (null != null);
		}
		else
		{
			UUIItem uuiitem = horizontalLayout.RootUIComp.Get();
			flag = (((uuiitem != null) ? uuiitem.GetAttachUIChild(0) : null) != null);
		}
		if (flag)
		{
			this.StarLayout = new GenericLayout<RoleTowerPauseStarItem, bool>(horizontalLayout, () => new RoleTowerPauseStarItem(), null, false, true);
		}
		this.BuffScroll = new GenericScrollViewNew<RoleTowerPropBuffItem, RoleTowerPropBuffData>(base.GetScrollViewWithScrollbar(3), () => new RoleTowerPropBuffItem(), null, false, null);
	}

	// Token: 0x0601255E RID: 75102 RVA: 0x00568D2C File Offset: 0x00566F2C
	[NullableContext(1)]
	public void Refresh(int curStar, int starLimit, List<RoleTowerPropBuffData> buffList)
	{
		List<bool> list = new List<bool>();
		for (int i = 0; i < starLimit; i++)
		{
			list.Add(i < curStar);
		}
		GenericLayout<RoleTowerPauseStarItem, bool> starLayout = this.StarLayout;
		if (starLayout != null)
		{
			starLayout.RefreshByData(list, null, false);
		}
		GenericScrollViewNew<RoleTowerPropBuffItem, RoleTowerPropBuffData> buffScroll = this.BuffScroll;
		if (buffScroll == null)
		{
			return;
		}
		buffScroll.RefreshByData(buffList, null, false);
	}

	// Token: 0x04009FE3 RID: 40931
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTowerPauseStarItem, bool> StarLayout;

	// Token: 0x04009FE4 RID: 40932
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerPropBuffItem, RoleTowerPropBuffData> BuffScroll;

	// Token: 0x02007FFB RID: 32763
	private static class EChildType
	{
		// Token: 0x04029674 RID: 169588
		public const int TxtTitle = 0;

		// Token: 0x04029675 RID: 169589
		public const int PnlStar = 1;

		// Token: 0x04029676 RID: 169590
		public const int UiItemStarPrefab = 2;

		// Token: 0x04029677 RID: 169591
		public const int LevelBuffScroll = 3;

		// Token: 0x04029678 RID: 169592
		public const int PnlDescItem = 4;
	}
}
