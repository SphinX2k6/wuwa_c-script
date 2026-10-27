using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F9E RID: 8094
public class InfoDisplayTypeFiveView : UiViewBase
{
	// Token: 0x0600FB53 RID: 64339 RVA: 0x003CE632 File Offset: 0x003CC832
	[NullableContext(1)]
	public InfoDisplayTypeFiveView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FB54 RID: 64340 RVA: 0x003CE63C File Offset: 0x003CC83C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
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

	// Token: 0x0600FB55 RID: 64341 RVA: 0x003CE704 File Offset: 0x003CC904
	protected override void OnStart()
	{
		InfoDisplay? config = ConfigInfoDisplayById.GetConfig(InfoDisplayModel.Instance.CurrentInformationId(), true);
		if (config == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), config.Value.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.Value.Text, Array.Empty<object>());
	}

	// Token: 0x0600FB56 RID: 64342 RVA: 0x003CE776 File Offset: 0x003CC976
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0200858B RID: 34187
	private class EComponentType
	{
		// Token: 0x0402B79A RID: 178074
		public const int TitleText = 0;

		// Token: 0x0402B79B RID: 178075
		public const int DescText = 1;

		// Token: 0x0402B79C RID: 178076
		public const int CloseButton = 2;
	}
}
