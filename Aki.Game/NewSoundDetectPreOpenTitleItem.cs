using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using UnrealEngine;

// Token: 0x02000B56 RID: 2902
[Nullable(new byte[]
{
	0,
	1
})]
public class NewSoundDetectPreOpenTitleItem : SyncGridProxyAbstract<NewSoundDetectTabItemData>
{
	// Token: 0x06007932 RID: 31026 RVA: 0x002591E8 File Offset: 0x002573E8
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

	// Token: 0x06007933 RID: 31027 RVA: 0x00259254 File Offset: 0x00257454
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

	// Token: 0x06007934 RID: 31028 RVA: 0x0025929C File Offset: 0x0025749C
	private void OnToggleStateChange(EToggleState state)
	{
		if (this.OnClickCallBack != null)
		{
			this.OnClickCallBack(this.Area, !this.IsVisible);
		}
	}

	// Token: 0x04004B77 RID: 19319
	private int Area;

	// Token: 0x04004B78 RID: 19320
	private bool IsVisible;

	// Token: 0x04004B79 RID: 19321
	[Nullable(2)]
	public Action<int, bool> OnClickCallBack;

	// Token: 0x02006DFB RID: 28155
	private enum ENewSoundDetectPreOpenTitleItem
	{
		// Token: 0x04024091 RID: 147601
		Toggle
	}
}
