using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F9B RID: 8091
public class InfoDisplayImgView : UiViewBase
{
	// Token: 0x0600FB3F RID: 64319 RVA: 0x003CDEC0 File Offset: 0x003CC0C0
	[NullableContext(1)]
	public InfoDisplayImgView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600FB40 RID: 64320 RVA: 0x003CDECC File Offset: 0x003CC0CC
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

	// Token: 0x0600FB41 RID: 64321 RVA: 0x003CDF93 File Offset: 0x003CC193
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FB42 RID: 64322 RVA: 0x003CDF9C File Offset: 0x003CC19C
	protected override void OnStart()
	{
		this.RefreshView();
	}

	// Token: 0x0600FB43 RID: 64323 RVA: 0x003CDFA4 File Offset: 0x003CC1A4
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

	// Token: 0x02008587 RID: 34183
	private class EInfoDisplayImgViewComponents
	{
		// Token: 0x0402B792 RID: 178066
		public const int DetailImg = 0;

		// Token: 0x0402B793 RID: 178067
		public const int CloseText = 1;

		// Token: 0x0402B794 RID: 178068
		public const int MaskBtn = 2;
	}
}
