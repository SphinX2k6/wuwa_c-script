using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001691 RID: 5777
	[JsonConverter(typeof(ESceneInteractionOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum ESceneInteractionOperationType
	{
		// Token: 0x04004D6A RID: 19818
		Enable,
		// Token: 0x04004D6B RID: 19819
		Disable
	}
}
