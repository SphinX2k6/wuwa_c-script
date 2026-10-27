using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B63 RID: 19299
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseRewardItem : GridProxyAbstract<IActivityRewardData>
	{
		// Token: 0x06031F72 RID: 204658 RVA: 0x00B98904 File Offset: 0x00B96B04
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickJumpBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031F73 RID: 204659 RVA: 0x00B98A94 File Offset: 0x00B96C94
		protected override void OnStart()
		{
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(2);
			if (horizontalLayout != null)
			{
				this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(horizontalLayout, new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
			}
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				this.ReceiveButton = new ButtonItem(button.RootUIComp.Get());
				this.ReceiveButton.SetFunction(delegate(int _)
				{
					this.OnClickReceiveBtn();
				});
			}
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06031F74 RID: 204660 RVA: 0x00B98B14 File Offset: 0x00B96D14
		public override void Refresh(IActivityRewardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshTitle(data);
			this.RefreshDesc(data);
			this.RefreshRewardList(data);
			this.RefreshState(data);
		}

		// Token: 0x06031F75 RID: 204661 RVA: 0x00B98B39 File Offset: 0x00B96D39
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06031F76 RID: 204662 RVA: 0x00B98B40 File Offset: 0x00B96D40
		private void RefreshTitle(IActivityRewardData data)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(data.NameTextId))
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.NameTextId, data.NameTextArgs ?? Array.Empty<string>());
				return;
			}
			text.SetText(data.NameText, true);
		}

		// Token: 0x06031F77 RID: 204663 RVA: 0x00B98B94 File Offset: 0x00B96D94
		private void RefreshDesc(IActivityRewardData data)
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(data.ProgressText != null);
			}
			if (text == null)
			{
				return;
			}
			text.SetText(data.ProgressText ?? "", true);
		}

		// Token: 0x06031F78 RID: 204664 RVA: 0x00B98BCC File Offset: 0x00B96DCC
		private void RefreshRewardList(IActivityRewardData data)
		{
			if (this.ItemLayout == null)
			{
				return;
			}
			TItem[] array = data.RewardList ?? Array.Empty<TItem>();
			this.ItemLayout.SetActive(array.Length != 0);
			if (array.Length == 0)
			{
				return;
			}
			this.ItemLayout.RefreshByData(array, null, false);
		}

		// Token: 0x06031F79 RID: 204665 RVA: 0x00B98C18 File Offset: 0x00B96E18
		private void RefreshState(IActivityRewardData data)
		{
			EActivityRewardState rewardState = data.RewardState;
			UUIButtonComponent button = base.GetButton(8);
			UUIItem item = base.GetItem(6);
			UUIText text = base.GetText(5);
			bool flag = rewardState == EActivityRewardState.Enable;
			UUIButtonComponent button2 = base.GetButton(4);
			if (button2 != null)
			{
				UUIItem uuiitem = button2.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag);
				}
			}
			ButtonItem receiveButton = this.ReceiveButton;
			if (receiveButton != null)
			{
				receiveButton.SetRedDotVisible(flag && data.RewardButtonRedDot.GetValueOrDefault());
			}
			if (button != null)
			{
				UUIItem uuiitem2 = button.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(false);
				}
			}
			if (item != null)
			{
				item.SetUIActive(rewardState == EActivityRewardState.Claimed);
			}
			if (text != null)
			{
				text.SetUIActive(rewardState == EActivityRewardState.Disabled);
			}
			if (rewardState == EActivityRewardState.Disabled && text != null)
			{
				if (data.RewardButtonTextId != null)
				{
					LguiUtil.Instance.SetLocalTextNew(text, data.RewardButtonTextId, Array.Empty<object>());
					return;
				}
				if (data.RewardButtonText != null)
				{
					text.SetText(data.RewardButtonText, true);
				}
			}
		}

		// Token: 0x06031F7A RID: 204666 RVA: 0x00B98D09 File Offset: 0x00B96F09
		private void OnClickReceiveBtn()
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.RewardState != EActivityRewardState.Enable)
			{
				return;
			}
			Action clickFunction = this.Data.ClickFunction;
			if (clickFunction == null)
			{
				return;
			}
			clickFunction();
		}

		// Token: 0x06031F7B RID: 204667 RVA: 0x00B98D38 File Offset: 0x00B96F38
		private void OnClickJumpBtn()
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.RewardState != EActivityRewardState.Disabled)
			{
				return;
			}
			Action clickFunction = this.Data.ClickFunction;
			if (clickFunction == null)
			{
				return;
			}
			clickFunction();
		}

		// Token: 0x0401AA3D RID: 109117
		[Nullable(2)]
		private IActivityRewardData Data;

		// Token: 0x0401AA3E RID: 109118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

		// Token: 0x0401AA3F RID: 109119
		[Nullable(2)]
		private ButtonItem ReceiveButton;

		// Token: 0x0200ACF4 RID: 44276
		[NullableContext(0)]
		private class ERewardComponent
		{
			// Token: 0x040348D0 RID: 215248
			public const int TitleTxt = 0;

			// Token: 0x040348D1 RID: 215249
			public const int DescTxt = 1;

			// Token: 0x040348D2 RID: 215250
			public const int RewardLayout = 2;

			// Token: 0x040348D3 RID: 215251
			public const int RewardItem = 3;

			// Token: 0x040348D4 RID: 215252
			public const int ReceiveBtn = 4;

			// Token: 0x040348D5 RID: 215253
			public const int InProgressTxt = 5;

			// Token: 0x040348D6 RID: 215254
			public const int ReceivedSprite = 6;

			// Token: 0x040348D7 RID: 215255
			public const int RedDotItem = 7;

			// Token: 0x040348D8 RID: 215256
			public const int JumpBtn = 8;
		}
	}
}
