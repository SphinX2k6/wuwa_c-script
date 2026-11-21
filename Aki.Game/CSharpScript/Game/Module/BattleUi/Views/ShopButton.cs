using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DA3 RID: 19875
	public class ShopButton : BattleChildView
	{
		// Token: 0x06031F39 RID: 204601 RVA: 0x00DFA7FC File Offset: 0x00DF89FC
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

		// Token: 0x06031F3A RID: 204602 RVA: 0x00DFA8A2 File Offset: 0x00DF8AA2
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			RedDotController.Instance.BindRedDot(ERedDotName.BattleViewShopButton, base.GetItem(1), null, 0);
		}

		// Token: 0x06031F3B RID: 204603 RVA: 0x00DFA8BF File Offset: 0x00DF8ABF
		public override void Reset()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.BattleViewShopButton);
			base.Reset();
		}

		// Token: 0x06031F3C RID: 204604 RVA: 0x00DFA8D4 File Offset: 0x00DF8AD4
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

		// Token: 0x0200AAC6 RID: 43718
		private enum EChildType
		{
			// Token: 0x04034C53 RID: 216147
			ShopButton,
			// Token: 0x04034C54 RID: 216148
			RedDotItem
		}
	}
}
