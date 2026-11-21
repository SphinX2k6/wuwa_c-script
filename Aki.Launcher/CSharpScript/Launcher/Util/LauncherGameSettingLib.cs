using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui;
using UnrealEngine;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200006C RID: 108
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherGameSettingLib : Singleton
	{
		// Token: 0x060002CC RID: 716 RVA: 0x0000EA4D File Offset: 0x0000CC4D
		public void Initialize()
		{
			this.ApplyGameSettings();
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000EA55 File Offset: 0x0000CC55
		public void InitInLaunch(UWorld world)
		{
			if (Platform.Instance.IsOpenHarmonyPlatform())
			{
				this.GetDefaultMobileContentScaleFactor();
			}
			this.TryApplyMobileContentScaleFactor(world);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000EA74 File Offset: 0x0000CC74
		private void ApplyGameSettings()
		{
			Dictionary<int, double> dictionary = this.LoadGameSetting();
			if (dictionary == null)
			{
				return;
			}
			this.Apply(dictionary, 1);
			this.Apply(dictionary, 2);
			this.Apply(dictionary, 3);
			this.Apply(dictionary, 4);
			this.Apply(dictionary, 69);
			this.Apply(dictionary, 70);
			this.Apply(dictionary, 6);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000EAC8 File Offset: 0x0000CCC8
		[NullableContext(2)]
		public Dictionary<int, double> LoadPlayMenuInfo()
		{
			Dictionary<int, double> global = LauncherStorageLib.Instance.GetGlobal<Dictionary<int, double>>(ELauncherStorageGlobalKey.MenuData, null);
			if (global == null)
			{
				string global2 = LauncherStorageLib.Instance.GetGlobal<string>(ELauncherStorageGlobalKey.PlayMenuInfo, string.Empty);
				if (!string.IsNullOrEmpty(global2))
				{
					return LaunchUtil.ObjToMap<int, double>(LauncherJson.Parse<Dictionary<int, double>>(global2, null));
				}
			}
			return global;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000EB10 File Offset: 0x0000CD10
		[NullableContext(2)]
		private Dictionary<int, double> LoadGameSetting()
		{
			Dictionary<int, double> dictionary = this.LoadPlayMenuInfo();
			if (dictionary == null)
			{
				LauncherLog.Instance.Info("[LauncherGameSettingLib][GameSettings]找不到玩家保存数据，从默认配置表中读取????", default(ReadOnlySpan<ValueTuple<string, object>>));
				dictionary = new Dictionary<int, double>();
				this.SetGameDataMap(dictionary, 1, ELauncherStorageGlobalKey.MasterVolume, 100);
				this.SetGameDataMap(dictionary, 2, ELauncherStorageGlobalKey.VoiceVolume, 100);
				this.SetGameDataMap(dictionary, 3, ELauncherStorageGlobalKey.MusicVolume, 100);
				this.SetGameDataMap(dictionary, 4, ELauncherStorageGlobalKey.SFXVolume, 100);
				this.SetGameDataMap(dictionary, 69, ELauncherStorageGlobalKey.AMBVolume, 100);
				this.SetGameDataMap(dictionary, 70, ELauncherStorageGlobalKey.UIVolume, 100);
				this.SetGameDataMap(dictionary, 6, ELauncherStorageGlobalKey.PcResolutionIndex, 0);
			}
			else if (LauncherStorageLib.Instance.GetGlobal<bool>(ELauncherStorageGlobalKey.HasLocalGameSettings, false))
			{
				this.SetGameDataMap(dictionary, 6, ELauncherStorageGlobalKey.PcResolutionIndex, 0);
			}
			return dictionary;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000EBB8 File Offset: 0x0000CDB8
		private unsafe void SetGameDataMap(Dictionary<int, double> gameDataMapRef, int functionId, ELauncherStorageGlobalKey launcherStorageGlobalKey, int NotFoundValue = 0)
		{
			double? global = LauncherStorageLib.Instance.GetGlobal<double?>(launcherStorageGlobalKey, null);
			if (global != null)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "[LauncherGameSettingLib][GameSettings]设置游戏数据Map时，存在新版本的游戏设置，将读取新版本的游戏设置数据";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", functionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", global);
				instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				gameDataMapRef[functionId] = global.Value;
				return;
			}
			LaunchGameSettingMenuConfig gameSettingsMenuConfigByFunctionId = LauncherConfigLib.Instance.GetGameSettingsMenuConfigByFunctionId(functionId);
			if (gameSettingsMenuConfigByFunctionId == null)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "[LauncherGameSettingLib][GameSettings]找不到设置系统表配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("functionId", functionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("NotFoundValue", NotFoundValue);
				instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				gameDataMapRef[functionId] = (double)NotFoundValue;
				return;
			}
			float defaultValue = gameSettingsMenuConfigByFunctionId.GetDefaultValue();
			LauncherLog instance3 = LauncherLog.Instance;
			string message3 = "[LauncherGameSettingLib][GameSettings]设置游戏数据Map";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("functionId", functionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("defaultValue", defaultValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("NotFoundValue", NotFoundValue);
			instance3.Info(message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			gameDataMapRef[functionId] = (double)defaultValue;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000ED48 File Offset: 0x0000CF48
		private unsafe void Apply(Dictionary<int, double> gameDataMap, int functionId)
		{
			double num;
			if (!gameDataMap.TryGetValue(functionId, out num))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "[LauncherGameSettingLib][GameSettings]找不到对应热更游戏设置数据";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", functionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", null);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "[LauncherGameSettingLib][GameSettings]应用热更游戏设置数据";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("functionId", functionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("value", num);
			instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			switch (functionId)
			{
			case 1:
				this.ApplyRTPCValue("volume_master", (float)num);
				return;
			case 2:
				this.ApplyRTPCValue("volume_voice", (float)num);
				return;
			case 3:
				this.ApplyRTPCValue("volume_music", (float)num);
				return;
			case 4:
				this.ApplyRTPCValue("volume_sfx", (float)num);
				return;
			case 5:
				break;
			case 6:
				this.ApplyResolution((int)num);
				break;
			default:
				if (functionId == 69)
				{
					this.ApplyRTPCValue("volume_sfx_amb", (float)num);
					return;
				}
				if (functionId != 70)
				{
					return;
				}
				this.ApplyRTPCValue("volume_sfx_ui", (float)num);
				return;
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000EE95 File Offset: 0x0000D095
		private void ApplyRTPCValue(string rtpc, float value)
		{
			UAkGameplayStatics.SetRTPCValue(null, value, 0, null, new FName(rtpc));
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
		private unsafe void ApplyResolution(int value)
		{
			List<FIntPoint> resolutionList = this.GetResolutionList();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[LauncherGameSettingLib][GameSettings]当前分辨率列表";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("resolutionList", resolutionList);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (value < 0 || value >= resolutionList.Count)
			{
				return;
			}
			FIntPoint fintPoint = resolutionList[value];
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "[LauncherGameSettingLib][GameSettings]热更时应用分辨率";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("value", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("resolution", fintPoint);
			instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			gameUserSettings.SetScreenResolution(fintPoint);
			gameUserSettings.ApplySettings(true);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000EF94 File Offset: 0x0000D194
		public List<FIntPoint> GetResolutionList()
		{
			List<FIntPoint> list = new List<FIntPoint>();
			TArray<FIntPoint> tarray = new TArray<FIntPoint>();
			if (UKismetSystemLibrary.GetSupportedFullscreenResolutions(ref tarray))
			{
				for (int i = tarray.Num() - 1; i >= 0; i--)
				{
					FIntPoint fintPoint = tarray.Get(i);
					list.Add(fintPoint);
					LauncherLog instance = LauncherLog.Instance;
					string message = "具体分辨率";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("resolution", fintPoint);
					instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			if (list.Count == 0)
			{
				LauncherLog.Instance.Info("[LauncherGameSettingLib][GameSettings]获取当前分辨率列表失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				list.Add(UGameUserSettings.GetGameUserSettings().GetDesktopResolution());
			}
			else
			{
				List<FIntPoint> list2 = list;
				Comparison<FIntPoint> comparison;
				if ((comparison = LauncherGameSettingLib.<>O.<0>__CompareResolution) == null)
				{
					comparison = (LauncherGameSettingLib.<>O.<0>__CompareResolution = new Comparison<FIntPoint>(LauncherGameSettingLib.CompareResolution));
				}
				list2.Sort(comparison);
			}
			if (list.Count > 0 && list[0].X == 3620 && list[0].Y == 2036)
			{
				list.RemoveAt(0);
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "最后的分辨率列表结果";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("resolutionList", list);
			instance2.Debug(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return list;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000F0B6 File Offset: 0x0000D2B6
		private static int CompareResolution(FIntPoint a, FIntPoint b)
		{
			if (a.X == b.X)
			{
				return b.Y - a.Y;
			}
			return b.X - a.X;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000F0E4 File Offset: 0x0000D2E4
		private float GetDefaultMobileContentScaleFactor()
		{
			float value = this.DefaultMobileContentScaleFactor.GetValueOrDefault();
			if (this.DefaultMobileContentScaleFactor == null)
			{
				value = UKismetSystemLibrary.GetConsoleVariableFloatValue("r.MobileContentScaleFactor");
				this.DefaultMobileContentScaleFactor = new float?(value);
			}
			return this.DefaultMobileContentScaleFactor.Value;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000F12C File Offset: 0x0000D32C
		public unsafe void ApplyFoldStateMobileContentScaleFactor(UWorld world, bool isFolded)
		{
			if (!Platform.Instance.IsOpenHarmonyPlatform() || Platform.Instance.IsRedMagicDevice())
			{
				return;
			}
			float num = this.GetDefaultMobileContentScaleFactor();
			if (!isFolded)
			{
				string deviceProfileBaseProfileName = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceProfileBaseProfileName();
				if (deviceProfileBaseProfileName == "Android_Mid")
				{
					num = 2.5f;
				}
				else if (deviceProfileBaseProfileName == "Android_High" || deviceProfileBaseProfileName == "Android_VeryHigh")
				{
					num = 3f;
				}
				else
				{
					num = 2f;
				}
			}
			float consoleVariableFloatValue = UKismetSystemLibrary.GetConsoleVariableFloatValue("r.MobileContentScaleFactor");
			if (consoleVariableFloatValue == num)
			{
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(world, FormattableString.Invariant(FormattableStringFactory.Create("r.MobileContentScaleFactor {0}", new object[]
			{
				num
			})), null);
			LauncherLog instance = LauncherLog.Instance;
			string message = "折叠屏适配更新ScaleFactor";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isFolded", isFolded);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("previousScaleFactor", consoleVariableFloatValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("scaleFactor", num);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000F24C File Offset: 0x0000D44C
		private void TryApplyMobileContentScaleFactor(UWorld world)
		{
			if (Platform.Instance.IsRedMagicDevice())
			{
				return;
			}
			if (Platform.Instance.IsFoldingScreen() && (Platform.Instance.IsAndroidPlatform() || Platform.Instance.IsOpenHarmonyPlatform()))
			{
				string deviceProfileBaseProfileName = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceProfileBaseProfileName();
				if (deviceProfileBaseProfileName == "Android_Low")
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(world, "r.MobileContentScaleFactor 2", null);
					return;
				}
				if (deviceProfileBaseProfileName == "Android_Mid")
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(world, "r.MobileContentScaleFactor 2.5", null);
					return;
				}
				if (deviceProfileBaseProfileName == "Android_High" || deviceProfileBaseProfileName == "Android_VeryHigh")
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(world, "r.MobileContentScaleFactor 3", null);
					return;
				}
				UKismetSystemLibrary.ExecuteConsoleCommand(world, "r.MobileContentScaleFactor 2", null);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000F2FA File Offset: 0x0000D4FA
		public static LauncherGameSettingLib Instance
		{
			get
			{
				if (LauncherGameSettingLib._instance == null)
				{
					LauncherGameSettingLib._instance = new LauncherGameSettingLib();
					LauncherGameSettingLib._instance.OnInit();
				}
				return LauncherGameSettingLib._instance;
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000F31D File Offset: 0x0000D51D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000F31F File Offset: 0x0000D51F
		public static void ResetStaticDefaultValue()
		{
			LauncherGameSettingLib instance = LauncherGameSettingLib._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherGameSettingLib._instance = null;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000F338 File Offset: 0x0000D538
		static LauncherGameSettingLib()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherGameSettingLib.CreateStaticDefaultValue), new Action(LauncherGameSettingLib.ResetStaticDefaultValue));
		}

		// Token: 0x040001EB RID: 491
		private const int MASTERVOLUMEFUNCTION = 1;

		// Token: 0x040001EC RID: 492
		private const int VOICEVOLUMEFUNCTION = 2;

		// Token: 0x040001ED RID: 493
		private const int MUSICVOLUMEFUNCTION = 3;

		// Token: 0x040001EE RID: 494
		private const int SFXVOLUMEFUNCTION = 4;

		// Token: 0x040001EF RID: 495
		private const int RESOLUTION = 6;

		// Token: 0x040001F0 RID: 496
		private const int AMBVOLUMEFUNCTION = 69;

		// Token: 0x040001F1 RID: 497
		private const int UIVOLUMEFUNCTION = 70;

		// Token: 0x040001F2 RID: 498
		private const int DEFAULT_VALUE_VALUE = 100;

		// Token: 0x040001F3 RID: 499
		private float? DefaultMobileContentScaleFactor;

		// Token: 0x040001F4 RID: 500
		[Nullable(2)]
		private static LauncherGameSettingLib _instance;

		// Token: 0x020002CD RID: 717
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000B4E RID: 2894
			[Nullable(0)]
			public static Comparison<FIntPoint> <0>__CompareResolution;
		}
	}
}
