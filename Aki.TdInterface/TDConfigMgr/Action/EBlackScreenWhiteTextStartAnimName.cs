using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016F6 RID: 5878
	[JsonConverter(typeof(EBlackScreenWhiteTextStartAnimNameJsonConverter))]
	[EnumExtensions]
	public enum EBlackScreenWhiteTextStartAnimName
	{
		// Token: 0x04004D3F RID: 19775
		Start01,
		// Token: 0x04004D40 RID: 19776
		Start02,
		// Token: 0x04004D41 RID: 19777
		Start03
	}
}
