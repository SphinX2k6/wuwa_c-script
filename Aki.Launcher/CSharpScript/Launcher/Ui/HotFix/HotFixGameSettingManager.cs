using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D5 RID: 213
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixGameSettingManager
	{
		// Token: 0x06000700 RID: 1792 RVA: 0x0003B138 File Offset: 0x00039338
		public void ApplyGameSettings()
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
			if (!CloudGameManagerLauncher.Instance.IsPreLaunch)
			{
				this.Apply(dictionary, 6);
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0003B198 File Offset: 0x00039398
		[NullableContext(2)]
		private Dictionary<int, double> LoadPlayMenuInfo()
		{
			Dictionary<int, double> global = LauncherStorageLib.Instance.GetGlobal<Dictionary<int, double>>(ELauncherStorageGlobalKey.MenuData, null);
			if (global == null)
			{
				string global2 = LauncherStorageLib.Instance.GetGlobal<string>(ELauncherStorageGlobalKey.PlayMenuInfo, "");
				if (global2 != null && global2 != "")
				{
					return LaunchUtil.ObjToMap<string, double>(LauncherJson.Parse<Dictionary<string, double>>(global2, null) ?? new Dictionary<string, double>());
				}
			}
			return global;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0003B1F0 File Offset: 0x000393F0
		[NullableContext(2)]
		private Dictionary<int, double> LoadGameSetting()
		{
			Dictionary<int, double> dictionary = this.LoadPlayMenuInfo();
			if (dictionary == null)
			{
				LauncherLog.Instance.Info("[HotFixGameSettingManager][GameSettings]找不到玩家保存数据，从默认配置表中读取", default(ReadOnlySpan<ValueTuple<string, object>>));
				dictionary = new Dictionary<int, double>();
			}
			this.SetGameDataMap(dictionary, 1, ELauncherStorageGlobalKey.MasterVolume, 100);
			this.SetGameDataMap(dictionary, 2, ELauncherStorageGlobalKey.VoiceVolume, 100);
			this.SetGameDataMap(dictionary, 3, ELauncherStorageGlobalKey.MusicVolume, 100);
			this.SetGameDataMap(dictionary, 4, ELauncherStorageGlobalKey.SFXVolume, 100);
			this.SetGameDataMap(dictionary, 69, ELauncherStorageGlobalKey.AMBVolume, 100);
			this.SetGameDataMap(dictionary, 70, ELauncherStorageGlobalKey.UIVolume, 100);
			this.SetGameDataMap(dictionary, 6, ELauncherStorageGlobalKey.PcResolutionIndex, 0);
			return dictionary;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0003B27C File Offset: 0x0003947C
		private unsafe void SetGameDataMap(Dictionary<int, double> gameDataMapRef, int functionId, ELauncherStorageGlobalKey launcherStorageGlobalKey, int NotFoundValue = 0)
		{
			double global = LauncherStorageLib.Instance.GetGlobal<double>(launcherStorageGlobalKey, double.NaN);
			if (!double.IsNaN(global))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "[HotFixGameSettingManager][GameSettings]设置游戏数据Map时，存在新版本的游戏设置，将读取新版本的游戏设置数据";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", functionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", global);
				instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				gameDataMapRef[functionId] = global;
				return;
			}
			if (!gameDataMapRef.ContainsKey(functionId))
			{
				double? defaultGameSetttingsValue = this.GetDefaultGameSetttingsValue(functionId);
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "[HotFixGameSettingManager][GameSettings]设置游戏数据Map";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("functionId", functionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("defaultValue", defaultGameSetttingsValue);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("NotFoundValue", NotFoundValue);
				instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				gameDataMapRef[functionId] = (defaultGameSetttingsValue ?? ((double)NotFoundValue));
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0003B3B4 File Offset: 0x000395B4
		private double? GetDefaultGameSetttingsValue(int functionId)
		{
			LaunchGameSettingMenuConfig gameSettingsMenuConfigByFunctionId = LauncherConfigLib.Instance.GetGameSettingsMenuConfigByFunctionId(functionId);
			if (gameSettingsMenuConfigByFunctionId == null)
			{
				return null;
			}
			return new double?((double)gameSettingsMenuConfigByFunctionId.GetDefaultValue());
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0003B3E8 File Offset: 0x000395E8
		private unsafe void Apply(Dictionary<int, double> gameDataMap, int functionId)
		{
			double num;
			if (!gameDataMap.TryGetValue(functionId, out num))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "[HotFixGameSettingManager][GameSettings]找不到对应热更游戏设置数据";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", functionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", null);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "[HotFixGameSettingManager][GameSettings]应用热更游戏设置数据";
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

		// Token: 0x06000706 RID: 1798 RVA: 0x0003B535 File Offset: 0x00039735
		private void ApplyRTPCValue(string rtpc, float value)
		{
			UAkGameplayStatics.SetRTPCValue(null, value, 0, null, new FName(rtpc));
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0003B548 File Offset: 0x00039748
		private unsafe void ApplyResolution(int value)
		{
			if (Platform.Instance.IsCloudGame())
			{
				return;
			}
			List<FIntPoint> resolutionList = this.GetResolutionList();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[HotFixGameSettingManager][GameSettings]当前分辨率列表";
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
			string message2 = "[HotFixGameSettingManager][GameSettings]热更时应用分辨率";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("value", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("resolution", fintPoint);
			instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			gameUserSettings.SetScreenResolution(fintPoint);
			gameUserSettings.ApplySettings(true);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0003B63E File Offset: 0x0003983E
		public List<FIntPoint> GetResolutionList()
		{
			return LauncherGameSettingLib.Instance.GetResolutionList();
		}

		// Token: 0x0400044E RID: 1102
		private const int MASTERVOLUMEFUNCTION = 1;

		// Token: 0x0400044F RID: 1103
		private const int VOICEVOLUMEFUNCTION = 2;

		// Token: 0x04000450 RID: 1104
		private const int MUSICVOLUMEFUNCTION = 3;

		// Token: 0x04000451 RID: 1105
		private const int SFXVOLUMEFUNCTION = 4;

		// Token: 0x04000452 RID: 1106
		private const int RESOLUTION = 6;

		// Token: 0x04000453 RID: 1107
		private const int AMBVOLUMEFUNCTION = 69;

		// Token: 0x04000454 RID: 1108
		private const int UIVOLUMEFUNCTION = 70;

		// Token: 0x04000455 RID: 1109
		private const int DEFAULT_VOLUME_VALUE = 100;
	}
}
