using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200145D RID: 5213
public class InfoDisplayImgView : UiViewBase
{
	// Token: 0x0600CF61 RID: 53089 RVA: 0x003D9A80 File Offset: 0x003D7C80
	[NullableContext(1)]
	public InfoDisplayImgView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600CF62 RID: 53090 RVA: 0x003D9A8C File Offset: 0x003D7C8C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickCloseBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CF63 RID: 53091 RVA: 0x003D9B53 File Offset: 0x003D7D53
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CF64 RID: 53092 RVA: 0x003D9B5C File Offset: 0x003D7D5C
	protected override void OnStart()
	{
		this.RefreshView();
	}

	// Token: 0x0600CF65 RID: 53093 RVA: 0x003D9B64 File Offset: 0x003D7D64
	private void RefreshView()
	{
		string path2 = InfoDisplayModel.Instance.CurrentCurrentInformationTexture();
		UUITexture uiTexture = base.GetTexture(0);
		ResourceSystem.Instance.LoadAsync<UTexture>(path2, delegate([Nullable(2)] UTexture texture, string path)
		{
			if (texture != null && texture.IsValid() && uiTexture != null && uiTexture.IsValid())
			{
				uiTexture.SetTexture(texture);
			}
		}, 100, this.MemoryTag);
	}

	// Token: 0x0200770C RID: 30476
	private class EInfoDisplayImgViewComponents
	{
		// Token: 0x04026AB5 RID: 158389
		public const int DetailImg = 0;

		// Token: 0x04026AB6 RID: 158390
		public const int CloseText = 1;

		// Token: 0x04026AB7 RID: 158391
		public const int MaskBtn = 2;
	}
}
