using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FeedbackReward
{
	// Token: 0x02004A65 RID: 19045
	public class PageItem : UiPanelBase
	{
		// Token: 0x0602FA8D RID: 195213 RVA: 0x00D4C204 File Offset: 0x00D4A404
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FA8E RID: 195214 RVA: 0x00D4C26D File Offset: 0x00D4A46D
		public void RefreshItem(bool isShow)
		{
			base.GetItem(1).SetUIActive(isShow);
		}

		// Token: 0x0200A6CA RID: 42698
		private enum EPageItem
		{
			// Token: 0x040338DF RID: 211167
			BgItem,
			// Token: 0x040338E0 RID: 211168
			ShowItem
		}
	}
}
