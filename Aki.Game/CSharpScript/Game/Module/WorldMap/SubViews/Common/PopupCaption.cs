using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x02004832 RID: 18482
	[NullableContext(2)]
	[Nullable(0)]
	public class PopupCaption : UiPanelBase
	{
		// Token: 0x170078ED RID: 30957
		// (get) Token: 0x060305FB RID: 198139 RVA: 0x00B3B03E File Offset: 0x00B3923E
		// (set) Token: 0x060305FC RID: 198140 RVA: 0x00B3B046 File Offset: 0x00B39246
		public Action OnCloseCall { get; set; }

		// Token: 0x060305FD RID: 198141 RVA: 0x00B3B050 File Offset: 0x00B39250
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickCloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060305FE RID: 198142 RVA: 0x00B3B17A File Offset: 0x00B3937A
		private void OnClickCloseBtn()
		{
			Action onCloseCall = this.OnCloseCall;
			if (onCloseCall == null)
			{
				return;
			}
			onCloseCall();
		}

		// Token: 0x060305FF RID: 198143 RVA: 0x00B3B18C File Offset: 0x00B3938C
		[NullableContext(1)]
		public void SetTitleIcon(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x06030600 RID: 198144 RVA: 0x00B3B1BE File Offset: 0x00B393BE
		[NullableContext(1)]
		public void SetTitleLocalTxt(string txtId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), txtId, Array.Empty<object>());
		}

		// Token: 0x0200AB0E RID: 43790
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033FCE RID: 212942
			public const int SprTitleIcon = 0;

			// Token: 0x04033FCF RID: 212943
			public const int TxtTitle = 1;

			// Token: 0x04033FD0 RID: 212944
			public const int BtnHelpInfo = 2;

			// Token: 0x04033FD1 RID: 212945
			public const int BtnBack = 3;

			// Token: 0x04033FD2 RID: 212946
			public const int PnlCost = 4;

			// Token: 0x04033FD3 RID: 212947
			public const int PnlTabInfo = 5;
		}
	}
}
