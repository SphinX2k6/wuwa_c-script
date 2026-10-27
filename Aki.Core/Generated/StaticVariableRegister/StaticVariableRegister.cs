using System;
using CSharpScript.Core.Common;
using CSharpScript.Core.Config;
using CSharpScript.Core.Container;
using CSharpScript.Core.Define.TdConfigExtensions;
using CSharpScript.Core.Utils;
using UnrealEngine;

namespace Generated.StaticVariableRegister
{
	// Token: 0x02000112 RID: 274
	public static class StaticVariableRegister
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x00033750 File Offset: 0x00031950
		public static bool CreateAllStaticDefaultValue()
		{
			FNameUtil.CreateStaticDefaultValue();
			EventConstant.CreateStaticDefaultValue();
			Entry.CreateStaticDefaultValue();
			GameplayTagUtils.CreateStaticDefaultValue();
			TimerSystem.CreateStaticDefaultValue();
			TimerHandle.CreateStaticDefaultValue();
			TickProcess.CreateStaticDefaultValue();
			GameplayTagCache.CreateStaticDefaultValue();
			StatSecondsAccumulator.CreateStaticDefaultValue();
			NumberEvent.CreateStaticDefaultValue();
			RomanNumeralUtils.CreateStaticDefaultValue();
			EntityComponentConstant.CreateStaticDefaultValue();
			ClassDefine.CreateStaticDefaultValue();
			ProxyLruConstants.CreateStaticDefaultValue();
			LruConstants.CreateStaticDefaultValue();
			GraphDefine.CreateStaticDefaultValue();
			ConnectDbObject.CreateStaticDefaultValue();
			ConfigReloadHub.CreateStaticDefaultValue();
			ConfigCommon.CreateStaticDefaultValue();
			CommonDbConnectManager.CreateStaticDefaultValue();
			JsonSettings.CreateStaticDefaultValue();
			Stcp.CreateStaticDefaultValue();
			UiTextTranslationUtils.CreateStaticDefaultValue();
			return true;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000337D4 File Offset: 0x000319D4
		public static bool ResetAllStaticDefaultValue()
		{
			UiTextTranslationUtils.ResetStaticDefaultValue();
			Stcp.ResetStaticDefaultValue();
			JsonSettings.ResetStaticDefaultValue();
			CommonDbConnectManager.ResetStaticDefaultValue();
			ConfigCommon.ResetStaticDefaultValue();
			ConfigReloadHub.ResetStaticDefaultValue();
			ConnectDbObject.ResetStaticDefaultValue();
			GraphDefine.ResetStaticDefaultValue();
			LruConstants.ResetStaticDefaultValue();
			ProxyLruConstants.ResetStaticDefaultValue();
			ClassDefine.ResetStaticDefaultValue();
			EntityComponentConstant.ResetStaticDefaultValue();
			RomanNumeralUtils.ResetStaticDefaultValue();
			NumberEvent.ResetStaticDefaultValue();
			StatSecondsAccumulator.ResetStaticDefaultValue();
			GameplayTagCache.ResetStaticDefaultValue();
			TickProcess.ResetStaticDefaultValue();
			TimerHandle.ResetStaticDefaultValue();
			TimerSystem.ResetStaticDefaultValue();
			GameplayTagUtils.ResetStaticDefaultValue();
			Entry.ResetStaticDefaultValue();
			EventConstant.ResetStaticDefaultValue();
			FNameUtil.ResetStaticDefaultValue();
			return true;
		}
	}
}
