using System;

namespace System.Text.Json
{
	// Token: 0x0200001C RID: 28
	internal static class AppContextSwitchHelper
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000668A File Offset: 0x0000488A
		public static bool IsSourceGenReflectionFallbackEnabled { get; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00006691 File Offset: 0x00004891
		public static bool RespectNullableAnnotationsDefault { get; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00006698 File Offset: 0x00004898
		public static bool RespectRequiredConstructorParametersDefault { get; }

		// Token: 0x06000210 RID: 528 RVA: 0x000066A0 File Offset: 0x000048A0
		// Note: this type is marked as 'beforefieldinit'.
		static AppContextSwitchHelper()
		{
			bool flag;
			AppContextSwitchHelper.IsSourceGenReflectionFallbackEnabled = (AppContext.TryGetSwitch("System.Text.Json.Serialization.EnableSourceGenReflectionFallback", out flag) && flag);
			bool flag2;
			AppContextSwitchHelper.RespectNullableAnnotationsDefault = (AppContext.TryGetSwitch("System.Text.Json.Serialization.RespectNullableAnnotationsDefault", out flag2) && flag2);
			bool flag3;
			AppContextSwitchHelper.RespectRequiredConstructorParametersDefault = (AppContext.TryGetSwitch("System.Text.Json.Serialization.RespectRequiredConstructorParametersDefault", out flag3) && flag3);
		}
	}
}
