using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001550 RID: 5456
public class DangoAbyssWorldLoadingView : LoadingViewBase
{
	// Token: 0x0600DA72 RID: 55922 RVA: 0x0040AA0E File Offset: 0x00408C0E
	[NullableContext(1)]
	public DangoAbyssWorldLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DA73 RID: 55923 RVA: 0x0040AA18 File Offset: 0x00408C18
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600DA74 RID: 55924 RVA: 0x0040AAC3 File Offset: 0x00408CC3
	protected override void OnStart()
	{
		base.OnStart();
		UUIItem item = base.GetItem(1);
		this.FullSize = ((item != null) ? item.Width : 0f);
	}

	// Token: 0x0600DA75 RID: 55925 RVA: 0x0040AAE8 File Offset: 0x00408CE8
	protected override void UpdateProgressRate(float rate)
	{
		base.SetTextureProgressRate(0, rate);
		float anchorOffsetX = this.FullSize * rate;
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetAnchorOffsetX(anchorOffsetX);
	}

	// Token: 0x0600DA76 RID: 55926 RVA: 0x0040AB18 File Offset: 0x00408D18
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(3, value, "%");
	}

	// Token: 0x0600DA77 RID: 55927 RVA: 0x0040AB27 File Offset: 0x00408D27
	protected override void OnLevelSequencePlayerBandStateChange(bool state)
	{
		base.PlaySequence("Loop", null, false);
	}

	// Token: 0x040079E2 RID: 31202
	private float FullSize;

	// Token: 0x020077EC RID: 30700
	private class EChildType
	{
		// Token: 0x04026EAB RID: 159403
		public const int Progress = 0;

		// Token: 0x04026EAC RID: 159404
		public const int NiagaraParent = 1;

		// Token: 0x04026EAD RID: 159405
		public const int NiagaraItem = 2;

		// Token: 0x04026EAE RID: 159406
		public const int LoadingText = 3;
	}
}
