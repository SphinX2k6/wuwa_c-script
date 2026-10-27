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
	// Token: 0x02005720 RID: 22304
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoShopSelectCard : GridProxyAbstract<IKurotatoShopSelectCardData>
	{
		// Token: 0x06038B5D RID: 232285 RVA: 0x00D751E8 File Offset: 0x00D733E8
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

		// Token: 0x06038B5E RID: 232286 RVA: 0x00D75314 File Offset: 0x00D73514
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoShopSelectCard.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoShopSelectCard.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038B5F RID: 232287 RVA: 0x00D75357 File Offset: 0x00D73557
		public void SetConfirmCb(Action<int> cb)
		{
			this.ConfirmCb = cb;
		}

		// Token: 0x06038B60 RID: 232288 RVA: 0x00D75360 File Offset: 0x00D73560
		public void SetBuildTagClickCb(Action<int, EToggleState> cb)
		{
			this.BuildTagClickCb = cb;
		}

		// Token: 0x06038B61 RID: 232289 RVA: 0x00D75369 File Offset: 0x00D73569
		public void SetAttrPreviewCb(Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> cb)
		{
			this.AttrPreviewCb = cb;
		}

		// Token: 0x06038B62 RID: 232290 RVA: 0x00D75372 File Offset: 0x00D73572
		public void ClearAttrPreviewSelection()
		{
			this.CardInfoItem.ClearAttrPreviewSelection();
		}

		// Token: 0x06038B63 RID: 232291 RVA: 0x00D7537F File Offset: 0x00D7357F
		public override void Refresh(IKurotatoShopSelectCardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshCardInfo();
		}

		// Token: 0x06038B64 RID: 232292 RVA: 0x00D75390 File Offset: 0x00D73590
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

		// Token: 0x06038B65 RID: 232293 RVA: 0x00D753FD File Offset: 0x00D735FD
		public void SetComposeUpgradeVisible(bool visible)
		{
			this.CardInfoItem.SetComposeUpgradeVisible(visible);
		}

		// Token: 0x06038B66 RID: 232294 RVA: 0x00D7540B File Offset: 0x00D7360B
		public void RefreshBuildTagLevel()
		{
			this.CardInfoItem.RefreshBuildTagLevel();
		}

		// Token: 0x06038B67 RID: 232295 RVA: 0x00D75418 File Offset: 0x00D73618
		public void RefreshHoldNum()
		{
			this.CardInfoItem.RefreshHoldNum();
		}

		// Token: 0x06038B68 RID: 232296 RVA: 0x00D75428 File Offset: 0x00D73628
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

		// Token: 0x06038B69 RID: 232297 RVA: 0x00D755A8 File Offset: 0x00D737A8
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

		// Token: 0x06038B6A RID: 232298 RVA: 0x00D755E1 File Offset: 0x00D737E1
		private void OnToggleClickLock(int selectionId, bool isLock)
		{
			KurotatoController.Instance.RequestKurotatoShopRewardLock(selectionId).Forget<bool>();
		}

		// Token: 0x06038B6B RID: 232299 RVA: 0x00D755F3 File Offset: 0x00D737F3
		public void ClearBuildTagSelection()
		{
			this.CardInfoItem.ClearBuildTagSelection();
		}

		// Token: 0x06038B6C RID: 232300 RVA: 0x00D75600 File Offset: 0x00D73800
		public void CloseBuildInfo()
		{
			this.CardInfoItem.CloseBuildInfo();
		}

		// Token: 0x06038B6D RID: 232301 RVA: 0x00D7560D File Offset: 0x00D7380D
		public int GetSelectionId()
		{
			IKurotatoShopSelectCardData data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.SelectionId;
		}

		// Token: 0x06038B6E RID: 232302 RVA: 0x00D75620 File Offset: 0x00D73820
		private void OnClickBuildTag(EToggleState state)
		{
			Action<int, EToggleState> buildTagClickCb = this.BuildTagClickCb;
			if (buildTagClickCb == null)
			{
				return;
			}
			buildTagClickCb(this.Data.SelectionId, state);
		}

		// Token: 0x06038B6F RID: 232303 RVA: 0x00D7563E File Offset: 0x00D7383E
		private void OnAttrPreview(bool active, IReadOnlyList<IKurotatoAttrPreviewDelta> deltas)
		{
			Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(this.Data.SelectionId, active, deltas);
		}

		// Token: 0x06038B70 RID: 232304 RVA: 0x00D7565D File Offset: 0x00D7385D
		public bool IsRecommend()
		{
			IKurotatoShopSelectCardData data = this.Data;
			return data != null && data.IsRecommend;
		}

		// Token: 0x06038B71 RID: 232305 RVA: 0x00D75670 File Offset: 0x00D73870
		public bool HasBuildTag()
		{
			return this.CardInfoItem.HasBuildTag();
		}

		// Token: 0x06038B72 RID: 232306 RVA: 0x00D75680 File Offset: 0x00D73880
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

		// Token: 0x0401DC2A RID: 121898
		[Nullable(2)]
		private IKurotatoShopSelectCardData Data;

		// Token: 0x0401DC2B RID: 121899
		private readonly KurotatoCardInfoItem CardInfoItem = new KurotatoCardInfoItem();

		// Token: 0x0401DC2C RID: 121900
		[Nullable(2)]
		private Action<int> ConfirmCb;

		// Token: 0x0401DC2D RID: 121901
		[Nullable(2)]
		private Action<int, EToggleState> BuildTagClickCb;

		// Token: 0x0401DC2E RID: 121902
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<int, bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> AttrPreviewCb;

		// Token: 0x0200B8DB RID: 47323
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x04037EB2 RID: 229042
			public const int CardInfoItem = 0;

			// Token: 0x04037EB3 RID: 229043
			public const int ButtonConfirm = 1;

			// Token: 0x04037EB4 RID: 229044
			public const int TextureItemIcon = 2;

			// Token: 0x04037EB5 RID: 229045
			public const int TextNum = 3;

			// Token: 0x04037EB6 RID: 229046
			public const int PanelDone = 4;

			// Token: 0x04037EB7 RID: 229047
			public const int TextDiscount = 5;
		}
	}
}
