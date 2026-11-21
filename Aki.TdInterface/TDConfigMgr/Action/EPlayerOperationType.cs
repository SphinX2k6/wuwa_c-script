using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017E9 RID: 6121
	[JsonConverter(typeof(EPlayerOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum EPlayerOperationType
	{
		// Token: 0x04005110 RID: 20752
		EnableAll,
		// Token: 0x04005111 RID: 20753
		DisableAll,
		// Token: 0x04005112 RID: 20754
		DisableModule
	}
}
