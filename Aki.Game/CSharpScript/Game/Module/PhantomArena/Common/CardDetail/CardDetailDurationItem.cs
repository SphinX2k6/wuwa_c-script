using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041DA RID: 16858
	public class CardDetailDurationItem : UiPanelBase
	{
		// Token: 0x0602AA8D RID: 174733 RVA: 0x00C0595C File Offset: 0x00C03B5C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602AA8E RID: 174734 RVA: 0x00C05995 File Offset: 0x00C03B95
		[NullableContext(1)]
		public void Refresh(ICardDetailDurationData data)
		{
			if (!string.IsNullOrEmpty(data.Tips))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Tips, Array.Empty<object>());
			}
			base.GetText(1).SetText(data.DurationDesc, true);
		}

		// Token: 0x02009DE5 RID: 40421
		private static class EComponentDefine
		{
			// Token: 0x040311A3 RID: 201123
			public const int TipsText = 0;

			// Token: 0x040311A4 RID: 201124
			public const int DurationText = 1;
		}
	}
}
