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

// Token: 0x02002026 RID: 8230
[NullableContext(1)]
[Nullable(0)]
public class SubPackageDownLoadMobileClearPopView : UiViewBase
{
	// Token: 0x0601460E RID: 83470 RVA: 0x005F19C9 File Offset: 0x005EFBC9
	public SubPackageDownLoadMobileClearPopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0601460F RID: 83471 RVA: 0x005F19E8 File Offset: 0x005EFBE8
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

	// Token: 0x06014610 RID: 83472 RVA: 0x005F1A94 File Offset: 0x005EFC94
	protected override UniTask OnBeforeStartAsync()
	{
		SubPackageDownLoadMobileClearPopView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SubPackageDownLoadMobileClearPopView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014611 RID: 83473 RVA: 0x005F1AD8 File Offset: 0x005EFCD8
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

	// Token: 0x06014612 RID: 83474 RVA: 0x005F1B80 File Offset: 0x005EFD80
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

	// Token: 0x06014613 RID: 83475 RVA: 0x005F1BF8 File Offset: 0x005EFDF8
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

	// Token: 0x06014614 RID: 83476 RVA: 0x005F1C88 File Offset: 0x005EFE88
	private bool GetPlotData()
	{
		long canCleanVideoSpace = SubPackageDownLoadModel.Instance.GetCanCleanVideoSpace();
		this.AllCanClearSpace += canCleanVideoSpace;
		return canCleanVideoSpace > 0L;
	}

	// Token: 0x06014615 RID: 83477 RVA: 0x005F1CB4 File Offset: 0x005EFEB4
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

	// Token: 0x06014616 RID: 83478 RVA: 0x005F1DAC File Offset: 0x005EFFAC
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

	// Token: 0x06014617 RID: 83479 RVA: 0x005F1DC5 File Offset: 0x005EFFC5
	private SubPackageDownLoadMobileClearItem InitSubPackageDownLoadMobileClearItem()
	{
		return new SubPackageDownLoadMobileClearItem
		{
			OnClickToggleCallBack = new Action<int?, bool, EToggleState, string>(this.OnSelectSubItem),
			OnClickHelpBtnCallBack = new Action<int, UUIItem>(this.OnClickHelpBtn)
		};
	}

	// Token: 0x06014618 RID: 83480 RVA: 0x005F1DF0 File Offset: 0x005EFFF0
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

	// Token: 0x06014619 RID: 83481 RVA: 0x005F1E14 File Offset: 0x005F0014
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
			SubPackageDownLoadModel.Instance.OpenMultiBanCleanConfirm();
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

	// Token: 0x0601461A RID: 83482 RVA: 0x005F1F18 File Offset: 0x005F0118
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

	// Token: 0x0601461B RID: 83483 RVA: 0x005F1FC8 File Offset: 0x005F01C8
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

	// Token: 0x0601461C RID: 83484 RVA: 0x005F2104 File Offset: 0x005F0304
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

	// Token: 0x0400ACD0 RID: 44240
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<SubPackageDownLoadMobileClearItem, ISubPackageDownLoadMobileClearData> SubPackageScrollView;

	// Token: 0x0400ACD1 RID: 44241
	private readonly HashSet<int> CurrentSelectInfoIdSet = new HashSet<int>();

	// Token: 0x0400ACD2 RID: 44242
	private bool HaveSelectVideo;

	// Token: 0x0400ACD3 RID: 44243
	private readonly HashSet<string> SelectVoiceCodeSet = new HashSet<string>();

	// Token: 0x0400ACD4 RID: 44244
	[Nullable(2)]
	private SubPackageDownLoadVersionTipsView VersionTipsView;

	// Token: 0x0400ACD5 RID: 44245
	private long AllCanClearSpace;

	// Token: 0x0400ACD6 RID: 44246
	private const long MB_SIZE = 1048576L;

	// Token: 0x0200831C RID: 33564
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A5E2 RID: 173538
		public const int ConfirmBtn = 0;

		// Token: 0x0402A5E3 RID: 173539
		public const int AutoClearToggle = 1;

		// Token: 0x0402A5E4 RID: 173540
		public const int ScrollView = 2;

		// Token: 0x0402A5E5 RID: 173541
		public const int ConfirmBoxText = 5;
	}
}
