using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020041A4 RID: 16804
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class CollectCardItem : CommonBaseCardItem<CollectGridCardData>
	{
		// Token: 0x0602A8D5 RID: 174293 RVA: 0x00C014D4 File Offset: 0x00BFF6D4
		protected override void OnRegisterCardComponent()
		{
			string resourceId = this.IsNewPhantomArenaActivity ? "UiItem_CardLock256New" : "UiItem_CardLockSmall";
			if (this.IsNewPhantomArenaActivity)
			{
				this.ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>
				{
					new TCardComponentsRegisterInfoByItem(ECardItemComponent.NewCommonBaseCardComponent, base.GetCardRootItem())
				};
			}
			else
			{
				this.ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>
				{
					new TCardComponentsRegisterInfoByItem(ECardItemComponent.CommonBaseCardComponent, base.GetCardRootItem())
				};
			}
			this.ComponentsRegisterInfoByResourceId = new List<TCardComponentsRegisterInfoByResourceId>
			{
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardLockComponent, resourceId, base.GetContentRootItem()),
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardSpineComponent, "UiItem_SoundRemnantItemSpine", base.GetSpineRootItem())
			};
		}

		// Token: 0x0602A8D6 RID: 174294 RVA: 0x00C01570 File Offset: 0x00BFF770
		protected override void OnStart()
		{
			CollectGridCardData collectGridCardData = this.OpenParam as CollectGridCardData;
			if (collectGridCardData != null)
			{
				this.Refresh(collectGridCardData);
			}
		}

		// Token: 0x0602A8D7 RID: 174295 RVA: 0x00C01594 File Offset: 0x00BFF794
		public override void Refresh(CollectGridCardData data)
		{
			this.Data = data;
			ICommonBaseCardComponent commonBaseCardComponent;
			if (!this.IsNewPhantomArenaActivity)
			{
				ICommonBaseCardComponent component = base.GetComponent<CommonBaseCardComponent>(ECardItemComponent.CommonBaseCardComponent);
				commonBaseCardComponent = component;
			}
			else
			{
				ICommonBaseCardComponent component = base.GetComponent<NewCommonBaseCardComponent>(ECardItemComponent.NewCommonBaseCardComponent);
				commonBaseCardComponent = component;
			}
			ICommonBaseCardComponent commonBaseCardComponent2 = commonBaseCardComponent;
			if (commonBaseCardComponent2 != null)
			{
				CommonBaseCardComponentData data2 = new CommonBaseCardComponentData
				{
					CardId = data.CardId,
					Attack = data.Attack,
					Life = data.Life,
					Element = data.Element,
					Cost = data.Cost,
					CanToggleExecuteChange = new Func<bool>(this.CanToggleChange),
					OnPointerUp = new Action(this.OnClickCard),
					OutlookUnlocked = PhantomArenaModel.Instance.IsCardOutlookUnlock(data.CardId),
					CardFaceTexturePath = data.CardFaceTexturePath,
					ShowCardFaceTexture = (data.CardFaceType == ECardFaceType.Texture)
				};
				commonBaseCardComponent2.Refresh(data2);
			}
			CardLockComponent component2 = base.GetComponent<CardLockComponent>(ECardItemComponent.CardLockComponent);
			if (component2 != null)
			{
				component2.Refresh(data.IsLocked);
			}
			CardSpineComponentData data3 = new CardSpineComponentData
			{
				CardSpineData = data.CardSpineData,
				ShowSpine = (data.CardFaceType == ECardFaceType.Spine)
			};
			CardSpineComponent component3 = base.GetComponent<CardSpineComponent>(ECardItemComponent.CardSpineComponent);
			if (component3 == null)
			{
				return;
			}
			component3.Refresh(data3);
		}

		// Token: 0x0602A8D8 RID: 174296 RVA: 0x00C016B5 File Offset: 0x00BFF8B5
		private bool CanToggleChange()
		{
			return false;
		}

		// Token: 0x0602A8D9 RID: 174297 RVA: 0x00C016B8 File Offset: 0x00BFF8B8
		private void OnClickCard()
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.CallbackOnClick != null)
			{
				this.CallbackOnClick(this.Data.CardId);
			}
		}

		// Token: 0x04017182 RID: 94594
		private CollectGridCardData Data;

		// Token: 0x04017183 RID: 94595
		public Action<int> CallbackOnClick;

		// Token: 0x04017184 RID: 94596
		public bool IsNewPhantomArenaActivity;
	}
}
