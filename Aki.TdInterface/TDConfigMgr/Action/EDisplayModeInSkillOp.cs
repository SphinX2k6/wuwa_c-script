using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001725 RID: 5925
	[JsonConverter(typeof(EDisplayModeInSkillOpJsonConverter))]
	[EnumExtensions]
	public enum EDisplayModeInSkillOp
	{
		// Token: 0x04004E03 RID: 19971
		Ashen,
		// Token: 0x04004E04 RID: 19972
		Hide,
		// Token: 0x04004E05 RID: 19973
		Disable,
		// Token: 0x04004E06 RID: 19974
		Show
	}
}
