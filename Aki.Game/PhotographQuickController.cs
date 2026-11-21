using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A3D RID: 6717
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class PhotographQuickController : ControllerBase
{
	// Token: 0x17001917 RID: 6423
	// (get) Token: 0x060108DD RID: 67805 RVA: 0x004D8887 File Offset: 0x004D6A87
	public PhotographQuickModel Model
	{
		get
		{
			return PhotographQuickModel.Instance;
		}
	}

	// Token: 0x060108DE RID: 67806 RVA: 0x004D888E File Offset: 0x004D6A8E
	protected override bool OnInit()
	{
		this.OnAddEvents();
		return true;
	}

	// Token: 0x060108DF RID: 67807 RVA: 0x004D8897 File Offset: 0x004D6A97
	protected override bool OnLeaveLevel()
	{
		this.Reset();
		return true;
	}

	// Token: 0x060108E0 RID: 67808 RVA: 0x004D88A0 File Offset: 0x004D6AA0
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x060108E1 RID: 67809 RVA: 0x004D88AC File Offset: 0x004D6AAC
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
		EventSystem.Instance.Add<FGameplayTag>(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnCheckClientEvent));
		InputDistributeController.Instance.BindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
		InputDistributeController.Instance.BindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
	}

	// Token: 0x060108E2 RID: 67810 RVA: 0x004D8944 File Offset: 0x004D6B44
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Remove(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
		EventSystem.Instance.Remove(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnCheckClientEvent));
		InputDistributeController.Instance.UnBindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
		InputDistributeController.Instance.UnBindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
	}

	// Token: 0x060108E3 RID: 67811 RVA: 0x004D89DC File Offset: 0x004D6BDC
	private void OnInputUiLookUp(string axisName, float value, InputIdentification _)
	{
		if (value == 0f)
		{
			return;
		}
		PhotoCameraHandler handler = this.Model.GetHandler();
		if (handler == null)
		{
			return;
		}
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		if (UiManager.Instance.IsViewShow(EUiViewName.PhotoSaveView))
		{
			return;
		}
		handler.AddPitchInput(-value);
	}

	// Token: 0x060108E4 RID: 67812 RVA: 0x004D8A2C File Offset: 0x004D6C2C
	private void OnInputUiTurn(string axisName, float value, InputIdentification _)
	{
		if (value == 0f)
		{
			return;
		}
		PhotoCameraHandler handler = this.Model.GetHandler();
		if (handler == null)
		{
			return;
		}
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		if (UiManager.Instance.IsViewShow(EUiViewName.PhotoSaveView))
		{
			return;
		}
		handler.AddYawInput(value);
	}

	// Token: 0x060108E5 RID: 67813 RVA: 0x004D8A78 File Offset: 0x004D6C78
	protected override void OnTick(float delta)
	{
		if (this.Model.GetHandler() == null)
		{
			return;
		}
		this.Model.GetHandler().ApplyCameraDelta();
	}

	// Token: 0x060108E6 RID: 67814 RVA: 0x004D8A98 File Offset: 0x004D6C98
	private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		this.Close(false);
	}

	// Token: 0x060108E7 RID: 67815 RVA: 0x004D8AA1 File Offset: 0x004D6CA1
	private void OnRoleDead(int charId)
	{
		this.Close(false);
	}

	// Token: 0x060108E8 RID: 67816 RVA: 0x004D8AAA File Offset: 0x004D6CAA
	public void Close(bool bCloseFromSavePhoto = false)
	{
		this.Model.ClearHandler();
	}

	// Token: 0x060108E9 RID: 67817 RVA: 0x004D8AB7 File Offset: 0x004D6CB7
	public void Reset()
	{
		this.Model.ClearHandler();
	}

	// Token: 0x060108EA RID: 67818 RVA: 0x004D8AC4 File Offset: 0x004D6CC4
	public void SetFov(float v)
	{
		PhotoCameraHandler handler = this.Model.GetHandler();
		if (handler == null)
		{
			return;
		}
		handler.SetFov(v);
	}

	// Token: 0x060108EB RID: 67819 RVA: 0x004D8ADC File Offset: 0x004D6CDC
	public void InitHandlerForCaptureCollect()
	{
		this.Model.InitHandlerForCaptureCollect();
	}

	// Token: 0x060108EC RID: 67820 RVA: 0x004D8AEC File Offset: 0x004D6CEC
	private void OnCheckClientEvent(FGameplayTag tag)
	{
		int num = tag.TagId();
		if (num == GameplayTagDefine.EGameplayTagId["功能.功能制作.拍照.拍照并收集物品.开启"])
		{
			if (!UiManager.Instance.IsViewShow(EUiViewName.CaptureCollectView))
			{
				UiManager.Instance.OpenView(EUiViewName.CaptureCollectView, null, null);
				return;
			}
		}
		else if (num == GameplayTagDefine.EGameplayTagId["功能.功能制作.拍照.拍照并收集物品.关闭"] && UiManager.Instance.IsViewShow(EUiViewName.CaptureCollectView))
		{
			UiManager.Instance.CloseView(EUiViewName.CaptureCollectView, null);
		}
	}

	// Token: 0x17001918 RID: 6424
	// (get) Token: 0x060108ED RID: 67821 RVA: 0x004D8B68 File Offset: 0x004D6D68
	public static PhotographQuickController Instance
	{
		get
		{
			return PhotographQuickController._Instance;
		}
	}

	// Token: 0x060108EE RID: 67822 RVA: 0x004D8B6F File Offset: 0x004D6D6F
	public static PhotographQuickController GetOrCreateInstance()
	{
		if (PhotographQuickController._Instance == null)
		{
			PhotographQuickController.CreateInstance();
		}
		return PhotographQuickController._Instance;
	}

	// Token: 0x060108EF RID: 67823 RVA: 0x004D8B83 File Offset: 0x004D6D83
	public static bool CreateInstance()
	{
		if (PhotographQuickController._Instance != null)
		{
			return true;
		}
		PhotographQuickController._Instance = new PhotographQuickController();
		return true;
	}

	// Token: 0x060108F0 RID: 67824 RVA: 0x004D8B99 File Offset: 0x004D6D99
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060108F1 RID: 67825 RVA: 0x004D8B9B File Offset: 0x004D6D9B
	public static void ResetStaticDefaultValue()
	{
		PhotographQuickController._Instance = null;
	}

	// Token: 0x060108F2 RID: 67826 RVA: 0x004D8BA3 File Offset: 0x004D6DA3
	static PhotographQuickController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhotographQuickController.CreateStaticDefaultValue), new Action(PhotographQuickController.ResetStaticDefaultValue));
	}

	// Token: 0x040092AB RID: 37547
	[Nullable(2)]
	private static PhotographQuickController _Instance;
}
