using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015A0 RID: 5536
	[JsonConverter(typeof(ECameraOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum ECameraOperationType
	{
		// Token: 0x040049B5 RID: 18869
		Enable,
		// Token: 0x040049B6 RID: 18870
		EnableSection,
		// Token: 0x040049B7 RID: 18871
		Disable
	}
}
