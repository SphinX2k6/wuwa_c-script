using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E26 RID: 20006
	public class RoguelikeSettleRecordItem : UiPanelBase
	{
		// Token: 0x0603397D RID: 211325 RVA: 0x00C11ACB File Offset: 0x00C0FCCB
		public RoguelikeSettleRecordItem(ERoguelikeSettleItemType itemType, int num)
		{
			this.ItemType = new ERoguelikeSettleItemType?(itemType);
			this.Count = num;
		}

		// Token: 0x0603397E RID: 211326 RVA: 0x00C11AE8 File Offset: 0x00C0FCE8
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

		// Token: 0x0603397F RID: 211327 RVA: 0x00C11B54 File Offset: 0x00C0FD54
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

		// Token: 0x0401B5DF RID: 112095
		public ERoguelikeSettleItemType? ItemType;

		// Token: 0x0401B5E0 RID: 112096
		public int Count;

		// Token: 0x0200AFCF RID: 45007
		private class ERoguelikeSettleRecordItemDefine
		{
			// Token: 0x040355F9 RID: 218617
			public const int TxtTitle = 0;

			// Token: 0x040355FA RID: 218618
			public const int TxtNum = 1;
		}
	}
}
