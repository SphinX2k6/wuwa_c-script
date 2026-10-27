using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DA0 RID: 7584
public class PunishReportView : UiViewBase
{
	// Token: 0x0600E638 RID: 58936 RVA: 0x00364377 File Offset: 0x00362577
	[NullableContext(1)]
	public PunishReportView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E639 RID: 58937 RVA: 0x00364380 File Offset: 0x00362580
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

	// Token: 0x0600E63A RID: 58938 RVA: 0x003643EC File Offset: 0x003625EC
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

	// Token: 0x0600E63B RID: 58939 RVA: 0x0036448F File Offset: 0x0036268F
	[NullableContext(1)]
	private void OnStartSequenceEnd(string _)
	{
		this.UiViewSequence.RemoveSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd));
		base.CloseMe(null);
	}

	// Token: 0x0200837D RID: 33661
	private static class EViewComponent
	{
		// Token: 0x0402AD99 RID: 175513
		public const int TitleText = 0;

		// Token: 0x0402AD9A RID: 175514
		public const int DescribeText = 1;
	}
}
