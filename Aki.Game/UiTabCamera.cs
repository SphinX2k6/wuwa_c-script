using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02001A89 RID: 6793
public class UiTabCamera : UiTabViewBehavior
{
	// Token: 0x0600C86F RID: 51311 RVA: 0x002DB9CE File Offset: 0x002D9BCE
	public void SetTabData(EUiTabViewName tabViewName)
	{
		this.TabData = new UiDynamicTab?(DynamicTabConfig.Instance.GetViewTab(tabViewName));
	}

	// Token: 0x0600C870 RID: 51312 RVA: 0x002DB9EB File Offset: 0x002D9BEB
	public override void Init()
	{
	}

	// Token: 0x0600C871 RID: 51313 RVA: 0x002DB9F0 File Offset: 0x002D9BF0
	public override void Begin()
	{
		DynamicTabCamera.PlayTabUiCamera((EUiTabViewName)this.TabData.Value.ChildViewName, null);
		this.AddEvents();
	}

	// Token: 0x0600C872 RID: 51314 RVA: 0x002DBA24 File Offset: 0x002D9C24
	public override void ShowFromToggle()
	{
		DynamicTabCamera.PlayTabUiCamera((EUiTabViewName)this.TabData.Value.ChildViewName, this.TabData.Value.BackViewBlendName);
	}

	// Token: 0x0600C873 RID: 51315 RVA: 0x002DBA64 File Offset: 0x002D9C64
	public override void ShowFromView()
	{
		DynamicTabCamera.PlayTabUiCamera((EUiTabViewName)this.TabData.Value.ChildViewName, null);
	}

	// Token: 0x0600C874 RID: 51316 RVA: 0x002DBA8F File Offset: 0x002D9C8F
	public override void Hide()
	{
	}

	// Token: 0x0600C875 RID: 51317 RVA: 0x002DBA91 File Offset: 0x002D9C91
	public override void Destroy()
	{
		this.TabData = null;
		this.RemoveEvents();
	}

	// Token: 0x0600C876 RID: 51318 RVA: 0x002DBAA5 File Offset: 0x002D9CA5
	private void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraAnimationDefine.IFinishData>(this.OnPlayCameraAnimationFinish));
	}

	// Token: 0x0600C877 RID: 51319 RVA: 0x002DBAC3 File Offset: 0x002D9CC3
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraAnimationDefine.IFinishData>(this.OnPlayCameraAnimationFinish));
	}

	// Token: 0x0600C878 RID: 51320 RVA: 0x002DBAE1 File Offset: 0x002D9CE1
	[NullableContext(1)]
	private void OnPlayCameraAnimationFinish(UiCameraAnimationDefine.IFinishData finishData)
	{
		DynamicTabCamera.OnPlayCameraAnimationFinished(finishData);
	}

	// Token: 0x04005C6B RID: 23659
	private UiDynamicTab? TabData;
}
