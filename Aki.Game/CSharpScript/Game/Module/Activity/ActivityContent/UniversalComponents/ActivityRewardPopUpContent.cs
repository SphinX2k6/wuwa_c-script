using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02004F62 RID: 20322
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ActivityRewardPopUpContent : GridProxyAbstract<IActivityRewardData>
	{
		// Token: 0x0603302F RID: 208943 RVA: 0x00E4C4AC File Offset: 0x00E4A6AC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText))
			};
		}

		// Token: 0x06033030 RID: 208944 RVA: 0x00E4C548 File Offset: 0x00E4A748
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(1), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
			this.ButtonItem = new ButtonItem(base.GetItem(3));
		}

		// Token: 0x06033031 RID: 208945 RVA: 0x00E4C57D File Offset: 0x00E4A77D
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06033032 RID: 208946 RVA: 0x00E4C584 File Offset: 0x00E4A784
		public override void Refresh(IActivityRewardData data, bool isSelected, int gridIndex)
		{
			if (!string.IsNullOrEmpty(data.NameTextId))
			{
				string[] args = data.NameTextArgs ?? Array.Empty<string>();
				this.RefreshTitleByTextId(data.NameTextId, args);
			}
			else
			{
				this.RefreshTitle(data.NameText);
			}
			this.RefreshLayout(data.RewardList ?? Array.Empty<TItem>(), data.RewardState);
			this.RefreshState(data);
		}

		// Token: 0x06033033 RID: 208947 RVA: 0x00E4C5EB File Offset: 0x00E4A7EB
		private void RefreshTitle(string text)
		{
			base.GetText(0).SetText(text, true);
		}

		// Token: 0x06033034 RID: 208948 RVA: 0x00E4C5FB File Offset: 0x00E4A7FB
		private void RefreshTitleByTextId(string textId, string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x06033035 RID: 208949 RVA: 0x00E4C610 File Offset: 0x00E4A810
		private void RefreshLayout(TItem[] itemList, EActivityRewardState dataState)
		{
			GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout = this.ItemLayout;
			if (itemLayout != null)
			{
				itemLayout.SetActive(itemList.Length != 0);
			}
			if (itemList.Length == 0)
			{
				return;
			}
			GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout2 = this.ItemLayout;
			if (itemLayout2 == null)
			{
				return;
			}
			itemLayout2.RefreshByData(itemList, null, false);
		}

		// Token: 0x06033036 RID: 208950 RVA: 0x00E4C640 File Offset: 0x00E4A840
		private void RefreshState(IActivityRewardData data)
		{
			this.ButtonItem.SetActive(data.RewardState == EActivityRewardState.Enable);
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(data.RewardState == EActivityRewardState.Claimed);
			}
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(data.RewardState == EActivityRewardState.Disabled);
			}
			switch (data.RewardState)
			{
			case EActivityRewardState.Disabled:
			{
				ButtonItem buttonItem = this.ButtonItem;
				if (buttonItem != null)
				{
					buttonItem.SetRedDotVisible(false);
				}
				if (data.RewardButtonTextId != null)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(5), data.RewardButtonTextId, Array.Empty<object>());
					return;
				}
				if (data.RewardButtonText != null)
				{
					base.GetText(5).SetText(data.RewardButtonText, true);
				}
				break;
			}
			case EActivityRewardState.Enable:
			{
				ButtonItem buttonItem2 = this.ButtonItem;
				if (buttonItem2 != null)
				{
					buttonItem2.SetRedDotVisible(data.RewardButtonRedDot.GetValueOrDefault(true));
				}
				if (data.ClickFunction != null)
				{
					ButtonItem buttonItem3 = this.ButtonItem;
					if (buttonItem3 != null)
					{
						buttonItem3.SetFunction(delegate(int _)
						{
							Action clickFunction = data.ClickFunction;
							if (clickFunction != null)
							{
								clickFunction();
							}
							if (data.ClickFunctionAndCloseSelf.GetValueOrDefault())
							{
								Action closeViewFunction = this.CloseViewFunction;
								if (closeViewFunction == null)
								{
									return;
								}
								closeViewFunction();
							}
						});
					}
				}
				if (data.RewardButtonTextId != null)
				{
					ButtonItem buttonItem4 = this.ButtonItem;
					if (buttonItem4 == null)
					{
						return;
					}
					buttonItem4.SetLocalTextNew(data.RewardButtonTextId, Array.Empty<object>());
					return;
				}
				else if (data.RewardButtonText != null)
				{
					ButtonItem buttonItem5 = this.ButtonItem;
					if (buttonItem5 == null)
					{
						return;
					}
					buttonItem5.SetText(data.RewardButtonText);
					return;
				}
				break;
			}
			case EActivityRewardState.Claimed:
				break;
			default:
				return;
			}
		}

		// Token: 0x0401B135 RID: 110901
		[Nullable(2)]
		private ButtonItem ButtonItem;

		// Token: 0x0401B136 RID: 110902
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

		// Token: 0x0401B137 RID: 110903
		[Nullable(2)]
		public Action CloseViewFunction;
	}
}
