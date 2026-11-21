using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001460 RID: 5216
public class InfoDisplayTypeFiveView : UiViewBase
{
	// Token: 0x0600CF75 RID: 53109 RVA: 0x003DA1F2 File Offset: 0x003D83F2
	[NullableContext(1)]
	public InfoDisplayTypeFiveView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CF76 RID: 53110 RVA: 0x003DA1FC File Offset: 0x003D83FC
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

	// Token: 0x0600CF77 RID: 53111 RVA: 0x003DA2C4 File Offset: 0x003D84C4
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

	// Token: 0x0600CF78 RID: 53112 RVA: 0x003DA336 File Offset: 0x003D8536
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x02007710 RID: 30480
	private class EComponentType
	{
		// Token: 0x04026ABD RID: 158397
		public const int TitleText = 0;

		// Token: 0x04026ABE RID: 158398
		public const int DescText = 1;

		// Token: 0x04026ABF RID: 158399
		public const int CloseButton = 2;
	}
}
