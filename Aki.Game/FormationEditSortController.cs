using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;

// Token: 0x0200106F RID: 4207
[NullableContext(1)]
[Nullable(0)]
public class FormationEditSortController : UiControllerBase
{
	// Token: 0x1700118F RID: 4495
	// (get) Token: 0x0600A76B RID: 42859 RVA: 0x00314913 File Offset: 0x00312B13
	public static bool IsSortMode
	{
		get
		{
			FormationEditView view = FormationEditSortController.GetView();
			return view != null && view.IsGamePadSort;
		}
	}

	// Token: 0x0600A76C RID: 42860 RVA: 0x00314925 File Offset: 0x00312B25
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x0600A76D RID: 42861 RVA: 0x00314943 File Offset: 0x00312B43
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x0600A76E RID: 42862 RVA: 0x00314961 File Offset: 0x00312B61
	private void InputControllerChange(EInputControllerType last, EInputControllerType current)
	{
		if (!Info.Instance.IsInGamepad())
		{
			FormationEditSortController.Cancel();
		}
	}

	// Token: 0x0600A76F RID: 42863 RVA: 0x00314974 File Offset: 0x00312B74
	public static void AddCustomShieldHotKeyComponentSetData(int index)
	{
		FormationEditSortController.ShieldWhiteList.Add(index);
	}

	// Token: 0x0600A770 RID: 42864 RVA: 0x00314982 File Offset: 0x00312B82
	public static void ReleaseInputBlock()
	{
		FormationEditSortController.SetInputBlocked(false);
	}

	// Token: 0x0600A771 RID: 42865 RVA: 0x0031498C File Offset: 0x00312B8C
	public static bool CanEnterSortMode()
	{
		FormationEditView view = FormationEditSortController.GetView();
		return view != null && !view.IsGamePadSort && view.CanBeginGamePadSort();
	}

	// Token: 0x0600A772 RID: 42866 RVA: 0x003149B4 File Offset: 0x00312BB4
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

	// Token: 0x0600A773 RID: 42867 RVA: 0x003149FC File Offset: 0x00312BFC
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

	// Token: 0x0600A774 RID: 42868 RVA: 0x00314A4C File Offset: 0x00312C4C
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

	// Token: 0x0600A775 RID: 42869 RVA: 0x00314A9A File Offset: 0x00312C9A
	public static void MoveSort(int delta)
	{
		FormationEditView view = FormationEditSortController.GetView();
		if (view == null)
		{
			return;
		}
		view.MoveGamePadSort(delta);
	}

	// Token: 0x0600A776 RID: 42870 RVA: 0x00314AAC File Offset: 0x00312CAC
	[NullableContext(2)]
	private static FormationEditView GetView()
	{
		return UiManager.Instance.GetViewByName(EUiViewName.FormationEditView) as FormationEditView;
	}

	// Token: 0x0600A777 RID: 42871 RVA: 0x00314AC2 File Offset: 0x00312CC2
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

	// Token: 0x17001190 RID: 4496
	// (get) Token: 0x0600A778 RID: 42872 RVA: 0x00314AFE File Offset: 0x00312CFE
	public static FormationEditSortController Instance
	{
		get
		{
			return FormationEditSortController._Instance;
		}
	}

	// Token: 0x0600A779 RID: 42873 RVA: 0x00314B05 File Offset: 0x00312D05
	public static FormationEditSortController GetOrCreateInstance()
	{
		if (FormationEditSortController._Instance == null)
		{
			FormationEditSortController.CreateInstance();
		}
		return FormationEditSortController._Instance;
	}

	// Token: 0x0600A77A RID: 42874 RVA: 0x00314B19 File Offset: 0x00312D19
	public static bool CreateInstance()
	{
		if (FormationEditSortController._Instance != null)
		{
			return true;
		}
		FormationEditSortController._Instance = new FormationEditSortController();
		return true;
	}

	// Token: 0x0600A77B RID: 42875 RVA: 0x00314B2F File Offset: 0x00312D2F
	public static void CreateStaticDefaultValue()
	{
		FormationEditSortController.OnCreateStaticDefaultValue();
	}

	// Token: 0x0600A77C RID: 42876 RVA: 0x00314B36 File Offset: 0x00312D36
	public static void ResetStaticDefaultValue()
	{
		FormationEditSortController._Instance = null;
		FormationEditSortController.OnResetStaticDefaultValue();
	}

	// Token: 0x0600A77D RID: 42877 RVA: 0x00314B43 File Offset: 0x00312D43
	private static void OnCreateStaticDefaultValue()
	{
		FormationEditSortController.ShieldWhiteList = new HashSet<int>();
		FormationEditSortController.IsInputBlocked = false;
	}

	// Token: 0x0600A77E RID: 42878 RVA: 0x00314B55 File Offset: 0x00312D55
	private static void OnResetStaticDefaultValue()
	{
		FormationEditSortController.ShieldWhiteList = null;
		FormationEditSortController.IsInputBlocked = false;
	}

	// Token: 0x0600A77F RID: 42879 RVA: 0x00314B63 File Offset: 0x00312D63
	static FormationEditSortController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationEditSortController.CreateStaticDefaultValue), new Action(FormationEditSortController.ResetStaticDefaultValue));
	}

	// Token: 0x0400618F RID: 24975
	private const string BLOCK_FOCUS_TAG = "FormationEditSort";

	// Token: 0x04006190 RID: 24976
	[Nullable(2)]
	private static HashSet<int> ShieldWhiteList;

	// Token: 0x04006191 RID: 24977
	private static bool IsInputBlocked;

	// Token: 0x04006192 RID: 24978
	[Nullable(2)]
	private static FormationEditSortController _Instance;
}
