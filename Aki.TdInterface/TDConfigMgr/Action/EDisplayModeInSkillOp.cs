using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015C6 RID: 5574
	[JsonConverter(typeof(EDisplayModeInSkillOpJsonConverter))]
	[EnumExtensions]
	public enum EDisplayModeInSkillOp
	{
		// Token: 0x04004A49 RID: 19017
		Ashen,
		// Token: 0x04004A4A RID: 19018
		Hide,
		// Token: 0x04004A4B RID: 19019
		Disable,
		// Token: 0x04004A4C RID: 19020
		Show
	}
}
