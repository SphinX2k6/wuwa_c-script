using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AB5 RID: 23221
	public class DreamLinkWhiteCatSettleRecordItem : UiPanelBase
	{
		// Token: 0x0603AD0B RID: 240907 RVA: 0x00E034B4 File Offset: 0x00E016B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AD0C RID: 240908 RVA: 0x00E03540 File Offset: 0x00E01740
		protected override void OnBeforeShow()
		{
			if (this.Data == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.Title, Array.Empty<object>());
			base.GetText(1).SetText(this.Data.Score, true);
			base.GetItem(2).SetUIActive(this.Data.IsNew);
		}

		// Token: 0x0401EB16 RID: 125718
		[Nullable(2)]
		public IDreamLinkRecordData Data;

		// Token: 0x0200BD05 RID: 48389
		private class EDreamLinkWhiteCatSettleRecordItemDefine
		{
			// Token: 0x04039008 RID: 233480
			public const int TxtTitle = 0;

			// Token: 0x04039009 RID: 233481
			public const int TxtContent = 1;

			// Token: 0x0403900A RID: 233482
			public const int NewRecordItem = 2;
		}
	}
}
