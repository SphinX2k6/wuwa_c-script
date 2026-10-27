using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020051D9 RID: 20953
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderCardItem : CommonGridCardItem<DeckBuilderCardItemData>
	{
		// Token: 0x060359F8 RID: 219640 RVA: 0x00CB4328 File Offset: 0x00CB2528
		protected override void OnRegisterCardComponent()
		{
			if (this.IsNewPhantomArenaActivity)
			{
				this.ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>
				{
					new TCardComponentsRegisterInfoByItem(ECardItemComponent.NewCommonBaseCardComponent, base.GetRootItem())
				};
			}
			else
			{
				this.ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>
				{
					new TCardComponentsRegisterInfoByItem(ECardItemComponent.CommonBaseCardComponent, base.GetRootItem())
				};
			}
			string resourceId = this.IsNewPhantomArenaActivity ? "UiItem_CardLockNew" : "UiItem_CardLock";
			string resourceId2 = this.IsNewPhantomArenaActivity ? "UiItem_CardDisableNew" : "UiItem_CardDisable";
			string resourceId3 = this.IsNewPhantomArenaActivity ? "UiItem_CardUseNew" : "UiItem_CardUse";
			string resourceId4 = this.IsNewPhantomArenaActivity ? "NewUiItem_CardCheck" : "UiItem_CardCheck";
			this.ComponentsRegisterInfoByResourceId = new List<TCardComponentsRegisterInfoByResourceId>
			{
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardLockComponent, resourceId, base.GetContentRootItem()),
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardAllInDeckComponent, resourceId3, base.GetContentRootItem()),
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardDisabledComponent, resourceId2, base.GetContentRootItem()),
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardCheckComponent, resourceId4, base.GetContentRootItem()),
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardSpineComponent, "UiItem_SoundRemnantItem512Spine", base.GetSpineRootItem())
			};
		}

		// Token: 0x060359F9 RID: 219641 RVA: 0x00CB443E File Offset: 0x00CB263E
		protected override void OnStart()
		{
			base.GetComponent<CardCheckComponent>(ECardItemComponent.CardCheckComponent).SetActive(true);
		}

		// Token: 0x060359FA RID: 219642 RVA: 0x00CB4450 File Offset: 0x00CB2650
		public override void Refresh(DeckBuilderCardItemData data)
		{
			DeckBuilderCardItem.<>c__DisplayClass6_0 CS$<>8__locals1 = new DeckBuilderCardItem.<>c__DisplayClass6_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			UiAsyncTask task = new UiAsyncTask("DeckBuilderCardItem", delegate()
			{
				DeckBuilderCardItem.<>c__DisplayClass6_0.<<Refresh>b__0>d <<Refresh>b__0>d;
				<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
				<<Refresh>b__0>d.<>1__state = -1;
				<<Refresh>b__0>d.<>t__builder.Start<DeckBuilderCardItem.<>c__DisplayClass6_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
				return <<Refresh>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x060359FB RID: 219643 RVA: 0x00CB4494 File Offset: 0x00CB2694
		public override UniTask RefreshAsync(DeckBuilderCardItemData data, bool isSelected, int gridIndex)
		{
			DeckBuilderCardItem.<RefreshAsync>d__7 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<DeckBuilderCardItem.<RefreshAsync>d__7>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060359FC RID: 219644 RVA: 0x00CB44E0 File Offset: 0x00CB26E0
		public void RefreshLeftCount()
		{
			CardCheckComponentData data = new CardCheckComponentData
			{
				LeftCount = this.Data.LeftCount,
				MaxCount = this.Data.MaxCount,
				OnCheckBtnClick = new Action(this.OpenCardInfoViewInternal)
			};
			base.GetComponent<CardCheckComponent>(ECardItemComponent.CardCheckComponent).Refresh(data);
		}

		// Token: 0x060359FD RID: 219645 RVA: 0x00CB4534 File Offset: 0x00CB2734
		public void RefreshAllInDeckComponent()
		{
			CardAllInDeckComponentData data = new CardAllInDeckComponentData
			{
				IsAllInDeck = this.Data.IsAllInDeck,
				ShowComponent = (this.Data.IsAllInDeck && !this.Data.IsLocked)
			};
			base.GetComponent<CardAllInDeckComponent>(ECardItemComponent.CardAllInDeckComponent).Refresh(data);
		}

		// Token: 0x060359FE RID: 219646 RVA: 0x00CB458C File Offset: 0x00CB278C
		public void RefreshDisabledComponent()
		{
			CardDisabledComponentData data = new CardDisabledComponentData
			{
				Disabled = this.Data.Disabled,
				ShowComponent = (this.Data.Disabled && !this.Data.IsLocked && !this.Data.IsAllInDeck)
			};
			base.GetComponent<CardDisabledComponent>(ECardItemComponent.CardDisabledComponent).Refresh(data);
		}

		// Token: 0x060359FF RID: 219647 RVA: 0x00CB45EF File Offset: 0x00CB27EF
		public void RefreshLockComponent()
		{
			base.GetComponent<CardLockComponent>(ECardItemComponent.CardLockComponent).Refresh(this.Data.IsLocked);
		}

		// Token: 0x06035A00 RID: 219648 RVA: 0x00CB4608 File Offset: 0x00CB2808
		public void RefreshOutlook()
		{
			ECardFaceType cardFaceType = PhantomArenaModel.Instance.GetCardFaceType(this.Data.CardId);
			this.Data.CardFaceType = cardFaceType;
			this.CommonBaseCardComponentData.ShowCardFaceTexture = (cardFaceType == ECardFaceType.Texture);
			this.CommonBaseCardComponentData.OutlookUnlocked = this.Data.OutlookUnlocked;
			CommonBaseCardComponent component = base.GetComponent<CommonBaseCardComponent>(ECardItemComponent.CommonBaseCardComponent);
			if (component != null)
			{
				component.RefreshOutlook();
			}
			this.SpineComponentData.ShowSpine = (cardFaceType == ECardFaceType.Spine);
			base.GetComponent<CardSpineComponent>(ECardItemComponent.CardSpineComponent).Refresh(this.SpineComponentData);
		}

		// Token: 0x06035A01 RID: 219649 RVA: 0x00CB4690 File Offset: 0x00CB2890
		private void OpenCardInfoViewInternal()
		{
			DeckBuilderCardItemData data = this.Data;
			if (data == null)
			{
				return;
			}
			Action<int> openCardInfoView = data.OpenCardInfoView;
			DeckBuilderCardItemData data2 = this.Data;
			openCardInfoView((data2 != null) ? data2.CardId : 0);
		}

		// Token: 0x06035A02 RID: 219650 RVA: 0x00CB46B9 File Offset: 0x00CB28B9
		protected void OnPointerUp()
		{
			DeckBuilderCardItemData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.AddCardToDeck(this.Data.CardId, 1);
		}

		// Token: 0x06035A03 RID: 219651 RVA: 0x00CB46DC File Offset: 0x00CB28DC
		private bool CanToggleChange()
		{
			return false;
		}

		// Token: 0x06035A04 RID: 219652 RVA: 0x00CB46DF File Offset: 0x00CB28DF
		public override object GetKey(DeckBuilderCardItemData data, int gridIndex)
		{
			return data.CardId;
		}

		// Token: 0x06035A05 RID: 219653 RVA: 0x00CB46EC File Offset: 0x00CB28EC
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "CardDetail")
			{
				CardCheckComponent component = base.GetComponent<CardCheckComponent>(ECardItemComponent.CardCheckComponent);
				return ((component != null) ? component.GetGuideUiItemAndUiItemForShowEx(configParams) : null) ?? Array.Empty<UUIItem>();
			}
			if (a == "New:CardDetail")
			{
				CardCheckComponent component2 = base.GetComponent<CardCheckComponent>(ECardItemComponent.CardCheckComponent);
				UUIItem uuiitem;
				if (component2 == null)
				{
					uuiitem = null;
				}
				else
				{
					UUIItem[] guideUiItemAndUiItemForShowEx = component2.GetGuideUiItemAndUiItemForShowEx(configParams);
					uuiitem = ((guideUiItemAndUiItemForShowEx != null) ? guideUiItemAndUiItemForShowEx[0] : null);
				}
				UUIItem uuiitem2 = uuiitem;
				UUIItem rootItem = base.GetRootItem();
				if (uuiitem2 != null && rootItem != null)
				{
					return new UUIItem[]
					{
						uuiitem2,
						rootItem
					};
				}
			}
			return null;
		}

		// Token: 0x0401C75A RID: 116570
		protected DeckBuilderCardItemData Data;

		// Token: 0x0401C75B RID: 116571
		protected ICommonBaseCardComponentData CommonBaseCardComponentData;

		// Token: 0x0401C75C RID: 116572
		protected ICardSpineComponentData SpineComponentData;

		// Token: 0x0401C75D RID: 116573
		public bool IsNewPhantomArenaActivity;
	}
}
