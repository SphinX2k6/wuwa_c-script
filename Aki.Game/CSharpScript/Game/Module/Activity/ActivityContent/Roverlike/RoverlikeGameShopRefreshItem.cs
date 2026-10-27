using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200615A RID: 24922
	public class RoverlikeGameShopRefreshItem : UiPanelBase
	{
		// Token: 0x0603EFE1 RID: 258017 RVA: 0x00F37922 File Offset: 0x00F35B22
		[NullableContext(1)]
		public void BindOnRefresh(Action cb)
		{
			this.OnRefresh = cb;
		}

		// Token: 0x0603EFE2 RID: 258018 RVA: 0x00F3792C File Offset: 0x00F35B2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnRefresh));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603EFE3 RID: 258019 RVA: 0x00F37A14 File Offset: 0x00F35C14
		private void OnClickBtnRefresh()
		{
			Action onRefresh = this.OnRefresh;
			if (onRefresh == null)
			{
				return;
			}
			onRefresh();
		}

		// Token: 0x0603EFE4 RID: 258020 RVA: 0x00F37A28 File Offset: 0x00F35C28
		public void Refresh(int nextRefreshCost, int refreshCount, int maxRefreshCount, int insideCurrencyItemId, int currencyCount)
		{
			UUIText text = base.GetText(1);
			UUIText text2 = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text, "RoverRogue_RefreshCount", new <>z__ReadOnlyArray<object>(new object[]
			{
				refreshCount,
				maxRefreshCount
			}));
			bool flag = currencyCount < nextRefreshCost;
			UUIItem uuiitem = text2;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(text2.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			LguiUtil.Instance.SetLocalTextNew(text2, "RoverRogue_RefreshCost", new <>z__ReadOnlySingleElementList<object>(nextRefreshCost));
			UUITexture texture = base.GetTexture(3);
			base.SetItemIcon(texture, insideCurrencyItemId, null, null);
			base.GetButton(0).SetSelfInteractive(refreshCount < maxRefreshCount);
		}

		// Token: 0x04020DE7 RID: 134631
		[Nullable(2)]
		private Action OnRefresh;

		// Token: 0x0200C3B9 RID: 50105
		private class EComponents
		{
			// Token: 0x0403B0F8 RID: 241912
			public const int BtnRefresh = 0;

			// Token: 0x0403B0F9 RID: 241913
			public const int TxtRefresh = 1;

			// Token: 0x0403B0FA RID: 241914
			public const int TxtRefreshCount = 2;

			// Token: 0x0403B0FB RID: 241915
			public const int TextureIcon = 3;
		}
	}
}
