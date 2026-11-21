using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000737 RID: 1847
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoTaskTabItem : GridProxyAbstract<PhotoFightRewardTab>
{
	// Token: 0x060054FF RID: 21759 RVA: 0x001C00D4 File Offset: 0x001BE2D4
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

	// Token: 0x06005500 RID: 21760 RVA: 0x001C0154 File Offset: 0x001BE354
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

	// Token: 0x06005501 RID: 21761 RVA: 0x001C01B0 File Offset: 0x001BE3B0
	private void OnToggleClick(EToggleState toggleState)
	{
		this.OnToggleClickCallBack(this.Data.Value.TabId);
	}

	// Token: 0x06005502 RID: 21762 RVA: 0x001C01DB File Offset: 0x001BE3DB
	public override object GetKey(PhotoFightRewardTab data, int displayIndex)
	{
		return data.TabId;
	}

	// Token: 0x06005503 RID: 21763 RVA: 0x001C01EC File Offset: 0x001BE3EC
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
	}

	// Token: 0x06005504 RID: 21764 RVA: 0x001C0212 File Offset: 0x001BE412
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x06005505 RID: 21765 RVA: 0x001C021B File Offset: 0x001BE41B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04003B3B RID: 15163
	private PhotoFightRewardTab? Data;

	// Token: 0x04003B3C RID: 15164
	public FightPhotoActivityData activityData;

	// Token: 0x04003B3D RID: 15165
	public Action<int> OnToggleClickCallBack = delegate(int tabId)
	{
	};

	// Token: 0x02006A25 RID: 27173
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022EFF RID: 143103
		ToggleRoot,
		// Token: 0x04022F00 RID: 143104
		TextTabName,
		// Token: 0x04022F01 RID: 143105
		ItemRedDot
	}
}
