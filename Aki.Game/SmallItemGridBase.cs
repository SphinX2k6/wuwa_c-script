using System;
using System.Runtime.CompilerServices;

// Token: 0x0200199F RID: 6559
[NullableContext(2)]
[Nullable(0)]
public abstract class SmallItemGridBase : IMediumItemGridBase
{
	// Token: 0x17001004 RID: 4100
	// (get) Token: 0x0600BF7E RID: 49022
	public abstract ESmallItemGridType Type { get; }

	// Token: 0x040055E5 RID: 21989
	public object Data;

	// Token: 0x040055E6 RID: 21990
	public int? SkinId;

	// Token: 0x040055E7 RID: 21991
	public bool? IsIconHide;

	// Token: 0x040055E8 RID: 21992
	public int? ItemConfigId;

	// Token: 0x040055E9 RID: 21993
	public string BottomTextId;

	// Token: 0x040055EA RID: 21994
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public object[] BottomTextParameter;

	// Token: 0x040055EB RID: 21995
	public string BottomText;

	// Token: 0x040055EC RID: 21996
	public string IconPath;

	// Token: 0x040055ED RID: 21997
	public bool? IsQualityHidden;

	// Token: 0x040055EE RID: 21998
	public string QualityIconResourceId;

	// Token: 0x040055EF RID: 21999
	public string QualityIcon;

	// Token: 0x040055F0 RID: 22000
	public int? QualityId;

	// Token: 0x040055F1 RID: 22001
	public CommonDefine.EQualityIconType? QualityType;

	// Token: 0x040055F2 RID: 22002
	public bool? IsDisable;

	// Token: 0x040055F3 RID: 22003
	public string TopRightTextId;

	// Token: 0x040055F4 RID: 22004
	public object[] TopRightTextParameter;

	// Token: 0x040055F5 RID: 22005
	public string TopRightText;

	// Token: 0x040055F6 RID: 22006
	public string TopRightTextBgColor;

	// Token: 0x040055F7 RID: 22007
	public string TopRightTextColor;

	// Token: 0x040055F8 RID: 22008
	public string RightTopValue;

	// Token: 0x040055F9 RID: 22009
	public bool? IsRedDotVisible;

	// Token: 0x040055FA RID: 22010
	public bool? IsDoubleRewardVisible;

	// Token: 0x040055FB RID: 22011
	public string SpriteIconPath;
}
