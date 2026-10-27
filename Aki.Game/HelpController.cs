using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E51 RID: 7761
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class HelpController : UiControllerBase
{
	// Token: 0x0600EC04 RID: 60420 RVA: 0x00380790 File Offset: 0x0037E990
	protected override bool OnInit()
	{
		FLGUIDelegateForHelpClick flguidelegateForHelpClick = DelegateUtils.ToManualReleaseDelegate<FLGUIDelegateForHelpClick>(new Action<int>(this.OnHelpClick));
		UUIExtendButtonComponent.SetDelegateForHelpClick(flguidelegateForHelpClick);
		return true;
	}

	// Token: 0x0600EC05 RID: 60421 RVA: 0x003807B7 File Offset: 0x0037E9B7
	private void OnHelpClick(int helpGroupId)
	{
		this.OpenHelpById(helpGroupId);
	}

	// Token: 0x0600EC06 RID: 60422 RVA: 0x003807C0 File Offset: 0x0037E9C0
	public void OpenHelpById(int helpGroupId)
	{
		IReadOnlyList<HelpText> helpContentInfoByGroupId = HelpConfig.Instance.GetHelpContentInfoByGroupId(helpGroupId);
		if (helpContentInfoByGroupId == null || helpContentInfoByGroupId.Count == 0)
		{
			return;
		}
		this.HelpGroupId = new int?(helpGroupId);
		int type = helpContentInfoByGroupId[0].Type;
		if (type == 0)
		{
			UiManager instance = UiManager.Instance;
			EUiViewName helpView = EUiViewName.HelpView;
			object param = this.HelpGroupId;
			TOpenViewCallBack finishCallback;
			if ((finishCallback = HelpController.<>O.<0>__OpenViewCallback) == null)
			{
				finishCallback = (HelpController.<>O.<0>__OpenViewCallback = new TOpenViewCallBack(HelpController.OpenViewCallback));
			}
			instance.OpenView(helpView, param, finishCallback);
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

	// Token: 0x0600EC07 RID: 60423 RVA: 0x00380874 File Offset: 0x0037EA74
	private static void OpenViewCallback(bool success, int viewId)
	{
		if (success)
		{
			HelpController.Instance.HelpGroupId = null;
		}
	}

	// Token: 0x0600EC08 RID: 60424 RVA: 0x00380889 File Offset: 0x0037EA89
	protected override bool OnClear()
	{
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.OnHelpClick));
		return true;
	}

	// Token: 0x17001288 RID: 4744
	// (get) Token: 0x0600EC09 RID: 60425 RVA: 0x0038089D File Offset: 0x0037EA9D
	public static HelpController Instance
	{
		get
		{
			return HelpController._Instance;
		}
	}

	// Token: 0x0600EC0A RID: 60426 RVA: 0x003808A4 File Offset: 0x0037EAA4
	public static HelpController GetOrCreateInstance()
	{
		if (HelpController._Instance == null)
		{
			HelpController.CreateInstance();
		}
		return HelpController._Instance;
	}

	// Token: 0x0600EC0B RID: 60427 RVA: 0x003808B8 File Offset: 0x0037EAB8
	public static bool CreateInstance()
	{
		if (HelpController._Instance != null)
		{
			return true;
		}
		HelpController._Instance = new HelpController();
		return true;
	}

	// Token: 0x0600EC0C RID: 60428 RVA: 0x003808CE File Offset: 0x0037EACE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EC0D RID: 60429 RVA: 0x003808D0 File Offset: 0x0037EAD0
	public static void ResetStaticDefaultValue()
	{
		HelpController._Instance = null;
	}

	// Token: 0x0600EC0E RID: 60430 RVA: 0x003808D8 File Offset: 0x0037EAD8
	static HelpController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HelpController.CreateStaticDefaultValue), new Action(HelpController.ResetStaticDefaultValue));
	}

	// Token: 0x04006D6E RID: 28014
	public int? HelpGroupId;

	// Token: 0x04006D6F RID: 28015
	[Nullable(2)]
	private static HelpController _Instance;

	// Token: 0x02008406 RID: 33798
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402AF98 RID: 176024
		[Nullable(0)]
		public static TOpenViewCallBack <0>__OpenViewCallback;
	}
}
