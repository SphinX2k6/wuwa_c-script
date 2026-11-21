using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;

// Token: 0x02000F48 RID: 3912
public class UiTabCamera : UiTabViewBehavior
{
	// Token: 0x06009C80 RID: 40064 RVA: 0x002E6B76 File Offset: 0x002E4D76
	public void SetTabData(EUiTabViewName tabViewName)
	{
		this.TabData = new UiDynamicTab?(DynamicTabConfig.Instance.GetViewTab(tabViewName));
	}

	// Token: 0x06009C81 RID: 40065 RVA: 0x002E6B93 File Offset: 0x002E4D93
	public override void Init()
	{
	}

	// Token: 0x06009C82 RID: 40066 RVA: 0x002E6B98 File Offset: 0x002E4D98
	public override void Begin()
	{
		DynamicTabCamera.PlayTabUiCamera((EUiTabViewName)this.TabData.Value.ChildViewName, null);
		this.AddEvents();
	}

	// Token: 0x06009C83 RID: 40067 RVA: 0x002E6BCC File Offset: 0x002E4DCC
	public override void ShowFromToggle()
	{
		DynamicTabCamera.PlayTabUiCamera((EUiTabViewName)this.TabData.Value.ChildViewName, this.TabData.Value.BackViewBlendName);
	}

	// Token: 0x06009C84 RID: 40068 RVA: 0x002E6C0C File Offset: 0x002E4E0C
	public override void ShowFromView()
	{
		DynamicTabCamera.PlayTabUiCamera((EUiTabViewName)this.TabData.Value.ChildViewName, null);
	}

	// Token: 0x06009C85 RID: 40069 RVA: 0x002E6C37 File Offset: 0x002E4E37
	public override void Hide()
	{
	}

	// Token: 0x06009C86 RID: 40070 RVA: 0x002E6C39 File Offset: 0x002E4E39
	public override void Destroy()
	{
		this.TabData = null;
		this.RemoveEvents();
	}

	// Token: 0x06009C87 RID: 40071 RVA: 0x002E6C4D File Offset: 0x002E4E4D
	private void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraDefine.IFinishData>(this.OnPlayCameraAnimationFinish));
	}

	// Token: 0x06009C88 RID: 40072 RVA: 0x002E6C6B File Offset: 0x002E4E6B
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraDefine.IFinishData>(this.OnPlayCameraAnimationFinish));
	}

	// Token: 0x06009C89 RID: 40073 RVA: 0x002E6C89 File Offset: 0x002E4E89
	[NullableContext(1)]
	private void OnPlayCameraAnimationFinish(UiCameraDefine.IFinishData finishData)
	{
		DynamicTabCamera.OnPlayCameraAnimationFinished(finishData);
	}

	// Token: 0x04005D3A RID: 23866
	private UiDynamicTab? TabData;
}
