using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002471 RID: 9329
public class PhantomInteractDetailSpecialContent : UiPanelBase, IDetailContent
{
	// Token: 0x06012BA2 RID: 76706 RVA: 0x0049EA10 File Offset: 0x0049CC10
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

	// Token: 0x06012BA3 RID: 76707 RVA: 0x0049EA96 File Offset: 0x0049CC96
	protected override void OnStart()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PhantomDisplay_SpecialSkillTitle", Array.Empty<object>());
	}

	// Token: 0x06012BA4 RID: 76708 RVA: 0x0049EAB4 File Offset: 0x0049CCB4
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

	// Token: 0x06012BA5 RID: 76709 RVA: 0x0049EB24 File Offset: 0x0049CD24
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

	// Token: 0x06012BA6 RID: 76710 RVA: 0x0049EB84 File Offset: 0x0049CD84
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

	// Token: 0x04008D0E RID: 36110
	private bool ScrollListenerActive;

	// Token: 0x020089EC RID: 35308
	private enum EComponent
	{
		// Token: 0x0402CCA8 RID: 183464
		TxtName,
		// Token: 0x0402CCA9 RID: 183465
		TexPix,
		// Token: 0x0402CCAA RID: 183466
		TxtDescTitle,
		// Token: 0x0402CCAB RID: 183467
		TxtDesc,
		// Token: 0x0402CCAC RID: 183468
		SvDesc
	}
}
