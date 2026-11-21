using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001848 RID: 6216
	[JsonConverter(typeof(ETeamDisplayModeInSkillOpJsonConverter))]
	[EnumExtensions]
	public enum ETeamDisplayModeInSkillOp
	{
		// Token: 0x04005310 RID: 21264
		Normal,
		// Token: 0x04005311 RID: 21265
		Lock
	}
}
