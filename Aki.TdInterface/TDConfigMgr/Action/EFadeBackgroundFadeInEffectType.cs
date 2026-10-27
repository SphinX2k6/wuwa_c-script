using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015DF RID: 5599
	[JsonConverter(typeof(EFadeBackgroundFadeInEffectTypeJsonConverter))]
	[EnumExtensions]
	public enum EFadeBackgroundFadeInEffectType
	{
		// Token: 0x04004AB8 RID: 19128
		Black,
		// Token: 0x04004AB9 RID: 19129
		ScreenEffect
	}
}
