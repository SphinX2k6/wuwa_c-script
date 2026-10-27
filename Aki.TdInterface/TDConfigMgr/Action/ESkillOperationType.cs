using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016A6 RID: 5798
	[JsonConverter(typeof(ESkillOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum ESkillOperationType
	{
		// Token: 0x04004DD2 RID: 19922
		Enable,
		// Token: 0x04004DD3 RID: 19923
		Disable,
		// Token: 0x04004DD4 RID: 19924
		DisableSection
	}
}
