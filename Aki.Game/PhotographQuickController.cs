using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002552 RID: 9554
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class PhotographQuickController : ControllerBase
{
	// Token: 0x170018DE RID: 6366
	// (get) Token: 0x060133FD RID: 78845 RVA: 0x004C9D07 File Offset: 0x004C7F07
	public PhotographQuickModel Model
	{
		get
		{
			return PhotographQuickModel.Instance;
		}
	}

	// Token: 0x060133FE RID: 78846 RVA: 0x004C9D0E File Offset: 0x004C7F0E
	protected override bool OnInit()
	{
		this.OnAddEvents();
		return true;
	}

	// Token: 0x060133FF RID: 78847 RVA: 0x004C9D17 File Offset: 0x004C7F17
	protected override bool OnLeaveLevel()
	{
		this.Reset();
		return true;
	}

	// Token: 0x06013400 RID: 78848 RVA: 0x004C9D20 File Offset: 0x004C7F20
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x06013401 RID: 78849 RVA: 0x004C9D2C File Offset: 0x004C7F2C
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
		EventSystem.Instance.Add<FGameplayTag>(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnCheckClientEvent));
		InputDistributeController.Instance.BindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
		InputDistributeController.Instance.BindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
	}

	// Token: 0x06013402 RID: 78850 RVA: 0x004C9DC4 File Offset: 0x004C7FC4
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Remove(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
		EventSystem.Instance.Remove(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnCheckClientEvent));
		InputDistributeController.Instance.UnBindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
		InputDistributeController.Instance.UnBindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
	}

	// Token: 0x06013403 RID: 78851 RVA: 0x004C9E5C File Offset: 0x004C805C
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

	// Token: 0x06013404 RID: 78852 RVA: 0x004C9EAC File Offset: 0x004C80AC
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

	// Token: 0x06013405 RID: 78853 RVA: 0x004C9EF8 File Offset: 0x004C80F8
	protected override void OnTick(float delta)
	{
		if (this.Model.GetHandler() == null)
		{
			return;
		}
		this.Model.GetHandler().ApplyCameraDelta();
	}

	// Token: 0x06013406 RID: 78854 RVA: 0x004C9F18 File Offset: 0x004C8118
	private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		this.Close(false);
	}

	// Token: 0x06013407 RID: 78855 RVA: 0x004C9F21 File Offset: 0x004C8121
	private void OnRoleDead(int charId)
	{
		this.Close(false);
	}

	// Token: 0x06013408 RID: 78856 RVA: 0x004C9F2A File Offset: 0x004C812A
	public void Close(bool bCloseFromSavePhoto = false)
	{
		this.Model.ClearHandler();
	}

	// Token: 0x06013409 RID: 78857 RVA: 0x004C9F37 File Offset: 0x004C8137
	public void Reset()
	{
		this.Model.ClearHandler();
	}

	// Token: 0x0601340A RID: 78858 RVA: 0x004C9F44 File Offset: 0x004C8144
	public void SetFov(float v)
	{
		PhotoCameraHandler handler = this.Model.GetHandler();
		if (handler == null)
		{
			return;
		}
		handler.SetFov(v);
	}

	// Token: 0x0601340B RID: 78859 RVA: 0x004C9F5C File Offset: 0x004C815C
	public void InitHandlerForCaptureCollect()
	{
		this.Model.InitHandlerForCaptureCollect();
	}

	// Token: 0x0601340C RID: 78860 RVA: 0x004C9F6C File Offset: 0x004C816C
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

	// Token: 0x170018DF RID: 6367
	// (get) Token: 0x0601340D RID: 78861 RVA: 0x004C9FE8 File Offset: 0x004C81E8
	public static PhotographQuickController Instance
	{
		get
		{
			return PhotographQuickController._Instance;
		}
	}

	// Token: 0x0601340E RID: 78862 RVA: 0x004C9FEF File Offset: 0x004C81EF
	public static PhotographQuickController GetOrCreateInstance()
	{
		if (PhotographQuickController._Instance == null)
		{
			PhotographQuickController.CreateInstance();
		}
		return PhotographQuickController._Instance;
	}

	// Token: 0x0601340F RID: 78863 RVA: 0x004CA003 File Offset: 0x004C8203
	public static bool CreateInstance()
	{
		if (PhotographQuickController._Instance != null)
		{
			return true;
		}
		PhotographQuickController._Instance = new PhotographQuickController();
		return true;
	}

	// Token: 0x06013410 RID: 78864 RVA: 0x004CA019 File Offset: 0x004C8219
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013411 RID: 78865 RVA: 0x004CA01B File Offset: 0x004C821B
	public static void ResetStaticDefaultValue()
	{
		PhotographQuickController._Instance = null;
	}

	// Token: 0x06013412 RID: 78866 RVA: 0x004CA023 File Offset: 0x004C8223
	static PhotographQuickController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhotographQuickController.CreateStaticDefaultValue), new Action(PhotographQuickController.ResetStaticDefaultValue));
	}

	// Token: 0x04009152 RID: 37202
	[Nullable(2)]
	private static PhotographQuickController _Instance;
}
