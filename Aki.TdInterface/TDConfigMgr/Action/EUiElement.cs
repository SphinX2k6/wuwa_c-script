using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016EB RID: 5867
	[JsonConverter(typeof(EUiElementJsonConverter))]
	[EnumExtensions]
	public enum EUiElement
	{
		// Token: 0x04004F64 RID: 20324
		Guide
	}
}
