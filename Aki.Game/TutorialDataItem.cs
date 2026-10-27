using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C21 RID: 11297
[NullableContext(1)]
[Nullable(0)]
public class TutorialDataItem : UiPanelBase, IDynamicScrollItem<TutorialItemData>
{
	// Token: 0x0601789E RID: 96414 RVA: 0x005FC4D0 File Offset: 0x005FA6D0
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

	// Token: 0x0601789F RID: 96415 RVA: 0x005FC51B File Offset: 0x005FA71B
	public void ClearItem()
	{
	}

	// Token: 0x060178A0 RID: 96416 RVA: 0x005FC51D File Offset: 0x005FA71D
	public AUIBaseActor GetUsingItem(TutorialItemData data)
	{
		if (data.IsTypeTitle)
		{
			return base.GetItem(0).GetOwner() as AUIBaseActor;
		}
		return base.GetRootItem().GetOwner() as AUIBaseActor;
	}

	// Token: 0x060178A1 RID: 96417 RVA: 0x005FC549 File Offset: 0x005FA749
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

	// Token: 0x060178A2 RID: 96418 RVA: 0x005FC567 File Offset: 0x005FA767
	public void InitData(TutorialItemData data)
	{
		this.TutorialItemData = data;
	}

	// Token: 0x060178A3 RID: 96419 RVA: 0x005FC570 File Offset: 0x005FA770
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

	// Token: 0x060178A4 RID: 96420 RVA: 0x005FC61C File Offset: 0x005FA81C
	private void OnToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			this.OnToggleSelected(this.TutorialItemData, extendToggle);
		}
	}

	// Token: 0x060178A5 RID: 96421 RVA: 0x005FC647 File Offset: 0x005FA847
	public void SetOnToggleSelected(Action<TutorialItemData, UUIExtendToggle> onToggleSelected)
	{
		this.OnToggleSelected = onToggleSelected;
	}

	// Token: 0x060178A6 RID: 96422 RVA: 0x005FC650 File Offset: 0x005FA850
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

	// Token: 0x060178A7 RID: 96423 RVA: 0x005FC6CC File Offset: 0x005FA8CC
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

	// Token: 0x060178A8 RID: 96424 RVA: 0x005FC773 File Offset: 0x005FA973
	public void RefreshRed()
	{
		if (!this.TutorialItemData.IsTypeTitle)
		{
			base.GetItem(3).SetUIActive(this.TutorialItemData.SavedData.HasRedDot);
		}
	}

	// Token: 0x060178A9 RID: 96425 RVA: 0x005FC79E File Offset: 0x005FA99E
	public void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(2).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		this.OnToggleClick(EToggleState.ETT_Checked);
	}

	// Token: 0x060178AA RID: 96426 RVA: 0x005FC7B8 File Offset: 0x005FA9B8
	protected override void OnBeforeDestroy()
	{
		if (this.TutorialItemData != null)
		{
			this.TutorialItemData = null;
		}
	}

	// Token: 0x0400AF9F RID: 44959
	[Nullable(2)]
	private TutorialItemData TutorialItemData;

	// Token: 0x0400AFA0 RID: 44960
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<TutorialItemData, UUIExtendToggle> OnToggleSelected;

	// Token: 0x02009216 RID: 37398
	[NullableContext(0)]
	public enum EComponents
	{
		// Token: 0x0402F415 RID: 193557
		ItemTypeTitle,
		// Token: 0x0402F416 RID: 193558
		TxtTypeTitle,
		// Token: 0x0402F417 RID: 193559
		UUIItemStripD,
		// Token: 0x0402F418 RID: 193560
		PnlRedPoint,
		// Token: 0x0402F419 RID: 193561
		TxtList
	}
}
