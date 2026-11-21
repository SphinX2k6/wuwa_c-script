using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005048 RID: 20552
	internal class AbyssDangoLikeCountItem : UiPanelBase
	{
		// Token: 0x06033714 RID: 210708 RVA: 0x00E67DB8 File Offset: 0x00E65FB8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033715 RID: 210709 RVA: 0x00E67E00 File Offset: 0x00E66000
		public void Refresh(int data)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(data.ToString(), true);
		}

		// Token: 0x0200AD01 RID: 44289
		private enum ELikeCountItem
		{
			// Token: 0x040357EF RID: 219119
			LikeCount
		}
	}
}
