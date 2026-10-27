using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui;
using UnrealEngine;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200006A RID: 106
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherGameSettingLib : Singleton
	{
		// Token: 0x060002CA RID: 714 RVA: 0x0000E6A1 File Offset: 0x0000C8A1
		public void Initialize()
		{
			this.ApplyGameSettings();
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000E6A9 File Offset: 0x0000C8A9
		public void InitInLaunch(UWorld world)
		{
			this.TryApplyMobileContentScaleFactor(world);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000E6B4 File Offset: 0x0000C8B4
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

		// Token: 0x060002CD RID: 717 RVA: 0x0000E708 File Offset: 0x0000C908
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

		// Token: 0x060002CE RID: 718 RVA: 0x0000E750 File Offset: 0x0000C950
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

		// Token: 0x060002CF RID: 719 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
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

		// Token: 0x060002D0 RID: 720 RVA: 0x0000E988 File Offset: 0x0000CB88
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

		// Token: 0x060002D1 RID: 721 RVA: 0x0000EAD5 File Offset: 0x0000CCD5
		private void ApplyRTPCValue(string rtpc, float value)
		{
			UAkGameplayStatics.SetRTPCValue(null, value, 0, null, new FName(rtpc));
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
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

		// Token: 0x060002D3 RID: 723 RVA: 0x0000EBD4 File Offset: 0x0000CDD4
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

		// Token: 0x060002D4 RID: 724 RVA: 0x0000ECF6 File Offset: 0x0000CEF6
		private static int CompareResolution(FIntPoint a, FIntPoint b)
		{
			if (a.X == b.X)
			{
				return b.Y - a.Y;
			}
			return b.X - a.X;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000ED24 File Offset: 0x0000CF24
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
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000EDD2 File Offset: 0x0000CFD2
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

		// Token: 0x060002D7 RID: 727 RVA: 0x0000EDF5 File Offset: 0x0000CFF5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000EDF7 File Offset: 0x0000CFF7
		public static void ResetStaticDefaultValue()
		{
			LauncherGameSettingLib instance = LauncherGameSettingLib._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherGameSettingLib._instance = null;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000EE10 File Offset: 0x0000D010
		static LauncherGameSettingLib()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherGameSettingLib.CreateStaticDefaultValue), new Action(LauncherGameSettingLib.ResetStaticDefaultValue));
		}

		// Token: 0x040001C4 RID: 452
		private const int MASTERVOLUMEFUNCTION = 1;

		// Token: 0x040001C5 RID: 453
		private const int VOICEVOLUMEFUNCTION = 2;

		// Token: 0x040001C6 RID: 454
		private const int MUSICVOLUMEFUNCTION = 3;

		// Token: 0x040001C7 RID: 455
		private const int SFXVOLUMEFUNCTION = 4;

		// Token: 0x040001C8 RID: 456
		private const int RESOLUTION = 6;

		// Token: 0x040001C9 RID: 457
		private const int AMBVOLUMEFUNCTION = 69;

		// Token: 0x040001CA RID: 458
		private const int UIVOLUMEFUNCTION = 70;

		// Token: 0x040001CB RID: 459
		private const int DEFAULT_VALUE_VALUE = 100;

		// Token: 0x040001CC RID: 460
		[Nullable(2)]
		private static LauncherGameSettingLib _instance;

		// Token: 0x020002C4 RID: 708
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000AFE RID: 2814
			[Nullable(0)]
			public static Comparison<FIntPoint> <0>__CompareResolution;
		}
	}
}
