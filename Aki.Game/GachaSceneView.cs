using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;

// Token: 0x02001CA3 RID: 7331
public class GachaSceneView : UiTickViewBase
{
	// Token: 0x0600DD5E RID: 56670 RVA: 0x0033C7AC File Offset: 0x0033A9AC
	[NullableContext(1)]
	public GachaSceneView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DD5F RID: 56671 RVA: 0x0033C7B5 File Offset: 0x0033A9B5
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.CloseGachaSceneView, new Action(this.CloseViewEvent));
		this.AfterAddEventListener();
	}

	// Token: 0x0600DD60 RID: 56672 RVA: 0x0033C7D9 File Offset: 0x0033A9D9
	protected virtual void AfterAddEventListener()
	{
	}

	// Token: 0x0600DD61 RID: 56673 RVA: 0x0033C7DB File Offset: 0x0033A9DB
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CloseGachaSceneView, new Action(this.CloseViewEvent));
		this.AfterRemoveEventListener();
	}

	// Token: 0x0600DD62 RID: 56674 RVA: 0x0033C7FF File Offset: 0x0033A9FF
	protected virtual void AfterRemoveEventListener()
	{
	}

	// Token: 0x0600DD63 RID: 56675 RVA: 0x0033C801 File Offset: 0x0033AA01
	protected void CloseViewEvent()
	{
		this.BindCloseUiScene();
	}

	// Token: 0x0600DD64 RID: 56676 RVA: 0x0033C809 File Offset: 0x0033AA09
	protected override void OnBeforeShow()
	{
		this.OnAfterOpenUiScene();
	}

	// Token: 0x0600DD65 RID: 56677 RVA: 0x0033C811 File Offset: 0x0033AA11
	protected virtual void OnAfterOpenUiScene()
	{
	}

	// Token: 0x0600DD66 RID: 56678 RVA: 0x0033C813 File Offset: 0x0033AA13
	protected override void OnStart()
	{
		GachaModel.Instance.CanCloseView = false;
		this.OnAfterInitComponentsData();
	}

	// Token: 0x0600DD67 RID: 56679 RVA: 0x0033C826 File Offset: 0x0033AA26
	private void BindCloseUiScene()
	{
		this.AfterCloseUiScene(true);
	}

	// Token: 0x0600DD68 RID: 56680 RVA: 0x0033C830 File Offset: 0x0033AA30
	private void AfterCloseUiScene(bool ret)
	{
		if (!ret)
		{
			return;
		}
		this.OnAfterCloseUiScene();
		GachaModel.Instance.CanCloseView = true;
		if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
		{
			base.CloseMe(null);
		}
		EventSystem.Instance.Emit(EEventName.AfterCloseGachaScene);
	}

	// Token: 0x0600DD69 RID: 56681 RVA: 0x0033C880 File Offset: 0x0033AA80
	protected virtual void OnAfterCloseUiScene()
	{
	}

	// Token: 0x0600DD6A RID: 56682 RVA: 0x0033C882 File Offset: 0x0033AA82
	protected virtual void OnBeforeDestroyImplementImplement()
	{
	}

	// Token: 0x0600DD6B RID: 56683 RVA: 0x0033C884 File Offset: 0x0033AA84
	protected override void OnBeforeDestroyImplement()
	{
		GachaModel.Instance.CanCloseView = true;
		this.OnBeforeDestroyImplementImplement();
	}

	// Token: 0x0600DD6C RID: 56684 RVA: 0x0033C897 File Offset: 0x0033AA97
	protected virtual void OnAfterInitComponentsData()
	{
	}

	// Token: 0x04006598 RID: 26008
	[Nullable(2)]
	protected UiCameraHandleData UiCameraHandleData;
}
