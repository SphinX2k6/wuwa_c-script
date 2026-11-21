using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001741 RID: 5953
	[JsonConverter(typeof(EFadeBackgroundTypeJsonConverter))]
	[EnumExtensions]
	public enum EFadeBackgroundType
	{
		// Token: 0x04004E7E RID: 20094
		Spine,
		// Token: 0x04004E7F RID: 20095
		BackgroundImage,
		// Token: 0x04004E80 RID: 20096
		UiPrefab
	}
}
