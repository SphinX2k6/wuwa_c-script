using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017FF RID: 6143
	[JsonConverter(typeof(EResetPosTypeJsonConverter))]
	[EnumExtensions]
	public enum EResetPosType
	{
		// Token: 0x04005160 RID: 20832
		PosEntity,
		// Token: 0x04005161 RID: 20833
		ResetPoint
	}
}
