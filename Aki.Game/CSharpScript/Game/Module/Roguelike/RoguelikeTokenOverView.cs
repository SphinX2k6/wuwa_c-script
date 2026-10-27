using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E36 RID: 20022
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeTokenOverView : UiViewBase
	{
		// Token: 0x060339E0 RID: 211424 RVA: 0x00C1458D File Offset: 0x00C1278D
		public RoguelikeTokenOverView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060339E1 RID: 211425 RVA: 0x00C145AC File Offset: 0x00C127AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060339E2 RID: 211426 RVA: 0x00C147A7 File Offset: 0x00C129A7
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeSelectToken, new Action<RoguelikeTokenGrid>(this.RefreshDetail));
			EventSystem.Instance.Add(EEventName.RoguelikeGetTokenReward, new Action(this.RoguelikeGetTokenReward));
		}

		// Token: 0x060339E3 RID: 211427 RVA: 0x00C147E1 File Offset: 0x00C129E1
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeSelectToken, new Action<RoguelikeTokenGrid>(this.RefreshDetail));
			EventSystem.Instance.Remove(EEventName.RoguelikeGetTokenReward, new Action(this.RoguelikeGetTokenReward));
		}

		// Token: 0x060339E4 RID: 211428 RVA: 0x00C1481B File Offset: 0x00C12A1B
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x060339E5 RID: 211429 RVA: 0x00C14824 File Offset: 0x00C12A24
		private void ToggleCallBack(int index)
		{
			IReadOnlyList<RogueToken> allData = RoguelikeConfig.Instance.GetRogueTokenBySeasonId(this.SeasonId);
			List<RogueTokenData> data = new List<RogueTokenData>();
			int unlockCount = 0;
			Action<EPerkType?> action = delegate(EPerkType? perkType)
			{
				foreach (RogueToken value in allData)
				{
					RogueBuffPool? rogueBuffConfig = RoguelikeConfig.Instance.GetRogueBuffConfig(value.Token);
					if (perkType == null || rogueBuffConfig.Value.PerkType == (int)perkType.Value)
					{
						bool value2;
						bool? isReceive = this.DataMap.TryGetValue((long)value.Token, out value2) ? new bool?(value2) : null;
						RogueTokenData rogueTokenData = new RogueTokenData();
						rogueTokenData.IsReceive = isReceive;
						rogueTokenData.Config = new RogueToken?(value);
						if (isReceive != null)
						{
							int unlockCount = unlockCount;
							unlockCount++;
						}
						data.Add(rogueTokenData);
					}
				}
			};
			switch (index)
			{
			case 0:
				action(null);
				break;
			case 1:
				action(new EPerkType?(EPerkType.Common));
				break;
			case 2:
				action(new EPerkType?(EPerkType.CommonRole));
				break;
			}
			base.GetItem(13).SetUIActive(false);
			this.LoopScrollView.ReloadData(data, false);
			this.LoopScrollView.ScrollToGridIndex(0, true);
			this.LoopScrollView.SelectGridProxy(0, true);
			this.LoopScrollView.RefreshAllGridProxies();
			base.GetItem(12).SetUIActive(data.Count > 0);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Roguelike_TokenOverView_Collect", new <>z__ReadOnlyArray<object>(new object[]
			{
				unlockCount,
				data.Count
			}));
		}

		// Token: 0x060339E6 RID: 211430 RVA: 0x00C14954 File Offset: 0x00C12B54
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x060339E7 RID: 211431 RVA: 0x00C1498C File Offset: 0x00C12B8C
		protected RoguelikeTokenGrid CreateLoopScrollItem()
		{
			return new RoguelikeTokenGrid();
		}

		// Token: 0x060339E8 RID: 211432 RVA: 0x00C14994 File Offset: 0x00C12B94
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeTokenOverView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeTokenOverView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060339E9 RID: 211433 RVA: 0x00C149D7 File Offset: 0x00C12BD7
		protected override void OnBeforeShow()
		{
			this.TabComponent.SelectToggleByIndex(0, false);
		}

		// Token: 0x060339EA RID: 211434 RVA: 0x00C149E6 File Offset: 0x00C12BE6
		protected void OnCloseClick()
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, null);
		}

		// Token: 0x060339EB RID: 211435 RVA: 0x00C14A00 File Offset: 0x00C12C00
		protected void RefreshDetail(RoguelikeTokenGrid grid)
		{
			if (this.LastSelectGrid == grid)
			{
				return;
			}
			this.LastSelectGrid = grid;
			RogueTokenData data = grid.Data;
			RogueBuffPool? rogueBuffConfig = RoguelikeConfig.Instance.GetRogueBuffConfig(data.Config.Value.Token);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), rogueBuffConfig.Value.BuffName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), rogueBuffConfig.Value.BuffDesc, rogueBuffConfig.Value.BuffDescParam());
			base.GetText(7).SetUIActive(false);
			base.SetTextureByPath(rogueBuffConfig.Value.BuffIcon, base.GetTexture(9), null, null);
			List<KeyValuePair<int, int>> list = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview(data.Config.Value.DropId).ToList<KeyValuePair<int, int>>();
			TItem data2 = new TItem
			{
				ItemData = new InventoryDefine.GetItemData(list[0].Key, 0),
				Count = list[0].Value
			};
			int num = 10;
			int num2 = 0;
			foreach (DicIntInt dicIntInt in rogueBuffConfig.Value.BuffElementIter())
			{
				int key = dicIntInt.Key;
				int value = dicIntInt.Value;
				num = key;
				num2 = value;
			}
			base.GetTexture(5).SetUIActive(num < 10);
			base.GetText(4).SetUIActive(num < 10);
			if (num < 10)
			{
				base.SetTextureByPath(ElementInfoConfig.Instance.GetElementInfo(num).Value.Icon5, base.GetTexture(5), null, null);
				base.GetText(4).SetText(num2.ToString(), true);
			}
			this.CommonGridItem.Refresh(data2);
			this.CommonGridItem.SetActive(!data.IsReceive.GetValueOrDefault());
			base.GetItem(13).SetUIActive(true);
		}

		// Token: 0x060339EC RID: 211436 RVA: 0x00C14C44 File Offset: 0x00C12E44
		protected void RoguelikeGetTokenReward()
		{
			RogueTokenData data = this.LastSelectGrid.Data;
			if (data.IsReceive == null)
			{
				return;
			}
			RoguelikeController.Instance.RoguelikeTokenReceiveRequest(this.SeasonId, data.Config.Value.Id).ContinueWith(delegate(bool success)
			{
				if (!success)
				{
					return;
				}
				data.IsReceive = new bool?(true);
				this.CommonGridItem.SetActive(!data.IsReceive.GetValueOrDefault());
			});
		}

		// Token: 0x0401B609 RID: 112137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401B60A RID: 112138
		public List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401B60B RID: 112139
		public Dictionary<long, bool> DataMap = new Dictionary<long, bool>();

		// Token: 0x0401B60C RID: 112140
		public int SeasonId;

		// Token: 0x0401B60D RID: 112141
		[Nullable(2)]
		private RogueTokenCommonItemSmallItemGrid CommonGridItem;

		// Token: 0x0401B60E RID: 112142
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public LoopScrollView<RoguelikeTokenGrid, RogueTokenData> LoopScrollView;

		// Token: 0x0401B60F RID: 112143
		[Nullable(2)]
		public RoguelikeTokenGrid LastSelectGrid;

		// Token: 0x0200AFEB RID: 45035
		[NullableContext(0)]
		private static class ERoguelikeTokenOverViewDefine
		{
			// Token: 0x04035684 RID: 218756
			public const int CaptionItem = 0;

			// Token: 0x04035685 RID: 218757
			public const int LoopScrollView = 1;

			// Token: 0x04035686 RID: 218758
			public const int LoopScrollItem = 2;

			// Token: 0x04035687 RID: 218759
			public const int TxtNum = 3;

			// Token: 0x04035688 RID: 218760
			public const int TxtElementCount = 4;

			// Token: 0x04035689 RID: 218761
			public const int TexElementIcon = 5;

			// Token: 0x0403568A RID: 218762
			public const int TxtEffect = 6;

			// Token: 0x0403568B RID: 218763
			public const int TxtDescription = 7;

			// Token: 0x0403568C RID: 218764
			public const int UnlockRewardItem = 8;

			// Token: 0x0403568D RID: 218765
			public const int TexItemIcon = 9;

			// Token: 0x0403568E RID: 218766
			public const int TexItemQuality = 10;

			// Token: 0x0403568F RID: 218767
			public const int TxtItemName = 11;

			// Token: 0x04035690 RID: 218768
			public const int TokenGridContent = 12;

			// Token: 0x04035691 RID: 218769
			public const int TipsItem = 13;
		}
	}
}
