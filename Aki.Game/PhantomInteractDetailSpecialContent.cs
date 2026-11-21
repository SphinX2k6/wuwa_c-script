using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001956 RID: 6486
public class PhantomInteractDetailSpecialContent : UiPanelBase, IDetailContent
{
	// Token: 0x0601005A RID: 65626 RVA: 0x004AC17C File Offset: 0x004AA37C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent))
		};
	}

	// Token: 0x0601005B RID: 65627 RVA: 0x004AC202 File Offset: 0x004AA402
	protected override void OnStart()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PhantomDisplay_SpecialSkillTitle", Array.Empty<object>());
	}

	// Token: 0x0601005C RID: 65628 RVA: 0x004AC220 File Offset: 0x004AA420
	[NullableContext(1)]
	public void Refresh(PhantomInteractDetailViewModel viewModel)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), viewModel.SkillDescription, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), viewModel.SkillName, Array.Empty<object>());
		UUITexture texture = base.GetTexture(1);
		if (viewModel.SkillPicturePath != null && texture != null)
		{
			base.SetTextureByPath(viewModel.SkillPicturePath, texture, null, null);
		}
	}

	// Token: 0x0601005D RID: 65629 RVA: 0x004AC290 File Offset: 0x004AA490
	public void SetScrollListenerActive(bool active)
	{
		if (!Info.Instance.IsPcPlatform() || this.ScrollListenerActive == active)
		{
			return;
		}
		ULGUIEventSystem lguiEventSystem = LguiEventSystemManager.Instance.LguiEventSystem;
		if (lguiEventSystem == null)
		{
			return;
		}
		this.ScrollListenerActive = active;
		if (active)
		{
			lguiEventSystem.OnScrollTriggeredDelegate.Bind(new Action<ULGUIPointerEventData>(this.OnGlobalScrollTriggered));
			return;
		}
		lguiEventSystem.OnScrollTriggeredDelegate.Unbind();
	}

	// Token: 0x0601005E RID: 65630 RVA: 0x004AC2F0 File Offset: 0x004AA4F0
	[NullableContext(2)]
	private void OnGlobalScrollTriggered(ULGUIPointerEventData eventData)
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar == null || !scrollViewWithScrollbar.IsValid())
		{
			return;
		}
		scrollViewWithScrollbar.TriggerScrollEventManually(eventData);
	}

	// Token: 0x04008E55 RID: 36437
	private bool ScrollListenerActive;

	// Token: 0x02007B73 RID: 31603
	private enum EComponent
	{
		// Token: 0x04027FBE RID: 163774
		TxtName,
		// Token: 0x04027FBF RID: 163775
		TexPix,
		// Token: 0x04027FC0 RID: 163776
		TxtDescTitle,
		// Token: 0x04027FC1 RID: 163777
		TxtDesc,
		// Token: 0x04027FC2 RID: 163778
		SvDesc
	}
}
