using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001806 RID: 6150
	[JsonConverter(typeof(ESceneInteractionOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum ESceneInteractionOperationType
	{
		// Token: 0x04005175 RID: 20853
		Enable,
		// Token: 0x04005176 RID: 20854
		Disable
	}
}
