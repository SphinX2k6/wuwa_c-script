using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000577 RID: 1399
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityLinkageTabItem : GridProxyAbstract<ActivityLinkageTabData>
{
	// Token: 0x06004368 RID: 17256 RVA: 0x001750F0 File Offset: 0x001732F0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UTexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004369 RID: 17257 RVA: 0x001751D8 File Offset: 0x001733D8
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.RefreshRedDot));
	}

	// Token: 0x0600436A RID: 17258 RVA: 0x001751F8 File Offset: 0x001733F8
	public override void Refresh(ActivityLinkageTabData tabData, bool isSelected, int gridIndex)
	{
		this.TabData = tabData;
		ActivityLinkage? config = ConfigActivityLinkageById.GetConfig(tabData.TabId, true);
		if (config == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), config.Value.TabName, Array.Empty<object>());
		base.SetTextureByPath(config.Value.SmallImage, base.GetTexture(1), null, null);
		this.RefreshRedDot(0);
	}

	// Token: 0x0600436B RID: 17259 RVA: 0x00175278 File Offset: 0x00173478
	public void RefreshRedDot(int i = 0)
	{
		ActivityLinkageTabData tabData = this.TabData;
		bool uiactive = tabData == null || !tabData.IsReceive;
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600436C RID: 17260 RVA: 0x001752AD File Offset: 0x001734AD
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new <>f__AnonymousDelegate2<int>(this.RefreshRedDot));
	}

	// Token: 0x0600436D RID: 17261 RVA: 0x001752CB File Offset: 0x001734CB
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.TabData);
		}
	}

	// Token: 0x0600436E RID: 17262 RVA: 0x001752EC File Offset: 0x001734EC
	public void SetToggleCallBack(Action<int, ActivityLinkageTabData> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x0600436F RID: 17263 RVA: 0x001752F8 File Offset: 0x001734F8
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
	}

	// Token: 0x06004370 RID: 17264 RVA: 0x0017531E File Offset: 0x0017351E
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x06004371 RID: 17265 RVA: 0x00175327 File Offset: 0x00173527
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04003486 RID: 13446
	[Nullable(2)]
	private ActivityLinkageTabData TabData;

	// Token: 0x04003487 RID: 13447
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<int, ActivityLinkageTabData> OnToggleCallBack;

	// Token: 0x02006826 RID: 26662
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04022553 RID: 140627
		public const int ToggleRoot = 0;

		// Token: 0x04022554 RID: 140628
		public const int TextureImage = 1;

		// Token: 0x04022555 RID: 140629
		public const int TextTabName = 2;

		// Token: 0x04022556 RID: 140630
		public const int ItemRedDot = 3;
	}
}
