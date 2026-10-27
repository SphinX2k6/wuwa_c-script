using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.RoleLangCustomModel;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002AAA RID: 10922
[NullableContext(1)]
[Nullable(0)]
public class SubPackageDownLoadMobileClearPopView : UiViewBase
{
	// Token: 0x06016BDF RID: 93151 RVA: 0x005C4F29 File Offset: 0x005C3129
	public SubPackageDownLoadMobileClearPopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06016BE0 RID: 93152 RVA: 0x005C4F48 File Offset: 0x005C3148
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickConfirmBtn)),
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickAutoClearToggle))
		};
	}

	// Token: 0x06016BE1 RID: 93153 RVA: 0x005C4FF4 File Offset: 0x005C31F4
	protected override UniTask OnBeforeStartAsync()
	{
		SubPackageDownLoadMobileClearPopView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SubPackageDownLoadMobileClearPopView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016BE2 RID: 93154 RVA: 0x005C5038 File Offset: 0x005C3238
	protected override void OnStart()
	{
		this.SubPackageScrollView = new GenericScrollViewNew<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData>(base.GetScrollViewWithScrollbar(2), new Func<SubPackageDownLoadMobileClearItem>(this.InitSubPackageDownLoadMobileClearItem), null, false, null);
		this.SubPackageScrollView.RefreshByData(this.GetScrollViewDataList(), new Action(this.RefreshButton), false);
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadClearOnLogin, false);
		UUIExtendToggle extendToggle = base.GetExtendToggle(1);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(player ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
		}
		SubPackageController.Instance.MobileResCleanUpTraceId = new Random().Next(0, 1000000);
		SubPackageController.Instance.ReportInitialMobileResCleanUpViewLogEvent((int)(this.AllCanClearSpace / 1048576L), 3);
	}

	// Token: 0x06016BE3 RID: 93155 RVA: 0x005C50E0 File Offset: 0x005C32E0
	private List<ISubPackageDownLoadMobileClearData> GetScrollViewDataList()
	{
		List<ISubPackageDownLoadMobileClearData> list = new List<ISubPackageDownLoadMobileClearData>();
		ISubPackageDownLoadMobileClearData subPackageDownLoadMobileClearData = new SubPackageDownLoadMobileClearData
		{
			TitleId = 3
		};
		subPackageDownLoadMobileClearData.HaveVideoCanClear = new bool?(this.GetPlotData());
		list.Add(subPackageDownLoadMobileClearData);
		ISubPackageDownLoadMobileClearData subPackageDownLoadMobileClearData2 = new SubPackageDownLoadMobileClearData
		{
			TitleId = 2
		};
		subPackageDownLoadMobileClearData2.SceneIdList = this.GetSceneData();
		list.Add(subPackageDownLoadMobileClearData2);
		ISubPackageDownLoadMobileClearData subPackageDownLoadMobileClearData3 = new SubPackageDownLoadMobileClearData
		{
			TitleId = 5
		};
		subPackageDownLoadMobileClearData3.VoiceLanguageCodeList = this.GetVoiceData();
		list.Add(subPackageDownLoadMobileClearData3);
		return list;
	}

	// Token: 0x06016BE4 RID: 93156 RVA: 0x005C5158 File Offset: 0x005C3358
	private List<int> GetSceneData()
	{
		List<int> list = new List<int>();
		foreach (int num in SubPackageDownLoadModel.Instance.GetCanCleanSceneIdList())
		{
			long subPackageHaveDownLoadSpace = SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(num);
			if (subPackageHaveDownLoadSpace > 0L)
			{
				list.Add(num);
				this.AllCanClearSpace += subPackageHaveDownLoadSpace;
			}
		}
		if (list.Count <= 0)
		{
			list.Add(-1);
		}
		return list;
	}

	// Token: 0x06016BE5 RID: 93157 RVA: 0x005C51E8 File Offset: 0x005C33E8
	private bool GetPlotData()
	{
		long canCleanVideoSpace = SubPackageDownLoadModel.Instance.GetCanCleanVideoSpace();
		this.AllCanClearSpace += canCleanVideoSpace;
		return canCleanVideoSpace > 0L;
	}

	// Token: 0x06016BE6 RID: 93158 RVA: 0x005C5214 File Offset: 0x005C3414
	private List<string> GetVoiceData()
	{
		List<string> list = new List<string>();
		string packageAudio = LanguageSystem.Instance.PackageAudio;
		IEnumerable<LaunchLangDefine> allLanguageDefines = LauncherLanguageLib.Instance.GetAllLanguageDefines();
		HashSet<string> hashSet = new HashSet<string>();
		foreach (LaunchLangDefine launchLangDefine in allLanguageDefines)
		{
			string audioCode = launchLangDefine.AudioCode;
			if (!hashSet.Contains(audioCode))
			{
				hashSet.Add(audioCode);
				if (!(audioCode == packageAudio))
				{
					LanguageUpdater updater = LanguageUpdateManager.Instance.GetUpdater(audioCode);
					if (updater != null)
					{
						updater.CalculateDownloadStatus("SubPackageDownLoadMobileClearPopView GetVoiceData");
						if (updater.Status == ELanguageDownloadStatus.Done && ResourceDiffUpdaterManager.Instance.VoiceModule.GetLocalSizeByAudioCode(audioCode) > 0L)
						{
							list.Add(audioCode);
							this.AllCanClearSpace += updater.TotalDiskSize;
						}
					}
				}
			}
		}
		if (list.Count <= 0)
		{
			list.Add("");
		}
		return list;
	}

	// Token: 0x06016BE7 RID: 93159 RVA: 0x005C530C File Offset: 0x005C350C
	private void DealRoleLangCustom()
	{
		if (!LocalStorage.HasPlayerId())
		{
			return;
		}
		RoleLangCustomModel instance = RoleLangCustomModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.CheckAndApplyPlayerVoiceAll();
	}

	// Token: 0x06016BE8 RID: 93160 RVA: 0x005C5325 File Offset: 0x005C3525
	private SubPackageDownLoadMobileClearItem InitSubPackageDownLoadMobileClearItem()
	{
		return new SubPackageDownLoadMobileClearItem
		{
			OnClickToggleCallBack = new Action<int?, bool, EToggleState, string>(this.OnSelectSubItem),
			OnClickHelpBtnCallBack = new Action<int, UUIItem>(this.OnClickHelpBtn)
		};
	}

	// Token: 0x06016BE9 RID: 93161 RVA: 0x005C5350 File Offset: 0x005C3550
	private void OnClickAutoClearToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadClearOnLogin, true);
			return;
		}
		if (state == EToggleState.ETT_UnChecked)
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadClearOnLogin, false);
		}
	}

	// Token: 0x06016BEA RID: 93162 RVA: 0x005C5374 File Offset: 0x005C3574
	private void OnClickConfirmBtn()
	{
		if (this.CurrentSelectInfoIdSet.Count <= 0)
		{
			if (this.HaveSelectVideo)
			{
				SubPackageController.Instance.ClearSubPackage(new List<int>(), this.HaveSelectVideo);
			}
			if (this.SelectVoiceCodeSet.Count > 0)
			{
				foreach (string audioCode in this.SelectVoiceCodeSet)
				{
					ResourceDiffUpdaterManager.Instance.VoiceModule.DeleteByAudioCode(audioCode);
				}
				this.DealRoleLangCustom();
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("ClearBlockFinishTips", Array.Empty<object>());
			base.CloseMe(null);
			return;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ConnectBanCleanResource", Array.Empty<object>());
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ClearBlockSubPackageConfirm);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			SubPackageController.Instance.ClearSubPackage(new List<int>(this.CurrentSelectInfoIdSet), this.HaveSelectVideo);
			if (this.SelectVoiceCodeSet.Count > 0)
			{
				foreach (string audioCode2 in this.SelectVoiceCodeSet)
				{
					ResourceDiffUpdaterManager.Instance.VoiceModule.DeleteByAudioCode(audioCode2);
				}
				this.DealRoleLangCustom();
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("ClearBlockFinishTips", Array.Empty<object>());
			ReConnectController.Instance.Logout(ELogoutReason.ClearBlockReLogin);
			base.CloseMe(null);
			if (UiManager.Instance.IsViewShow(EUiViewName.SubPackageDownLoadFreeSpaceTipsView))
			{
				UiManager.Instance.CloseView(EUiViewName.SubPackageDownLoadFreeSpaceTipsView, null);
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.SubPackageDownLoadView))
			{
				UiManager.Instance.CloseView(EUiViewName.SubPackageDownLoadView, null);
			}
		});
		ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
	}

	// Token: 0x06016BEB RID: 93163 RVA: 0x005C5484 File Offset: 0x005C3684
	[NullableContext(2)]
	private void OnSelectSubItem(int? sceneId, bool isVideo, EToggleState state, string voiceCode)
	{
		if (state == EToggleState.ETT_Checked)
		{
			if (sceneId != null && sceneId.Value != 0)
			{
				this.CurrentSelectInfoIdSet.Add(sceneId.Value);
			}
			else if (isVideo)
			{
				this.HaveSelectVideo = true;
			}
			else if (!string.IsNullOrEmpty(voiceCode))
			{
				this.SelectVoiceCodeSet.Add(voiceCode);
			}
		}
		else if (sceneId != null && sceneId.Value != 0)
		{
			this.CurrentSelectInfoIdSet.Remove(sceneId.Value);
		}
		else if (isVideo)
		{
			this.HaveSelectVideo = false;
		}
		else if (!string.IsNullOrEmpty(voiceCode))
		{
			this.SelectVoiceCodeSet.Remove(voiceCode);
		}
		this.RefreshButton();
	}

	// Token: 0x06016BEC RID: 93164 RVA: 0x005C5534 File Offset: 0x005C3734
	private void RefreshButton()
	{
		base.GetButton(0).SetSelfInteractive(this.CurrentSelectInfoIdSet.Count > 0 || this.HaveSelectVideo || this.SelectVoiceCodeSet.Count > 0);
		long num = this.HaveSelectVideo ? SubPackageDownLoadModel.Instance.GetCanCleanVideoSpace() : 0L;
		foreach (int id in this.CurrentSelectInfoIdSet)
		{
			num += SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(id);
		}
		foreach (string audioCode in this.SelectVoiceCodeSet)
		{
			long localSizeByAudioCode = ResourceDiffUpdaterManager.Instance.VoiceModule.GetLocalSizeByAudioCode(audioCode);
			num += localSizeByAudioCode;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "SubPackageClearButton", new <>z__ReadOnlyArray<object>(new object[]
		{
			SubPackageDownLoadModel.Instance.ByteConverter(num),
			SubPackageDownLoadModel.Instance.ByteConverter(this.AllCanClearSpace)
		}));
	}

	// Token: 0x06016BED RID: 93165 RVA: 0x005C5670 File Offset: 0x005C3870
	private void OnClickHelpBtn(int type, UUIItem item)
	{
		SubPackageDownLoadVersionTipsView versionTipsView = this.VersionTipsView;
		if (versionTipsView != null)
		{
			versionTipsView.RefreshItemByClearType((ESubPackageDownLoadPackageType)type, item.D_K2_GetComponentLocation());
		}
		SubPackageDownLoadVersionTipsView versionTipsView2 = this.VersionTipsView;
		if (versionTipsView2 == null)
		{
			return;
		}
		versionTipsView2.SetUiActive(true);
	}

	// Token: 0x0400A8CA RID: 43210
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> SubPackageScrollView;

	// Token: 0x0400A8CB RID: 43211
	private readonly HashSet<int> CurrentSelectInfoIdSet = new HashSet<int>();

	// Token: 0x0400A8CC RID: 43212
	private bool HaveSelectVideo;

	// Token: 0x0400A8CD RID: 43213
	private readonly HashSet<string> SelectVoiceCodeSet = new HashSet<string>();

	// Token: 0x0400A8CE RID: 43214
	[Nullable(2)]
	private SubPackageDownLoadVersionTipsView VersionTipsView;

	// Token: 0x0400A8CF RID: 43215
	private long AllCanClearSpace;

	// Token: 0x0400A8D0 RID: 43216
	private const long MB_SIZE = 1048576L;

	// Token: 0x020090D8 RID: 37080
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402EEDD RID: 192221
		public const int ConfirmBtn = 0;

		// Token: 0x0402EEDE RID: 192222
		public const int AutoClearToggle = 1;

		// Token: 0x0402EEDF RID: 192223
		public const int ScrollView = 2;

		// Token: 0x0402EEE0 RID: 192224
		public const int ConfirmBoxText = 5;
	}
}
