using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001283 RID: 4739
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoTaskTabItem : GridProxyAbstract<PhotoFightRewardTab>
{
	// Token: 0x06008168 RID: 33128 RVA: 0x001B7404 File Offset: 0x001B5604
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06008169 RID: 33129 RVA: 0x001B7484 File Offset: 0x001B5684
	public override void Refresh(PhotoFightRewardTab data, bool isSelected, int gridIndex)
	{
		this.Data = new PhotoFightRewardTab?(data);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TabTitle, Array.Empty<object>());
		bool uiactive = this.activityData.IsTaskHasRedDotByTab(data.TabId);
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600816A RID: 33130 RVA: 0x001B74E0 File Offset: 0x001B56E0
	private void OnToggleClick(EToggleState toggleState)
	{
		this.OnToggleClickCallBack(this.Data.Value.TabId);
	}

	// Token: 0x0600816B RID: 33131 RVA: 0x001B750B File Offset: 0x001B570B
	public override object GetKey(PhotoFightRewardTab data, int displayIndex)
	{
		return data.TabId;
	}

	// Token: 0x0600816C RID: 33132 RVA: 0x001B751C File Offset: 0x001B571C
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600816D RID: 33133 RVA: 0x001B7542 File Offset: 0x001B5742
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600816E RID: 33134 RVA: 0x001B754B File Offset: 0x001B574B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04003AA3 RID: 15011
	private PhotoFightRewardTab? Data;

	// Token: 0x04003AA4 RID: 15012
	public FightPhotoActivityData activityData;

	// Token: 0x04003AA5 RID: 15013
	public Action<int> OnToggleClickCallBack = delegate(int tabId)
	{
	};

	// Token: 0x0200789A RID: 30874
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027BCE RID: 162766
		ToggleRoot,
		// Token: 0x04027BCF RID: 162767
		TextTabName,
		// Token: 0x04027BD0 RID: 162768
		ItemRedDot
	}
}
