using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E5C RID: 3676
[NullableContext(2)]
[Nullable(0)]
public abstract class SmallItemGridBase : IMediumItemGridBase
{
	// Token: 0x17001028 RID: 4136
	// (get) Token: 0x06009386 RID: 37766
	public abstract ESmallItemGridType Type { get; }

	// Token: 0x04005693 RID: 22163
	public object Data;

	// Token: 0x04005694 RID: 22164
	public int? SkinId;

	// Token: 0x04005695 RID: 22165
	public bool? IsIconHide;

	// Token: 0x04005696 RID: 22166
	public int? ItemConfigId;

	// Token: 0x04005697 RID: 22167
	public string BottomTextId;

	// Token: 0x04005698 RID: 22168
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public object[] BottomTextParameter;

	// Token: 0x04005699 RID: 22169
	public string BottomText;

	// Token: 0x0400569A RID: 22170
	public string IconPath;

	// Token: 0x0400569B RID: 22171
	public bool? IsQualityHidden;

	// Token: 0x0400569C RID: 22172
	public string QualityIconResourceId;

	// Token: 0x0400569D RID: 22173
	public string QualityIcon;

	// Token: 0x0400569E RID: 22174
	public int? QualityId;

	// Token: 0x0400569F RID: 22175
	public CommonDefine.EQualityIconType? QualityType;

	// Token: 0x040056A0 RID: 22176
	public bool? IsDisable;

	// Token: 0x040056A1 RID: 22177
	public string TopRightTextId;

	// Token: 0x040056A2 RID: 22178
	public object[] TopRightTextParameter;

	// Token: 0x040056A3 RID: 22179
	public string TopRightText;

	// Token: 0x040056A4 RID: 22180
	public string TopRightTextBgColor;

	// Token: 0x040056A5 RID: 22181
	public string TopRightTextColor;

	// Token: 0x040056A6 RID: 22182
	public string RightTopValue;

	// Token: 0x040056A7 RID: 22183
	public bool? IsRedDotVisible;

	// Token: 0x040056A8 RID: 22184
	public bool? IsDoubleRewardVisible;

	// Token: 0x040056A9 RID: 22185
	public string SpriteIconPath;
}
