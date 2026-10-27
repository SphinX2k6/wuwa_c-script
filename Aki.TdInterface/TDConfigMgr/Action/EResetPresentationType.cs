using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200168B RID: 5771
	[JsonConverter(typeof(EResetPresentationTypeJsonConverter))]
	[EnumExtensions]
	public enum EResetPresentationType
	{
		// Token: 0x04004D58 RID: 19800
		Failure
	}
}
