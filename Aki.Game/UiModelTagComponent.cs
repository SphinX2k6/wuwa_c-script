using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020021F0 RID: 8688
[NullableContext(1)]
[Nullable(0)]
public class UiModelTagComponent : UiModelComponentBase
{
	// Token: 0x06015632 RID: 87602 RVA: 0x00636F7A File Offset: 0x0063517A
	protected override void OnInit()
	{
		this.AnsControllerComponent = base.Owner.CheckGetComponent<UiModelAnsControllerComponent>();
	}

	// Token: 0x06015633 RID: 87603 RVA: 0x00636F90 File Offset: 0x00635190
	protected override void OnStart()
	{
		UiModelAnsControllerComponent ansControllerComponent = this.AnsControllerComponent;
		if (ansControllerComponent != null)
		{
			ansControllerComponent.RegisterAnsTrigger(typeof(UiTagAnsContext), new Action<UiAnsContextBase>(this.OnAnsBegin), new Action<UiAnsContextBase>(this.OnAnsEnd), null, null);
		}
		this.TagComponent.AddListener(GameplayTagDefine.EGameplayTagId["UI.角色.显示属性切换预览特效"], new TTagSwitchedCallback(this.OnShowElementChangePreviewEffect));
		this.TagComponent.AddListener(GameplayTagDefine.EGameplayTagId["UI.角色.葫芦灯光动画"], new TTagSwitchedCallback(this.OnHuluLightSequenceEvent));
	}

	// Token: 0x06015634 RID: 87604 RVA: 0x00637020 File Offset: 0x00635220
	protected override void OnEnd()
	{
		this.TagComponent.RemoveListener(GameplayTagDefine.EGameplayTagId["UI.角色.显示属性切换预览特效"], new TTagSwitchedCallback(this.OnShowElementChangePreviewEffect));
		this.TagComponent.RemoveListener(GameplayTagDefine.EGameplayTagId["UI.角色.葫芦灯光动画"], new TTagSwitchedCallback(this.OnHuluLightSequenceEvent));
	}

	// Token: 0x06015635 RID: 87605 RVA: 0x00637079 File Offset: 0x00635279
	protected override void OnClear()
	{
		this.TagComponent.RemoveAllTag();
	}

	// Token: 0x06015636 RID: 87606 RVA: 0x00637086 File Offset: 0x00635286
	public void AddTagById(int tagId, params object[] args)
	{
		this.TagComponent.AddTagById(tagId, args);
	}

	// Token: 0x06015637 RID: 87607 RVA: 0x00637095 File Offset: 0x00635295
	public void ReduceTagById(int tagId, params object[] args)
	{
		this.TagComponent.ReduceTagById(tagId, args);
	}

	// Token: 0x06015638 RID: 87608 RVA: 0x006370A4 File Offset: 0x006352A4
	public bool ContainsTagById(int tagId)
	{
		return this.TagComponent.ContainsTagById(tagId);
	}

	// Token: 0x06015639 RID: 87609 RVA: 0x006370B2 File Offset: 0x006352B2
	public void AddTagListener(int tagId, TTagSwitchedCallback callback)
	{
		this.TagComponent.AddListener(tagId, callback);
	}

	// Token: 0x0601563A RID: 87610 RVA: 0x006370C1 File Offset: 0x006352C1
	public void RemoveTagListener(int tagId, TTagSwitchedCallback callback)
	{
		this.TagComponent.RemoveListener(tagId, callback);
	}

	// Token: 0x0601563B RID: 87611 RVA: 0x006370D0 File Offset: 0x006352D0
	public void OnAnsBegin(UiAnsContextBase ansContext)
	{
		UiTagAnsContext uiTagAnsContext = ansContext as UiTagAnsContext;
		this.AddTagById(uiTagAnsContext.TagId, Array.Empty<object>());
	}

	// Token: 0x0601563C RID: 87612 RVA: 0x006370F8 File Offset: 0x006352F8
	public void OnAnsEnd(UiAnsContextBase ansContext)
	{
		UiTagAnsContext uiTagAnsContext = ansContext as UiTagAnsContext;
		this.ReduceTagById(uiTagAnsContext.TagId, Array.Empty<object>());
	}

	// Token: 0x0601563D RID: 87613 RVA: 0x0063711D File Offset: 0x0063531D
	private void OnShowElementChangePreviewEffect(int tagId, bool tagExist, params object[] _)
	{
		EventSystem.Instance.Emit<bool>(EEventName.ShowRoleElementChangePreviewEffect, tagExist);
	}

	// Token: 0x0601563E RID: 87614 RVA: 0x00637130 File Offset: 0x00635330
	private void OnHuluLightSequenceEvent(int tagId, bool tagExist, params object[] _)
	{
		UiRoleHuluLightSequenceComponent uiRoleHuluLightSequenceComponent = base.Owner.CheckGetComponent<UiRoleHuluLightSequenceComponent>();
		if (tagExist)
		{
			if (uiRoleHuluLightSequenceComponent != null)
			{
				uiRoleHuluLightSequenceComponent.PlayLightSequence();
				return;
			}
		}
		else if (uiRoleHuluLightSequenceComponent != null)
		{
			uiRoleHuluLightSequenceComponent.StopLightSequence();
		}
	}

	// Token: 0x0400B54F RID: 46415
	private readonly UiTagComponent TagComponent = new UiTagComponent();

	// Token: 0x0400B550 RID: 46416
	[Nullable(2)]
	private UiModelAnsControllerComponent AnsControllerComponent;
}
