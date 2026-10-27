using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;

// Token: 0x02001BB0 RID: 7088
[NullableContext(1)]
[Nullable(0)]
public class FormationEditSortController : UiControllerBase
{
	// Token: 0x1700116A RID: 4458
	// (get) Token: 0x0600D359 RID: 54105 RVA: 0x0030981F File Offset: 0x00307A1F
	public static bool IsSortMode
	{
		get
		{
			FormationEditView view = FormationEditSortController.GetView();
			return view != null && view.IsGamePadSort;
		}
	}

	// Token: 0x0600D35A RID: 54106 RVA: 0x00309831 File Offset: 0x00307A31
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x0600D35B RID: 54107 RVA: 0x0030984F File Offset: 0x00307A4F
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x0600D35C RID: 54108 RVA: 0x0030986D File Offset: 0x00307A6D
	private void InputControllerChange(EInputControllerType last, EInputControllerType current)
	{
		if (!Info.Instance.IsInGamepad())
		{
			FormationEditSortController.Cancel();
		}
	}

	// Token: 0x0600D35D RID: 54109 RVA: 0x00309880 File Offset: 0x00307A80
	public static void AddCustomShieldHotKeyComponentSetData(int index)
	{
		FormationEditSortController.ShieldWhiteList.Add(index);
	}

	// Token: 0x0600D35E RID: 54110 RVA: 0x0030988E File Offset: 0x00307A8E
	public static void ReleaseInputBlock()
	{
		FormationEditSortController.SetInputBlocked(false);
	}

	// Token: 0x0600D35F RID: 54111 RVA: 0x00309898 File Offset: 0x00307A98
	public static bool CanEnterSortMode()
	{
		FormationEditView view = FormationEditSortController.GetView();
		return view != null && !view.IsGamePadSort && view.CanBeginGamePadSort();
	}

	// Token: 0x0600D360 RID: 54112 RVA: 0x003098C0 File Offset: 0x00307AC0
	public static void EnterSortMode()
	{
		if (!FormationEditSortController.CanEnterSortMode())
		{
			return;
		}
		FormationEditView view = FormationEditSortController.GetView();
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "FormationEditSort-Enter", default(ReadOnlySpan<ValueTuple<string, object>>));
		view.BeginGamePadSort();
		FormationEditSortController.SetInputBlocked(view.IsGamePadSort);
	}

	// Token: 0x0600D361 RID: 54113 RVA: 0x00309908 File Offset: 0x00307B08
	public static void Confirm()
	{
		FormationEditView view = FormationEditSortController.GetView();
		if (view == null || !view.IsGamePadSort)
		{
			return;
		}
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "FormationEditSort-Confirm", default(ReadOnlySpan<ValueTuple<string, object>>));
		FormationEditSortController.SetInputBlocked(false);
		view.EndGamePadSort(false);
	}

	// Token: 0x0600D362 RID: 54114 RVA: 0x00309958 File Offset: 0x00307B58
	public static void Cancel()
	{
		FormationEditView view = FormationEditSortController.GetView();
		if (view == null || !view.IsGamePadSort)
		{
			return;
		}
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "FormationEditSort-Cancel", default(ReadOnlySpan<ValueTuple<string, object>>));
		FormationEditSortController.SetInputBlocked(false);
		view.EndGamePadSort(true);
	}

	// Token: 0x0600D363 RID: 54115 RVA: 0x003099A6 File Offset: 0x00307BA6
	public static void MoveSort(int delta)
	{
		FormationEditView view = FormationEditSortController.GetView();
		if (view == null)
		{
			return;
		}
		view.MoveGamePadSort(delta);
	}

	// Token: 0x0600D364 RID: 54116 RVA: 0x003099B8 File Offset: 0x00307BB8
	[NullableContext(2)]
	private static FormationEditView GetView()
	{
		return UiManager.Instance.GetViewByName(EUiViewName.FormationEditView) as FormationEditView;
	}

	// Token: 0x0600D365 RID: 54117 RVA: 0x003099CE File Offset: 0x00307BCE
	private static void SetInputBlocked(bool blocked)
	{
		if (FormationEditSortController.IsInputBlocked == blocked)
		{
			return;
		}
		FormationEditSortController.IsInputBlocked = blocked;
		UiNavigationModel.Instance.CustomShieldHotKeyComponent(FormationEditSortController.ShieldWhiteList, !blocked);
		if (blocked)
		{
			UiNavigationGlobalData.AddBlockListenerFocusTag("FormationEditSort");
			return;
		}
		UiNavigationGlobalData.DeleteBlockListenerFocusTag("FormationEditSort");
	}

	// Token: 0x1700116B RID: 4459
	// (get) Token: 0x0600D366 RID: 54118 RVA: 0x00309A0A File Offset: 0x00307C0A
	public static FormationEditSortController Instance
	{
		get
		{
			return FormationEditSortController._Instance;
		}
	}

	// Token: 0x0600D367 RID: 54119 RVA: 0x00309A11 File Offset: 0x00307C11
	public static FormationEditSortController GetOrCreateInstance()
	{
		if (FormationEditSortController._Instance == null)
		{
			FormationEditSortController.CreateInstance();
		}
		return FormationEditSortController._Instance;
	}

	// Token: 0x0600D368 RID: 54120 RVA: 0x00309A25 File Offset: 0x00307C25
	public static bool CreateInstance()
	{
		if (FormationEditSortController._Instance != null)
		{
			return true;
		}
		FormationEditSortController._Instance = new FormationEditSortController();
		return true;
	}

	// Token: 0x0600D369 RID: 54121 RVA: 0x00309A3B File Offset: 0x00307C3B
	public static void CreateStaticDefaultValue()
	{
		FormationEditSortController.OnCreateStaticDefaultValue();
	}

	// Token: 0x0600D36A RID: 54122 RVA: 0x00309A42 File Offset: 0x00307C42
	public static void ResetStaticDefaultValue()
	{
		FormationEditSortController._Instance = null;
		FormationEditSortController.OnResetStaticDefaultValue();
	}

	// Token: 0x0600D36B RID: 54123 RVA: 0x00309A4F File Offset: 0x00307C4F
	private static void OnCreateStaticDefaultValue()
	{
		FormationEditSortController.ShieldWhiteList = new HashSet<int>();
		FormationEditSortController.IsInputBlocked = false;
	}

	// Token: 0x0600D36C RID: 54124 RVA: 0x00309A61 File Offset: 0x00307C61
	private static void OnResetStaticDefaultValue()
	{
		FormationEditSortController.ShieldWhiteList = null;
		FormationEditSortController.IsInputBlocked = false;
	}

	// Token: 0x0600D36D RID: 54125 RVA: 0x00309A6F File Offset: 0x00307C6F
	static FormationEditSortController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationEditSortController.CreateStaticDefaultValue), new Action(FormationEditSortController.ResetStaticDefaultValue));
	}

	// Token: 0x040060C0 RID: 24768
	private const string BLOCK_FOCUS_TAG = "FormationEditSort";

	// Token: 0x040060C1 RID: 24769
	[Nullable(2)]
	private static HashSet<int> ShieldWhiteList;

	// Token: 0x040060C2 RID: 24770
	private static bool IsInputBlocked;

	// Token: 0x040060C3 RID: 24771
	[Nullable(2)]
	private static FormationEditSortController _Instance;
}
