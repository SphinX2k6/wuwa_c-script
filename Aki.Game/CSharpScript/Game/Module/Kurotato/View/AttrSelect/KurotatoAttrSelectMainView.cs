using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x0200474E RID: 18254
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttrSelectMainView : UiViewBase
	{
		// Token: 0x0602DD22 RID: 187682 RVA: 0x00CD29DC File Offset: 0x00CD0BDC
		public KurotatoAttrSelectMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DD23 RID: 187683 RVA: 0x00CD29F0 File Offset: 0x00CD0BF0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
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
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickRefresh));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DD24 RID: 187684 RVA: 0x00CD2B3B File Offset: 0x00CD0D3B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.KurotatoOnUpgradeRewardDataChanged, new Action(this.OnUpgradeRewardChanged));
		}

		// Token: 0x0602DD25 RID: 187685 RVA: 0x00CD2B59 File Offset: 0x00CD0D59
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.KurotatoOnUpgradeRewardDataChanged, new Action(this.OnUpgradeRewardChanged));
		}

		// Token: 0x0602DD26 RID: 187686 RVA: 0x00CD2B78 File Offset: 0x00CD0D78
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoAttrSelectMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoAttrSelectMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD27 RID: 187687 RVA: 0x00CD2BBC File Offset: 0x00CD0DBC
		private UniTask CreatePopupPanel()
		{
			KurotatoAttrSelectMainView.<CreatePopupPanel>d__9 <CreatePopupPanel>d__;
			<CreatePopupPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreatePopupPanel>d__.<>4__this = this;
			<CreatePopupPanel>d__.<>1__state = -1;
			<CreatePopupPanel>d__.<>t__builder.Start<KurotatoAttrSelectMainView.<CreatePopupPanel>d__9>(ref <CreatePopupPanel>d__);
			return <CreatePopupPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD28 RID: 187688 RVA: 0x00CD2BFF File Offset: 0x00CD0DFF
		private void CreateAttrSelectLayout()
		{
			this.AttrSelectLayout = new GenericLayout<KurotatoAttrSelectCard, IKurotatoAttrSelectCardData>(base.GetHorizontalLayout(2), delegate()
			{
				KurotatoAttrSelectCard kurotatoAttrSelectCard = new KurotatoAttrSelectCard();
				kurotatoAttrSelectCard.SetFunctionCb(new Action<int>(this.OnClickSelectFunction));
				kurotatoAttrSelectCard.SetAttrPreviewCb(new Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>>(this.OnCardAttrPreview));
				return kurotatoAttrSelectCard;
			}, null, false, true);
		}

		// Token: 0x0602DD29 RID: 187689 RVA: 0x00CD2C22 File Offset: 0x00CD0E22
		protected override void OnStart()
		{
			this.RefreshAttrSelectLayout();
			this.RefreshBtnRefresh();
			this.RefreshChangeNum();
			this.CommonPopupPanel.SetTitleLocalText("Kurotato_LevelUp_Title");
		}

		// Token: 0x0602DD2A RID: 187690 RVA: 0x00CD2C46 File Offset: 0x00CD0E46
		protected override void OnBeforeShow()
		{
			this.CommonPopupPanel.HideAttrChangeFx();
			this.OnUpgradeRewardChanged();
		}

		// Token: 0x0602DD2B RID: 187691 RVA: 0x00CD2C5C File Offset: 0x00CD0E5C
		private void RefreshAttrSelectLayout()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			KurotatoConfig instance2 = KurotatoConfig.Instance;
			int roleId = instance.GetRoleId();
			KurotatoCharacter? characterById = instance2.GetCharacterById(roleId);
			IEnumerable<string> enumerable = (characterById != null) ? characterById.GetValueOrDefault().RecommendedTagsIter() : null;
			List<string> list = (enumerable != null) ? new List<string>(enumerable) : new List<string>();
			IEnumerable<int> enumerable2 = (characterById != null) ? characterById.GetValueOrDefault().ExcludedRecommendItemIdsIter() : null;
			List<int> list2 = (enumerable2 != null) ? new List<int>(enumerable2) : new List<int>();
			this.CommonPopupPanel.ClearAttrPreview();
			GenericLayout<KurotatoAttrSelectCard, IKurotatoAttrSelectCardData> attrSelectLayout = this.AttrSelectLayout;
			foreach (KurotatoAttrSelectCard kurotatoAttrSelectCard in (((attrSelectLayout != null) ? attrSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoAttrSelectCard>()))
			{
				kurotatoAttrSelectCard.ClearAttrPreviewSelection();
			}
			List<IKurotatoAttrSelectCardData> list3 = new List<IKurotatoAttrSelectCardData>();
			foreach (KurotatoItemRewardPbData kurotatoItemRewardPbData in instance.GetUpgradeRewardData())
			{
				KurotatoItem? kurotatoItem;
				IEnumerable<string> enumerable3 = (instance2.GetItemConfigByItemId(kurotatoItemRewardPbData.ItemId) != null) ? kurotatoItem.GetValueOrDefault().TagsIter() : null;
				List<string> list4 = (enumerable3 != null) ? new List<string>(enumerable3) : new List<string>();
				bool flag = list2.Contains(kurotatoItemRewardPbData.ItemId);
				bool isRecommend = false;
				if (!flag)
				{
					foreach (string item in list)
					{
						if (list4.Contains(item))
						{
							isRecommend = true;
							break;
						}
					}
				}
				list3.Add(new KurotatoAttrSelectCardData
				{
					ItemId = kurotatoItemRewardPbData.ItemId,
					SelectionId = kurotatoItemRewardPbData.SelectionId,
					IsRecommend = isRecommend,
					SelectType = EKurotatoAttrSelectType.Upgrade
				});
			}
			this.AttrSelectLayout.RefreshByData(list3, null, true);
		}

		// Token: 0x0602DD2C RID: 187692 RVA: 0x00CD2E78 File Offset: 0x00CD1078
		private void ClearAttrSelectLayout()
		{
			this.CommonPopupPanel.ClearAttrPreview();
			GenericLayout<KurotatoAttrSelectCard, IKurotatoAttrSelectCardData> attrSelectLayout = this.AttrSelectLayout;
			if (attrSelectLayout == null)
			{
				return;
			}
			attrSelectLayout.RefreshByData(new List<IKurotatoAttrSelectCardData>(), null, false);
		}

		// Token: 0x0602DD2D RID: 187693 RVA: 0x00CD2E9C File Offset: 0x00CD109C
		private void RefreshBtnRefresh()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			int refreshCost = instance.GetRefreshCost();
			UUIText text = base.GetText(5);
			text.SetText(refreshCost.ToString(), true);
			base.GetText(6).SetUIActive(false);
			bool flag = instance.BattleData.GetCurrencyCount() < refreshCost;
			base.GetButton(4).SetSelfInteractive(!flag);
			UUIItem uuiitem = text;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x0602DD2E RID: 187694 RVA: 0x00CD2F0C File Offset: 0x00CD110C
		private void RefreshChangeNum()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			int upgradeRewardIndex = instance.GetUpgradeRewardIndex();
			int upgradeRewardCount = instance.GetUpgradeRewardCount();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Kurotato_Levelchoose", new <>z__ReadOnlyArray<object>(new object[]
			{
				upgradeRewardIndex.ToString(),
				upgradeRewardCount.ToString()
			}));
		}

		// Token: 0x0602DD2F RID: 187695 RVA: 0x00CD2F60 File Offset: 0x00CD1160
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length < 2 || configParams[0] != "UpgradeRecommend")
			{
				return null;
			}
			int num;
			if (!int.TryParse(configParams[1], out num))
			{
				return null;
			}
			int num2 = num - 1;
			if (num2 < 0)
			{
				return null;
			}
			KurotatoAttrSelectCard nthRecommendCard = this.GetNthRecommendCard(num2);
			if (nthRecommendCard == null)
			{
				return null;
			}
			return nthRecommendCard.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0602DD30 RID: 187696 RVA: 0x00CD2FB0 File Offset: 0x00CD11B0
		[NullableContext(2)]
		private KurotatoAttrSelectCard GetNthRecommendCard(int idx)
		{
			int num = 0;
			GenericLayout<KurotatoAttrSelectCard, IKurotatoAttrSelectCardData> attrSelectLayout = this.AttrSelectLayout;
			foreach (KurotatoAttrSelectCard kurotatoAttrSelectCard in (((attrSelectLayout != null) ? attrSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoAttrSelectCard>()))
			{
				if (kurotatoAttrSelectCard.IsRecommend())
				{
					if (num == idx)
					{
						return kurotatoAttrSelectCard;
					}
					num++;
				}
			}
			return null;
		}

		// Token: 0x0602DD31 RID: 187697 RVA: 0x00CD302C File Offset: 0x00CD122C
		private void OnClickRefresh()
		{
			if (this.RequestPending)
			{
				return;
			}
			KurotatoModel instance = KurotatoModel.Instance;
			if (instance.BattleData.GetCurrencyCount() < instance.GetRefreshCost())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Kurotato_Insufficient_Gold_Coins", Array.Empty<object>());
				return;
			}
			this.RequestPending = true;
			this.RequestRefreshAsync().Forget();
		}

		// Token: 0x0602DD32 RID: 187698 RVA: 0x00CD3084 File Offset: 0x00CD1284
		private UniTask RequestRefreshAsync()
		{
			KurotatoAttrSelectMainView.<RequestRefreshAsync>d__20 <RequestRefreshAsync>d__;
			<RequestRefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRefreshAsync>d__.<>4__this = this;
			<RequestRefreshAsync>d__.<>1__state = -1;
			<RequestRefreshAsync>d__.<>t__builder.Start<KurotatoAttrSelectMainView.<RequestRefreshAsync>d__20>(ref <RequestRefreshAsync>d__);
			return <RequestRefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD33 RID: 187699 RVA: 0x00CD30C7 File Offset: 0x00CD12C7
		private void OnClickSelectFunction(int selectionId)
		{
			this.OnClickSelectFunctionImpAsync(selectionId).Forget();
		}

		// Token: 0x0602DD34 RID: 187700 RVA: 0x00CD30D8 File Offset: 0x00CD12D8
		private UniTask OnClickSelectFunctionImpAsync(int selectionId)
		{
			KurotatoAttrSelectMainView.<OnClickSelectFunctionImpAsync>d__22 <OnClickSelectFunctionImpAsync>d__;
			<OnClickSelectFunctionImpAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnClickSelectFunctionImpAsync>d__.<>4__this = this;
			<OnClickSelectFunctionImpAsync>d__.selectionId = selectionId;
			<OnClickSelectFunctionImpAsync>d__.<>1__state = -1;
			<OnClickSelectFunctionImpAsync>d__.<>t__builder.Start<KurotatoAttrSelectMainView.<OnClickSelectFunctionImpAsync>d__22>(ref <OnClickSelectFunctionImpAsync>d__);
			return <OnClickSelectFunctionImpAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD35 RID: 187701 RVA: 0x00CD3123 File Offset: 0x00CD1323
		private void OnUpgradeRewardChanged()
		{
			this.RequestPending = false;
			this.RefreshAttrSelectLayout();
			this.RefreshBtnRefresh();
			this.RefreshChangeNum();
		}

		// Token: 0x0602DD36 RID: 187702 RVA: 0x00CD3140 File Offset: 0x00CD1340
		private void OnCardAttrPreview(int selectionId, bool active, IReadOnlyList<IKurotatoAttrPreviewDelta> deltas)
		{
			if (!active)
			{
				this.CommonPopupPanel.ClearAttrPreview();
				return;
			}
			this.CommonPopupPanel.ShowAttrPreview(deltas);
			GenericLayout<KurotatoAttrSelectCard, IKurotatoAttrSelectCardData> attrSelectLayout = this.AttrSelectLayout;
			foreach (KurotatoAttrSelectCard kurotatoAttrSelectCard in (((attrSelectLayout != null) ? attrSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoAttrSelectCard>()))
			{
				if (kurotatoAttrSelectCard.GetSelectionId() != selectionId)
				{
					kurotatoAttrSelectCard.ClearAttrPreviewSelection();
				}
			}
		}

		// Token: 0x040187D9 RID: 100313
		private readonly KurotatoCommonPopupPanel CommonPopupPanel = new KurotatoCommonPopupPanel();

		// Token: 0x040187DA RID: 100314
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoAttrSelectCard, IKurotatoAttrSelectCardData> AttrSelectLayout;

		// Token: 0x040187DB RID: 100315
		private bool RequestPending;

		// Token: 0x0200A3A4 RID: 41892
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x04032B98 RID: 207768
			public const int CommonPopupPanel = 0;

			// Token: 0x04032B99 RID: 207769
			public const int TextChangeNum = 1;

			// Token: 0x04032B9A RID: 207770
			public const int HorizontalLayoutAttr = 2;

			// Token: 0x04032B9B RID: 207771
			public const int CardItem = 3;

			// Token: 0x04032B9C RID: 207772
			public const int BtnRefresh = 4;

			// Token: 0x04032B9D RID: 207773
			public const int TextNum = 5;

			// Token: 0x04032B9E RID: 207774
			public const int TextDiscountNum = 6;
		}
	}
}
