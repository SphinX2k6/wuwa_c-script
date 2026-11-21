using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001262 RID: 4706
public class PunishReportView : UiViewBase
{
	// Token: 0x0600BA56 RID: 47702 RVA: 0x0036FFD7 File Offset: 0x0036E1D7
	[NullableContext(1)]
	public PunishReportView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BA57 RID: 47703 RVA: 0x0036FFE0 File Offset: 0x0036E1E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BA58 RID: 47704 RVA: 0x0037004C File Offset: 0x0036E24C
	protected override void OnStart()
	{
		this.UiViewSequence.AddSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd), false);
		IPunishReport punishReport = this.OpenParam as IPunishReport;
		if (punishReport == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(punishReport.MainText))
		{
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(punishReport.MainText);
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(configTextByKey, true);
			}
		}
		if (!string.IsNullOrEmpty(punishReport.SubText))
		{
			string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey(punishReport.SubText);
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(configTextByKey2, true);
		}
	}

	// Token: 0x0600BA59 RID: 47705 RVA: 0x003700EF File Offset: 0x0036E2EF
	[NullableContext(1)]
	private void OnStartSequenceEnd(string _)
	{
		this.UiViewSequence.RemoveSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd));
		base.CloseMe(null);
	}

	// Token: 0x02007505 RID: 29957
	private static class EViewComponent
	{
		// Token: 0x040260BF RID: 155839
		public const int TitleText = 0;

		// Token: 0x040260C0 RID: 155840
		public const int DescribeText = 1;
	}
}
