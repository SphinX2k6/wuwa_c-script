using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005322 RID: 21282
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueIllustratedTokenTabView : UiTabViewBase
	{
		// Token: 0x060366B5 RID: 222901 RVA: 0x00CE1660 File Offset: 0x00CDF860
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUINiagara))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickGetAllReward)),
				new ValueTuple<int, Delegate>(6, new Action(delegate()
				{
					this.OnClickGetReward(null);
				}))
			};
		}

		// Token: 0x060366B6 RID: 222902 RVA: 0x00CE17A8 File Offset: 0x00CDF9A8
		protected override UniTask OnBeforeStartAsync()
		{
			RogueIllustratedTokenTabView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueIllustratedTokenTabView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060366B7 RID: 222903 RVA: 0x00CE17EB File Offset: 0x00CDF9EB
		protected override void OnBeforeShow()
		{
			this.RefreshItemData();
		}

		// Token: 0x060366B8 RID: 222904 RVA: 0x00CE17F3 File Offset: 0x00CDF9F3
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(this.OnGetRewardUpdate));
		}

		// Token: 0x060366B9 RID: 222905 RVA: 0x00CE1811 File Offset: 0x00CDFA11
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(this.OnGetRewardUpdate));
		}

		// Token: 0x060366BA RID: 222906 RVA: 0x00CE182F File Offset: 0x00CDFA2F
		protected override void OnStart()
		{
			this.RefreshGetAllRewardBtn();
		}

		// Token: 0x060366BB RID: 222907 RVA: 0x00CE1837 File Offset: 0x00CDFA37
		protected override void OnBeforeDestroy()
		{
			this.SelectedItemViewData = null;
			this.ItemScrollView = null;
			this.RewardItemBtn = null;
		}

		// Token: 0x060366BC RID: 222908 RVA: 0x00CE184E File Offset: 0x00CDFA4E
		private void InitializeItemScrollView()
		{
			this.ItemScrollView = new LoopScrollView<RogueIllustratedTokenMediumItemGrid, RogueTokenViewData>(base.GetLoopScrollViewComponent(0), base.GetItem(7).GetOwner() as AUIBaseActor, new Func<RogueIllustratedTokenMediumItemGrid>(this.OnGridProxyCreate), false);
		}

		// Token: 0x060366BD RID: 222909 RVA: 0x00CE1880 File Offset: 0x00CDFA80
		private void RefreshItemData()
		{
			RogueResTheme? config = ((RogueIllustratedTabData)this.Params).Config;
			this.ItemViewDataList = this.GenerateTokenViewData(config);
			this.ItemScrollView.RefreshByData(this.ItemViewDataList, false, delegate
			{
				this.OnItemButtonClicked(this.ItemViewDataList[0]);
			}, true);
			int[] tokenCount = ActivityPermanentRogueModel.Instance.GetTokenCount((config != null) ? config.GetValueOrDefault().Id : 0);
			LguiUtil instance = LguiUtil.Instance;
			UUIText text = base.GetText(3);
			string textStringId = "RogueRes_UnlockProgress";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(tokenCount[0]);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(tokenCount[1]);
			instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
		}

		// Token: 0x060366BE RID: 222910 RVA: 0x00CE193B File Offset: 0x00CDFB3B
		private RogueIllustratedTokenMediumItemGrid OnGridProxyCreate()
		{
			RogueIllustratedTokenMediumItemGrid rogueIllustratedTokenMediumItemGrid = new RogueIllustratedTokenMediumItemGrid();
			rogueIllustratedTokenMediumItemGrid.BindOnItemButtonClickedCallback(new Action<RogueTokenViewData>(this.OnItemButtonClicked));
			return rogueIllustratedTokenMediumItemGrid;
		}

		// Token: 0x060366BF RID: 222911 RVA: 0x00CE1954 File Offset: 0x00CDFB54
		private void OnItemButtonClicked(RogueTokenViewData data)
		{
			if (this.SelectedItemViewData == data)
			{
				int gridIndex = this.ItemViewDataList.IndexOf(data);
				this.ItemScrollView.DeselectCurrentGridProxy(false);
				this.ItemScrollView.SelectGridProxy(gridIndex, false);
				return;
			}
			this.SelectedItem(data);
		}

		// Token: 0x060366C0 RID: 222912 RVA: 0x00CE1998 File Offset: 0x00CDFB98
		private void OnClickGetAllReward()
		{
			RogueResTheme? config = ((RogueIllustratedTabData)this.Params).Config;
			HashSet<int> tokenIndexSet = ActivityPermanentRogueModel.Instance.GetTokenIndexSet(config);
			List<int> list = new List<int>();
			foreach (int num in tokenIndexSet)
			{
				if (ActivityPermanentRogueModel.Instance.GetCollectItemState(num) == SignState.Unlock)
				{
					list.Add(num);
				}
			}
			(ActivityManager.GetActivityController(ActivityType.RogueRes) as ActivityPermanentRogueController).RequestIllustrationAward(list.ToArray());
		}

		// Token: 0x060366C1 RID: 222913 RVA: 0x00CE1A2C File Offset: 0x00CDFC2C
		private void OnClickGetReward(MediumItemGridExtendCallback _)
		{
			if (this.SelectedItemViewData == null)
			{
				return;
			}
			if (ActivityPermanentRogueModel.Instance.GetCollectItemState(this.SelectedItemViewData.GetCollectionIndex()) != SignState.Unlock)
			{
				ItemController.Instance.OpenItemTipsByItemId(this.CurRewardItemId, true, null);
				return;
			}
			(ActivityManager.GetActivityController(ActivityType.RogueRes) as ActivityPermanentRogueController).RequestIllustrationAward(new int[]
			{
				this.SelectedItemViewData.GetCollectionIndex()
			});
		}

		// Token: 0x060366C2 RID: 222914 RVA: 0x00CE1A94 File Offset: 0x00CDFC94
		private List<RogueTokenViewData> GenerateTokenViewData(RogueResTheme? config)
		{
			IEnumerable<int> tokenIndexSet = ActivityPermanentRogueModel.Instance.GetTokenIndexSet(config);
			List<RogueTokenViewData> list = new List<RogueTokenViewData>();
			List<int> list2 = new List<int>(tokenIndexSet);
			list2.Sort(delegate(int a, int b)
			{
				int num = RogueIllustratedTokenTabView.<GenerateTokenViewData>g__stateSwitch|19_0(ActivityPermanentRogueModel.Instance.GetCollectItemState(a));
				int num2 = RogueIllustratedTokenTabView.<GenerateTokenViewData>g__stateSwitch|19_0(ActivityPermanentRogueModel.Instance.GetCollectItemState(b));
				if (num != num2)
				{
					return num - num2;
				}
				RogueResCollection? config2 = ConfigRogueResCollectionByIdKey.GetConfig(a, true);
				RogueResCollection? config3 = ConfigRogueResCollectionByIdKey.GetConfig(b, true);
				RogueResBuffPool? config4 = ConfigRogueResBuffPoolById.GetConfig(config2.Value.Id, true);
				RogueResBuffPool? config5 = ConfigRogueResBuffPoolById.GetConfig(config3.Value.Id, true);
				int? num3 = (config4 != null) ? new int?(config4.GetValueOrDefault().Quality) : null;
				int? num4 = (config5 != null) ? new int?(config5.GetValueOrDefault().Quality) : null;
				if (!(num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null)))
				{
					return config5.Value.Quality - config4.Value.Quality;
				}
				if (config2.Value.SortId != config3.Value.SortId)
				{
					return config2.Value.SortId - config3.Value.SortId;
				}
				return config2.Value.Id - config3.Value.Id;
			});
			foreach (int indexId in list2)
			{
				RogueTokenViewData item = this.CreateTokenViewData(indexId);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060366C3 RID: 222915 RVA: 0x00CE1B28 File Offset: 0x00CDFD28
		[NullableContext(2)]
		private void SelectedItem(RogueTokenViewData data)
		{
			if (data == null)
			{
				return;
			}
			this.RefreshSelectedItemView(data);
		}

		// Token: 0x060366C4 RID: 222916 RVA: 0x00CE1B38 File Offset: 0x00CDFD38
		private void RefreshSelectedItemView(RogueTokenViewData itemViewData)
		{
			if (this.SelectedItemViewData != null)
			{
				this.ItemScrollView.DeselectCurrentGridProxy(false);
			}
			int gridIndex = this.ItemViewDataList.IndexOf(itemViewData);
			if (!this.ItemScrollView.IsGridDisplaying(gridIndex))
			{
				this.ItemScrollView.ScrollToGridIndex(gridIndex, true);
			}
			this.SelectedItemViewData = itemViewData;
			this.ItemScrollView.SelectGridProxy(gridIndex, true);
			this.ItemScrollView.RefreshGridProxy(gridIndex);
			this.RefreshItemTipsComp(itemViewData);
			RogueResCollection? config = ConfigRogueResCollectionByIdKey.GetConfig(itemViewData.GetCollectionIndex(), true);
			SignState collectItemState = ActivityPermanentRogueModel.Instance.GetCollectItemState(config.Value.IdKey);
			UUIItem item = base.GetItem(5);
			if (collectItemState == SignState.IsReceive)
			{
				item.SetUIActive(false);
				return;
			}
			item.SetUIActive(this.RefreshRewardItemGrid(config.Value.Award, collectItemState == SignState.Lock));
		}

		// Token: 0x060366C5 RID: 222917 RVA: 0x00CE1C04 File Offset: 0x00CDFE04
		public void RefreshItemTipsComp(RogueTokenViewData itemViewData)
		{
			RogueResGainData tokenTipsData = ActivityPermanentRogueModel.Instance.GetTokenTipsData(itemViewData.GetConfigId());
			RogueIllustratedTokenItem infoItem = this.InfoItem;
			if (infoItem == null)
			{
				return;
			}
			infoItem.Refresh(tokenTipsData, true, 0);
		}

		// Token: 0x060366C6 RID: 222918 RVA: 0x00CE1C38 File Offset: 0x00CDFE38
		private RogueTokenViewData CreateTokenViewData(int indexId)
		{
			RogueResCollection? config = ConfigRogueResCollectionByIdKey.GetConfig(indexId, true);
			ActivityPermanentRogueModel instance = ActivityPermanentRogueModel.Instance;
			SignState? signState = (instance != null) ? new SignState?(instance.GetCollectItemState(indexId)) : null;
			IllustratedTokenDataInfo illustratedTokenDataInfo = new IllustratedTokenDataInfo();
			illustratedTokenDataInfo.ConfigId = config.Value.Id;
			illustratedTokenDataInfo.CollectionIndex = indexId;
			SignState? signState2 = signState;
			SignState signState3 = SignState.Lock;
			illustratedTokenDataInfo.IsLock = (signState2.GetValueOrDefault() == signState3 & signState2 != null);
			illustratedTokenDataInfo.HasRedDot = (signState.GetValueOrDefault() == SignState.Unlock);
			illustratedTokenDataInfo.IsSelectOn = false;
			return new RogueTokenViewData(illustratedTokenDataInfo);
		}

		// Token: 0x060366C7 RID: 222919 RVA: 0x00CE1CC8 File Offset: 0x00CDFEC8
		private bool RefreshRewardItemGrid(int rewardId, bool isLock)
		{
			DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(rewardId);
			if (dropPackage == null)
			{
				return false;
			}
			using (IEnumerator<DicIntInt> enumerator = dropPackage.Value.DropPreviewIter().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					DicIntInt dicIntInt = enumerator.Current;
					PropSmallItemGrid parameters = new PropSmallItemGrid
					{
						Data = null,
						ItemConfigId = new int?(dicIntInt.Key),
						BottomText = dicIntInt.Value.ToString()
					};
					this.CurRewardItemId = dicIntInt.Key;
					this.RewardItemBtn.Apply<PropSmallItemGrid>(parameters);
					this.RewardItemBtn.SetLockBlackVisible(isLock);
					this.RewardItemBtn.SetReceivableVisible(!isLock);
				}
			}
			string textStringId = isLock ? "RogueRes_Lock" : "RogueRes_Unlock";
			FColor changeColor = base.GetTexture(9).changeColor;
			UUIItem texture = base.GetTexture(9);
			bool bUseChangeColor = !isLock;
			FColor? fcolor = new FColor?(changeColor);
			texture.SetChangeColor(bUseChangeColor, fcolor);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), textStringId, Array.Empty<object>());
			UUIButtonComponent button = base.GetButton(6);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(!isLock);
			}
			if (base.GetUiNiagara(10).GetIsActive() && !isLock)
			{
				base.GetUiNiagara(10).ActivateSystem(true);
			}
			else
			{
				base.GetUiNiagara(10).SetUIActive(!isLock);
			}
			return true;
		}

		// Token: 0x060366C8 RID: 222920 RVA: 0x00CE1E48 File Offset: 0x00CE0048
		private void RefreshGetAllRewardBtn()
		{
			RogueResTheme? config = ((RogueIllustratedTabData)this.Params).Config;
			bool haveTokenAward = ActivityPermanentRogueModel.Instance.GetHaveTokenAward((config != null) ? config.GetValueOrDefault().Id : 0);
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(haveTokenAward);
		}

		// Token: 0x060366C9 RID: 222921 RVA: 0x00CE1EAC File Offset: 0x00CE00AC
		private void OnGetRewardUpdate()
		{
			this.RefreshGetAllRewardBtn();
			RogueResTheme? config = ((RogueIllustratedTabData)this.Params).Config;
			RogueTokenViewData selectedItemViewData = this.SelectedItemViewData;
			int? num = (selectedItemViewData != null) ? new int?(selectedItemViewData.GetConfigId()) : null;
			this.ItemViewDataList = this.GenerateTokenViewData(config);
			foreach (RogueTokenViewData rogueTokenViewData in this.ItemViewDataList)
			{
				int? num2 = num;
				int configId = rogueTokenViewData.GetConfigId();
				if (num2.GetValueOrDefault() == configId & num2 != null)
				{
					this.SelectedItemViewData = rogueTokenViewData;
					break;
				}
			}
			this.ItemScrollView.UpdateData(this.ItemViewDataList);
			this.RefreshSelectedItemView(this.SelectedItemViewData);
		}

		// Token: 0x060366CD RID: 222925 RVA: 0x00CE1FB4 File Offset: 0x00CE01B4
		[CompilerGenerated]
		internal static int <GenerateTokenViewData>g__stateSwitch|19_0(SignState a)
		{
			if (a == SignState.Lock)
			{
				return 2;
			}
			if (a != SignState.Unlock)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0401CC4E RID: 117838
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RogueIllustratedTokenMediumItemGrid, RogueTokenViewData> ItemScrollView;

		// Token: 0x0401CC4F RID: 117839
		private List<RogueTokenViewData> ItemViewDataList = new List<RogueTokenViewData>();

		// Token: 0x0401CC50 RID: 117840
		[Nullable(2)]
		private RogueTokenViewData SelectedItemViewData;

		// Token: 0x0401CC51 RID: 117841
		private int CurRewardItemId;

		// Token: 0x0401CC52 RID: 117842
		[Nullable(2)]
		private RogueIllustratedTokenItem InfoItem;

		// Token: 0x0401CC53 RID: 117843
		[Nullable(2)]
		private SmallItemGrid RewardItemBtn;
	}
}
