using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Util;
using UnrealEngine;

// Token: 0x02000010 RID: 16
[NullableContext(1)]
[Nullable(0)]
public class LauncherFileLib : IStaticVariableResetter
{
	// Token: 0x06000096 RID: 150 RVA: 0x00006D23 File Offset: 0x00004F23
	static LauncherFileLib()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LauncherFileLib.CreateStaticDefaultValue), new Action(LauncherFileLib.ResetStaticDefaultValue));
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00006D42 File Offset: 0x00004F42
	public static void CreateStaticDefaultValue()
	{
		LauncherFileLib.HadDeletion = false;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00006D4A File Offset: 0x00004F4A
	public static void ResetStaticDefaultValue()
	{
		LauncherFileLib.HadDeletion = false;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00006D54 File Offset: 0x00004F54
	public unsafe static void ClearOldPackageResDir(string oldVer = "")
	{
		string appVersion = UKuroLauncherLibrary.GetAppVersion();
		string text = UKuroLauncherLibrary.GameSavedDir() + "Resources/";
		TArray<string> directories = UKuroStaticLibrary.GetDirectories(text);
		string text2 = LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PreDownloadConfig, "") ?? "";
		LauncherLog instance = LauncherLog.Instance;
		string message = "pre download record";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("preVer", text2);
		instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (!string.IsNullOrEmpty(text2))
		{
			VersionInfo item = VersionInfo.TryParse(appVersion).Item2;
			VersionInfo item2 = VersionInfo.TryParse(text2).Item2;
			if (item != null && item2 != null && VersionInfo.LessThanOrEqual(item2, item))
			{
				text2 = "";
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "pre download record is <= appVer, preVer reset.";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("appVer", appVersion);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("preVer", text2);
				instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		int num = directories.Num();
		for (int i = 0; i < num; i++)
		{
			string text3 = directories.Get(i);
			if (!(text3 == appVersion) && !(text3 == EResType.Video.ToEnumString()) && (string.IsNullOrEmpty(text2) || !(text3 == text2)) && (string.IsNullOrEmpty(oldVer) || !(text3 == oldVer)))
			{
				UKuroLauncherLibrary.DeleteDirectory(text + text3);
				LauncherFileLib.HadDeletion = true;
			}
		}
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00006EC0 File Offset: 0x000050C0
	public static void ClearResDirs(string resDir, ISet<string> retainVersions)
	{
		TArray<string> directories = UKuroStaticLibrary.GetDirectories(resDir);
		int num = directories.Num();
		for (int i = 0; i < num; i++)
		{
			string text = directories.Get(i);
			if (!retainVersions.Contains(text))
			{
				UKuroLauncherLibrary.DeleteDirectory(resDir + text);
				LauncherFileLib.HadDeletion = true;
			}
		}
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00006F0C File Offset: 0x0000510C
	public static void RemoveDownloadFile(string filePath)
	{
		if (!string.IsNullOrEmpty(filePath) && UBlueprintPathsLibrary.FileExists(filePath))
		{
			UKuroLauncherLibrary.DeleteFile(filePath);
		}
		string text = filePath + ".download";
		if (!string.IsNullOrEmpty(filePath) && UBlueprintPathsLibrary.FileExists(text))
		{
			UKuroLauncherLibrary.DeleteFile(text);
		}
	}

	// Token: 0x04000051 RID: 81
	public static bool HadDeletion;
}
