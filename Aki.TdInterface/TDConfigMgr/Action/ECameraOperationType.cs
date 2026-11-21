using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016FF RID: 5887
	[JsonConverter(typeof(ECameraOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum ECameraOperationType
	{
		// Token: 0x04004D67 RID: 19815
		Enable,
		// Token: 0x04004D68 RID: 19816
		EnableSection,
		// Token: 0x04004D69 RID: 19817
		Disable
	}
}
