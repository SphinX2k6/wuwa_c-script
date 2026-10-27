using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B7D RID: 7037
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchBuffItem : GridProxyAbstract<FloroRanchBuffData>
{
	// Token: 0x0600D171 RID: 53617 RVA: 0x002FFF3C File Offset: 0x002FE13C
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

	// Token: 0x0600D172 RID: 53618 RVA: 0x0030002C File Offset: 0x002FE22C
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

	// Token: 0x0600D173 RID: 53619 RVA: 0x00300072 File Offset: 0x002FE272
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(3));
	}

	// Token: 0x0600D174 RID: 53620 RVA: 0x00300088 File Offset: 0x002FE288
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

	// Token: 0x02008101 RID: 33025
	private class EComponentDefine
	{
		// Token: 0x0402A19E RID: 172446
		public const int Item = 0;

		// Token: 0x0402A19F RID: 172447
		public const int CountItem = 1;

		// Token: 0x0402A1A0 RID: 172448
		public const int CountNum = 2;

		// Token: 0x0402A1A1 RID: 172449
		public const int NameText = 3;

		// Token: 0x0402A1A2 RID: 172450
		public const int CurrencyTexture = 4;

		// Token: 0x0402A1A3 RID: 172451
		public const int CurrencyText = 5;
	}
}
