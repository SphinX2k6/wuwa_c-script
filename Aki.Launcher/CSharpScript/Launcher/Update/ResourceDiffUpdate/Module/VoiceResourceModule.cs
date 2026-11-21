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
	// Token: 0x020000B1 RID: 177
	[NullableContext(1)]
	[Nullable(0)]
	public class VoiceResourceModule : BaseResourceModule
	{
		// Token: 0x0600061E RID: 1566 RVA: 0x00037C4C File Offset: 0x00035E4C
		[NullableContext(0)]
		public override UniTask<bool> PrepareManifests()
		{
			VoiceResourceModule.<PrepareManifests>d__1 <PrepareManifests>d__;
			<PrepareManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PrepareManifests>d__.<>1__state = -1;
			<PrepareManifests>d__.<>t__builder.Start<VoiceResourceModule.<PrepareManifests>d__1>(ref <PrepareManifests>d__);
			return <PrepareManifests>d__.<>t__builder.Task;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00037C88 File Offset: 0x00035E88
		public unsafe override PackClassification ClassifyPacks(ResourceSelectionContext context, ETier tier = ETier.None, bool forceMax = false)
		{
			HashSet<string> hashSet = new HashSet<string>(LauncherLanguageLib.Instance.GetUsedAudioCodes());
			bool flag = !this.IsVoiceDownloadEnable();
			List<ResPackageInfo> list = new List<ResPackageInfo>();
			long num = 0L;
			int num2 = 0;
			int num3 = 0;
			foreach (KeyValuePair<string, ResPackageInfo> keyValuePair in ResPackageInfo.RoleVoiceInfos)
			{
				string key = keyValuePair.Key;
				ResPackageInfo value = keyValuePair.Value;
				string audioCodeFromPackKey = this.GetAudioCodeFromPackKey(key);
				bool flag2 = hashSet.Contains(audioCodeFromPackKey);
				bool flag3 = !string.IsNullOrEmpty(value.ResourceVersionInfo.RecordVersion);
				if (flag || flag2 || flag3)
				{
					List<RequireFileInfo> item = value.AnalyzeRequireFiles(false, tier).Item1;
					long num4 = 0L;
					foreach (RequireFileInfo requireFileInfo in item)
					{
						num4 += requireFileInfo.Size;
					}
					if (flag2)
					{
						num2++;
					}
					else if (flag3)
					{
						num3++;
					}
					list.Add(value);
					num += num4;
				}
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "RoleVoice package 分类完成";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tier", tier);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("downloadAll", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("usedAudioCodes", ResourceUpdateUtils.FormatLogList<string>(hashSet));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("usedLanguage.count", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("existingOtherLanguage.count", num3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("count", list.Count);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6);
			string item2 = "totalSize";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendFormatted<long>(num / 1048576L);
			defaultInterpolatedStringHandler.AppendLiteral(" MB");
			ptr = new ValueTuple<string, object>(item2, defaultInterpolatedStringHandler.ToStringAndClear());
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
			return new PackClassification
			{
				MinPacks = list,
				MaxPacks = list,
				MinSize = num,
				MaxSize = num
			};
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00037EFC File Offset: 0x000360FC
		public bool IsVoiceDownloadEnable()
		{
			return VideoResUpdate.Instance.GetIsSeparateVideo() && !Platform.Instance.IsCloudGame() && !Platform.Instance.IsMacPlatform();
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00037F28 File Offset: 0x00036128
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

		// Token: 0x06000622 RID: 1570 RVA: 0x00037FB4 File Offset: 0x000361B4
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

		// Token: 0x06000623 RID: 1571 RVA: 0x0003802C File Offset: 0x0003622C
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

		// Token: 0x06000624 RID: 1572 RVA: 0x000380D0 File Offset: 0x000362D0
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

		// Token: 0x06000625 RID: 1573 RVA: 0x000381A8 File Offset: 0x000363A8
		private string GetAudioCodeFromPackKey(string packKey)
		{
			string[] array = packKey.Split('_', StringSplitOptions.None);
			return array[array.Length - 1];
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000381BC File Offset: 0x000363BC
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

		// Token: 0x040003DB RID: 987
		private const long MB_SIZE = 1048576L;
	}
}
