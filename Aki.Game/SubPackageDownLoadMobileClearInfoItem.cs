using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;
using UnrealEngine;

// Token: 0x02002AAD RID: 10925
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SubPackageDownLoadMobileClearInfoItem : GridProxyAbstract<ISubPackageDownLoadMobileClearInfoItemData>
{
	// Token: 0x06016BF8 RID: 93176 RVA: 0x005C5AA4 File Offset: 0x005C3CA4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06016BF9 RID: 93177 RVA: 0x005C5B38 File Offset: 0x005C3D38
	public override void Refresh(ISubPackageDownLoadMobileClearInfoItemData data, bool isSelected, int gridIndex)
	{
		this.SceneId = null;
		this.IsVideo = false;
		this.VoiceCode = null;
		if (data.Type == ESubPackageDownLoadPackageType.OptionalPlot)
		{
			this.RefreshItemByPlot(data.HaveVideoCanClear.GetValueOrDefault());
		}
		if (data.Type == ESubPackageDownLoadPackageType.OptionalScene)
		{
			this.RefreshItemByScene(data.SceneId.GetValueOrDefault());
		}
		if (data.Type == ESubPackageDownLoadPackageType.Voice)
		{
			this.RefreshItemByVoice(data.VoiceLanguageCode ?? "");
		}
	}

	// Token: 0x06016BFA RID: 93178 RVA: 0x005C5BB8 File Offset: 0x005C3DB8
	public void RefreshItemByScene(int sceneId)
	{
		this.SceneId = new int?(sceneId);
		int? sceneId2 = this.SceneId;
		int num = 0;
		if (sceneId2.GetValueOrDefault() <= num & sceneId2 != null)
		{
			base.GetItem(2).SetUIActive(true);
			base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetItem(2).SetUIActive(false);
		base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(true);
		DownLoadSubPackage value = SubPackageConfig.Instance.GetDownLoadSubPackageById(this.SceneId.GetValueOrDefault()).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Title, Array.Empty<object>());
		long subPackageHaveDownLoadSpace = SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(this.SceneId.GetValueOrDefault());
		base.GetText(3).SetText(SubPackageDownLoadModel.Instance.ByteConverter(subPackageHaveDownLoadSpace), true);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x06016BFB RID: 93179 RVA: 0x005C5CC4 File Offset: 0x005C3EC4
	public void RefreshItemByPlot(bool haveVideo)
	{
		this.IsVideo = true;
		if (!haveVideo)
		{
			base.GetItem(2).SetUIActive(true);
			base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetItem(2).SetUIActive(false);
		base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SubPackageClearTips_Plot_Item_Info", Array.Empty<object>());
		long canCleanVideoSpace = SubPackageDownLoadModel.Instance.GetCanCleanVideoSpace();
		base.GetText(3).SetText(SubPackageDownLoadModel.Instance.ByteConverter(canCleanVideoSpace), true);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x06016BFC RID: 93180 RVA: 0x005C5D80 File Offset: 0x005C3F80
	public void RefreshItemByVoice(string audioCode)
	{
		this.VoiceCode = audioCode;
		if (string.IsNullOrEmpty(audioCode))
		{
			base.GetItem(2).SetUIActive(true);
			base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetItem(2).SetUIActive(false);
		base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(true);
		IEnumerable<LaunchLangDefine> allLanguageDefines = LauncherLanguageLib.Instance.GetAllLanguageDefines();
		LaunchLangDefine launchLangDefine = null;
		foreach (LaunchLangDefine launchLangDefine2 in allLanguageDefines)
		{
			if (launchLangDefine2.AudioCode == audioCode)
			{
				launchLangDefine = launchLangDefine2;
				break;
			}
		}
		RoleVoiceLanguage? roleVoiceLanguage = (launchLangDefine != null) ? ConfigRoleVoiceLanguageByLanguageId.GetConfig(launchLangDefine.LanguageType, true) : null;
		if (roleVoiceLanguage != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), roleVoiceLanguage.Value.Text, Array.Empty<object>());
		}
		else
		{
			base.GetText(1).SetText(audioCode, true);
		}
		long localSizeByAudioCode = ResourceDiffUpdaterManager.Instance.VoiceModule.GetLocalSizeByAudioCode(audioCode);
		base.GetText(3).SetText(SubPackageDownLoadModel.Instance.ByteConverter(localSizeByAudioCode), true);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x06016BFD RID: 93181 RVA: 0x005C5EE0 File Offset: 0x005C40E0
	private void OnClickToggle(EToggleState state)
	{
		Action<int?, bool, EToggleState, string> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.SceneId, this.IsVideo, state, this.VoiceCode);
	}

	// Token: 0x0400A8D7 RID: 43223
	[Nullable(2)]
	public Action<int?, bool, EToggleState, string> OnClickToggleCallBack;

	// Token: 0x0400A8D8 RID: 43224
	private int? SceneId;

	// Token: 0x0400A8D9 RID: 43225
	private bool IsVideo;

	// Token: 0x0400A8DA RID: 43226
	[Nullable(2)]
	private string VoiceCode;

	// Token: 0x020090DD RID: 37085
	[NullableContext(0)]
	private class ESubPackageDownLoadMobileClearInfoItem
	{
		// Token: 0x0402EEEE RID: 192238
		public const int Toggle = 0;

		// Token: 0x0402EEEF RID: 192239
		public const int Text = 1;

		// Token: 0x0402EEF0 RID: 192240
		public const int EmptyItem = 2;

		// Token: 0x0402EEF1 RID: 192241
		public const int SpaceText = 3;
	}
}
