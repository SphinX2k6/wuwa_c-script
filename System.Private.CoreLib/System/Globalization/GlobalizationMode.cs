using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	// Token: 0x020002EA RID: 746
	internal static class GlobalizationMode
	{
		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x000B36ED File Offset: 0x000B18ED
		internal static bool Invariant
		{
			get
			{
				return GlobalizationMode.Settings.Invariant;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060036CB RID: 14027 RVA: 0x000B36ED File Offset: 0x000B18ED
		internal static bool InvariantNoLoad
		{
			get
			{
				return GlobalizationMode.Settings.Invariant;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x000B36F4 File Offset: 0x000B18F4
		internal static bool PredefinedCulturesOnly
		{
			get
			{
				return GlobalizationMode.Settings.PredefinedCulturesOnly;
			}
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x000B36FB File Offset: 0x000B18FB
		private static bool TryGetAppLocalIcuSwitchValue([NotNullWhen(true)] out string value)
		{
			return GlobalizationMode.TryGetStringValue("System.Globalization.AppLocalIcu", "DOTNET_SYSTEM_GLOBALIZATION_APPLOCALICU", out value);
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x000B370D File Offset: 0x000B190D
		private static bool TryGetStringValue(string switchName, string envVariable, [NotNullWhen(true)] out string value)
		{
			value = (AppContext.GetData(switchName) as string);
			if (string.IsNullOrEmpty(value))
			{
				value = Environment.GetEnvironmentVariable(envVariable);
				if (string.IsNullOrEmpty(value))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x000B373C File Offset: 0x000B193C
		private static void LoadAppLocalIcu(string icuSuffixAndVersion)
		{
			ReadOnlySpan<char> suffix = default(ReadOnlySpan<char>);
			int num = icuSuffixAndVersion.IndexOf(':');
			ReadOnlySpan<char> version;
			if (num >= 0)
			{
				suffix = icuSuffixAndVersion.AsSpan(0, num);
				version = icuSuffixAndVersion.AsSpan(suffix.Length + 1);
			}
			else
			{
				version = icuSuffixAndVersion;
			}
			GlobalizationMode.LoadAppLocalIcuCore(version, suffix);
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x000B3787 File Offset: 0x000B1987
		private static string CreateLibraryName(ReadOnlySpan<char> baseName, ReadOnlySpan<char> suffix, ReadOnlySpan<char> extension, ReadOnlySpan<char> version, bool versionAtEnd = false)
		{
			if (!versionAtEnd)
			{
				return baseName + suffix + version + extension;
			}
			return baseName + suffix + extension + version;
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x000B37A0 File Offset: 0x000B19A0
		private static IntPtr LoadLibrary(string library, bool failOnLoadFailure)
		{
			IntPtr result;
			if (!NativeLibrary.TryLoad(library, typeof(object).Assembly, new DllImportSearchPath?(DllImportSearchPath.ApplicationDirectory | DllImportSearchPath.System32), out result) && failOnLoadFailure)
			{
				Environment.FailFast("Failed to load app-local ICU: " + library);
			}
			return result;
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x000B37E6 File Offset: 0x000B19E6
		internal static bool UseNls { get; } = !GlobalizationMode.Invariant && (AppContextConfigHelper.GetBooleanConfig("System.Globalization.UseNls", "DOTNET_SYSTEM_GLOBALIZATION_USENLS", false) || !GlobalizationMode.LoadIcu());

		// Token: 0x060036D3 RID: 14035 RVA: 0x000B37F0 File Offset: 0x000B19F0
		private static bool LoadIcu()
		{
			string icuSuffixAndVersion;
			if (!GlobalizationMode.TryGetAppLocalIcuSwitchValue(out icuSuffixAndVersion))
			{
				return Interop.Globalization.LoadICU() != 0;
			}
			GlobalizationMode.LoadAppLocalIcu(icuSuffixAndVersion);
			return true;
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x000B3818 File Offset: 0x000B1A18
		private static void LoadAppLocalIcuCore(ReadOnlySpan<char> version, ReadOnlySpan<char> suffix)
		{
			IntPtr intPtr = IntPtr.Zero;
			IntPtr intPtr2 = IntPtr.Zero;
			int num = version.IndexOf('.');
			if (num > 0)
			{
				ReadOnlySpan<char> version2 = version.Slice(0, num);
				intPtr = GlobalizationMode.LoadLibrary(GlobalizationMode.CreateLibraryName("icuuc", suffix, ".dll", version2, false), false);
				if (intPtr != IntPtr.Zero)
				{
					intPtr2 = GlobalizationMode.LoadLibrary(GlobalizationMode.CreateLibraryName("icuin", suffix, ".dll", version2, false), false);
				}
			}
			if (intPtr == IntPtr.Zero)
			{
				intPtr = GlobalizationMode.LoadLibrary(GlobalizationMode.CreateLibraryName("icuuc", suffix, ".dll", version, false), true);
			}
			if (intPtr2 == IntPtr.Zero)
			{
				intPtr2 = GlobalizationMode.LoadLibrary(GlobalizationMode.CreateLibraryName("icuin", suffix, ".dll", version, false), true);
			}
			Interop.Globalization.InitICUFunctions(intPtr, intPtr2, version, suffix);
		}

		// Token: 0x020002EB RID: 747
		private static class Settings
		{
			// Token: 0x17000A44 RID: 2628
			// (get) Token: 0x060036D6 RID: 14038 RVA: 0x000B3923 File Offset: 0x000B1B23
			internal static bool Invariant { get; } = AppContextConfigHelper.GetBooleanConfig("System.Globalization.Invariant", "DOTNET_SYSTEM_GLOBALIZATION_INVARIANT", false);

			// Token: 0x17000A45 RID: 2629
			// (get) Token: 0x060036D7 RID: 14039 RVA: 0x000B392A File Offset: 0x000B1B2A
			internal static bool PredefinedCulturesOnly { get; } = AppContextConfigHelper.GetBooleanConfig("System.Globalization.PredefinedCulturesOnly", "DOTNET_SYSTEM_GLOBALIZATION_PREDEFINED_CULTURES_ONLY", GlobalizationMode.Invariant);
		}
	}
}
