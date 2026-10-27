using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015E1 RID: 5601
	[JsonConverter(typeof(EFadeBackgroundTypeJsonConverter))]
	[EnumExtensions]
	public enum EFadeBackgroundType
	{
		// Token: 0x04004ABE RID: 19134
		Spine,
		// Token: 0x04004ABF RID: 19135
		BackgroundImage,
		// Token: 0x04004AC0 RID: 19136
		UiPrefab
	}
}
