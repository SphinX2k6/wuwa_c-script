using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020010C3 RID: 4291
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityLinkageTabItem : GridProxyAbstract<ActivityLinkageTabData>
{
	// Token: 0x06006FD2 RID: 28626 RVA: 0x0016C734 File Offset: 0x0016A934
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

	// Token: 0x06006FD3 RID: 28627 RVA: 0x0016C81C File Offset: 0x0016AA1C
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.RefreshRedDot));
	}

	// Token: 0x06006FD4 RID: 28628 RVA: 0x0016C83C File Offset: 0x0016AA3C
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

	// Token: 0x06006FD5 RID: 28629 RVA: 0x0016C8BC File Offset: 0x0016AABC
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

	// Token: 0x06006FD6 RID: 28630 RVA: 0x0016C8F1 File Offset: 0x0016AAF1
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new <>f__AnonymousDelegate2<int>(this.RefreshRedDot));
	}

	// Token: 0x06006FD7 RID: 28631 RVA: 0x0016C90F File Offset: 0x0016AB0F
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.TabData);
		}
	}

	// Token: 0x06006FD8 RID: 28632 RVA: 0x0016C930 File Offset: 0x0016AB30
	public void SetToggleCallBack(Action<int, ActivityLinkageTabData> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x06006FD9 RID: 28633 RVA: 0x0016C93C File Offset: 0x0016AB3C
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
	}

	// Token: 0x06006FDA RID: 28634 RVA: 0x0016C962 File Offset: 0x0016AB62
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x06006FDB RID: 28635 RVA: 0x0016C96B File Offset: 0x0016AB6B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x040033ED RID: 13293
	[Nullable(2)]
	private ActivityLinkageTabData TabData;

	// Token: 0x040033EE RID: 13294
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<int, ActivityLinkageTabData> OnToggleCallBack;

	// Token: 0x02007692 RID: 30354
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402720A RID: 160266
		public const int ToggleRoot = 0;

		// Token: 0x0402720B RID: 160267
		public const int TextureImage = 1;

		// Token: 0x0402720C RID: 160268
		public const int TextTabName = 2;

		// Token: 0x0402720D RID: 160269
		public const int ItemRedDot = 3;
	}
}
