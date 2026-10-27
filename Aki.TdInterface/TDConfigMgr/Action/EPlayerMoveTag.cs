using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001675 RID: 5749
	[EnumExtensions]
	public enum EPlayerMoveTag
	{
		// Token: 0x04004D06 RID: 19718
		[EnumStringMember("载具.摩托.移动.高速行驶")]
		VehicleMotorHighSpeed,
		// Token: 0x04004D07 RID: 19719
		[EnumStringMember("载具.摩托.移动.低速行驶")]
		VehicleMotorLowSpeed,
		// Token: 0x04004D08 RID: 19720
		[EnumStringMember("载具.摩托.移动.环视.低速行驶")]
		VehicleMotorPanoramaLowSpeed,
		// Token: 0x04004D09 RID: 19721
		[EnumStringMember("载具.摩托.移动.环视.低速行驶2")]
		VehicleMotorPanoramaLowSpeed2
	}
}
