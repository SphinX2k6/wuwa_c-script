using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200103C RID: 4156
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchBuffItem : GridProxyAbstract<FloroRanchBuffData>
{
	// Token: 0x0600A582 RID: 42370 RVA: 0x0030B014 File Offset: 0x00309214
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A583 RID: 42371 RVA: 0x0030B104 File Offset: 0x00309304
	protected override void OnStart()
	{
		ITermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(3),
			ViewType = ETermExplanationViewType.Center,
			Style = new ETermExplanationViewStyle?(ETermExplanationViewStyle.FloroRanch),
			ReportType = ETermExplanationReportType.FloroRanch
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600A584 RID: 42372 RVA: 0x0030B14A File Offset: 0x0030934A
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(3));
	}

	// Token: 0x0600A585 RID: 42373 RVA: 0x0030B160 File Offset: 0x00309360
	[NullableContext(1)]
	public override void Refresh(FloroRanchBuffData data, bool isSelected, int gridIndex)
	{
		int remindDay = data.RemindDay;
		bool flag = remindDay > 0;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (flag)
		{
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(remindDay.ToString(), true);
			}
		}
		UUIText text2 = base.GetText(3);
		if (text2 != null)
		{
			text2.ShowTextNew(data.GetBuffName());
		}
		UUITexture texture = base.GetTexture(4);
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		UUIText text3 = base.GetText(5);
		if (text3 == null)
		{
			return;
		}
		text3.SetUIActive(false);
	}

	// Token: 0x0200728F RID: 29327
	private class EComponentDefine
	{
		// Token: 0x040254D2 RID: 152786
		public const int Item = 0;

		// Token: 0x040254D3 RID: 152787
		public const int CountItem = 1;

		// Token: 0x040254D4 RID: 152788
		public const int CountNum = 2;

		// Token: 0x040254D5 RID: 152789
		public const int NameText = 3;

		// Token: 0x040254D6 RID: 152790
		public const int CurrencyTexture = 4;

		// Token: 0x040254D7 RID: 152791
		public const int CurrencyText = 5;
	}
}
