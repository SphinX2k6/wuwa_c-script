using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A91 RID: 19089
	public class DreamLinkWhiteCatSettleRecordItem : UiPanelBase
	{
		// Token: 0x0602FC57 RID: 195671 RVA: 0x00D53A7C File Offset: 0x00D51C7C
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

		// Token: 0x0602FC58 RID: 195672 RVA: 0x00D53B08 File Offset: 0x00D51D08
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

		// Token: 0x040195BD RID: 103869
		[Nullable(2)]
		public IDreamLinkRecordData Data;

		// Token: 0x0200A70D RID: 42765
		private class EDreamLinkWhiteCatSettleRecordItemDefine
		{
			// Token: 0x040339D2 RID: 211410
			public const int TxtTitle = 0;

			// Token: 0x040339D3 RID: 211411
			public const int TxtContent = 1;

			// Token: 0x040339D4 RID: 211412
			public const int NewRecordItem = 2;
		}
	}
}
