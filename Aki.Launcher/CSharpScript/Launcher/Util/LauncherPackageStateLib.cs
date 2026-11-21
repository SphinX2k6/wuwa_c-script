using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using UnrealEngine;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000071 RID: 113
	[NullableContext(1)]
	[Nullable(0)]
	public static class LauncherPackageStateLib
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x0000FCB8 File Offset: 0x0000DEB8
		public static EResUpdateType GetCommandLinePackageType()
		{
			Match match = Regex.Match(UKismetSystemLibrary.GetCommandLine(), "(?:^|\\s)-krpkg=(\\S+)", RegexOptions.IgnoreCase);
			if (!match.Success)
			{
				return EResUpdateType.NotSet;
			}
			string text = match.Groups[1].Value.Trim(new char[]
			{
				'"',
				'\''
			});
			string a = text.ToLowerInvariant();
			if (a == "max")
			{
				return EResUpdateType.Max;
			}
			if (!(a == "min"))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "GetCommandLinePackageType-无法识别的包体类型参数";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("krpkg", text);
				instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return EResUpdateType.NotSet;
			}
			return EResUpdateType.Min;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000FD54 File Offset: 0x0000DF54
		public static EResUpdateType GetPcPackageType(ETier tier)
		{
			EResUpdateType eresUpdateType = LauncherPackageStateLib.ReadPackageType(tier);
			if (eresUpdateType != EResUpdateType.NotSet)
			{
				LauncherLog instance = LauncherLog.Instance;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Optional package 使用启动器状态文件中的包体类型: ");
				defaultInterpolatedStringHandler.AppendFormatted<EResUpdateType>(eresUpdateType);
				instance.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return eresUpdateType;
			}
			eresUpdateType = LauncherPackageStateLib.GetCommandLinePackageType();
			if (eresUpdateType != EResUpdateType.NotSet)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Optional package 使用启动器命令行兜底的包体类型: ");
				defaultInterpolatedStringHandler.AppendFormatted<EResUpdateType>(eresUpdateType);
				instance2.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return eresUpdateType;
			}
			LauncherLog.Instance.Info("Optional package 状态文件和命令行均无有效包体类型，使用精简包兜底", default(ReadOnlySpan<ValueTuple<string, object>>));
			return EResUpdateType.Min;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000FE04 File Offset: 0x0000E004
		private unsafe static EResUpdateType ReadPackageType(ETier tier)
		{
			if (!LauncherPackageStateLib.IsValidTier(tier))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "Optional package 无有效资源档位，无法读取启动器包体状态";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tier", tier);
				instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return EResUpdateType.NotSet;
			}
			string statePath = LauncherPackageStateLib.GetStatePath();
			EResUpdateType result;
			try
			{
				LauncherPackageStateLib.LauncherPackageState launcherPackageState = JsonSerializer.Deserialize<LauncherPackageStateLib.LauncherPackageState>(File.ReadAllText(statePath), new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = true
				});
				if (launcherPackageState == null || launcherPackageState.SchemaVersion != 1 || launcherPackageState.Tiers == null)
				{
					LauncherLog instance2 = LauncherLog.Instance;
					string message2 = "Optional package 启动器包体状态格式或版本无效";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", statePath);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("schemaVersion", (launcherPackageState != null) ? new int?(launcherPackageState.SchemaVersion) : null);
					instance2.Warn(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					result = EResUpdateType.NotSet;
				}
				else
				{
					string text = LauncherDeviceTierLib.TierToLabel(tier);
					LauncherPackageStateLib.LauncherTierPackageState launcherTierPackageState;
					if (!launcherPackageState.Tiers.TryGetValue(text, out launcherTierPackageState) || launcherTierPackageState == null)
					{
						LauncherLog instance3 = LauncherLog.Instance;
						string message3 = "Optional package 启动器包体状态缺少当前档位记录";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("path", statePath);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("tier", text);
						instance3.Warn(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						result = EResUpdateType.NotSet;
					}
					else if (string.Equals(launcherTierPackageState.PackageType, "max", StringComparison.OrdinalIgnoreCase))
					{
						result = EResUpdateType.Max;
					}
					else if (string.Equals(launcherTierPackageState.PackageType, "min", StringComparison.OrdinalIgnoreCase))
					{
						result = EResUpdateType.Min;
					}
					else
					{
						LauncherLog instance4 = LauncherLog.Instance;
						string message4 = "Optional package 启动器包体状态中的包体类型无效";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("path", statePath);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("tier", text);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("packageType", launcherTierPackageState.PackageType);
						instance4.Warn(message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
						result = EResUpdateType.NotSet;
					}
				}
			}
			catch (Exception ex)
			{
				LauncherLog instance5 = LauncherLog.Instance;
				string message5 = "Optional package 读取启动器包体状态失败，使用命令行兜底";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("path", statePath);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("tier", tier);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("error", ex.Message);
				instance5.Warn(message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
				result = EResUpdateType.NotSet;
			}
			return result;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000100A8 File Offset: 0x0000E2A8
		public static EResUpdateType GetSavedPackageType(ETier tier)
		{
			if (tier == ETier.None)
			{
				return LauncherStorageLib.Instance.GetDeviceSaved<EResUpdateType>(ELauncherStorageDeviceKey.SelectedMaxOrMinPackType, EResUpdateType.NotSet);
			}
			if (!LauncherPackageStateLib.IsValidTier(tier))
			{
				return EResUpdateType.NotSet;
			}
			int num;
			if (int.TryParse(LauncherStorageLib.Instance.GetDeviceSavedString(LauncherPackageStateLib.GetStorageKey(tier), null), out num) && (num == 1 || num == 2))
			{
				return (EResUpdateType)num;
			}
			ETier deviceSaved = LauncherStorageLib.Instance.GetDeviceSaved<ETier>(ELauncherStorageDeviceKey.ResourceQualityTier, ETier.None);
			EResUpdateType deviceSaved2 = LauncherStorageLib.Instance.GetDeviceSaved<EResUpdateType>(ELauncherStorageDeviceKey.SelectedMaxOrMinPackType, EResUpdateType.NotSet);
			if (deviceSaved == tier && (deviceSaved2 == EResUpdateType.Max || deviceSaved2 == EResUpdateType.Min))
			{
				LauncherPackageStateLib.SetSavedPackageType(tier, deviceSaved2);
				return deviceSaved2;
			}
			return EResUpdateType.NotSet;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00010128 File Offset: 0x0000E328
		public unsafe static bool SetSavedPackageType(ETier tier, EResUpdateType packageType)
		{
			if (!LauncherPackageStateLib.IsValidPackageType(packageType))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "Optional package 拒绝记录非法档位包体类型";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tier", tier);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("packageType", packageType);
				instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (tier == ETier.None)
			{
				LauncherStorageLib.Instance.SetDeviceSaved<EResUpdateType>(ELauncherStorageDeviceKey.SelectedMaxOrMinPackType, packageType);
				return true;
			}
			if (!LauncherPackageStateLib.IsValidTier(tier))
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "Optional package 拒绝记录非法档位包体类型";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("tier", tier);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("packageType", packageType);
				instance2.Error(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			LauncherStorageLib instance3 = LauncherStorageLib.Instance;
			string storageKey = LauncherPackageStateLib.GetStorageKey(tier);
			int num = (int)packageType;
			return instance3.SetDeviceSavedString(storageKey, num.ToString());
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00010228 File Offset: 0x0000E428
		public static void ClearSavedPackageTypes()
		{
			foreach (ETier tier in new ETier[]
			{
				ETier.SD,
				ETier.HD,
				ETier.UHD
			})
			{
				LauncherStorageLib.Instance.DeleteDeviceSavedString(LauncherPackageStateLib.GetStorageKey(tier));
			}
			LauncherStorageLib.Instance.DeleteDeviceSaved(ELauncherStorageDeviceKey.SelectedMaxOrMinPackType);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00010278 File Offset: 0x0000E478
		public static bool SetPackageType(ETier tier, EResUpdateType packageType)
		{
			if (!LauncherPackageStateLib.IsValidTier(tier))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "Optional package 拒绝同步非法资源档位";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tier", tier);
				instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (packageType != EResUpdateType.Max && packageType != EResUpdateType.Min)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "Optional package 拒绝记录非法包体类型";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("packageType", packageType);
				instance2.Error(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			return LauncherPackageStateLib.WriteLauncherState(tier, packageType);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000102F0 File Offset: 0x0000E4F0
		private static bool IsValidTier(ETier tier)
		{
			return tier == ETier.SD || tier == ETier.HD || tier == ETier.UHD;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00010300 File Offset: 0x0000E500
		private static bool IsValidPackageType(EResUpdateType packageType)
		{
			return packageType == EResUpdateType.Max || packageType == EResUpdateType.Min;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0001030C File Offset: 0x0000E50C
		private static string GetStorageKey(ETier tier)
		{
			return "SelectedMaxOrMinPackType_" + LauncherDeviceTierLib.TierToLabel(tier);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0001031E File Offset: 0x0000E51E
		private static string GetStatePath()
		{
			return Path.Combine(UKuroLauncherLibrary.GameSavedDir(), "LauncherBridge", "PackageState.json");
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00010334 File Offset: 0x0000E534
		private unsafe static bool WriteLauncherState(ETier tier, EResUpdateType packageType)
		{
			string text = Path.Combine(UKuroLauncherLibrary.GameSavedDir(), "LauncherBridge");
			string statePath = LauncherPackageStateLib.GetStatePath();
			string path = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 3);
			defaultInterpolatedStringHandler.AppendFormatted("PackageState.json");
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted<int>(Environment.ProcessId);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted<Guid>(Guid.NewGuid(), "N");
			defaultInterpolatedStringHandler.AppendLiteral(".tmp");
			string text2 = Path.Combine(path, defaultInterpolatedStringHandler.ToStringAndClear());
			bool result;
			try
			{
				Directory.CreateDirectory(text);
				LauncherPackageStateLib.LauncherPackageState launcherPackageState = new LauncherPackageStateLib.LauncherPackageState();
				if (File.Exists(statePath))
				{
					LauncherPackageStateLib.LauncherPackageState launcherPackageState2 = JsonSerializer.Deserialize<LauncherPackageStateLib.LauncherPackageState>(File.ReadAllText(statePath), new JsonSerializerOptions
					{
						PropertyNameCaseInsensitive = true
					});
					if (launcherPackageState2 != null && launcherPackageState2.SchemaVersion == 1 && launcherPackageState2.Tiers != null)
					{
						launcherPackageState = launcherPackageState2;
					}
				}
				string text3 = LauncherDeviceTierLib.TierToLabel(tier);
				launcherPackageState.Tiers[text3] = new LauncherPackageStateLib.LauncherTierPackageState
				{
					PackageType = ((packageType == EResUpdateType.Max) ? "max" : "min"),
					UpdatedAtUtc = DateTime.UtcNow.ToString("O")
				};
				string contents = JsonSerializer.Serialize<LauncherPackageStateLib.LauncherPackageState>(launcherPackageState, new JsonSerializerOptions
				{
					PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
					WriteIndented = true
				});
				File.WriteAllText(text2, contents, new UTF8Encoding(false));
				File.Move(text2, statePath, true);
				LauncherLog instance = LauncherLog.Instance;
				string message = "Optional package 已同步启动器包体状态";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tier", text3);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("packageType", packageType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("path", statePath);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				result = true;
			}
			catch (Exception ex)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "Optional package 同步启动器包体状态失败";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("packageType", packageType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("path", statePath);
				instance2.ErrorWithStack(message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				result = false;
			}
			finally
			{
				if (File.Exists(text2))
				{
					try
					{
						File.Delete(text2);
					}
					catch (Exception ex2)
					{
						LauncherLog instance3 = LauncherLog.Instance;
						string message3 = "Optional package 清理启动器状态临时文件失败";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("path", text2);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("error", ex2.Message);
						instance3.Warn(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					}
				}
			}
			return result;
		}

		// Token: 0x04000215 RID: 533
		private const int SCHEMA_VERSION = 1;

		// Token: 0x04000216 RID: 534
		private const string STATE_DIRECTORY = "LauncherBridge";

		// Token: 0x04000217 RID: 535
		private const string STATE_FILE_NAME = "PackageState.json";

		// Token: 0x020002CE RID: 718
		[Nullable(0)]
		private sealed class LauncherPackageState
		{
			// Token: 0x17000179 RID: 377
			// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00060A96 File Offset: 0x0005EC96
			// (set) Token: 0x06000FFA RID: 4090 RVA: 0x00060A9E File Offset: 0x0005EC9E
			public int SchemaVersion { get; set; } = 1;

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00060AA7 File Offset: 0x0005ECA7
			// (set) Token: 0x06000FFC RID: 4092 RVA: 0x00060AAF File Offset: 0x0005ECAF
			public Dictionary<string, LauncherPackageStateLib.LauncherTierPackageState> Tiers { get; set; } = new Dictionary<string, LauncherPackageStateLib.LauncherTierPackageState>();
		}

		// Token: 0x020002CF RID: 719
		[Nullable(0)]
		private sealed class LauncherTierPackageState
		{
			// Token: 0x1700017B RID: 379
			// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00060AD2 File Offset: 0x0005ECD2
			// (set) Token: 0x06000FFF RID: 4095 RVA: 0x00060ADA File Offset: 0x0005ECDA
			public string PackageType { get; set; } = "";

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x06001000 RID: 4096 RVA: 0x00060AE3 File Offset: 0x0005ECE3
			// (set) Token: 0x06001001 RID: 4097 RVA: 0x00060AEB File Offset: 0x0005ECEB
			public string UpdatedAtUtc { get; set; } = "";
		}
	}
}
