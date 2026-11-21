using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200194E RID: 6478
public class PhantomInteractDetailNormalContent : UiPanelBase, IDetailContent
{
	// Token: 0x0601003E RID: 65598 RVA: 0x004ABD0E File Offset: 0x004A9F0E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0601003F RID: 65599 RVA: 0x004ABD47 File Offset: 0x004A9F47
	protected override void OnStart()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PhantomDisplay_GeneralSkillTitle", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PhantomDisplay_GeneralDesc", Array.Empty<object>());
	}

	// Token: 0x06010040 RID: 65600 RVA: 0x004ABD80 File Offset: 0x004A9F80
	[NullableContext(1)]
	public void Refresh(PhantomInteractDetailViewModel viewModel)
	{
		TableTextArgNew item = new TableTextArgNew(viewModel.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PhantomDisplay_GeneralDesc", new <>z__ReadOnlySingleElementList<object>(item));
	}

	// Token: 0x06010041 RID: 65601 RVA: 0x004ABDBA File Offset: 0x004A9FBA
	public void SetScrollListenerActive(bool active)
	{
	}

	// Token: 0x02007B6C RID: 31596
	private enum EComponent
	{
		// Token: 0x04027FA1 RID: 163745
		TxtName,
		// Token: 0x04027FA2 RID: 163746
		TxtDesc
	}
}
