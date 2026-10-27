using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016EC RID: 5868
	[JsonConverter(typeof(EUiOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum EUiOperationType
	{
		// Token: 0x04004F66 RID: 20326
		Enable,
		// Token: 0x04004F67 RID: 20327
		EnableSectionalUi,
		// Token: 0x04004F68 RID: 20328
		Disable
	}
}
