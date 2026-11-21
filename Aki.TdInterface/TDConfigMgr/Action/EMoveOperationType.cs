using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001794 RID: 6036
	[JsonConverter(typeof(EMoveOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum EMoveOperationType
	{
		// Token: 0x04005012 RID: 20498
		Enable,
		// Token: 0x04005013 RID: 20499
		Disable
	}
}
