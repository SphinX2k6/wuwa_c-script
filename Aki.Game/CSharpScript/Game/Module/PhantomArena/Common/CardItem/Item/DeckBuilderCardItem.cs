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
	// Token: 0x020041A9 RID: 16809
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderCardItem : CommonGridCardItem<DeckBuilderCardItemData>
	{
		// Token: 0x0602A8F3 RID: 174323 RVA: 0x00C01964 File Offset: 0x00BFFB64
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

		// Token: 0x0602A8F4 RID: 174324 RVA: 0x00C01A7A File Offset: 0x00BFFC7A
		protected override void OnStart()
		{
			base.GetComponent<CardCheckComponent>(ECardItemComponent.CardCheckComponent).SetActive(true);
		}

		// Token: 0x0602A8F5 RID: 174325 RVA: 0x00C01A8C File Offset: 0x00BFFC8C
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

		// Token: 0x0602A8F6 RID: 174326 RVA: 0x00C01AD0 File Offset: 0x00BFFCD0
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

		// Token: 0x0602A8F7 RID: 174327 RVA: 0x00C01B1C File Offset: 0x00BFFD1C
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

		// Token: 0x0602A8F8 RID: 174328 RVA: 0x00C01B70 File Offset: 0x00BFFD70
		public void RefreshAllInDeckComponent()
		{
			CardAllInDeckComponentData data = new CardAllInDeckComponentData
			{
				IsAllInDeck = this.Data.IsAllInDeck,
				ShowComponent = (this.Data.IsAllInDeck && !this.Data.IsLocked)
			};
			base.GetComponent<CardAllInDeckComponent>(ECardItemComponent.CardAllInDeckComponent).Refresh(data);
		}

		// Token: 0x0602A8F9 RID: 174329 RVA: 0x00C01BC8 File Offset: 0x00BFFDC8
		public void RefreshDisabledComponent()
		{
			CardDisabledComponentData data = new CardDisabledComponentData
			{
				Disabled = this.Data.Disabled,
				ShowComponent = (this.Data.Disabled && !this.Data.IsLocked && !this.Data.IsAllInDeck)
			};
			base.GetComponent<CardDisabledComponent>(ECardItemComponent.CardDisabledComponent).Refresh(data);
		}

		// Token: 0x0602A8FA RID: 174330 RVA: 0x00C01C2B File Offset: 0x00BFFE2B
		public void RefreshLockComponent()
		{
			base.GetComponent<CardLockComponent>(ECardItemComponent.CardLockComponent).Refresh(this.Data.IsLocked);
		}

		// Token: 0x0602A8FB RID: 174331 RVA: 0x00C01C44 File Offset: 0x00BFFE44
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

		// Token: 0x0602A8FC RID: 174332 RVA: 0x00C01CCC File Offset: 0x00BFFECC
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

		// Token: 0x0602A8FD RID: 174333 RVA: 0x00C01CF5 File Offset: 0x00BFFEF5
		protected void OnPointerUp()
		{
			DeckBuilderCardItemData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.AddCardToDeck(this.Data.CardId, 1);
		}

		// Token: 0x0602A8FE RID: 174334 RVA: 0x00C01D18 File Offset: 0x00BFFF18
		private bool CanToggleChange()
		{
			return false;
		}

		// Token: 0x0602A8FF RID: 174335 RVA: 0x00C01D1B File Offset: 0x00BFFF1B
		public override object GetKey(DeckBuilderCardItemData data, int gridIndex)
		{
			return data.CardId;
		}

		// Token: 0x0602A900 RID: 174336 RVA: 0x00C01D28 File Offset: 0x00BFFF28
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

		// Token: 0x0401718F RID: 94607
		protected DeckBuilderCardItemData Data;

		// Token: 0x04017190 RID: 94608
		protected ICommonBaseCardComponentData CommonBaseCardComponentData;

		// Token: 0x04017191 RID: 94609
		protected ICardSpineComponentData SpineComponentData;

		// Token: 0x04017192 RID: 94610
		public bool IsNewPhantomArenaActivity;
	}
}
