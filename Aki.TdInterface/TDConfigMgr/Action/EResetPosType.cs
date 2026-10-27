using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200168A RID: 5770
	[JsonConverter(typeof(EResetPosTypeJsonConverter))]
	[EnumExtensions]
	public enum EResetPosType
	{
		// Token: 0x04004D55 RID: 19797
		PosEntity,
		// Token: 0x04004D56 RID: 19798
		ResetPoint
	}
}
