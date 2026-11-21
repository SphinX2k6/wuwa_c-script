using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001868 RID: 6248
	[JsonConverter(typeof(EUiOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum EUiOperationType
	{
		// Token: 0x04005393 RID: 21395
		Enable,
		// Token: 0x04005394 RID: 21396
		EnableSectionalUi,
		// Token: 0x04005395 RID: 21397
		Disable
	}
}
