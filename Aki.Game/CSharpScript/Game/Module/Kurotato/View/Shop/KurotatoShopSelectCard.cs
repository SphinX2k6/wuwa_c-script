using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.View.AttrSelect;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Shop
{
	// Token: 0x020046F7 RID: 18167
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoShopSelectCard : GridProxyAbstract<IKurotatoShopSelectCardData>
	{
		// Token: 0x0602DA6C RID: 186988 RVA: 0x00CC381C File Offset: 0x00CC1A1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickConfirm));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DA6D RID: 186989 RVA: 0x00CC3948 File Offset: 0x00CC1B48
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoShopSelectCard.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoShopSelectCard.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DA6E RID: 186990 RVA: 0x00CC398B File Offset: 0x00CC1B8B
		public void SetConfirmCb(Action<int> cb)
		{
			this.ConfirmCb = cb;
		}

		// Token: 0x0602DA6F RID: 186991 RVA: 0x00CC3994 File Offset: 0x00CC1B94
		public void SetBuildTagClickCb(Action<int, EToggleState> cb)
		{
			this.BuildTagClickCb = cb;
		}

		// Token: 0x0602DA70 RID: 186992 RVA: 0x00CC399D File Offset: 0x00CC1B9D
		public void SetAttrPreviewCb(Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> cb)
		{
			this.AttrPreviewCb = cb;
		}

		// Token: 0x0602DA71 RID: 186993 RVA: 0x00CC39A6 File Offset: 0x00CC1BA6
		public void ClearAttrPreviewSelection()
		{
			this.CardInfoItem.ClearAttrPreviewSelection();
		}

		// Token: 0x0602DA72 RID: 186994 RVA: 0x00CC39B3 File Offset: 0x00CC1BB3
		public override void Refresh(IKurotatoShopSelectCardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshCardInfo();
		}

		// Token: 0x0602DA73 RID: 186995 RVA: 0x00CC39C4 File Offset: 0x00CC1BC4
		public void RefreshCurrencyState()
		{
			if (this.Data == null)
			{
				return;
			}
			int currencyCount = KurotatoModel.Instance.BattleData.GetCurrencyCount();
			base.GetButton(1).SetSelfInteractive(currencyCount >= this.Data.Cost);
			UUIText text = base.GetText(3);
			UUIItem uuiitem = text;
			bool bUseChangeColor = currencyCount < this.Data.Cost;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x0602DA74 RID: 186996 RVA: 0x00CC3A31 File Offset: 0x00CC1C31
		public void SetComposeUpgradeVisible(bool visible)
		{
			this.CardInfoItem.SetComposeUpgradeVisible(visible);
		}

		// Token: 0x0602DA75 RID: 186997 RVA: 0x00CC3A3F File Offset: 0x00CC1C3F
		public void RefreshBuildTagLevel()
		{
			this.CardInfoItem.RefreshBuildTagLevel();
		}

		// Token: 0x0602DA76 RID: 186998 RVA: 0x00CC3A4C File Offset: 0x00CC1C4C
		public void RefreshHoldNum()
		{
			this.CardInfoItem.RefreshHoldNum();
		}

		// Token: 0x0602DA77 RID: 186999 RVA: 0x00CC3A5C File Offset: 0x00CC1C5C
		private void RefreshCardInfo()
		{
			this.CardInfoItem.Refresh(new KurotatoCardItemData
			{
				Id = this.Data.Id,
				SelectionId = this.Data.SelectionId,
				HasBuy = this.Data.HasBuy,
				IsRecommend = this.Data.IsRecommend,
				CardType = this.Data.CardType,
				HasLock = this.Data.IsLock,
				ShowLock = true,
				Cost = this.Data.Cost
			});
			this.CardInfoItem.SetLockToggleCb(new Action<int, bool>(this.OnToggleClickLock));
			this.CardInfoItem.SetBuildTagClickCb(new Action<EToggleState>(this.OnClickBuildTag));
			this.CardInfoItem.SetAttrPreviewCb(new Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>>(this.OnAttrPreview));
			base.GetText(3).SetText(this.Data.Cost.ToString(), true);
			base.GetItem(4).SetUIActive(this.Data.HasBuy);
			base.GetButton(1).GetRootComponent().SetUIActive(!this.Data.HasBuy);
			base.GetText(5).SetText(this.Data.OriginalCost.ToString(), true);
			base.GetText(5).SetUIActive(this.Data.OriginalCost > this.Data.Cost);
			this.RefreshCurrencyState();
		}

		// Token: 0x0602DA78 RID: 187000 RVA: 0x00CC3BDC File Offset: 0x00CC1DDC
		private void OnClickConfirm()
		{
			if (KurotatoModel.Instance.BattleData.GetCurrencyCount() >= this.Data.Cost)
			{
				Action<int> confirmCb = this.ConfirmCb;
				if (confirmCb == null)
				{
					return;
				}
				confirmCb(this.Data.SelectionId);
			}
		}

		// Token: 0x0602DA79 RID: 187001 RVA: 0x00CC3C15 File Offset: 0x00CC1E15
		private void OnToggleClickLock(int selectionId, bool isLock)
		{
			KurotatoController.Instance.RequestKurotatoShopRewardLock(selectionId).Forget<bool>();
		}

		// Token: 0x0602DA7A RID: 187002 RVA: 0x00CC3C27 File Offset: 0x00CC1E27
		public void ClearBuildTagSelection()
		{
			this.CardInfoItem.ClearBuildTagSelection();
		}

		// Token: 0x0602DA7B RID: 187003 RVA: 0x00CC3C34 File Offset: 0x00CC1E34
		public void CloseBuildInfo()
		{
			this.CardInfoItem.CloseBuildInfo();
		}

		// Token: 0x0602DA7C RID: 187004 RVA: 0x00CC3C41 File Offset: 0x00CC1E41
		public int GetSelectionId()
		{
			IKurotatoShopSelectCardData data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.SelectionId;
		}

		// Token: 0x0602DA7D RID: 187005 RVA: 0x00CC3C54 File Offset: 0x00CC1E54
		private void OnClickBuildTag(EToggleState state)
		{
			Action<int, EToggleState> buildTagClickCb = this.BuildTagClickCb;
			if (buildTagClickCb == null)
			{
				return;
			}
			buildTagClickCb(this.Data.SelectionId, state);
		}

		// Token: 0x0602DA7E RID: 187006 RVA: 0x00CC3C72 File Offset: 0x00CC1E72
		private void OnAttrPreview(bool active, IReadOnlyList<IKurotatoAttrPreviewDelta> deltas)
		{
			Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(this.Data.SelectionId, active, deltas);
		}

		// Token: 0x0602DA7F RID: 187007 RVA: 0x00CC3C91 File Offset: 0x00CC1E91
		public bool IsRecommend()
		{
			IKurotatoShopSelectCardData data = this.Data;
			return data != null && data.IsRecommend;
		}

		// Token: 0x0602DA80 RID: 187008 RVA: 0x00CC3CA4 File Offset: 0x00CC1EA4
		public bool HasBuildTag()
		{
			return this.CardInfoItem.HasBuildTag();
		}

		// Token: 0x0602DA81 RID: 187009 RVA: 0x00CC3CB4 File Offset: 0x00CC1EB4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "ShopCard")
			{
				UUIItem rootItem = base.GetRootItem();
				if (rootItem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					rootItem,
					rootItem
				};
			}
			else
			{
				if (a == "ShopRecommend" || a == "ShopCardLock" || a == "ShopBuildTag" || a == "ShopCardDes")
				{
					return this.CardInfoItem.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
				return null;
			}
		}

		// Token: 0x040186C0 RID: 100032
		[Nullable(2)]
		private IKurotatoShopSelectCardData Data;

		// Token: 0x040186C1 RID: 100033
		private readonly KurotatoCardInfoItem CardInfoItem = new KurotatoCardInfoItem();

		// Token: 0x040186C2 RID: 100034
		[Nullable(2)]
		private Action<int> ConfirmCb;

		// Token: 0x040186C3 RID: 100035
		[Nullable(2)]
		private Action<int, EToggleState> BuildTagClickCb;

		// Token: 0x040186C4 RID: 100036
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> AttrPreviewCb;

		// Token: 0x0200A2FD RID: 41725
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x040328C4 RID: 207044
			public const int CardInfoItem = 0;

			// Token: 0x040328C5 RID: 207045
			public const int ButtonConfirm = 1;

			// Token: 0x040328C6 RID: 207046
			public const int TextureItemIcon = 2;

			// Token: 0x040328C7 RID: 207047
			public const int TextNum = 3;

			// Token: 0x040328C8 RID: 207048
			public const int PanelDone = 4;

			// Token: 0x040328C9 RID: 207049
			public const int TextDiscount = 5;
		}
	}
}
