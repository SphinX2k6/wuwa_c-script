using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.RoleLangCustomModel
{
	// Token: 0x02004D7A RID: 19834
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleLangCustomUpdateManager
	{
		// Token: 0x06033430 RID: 209968 RVA: 0x00BF490D File Offset: 0x00BF2B0D
		public void Init()
		{
		}

		// Token: 0x06033431 RID: 209969 RVA: 0x00BF490F File Offset: 0x00BF2B0F
		public void Clear()
		{
			this.UpdaterMap.Clear();
			this.CreatingMap.Clear();
			this.CreatingPauseMap.Clear();
			this.RunningSet.Clear();
		}

		// Token: 0x06033432 RID: 209970 RVA: 0x00BF4940 File Offset: 0x00BF2B40
		public string GetPackageName(IRoleLangCustomLangPackageInfo info)
		{
			string roleLangStateGroup = RoleConfig.Instance.GetRoleLangStateGroup(info.RoleId);
			if (StringUtils.IsBlank(roleLangStateGroup))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Role;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "GetPackageName StateGroup 为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", info.RoleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return "";
			}
			string audioCode = LanguageSystem.Instance.GetLanguageDefineByType(info.LangIndex).AudioCode;
			return StringUtils.Format("{0}_{1}", new string[]
			{
				roleLangStateGroup,
				audioCode
			});
		}

		// Token: 0x06033433 RID: 209971 RVA: 0x00BF49CC File Offset: 0x00BF2BCC
		[NullableContext(0)]
		public UniTask<bool> StartDownload([Nullable(1)] IRoleLangCustomLangPackageInfo info)
		{
			RoleLangCustomUpdateManager.<StartDownload>d__10 <StartDownload>d__;
			<StartDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartDownload>d__.<>4__this = this;
			<StartDownload>d__.info = info;
			<StartDownload>d__.<>1__state = -1;
			<StartDownload>d__.<>t__builder.Start<RoleLangCustomUpdateManager.<StartDownload>d__10>(ref <StartDownload>d__);
			return <StartDownload>d__.<>t__builder.Task;
		}

		// Token: 0x06033434 RID: 209972 RVA: 0x00BF4A18 File Offset: 0x00BF2C18
		protected void CheckAllDownloadComplete(EResDownloadStatus state)
		{
			if (state == EResDownloadStatus.NoSpace)
			{
				double now = Time.Instance.Now;
				if (now - this.NoSpaceTime < 1000.0)
				{
					return;
				}
				this.NoSpaceTime = now;
				ScrollingTipsController.Instance.ShowTipsByTextId("VoiceDIY_Tips_OutOfMemory", Array.Empty<object>());
				return;
			}
			else
			{
				if (state != EResDownloadStatus.Down)
				{
					return;
				}
				List<string> list = new List<string>();
				foreach (KeyValuePair<string, ResourceDiffUpdater> keyValuePair in this.UpdaterMap)
				{
					if (keyValuePair.Value.UpdateStatus == EResDownloadStatus.Down)
					{
						list.Add(keyValuePair.Key);
					}
				}
				foreach (string key in list)
				{
					this.UpdaterMap.Remove(key);
				}
				using (Dictionary<string, ResourceDiffUpdater>.ValueCollection.Enumerator enumerator3 = this.UpdaterMap.Values.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						if (enumerator3.Current.UpdateStatus == EResDownloadStatus.Downloading)
						{
							return;
						}
					}
				}
				ScrollingTipsController.Instance.ShowTipsByTextId("Notice_VoiceDIY_Download_Success", Array.Empty<object>());
				return;
			}
		}

		// Token: 0x06033435 RID: 209973 RVA: 0x00BF4B70 File Offset: 0x00BF2D70
		public bool IsDownloading(IRoleLangCustomLangPackageInfo info)
		{
			string packageName = this.GetPackageName(info);
			if (this.CreatingMap.ContainsKey(packageName))
			{
				return !this.CreatingPauseMap.Contains(packageName);
			}
			ResourceDiffUpdater resourceDiffUpdater;
			return this.UpdaterMap.TryGetValue(packageName, out resourceDiffUpdater) && resourceDiffUpdater.UpdateStatus == EResDownloadStatus.Downloading;
		}

		// Token: 0x06033436 RID: 209974 RVA: 0x00BF4BC0 File Offset: 0x00BF2DC0
		public unsafe void PauseDownload(IRoleLangCustomLangPackageInfo info)
		{
			string packageName = this.GetPackageName(info);
			if (this.CreatingMap.ContainsKey(packageName))
			{
				this.CreatingPauseMap.Add(packageName);
				return;
			}
			ResourceDiffUpdater resourceDiffUpdater;
			if (!this.UpdaterMap.TryGetValue(packageName, out resourceDiffUpdater))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Role;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "PauseDownload 未找到 Updater";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", info.RoleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("langType", info.LangIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("name", packageName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			resourceDiffUpdater.Stop();
		}

		// Token: 0x06033437 RID: 209975 RVA: 0x00BF4C8C File Offset: 0x00BF2E8C
		public List<int> GetDownloadProgress(IRoleLangCustomLangPackageInfo info)
		{
			string packageName = this.GetPackageName(info);
			ResourceDiffUpdater resourceDiffUpdater;
			if (this.UpdaterMap.TryGetValue(packageName, out resourceDiffUpdater) && resourceDiffUpdater.UpdateStatus == EResDownloadStatus.Downloading && resourceDiffUpdater.ViewInfo != null)
			{
				return new List<int>
				{
					(int)resourceDiffUpdater.ViewInfo.SavedSize,
					(int)resourceDiffUpdater.ViewInfo.TotalSize
				};
			}
			ResPackageInfo roleVoiceInfo = ResPackageInfo.GetRoleVoiceInfo(packageName);
			if (roleVoiceInfo == null)
			{
				return new List<int>
				{
					0,
					1
				};
			}
			ValueTuple<long, long> valueTuple = roleVoiceInfo.CalculateSavedSizeAndTotalSize();
			long item = valueTuple.Item1;
			long item2 = valueTuple.Item2;
			return new List<int>
			{
				(int)item,
				(int)item2
			};
		}

		// Token: 0x06033438 RID: 209976 RVA: 0x00BF4D34 File Offset: 0x00BF2F34
		public long GetDownloadingSavedSizeTotal()
		{
			long num = 0L;
			foreach (ResourceDiffUpdater resourceDiffUpdater in this.UpdaterMap.Values)
			{
				if (resourceDiffUpdater.UpdateStatus == EResDownloadStatus.Downloading)
				{
					ResourceUpdateViewAgent viewInfo = resourceDiffUpdater.ViewInfo;
					if (viewInfo != null)
					{
						num += viewInfo.SavedSize;
					}
				}
			}
			return num;
		}

		// Token: 0x06033439 RID: 209977 RVA: 0x00BF4DA8 File Offset: 0x00BF2FA8
		public ELanguageDownloadStatus GetDownloadStatus(IRoleLangCustomLangPackageInfo info)
		{
			if (!ResourceDiffUpdaterManager.Instance.VoiceModule.IsVoiceDownloadEnable())
			{
				return ELanguageDownloadStatus.Done;
			}
			string packageName = this.GetPackageName(info);
			ResPackageInfo roleVoiceInfo = ResPackageInfo.GetRoleVoiceInfo(packageName);
			if (roleVoiceInfo != null && roleVoiceInfo.IsCompleteDownload())
			{
				return ELanguageDownloadStatus.Done;
			}
			if (this.CreatingMap.ContainsKey(packageName))
			{
				return ELanguageDownloadStatus.Half;
			}
			ResourceDiffUpdater resourceDiffUpdater;
			if (!this.UpdaterMap.TryGetValue(packageName, out resourceDiffUpdater))
			{
				return ELanguageDownloadStatus.None;
			}
			EResDownloadStatus updateStatus = resourceDiffUpdater.UpdateStatus;
			if (updateStatus - EResDownloadStatus.Downloading <= 1)
			{
				return ELanguageDownloadStatus.Half;
			}
			if (updateStatus != EResDownloadStatus.Down)
			{
				return ELanguageDownloadStatus.None;
			}
			return ELanguageDownloadStatus.Done;
		}

		// Token: 0x0603343A RID: 209978 RVA: 0x00BF4E20 File Offset: 0x00BF3020
		public void DeletePackage(List<IRoleLangCustomLangPackageInfo> infoList)
		{
			List<string> list = new List<string>();
			foreach (IRoleLangCustomLangPackageInfo info in infoList)
			{
				string packageName = this.GetPackageName(info);
				ResourceDiffUpdater resourceDiffUpdater;
				if (this.UpdaterMap.TryGetValue(packageName, out resourceDiffUpdater))
				{
					if (resourceDiffUpdater.UpdateStatus == EResDownloadStatus.Downloading)
					{
						resourceDiffUpdater.Stop();
					}
					this.UpdaterMap.Remove(packageName);
				}
				list.Add(packageName);
			}
			ResourceDiffUpdaterManager.Instance.VoiceModule.Delete(list);
		}

		// Token: 0x0603343B RID: 209979 RVA: 0x00BF4EBC File Offset: 0x00BF30BC
		public bool IsListDownloading()
		{
			if (this.ListCreating != null)
			{
				return !this.ListCreatingPaused;
			}
			ResourceDiffUpdater listUpdater = this.ListUpdater;
			return listUpdater != null && listUpdater.UpdateStatus == EResDownloadStatus.Downloading;
		}

		// Token: 0x0603343C RID: 209980 RVA: 0x00BF4EE4 File Offset: 0x00BF30E4
		private List<string> GetListPackageNames(List<IRoleLangCustomLangPackageInfo> infoList)
		{
			List<string> list = new List<string>();
			foreach (IRoleLangCustomLangPackageInfo info in infoList)
			{
				string packageName = this.GetPackageName(info);
				if (!StringUtils.IsBlank(packageName))
				{
					list.Add(packageName);
				}
			}
			return list;
		}

		// Token: 0x0603343D RID: 209981 RVA: 0x00BF4F4C File Offset: 0x00BF314C
		[NullableContext(0)]
		public UniTask<bool> StartDownloadList([Nullable(1)] List<IRoleLangCustomLangPackageInfo> infoList)
		{
			RoleLangCustomUpdateManager.<StartDownloadList>d__23 <StartDownloadList>d__;
			<StartDownloadList>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartDownloadList>d__.<>4__this = this;
			<StartDownloadList>d__.infoList = infoList;
			<StartDownloadList>d__.<>1__state = -1;
			<StartDownloadList>d__.<>t__builder.Start<RoleLangCustomUpdateManager.<StartDownloadList>d__23>(ref <StartDownloadList>d__);
			return <StartDownloadList>d__.<>t__builder.Task;
		}

		// Token: 0x0603343E RID: 209982 RVA: 0x00BF4F98 File Offset: 0x00BF3198
		public void PauseDownloadList()
		{
			if (this.ListCreating != null)
			{
				this.ListCreatingPaused = true;
				return;
			}
			if (this.ListUpdater == null)
			{
				Log.Instance.Error(ELogModule.Role, ELogAuthor.WHJ, "PauseDownloadList 未找到 ListUpdater", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.ListUpdater.Stop();
		}

		// Token: 0x0603343F RID: 209983 RVA: 0x00BF4FE8 File Offset: 0x00BF31E8
		public void DeletePackageList(List<IRoleLangCustomLangPackageInfo> infoList)
		{
			List<string> listPackageNames = this.GetListPackageNames(infoList);
			if (this.ListUpdater != null)
			{
				if (this.ListUpdater.UpdateStatus == EResDownloadStatus.Downloading)
				{
					this.ListUpdater.Stop();
				}
				this.ListUpdater = null;
			}
			this.ListCreatingPaused = false;
			if (listPackageNames.Count == 0)
			{
				return;
			}
			ResourceDiffUpdaterManager.Instance.VoiceModule.Delete(listPackageNames);
		}

		// Token: 0x0401B344 RID: 111428
		private const string PACKAGE_NAME = "{0}_{1}";

		// Token: 0x0401B345 RID: 111429
		private const int COOLDOWNTIME = 1000;

		// Token: 0x0401B346 RID: 111430
		private readonly Dictionary<string, ResourceDiffUpdater> UpdaterMap = new Dictionary<string, ResourceDiffUpdater>();

		// Token: 0x0401B347 RID: 111431
		[Nullable(new byte[]
		{
			1,
			1,
			1,
			2
		})]
		private readonly Dictionary<string, UniTaskCompletionSource<ResourceDiffUpdater>> CreatingMap = new Dictionary<string, UniTaskCompletionSource<ResourceDiffUpdater>>();

		// Token: 0x0401B348 RID: 111432
		private readonly HashSet<string> CreatingPauseMap = new HashSet<string>();

		// Token: 0x0401B349 RID: 111433
		private readonly HashSet<string> RunningSet = new HashSet<string>();

		// Token: 0x0401B34A RID: 111434
		protected double NoSpaceTime;

		// Token: 0x0401B34B RID: 111435
		[Nullable(2)]
		private ResourceDiffUpdater ListUpdater;

		// Token: 0x0401B34C RID: 111436
		[Nullable(2)]
		private UniTaskCompletionSource<ResourceDiffUpdater> ListCreating;

		// Token: 0x0401B34D RID: 111437
		private bool ListCreatingPaused;
	}
}
