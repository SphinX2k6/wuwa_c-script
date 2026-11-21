using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato.View.AttrSelect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.BoxDrop
{
	// Token: 0x0200474A RID: 18250
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoBoxDropMainView : UiViewBase
	{
		// Token: 0x0602DCF5 RID: 187637 RVA: 0x00CD1C84 File Offset: 0x00CCFE84
		public KurotatoBoxDropMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DCF6 RID: 187638 RVA: 0x00CD1CBC File Offset: 0x00CCFEBC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DCF7 RID: 187639 RVA: 0x00CD1DCA File Offset: 0x00CCFFCA
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.KurotatoOnChestRewardDataChanged, new Action(this.OnChestRewardChanged));
		}

		// Token: 0x0602DCF8 RID: 187640 RVA: 0x00CD1DE8 File Offset: 0x00CCFFE8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.KurotatoOnChestRewardDataChanged, new Action(this.OnChestRewardChanged));
		}

		// Token: 0x0602DCF9 RID: 187641 RVA: 0x00CD1E08 File Offset: 0x00CD0008
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoBoxDropMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoBoxDropMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DCFA RID: 187642 RVA: 0x00CD1E4C File Offset: 0x00CD004C
		private UniTask CreatePopupPanel()
		{
			KurotatoBoxDropMainView.<CreatePopupPanel>d__11 <CreatePopupPanel>d__;
			<CreatePopupPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreatePopupPanel>d__.<>4__this = this;
			<CreatePopupPanel>d__.<>1__state = -1;
			<CreatePopupPanel>d__.<>t__builder.Start<KurotatoBoxDropMainView.<CreatePopupPanel>d__11>(ref <CreatePopupPanel>d__);
			return <CreatePopupPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602DCFB RID: 187643 RVA: 0x00CD1E90 File Offset: 0x00CD0090
		private UniTask CreateCardItem()
		{
			KurotatoBoxDropMainView.<CreateCardItem>d__12 <CreateCardItem>d__;
			<CreateCardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCardItem>d__.<>4__this = this;
			<CreateCardItem>d__.<>1__state = -1;
			<CreateCardItem>d__.<>t__builder.Start<KurotatoBoxDropMainView.<CreateCardItem>d__12>(ref <CreateCardItem>d__);
			return <CreateCardItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602DCFC RID: 187644 RVA: 0x00CD1ED4 File Offset: 0x00CD00D4
		private UniTask CreateExchangeBtnAsync()
		{
			KurotatoBoxDropMainView.<CreateExchangeBtnAsync>d__13 <CreateExchangeBtnAsync>d__;
			<CreateExchangeBtnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateExchangeBtnAsync>d__.<>4__this = this;
			<CreateExchangeBtnAsync>d__.<>1__state = -1;
			<CreateExchangeBtnAsync>d__.<>t__builder.Start<KurotatoBoxDropMainView.<CreateExchangeBtnAsync>d__13>(ref <CreateExchangeBtnAsync>d__);
			return <CreateExchangeBtnAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DCFD RID: 187645 RVA: 0x00CD1F18 File Offset: 0x00CD0118
		private UniTask CreateSelectBtnAsync()
		{
			KurotatoBoxDropMainView.<CreateSelectBtnAsync>d__14 <CreateSelectBtnAsync>d__;
			<CreateSelectBtnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSelectBtnAsync>d__.<>4__this = this;
			<CreateSelectBtnAsync>d__.<>1__state = -1;
			<CreateSelectBtnAsync>d__.<>t__builder.Start<KurotatoBoxDropMainView.<CreateSelectBtnAsync>d__14>(ref <CreateSelectBtnAsync>d__);
			return <CreateSelectBtnAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DCFE RID: 187646 RVA: 0x00CD1F5B File Offset: 0x00CD015B
		protected override void OnStart()
		{
			this.RefreshAttrSelectLayout();
			this.RefreshChangeNum();
			this.CommonPopupPanel.SetTitleLocalText("Kurotato_Reward_Title");
		}

		// Token: 0x0602DCFF RID: 187647 RVA: 0x00CD1F79 File Offset: 0x00CD0179
		protected override void OnBeforeShow()
		{
			this.CommonPopupPanel.HideAttrChangeFx();
			this.OnChestRewardChanged();
		}

		// Token: 0x0602DD00 RID: 187648 RVA: 0x00CD1F8C File Offset: 0x00CD018C
		private void RefreshAttrSelectLayout()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			KurotatoConfig instance2 = KurotatoConfig.Instance;
			int chestItemId = instance.GetChestItemId();
			int roleId = instance.GetRoleId();
			KurotatoCharacter? characterById = instance2.GetCharacterById(roleId);
			IEnumerable<string> enumerable = ((characterById != null) ? characterById.GetValueOrDefault().RecommendedTagsIter() : null) ?? new List<string>();
			IEnumerable<int> enumerable2 = (characterById != null) ? characterById.GetValueOrDefault().ExcludedRecommendItemIdsIter() : null;
			List<int> list = (enumerable2 != null) ? new List<int>(enumerable2) : new List<int>();
			KurotatoItem? itemConfigByItemId = instance2.GetItemConfigByItemId(chestItemId);
			IEnumerable<string> enumerable3 = (itemConfigByItemId != null) ? itemConfigByItemId.GetValueOrDefault().TagsIter() : null;
			List<string> list2 = (enumerable3 != null) ? new List<string>(enumerable3) : new List<string>();
			bool flag = list.Contains(chestItemId);
			bool isRecommend = false;
			if (!flag)
			{
				foreach (string item in enumerable)
				{
					if (list2.Contains(item))
					{
						isRecommend = true;
						break;
					}
				}
			}
			this.CardItem.Refresh(new KurotatoCardItemData
			{
				Id = chestItemId,
				SelectionId = 0,
				Cost = 0,
				HasBuy = false,
				IsRecommend = isRecommend,
				CardType = EKurotatoCardType.Item,
				HasLock = false,
				ShowLock = false
			});
			this.RecycleBtn.SetLocalTextNew("PrefabTextItem_538048862_Text", new object[]
			{
				instance.GetChestSoldPrice()
			});
		}

		// Token: 0x0602DD01 RID: 187649 RVA: 0x00CD2114 File Offset: 0x00CD0314
		private void RefreshChangeNum()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			int chestRewardIndex = instance.GetChestRewardIndex();
			int chestRewardCount = instance.GetChestRewardCount();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "PrefabTextItem_1132806154_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				chestRewardIndex.ToString(),
				chestRewardCount.ToString()
			}));
		}

		// Token: 0x0602DD02 RID: 187650 RVA: 0x00CD2168 File Offset: 0x00CD0368
		private void OnChestRewardChanged()
		{
			this.RewardSelected = false;
			this.RefreshAttrSelectLayout();
			this.RefreshChangeNum();
		}

		// Token: 0x0602DD03 RID: 187651 RVA: 0x00CD217D File Offset: 0x00CD037D
		private void OnClickSelect(int _)
		{
			this.RequestChestRewardSelect(false).Forget();
		}

		// Token: 0x0602DD04 RID: 187652 RVA: 0x00CD218B File Offset: 0x00CD038B
		private void OnClickRecycle(int _)
		{
			this.RequestChestRewardSelect(true).Forget();
		}

		// Token: 0x0602DD05 RID: 187653 RVA: 0x00CD219C File Offset: 0x00CD039C
		private UniTask RequestChestRewardSelect(bool willSold)
		{
			KurotatoBoxDropMainView.<RequestChestRewardSelect>d__22 <RequestChestRewardSelect>d__;
			<RequestChestRewardSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestChestRewardSelect>d__.<>4__this = this;
			<RequestChestRewardSelect>d__.willSold = willSold;
			<RequestChestRewardSelect>d__.<>1__state = -1;
			<RequestChestRewardSelect>d__.<>t__builder.Start<KurotatoBoxDropMainView.<RequestChestRewardSelect>d__22>(ref <RequestChestRewardSelect>d__);
			return <RequestChestRewardSelect>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD06 RID: 187654 RVA: 0x00CD21E7 File Offset: 0x00CD03E7
		private void OnCardAttrPreview(bool active, IReadOnlyList<IKurotatoAttrPreviewDelta> deltas)
		{
			if (active)
			{
				this.CommonPopupPanel.ShowAttrPreview(deltas);
				return;
			}
			this.CommonPopupPanel.ClearAttrPreview();
		}

		// Token: 0x040187CD RID: 100301
		private readonly KurotatoCommonPopupPanel CommonPopupPanel = new KurotatoCommonPopupPanel();

		// Token: 0x040187CE RID: 100302
		private readonly KurotatoCardInfoItem CardItem = new KurotatoCardInfoItem();

		// Token: 0x040187CF RID: 100303
		private readonly ButtonItem RecycleBtn = new ButtonItem(null);

		// Token: 0x040187D0 RID: 100304
		private readonly ButtonItem SelectBtn = new ButtonItem(null);

		// Token: 0x040187D1 RID: 100305
		private bool RewardSelected;

		// Token: 0x0200A397 RID: 41879
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x04032B62 RID: 207714
			public const int CommonPopupPanel = 0;

			// Token: 0x04032B63 RID: 207715
			public const int TextureIcon = 1;

			// Token: 0x04032B64 RID: 207716
			public const int TextChangeNum = 2;

			// Token: 0x04032B65 RID: 207717
			public const int HorizontalLayoutAttr = 3;

			// Token: 0x04032B66 RID: 207718
			public const int CardItem = 4;

			// Token: 0x04032B67 RID: 207719
			public const int BtnRecycle = 5;

			// Token: 0x04032B68 RID: 207720
			public const int BtnSelect = 6;
		}
	}
}
