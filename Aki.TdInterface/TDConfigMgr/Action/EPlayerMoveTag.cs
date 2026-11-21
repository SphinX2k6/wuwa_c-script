using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017E8 RID: 6120
	[EnumExtensions]
	public enum EPlayerMoveTag
	{
		// Token: 0x0400510B RID: 20747
		[EnumStringMember("载具.摩托.移动.高速行驶")]
		VehicleMotorHighSpeed,
		// Token: 0x0400510C RID: 20748
		[EnumStringMember("载具.摩托.移动.低速行驶")]
		VehicleMotorLowSpeed,
		// Token: 0x0400510D RID: 20749
		[EnumStringMember("载具.摩托.移动.环视.低速行驶")]
		VehicleMotorPanoramaLowSpeed,
		// Token: 0x0400510E RID: 20750
		[EnumStringMember("载具.摩托.移动.环视.低速行驶2")]
		VehicleMotorPanoramaLowSpeed2
	}
}
