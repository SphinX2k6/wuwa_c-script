using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200599C RID: 22940
	public class SolarSchoolRoleTalkItem : UiPanelBase
	{
		// Token: 0x06038903 RID: 231683 RVA: 0x00FD34D8 File Offset: 0x00FD16D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038904 RID: 231684 RVA: 0x00FD3583 File Offset: 0x00FD1783
		[NullableContext(1)]
		public void Refresh(string roleName, string content, bool showSpine)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(showSpine);
			}
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(roleName);
			}
			UUIText text2 = base.GetText(3);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(content, true);
		}

		// Token: 0x0200B546 RID: 46406
		private class EComponents
		{
			// Token: 0x040380BB RID: 229563
			public const int PnlSpineParent = 0;

			// Token: 0x040380BC RID: 229564
			public const int TxtName = 1;

			// Token: 0x040380BD RID: 229565
			public const int TxtScroll = 2;

			// Token: 0x040380BE RID: 229566
			public const int TxtContent = 3;
		}
	}
}
