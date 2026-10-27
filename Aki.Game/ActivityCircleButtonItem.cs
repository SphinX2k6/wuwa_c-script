using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200154E RID: 5454
[NullableContext(1)]
[Nullable(0)]
public class ActivityCircleButtonItem : UiPanelBase
{
	// Token: 0x06009BEB RID: 39915 RVA: 0x0021BF4C File Offset: 0x0021A14C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009BEC RID: 39916 RVA: 0x0021C013 File Offset: 0x0021A213
	public void SetOnClick(Action onClick)
	{
		this.OnClickInternal = onClick;
	}

	// Token: 0x06009BED RID: 39917 RVA: 0x0021C01C File Offset: 0x0021A21C
	public void SetSubText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x06009BEE RID: 39918 RVA: 0x0021C02C File Offset: 0x0021A22C
	public void SetRedDotVisible(bool value)
	{
		base.GetItem(2).SetUIActive(value);
	}

	// Token: 0x06009BEF RID: 39919 RVA: 0x0021C03C File Offset: 0x0021A23C
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x06009BF0 RID: 39920 RVA: 0x0021C084 File Offset: 0x0021A284
	public void BindGivenUid(ERedDotName redDotName, int uId)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x06009BF1 RID: 39921 RVA: 0x0021C0C4 File Offset: 0x0021A2C4
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), uId);
		}
	}

	// Token: 0x06009BF2 RID: 39922 RVA: 0x0021C0F0 File Offset: 0x0021A2F0
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x06009BF3 RID: 39923 RVA: 0x0021C120 File Offset: 0x0021A320
	private void OnClick()
	{
		this.OnClickInternal();
	}

	// Token: 0x04004470 RID: 17520
	private Action OnClickInternal = delegate()
	{
	};

	// Token: 0x04004471 RID: 17521
	private ERedDotName? RedDotName;

	// Token: 0x02007B83 RID: 31619
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040289B0 RID: 166320
		public const int BtnCircle = 0;

		// Token: 0x040289B1 RID: 166321
		public const int TextSub = 1;

		// Token: 0x040289B2 RID: 166322
		public const int ItemRedDot = 2;
	}
}
