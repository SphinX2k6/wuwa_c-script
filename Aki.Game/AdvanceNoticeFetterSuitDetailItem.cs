using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000581 RID: 1409
[Nullable(new byte[]
{
	0,
	1
})]
public class AdvanceNoticeFetterSuitDetailItem : GridProxyAbstract<IAdvanceNoticeFetterSuitDetailItemData>
{
	// Token: 0x060043A1 RID: 17313 RVA: 0x001757AC File Offset: 0x001739AC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060043A2 RID: 17314 RVA: 0x001757E8 File Offset: 0x001739E8
	[NullableContext(1)]
	public override void Refresh(IAdvanceNoticeFetterSuitDetailItemData data, bool isSelected, int gridIndex)
	{
		if (!string.IsNullOrEmpty(data.TitleTextData.TextKey))
		{
			base.GetText(0).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TitleTextData.TextKey, data.TitleTextData.Params);
		}
		else
		{
			base.GetText(0).SetUIActive(false);
		}
		if (!string.IsNullOrEmpty(data.DescTextData.TextKey))
		{
			base.GetText(1).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.DescTextData.TextKey, data.DescTextData.Params);
			return;
		}
		base.GetText(1).SetUIActive(false);
	}

	// Token: 0x02006827 RID: 26663
	private class EComponentDefine
	{
		// Token: 0x04022557 RID: 140631
		public const int TitleText = 0;

		// Token: 0x04022558 RID: 140632
		public const int DescText = 1;
	}
}
