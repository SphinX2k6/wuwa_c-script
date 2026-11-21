using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200219C RID: 8604
[NullableContext(1)]
[Nullable(0)]
public class TutorialDataItem : UiPanelBase, IDynamicScrollItem<TutorialItemData>
{
	// Token: 0x060152D0 RID: 86736 RVA: 0x00628EF4 File Offset: 0x006270F4
	public UniTask Init(UUIItem actor)
	{
		TutorialDataItem.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<TutorialDataItem.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060152D1 RID: 86737 RVA: 0x00628F3F File Offset: 0x0062713F
	public void ClearItem()
	{
	}

	// Token: 0x060152D2 RID: 86738 RVA: 0x00628F41 File Offset: 0x00627141
	public AUIBaseActor GetUsingItem(TutorialItemData data)
	{
		if (data.IsTypeTitle)
		{
			return base.GetItem(0).GetOwner() as AUIBaseActor;
		}
		return base.GetRootItem().GetOwner() as AUIBaseActor;
	}

	// Token: 0x060152D3 RID: 86739 RVA: 0x00628F6D File Offset: 0x0062716D
	public void Update(TutorialItemData data, int index)
	{
		this.TutorialItemData = data;
		if (data.IsTypeTitle)
		{
			this.RefreshTitleItem();
			return;
		}
		this.RefreshTutorialItem();
	}

	// Token: 0x060152D4 RID: 86740 RVA: 0x00628F8B File Offset: 0x0062718B
	public void InitData(TutorialItemData data)
	{
		this.TutorialItemData = data;
	}

	// Token: 0x060152D5 RID: 86741 RVA: 0x00628F94 File Offset: 0x00627194
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x060152D6 RID: 86742 RVA: 0x00629040 File Offset: 0x00627240
	private void OnToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			this.OnToggleSelected(this.TutorialItemData, extendToggle);
		}
	}

	// Token: 0x060152D7 RID: 86743 RVA: 0x0062906B File Offset: 0x0062726B
	public void SetOnToggleSelected(Action<TutorialItemData, UUIExtendToggle> onToggleSelected)
	{
		this.OnToggleSelected = onToggleSelected;
	}

	// Token: 0x060152D8 RID: 86744 RVA: 0x00629074 File Offset: 0x00627274
	private void RefreshTitleItem()
	{
		base.GetItem(0).SetUIActive(true);
		base.GetExtendToggle(2).RootUIComp.Get().SetUIActive(false);
		UUIText text = base.GetText(1);
		if (string.IsNullOrEmpty(this.TutorialItemData.Text))
		{
			LguiUtil.Instance.SetLocalTextNew(text, this.TutorialItemData.TextId, Array.Empty<object>());
			return;
		}
		text.SetText(this.TutorialItemData.Text, true);
	}

	// Token: 0x060152D9 RID: 86745 RVA: 0x006290F0 File Offset: 0x006272F0
	private void RefreshTutorialItem()
	{
		base.GetItem(0).SetUIActive(false);
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		extendToggle.RootUIComp.Get().SetUIActive(true);
		UUIText text = base.GetText(4);
		if (string.IsNullOrEmpty(this.TutorialItemData.Text))
		{
			LguiUtil.Instance.SetLocalTextNew(text, this.TutorialItemData.TextId, Array.Empty<object>());
		}
		else
		{
			text.SetText(this.TutorialItemData.Text, true);
		}
		this.RefreshRed();
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		if (this.TutorialItemData.Selected.GetValueOrDefault())
		{
			this.OnSelected(true);
		}
	}

	// Token: 0x060152DA RID: 86746 RVA: 0x00629197 File Offset: 0x00627397
	public void RefreshRed()
	{
		if (!this.TutorialItemData.IsTypeTitle)
		{
			base.GetItem(3).SetUIActive(this.TutorialItemData.SavedData.HasRedDot);
		}
	}

	// Token: 0x060152DB RID: 86747 RVA: 0x006291C2 File Offset: 0x006273C2
	public void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(2).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		this.OnToggleClick(EToggleState.ETT_Checked);
	}

	// Token: 0x060152DC RID: 86748 RVA: 0x006291DC File Offset: 0x006273DC
	protected override void OnBeforeDestroy()
	{
		if (this.TutorialItemData != null)
		{
			this.TutorialItemData = null;
		}
	}

	// Token: 0x0400B3A4 RID: 45988
	[Nullable(2)]
	private TutorialItemData TutorialItemData;

	// Token: 0x0400B3A5 RID: 45989
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<TutorialItemData, UUIExtendToggle> OnToggleSelected;

	// Token: 0x02008459 RID: 33881
	[NullableContext(0)]
	public enum EComponents
	{
		// Token: 0x0402AB16 RID: 174870
		ItemTypeTitle,
		// Token: 0x0402AB17 RID: 174871
		TxtTypeTitle,
		// Token: 0x0402AB18 RID: 174872
		UUIItemStripD,
		// Token: 0x0402AB19 RID: 174873
		PnlRedPoint,
		// Token: 0x0402AB1A RID: 174874
		TxtList
	}
}
