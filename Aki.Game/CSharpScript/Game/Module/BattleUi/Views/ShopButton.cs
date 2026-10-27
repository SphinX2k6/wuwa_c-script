using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DBF RID: 23999
	public class ShopButton : BattleChildView
	{
		// Token: 0x0603CFC2 RID: 249794 RVA: 0x00EA9920 File Offset: 0x00EA7B20
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedShopButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603CFC3 RID: 249795 RVA: 0x00EA99C6 File Offset: 0x00EA7BC6
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			RedDotController.Instance.BindRedDot(ERedDotName.BattleViewShopButton, base.GetItem(1), null, 0);
		}

		// Token: 0x0603CFC4 RID: 249796 RVA: 0x00EA99E3 File Offset: 0x00EA7BE3
		public override void Reset()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.BattleViewShopButton);
			base.Reset();
		}

		// Token: 0x0603CFC5 RID: 249797 RVA: 0x00EA99F8 File Offset: 0x00EA7BF8
		private void OnClickedShopButton()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("BattleViewShopId");
			if (intConfig == null)
			{
				return;
			}
			ShopController.Instance.OpenShop(intConfig.Value, null, null);
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.FirstOpenShop, false);
		}

		// Token: 0x0200C0BD RID: 49341
		private enum EChildType
		{
			// Token: 0x0403A281 RID: 238209
			ShopButton,
			// Token: 0x0403A282 RID: 238210
			RedDotItem
		}
	}
}
