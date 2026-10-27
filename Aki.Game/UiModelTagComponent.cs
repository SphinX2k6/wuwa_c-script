using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002C97 RID: 11415
[NullableContext(1)]
[Nullable(0)]
public class UiModelTagComponent : UiModelComponentBase
{
	// Token: 0x06017DBE RID: 97726 RVA: 0x006113DA File Offset: 0x0060F5DA
	protected override void OnInit()
	{
		this.AnsControllerComponent = base.Owner.CheckGetComponent<UiModelAnsControllerComponent>();
	}

	// Token: 0x06017DBF RID: 97727 RVA: 0x006113F0 File Offset: 0x0060F5F0
	protected override void OnStart()
	{
		UiModelAnsControllerComponent ansControllerComponent = this.AnsControllerComponent;
		if (ansControllerComponent != null)
		{
			ansControllerComponent.RegisterAnsTrigger("UiTagAnsContext", new Action<UiAnsContextBase>(this.OnAnsBegin), new Action<UiAnsContextBase>(this.OnAnsEnd), null, null);
		}
		this.TagComponent.AddListener(GameplayTagDefine.EGameplayTagId["UI.角色.显示属性切换预览特效"], new TTagSwitchedCallback(this.OnShowElementChangePreviewEffect));
		this.TagComponent.AddListener(GameplayTagDefine.EGameplayTagId["UI.角色.葫芦灯光动画"], new TTagSwitchedCallback(this.OnHuluLightSequenceEvent));
	}

	// Token: 0x06017DC0 RID: 97728 RVA: 0x0061147C File Offset: 0x0060F67C
	protected override void OnEnd()
	{
		this.TagComponent.RemoveListener(GameplayTagDefine.EGameplayTagId["UI.角色.显示属性切换预览特效"], new TTagSwitchedCallback(this.OnShowElementChangePreviewEffect));
		this.TagComponent.RemoveListener(GameplayTagDefine.EGameplayTagId["UI.角色.葫芦灯光动画"], new TTagSwitchedCallback(this.OnHuluLightSequenceEvent));
	}

	// Token: 0x06017DC1 RID: 97729 RVA: 0x006114D5 File Offset: 0x0060F6D5
	protected override void OnClear()
	{
		this.TagComponent.RemoveAllTag();
	}

	// Token: 0x06017DC2 RID: 97730 RVA: 0x006114E2 File Offset: 0x0060F6E2
	public void AddTagById(int tagId, params object[] args)
	{
		this.TagComponent.AddTagById(tagId, args);
	}

	// Token: 0x06017DC3 RID: 97731 RVA: 0x006114F1 File Offset: 0x0060F6F1
	public void ReduceTagById(int tagId, params object[] args)
	{
		this.TagComponent.ReduceTagById(tagId, args);
	}

	// Token: 0x06017DC4 RID: 97732 RVA: 0x00611500 File Offset: 0x0060F700
	public bool ContainsTagById(int tagId)
	{
		return this.TagComponent.ContainsTagById(tagId);
	}

	// Token: 0x06017DC5 RID: 97733 RVA: 0x0061150E File Offset: 0x0060F70E
	public void AddTagListener(int tagId, TTagSwitchedCallback callback)
	{
		this.TagComponent.AddListener(tagId, callback);
	}

	// Token: 0x06017DC6 RID: 97734 RVA: 0x0061151D File Offset: 0x0060F71D
	public void RemoveTagListener(int tagId, TTagSwitchedCallback callback)
	{
		this.TagComponent.RemoveListener(tagId, callback);
	}

	// Token: 0x06017DC7 RID: 97735 RVA: 0x0061152C File Offset: 0x0060F72C
	public void OnAnsBegin(UiAnsContextBase ansContext)
	{
		UiTagAnsContext uiTagAnsContext = ansContext as UiTagAnsContext;
		this.AddTagById(uiTagAnsContext.TagId, Array.Empty<object>());
	}

	// Token: 0x06017DC8 RID: 97736 RVA: 0x00611554 File Offset: 0x0060F754
	public void OnAnsEnd(UiAnsContextBase ansContext)
	{
		UiTagAnsContext uiTagAnsContext = ansContext as UiTagAnsContext;
		this.ReduceTagById(uiTagAnsContext.TagId, Array.Empty<object>());
	}

	// Token: 0x06017DC9 RID: 97737 RVA: 0x00611579 File Offset: 0x0060F779
	private void OnShowElementChangePreviewEffect(int tagId, bool tagExist, params object[] _)
	{
		EventSystem.Instance.Emit<bool>(EEventName.ShowRoleElementChangePreviewEffect, tagExist);
	}

	// Token: 0x06017DCA RID: 97738 RVA: 0x0061158C File Offset: 0x0060F78C
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

	// Token: 0x0400B1E4 RID: 45540
	private readonly UiTagComponent TagComponent = new UiTagComponent();

	// Token: 0x0400B1E5 RID: 45541
	[Nullable(2)]
	private UiModelAnsControllerComponent AnsControllerComponent;
}
