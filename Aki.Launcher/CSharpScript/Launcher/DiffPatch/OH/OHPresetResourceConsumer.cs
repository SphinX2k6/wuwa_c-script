using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.DiffPatch.OH
{
	// Token: 0x02000221 RID: 545
	[NullableContext(1)]
	[Nullable(0)]
	public class OHPresetResourceConsumer
	{
		// Token: 0x06000E38 RID: 3640 RVA: 0x00056CBC File Offset: 0x00054EBC
		public OHPresetResourceConsumer()
		{
			this.OhSystemManagedDownloadDir = "/data/storage/el2/base/haps/entry/cache/asset_acceleration/";
			this.OhNearbyDir = "/data/storage/el2/base/files/com.huawei.hms.gameservice.nearby.transfer/receive/UE4Game/Client/Client/Saved/Resources/";
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00056CDA File Offset: 0x00054EDA
		public bool IsSysMgEnabled()
		{
			return this.OhSystemManagedDownloadDir.Length > 0 && UBlueprintPathsLibrary.DirectoryExists(this.OhSystemManagedDownloadDir);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00056CF7 File Offset: 0x00054EF7
		public bool IsNearbyEnabled()
		{
			return this.OhNearbyDir.Length > 0 && UBlueprintPathsLibrary.DirectoryExists(this.OhNearbyDir);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00056D14 File Offset: 0x00054F14
		public UniTask ConsumeAfterManifest(DiffUpdate update, [Nullable(2)] HotFixManager viewMgr, bool bIsLauncher = false)
		{
			OHPresetResourceConsumer.<ConsumeAfterManifest>d__5 <ConsumeAfterManifest>d__;
			<ConsumeAfterManifest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ConsumeAfterManifest>d__.<>4__this = this;
			<ConsumeAfterManifest>d__.update = update;
			<ConsumeAfterManifest>d__.viewMgr = viewMgr;
			<ConsumeAfterManifest>d__.bIsLauncher = bIsLauncher;
			<ConsumeAfterManifest>d__.<>1__state = -1;
			<ConsumeAfterManifest>d__.<>t__builder.Start<OHPresetResourceConsumer.<ConsumeAfterManifest>d__5>(ref <ConsumeAfterManifest>d__);
			return <ConsumeAfterManifest>d__.<>t__builder.Task;
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00056D6F File Offset: 0x00054F6F
		private void DeletePresetFile(string path)
		{
			if (UBlueprintPathsLibrary.FileExists(path))
			{
				UKuroLauncherLibrary.DeleteFile(path);
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00056D80 File Offset: 0x00054F80
		public void Cleanup()
		{
			LauncherLog.Instance.Info("OH clean up preset resources.", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKuroLauncherLibrary.DeleteDirectory(this.OhSystemManagedDownloadDir);
			UKuroLauncherLibrary.DeleteDirectory(this.OhNearbyDir);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00056DC0 File Offset: 0x00054FC0
		private unsafe void Report(int moved, int missed, long totalMoved)
		{
			HotPatchLog hotPatchLog = new HotPatchLog();
			hotPatchLog.s_step_id = "oh_preset_consume";
			hotPatchLog.i_download_state = moved.ToString();
			HotPatchLogResult value = new HotPatchLogResult
			{
				success = true,
				info = new OHConsumeLogInfo
				{
					moved = moved,
					missed = missed,
					totalMoved = totalMoved
				}
			};
			hotPatchLog.s_step_result = LauncherJson.Stringify(value, null);
			HotPatchLogReport.Instance.Report(hotPatchLog);
			LauncherLog instance = LauncherLog.Instance;
			string message = "OH preset consume done";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("moved", moved);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("missed", missed);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("totalMoved", totalMoved.ToString());
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00056EA8 File Offset: 0x000550A8
		private void DirIterator(string dir, Dictionary<string, HashSet<string>> result)
		{
			TArray<string> filesRecursive = UKuroStaticLibrary.GetFilesRecursive(dir, "*", true, false);
			if (filesRecursive != null && filesRecursive.Num() > 0)
			{
				string value = dir.EndsWith('/') ? dir : (dir + "/");
				int num = filesRecursive.Num();
				for (int i = 0; i < num; i++)
				{
					string text = filesRecursive.Get(i).Replace("\\", "/");
					int num2 = text.LastIndexOf('/');
					string key = text.StartsWith(value) ? text.Substring(num2 + 1) : text;
					HashSet<string> hashSet = result.GetValueOrDefault(key);
					if (hashSet == null)
					{
						hashSet = new HashSet<string>();
						result.Add(key, hashSet);
					}
					hashSet.Add(text);
				}
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00056F68 File Offset: 0x00055168
		private Dictionary<string, HashSet<string>> EnumeratePresetFiles()
		{
			Dictionary<string, HashSet<string>> result = new Dictionary<string, HashSet<string>>();
			this.DirIterator(this.OhSystemManagedDownloadDir, result);
			this.DirIterator(this.OhNearbyDir, result);
			return result;
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00056F98 File Offset: 0x00055198
		private Dictionary<string, IWantedTarget> BuildWantedFromVideos()
		{
			Dictionary<string, IWantedTarget> dictionary = new Dictionary<string, IWantedTarget>();
			foreach (VideoResourceInfo videoResourceInfo in VideoResUpdate.Instance.VideoMap.Values)
			{
				dictionary[videoResourceInfo.PakFileName] = new IWantedTarget
				{
					Hash = videoResourceInfo.PakHash,
					DestPath = videoResourceInfo.LocalPath + "/" + videoResourceInfo.PakFileName,
					Size = videoResourceInfo.PakSize
				};
				dictionary[videoResourceInfo.SigFileName] = new IWantedTarget
				{
					Hash = videoResourceInfo.SigHash,
					DestPath = videoResourceInfo.LocalPath + "/" + videoResourceInfo.SigFileName,
					Size = videoResourceInfo.SigSize
				};
			}
			return dictionary;
		}

		// Token: 0x040008FC RID: 2300
		private readonly string OhSystemManagedDownloadDir;

		// Token: 0x040008FD RID: 2301
		private readonly string OhNearbyDir;
	}
}
