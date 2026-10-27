using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using UnrealEngine;

// Token: 0x0200169C RID: 5788
[Nullable(new byte[]
{
	0,
	1
})]
public class NewSoundDetectTabItemTitleItem : SyncGridProxyAbstract<NewSoundDetectTabItemData>
{
	// Token: 0x0600A54B RID: 42315 RVA: 0x0024EB9C File Offset: 0x0024CD9C
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

	// Token: 0x0600A54C RID: 42316 RVA: 0x0024EC8C File Offset: 0x0024CE8C
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

	// Token: 0x0600A54D RID: 42317 RVA: 0x0024ED78 File Offset: 0x0024CF78
	private void OnToggleStateChange(EToggleState state)
	{
		if (this.OnClickCallBack != null)
		{
			this.OnClickCallBack(this.Area, !this.IsVisible);
		}
	}

	// Token: 0x04004ACC RID: 19148
	private int Area;

	// Token: 0x04004ACD RID: 19149
	private bool IsVisible;

	// Token: 0x04004ACE RID: 19150
	[Nullable(2)]
	public Action<int, bool> OnClickCallBack;

	// Token: 0x02007C75 RID: 31861
	private enum ENewSoundDetectTabItemTitleItem
	{
		// Token: 0x04028D62 RID: 167266
		Toggle,
		// Token: 0x04028D63 RID: 167267
		Title,
		// Token: 0x04028D64 RID: 167268
		Icon,
		// Token: 0x04028D65 RID: 167269
		PanelWithIconBg,
		// Token: 0x04028D66 RID: 167270
		PanelNoIconBg
	}
}
