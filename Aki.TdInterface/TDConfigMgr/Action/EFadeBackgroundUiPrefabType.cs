using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015E2 RID: 5602
	[JsonConverter(typeof(EFadeBackgroundUiPrefabTypeJsonConverter))]
	[EnumExtensions]
	public enum EFadeBackgroundUiPrefabType
	{
		// Token: 0x04004AC2 RID: 19138
		BlackScreenWhiteText
	}
}
