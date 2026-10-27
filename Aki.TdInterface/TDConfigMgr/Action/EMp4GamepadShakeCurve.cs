using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200162E RID: 5678
	[EnumExtensions]
	public enum EMp4GamepadShakeCurve
	{
		// Token: 0x04004C37 RID: 19511
		Linear,
		// Token: 0x04004C38 RID: 19512
		[EnumStringMember("Insine")]
		InSine,
		// Token: 0x04004C39 RID: 19513
		[EnumStringMember("Outsine")]
		OutSine
	}
}
