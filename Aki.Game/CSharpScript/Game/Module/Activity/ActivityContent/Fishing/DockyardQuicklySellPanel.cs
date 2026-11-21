using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005545 RID: 21829
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardQuicklySellPanel : UiPanelBase
	{
		// Token: 0x0603626B RID: 221803 RVA: 0x00F1D38C File Offset: 0x00F1B58C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, this.ConfirmBtnClick);
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, this.CloseBtnClick);
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603626C RID: 221804 RVA: 0x00F1D4CD File Offset: 0x00F1B6CD
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(delegate(string eventName)
			{
				if (eventName == "Close")
				{
					this.SetActive(false);
				}
			}, false);
		}

		// Token: 0x0603626D RID: 221805 RVA: 0x00F1D4F8 File Offset: 0x00F1B6F8
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x0603626E RID: 221806 RVA: 0x00F1D508 File Offset: 0x00F1B708
		public void SetPanelVisible(bool bVisible)
		{
			if (bVisible)
			{
				this.SequencePlayer.StopCurrentSequence(false, true);
				this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
				this.SetActive(true);
				return;
			}
			this.SequencePlayer.StopCurrentSequence(false, true);
			this.SequencePlayer.PlaySequencePurely("Close", false, false, null, null, false);
		}

		// Token: 0x0603626F RID: 221807 RVA: 0x00F1D574 File Offset: 0x00F1B774
		public void RefreshPanel(int price, EBackpackQuicklySellType sellType)
		{
			bool flag = sellType == EBackpackQuicklySellType.Full;
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag);
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(price.ToString(), true);
			}
			base.SetItemIcon(base.GetTexture(1), 27, null, null);
			if (!flag)
			{
				if (sellType == EBackpackQuicklySellType.RangeError)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Fishing_ShapeNotMatch", Array.Empty<object>());
					return;
				}
				if (sellType == EBackpackQuicklySellType.ItemError)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Fishing_ShapeCantSell", Array.Empty<object>());
				}
			}
		}

		// Token: 0x0401C946 RID: 117062
		public Action ConfirmBtnClick;

		// Token: 0x0401C947 RID: 117063
		public Action CloseBtnClick;

		// Token: 0x0401C948 RID: 117064
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B1CB RID: 45515
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036F52 RID: 225106
			public const int PriceText = 0;

			// Token: 0x04036F53 RID: 225107
			public const int PriceIcon = 1;

			// Token: 0x04036F54 RID: 225108
			public const int ConfirmBtn = 2;

			// Token: 0x04036F55 RID: 225109
			public const int ConditionItem = 3;

			// Token: 0x04036F56 RID: 225110
			public const int ConditionText = 4;

			// Token: 0x04036F57 RID: 225111
			public const int CloseBtn = 5;
		}
	}
}
