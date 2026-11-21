using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x02003763 RID: 14179
	[NullableContext(2)]
	[Nullable(0)]
	public class PopupCaption : UiPanelBase
	{
		// Token: 0x17004BAA RID: 19370
		// (get) Token: 0x06024DCB RID: 150987 RVA: 0x00A6B10A File Offset: 0x00A6930A
		// (set) Token: 0x06024DCC RID: 150988 RVA: 0x00A6B112 File Offset: 0x00A69312
		public Action OnCloseCall { get; set; }

		// Token: 0x06024DCD RID: 150989 RVA: 0x00A6B11C File Offset: 0x00A6931C
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

		// Token: 0x06024DCE RID: 150990 RVA: 0x00A6B246 File Offset: 0x00A69446
		private void OnClickCloseBtn()
		{
			Action onCloseCall = this.OnCloseCall;
			if (onCloseCall == null)
			{
				return;
			}
			onCloseCall();
		}

		// Token: 0x06024DCF RID: 150991 RVA: 0x00A6B258 File Offset: 0x00A69458
		[NullableContext(1)]
		public void SetTitleIcon(string resourceId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x06024DD0 RID: 150992 RVA: 0x00A6B28A File Offset: 0x00A6948A
		[NullableContext(1)]
		public void SetTitleLocalTxt(string txtId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), txtId, Array.Empty<object>());
		}

		// Token: 0x020094BD RID: 38077
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E74E RID: 190286
			public const int SprTitleIcon = 0;

			// Token: 0x0402E74F RID: 190287
			public const int TxtTitle = 1;

			// Token: 0x0402E750 RID: 190288
			public const int BtnHelpInfo = 2;

			// Token: 0x0402E751 RID: 190289
			public const int BtnBack = 3;

			// Token: 0x0402E752 RID: 190290
			public const int PnlCost = 4;

			// Token: 0x0402E753 RID: 190291
			public const int PnlTabInfo = 5;
		}
	}
}
