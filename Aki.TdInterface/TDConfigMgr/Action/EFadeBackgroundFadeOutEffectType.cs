using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001740 RID: 5952
	[JsonConverter(typeof(EFadeBackgroundFadeOutEffectTypeJsonConverter))]
	[EnumExtensions]
	public enum EFadeBackgroundFadeOutEffectType
	{
		// Token: 0x04004E7B RID: 20091
		Black,
		// Token: 0x04004E7C RID: 20092
		ScreenEffect
	}
}
