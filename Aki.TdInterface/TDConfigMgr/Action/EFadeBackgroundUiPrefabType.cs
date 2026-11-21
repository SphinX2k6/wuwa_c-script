using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001742 RID: 5954
	[JsonConverter(typeof(EFadeBackgroundUiPrefabTypeJsonConverter))]
	[EnumExtensions]
	public enum EFadeBackgroundUiPrefabType
	{
		// Token: 0x04004E82 RID: 20098
		BlackScreenWhiteText
	}
}
