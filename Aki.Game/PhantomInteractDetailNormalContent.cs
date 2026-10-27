using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002469 RID: 9321
public class PhantomInteractDetailNormalContent : UiPanelBase, IDetailContent
{
	// Token: 0x06012B86 RID: 76678 RVA: 0x0049E5A2 File Offset: 0x0049C7A2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06012B87 RID: 76679 RVA: 0x0049E5DB File Offset: 0x0049C7DB
	protected override void OnStart()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PhantomDisplay_GeneralSkillTitle", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PhantomDisplay_GeneralDesc", Array.Empty<object>());
	}

	// Token: 0x06012B88 RID: 76680 RVA: 0x0049E614 File Offset: 0x0049C814
	[NullableContext(1)]
	public void Refresh(PhantomInteractDetailViewModel viewModel)
	{
		TableTextArgNew item = new TableTextArgNew(viewModel.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PhantomDisplay_GeneralDesc", new <>z__ReadOnlySingleElementList<object>(item));
	}

	// Token: 0x06012B89 RID: 76681 RVA: 0x0049E64E File Offset: 0x0049C84E
	public void SetScrollListenerActive(bool active)
	{
	}

	// Token: 0x020089E5 RID: 35301
	private enum EComponent
	{
		// Token: 0x0402CC8B RID: 183435
		TxtName,
		// Token: 0x0402CC8C RID: 183436
		TxtDesc
	}
}
