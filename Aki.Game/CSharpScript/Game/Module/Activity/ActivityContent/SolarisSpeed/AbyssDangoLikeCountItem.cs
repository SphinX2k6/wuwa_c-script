using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060CA RID: 24778
	internal class AbyssDangoLikeCountItem : UiPanelBase
	{
		// Token: 0x0603EA50 RID: 256592 RVA: 0x00F20FE8 File Offset: 0x00F1F1E8
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

		// Token: 0x0603EA51 RID: 256593 RVA: 0x00F21030 File Offset: 0x00F1F230
		public void Refresh(int data)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(data.ToString(), true);
		}

		// Token: 0x0200C316 RID: 49942
		private enum ELikeCountItem
		{
			// Token: 0x0403AE87 RID: 241287
			LikeCount
		}
	}
}
