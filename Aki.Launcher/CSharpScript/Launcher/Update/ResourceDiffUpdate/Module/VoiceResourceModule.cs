using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Module
{
	// Token: 0x020000AE RID: 174
	[NullableContext(1)]
	[Nullable(0)]
	public class VoiceResourceModule : BaseResourceModule
	{
		// Token: 0x06000603 RID: 1539 RVA: 0x000361C4 File Offset: 0x000343C4
		[NullableContext(0)]
		public override UniTask<bool> PrepareManifests()
		{
			VoiceResourceModule.<PrepareManifests>d__1 <PrepareManifests>d__;
			<PrepareManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PrepareManifests>d__.<>1__state = -1;
			<PrepareManifests>d__.<>t__builder.Start<VoiceResourceModule.<PrepareManifests>d__1>(ref <PrepareManifests>d__);
			return <PrepareManifests>d__.<>t__builder.Task;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00036200 File Offset: 0x00034400
		public unsafe override PackClassification ClassifyPacks(ResourceSelectionContext context, ETier tier = ETier.None, bool forceMax = false)
		{
			HashSet<string> hashSet = new HashSet<string>(LauncherLanguageLib.Instance.GetUsedAudioCodes());
			bool flag = !this.IsVoiceDownloadEnable();
			List<ResPackageInfo> list = new List<ResPackageInfo>();
			long num = 0L;
			foreach (KeyValuePair<string, ResPackageInfo> keyValuePair in ResPackageInfo.RoleVoiceInfos)
			{
				string key = keyValuePair.Key;
				ResPackageInfo value = keyValuePair.Value;
				if (!flag)
				{
					string audioCodeFromPackKey = this.GetAudioCodeFromPackKey(key);
					if (!hashSet.Contains(audioCodeFromPackKey) && string.IsNullOrEmpty(value.ResourceVersionInfo.RecordVersion))
					{
						continue;
					}
				}
				List<RequireFileInfo> item = value.AnalyzeRequireFiles(false, tier).Item1;
				long num2 = 0L;
				foreach (RequireFileInfo requireFileInfo in item)
				{
					num2 += requireFileInfo.Size;
				}
				LauncherLog.Instance.Info("RoleVoice package 已下载过的角色语音包 " + key + ", 会自动参与更新.", default(ReadOnlySpan<ValueTuple<string, object>>));
				list.Add(value);
				num += num2;
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "RoleVoice package 分类完成";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("downloadAll", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("usedAudioCodes", string.Join(",", hashSet));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("count", list.Count);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item2 = "totalSize";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendFormatted<long>(num / 1048576L);
			defaultInterpolatedStringHandler.AppendLiteral(" MB");
			ptr = new ValueTuple<string, object>(item2, defaultInterpolatedStringHandler.ToStringAndClear());
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return new PackClassification
			{
				MinPacks = list,
				MaxPacks = list,
				MinSize = num,
				MaxSize = num
			};
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0003641C File Offset: 0x0003461C
		public bool IsVoiceDownloadEnable()
		{
			return VideoResUpdate.Instance.GetIsSeparateVideo() && !Platform.Instance.IsCloudGame() && !Platform.Instance.IsMacPlatform();
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00036448 File Offset: 0x00034648
		public override long GetLocalSize(IReadOnlyList<string> pakNames)
		{
			long num = 0L;
			foreach (string text in pakNames)
			{
				ResPackageInfo roleVoiceInfo = ResPackageInfo.GetRoleVoiceInfo(text);
				if (roleVoiceInfo != null)
				{
					long item = roleVoiceInfo.AnalyzeRequireFiles(false, ETier.None).Rest.Item1;
					num += item;
				}
				else
				{
					LauncherLog.Instance.Warn("RoleVoice package 获取角色语音大小时未找到资源包信息: " + text, default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			return num;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000364D4 File Offset: 0x000346D4
		public override void Delete(IReadOnlyList<string> pakNames)
		{
			foreach (string text in pakNames)
			{
				ResPackageInfo roleVoiceInfo = ResPackageInfo.GetRoleVoiceInfo(text);
				if (roleVoiceInfo != null)
				{
					roleVoiceInfo.DeleteLocalFiles();
					roleVoiceInfo.ClearRecord();
				}
				else
				{
					LauncherLog.Instance.Warn("RoleVoice package 卸载角色语音时未找到资源包信息: " + text, default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0003654C File Offset: 0x0003474C
		public long GetLocalSizeByAudioCode(string audioCode)
		{
			long num = 0L;
			ResPackageInfo languageInfo = ResPackageInfo.GetLanguageInfo(audioCode);
			if (languageInfo != null)
			{
				ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> valueTuple = languageInfo.AnalyzeRequireFiles(false, ETier.None);
				long num2 = valueTuple.Item2 + valueTuple.Rest.Item1;
				num += num2;
			}
			foreach (ValueTuple<string, ResPackageInfo> valueTuple2 in this.GetRoleVoicesByAudioCode(audioCode))
			{
				ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> valueTuple3 = valueTuple2.Item2.AnalyzeRequireFiles(false, ETier.None);
				long num3 = valueTuple3.Item2 + valueTuple3.Rest.Item1;
				num += num3;
			}
			return num;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000365F0 File Offset: 0x000347F0
		public void DeleteByAudioCode(string audioCode)
		{
			ResPackageInfo languageInfo = ResPackageInfo.GetLanguageInfo(audioCode);
			if (languageInfo != null)
			{
				languageInfo.DeleteLocalFiles();
				languageInfo.ClearRecord();
				LauncherLog.Instance.Info("RoleVoice package 已删除语言包: " + audioCode, default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			foreach (ValueTuple<string, ResPackageInfo> valueTuple in this.GetRoleVoicesByAudioCode(audioCode))
			{
				string item = valueTuple.Item1;
				ResPackageInfo item2 = valueTuple.Item2;
				item2.DeleteLocalFiles();
				item2.ClearRecord();
				LauncherLog.Instance.Info("RoleVoice package 已删除角色语音包: " + item, default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			LanguageUpdater updater = LanguageUpdateManager.Instance.GetUpdater(audioCode);
			if (updater != null)
			{
				updater.CalculateDownloadStatus("VoiceModule DeleteByAudioCode");
				updater.Status = ELanguageDownloadStatus.None;
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000366C8 File Offset: 0x000348C8
		private string GetAudioCodeFromPackKey(string packKey)
		{
			string[] array = packKey.Split('_', StringSplitOptions.None);
			return array[array.Length - 1];
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000366DC File Offset: 0x000348DC
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private List<ValueTuple<string, ResPackageInfo>> GetRoleVoicesByAudioCode(string audioCode)
		{
			List<ValueTuple<string, ResPackageInfo>> list = new List<ValueTuple<string, ResPackageInfo>>();
			foreach (KeyValuePair<string, ResPackageInfo> keyValuePair in ResPackageInfo.RoleVoiceInfos)
			{
				if (this.GetAudioCodeFromPackKey(keyValuePair.Key) == audioCode)
				{
					list.Add(new ValueTuple<string, ResPackageInfo>(keyValuePair.Key, keyValuePair.Value));
				}
			}
			return list;
		}

		// Token: 0x040003AD RID: 941
		private const long MB_SIZE = 1048576L;
	}
}
