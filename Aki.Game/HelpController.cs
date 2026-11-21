using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001313 RID: 4883
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class HelpController : UiControllerBase
{
	// Token: 0x0600C023 RID: 49187 RVA: 0x0038C428 File Offset: 0x0038A628
	protected override bool OnInit()
	{
		FLGUIDelegateForHelpClick flguidelegateForHelpClick = DelegateUtils.ToManualReleaseDelegate<FLGUIDelegateForHelpClick>(new Action<int>(this.OnHelpClick));
		UUIExtendButtonComponent.SetDelegateForHelpClick(flguidelegateForHelpClick);
		return true;
	}

	// Token: 0x0600C024 RID: 49188 RVA: 0x0038C44F File Offset: 0x0038A64F
	private void OnHelpClick(int helpGroupId)
	{
		this.OpenHelpById(helpGroupId);
	}

	// Token: 0x0600C025 RID: 49189 RVA: 0x0038C458 File Offset: 0x0038A658
	public void OpenHelpById(int helpGroupId)
	{
		IReadOnlyList<HelpText> helpContentInfoByGroupId = HelpConfig.Instance.GetHelpContentInfoByGroupId(helpGroupId);
		if (helpContentInfoByGroupId == null || helpContentInfoByGroupId.Count == 0)
		{
			return;
		}
		this.HelpGroupId = new int?(helpGroupId);
		EHelpStylizeType style = (EHelpStylizeType)helpContentInfoByGroupId[0].Style;
		int type = helpContentInfoByGroupId[0].Type;
		if (type == 0)
		{
			UiManager instance = UiManager.Instance;
			EUiViewName name = HelpStylizeDefine.helpPopUpViewStylizeMap[style];
			object param = this.HelpGroupId;
			TOpenViewCallBack finishCallback;
			if ((finishCallback = HelpController.<>O.<0>__OpenViewCallback) == null)
			{
				finishCallback = (HelpController.<>O.<0>__OpenViewCallback = new TOpenViewCallBack(HelpController.OpenViewCallback));
			}
			instance.OpenView(name, param, finishCallback);
			return;
		}
		if (type != 1)
		{
			return;
		}
		UiManager instance2 = UiManager.Instance;
		EUiViewName helpGuideView = EUiViewName.HelpGuideView;
		object param2 = this.HelpGroupId;
		TOpenViewCallBack finishCallback2;
		if ((finishCallback2 = HelpController.<>O.<0>__OpenViewCallback) == null)
		{
			finishCallback2 = (HelpController.<>O.<0>__OpenViewCallback = new TOpenViewCallBack(HelpController.OpenViewCallback));
		}
		instance2.OpenView(helpGuideView, param2, finishCallback2);
	}

	// Token: 0x0600C026 RID: 49190 RVA: 0x0038C522 File Offset: 0x0038A722
	private static void OpenViewCallback(bool success, int viewId)
	{
		if (success)
		{
			HelpController.Instance.HelpGroupId = null;
		}
	}

	// Token: 0x0600C027 RID: 49191 RVA: 0x0038C537 File Offset: 0x0038A737
	protected override bool OnClear()
	{
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.OnHelpClick));
		return true;
	}

	// Token: 0x170012B2 RID: 4786
	// (get) Token: 0x0600C028 RID: 49192 RVA: 0x0038C54B File Offset: 0x0038A74B
	public static HelpController Instance
	{
		get
		{
			return HelpController._Instance;
		}
	}

	// Token: 0x0600C029 RID: 49193 RVA: 0x0038C552 File Offset: 0x0038A752
	public static HelpController GetOrCreateInstance()
	{
		if (HelpController._Instance == null)
		{
			HelpController.CreateInstance();
		}
		return HelpController._Instance;
	}

	// Token: 0x0600C02A RID: 49194 RVA: 0x0038C566 File Offset: 0x0038A766
	public static bool CreateInstance()
	{
		if (HelpController._Instance != null)
		{
			return true;
		}
		HelpController._Instance = new HelpController();
		return true;
	}

	// Token: 0x0600C02B RID: 49195 RVA: 0x0038C57C File Offset: 0x0038A77C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C02C RID: 49196 RVA: 0x0038C57E File Offset: 0x0038A77E
	public static void ResetStaticDefaultValue()
	{
		HelpController._Instance = null;
	}

	// Token: 0x0600C02D RID: 49197 RVA: 0x0038C586 File Offset: 0x0038A786
	static HelpController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HelpController.CreateStaticDefaultValue), new Action(HelpController.ResetStaticDefaultValue));
	}

	// Token: 0x04006E4F RID: 28239
	public int? HelpGroupId;

	// Token: 0x04006E50 RID: 28240
	[Nullable(2)]
	private static HelpController _Instance;

	// Token: 0x0200758B RID: 30091
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040262BC RID: 156348
		[Nullable(0)]
		public static TOpenViewCallBack <0>__OpenViewCallback;
	}
}
