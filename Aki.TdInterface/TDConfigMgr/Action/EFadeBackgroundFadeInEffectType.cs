using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200173F RID: 5951
	[JsonConverter(typeof(EFadeBackgroundFadeInEffectTypeJsonConverter))]
	[EnumExtensions]
	public enum EFadeBackgroundFadeInEffectType
	{
		// Token: 0x04004E78 RID: 20088
		Black,
		// Token: 0x04004E79 RID: 20089
		ScreenEffect
	}
}
