using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using UnrealEngine;

// Token: 0x02000B54 RID: 2900
[Nullable(new byte[]
{
	0,
	1
})]
public class NewSoundDetectTabItemTitleItem : SyncGridProxyAbstract<NewSoundDetectTabItemData>
{
	// Token: 0x0600792B RID: 31019 RVA: 0x00258FB8 File Offset: 0x002571B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChange))
		};
	}

	// Token: 0x0600792C RID: 31020 RVA: 0x002590A8 File Offset: 0x002572A8
	[NullableContext(1)]
	public override void Refresh(NewSoundDetectTabItemData data)
	{
		this.Area = data.Area;
		this.IsVisible = data.IsVisible;
		EToggleState state = data.IsVisible ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(state, false, false, false);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TabTextId, Array.Empty<object>());
		if (!string.IsNullOrEmpty(data.IconPath))
		{
			this.SetSpriteByPath(data.IconPath, base.GetSprite(2), false, null, null);
		}
		UUISprite sprite = base.GetSprite(2);
		if (sprite != null)
		{
			sprite.SetUIActive(!string.IsNullOrEmpty(data.IconPath));
		}
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(!string.IsNullOrEmpty(data.IconPath));
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(string.IsNullOrEmpty(data.IconPath));
	}

	// Token: 0x0600792D RID: 31021 RVA: 0x00259194 File Offset: 0x00257394
	private void OnToggleStateChange(EToggleState state)
	{
		if (this.OnClickCallBack != null)
		{
			this.OnClickCallBack(this.Area, !this.IsVisible);
		}
	}

	// Token: 0x04004B73 RID: 19315
	private int Area;

	// Token: 0x04004B74 RID: 19316
	private bool IsVisible;

	// Token: 0x04004B75 RID: 19317
	[Nullable(2)]
	public Action<int, bool> OnClickCallBack;

	// Token: 0x02006DFA RID: 28154
	private enum ENewSoundDetectTabItemTitleItem
	{
		// Token: 0x0402408B RID: 147595
		Toggle,
		// Token: 0x0402408C RID: 147596
		Title,
		// Token: 0x0402408D RID: 147597
		Icon,
		// Token: 0x0402408E RID: 147598
		PanelWithIconBg,
		// Token: 0x0402408F RID: 147599
		PanelNoIconBg
	}
}
