using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel
{
	// Token: 0x02004D79 RID: 19833
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RoleLangCustomModel : ModelBase
	{
		// Token: 0x06033402 RID: 209922 RVA: 0x00BF3306 File Offset: 0x00BF1506
		protected override bool OnInit()
		{
			this.UpdateManager = new RoleLangCustomUpdateManager();
			this.UpdateManager.Init();
			return true;
		}

		// Token: 0x06033403 RID: 209923 RVA: 0x00BF331F File Offset: 0x00BF151F
		protected override bool OnClear()
		{
			this.UpdateManager.Clear();
			return true;
		}

		// Token: 0x06033404 RID: 209924 RVA: 0x00BF332D File Offset: 0x00BF152D
		public RoleLangCustomUpdateManager GetUpdateManager()
		{
			return this.UpdateManager;
		}

		// Token: 0x06033405 RID: 209925 RVA: 0x00BF3338 File Offset: 0x00BF1538
		public bool CheckPackageAudioDownloading(int audioType)
		{
			string audioCodeById = GameSettingsManager.Instance.GetAudioCodeById(audioType);
			if (StringUtils.IsBlank(audioCodeById))
			{
				return false;
			}
			LanguageUpdater updater = LanguageUpdateManager.Instance.GetUpdater(audioCodeById);
			return updater != null && updater.IsDownloading;
		}

		// Token: 0x06033406 RID: 209926 RVA: 0x00BF3374 File Offset: 0x00BF1574
		public List<RoleInstance> GetRoleList()
		{
			List<RoleInstance> list = new List<RoleInstance>();
			foreach (RoleInstance roleInstance in RoleModel.Instance.GetRoleList())
			{
				if (!StringUtils.IsBlank(RoleConfig.Instance.GetRoleLangStateGroup(roleInstance.GetRoleId())))
				{
					list.Add(roleInstance);
				}
			}
			return list;
		}

		// Token: 0x06033407 RID: 209927 RVA: 0x00BF33C3 File Offset: 0x00BF15C3
		public bool GetCanSetCustom()
		{
			return this.CanSetCustom;
		}

		// Token: 0x06033408 RID: 209928 RVA: 0x00BF33CB File Offset: 0x00BF15CB
		public bool GetStartLoadingInited()
		{
			return this.StartLoadingInited;
		}

		// Token: 0x06033409 RID: 209929 RVA: 0x00BF33D3 File Offset: 0x00BF15D3
		public bool NeedDeleteButton()
		{
			return ResourceDiffUpdaterManager.Instance.VoiceModule.IsVoiceDownloadEnable() && GameSettingsManager.Instance.IsValid(EFunction.VOICEPACKMANAGER, true);
		}

		// Token: 0x0603340A RID: 209930 RVA: 0x00BF33F8 File Offset: 0x00BF15F8
		public unsafe void CheckAndApplyPlayerVoiceAll()
		{
			bool global = LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.RoleLangCustomNeedCover, false);
			string packageAudio = LanguageSystem.Instance.PackageAudio;
			int languageTypeByAudioCode = LanguageSystem.Instance.GetLanguageTypeByAudioCode(packageAudio);
			Dictionary<int, int> dictionary = this.CleanLegacyRoleVoiceMap(LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoleVoiceMap, null) ?? new Dictionary<int, int>());
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "PlayerVoice CheckAndApplyPlayerVoiceAll 进入";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("coverAll", global);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CanSetCustom", this.CanSetCustom);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StartLoadingInited", this.StartLoadingInited);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("NeedCoverAllPlayer", this.NeedCoverAllPlayer);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("packageAudioCode", packageAudio);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("packageLangType", languageTypeByAudioCode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("roleVoiceMap", JsonSerializer.Serialize<Dictionary<int, int>>(dictionary, null));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
			LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.RoleLangCustomNeedCover, false);
			if (global)
			{
				this.NeedCoverAllPlayer = true;
				Log.Instance.Info(ELogModule.Role, ELogAuthor.WHJ, "PlayerVoice CheckAndApplyPlayerVoiceAll 命中 coverAll，转交 ApplyPlayerVoiceAll", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ApplyPlayerVoiceAll();
				return;
			}
			this.StartLoadingInited = true;
			int num = languageTypeByAudioCode;
			IReadOnlyList<RoleInfo> readOnlyList = RoleConfig.Instance.GetRoleListByType(ERoleType.Common) ?? new List<RoleInfo>();
			Dictionary<int, int> dictionary2 = dictionary;
			List<int> list = new List<int>();
			foreach (RoleInfo roleInfo in readOnlyList)
			{
				int realId = this.GetRealId(roleInfo.Id);
				int langIndex = dictionary2.ContainsKey(realId) ? dictionary2[realId] : num;
				bool flag = this.CheckAudioPackageValid(new RoleLangCustomLangPackageInfo
				{
					RoleId = roleInfo.Id,
					LangIndex = langIndex
				});
				this.ApplyPlayerVoice(roleInfo.Id, !flag);
				if (!flag)
				{
					list.Add(roleInfo.Id);
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Role;
			ELogAuthor author2 = ELogAuthor.WHJ;
			string message2 = "PlayerVoice CheckAndApplyPlayerVoiceAll 完成";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("allRoleCount", readOnlyList.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("coverRoleCount", list.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("coverRoleList", JsonSerializer.Serialize<List<int>>(list, null));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("fallbackLangType", num);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			if (list.Count > 0)
			{
				this.SystemSettingLogReport(num, ERoleLangLogReportType.NoResource, list.Count == readOnlyList.Count);
			}
		}

		// Token: 0x0603340B RID: 209931 RVA: 0x00BF3718 File Offset: 0x00BF1918
		private Dictionary<int, int> CleanLegacyRoleVoiceMap(Dictionary<int, int> roleMap)
		{
			bool flag = false;
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (KeyValuePair<int, int> keyValuePair in roleMap)
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int key = num;
				int num3 = num2;
				try
				{
					LanguageSystem.Instance.GetLanguageDefineByType(num3);
				}
				catch
				{
					flag = true;
					continue;
				}
				dictionary[key] = num3;
			}
			if (flag)
			{
				Log.Instance.Info(ELogModule.Role, ELogAuthor.WHJ, "PlayerVoice 清理旧格式 RoleVoiceMap", default(ReadOnlySpan<ValueTuple<string, object>>));
				LocalStorage.SetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoleVoiceMap, dictionary);
			}
			return dictionary;
		}

		// Token: 0x0603340C RID: 209932 RVA: 0x00BF37D0 File Offset: 0x00BF19D0
		public bool CheckAudioPackageValid(IRoleLangCustomLangPackageInfo info)
		{
			return !UKuroLauncherLibrary.NeedHotPatch() || !ResourceDiffUpdaterManager.Instance.VoiceModule.IsVoiceDownloadEnable() || this.UpdateManager.GetDownloadStatus(info) == ELanguageDownloadStatus.Done;
		}

		// Token: 0x0603340D RID: 209933 RVA: 0x00BF37FC File Offset: 0x00BF19FC
		public unsafe void ApplyPlayerVoiceAll()
		{
			string packageAudio = LanguageSystem.Instance.PackageAudio;
			int languageTypeByAudioCode = LanguageSystem.Instance.GetLanguageTypeByAudioCode(packageAudio);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "PlayerVoice ApplyPlayerVoiceAll 进入";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CanSetCustom", this.CanSetCustom);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StartLoadingInited", this.StartLoadingInited);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("NeedCoverAllPlayer", this.NeedCoverAllPlayer);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("packageAudioCode", packageAudio);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("packageLangType", languageTypeByAudioCode);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			if (!this.GetCanSetCustom())
			{
				Log.Instance.Info(ELogModule.Role, ELogAuthor.WHJ, "PlayerVoice ApplyPlayerVoiceAll 提前退出：CanSetCustom 为 false", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			bool needCoverAllPlayer = this.NeedCoverAllPlayer;
			this.NeedCoverAllPlayer = false;
			IReadOnlyList<RoleInfo> readOnlyList = RoleConfig.Instance.GetRoleListByType(ERoleType.Common) ?? new List<RoleInfo>();
			if (needCoverAllPlayer)
			{
				this.ClearAllMark();
			}
			foreach (RoleInfo roleInfo in readOnlyList)
			{
				this.ApplyPlayerVoice(roleInfo.Id, needCoverAllPlayer);
			}
			if (this.StartLoadingInited)
			{
				Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoleVoiceMap, null) ?? new Dictionary<int, int>();
				List<RoleVoiceSetting> list = new List<RoleVoiceSetting>();
				HashSet<int> hashSet = new HashSet<int>();
				foreach (RoleInfo roleInfo2 in readOnlyList)
				{
					int id = roleInfo2.Id;
					int realId = this.GetRealId(id);
					if (!dictionary.ContainsKey(realId) && !hashSet.Contains(realId) && (RoleModel.Instance.IsMainRole(id) || RoleModel.Instance.GetRoleDataById(id, true) != null))
					{
						RoleVoiceSetting roleVoiceSetting = RoleVoiceSetting.Create();
						roleVoiceSetting.RoleId = realId;
						int languageTypeByAudioCode2 = LanguageSystem.Instance.GetLanguageTypeByAudioCode(LanguageSystem.Instance.PackageAudio);
						roleVoiceSetting.VoiceLanguage = languageTypeByAudioCode2;
						list.Add(roleVoiceSetting);
						hashSet.Add(realId);
					}
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Role;
				ELogAuthor author2 = ELogAuthor.WHJ;
				string message2 = "PlayerVoice ApplyPlayerVoiceAll 上报服务器";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("needCoverAll", needCoverAllPlayer);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("allRoleCount", readOnlyList.Count);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("uploadCount", list.Count);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				RoleController.Instance.RequestPlayerRoleVoiceSet(list);
			}
			else
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Role;
				ELogAuthor author3 = ELogAuthor.WHJ;
				string message3 = "PlayerVoice ApplyPlayerVoiceAll 跳过上报：StartLoadingInited 为 false";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("needCoverAll", needCoverAllPlayer);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("allRoleCount", readOnlyList.Count);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			}
			this.StartLoadingInited = true;
			int num = languageTypeByAudioCode;
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Role;
			ELogAuthor author4 = ELogAuthor.WHJ;
			string message4 = "PlayerVoice ApplyPlayerVoiceAll 完成";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("langType", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("needCoverAll", needCoverAllPlayer);
			instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
			this.SystemSettingLogReport(num, ERoleLangLogReportType.Player, needCoverAllPlayer);
		}

		// Token: 0x0603340E RID: 209934 RVA: 0x00BF3BD4 File Offset: 0x00BF1DD4
		public void GetServerVoiceData(List<RoleVoice> serverData)
		{
			this.ServerVoiceData.Clear();
			foreach (RoleVoice roleVoice in serverData)
			{
				this.ServerVoiceData[roleVoice.RoleId] = roleVoice.VoiceId;
			}
			this.HasCheckServer = true;
		}

		// Token: 0x0603340F RID: 209935 RVA: 0x00BF3C44 File Offset: 0x00BF1E44
		public bool CheckServerVoiceDataSame(bool fromSettingAll = false)
		{
			if (this.HasConfirm || (this.HasCheckServer && this.ServerVoiceData.Count == 0))
			{
				return true;
			}
			bool flag = false;
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoleLangCustomRecord, null) ?? new HashSet<int>();
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoleLangCustomRecord) as ServerStorageSet;
			if (hashSet.Count != serverStorageSet.Size())
			{
				flag = true;
			}
			else
			{
				foreach (int value in hashSet)
				{
					if (!serverStorageSet.Has(value))
					{
						flag = true;
						break;
					}
				}
			}
			Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoleVoiceMap, null) ?? new Dictionary<int, int>();
			if (!flag)
			{
				foreach (int key in serverStorageSet.GetContainer())
				{
					if (!this.ServerVoiceData.ContainsKey(key))
					{
						flag = true;
						break;
					}
					if (!dictionary.ContainsKey(key))
					{
						flag = true;
						break;
					}
					int num = this.ServerVoiceData[key];
					if (dictionary[key] != num)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				this.HasConfirm = true;
				return true;
			}
			if (CloudGameManager.Instance.IsCloudGame)
			{
				this.OnClickedConfirmConfirm();
				return true;
			}
			this.ConfirmViewMask.SetMask("RoleLangNetConfirmPop", true);
			UiManager.Instance.OpenView(EUiViewName.RoleLangNetConfirmPop, fromSettingAll, delegate(bool _, int viewId)
			{
				if (!fromSettingAll && UiManager.Instance.GetViewByName(EUiViewName.RoleRootView) != null)
				{
					UiManager.Instance.GetViewByName(EUiViewName.RoleRootView).AddChildViewById(viewId);
				}
				else if (fromSettingAll && UiManager.Instance.GetViewByName(EUiViewName.RoleLangCustomView) != null)
				{
					UiManager.Instance.GetViewByName(EUiViewName.RoleLangCustomView).AddChildViewById(viewId);
				}
				this.ConfirmViewMask.SetMask("RoleLangNetConfirmPop", false);
			});
			return false;
		}

		// Token: 0x06033410 RID: 209936 RVA: 0x00BF3DFC File Offset: 0x00BF1FFC
		public List<IRoleLangCustomLangPackageInfo> CheckNoResourceInfo()
		{
			List<IRoleLangCustomLangPackageInfo> list = new List<IRoleLangCustomLangPackageInfo>();
			HashSet<int> hashSet = new HashSet<int>();
			Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoleVoiceMap, null) ?? new Dictionary<int, int>();
			foreach (int num in (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoleLangCustomRecord) as ServerStorageSet).GetContainer())
			{
				if (!hashSet.Contains(num) && this.ServerVoiceData.ContainsKey(num))
				{
					int num2 = this.ServerVoiceData[num];
					if (!dictionary.ContainsKey(num) || dictionary[num] != num2)
					{
						int roleIdByRealId = this.GetRoleIdByRealId(num);
						RoleLangCustomLangPackageInfo roleLangCustomLangPackageInfo = new RoleLangCustomLangPackageInfo
						{
							RoleId = roleIdByRealId,
							LangIndex = num2
						};
						if (!this.CheckAudioPackageValid(roleLangCustomLangPackageInfo))
						{
							list.Add(roleLangCustomLangPackageInfo);
							hashSet.Add(num);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06033411 RID: 209937 RVA: 0x00BF3EFC File Offset: 0x00BF20FC
		protected int GetRealId(int roleId)
		{
			int result = roleId;
			if (RoleModel.Instance.IsMainRole(roleId))
			{
				result = RoleConfig.Instance.GetMainRoleById(roleId).Value.Gender;
			}
			return result;
		}

		// Token: 0x06033412 RID: 209938 RVA: 0x00BF3F38 File Offset: 0x00BF2138
		protected int GetRoleIdByRealId(int realRoleId)
		{
			if (realRoleId != 0 && realRoleId != 1)
			{
				return realRoleId;
			}
			return RoleConfig.Instance.GetMainRoleByGender((LoginDefine.ELoginSex)realRoleId)[0].Id;
		}

		// Token: 0x06033413 RID: 209939 RVA: 0x00BF3F6C File Offset: 0x00BF216C
		public void OnClickedConfirmClose()
		{
			this.HasConfirm = true;
			Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoleVoiceMap, null) ?? new Dictionary<int, int>();
			List<RoleVoiceSetting> list = new List<RoleVoiceSetting>();
			HashSet<int> hashSet = new HashSet<int>();
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int roleId = num;
				int voiceLanguage = num2;
				RoleVoiceSetting roleVoiceSetting = RoleVoiceSetting.Create();
				roleVoiceSetting.RoleId = roleId;
				roleVoiceSetting.VoiceLanguage = voiceLanguage;
				list.Add(roleVoiceSetting);
			}
			foreach (RoleInfo roleInfo in (RoleConfig.Instance.GetRoleListByType(ERoleType.Common) ?? new List<RoleInfo>()))
			{
				int id = roleInfo.Id;
				int realId = this.GetRealId(id);
				if (!dictionary.ContainsKey(realId) && !hashSet.Contains(realId) && (RoleModel.Instance.IsMainRole(id) || RoleModel.Instance.GetRoleInstanceById(id) != null))
				{
					RoleVoiceSetting roleVoiceSetting2 = RoleVoiceSetting.Create();
					roleVoiceSetting2.RoleId = realId;
					int languageTypeByAudioCode = LanguageSystem.Instance.GetLanguageTypeByAudioCode(LanguageSystem.Instance.PackageAudio);
					roleVoiceSetting2.VoiceLanguage = languageTypeByAudioCode;
					list.Add(roleVoiceSetting2);
					hashSet.Add(realId);
				}
			}
			RoleController.Instance.RequestPlayerRoleVoiceSet(list).ContinueWith(delegate(bool value)
			{
				if (!value)
				{
					return;
				}
				HashSet<int> values = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoleLangCustomRecord, null) ?? new HashSet<int>();
				(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoleLangCustomRecord) as ServerStorageSet).Overwrite(values);
			}).Forget();
		}

		// Token: 0x06033414 RID: 209940 RVA: 0x00BF4118 File Offset: 0x00BF2318
		public void OnClickedConfirmConfirm()
		{
			this.HasConfirm = true;
			HashSet<int> hashSet = new HashSet<int>((ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoleLangCustomRecord) as ServerStorageSet).GetContainer());
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoleLangCustomRecord, hashSet);
			foreach (int num in hashSet)
			{
				int lang = this.ServerVoiceData[num];
				int roleIdByRealId = this.GetRoleIdByRealId(num);
				RoleLangSetVoiceParam playerVoice = new RoleLangSetVoiceParam
				{
					RoleId = roleIdByRealId,
					Lang = lang,
					NeedRequest = false,
					IsCustom = true,
					IsCover = false
				};
				this.SetPlayerVoice(playerVoice);
			}
			int languageTypeByAudioCode = LanguageSystem.Instance.GetLanguageTypeByAudioCode(LanguageSystem.Instance.PackageAudio);
			foreach (RoleInfo roleInfo in (RoleConfig.Instance.GetRoleListByType(ERoleType.Common) ?? new List<RoleInfo>()))
			{
				int id = roleInfo.Id;
				if (!hashSet.Contains(this.GetRealId(id)))
				{
					RoleLangSetVoiceParam playerVoice2 = new RoleLangSetVoiceParam
					{
						RoleId = id,
						Lang = languageTypeByAudioCode,
						NeedRequest = false,
						IsCustom = false,
						IsCover = true
					};
					this.SetPlayerVoice(playerVoice2);
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RoleLangCustomRefresh, -1);
		}

		// Token: 0x06033415 RID: 209941 RVA: 0x00BF4294 File Offset: 0x00BF2494
		public UniTask RequestServerVoiceData()
		{
			RoleLangCustomModel.<RequestServerVoiceData>d__29 <RequestServerVoiceData>d__;
			<RequestServerVoiceData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestServerVoiceData>d__.<>4__this = this;
			<RequestServerVoiceData>d__.<>1__state = -1;
			<RequestServerVoiceData>d__.<>t__builder.Start<RoleLangCustomModel.<RequestServerVoiceData>d__29>(ref <RequestServerVoiceData>d__);
			return <RequestServerVoiceData>d__.<>t__builder.Task;
		}

		// Token: 0x06033416 RID: 209942 RVA: 0x00BF42D8 File Offset: 0x00BF24D8
		public void ApplyPlayerVoice(int roleId, bool cover = false)
		{
			if (StringUtils.IsBlank(RoleConfig.Instance.GetRoleLangStateGroup(roleId)))
			{
				return;
			}
			if (cover)
			{
				RoleLangSetVoiceParam playerVoice = new RoleLangSetVoiceParam
				{
					RoleId = roleId,
					Lang = LanguageSystem.Instance.GetLanguageTypeByAudioCode(LanguageSystem.Instance.PackageAudio),
					NeedRequest = false,
					IsCustom = false,
					IsCover = true
				};
				this.SetPlayerVoice(playerVoice);
				return;
			}
			int realId = this.GetRealId(roleId);
			Dictionary<int, int> player = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoleVoiceMap, null);
			int lang;
			if (player == null || !player.ContainsKey(realId))
			{
				lang = LanguageSystem.Instance.GetLanguageTypeByAudioCode(LanguageSystem.Instance.PackageAudio);
			}
			else
			{
				lang = player[realId];
			}
			RoleLangSetVoiceParam playerVoice2 = new RoleLangSetVoiceParam
			{
				RoleId = roleId,
				Lang = lang,
				NeedRequest = false,
				IsCustom = false,
				IsCover = cover
			};
			this.SetPlayerVoice(playerVoice2);
		}

		// Token: 0x06033417 RID: 209943 RVA: 0x00BF43B0 File Offset: 0x00BF25B0
		public unsafe void SetPlayerVoice(IRoleLangSetVoiceParam param)
		{
			int roleId = param.RoleId;
			bool needRequest = param.NeedRequest;
			bool isCustom = param.IsCustom;
			bool isCover = param.IsCover;
			string roleLangStateGroup = RoleConfig.Instance.GetRoleLangStateGroup(roleId);
			Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoleVoiceMap, null) ?? new Dictionary<int, int>();
			if (StringUtils.IsBlank(roleLangStateGroup))
			{
				return;
			}
			if (isCustom)
			{
				this.MarkRoleNeedCustom(roleId);
			}
			else if (isCover)
			{
				this.RemoveRoleMark(roleId);
			}
			int lang = param.Lang;
			int realId = this.GetRealId(roleId);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "PlayerVoice 切换语音";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("languageCode", lang);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isCustom", isCustom);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("isCover", isCover);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			if (isCustom)
			{
				dictionary[realId] = lang;
			}
			else if (isCover)
			{
				dictionary.Remove(realId);
			}
			global::LanguageDefine languageDefineByType = LanguageSystem.Instance.GetLanguageDefineByType(lang);
			AudioSystem.Instance.SetState(roleLangStateGroup, languageDefineByType.AudioCode, false);
			if (isCustom || isCover)
			{
				LocalStorage.SetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoleVoiceMap, dictionary);
			}
			RoleVoiceSetting roleVoiceSetting = RoleVoiceSetting.Create();
			roleVoiceSetting.RoleId = realId;
			roleVoiceSetting.VoiceLanguage = this.GetRoleLangType(roleId);
			if (needRequest)
			{
				RoleController.Instance.RequestPlayerRoleVoiceSet(new List<RoleVoiceSetting>
				{
					roleVoiceSetting
				});
			}
			EventSystem.Instance.Emit<int>(EEventName.RoleLangCustomRefresh, roleId);
		}

		// Token: 0x06033418 RID: 209944 RVA: 0x00BF4560 File Offset: 0x00BF2760
		public void MarkRoleNeedCustom(int roleId)
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoleLangCustomRecord, null) ?? new HashSet<int>();
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoleLangCustomRecord) as ServerStorageSet;
			int realId = this.GetRealId(roleId);
			hashSet.Add(realId);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoleLangCustomRecord, hashSet);
			serverStorageSet.Add(realId);
		}

		// Token: 0x06033419 RID: 209945 RVA: 0x00BF45B8 File Offset: 0x00BF27B8
		public void RemoveRoleMark(int roleId)
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoleLangCustomRecord, null) ?? new HashSet<int>();
			int realId = this.GetRealId(roleId);
			hashSet.Remove(realId);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoleLangCustomRecord, hashSet);
			if (this.HasConfirm)
			{
				(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoleLangCustomRecord) as ServerStorageSet).Remove(realId);
			}
		}

		// Token: 0x0603341A RID: 209946 RVA: 0x00BF4615 File Offset: 0x00BF2815
		public bool CheckIsMark(int roleId)
		{
			return (LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoleLangCustomRecord, null) ?? new HashSet<int>()).Contains(this.GetRealId(roleId));
		}

		// Token: 0x0603341B RID: 209947 RVA: 0x00BF4637 File Offset: 0x00BF2837
		public void ClearAllMark()
		{
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RoleLangCustomRecord, new HashSet<int>());
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoleLangCustomRecord) as ServerStorageSet).Overwrite(new HashSet<int>());
		}

		// Token: 0x0603341C RID: 209948 RVA: 0x00BF4664 File Offset: 0x00BF2864
		public int GetRoleLangType(int roleId)
		{
			if (StringUtils.IsBlank(RoleConfig.Instance.GetRoleLangStateGroup(roleId)))
			{
				return LanguageSystem.Instance.GetLanguageTypeByAudioCode(LanguageSystem.Instance.PackageAudio);
			}
			Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoleVoiceMap, null) ?? new Dictionary<int, int>();
			int realId = this.GetRealId(roleId);
			int num = dictionary.ContainsKey(realId) ? dictionary[realId] : -1;
			if (num == -1)
			{
				return LanguageSystem.Instance.GetLanguageTypeByAudioCode(LanguageSystem.Instance.PackageAudio);
			}
			return num;
		}

		// Token: 0x0603341D RID: 209949 RVA: 0x00BF46E4 File Offset: 0x00BF28E4
		public UniTask UploadAllPlayerVoiceLanguage()
		{
			RoleLangCustomModel.<UploadAllPlayerVoiceLanguage>d__37 <UploadAllPlayerVoiceLanguage>d__;
			<UploadAllPlayerVoiceLanguage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UploadAllPlayerVoiceLanguage>d__.<>1__state = -1;
			<UploadAllPlayerVoiceLanguage>d__.<>t__builder.Start<RoleLangCustomModel.<UploadAllPlayerVoiceLanguage>d__37>(ref <UploadAllPlayerVoiceLanguage>d__);
			return <UploadAllPlayerVoiceLanguage>d__.<>t__builder.Task;
		}

		// Token: 0x0603341E RID: 209950 RVA: 0x00BF471F File Offset: 0x00BF291F
		public ELanguageDownloadStatus GetDownloadStatus(IRoleLangCustomLangPackageInfo info)
		{
			if (!UKuroLauncherLibrary.NeedHotPatch() || !ResourceDiffUpdaterManager.Instance.VoiceModule.IsVoiceDownloadEnable())
			{
				return ELanguageDownloadStatus.Done;
			}
			return this.UpdateManager.GetDownloadStatus(info);
		}

		// Token: 0x0603341F RID: 209951 RVA: 0x00BF4747 File Offset: 0x00BF2947
		public List<int> GetDownloadProgress(int roleId, int langType)
		{
			return this.UpdateManager.GetDownloadProgress(new RoleLangCustomLangPackageInfo
			{
				RoleId = roleId,
				LangIndex = langType
			});
		}

		// Token: 0x06033420 RID: 209952 RVA: 0x00BF4767 File Offset: 0x00BF2967
		public void StartDownloading(IRoleLangCustomLangPackageInfo info)
		{
			this.UpdateManager.StartDownload(info);
		}

		// Token: 0x06033421 RID: 209953 RVA: 0x00BF4776 File Offset: 0x00BF2976
		public void PauseDownloading(IRoleLangCustomLangPackageInfo info)
		{
			this.UpdateManager.PauseDownload(info);
		}

		// Token: 0x06033422 RID: 209954 RVA: 0x00BF4784 File Offset: 0x00BF2984
		public void StartDownloadingList(List<IRoleLangCustomLangPackageInfo> infoList)
		{
			this.UpdateManager.StartDownloadList(infoList);
		}

		// Token: 0x06033423 RID: 209955 RVA: 0x00BF4793 File Offset: 0x00BF2993
		public void PauseDownloadingList()
		{
			this.UpdateManager.PauseDownloadList();
		}

		// Token: 0x06033424 RID: 209956 RVA: 0x00BF47A0 File Offset: 0x00BF29A0
		public bool IsListDownloading()
		{
			return this.UpdateManager.IsListDownloading();
		}

		// Token: 0x06033425 RID: 209957 RVA: 0x00BF47AD File Offset: 0x00BF29AD
		public void DeletePackageList(List<IRoleLangCustomLangPackageInfo> infoList)
		{
			this.UpdateManager.DeletePackageList(infoList);
		}

		// Token: 0x06033426 RID: 209958 RVA: 0x00BF47BC File Offset: 0x00BF29BC
		public bool CheckSpaceEnough(IRoleLangCustomLangPackageInfo info)
		{
			string packageName = this.UpdateManager.GetPackageName(info);
			string checkPath = UKuroLauncherLibrary.GameSavedDir();
			long num = 0L;
			UKuroLauncherLibrary.GetTotalAndFreeSpace(checkPath, ref num);
			long num2 = num;
			long num3 = 0L;
			ResPackageInfo roleVoiceInfo = ResPackageInfo.GetRoleVoiceInfo(packageName);
			if (roleVoiceInfo != null)
			{
				ValueTuple<long, long> valueTuple = roleVoiceInfo.CalculateSavedSizeAndTotalSize();
				long item = valueTuple.Item1;
				num3 = valueTuple.Item2 - item;
			}
			return num2 >= num3 + 10485760L;
		}

		// Token: 0x06033427 RID: 209959 RVA: 0x00BF4818 File Offset: 0x00BF2A18
		public int PlayVoiceOnSetVoice(int roleId)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			RoleSkinAudio? roleConfig = AudioConfig.Instance.GetRoleConfig(roleDataById.GetRoleSkinId());
			return AudioSystem.Instance.PostEvent(roleConfig.Value.JoinTeamEvent);
		}

		// Token: 0x06033428 RID: 209960 RVA: 0x00BF485C File Offset: 0x00BF2A5C
		public void SystemSettingLogReport(int lang, ERoleLangLogReportType type, bool isAll)
		{
			RoleLangCustomSettingEvent roleLangCustomSettingEvent = new RoleLangCustomSettingEvent();
			roleLangCustomSettingEvent.i_language = lang;
			roleLangCustomSettingEvent.i_way = (int)type;
			roleLangCustomSettingEvent.i_cover = (isAll ? 1 : 2);
			LogReportController.Instance.LogReport(roleLangCustomSettingEvent);
		}

		// Token: 0x17007E7F RID: 32383
		// (get) Token: 0x06033429 RID: 209961 RVA: 0x00BF4895 File Offset: 0x00BF2A95
		public static RoleLangCustomModel Instance
		{
			get
			{
				return RoleLangCustomModel._Instance;
			}
		}

		// Token: 0x0603342A RID: 209962 RVA: 0x00BF489C File Offset: 0x00BF2A9C
		public static RoleLangCustomModel GetOrCreateInstance()
		{
			if (RoleLangCustomModel._Instance == null)
			{
				RoleLangCustomModel.CreateInstance();
			}
			return RoleLangCustomModel._Instance;
		}

		// Token: 0x0603342B RID: 209963 RVA: 0x00BF48B0 File Offset: 0x00BF2AB0
		public static bool CreateInstance()
		{
			if (RoleLangCustomModel._Instance != null)
			{
				return true;
			}
			RoleLangCustomModel._Instance = new RoleLangCustomModel();
			return true;
		}

		// Token: 0x0603342C RID: 209964 RVA: 0x00BF48C6 File Offset: 0x00BF2AC6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603342D RID: 209965 RVA: 0x00BF48C8 File Offset: 0x00BF2AC8
		public static void ResetStaticDefaultValue()
		{
			RoleLangCustomModel._Instance = null;
		}

		// Token: 0x0603342E RID: 209966 RVA: 0x00BF48D0 File Offset: 0x00BF2AD0
		static RoleLangCustomModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleLangCustomModel.CreateStaticDefaultValue), new Action(RoleLangCustomModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401B339 RID: 111417
		public int RoleViewRoleId;

		// Token: 0x0401B33A RID: 111418
		public bool CanSetCustom;

		// Token: 0x0401B33B RID: 111419
		public bool NeedCoverAllPlayer;

		// Token: 0x0401B33C RID: 111420
		private bool StartLoadingInited;

		// Token: 0x0401B33D RID: 111421
		private readonly Dictionary<int, int> ServerVoiceData = new Dictionary<int, int>();

		// Token: 0x0401B33E RID: 111422
		private bool HasCheckServer;

		// Token: 0x0401B33F RID: 111423
		private bool HasConfirm;

		// Token: 0x0401B340 RID: 111424
		private RoleLangCustomUpdateManager UpdateManager;

		// Token: 0x0401B341 RID: 111425
		private readonly UiMask ConfirmViewMask = new UiMask();

		// Token: 0x0401B342 RID: 111426
		private const string ConfirmMaskTag = "RoleLangNetConfirmPop";

		// Token: 0x0401B343 RID: 111427
		[Nullable(2)]
		private static RoleLangCustomModel _Instance;
	}
}
