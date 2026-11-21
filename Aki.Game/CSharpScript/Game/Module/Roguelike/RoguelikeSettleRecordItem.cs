using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DEF RID: 15855
	public class RoguelikeSettleRecordItem : UiPanelBase
	{
		// Token: 0x060287E8 RID: 165864 RVA: 0x00B5AFFF File Offset: 0x00B591FF
		public RoguelikeSettleRecordItem(ERoguelikeSettleItemType itemType, int num)
		{
			this.ItemType = new ERoguelikeSettleItemType?(itemType);
			this.Count = num;
		}

		// Token: 0x060287E9 RID: 165865 RVA: 0x00B5B01C File Offset: 0x00B5921C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060287EA RID: 165866 RVA: 0x00B5B088 File Offset: 0x00B59288
		protected override void OnStart()
		{
			base.GetText(1).SetText(this.Count.ToString(), true);
			ERoguelikeSettleItemType? itemType = this.ItemType;
			if (itemType != null)
			{
				switch (itemType.GetValueOrDefault())
				{
				case ERoguelikeSettleItemType.KillCount:
					LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RoguelikeSettleKill", Array.Empty<object>());
					return;
				case ERoguelikeSettleItemType.TokenCount:
					LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RoguelikeSettleToken", Array.Empty<object>());
					return;
				case ERoguelikeSettleItemType.MoneyCount:
					LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RoguelikeSettleMoney", Array.Empty<object>());
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x04015FB2 RID: 90034
		public ERoguelikeSettleItemType? ItemType;

		// Token: 0x04015FB3 RID: 90035
		public int Count;

		// Token: 0x02009A01 RID: 39425
		private class ERoguelikeSettleRecordItemDefine
		{
			// Token: 0x04030029 RID: 196649
			public const int TxtTitle = 0;

			// Token: 0x0403002A RID: 196650
			public const int TxtNum = 1;
		}
	}
}
