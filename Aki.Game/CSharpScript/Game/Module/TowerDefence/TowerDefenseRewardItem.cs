using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B0B RID: 15115
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseRewardItem : GridProxyAbstract<IActivityRewardData>
	{
		// Token: 0x06026D01 RID: 158977 RVA: 0x00ADCB40 File Offset: 0x00ADAD40
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

		// Token: 0x06026D02 RID: 158978 RVA: 0x00ADCCD0 File Offset: 0x00ADAED0
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

		// Token: 0x06026D03 RID: 158979 RVA: 0x00ADCD50 File Offset: 0x00ADAF50
		public override void Refresh(IActivityRewardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshTitle(data);
			this.RefreshDesc(data);
			this.RefreshRewardList(data);
			this.RefreshState(data);
		}

		// Token: 0x06026D04 RID: 158980 RVA: 0x00ADCD75 File Offset: 0x00ADAF75
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06026D05 RID: 158981 RVA: 0x00ADCD7C File Offset: 0x00ADAF7C
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

		// Token: 0x06026D06 RID: 158982 RVA: 0x00ADCDD0 File Offset: 0x00ADAFD0
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

		// Token: 0x06026D07 RID: 158983 RVA: 0x00ADCE08 File Offset: 0x00ADB008
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

		// Token: 0x06026D08 RID: 158984 RVA: 0x00ADCE54 File Offset: 0x00ADB054
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

		// Token: 0x06026D09 RID: 158985 RVA: 0x00ADCF45 File Offset: 0x00ADB145
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

		// Token: 0x06026D0A RID: 158986 RVA: 0x00ADCF74 File Offset: 0x00ADB174
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

		// Token: 0x0401538F RID: 86927
		[Nullable(2)]
		private IActivityRewardData Data;

		// Token: 0x04015390 RID: 86928
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

		// Token: 0x04015391 RID: 86929
		[Nullable(2)]
		private ButtonItem ReceiveButton;

		// Token: 0x02009713 RID: 38675
		[NullableContext(0)]
		private class ERewardComponent
		{
			// Token: 0x0402F279 RID: 193145
			public const int TitleTxt = 0;

			// Token: 0x0402F27A RID: 193146
			public const int DescTxt = 1;

			// Token: 0x0402F27B RID: 193147
			public const int RewardLayout = 2;

			// Token: 0x0402F27C RID: 193148
			public const int RewardItem = 3;

			// Token: 0x0402F27D RID: 193149
			public const int ReceiveBtn = 4;

			// Token: 0x0402F27E RID: 193150
			public const int InProgressTxt = 5;

			// Token: 0x0402F27F RID: 193151
			public const int ReceivedSprite = 6;

			// Token: 0x0402F280 RID: 193152
			public const int RedDotItem = 7;

			// Token: 0x0402F281 RID: 193153
			public const int JumpBtn = 8;
		}
	}
}
