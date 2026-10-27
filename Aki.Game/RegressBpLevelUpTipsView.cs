using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200147F RID: 5247
public class RegressBpLevelUpTipsView : UiViewBase
{
	// Token: 0x0600946C RID: 37996 RVA: 0x001FF4B3 File Offset: 0x001FD6B3
	[NullableContext(1)]
	public RegressBpLevelUpTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600946D RID: 37997 RVA: 0x001FF4BC File Offset: 0x001FD6BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600946E RID: 37998 RVA: 0x001FF568 File Offset: 0x001FD768
	protected override void OnStart()
	{
		IRegressBpLevelUpTipsData regressBpLevelUpTipsData = this.OpenParam as IRegressBpLevelUpTipsData;
		if (regressBpLevelUpTipsData != null)
		{
			int? num = regressBpLevelUpTipsData.PrevLevel;
			if (num != null)
			{
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIText text = base.GetText(3);
				if (text != null)
				{
					text.SetUIActive(false);
				}
				UUIText text2 = base.GetText(0);
				if (text2 != null)
				{
					num = regressBpLevelUpTipsData.PrevLevel;
					text2.SetText(((num != null) ? num.GetValueOrDefault().ToString() : null) ?? "", true);
				}
				UUIText text3 = base.GetText(1);
				if (text3 == null)
				{
					goto IL_EF;
				}
				num = regressBpLevelUpTipsData.CurLevel;
				text3.SetText(((num != null) ? num.GetValueOrDefault().ToString() : null) ?? "", true);
				goto IL_EF;
			}
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIText text4 = base.GetText(3);
		if (text4 != null)
		{
			text4.SetUIActive(true);
		}
		IL_EF:
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			base.CloseMe(null);
		}, 2000f, null, null, true, 1f);
	}

	// Token: 0x02007AA1 RID: 31393
	private class ELevelUpTipsComponents
	{
		// Token: 0x0402858E RID: 165262
		public const int TxtCurLevel = 0;

		// Token: 0x0402858F RID: 165263
		public const int TxtTargetLevel = 1;

		// Token: 0x04028590 RID: 165264
		public const int PanelLevelUpDesc = 2;

		// Token: 0x04028591 RID: 165265
		public const int TxtOpenTips = 3;
	}
}
