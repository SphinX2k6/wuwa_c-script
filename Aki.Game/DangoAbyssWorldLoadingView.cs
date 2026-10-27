using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200207D RID: 8317
public class DangoAbyssWorldLoadingView : LoadingViewBase
{
	// Token: 0x0601060A RID: 67082 RVA: 0x003FE5C6 File Offset: 0x003FC7C6
	[NullableContext(1)]
	public DangoAbyssWorldLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601060B RID: 67083 RVA: 0x003FE5D0 File Offset: 0x003FC7D0
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

	// Token: 0x0601060C RID: 67084 RVA: 0x003FE67B File Offset: 0x003FC87B
	protected override void OnStart()
	{
		base.OnStart();
		UUIItem item = base.GetItem(1);
		this.FullSize = ((item != null) ? item.Width : 0f);
	}

	// Token: 0x0601060D RID: 67085 RVA: 0x003FE6A0 File Offset: 0x003FC8A0
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

	// Token: 0x0601060E RID: 67086 RVA: 0x003FE6D0 File Offset: 0x003FC8D0
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(3, value, "%");
	}

	// Token: 0x0601060F RID: 67087 RVA: 0x003FE6DF File Offset: 0x003FC8DF
	protected override void OnLevelSequencePlayerBandStateChange(bool state)
	{
		base.PlaySequence("Loop", null, false);
	}

	// Token: 0x040078F9 RID: 30969
	private float FullSize;

	// Token: 0x02008665 RID: 34405
	private class EChildType
	{
		// Token: 0x0402BB9C RID: 179100
		public const int Progress = 0;

		// Token: 0x0402BB9D RID: 179101
		public const int NiagaraParent = 1;

		// Token: 0x0402BB9E RID: 179102
		public const int NiagaraItem = 2;

		// Token: 0x0402BB9F RID: 179103
		public const int LoadingText = 3;
	}
}
