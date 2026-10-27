using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005318 RID: 21272
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueIllustratedEventTabView : UiTabViewBase
	{
		// Token: 0x0603666C RID: 222828 RVA: 0x00CDFC20 File Offset: 0x00CDDE20
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUITexture)),
				new ValueTuple<int, Type>(11, typeof(UUINiagara)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(13, new Action(this.OnClickGetAllReward)),
				new ValueTuple<int, Delegate>(6, new Action(delegate()
				{
					this.OnClickGetReward(null);
				}))
			};
		}

		// Token: 0x0603666D RID: 222829 RVA: 0x00CDFDB0 File Offset: 0x00CDDFB0
		protected override UniTask OnBeforeStartAsync()
		{
			RogueIllustratedEventTabView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueIllustratedEventTabView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603666E RID: 222830 RVA: 0x00CDFDF3 File Offset: 0x00CDDFF3
		protected override void OnStart()
		{
			this.InitializeScrollView();
		}

		// Token: 0x0603666F RID: 222831 RVA: 0x00CDFDFB File Offset: 0x00CDDFFB
		protected override void OnBeforeShow()
		{
			this.RefreshItemData();
			this.RefreshGetAllRewardBtn();
		}

		// Token: 0x06036670 RID: 222832 RVA: 0x00CDFE09 File Offset: 0x00CDE009
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(this.OnGetRewardUpdate));
		}

		// Token: 0x06036671 RID: 222833 RVA: 0x00CDFE27 File Offset: 0x00CDE027
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(this.OnGetRewardUpdate));
		}

		// Token: 0x06036672 RID: 222834 RVA: 0x00CDFE45 File Offset: 0x00CDE045
		protected override void OnBeforeDestroy()
		{
			this.SelectedItemViewData = null;
			this.ScrollView = null;
			this.RewardItemBtn = null;
		}

		// Token: 0x06036673 RID: 222835 RVA: 0x00CDFE61 File Offset: 0x00CDE061
		private void InitializeScrollView()
		{
			this.ScrollView = new LoopScrollView<RogueIllustratedEventItem, int>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<RogueIllustratedEventItem>(this.OnGridProxyCreate), false);
		}

		// Token: 0x06036674 RID: 222836 RVA: 0x00CDFE94 File Offset: 0x00CDE094
		private void RefreshItemData()
		{
			RogueIllustratedTabData rogueIllustratedTabData = (RogueIllustratedTabData)this.Params;
			RogueResTheme? config = rogueIllustratedTabData.Config;
			this.ItemViewDataList = this.GenerateTokenViewData(config);
			this.ScrollView.RefreshByData(this.ItemViewDataList, false, delegate
			{
				SignState collectItemState = ActivityPermanentRogueModel.Instance.GetCollectItemState(this.ItemViewDataList[0]);
				this.OnItemButtonClicked(this.ItemViewDataList[0], collectItemState);
			}, true);
			ActivityPermanentRogueModel instance = ActivityPermanentRogueModel.Instance;
			RogueIllustratedTabData rogueIllustratedTabData2 = rogueIllustratedTabData;
			int[] eventCount = instance.GetEventCount((rogueIllustratedTabData2.Config != null) ? rogueIllustratedTabData2.Config.GetValueOrDefault().Id : 0, rogueIllustratedTabData.TabType == ERogueHandbookType.NormalEvent);
			LguiUtil instance2 = LguiUtil.Instance;
			UUIText text = base.GetText(2);
			string textStringId = "RogueRes_UnlockProgress";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(eventCount[0]);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(eventCount[1]);
			instance2.SetLocalTextNew(text, textStringId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
		}

		// Token: 0x06036675 RID: 222837 RVA: 0x00CDFF5E File Offset: 0x00CDE15E
		private RogueIllustratedEventItem OnGridProxyCreate()
		{
			RogueIllustratedEventItem rogueIllustratedEventItem = new RogueIllustratedEventItem();
			rogueIllustratedEventItem.BindOnItemButtonClickedCallback(new Action<int, SignState>(this.OnItemButtonClicked));
			return rogueIllustratedEventItem;
		}

		// Token: 0x06036676 RID: 222838 RVA: 0x00CDFF78 File Offset: 0x00CDE178
		private void OnItemButtonClicked(int data, SignState state)
		{
			int? selectedItemViewData = this.SelectedItemViewData;
			if (selectedItemViewData.GetValueOrDefault() == data & selectedItemViewData != null)
			{
				int gridIndex = this.ItemViewDataList.IndexOf(data);
				this.ScrollView.DeselectCurrentGridProxy(false);
				this.ScrollView.SelectGridProxy(gridIndex, false);
				return;
			}
			this.SelectedItem(new int?(data));
		}

		// Token: 0x06036677 RID: 222839 RVA: 0x00CDFFD8 File Offset: 0x00CDE1D8
		private void OnClickGetAllReward()
		{
			RogueIllustratedTabData rogueIllustratedTabData = (RogueIllustratedTabData)this.Params;
			RogueResTheme? config = rogueIllustratedTabData.Config;
			HashSet<int> hashSet = (rogueIllustratedTabData.TabType == ERogueHandbookType.NormalEvent) ? ActivityPermanentRogueModel.Instance.GetNormalIndexSet(config) : ActivityPermanentRogueModel.Instance.GetMapIndexSet(config);
			List<int> list = new List<int>();
			foreach (int num in hashSet)
			{
				if (ActivityPermanentRogueModel.Instance.GetCollectItemState(num) == SignState.Unlock)
				{
					list.Add(num);
				}
			}
			(ActivityManager.GetActivityController(ActivityType.RogueRes) as ActivityPermanentRogueController).RequestIllustrationAward(list.ToArray());
		}

		// Token: 0x06036678 RID: 222840 RVA: 0x00CE0084 File Offset: 0x00CDE284
		private void OnClickGetReward(MediumItemGridExtendCallback _)
		{
			if (this.SelectedItemViewData == null)
			{
				return;
			}
			if (ActivityPermanentRogueModel.Instance.GetCollectItemState(this.SelectedItemViewData.Value) != SignState.Unlock)
			{
				ItemController.Instance.OpenItemTipsByItemId(this.CurRewardItemId, true, null);
				return;
			}
			(ActivityManager.GetActivityController(ActivityType.RogueRes) as ActivityPermanentRogueController).RequestIllustrationAward(new int[]
			{
				this.SelectedItemViewData.Value
			});
		}

		// Token: 0x06036679 RID: 222841 RVA: 0x00CE00F0 File Offset: 0x00CDE2F0
		private List<int> GenerateTokenViewData(RogueResTheme? config)
		{
			HashSet<int> collection = new HashSet<int>();
			if (((RogueIllustratedTabData)this.Params).TabType == ERogueHandbookType.NormalEvent)
			{
				collection = ActivityPermanentRogueModel.Instance.GetNormalIndexSet(config);
			}
			else
			{
				collection = ActivityPermanentRogueModel.Instance.GetMapIndexSet(config);
			}
			List<int> list = new List<int>(collection);
			list.Sort(delegate(int a, int b)
			{
				int num = RogueIllustratedEventTabView.<GenerateTokenViewData>g__stateSwitch|18_0(ActivityPermanentRogueModel.Instance.GetCollectItemState(a));
				int num2 = RogueIllustratedEventTabView.<GenerateTokenViewData>g__stateSwitch|18_0(ActivityPermanentRogueModel.Instance.GetCollectItemState(b));
				if (num != num2)
				{
					return num - num2;
				}
				RogueResCollection value = ConfigRogueResCollectionByIdKey.GetConfig(a, true).Value;
				RogueResCollection value2 = ConfigRogueResCollectionByIdKey.GetConfig(b, true).Value;
				if (value.SortId != value2.SortId)
				{
					return value.SortId - value2.SortId;
				}
				return value.Id - value2.Id;
			});
			return list;
		}

		// Token: 0x0603667A RID: 222842 RVA: 0x00CE015D File Offset: 0x00CDE35D
		private void SelectedItem(int? data)
		{
			if (data == null)
			{
				return;
			}
			this.RefreshSelectedItemView(data.Value);
		}

		// Token: 0x0603667B RID: 222843 RVA: 0x00CE0178 File Offset: 0x00CDE378
		private void RefreshSelectedItemView(int itemViewData)
		{
			if (this.SelectedItemViewData != null)
			{
				this.ScrollView.DeselectCurrentGridProxy(false);
			}
			int gridIndex = this.ItemViewDataList.IndexOf(itemViewData);
			if (!this.ScrollView.IsGridDisplaying(gridIndex))
			{
				this.ScrollView.ScrollToGridIndex(gridIndex, true);
			}
			this.SelectedItemViewData = new int?(itemViewData);
			this.ScrollView.SelectGridProxy(gridIndex, true);
			this.ScrollView.RefreshGridProxy(gridIndex);
			this.RefreshItemTipsComp(itemViewData);
		}

		// Token: 0x0603667C RID: 222844 RVA: 0x00CE01F4 File Offset: 0x00CDE3F4
		public void RefreshItemTipsComp(int index)
		{
			RogueResCollection? config = ConfigRogueResCollectionByIdKey.GetConfig(index, true);
			int id = config.Value.Id;
			SignState collectItemState = ActivityPermanentRogueModel.Instance.GetCollectItemState(index);
			RogueResGridEvent? config2 = ConfigRogueResGridEventById.GetConfig(id, true);
			RogueResEventPlot? rogueEventPlotById = MapRogueConfig.Instance.GetRogueEventPlotById(config2.Value.Plot);
			RogueResEventBg? eventBgById = MapRogueConfig.Instance.GetEventBgById(rogueEventPlotById.Value.BgResource);
			PlayerInfoModel instance = PlayerInfoModel.Instance;
			EPlayerGender? eplayerGender = (instance != null) ? new EPlayerGender?(instance.GetPlayerGender()) : null;
			EPlayerGender eplayerGender2 = EPlayerGender.Female;
			string path = (eplayerGender.GetValueOrDefault() == eplayerGender2 & eplayerGender != null) ? eventBgById.Value.HandBookBgFemalePath : eventBgById.Value.HandBookBgPath;
			base.SetTextureByPath(path, base.GetTexture(3), null, delegate(bool _)
			{
				base.GetTexture(3).SetSizeFromTexture();
			});
			if (collectItemState != SignState.Lock)
			{
				string text = StringUtils.IsBlank(config.Value.Desc) ? config2.Value.Desc : config.Value.Desc;
				UUIItem item = base.GetItem(7);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(12);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), text ?? "", Array.Empty<object>());
			}
			else
			{
				UUIItem item3 = base.GetItem(7);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
				UUIItem item4 = base.GetItem(12);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RogueRes_CollectionEventLock", Array.Empty<object>());
			}
			if (collectItemState != SignState.IsReceive)
			{
				UUIItem item5 = base.GetItem(8);
				if (item5 != null)
				{
					item5.SetUIActive(true);
				}
				this.RefreshRewardItemGrid(config.Value.Award, collectItemState == SignState.Lock);
				return;
			}
			UUIItem item6 = base.GetItem(8);
			if (item6 == null)
			{
				return;
			}
			item6.SetUIActive(false);
		}

		// Token: 0x0603667D RID: 222845 RVA: 0x00CE03F8 File Offset: 0x00CDE5F8
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
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), textStringId, Array.Empty<object>());
			UUIButtonComponent button = base.GetButton(6);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(!isLock);
			}
			FColor changeColor = base.GetTexture(10).changeColor;
			UUIItem texture = base.GetTexture(10);
			bool bUseChangeColor = !isLock;
			FColor? fcolor = new FColor?(changeColor);
			texture.SetChangeColor(bUseChangeColor, fcolor);
			if (base.GetUiNiagara(11).GetIsActive() && !isLock)
			{
				base.GetUiNiagara(11).ActivateSystem(true);
			}
			else
			{
				base.GetUiNiagara(11).SetUIActive(!isLock);
			}
			return true;
		}

		// Token: 0x0603667E RID: 222846 RVA: 0x00CE0578 File Offset: 0x00CDE778
		private void RefreshGetAllRewardBtn()
		{
			RogueIllustratedTabData rogueIllustratedTabData = (RogueIllustratedTabData)this.Params;
			RogueResTheme? config = rogueIllustratedTabData.Config;
			bool uiactive = (rogueIllustratedTabData.TabType == ERogueHandbookType.NormalEvent) ? ActivityPermanentRogueModel.Instance.GetHaveNormalAward((config != null) ? config.Value.Id : 0) : ActivityPermanentRogueModel.Instance.GetHaveMapAward((config != null) ? config.Value.Id : 0);
			UUIButtonComponent button = base.GetButton(13);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(uiactive);
		}

		// Token: 0x0603667F RID: 222847 RVA: 0x00CE0610 File Offset: 0x00CDE810
		private void OnGetRewardUpdate()
		{
			this.RefreshGetAllRewardBtn();
			RogueResTheme? config = ((RogueIllustratedTabData)this.Params).Config;
			this.ItemViewDataList = this.GenerateTokenViewData(config);
			this.ScrollView.UpdateData(this.ItemViewDataList);
			this.ScrollView.DeselectCurrentGridProxy(false);
			this.ScrollView.SelectGridProxy(this.ItemViewDataList.IndexOf(this.SelectedItemViewData.Value), false);
			this.RefreshItemTipsComp(this.SelectedItemViewData.Value);
		}

		// Token: 0x06036683 RID: 222851 RVA: 0x00CE06E7 File Offset: 0x00CDE8E7
		[CompilerGenerated]
		internal static int <GenerateTokenViewData>g__stateSwitch|18_0(SignState a)
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

		// Token: 0x0401CC13 RID: 117779
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<RogueIllustratedEventItem, int> ScrollView;

		// Token: 0x0401CC14 RID: 117780
		private List<int> ItemViewDataList = new List<int>();

		// Token: 0x0401CC15 RID: 117781
		private int CurRewardItemId;

		// Token: 0x0401CC16 RID: 117782
		private int? SelectedItemViewData;

		// Token: 0x0401CC17 RID: 117783
		[Nullable(2)]
		private SmallItemGrid RewardItemBtn;
	}
}
