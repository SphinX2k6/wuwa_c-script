using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200100E RID: 4110
public class GolemHackingResultPop : UiViewBase
{
	// Token: 0x0600696D RID: 26989 RVA: 0x00150811 File Offset: 0x0014EA11
	[NullableContext(1)]
	public GolemHackingResultPop(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600696E RID: 26990 RVA: 0x0015081C File Offset: 0x0014EA1C
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

	// Token: 0x0600696F RID: 26991 RVA: 0x00150864 File Offset: 0x0014EA64
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

	// Token: 0x06006970 RID: 26992 RVA: 0x001508DB File Offset: 0x0014EADB
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

	// Token: 0x04003098 RID: 12440
	[Nullable(2)]
	protected Action CloseCallback;

	// Token: 0x04003099 RID: 12441
	protected bool IsSuccess;

	// Token: 0x02007608 RID: 30216
	private enum EDefine
	{
		// Token: 0x04026FE8 RID: 159720
		Txt
	}
}
