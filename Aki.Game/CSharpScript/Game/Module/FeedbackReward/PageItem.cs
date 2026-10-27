using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FeedbackReward
{
	// Token: 0x02005A89 RID: 23177
	public class PageItem : UiPanelBase
	{
		// Token: 0x0603AB44 RID: 240452 RVA: 0x00DFBC70 File Offset: 0x00DF9E70
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

		// Token: 0x0603AB45 RID: 240453 RVA: 0x00DFBCD9 File Offset: 0x00DF9ED9
		public void RefreshItem(bool isShow)
		{
			base.GetItem(1).SetUIActive(isShow);
		}

		// Token: 0x0200BCC1 RID: 48321
		private enum EPageItem
		{
			// Token: 0x04038F14 RID: 233236
			BgItem,
			// Token: 0x04038F15 RID: 233237
			ShowItem
		}
	}
}
