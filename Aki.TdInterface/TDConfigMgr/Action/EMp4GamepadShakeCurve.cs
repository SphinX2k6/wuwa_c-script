using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200179B RID: 6043
	[EnumExtensions]
	public enum EMp4GamepadShakeCurve
	{
		// Token: 0x0400502B RID: 20523
		Linear,
		// Token: 0x0400502C RID: 20524
		[EnumStringMember("Insine")]
		InSine,
		// Token: 0x0400502D RID: 20525
		[EnumStringMember("Outsine")]
		OutSine
	}
}
