using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020004C2 RID: 1218
public class GolemHackingResultPop : UiViewBase
{
	// Token: 0x06003D02 RID: 15618 RVA: 0x00159139 File Offset: 0x00157339
	[NullableContext(1)]
	public GolemHackingResultPop(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06003D03 RID: 15619 RVA: 0x00159144 File Offset: 0x00157344
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06003D04 RID: 15620 RVA: 0x0015918C File Offset: 0x0015738C
	protected override void OnStart()
	{
		GolemHackingResultInfo golemHackingResultInfo = (GolemHackingResultInfo)this.OpenParam;
		this.CloseCallback = golemHackingResultInfo.CloseCallback;
		this.IsSuccess = golemHackingResultInfo.IsSuccess;
		string startSequenceName = this.IsSuccess ? "Success" : "Fail";
		this.UiViewSequence.StartSequenceName = startSequenceName;
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(this.IsSuccess ? "IntrusionProtocol_SucceedTips" : "IntrusionProtocol_FailTips");
	}

	// Token: 0x06003D05 RID: 15621 RVA: 0x00159203 File Offset: 0x00157403
	protected override void OnFinishShow()
	{
		base.CloseMe(delegate(bool _)
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		});
	}

	// Token: 0x04003131 RID: 12593
	[Nullable(2)]
	protected Action CloseCallback;

	// Token: 0x04003132 RID: 12594
	protected bool IsSuccess;

	// Token: 0x0200679C RID: 26524
	private enum EDefine
	{
		// Token: 0x04022333 RID: 140083
		Txt
	}
}
