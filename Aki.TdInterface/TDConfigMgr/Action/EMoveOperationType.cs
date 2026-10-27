using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001627 RID: 5671
	[JsonConverter(typeof(EMoveOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum EMoveOperationType
	{
		// Token: 0x04004C1E RID: 19486
		Enable,
		// Token: 0x04004C1F RID: 19487
		Disable
	}
}
