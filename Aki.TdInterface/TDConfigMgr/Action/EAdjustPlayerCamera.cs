using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001582 RID: 5506
	[EnumExtensions]
	public enum EAdjustPlayerCamera
	{
		// Token: 0x0400492D RID: 18733
		[EnumStringMember("关卡.Common.镜头调整")]
		Basic,
		// Token: 0x0400492E RID: 18734
		[EnumStringMember("关卡.Common.镜头.横版镜头")]
		Horizontal,
		// Token: 0x0400492F RID: 18735
		[EnumStringMember("关卡.Common.镜头.对话镜头")]
		Dialog,
		// Token: 0x04004930 RID: 18736
		[EnumStringMember("关卡.Common.镜头.固定镜头")]
		Fixed,
		// Token: 0x04004931 RID: 18737
		[EnumStringMember("关卡.Common.镜头.锁轴镜头")]
		AxisLock,
		// Token: 0x04004932 RID: 18738
		[EnumStringMember("关卡.Common.镜头.第一人称镜头")]
		FirstPerson,
		// Token: 0x04004933 RID: 18739
		[EnumStringMember("关卡.Common.镜头.固定镜头看向目标")]
		FixedLookAt,
		// Token: 0x04004934 RID: 18740
		[EnumStringMember("关卡.Common.镜头.固定位置监控镜头")]
		FixedSurveillance,
		// Token: 0x04004935 RID: 18741
		[EnumStringMember("关卡.Common.镜头.区域焦点镜头")]
		ZoneFollow
	}
}
