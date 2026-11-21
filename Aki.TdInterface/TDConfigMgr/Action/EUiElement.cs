using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001867 RID: 6247
	[JsonConverter(typeof(EUiElementJsonConverter))]
	[EnumExtensions]
	public enum EUiElement
	{
		// Token: 0x04005391 RID: 21393
		Guide
	}
}
