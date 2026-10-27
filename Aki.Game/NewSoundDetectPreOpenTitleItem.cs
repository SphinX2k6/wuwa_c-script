using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using UnrealEngine;

// Token: 0x0200169E RID: 5790
[Nullable(new byte[]
{
	0,
	1
})]
public class NewSoundDetectPreOpenTitleItem : SyncGridProxyAbstract<NewSoundDetectTabItemData>
{
	// Token: 0x0600A552 RID: 42322 RVA: 0x0024EDCC File Offset: 0x0024CFCC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChange))
		};
	}

	// Token: 0x0600A553 RID: 42323 RVA: 0x0024EE38 File Offset: 0x0024D038
	[NullableContext(1)]
	public override void Refresh(NewSoundDetectTabItemData data)
	{
		this.Area = data.Area;
		this.IsVisible = data.IsVisible;
		EToggleState state = data.IsVisible ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x0600A554 RID: 42324 RVA: 0x0024EE80 File Offset: 0x0024D080
	private void OnToggleStateChange(EToggleState state)
	{
		if (this.OnClickCallBack != null)
		{
			this.OnClickCallBack(this.Area, !this.IsVisible);
		}
	}

	// Token: 0x04004AD0 RID: 19152
	private int Area;

	// Token: 0x04004AD1 RID: 19153
	private bool IsVisible;

	// Token: 0x04004AD2 RID: 19154
	[Nullable(2)]
	public Action<int, bool> OnClickCallBack;

	// Token: 0x02007C76 RID: 31862
	private enum ENewSoundDetectPreOpenTitleItem
	{
		// Token: 0x04028D68 RID: 167272
		Toggle
	}
}
