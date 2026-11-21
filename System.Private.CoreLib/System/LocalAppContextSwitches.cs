using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000162 RID: 354
	internal static class LocalAppContextSwitches
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00046548 File Offset: 0x00044748
		public static bool EnableUnsafeUTF7Encoding
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return LocalAppContextSwitches.GetCachedSwitchValue("System.Text.Encoding.EnableUnsafeUTF7Encoding", ref LocalAppContextSwitches.s_enableUnsafeUTF7Encoding);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x00046559 File Offset: 0x00044759
		public static bool EnforceJapaneseEraYearRanges
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return LocalAppContextSwitches.GetCachedSwitchValue("Switch.System.Globalization.EnforceJapaneseEraYearRanges", ref LocalAppContextSwitches.s_enforceJapaneseEraYearRanges);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x0004656A File Offset: 0x0004476A
		public static bool FormatJapaneseFirstYearAsANumber
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return LocalAppContextSwitches.GetCachedSwitchValue("Switch.System.Globalization.FormatJapaneseFirstYearAsANumber", ref LocalAppContextSwitches.s_formatJapaneseFirstYearAsANumber);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x0004657B File Offset: 0x0004477B
		public static bool EnforceLegacyJapaneseDateParsing
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return LocalAppContextSwitches.GetCachedSwitchValue("Switch.System.Globalization.EnforceLegacyJapaneseDateParsing", ref LocalAppContextSwitches.s_enforceLegacyJapaneseDateParsing);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x0004658C File Offset: 0x0004478C
		public static bool PreserveEventListenerObjectIdentity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return LocalAppContextSwitches.GetCachedSwitchValue("Switch.System.Diagnostics.EventSource.PreserveEventListenerObjectIdentity", ref LocalAppContextSwitches.s_preserveEventListenerObjectIdentity);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x0004659D File Offset: 0x0004479D
		public static bool ForceEmitInvoke
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return LocalAppContextSwitches.GetCachedSwitchValue("Switch.System.Reflection.ForceEmitInvoke", ref LocalAppContextSwitches.s_forceEmitInvoke);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x000465AE File Offset: 0x000447AE
		public static bool ForceInterpretedInvoke
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return LocalAppContextSwitches.GetCachedSwitchValue("Switch.System.Reflection.ForceInterpretedInvoke", ref LocalAppContextSwitches.s_forceInterpretedInvoke);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x000465BF File Offset: 0x000447BF
		public static bool SerializationGuard
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return LocalAppContextSwitches.GetCachedSwitchValue("Switch.System.Runtime.Serialization.SerializationGuard", ref LocalAppContextSwitches.s_serializationGuard);
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x000465D0 File Offset: 0x000447D0
		private static bool GetDefaultShowILOffsetSetting()
		{
			if (LocalAppContextSwitches.s_showILOffset < 0)
			{
				return false;
			}
			if (LocalAppContextSwitches.s_showILOffset > 0)
			{
				return true;
			}
			bool booleanConfig = AppContextConfigHelper.GetBooleanConfig("Switch.System.Diagnostics.StackTrace.ShowILOffsets", true);
			LocalAppContextSwitches.s_showILOffset = (booleanConfig ? 1 : -1);
			return booleanConfig;
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x000465FD File Offset: 0x000447FD
		public static bool ShowILOffsets
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return LocalAppContextSwitches.GetDefaultShowILOffsetSetting();
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00046604 File Offset: 0x00044804
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool GetCachedSwitchValue(string switchName, ref int cachedSwitchValue)
		{
			return cachedSwitchValue >= 0 && (cachedSwitchValue > 0 || LocalAppContextSwitches.GetCachedSwitchValueInternal(switchName, ref cachedSwitchValue));
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0004661C File Offset: 0x0004481C
		private static bool GetCachedSwitchValueInternal(string switchName, ref int cachedSwitchValue)
		{
			bool switchDefaultValue;
			if (!AppContext.TryGetSwitch(switchName, out switchDefaultValue))
			{
				switchDefaultValue = LocalAppContextSwitches.GetSwitchDefaultValue(switchName);
			}
			bool flag;
			AppContext.TryGetSwitch("TestSwitch.LocalAppContext.DisableCaching", out flag);
			if (!flag)
			{
				cachedSwitchValue = (switchDefaultValue ? 1 : -1);
			}
			return switchDefaultValue;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00046654 File Offset: 0x00044854
		private static bool GetSwitchDefaultValue(string switchName)
		{
			return switchName == "Switch.System.Runtime.Serialization.SerializationGuard" || switchName == "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization" || switchName == "System.Xml.XmlResolver.IsNetworkingEnabledByDefault";
		}

		// Token: 0x040004E8 RID: 1256
		private static int s_enableUnsafeUTF7Encoding;

		// Token: 0x040004E9 RID: 1257
		private static int s_enforceJapaneseEraYearRanges;

		// Token: 0x040004EA RID: 1258
		private static int s_formatJapaneseFirstYearAsANumber;

		// Token: 0x040004EB RID: 1259
		private static int s_enforceLegacyJapaneseDateParsing;

		// Token: 0x040004EC RID: 1260
		private static int s_preserveEventListenerObjectIdentity;

		// Token: 0x040004ED RID: 1261
		private static int s_forceEmitInvoke;

		// Token: 0x040004EE RID: 1262
		private static int s_forceInterpretedInvoke;

		// Token: 0x040004EF RID: 1263
		private static int s_serializationGuard;

		// Token: 0x040004F0 RID: 1264
		private static int s_showILOffset;
	}
}
