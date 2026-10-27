using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065C7 RID: 26055
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardQuicklySellPanel : UiPanelBase
	{
		// Token: 0x060415A6 RID: 267686 RVA: 0x00FD634C File Offset: 0x00FD454C
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

		// Token: 0x060415A7 RID: 267687 RVA: 0x00FD648D File Offset: 0x00FD468D
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

		// Token: 0x060415A8 RID: 267688 RVA: 0x00FD64B8 File Offset: 0x00FD46B8
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x060415A9 RID: 267689 RVA: 0x00FD64C8 File Offset: 0x00FD46C8
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

		// Token: 0x060415AA RID: 267690 RVA: 0x00FD6534 File Offset: 0x00FD4734
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

		// Token: 0x04022015 RID: 139285
		public Action ConfirmBtnClick;

		// Token: 0x04022016 RID: 139286
		public Action CloseBtnClick;

		// Token: 0x04022017 RID: 139287
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0200C7E8 RID: 51176
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C604 RID: 247300
			public const int PriceText = 0;

			// Token: 0x0403C605 RID: 247301
			public const int PriceIcon = 1;

			// Token: 0x0403C606 RID: 247302
			public const int ConfirmBtn = 2;

			// Token: 0x0403C607 RID: 247303
			public const int ConditionItem = 3;

			// Token: 0x0403C608 RID: 247304
			public const int ConditionText = 4;

			// Token: 0x0403C609 RID: 247305
			public const int CloseBtn = 5;
		}
	}
}
