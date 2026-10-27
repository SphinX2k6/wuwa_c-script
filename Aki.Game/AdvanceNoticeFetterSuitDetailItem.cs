using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020010CD RID: 4301
[Nullable(new byte[]
{
	0,
	1
})]
public class AdvanceNoticeFetterSuitDetailItem : GridProxyAbstract<IAdvanceNoticeFetterSuitDetailItemData>
{
	// Token: 0x0600700B RID: 28683 RVA: 0x0016CDF0 File Offset: 0x0016AFF0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600700C RID: 28684 RVA: 0x0016CE2C File Offset: 0x0016B02C
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

	// Token: 0x02007693 RID: 30355
	private class EComponentDefine
	{
		// Token: 0x0402720E RID: 160270
		public const int TitleText = 0;

		// Token: 0x0402720F RID: 160271
		public const int DescText = 1;
	}
}
