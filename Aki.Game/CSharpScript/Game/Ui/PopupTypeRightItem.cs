using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004654 RID: 18004
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeRightItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x0602E7A1 RID: 190369 RVA: 0x00ABC9C6 File Offset: 0x00ABABC6
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x0602E7A2 RID: 190370 RVA: 0x00ABC9CF File Offset: 0x00ABABCF
		public override UUIItem GetCostParent()
		{
			return null;
		}

		// Token: 0x0602E7A3 RID: 190371 RVA: 0x00ABC9D4 File Offset: 0x00ABABD4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(base.OnClickCloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602E7A4 RID: 190372 RVA: 0x00ABCAE0 File Offset: 0x00ABACE0
		public override void OnSetBackBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(0).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x0602E7A5 RID: 190373 RVA: 0x00ABCB0C File Offset: 0x00ABAD0C
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x0602E7A6 RID: 190374 RVA: 0x00ABCB0E File Offset: 0x00ABAD0E
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x0602E7A7 RID: 190375 RVA: 0x00ABCB10 File Offset: 0x00ABAD10
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
		}

		// Token: 0x0602E7A8 RID: 190376 RVA: 0x00ABCB12 File Offset: 0x00ABAD12
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
		}

		// Token: 0x0602E7A9 RID: 190377 RVA: 0x00ABCB14 File Offset: 0x00ABAD14
		public void ShowMoraleBg(bool show)
		{
			this.SetMoraleBgActive(show);
			this.SetWhiteBgActive(!show);
		}

		// Token: 0x0602E7AA RID: 190378 RVA: 0x00ABCB27 File Offset: 0x00ABAD27
		private void SetMoraleBgActive(bool active)
		{
			UUITexture texture = base.GetTexture(4);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(active);
		}

		// Token: 0x0602E7AB RID: 190379 RVA: 0x00ABCB3B File Offset: 0x00ABAD3B
		private void SetWhiteBgActive(bool active)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(active);
		}

		// Token: 0x0200A8B9 RID: 43193
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040335C9 RID: 210377
			public const int BackBtn = 0;

			// Token: 0x040335CA RID: 210378
			public const int Content = 1;

			// Token: 0x040335CB RID: 210379
			public const int TexturePatternB = 2;

			// Token: 0x040335CC RID: 210380
			public const int TextureWitheBgTop = 3;

			// Token: 0x040335CD RID: 210381
			public const int TextureMoraleBgTop = 4;
		}
	}
}
