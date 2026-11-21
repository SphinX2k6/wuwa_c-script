using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016E0 RID: 5856
	[EnumExtensions]
	public enum EAdjustPlayerCamera
	{
		// Token: 0x04004CDC RID: 19676
		[EnumStringMember("关卡.Common.镜头调整")]
		Basic,
		// Token: 0x04004CDD RID: 19677
		[EnumStringMember("关卡.Common.镜头.横版镜头")]
		Horizontal,
		// Token: 0x04004CDE RID: 19678
		[EnumStringMember("关卡.Common.镜头.对话镜头")]
		Dialog,
		// Token: 0x04004CDF RID: 19679
		[EnumStringMember("关卡.Common.镜头.固定镜头")]
		Fixed,
		// Token: 0x04004CE0 RID: 19680
		[EnumStringMember("关卡.Common.镜头.锁轴镜头")]
		AxisLock,
		// Token: 0x04004CE1 RID: 19681
		[EnumStringMember("关卡.Common.镜头.第一人称镜头")]
		FirstPerson,
		// Token: 0x04004CE2 RID: 19682
		[EnumStringMember("关卡.Common.镜头.固定镜头看向目标")]
		FixedLookAt,
		// Token: 0x04004CE3 RID: 19683
		[EnumStringMember("关卡.Common.镜头.固定位置监控镜头")]
		FixedSurveillance,
		// Token: 0x04004CE4 RID: 19684
		[EnumStringMember("关卡.Common.镜头.区域焦点镜头")]
		ZoneFollow
	}
}
