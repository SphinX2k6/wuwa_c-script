using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001800 RID: 6144
	[JsonConverter(typeof(EResetPresentationTypeJsonConverter))]
	[EnumExtensions]
	public enum EResetPresentationType
	{
		// Token: 0x04005163 RID: 20835
		Failure
	}
}
