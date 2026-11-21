using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003585 RID: 13701
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupTypeRightItem : CommonPopViewBase, ICommonPopView
	{
		// Token: 0x06022EEB RID: 143083 RVA: 0x009E9FF6 File Offset: 0x009E81F6
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(1);
		}

		// Token: 0x06022EEC RID: 143084 RVA: 0x009E9FFF File Offset: 0x009E81FF
		public override UUIItem GetCostParent()
		{
			return null;
		}

		// Token: 0x06022EED RID: 143085 RVA: 0x009EA004 File Offset: 0x009E8204
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

		// Token: 0x06022EEE RID: 143086 RVA: 0x009EA110 File Offset: 0x009E8310
		public override void OnSetBackBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(0).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x06022EEF RID: 143087 RVA: 0x009EA13C File Offset: 0x009E833C
		public override void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x06022EF0 RID: 143088 RVA: 0x009EA13E File Offset: 0x009E833E
		public override void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x06022EF1 RID: 143089 RVA: 0x009EA140 File Offset: 0x009E8340
		public override void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
		}

		// Token: 0x06022EF2 RID: 143090 RVA: 0x009EA142 File Offset: 0x009E8342
		public override void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
		}

		// Token: 0x06022EF3 RID: 143091 RVA: 0x009EA144 File Offset: 0x009E8344
		public void ShowMoraleBg(bool show)
		{
			this.SetMoraleBgActive(show);
			this.SetWhiteBgActive(!show);
		}

		// Token: 0x06022EF4 RID: 143092 RVA: 0x009EA157 File Offset: 0x009E8357
		private void SetMoraleBgActive(bool active)
		{
			UUITexture texture = base.GetTexture(4);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(active);
		}

		// Token: 0x06022EF5 RID: 143093 RVA: 0x009EA16B File Offset: 0x009E836B
		private void SetWhiteBgActive(bool active)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(active);
		}

		// Token: 0x02009275 RID: 37493
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402DD5F RID: 187743
			public const int BackBtn = 0;

			// Token: 0x0402DD60 RID: 187744
			public const int Content = 1;

			// Token: 0x0402DD61 RID: 187745
			public const int TexturePatternB = 2;

			// Token: 0x0402DD62 RID: 187746
			public const int TextureWitheBgTop = 3;

			// Token: 0x0402DD63 RID: 187747
			public const int TextureMoraleBgTop = 4;
		}
	}
}
