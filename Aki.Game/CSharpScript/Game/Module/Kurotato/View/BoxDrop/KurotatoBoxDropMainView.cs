using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005773 RID: 22387
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoBoxDropMainView : UiViewBase
	{
		// Token: 0x06038DE5 RID: 232933 RVA: 0x00D83188 File Offset: 0x00D81388
		public KurotatoBoxDropMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038DE6 RID: 232934 RVA: 0x00D831C0 File Offset: 0x00D813C0
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

		// Token: 0x06038DE7 RID: 232935 RVA: 0x00D832CE File Offset: 0x00D814CE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.KurotatoOnChestRewardDataChanged, new Action(this.OnChestRewardChanged));
		}

		// Token: 0x06038DE8 RID: 232936 RVA: 0x00D832EC File Offset: 0x00D814EC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.KurotatoOnChestRewardDataChanged, new Action(this.OnChestRewardChanged));
		}

		// Token: 0x06038DE9 RID: 232937 RVA: 0x00D8330C File Offset: 0x00D8150C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoBoxDropMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoBoxDropMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038DEA RID: 232938 RVA: 0x00D83350 File Offset: 0x00D81550
		private UniTask CreatePopupPanel()
		{
			KurotatoBoxDropMainView.<CreatePopupPanel>d__11 <CreatePopupPanel>d__;
			<CreatePopupPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreatePopupPanel>d__.<>4__this = this;
			<CreatePopupPanel>d__.<>1__state = -1;
			<CreatePopupPanel>d__.<>t__builder.Start<KurotatoBoxDropMainView.<CreatePopupPanel>d__11>(ref <CreatePopupPanel>d__);
			return <CreatePopupPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06038DEB RID: 232939 RVA: 0x00D83394 File Offset: 0x00D81594
		private UniTask CreateCardItem()
		{
			KurotatoBoxDropMainView.<CreateCardItem>d__12 <CreateCardItem>d__;
			<CreateCardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCardItem>d__.<>4__this = this;
			<CreateCardItem>d__.<>1__state = -1;
			<CreateCardItem>d__.<>t__builder.Start<KurotatoBoxDropMainView.<CreateCardItem>d__12>(ref <CreateCardItem>d__);
			return <CreateCardItem>d__.<>t__builder.Task;
		}

		// Token: 0x06038DEC RID: 232940 RVA: 0x00D833D8 File Offset: 0x00D815D8
		private UniTask CreateExchangeBtnAsync()
		{
			KurotatoBoxDropMainView.<CreateExchangeBtnAsync>d__13 <CreateExchangeBtnAsync>d__;
			<CreateExchangeBtnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateExchangeBtnAsync>d__.<>4__this = this;
			<CreateExchangeBtnAsync>d__.<>1__state = -1;
			<CreateExchangeBtnAsync>d__.<>t__builder.Start<KurotatoBoxDropMainView.<CreateExchangeBtnAsync>d__13>(ref <CreateExchangeBtnAsync>d__);
			return <CreateExchangeBtnAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038DED RID: 232941 RVA: 0x00D8341C File Offset: 0x00D8161C
		private UniTask CreateSelectBtnAsync()
		{
			KurotatoBoxDropMainView.<CreateSelectBtnAsync>d__14 <CreateSelectBtnAsync>d__;
			<CreateSelectBtnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSelectBtnAsync>d__.<>4__this = this;
			<CreateSelectBtnAsync>d__.<>1__state = -1;
			<CreateSelectBtnAsync>d__.<>t__builder.Start<KurotatoBoxDropMainView.<CreateSelectBtnAsync>d__14>(ref <CreateSelectBtnAsync>d__);
			return <CreateSelectBtnAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038DEE RID: 232942 RVA: 0x00D8345F File Offset: 0x00D8165F
		protected override void OnStart()
		{
			this.RefreshAttrSelectLayout();
			this.RefreshChangeNum();
			this.CommonPopupPanel.SetTitleLocalText("Kurotato_Reward_Title");
		}

		// Token: 0x06038DEF RID: 232943 RVA: 0x00D8347D File Offset: 0x00D8167D
		protected override void OnBeforeShow()
		{
			this.CommonPopupPanel.HideAttrChangeFx();
			this.OnChestRewardChanged();
		}

		// Token: 0x06038DF0 RID: 232944 RVA: 0x00D83490 File Offset: 0x00D81690
		private void RefreshAttrSelectLayout()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			KurotatoConfig instance2 = KurotatoConfig.Instance;
			int chestItemId = instance.GetChestItemId();
			int roleId = instance.GetRoleId();
			KurotatoCharacter? characterById = instance2.GetCharacterById(roleId);
			IEnumerable<string> enumerable = ((characterById != null) ? characterById.GetValueOrDefault().RecommendedTagsIter() : null) ?? new List<string>();
			List<int> list = ((characterById != null) ? characterById.GetValueOrDefault().ExcludedRecommendItemIdsIter().ToList<int>() : null) ?? new List<int>();
			KurotatoItem? itemConfigByItemId = instance2.GetItemConfigByItemId(chestItemId);
			List<string> list2 = ((itemConfigByItemId != null) ? itemConfigByItemId.GetValueOrDefault().TagsIter().ToList<string>() : null) ?? new List<string>();
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

		// Token: 0x06038DF1 RID: 232945 RVA: 0x00D8360C File Offset: 0x00D8180C
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

		// Token: 0x06038DF2 RID: 232946 RVA: 0x00D83660 File Offset: 0x00D81860
		private void OnChestRewardChanged()
		{
			this.RewardSelected = false;
			this.RefreshAttrSelectLayout();
			this.RefreshChangeNum();
		}

		// Token: 0x06038DF3 RID: 232947 RVA: 0x00D83675 File Offset: 0x00D81875
		private void OnClickSelect(int _)
		{
			this.RequestChestRewardSelect(false).Forget();
		}

		// Token: 0x06038DF4 RID: 232948 RVA: 0x00D83683 File Offset: 0x00D81883
		private void OnClickRecycle(int _)
		{
			this.RequestChestRewardSelect(true).Forget();
		}

		// Token: 0x06038DF5 RID: 232949 RVA: 0x00D83694 File Offset: 0x00D81894
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

		// Token: 0x06038DF6 RID: 232950 RVA: 0x00D836DF File Offset: 0x00D818DF
		private void OnCardAttrPreview(bool active, IReadOnlyList<IKurotatoAttrPreviewDelta> deltas)
		{
			if (active)
			{
				this.CommonPopupPanel.ShowAttrPreview(deltas);
				return;
			}
			this.CommonPopupPanel.ClearAttrPreview();
		}

		// Token: 0x0401DD37 RID: 122167
		private readonly KurotatoCommonPopupPanel CommonPopupPanel = new KurotatoCommonPopupPanel();

		// Token: 0x0401DD38 RID: 122168
		private readonly KurotatoCardInfoItem CardItem = new KurotatoCardInfoItem();

		// Token: 0x0401DD39 RID: 122169
		private readonly ButtonItem RecycleBtn = new ButtonItem(null);

		// Token: 0x0401DD3A RID: 122170
		private readonly ButtonItem SelectBtn = new ButtonItem(null);

		// Token: 0x0401DD3B RID: 122171
		private bool RewardSelected;

		// Token: 0x0200B97D RID: 47485
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x04038168 RID: 229736
			public const int CommonPopupPanel = 0;

			// Token: 0x04038169 RID: 229737
			public const int TextureIcon = 1;

			// Token: 0x0403816A RID: 229738
			public const int TextChangeNum = 2;

			// Token: 0x0403816B RID: 229739
			public const int HorizontalLayoutAttr = 3;

			// Token: 0x0403816C RID: 229740
			public const int CardItem = 4;

			// Token: 0x0403816D RID: 229741
			public const int BtnRecycle = 5;

			// Token: 0x0403816E RID: 229742
			public const int BtnSelect = 6;
		}
	}
}
