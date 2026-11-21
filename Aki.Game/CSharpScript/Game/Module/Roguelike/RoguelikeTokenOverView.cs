using System;
using System.Collections.Generic;
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
	// Token: 0x02003DFF RID: 15871
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeTokenOverView : UiViewBase
	{
		// Token: 0x0602884B RID: 165963 RVA: 0x00B5DAB5 File Offset: 0x00B5BCB5
		public RoguelikeTokenOverView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602884C RID: 165964 RVA: 0x00B5DAD4 File Offset: 0x00B5BCD4
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

		// Token: 0x0602884D RID: 165965 RVA: 0x00B5DCCF File Offset: 0x00B5BECF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeSelectToken, new Action<RoguelikeTokenGrid>(this.RefreshDetail));
			EventSystem.Instance.Add(EEventName.RoguelikeGetTokenReward, new Action(this.RoguelikeGetTokenReward));
		}

		// Token: 0x0602884E RID: 165966 RVA: 0x00B5DD09 File Offset: 0x00B5BF09
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeSelectToken, new Action<RoguelikeTokenGrid>(this.RefreshDetail));
			EventSystem.Instance.Remove(EEventName.RoguelikeGetTokenReward, new Action(this.RoguelikeGetTokenReward));
		}

		// Token: 0x0602884F RID: 165967 RVA: 0x00B5DD43 File Offset: 0x00B5BF43
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x06028850 RID: 165968 RVA: 0x00B5DD4C File Offset: 0x00B5BF4C
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

		// Token: 0x06028851 RID: 165969 RVA: 0x00B5DE7C File Offset: 0x00B5C07C
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06028852 RID: 165970 RVA: 0x00B5DEB4 File Offset: 0x00B5C0B4
		protected RoguelikeTokenGrid CreateLoopScrollItem()
		{
			return new RoguelikeTokenGrid();
		}

		// Token: 0x06028853 RID: 165971 RVA: 0x00B5DEBC File Offset: 0x00B5C0BC
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeTokenOverView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeTokenOverView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028854 RID: 165972 RVA: 0x00B5DEFF File Offset: 0x00B5C0FF
		protected override void OnBeforeShow()
		{
			this.TabComponent.SelectToggleByIndex(0, false);
		}

		// Token: 0x06028855 RID: 165973 RVA: 0x00B5DF0E File Offset: 0x00B5C10E
		protected void OnCloseClick()
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, null);
		}

		// Token: 0x06028856 RID: 165974 RVA: 0x00B5DF28 File Offset: 0x00B5C128
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
			List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>(CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview(data.Config.Value.DropId));
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

		// Token: 0x06028857 RID: 165975 RVA: 0x00B5E16C File Offset: 0x00B5C36C
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

		// Token: 0x04015FDC RID: 90076
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x04015FDD RID: 90077
		public List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x04015FDE RID: 90078
		public Dictionary<long, bool> DataMap = new Dictionary<long, bool>();

		// Token: 0x04015FDF RID: 90079
		public int SeasonId;

		// Token: 0x04015FE0 RID: 90080
		[Nullable(2)]
		private RogueTokenCommonItemSmallItemGrid CommonGridItem;

		// Token: 0x04015FE1 RID: 90081
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public LoopScrollView<RoguelikeTokenGrid, RogueTokenData> LoopScrollView;

		// Token: 0x04015FE2 RID: 90082
		[Nullable(2)]
		public RoguelikeTokenGrid LastSelectGrid;

		// Token: 0x02009A1D RID: 39453
		[NullableContext(0)]
		private static class ERoguelikeTokenOverViewDefine
		{
			// Token: 0x040300B4 RID: 196788
			public const int CaptionItem = 0;

			// Token: 0x040300B5 RID: 196789
			public const int LoopScrollView = 1;

			// Token: 0x040300B6 RID: 196790
			public const int LoopScrollItem = 2;

			// Token: 0x040300B7 RID: 196791
			public const int TxtNum = 3;

			// Token: 0x040300B8 RID: 196792
			public const int TxtElementCount = 4;

			// Token: 0x040300B9 RID: 196793
			public const int TexElementIcon = 5;

			// Token: 0x040300BA RID: 196794
			public const int TxtEffect = 6;

			// Token: 0x040300BB RID: 196795
			public const int TxtDescription = 7;

			// Token: 0x040300BC RID: 196796
			public const int UnlockRewardItem = 8;

			// Token: 0x040300BD RID: 196797
			public const int TexItemIcon = 9;

			// Token: 0x040300BE RID: 196798
			public const int TexItemQuality = 10;

			// Token: 0x040300BF RID: 196799
			public const int TxtItemName = 11;

			// Token: 0x040300C0 RID: 196800
			public const int TokenGridContent = 12;

			// Token: 0x040300C1 RID: 196801
			public const int TipsItem = 13;
		}
	}
}
