using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005777 RID: 22391
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttrSelectMainView : UiViewBase
	{
		// Token: 0x06038E12 RID: 232978 RVA: 0x00D83EAC File Offset: 0x00D820AC
		public KurotatoAttrSelectMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038E13 RID: 232979 RVA: 0x00D83EC0 File Offset: 0x00D820C0
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

		// Token: 0x06038E14 RID: 232980 RVA: 0x00D8400B File Offset: 0x00D8220B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.KurotatoOnUpgradeRewardDataChanged, new Action(this.OnUpgradeRewardChanged));
		}

		// Token: 0x06038E15 RID: 232981 RVA: 0x00D84029 File Offset: 0x00D82229
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.KurotatoOnUpgradeRewardDataChanged, new Action(this.OnUpgradeRewardChanged));
		}

		// Token: 0x06038E16 RID: 232982 RVA: 0x00D84048 File Offset: 0x00D82248
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoAttrSelectMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoAttrSelectMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E17 RID: 232983 RVA: 0x00D8408C File Offset: 0x00D8228C
		private UniTask CreatePopupPanel()
		{
			KurotatoAttrSelectMainView.<CreatePopupPanel>d__9 <CreatePopupPanel>d__;
			<CreatePopupPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreatePopupPanel>d__.<>4__this = this;
			<CreatePopupPanel>d__.<>1__state = -1;
			<CreatePopupPanel>d__.<>t__builder.Start<KurotatoAttrSelectMainView.<CreatePopupPanel>d__9>(ref <CreatePopupPanel>d__);
			return <CreatePopupPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06038E18 RID: 232984 RVA: 0x00D840CF File Offset: 0x00D822CF
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

		// Token: 0x06038E19 RID: 232985 RVA: 0x00D840F2 File Offset: 0x00D822F2
		protected override void OnStart()
		{
			this.RefreshAttrSelectLayout();
			this.RefreshBtnRefresh();
			this.RefreshChangeNum();
			this.CommonPopupPanel.SetTitleLocalText("Kurotato_LevelUp_Title");
		}

		// Token: 0x06038E1A RID: 232986 RVA: 0x00D84116 File Offset: 0x00D82316
		protected override void OnBeforeShow()
		{
			this.CommonPopupPanel.HideAttrChangeFx();
			this.OnUpgradeRewardChanged();
		}

		// Token: 0x06038E1B RID: 232987 RVA: 0x00D8412C File Offset: 0x00D8232C
		private void RefreshAttrSelectLayout()
		{
			KurotatoModel instance = KurotatoModel.Instance;
			KurotatoConfig kurotatoConfig = KurotatoConfig.Instance;
			int roleId = instance.GetRoleId();
			KurotatoCharacter? characterById = kurotatoConfig.GetCharacterById(roleId);
			List<string> roleTags = ((characterById != null) ? characterById.GetValueOrDefault().RecommendedTagsIter().ToList<string>() : null) ?? new List<string>();
			List<int> excludedItemIds = ((characterById != null) ? characterById.GetValueOrDefault().ExcludedRecommendItemIdsIter().ToList<int>() : null) ?? new List<int>();
			this.CommonPopupPanel.ClearAttrPreview();
			GenericLayout<KurotatoAttrSelectCard, IKurotatoAttrSelectCardData> attrSelectLayout = this.AttrSelectLayout;
			foreach (KurotatoAttrSelectCard kurotatoAttrSelectCard in (((attrSelectLayout != null) ? attrSelectLayout.GetLayoutItemList() : null) ?? new List<KurotatoAttrSelectCard>()))
			{
				kurotatoAttrSelectCard.ClearAttrPreviewSelection();
			}
			this.AttrSelectLayout.RefreshByData(instance.GetUpgradeRewardData().Select(delegate(KurotatoItemRewardPbData item)
			{
				KurotatoItem? kurotatoItem;
				List<string> itemTags = ((kurotatoConfig.GetItemConfigByItemId(item.ItemId) != null) ? kurotatoItem.GetValueOrDefault().TagsIter().ToList<string>() : null) ?? new List<string>();
				bool flag = excludedItemIds.Contains(item.ItemId);
				return new KurotatoAttrSelectCardData
				{
					ItemId = item.ItemId,
					SelectionId = item.SelectionId,
					IsRecommend = (!flag && roleTags.Any((string tag) => itemTags.Contains(tag))),
					SelectType = EKurotatoAttrSelectType.Upgrade
				};
			}).ToList<IKurotatoAttrSelectCardData>(), null, true);
		}

		// Token: 0x06038E1C RID: 232988 RVA: 0x00D84254 File Offset: 0x00D82454
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

		// Token: 0x06038E1D RID: 232989 RVA: 0x00D84278 File Offset: 0x00D82478
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

		// Token: 0x06038E1E RID: 232990 RVA: 0x00D842E8 File Offset: 0x00D824E8
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

		// Token: 0x06038E1F RID: 232991 RVA: 0x00D8433C File Offset: 0x00D8253C
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

		// Token: 0x06038E20 RID: 232992 RVA: 0x00D8438C File Offset: 0x00D8258C
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

		// Token: 0x06038E21 RID: 232993 RVA: 0x00D84408 File Offset: 0x00D82608
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

		// Token: 0x06038E22 RID: 232994 RVA: 0x00D84460 File Offset: 0x00D82660
		private UniTask RequestRefreshAsync()
		{
			KurotatoAttrSelectMainView.<RequestRefreshAsync>d__20 <RequestRefreshAsync>d__;
			<RequestRefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRefreshAsync>d__.<>4__this = this;
			<RequestRefreshAsync>d__.<>1__state = -1;
			<RequestRefreshAsync>d__.<>t__builder.Start<KurotatoAttrSelectMainView.<RequestRefreshAsync>d__20>(ref <RequestRefreshAsync>d__);
			return <RequestRefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E23 RID: 232995 RVA: 0x00D844A3 File Offset: 0x00D826A3
		private void OnClickSelectFunction(int selectionId)
		{
			this.OnClickSelectFunctionImpAsync(selectionId).Forget();
		}

		// Token: 0x06038E24 RID: 232996 RVA: 0x00D844B4 File Offset: 0x00D826B4
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

		// Token: 0x06038E25 RID: 232997 RVA: 0x00D844FF File Offset: 0x00D826FF
		private void OnUpgradeRewardChanged()
		{
			this.RequestPending = false;
			this.RefreshAttrSelectLayout();
			this.RefreshBtnRefresh();
			this.RefreshChangeNum();
		}

		// Token: 0x06038E26 RID: 232998 RVA: 0x00D8451C File Offset: 0x00D8271C
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

		// Token: 0x0401DD43 RID: 122179
		private readonly KurotatoCommonPopupPanel CommonPopupPanel = new KurotatoCommonPopupPanel();

		// Token: 0x0401DD44 RID: 122180
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoAttrSelectCard, IKurotatoAttrSelectCardData> AttrSelectLayout;

		// Token: 0x0401DD45 RID: 122181
		private bool RequestPending;

		// Token: 0x0200B98A RID: 47498
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x0403819F RID: 229791
			public const int CommonPopupPanel = 0;

			// Token: 0x040381A0 RID: 229792
			public const int TextChangeNum = 1;

			// Token: 0x040381A1 RID: 229793
			public const int HorizontalLayoutAttr = 2;

			// Token: 0x040381A2 RID: 229794
			public const int CardItem = 3;

			// Token: 0x040381A3 RID: 229795
			public const int BtnRefresh = 4;

			// Token: 0x040381A4 RID: 229796
			public const int TextNum = 5;

			// Token: 0x040381A5 RID: 229797
			public const int TextDiscountNum = 6;
		}
	}
}
