using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200181F RID: 6175
	[JsonConverter(typeof(ESkillOperationTypeJsonConverter))]
	[EnumExtensions]
	public enum ESkillOperationType
	{
		// Token: 0x040051EC RID: 20972
		Enable,
		// Token: 0x040051ED RID: 20973
		Disable,
		// Token: 0x040051EE RID: 20974
		DisableSection
	}
}
