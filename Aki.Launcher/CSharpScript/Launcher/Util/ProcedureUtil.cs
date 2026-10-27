using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000078 RID: 120
	[NullableContext(1)]
	[Nullable(0)]
	public static class ProcedureUtil
	{
		// Token: 0x0600032B RID: 811 RVA: 0x000110C4 File Offset: 0x0000F2C4
		public static UniTask whetherRepeatDoOnFailedAsync([Nullable(new byte[]
		{
			1,
			0,
			1
		})] Func<UniTask<IDoResult>> doSomething, [Nullable(new byte[]
		{
			1,
			2,
			1,
			0,
			1,
			0,
			1
		})] Func<object, Func<UniTask<IDoResult>>, UniTask<IDoResult>> postDoFailed, bool doNotLoop = false)
		{
			ProcedureUtil.<whetherRepeatDoOnFailedAsync>d__0 <whetherRepeatDoOnFailedAsync>d__;
			<whetherRepeatDoOnFailedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<whetherRepeatDoOnFailedAsync>d__.doSomething = doSomething;
			<whetherRepeatDoOnFailedAsync>d__.postDoFailed = postDoFailed;
			<whetherRepeatDoOnFailedAsync>d__.doNotLoop = doNotLoop;
			<whetherRepeatDoOnFailedAsync>d__.<>1__state = -1;
			<whetherRepeatDoOnFailedAsync>d__.<>t__builder.Start<ProcedureUtil.<whetherRepeatDoOnFailedAsync>d__0>(ref <whetherRepeatDoOnFailedAsync>d__);
			return <whetherRepeatDoOnFailedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00011118 File Offset: 0x0000F318
		public static UniTask whetherRepeatDoOnFailed(Func<IDoResult> doSomething, [Nullable(new byte[]
		{
			1,
			2,
			1,
			1,
			0,
			1
		})] Func<object, Func<IDoResult>, UniTask<IDoResult>> postDoFailed, bool doNotLoop = false)
		{
			ProcedureUtil.<whetherRepeatDoOnFailed>d__1 <whetherRepeatDoOnFailed>d__;
			<whetherRepeatDoOnFailed>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<whetherRepeatDoOnFailed>d__.doSomething = doSomething;
			<whetherRepeatDoOnFailed>d__.postDoFailed = postDoFailed;
			<whetherRepeatDoOnFailed>d__.doNotLoop = doNotLoop;
			<whetherRepeatDoOnFailed>d__.<>1__state = -1;
			<whetherRepeatDoOnFailed>d__.<>t__builder.Start<ProcedureUtil.<whetherRepeatDoOnFailed>d__1>(ref <whetherRepeatDoOnFailed>d__);
			return <whetherRepeatDoOnFailed>d__.<>t__builder.Task;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0001116C File Offset: 0x0000F36C
		public static void randomArray<[Nullable(2)] T>(IList<T> arr)
		{
			Random random = new Random();
			for (int i = arr.Count - 1; i >= 0; i--)
			{
				if (i > 0)
				{
					int num = random.Next(i + 1);
					if (num != i)
					{
						T value = arr[num];
						arr[num] = arr[i];
						arr[i] = value;
					}
				}
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000111C4 File Offset: 0x0000F3C4
		public unsafe static bool IsFirstTimeUpdateForPackage()
		{
			string deviceSaved = LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PatchVersion, "");
			if (deviceSaved == null || deviceSaved == "")
			{
				return true;
			}
			RemoteInfo instance = RemoteInfo.Instance;
			string text;
			if (instance == null)
			{
				text = null;
			}
			else
			{
				RemoteVersionConfig newConfig = instance.NewConfig;
				text = ((newConfig != null) ? newConfig.PackageVersion : null);
			}
			string text2 = text;
			ValueTuple<bool, VersionInfo> valueTuple = VersionInfo.TryParse(deviceSaved);
			bool item = valueTuple.Item1;
			VersionInfo item2 = valueTuple.Item2;
			ValueTuple<bool, VersionInfo> valueTuple2 = VersionInfo.TryParse(text2);
			bool item3 = valueTuple2.Item1;
			VersionInfo item4 = valueTuple2.Item2;
			if (!item || !item3)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message = "package version is invalid";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("localVer", deviceSaved);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("remoteVer", text2);
				instance2.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			return item4.Major > item2.Major || item4.Minor > item2.Minor;
		}
	}
}
