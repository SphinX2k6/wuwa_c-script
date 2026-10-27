using System;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015E0 RID: 5600
	[JsonConverter(typeof(EFadeBackgroundFadeOutEffectTypeJsonConverter))]
	[EnumExtensions]
	public enum EFadeBackgroundFadeOutEffectType
	{
		// Token: 0x04004ABB RID: 19131
		Black,
		// Token: 0x04004ABC RID: 19132
		ScreenEffect
	}
}
