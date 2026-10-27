using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016CE RID: 5838
	[JsonConverter(typeof(ETeamDisplayModeInSkillOpJsonConverter))]
	[EnumExtensions]
	public enum ETeamDisplayModeInSkillOp
	{
		// Token: 0x04004EEA RID: 20202
		Normal,
		// Token: 0x04004EEB RID: 20203
		Lock
	}
}
