using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017E5 RID: 6117
	[JsonConverter(typeof(EPlayerAiControlTypeJsonConverter))]
	[EnumExtensions]
	public enum EPlayerAiControlType
	{
		// Token: 0x040050FD RID: 20733
		Enable,
		// Token: 0x040050FE RID: 20734
		Disable
	}
}
