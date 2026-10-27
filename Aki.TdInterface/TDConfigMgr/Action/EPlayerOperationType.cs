using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001676 RID: 5750
	[JsonConverter(typeof(EPlayerOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum EPlayerOperationType
	{
		// Token: 0x04004D0B RID: 19723
		EnableAll,
		// Token: 0x04004D0C RID: 19724
		DisableAll,
		// Token: 0x04004D0D RID: 19725
		DisableModule
	}
}
