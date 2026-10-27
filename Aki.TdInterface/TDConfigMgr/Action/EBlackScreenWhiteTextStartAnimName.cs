using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001597 RID: 5527
	[JsonConverter(typeof(EBlackScreenWhiteTextStartAnimNameJsonConverter))]
	[EnumExtensions]
	public enum EBlackScreenWhiteTextStartAnimName
	{
		// Token: 0x0400498D RID: 18829
		Start01,
		// Token: 0x0400498E RID: 18830
		Start02,
		// Token: 0x0400498F RID: 18831
		Start03
	}
}
