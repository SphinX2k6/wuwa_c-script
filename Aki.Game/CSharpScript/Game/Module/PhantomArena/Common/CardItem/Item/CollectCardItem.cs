using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020051D4 RID: 20948
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class CollectCardItem : CommonBaseCardItem<CollectGridCardData>
	{
		// Token: 0x060359DA RID: 219610 RVA: 0x00CB3E98 File Offset: 0x00CB2098
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

		// Token: 0x060359DB RID: 219611 RVA: 0x00CB3F34 File Offset: 0x00CB2134
		protected override void OnStart()
		{
			CollectGridCardData collectGridCardData = this.OpenParam as CollectGridCardData;
			if (collectGridCardData != null)
			{
				this.Refresh(collectGridCardData);
			}
		}

		// Token: 0x060359DC RID: 219612 RVA: 0x00CB3F58 File Offset: 0x00CB2158
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

		// Token: 0x060359DD RID: 219613 RVA: 0x00CB4079 File Offset: 0x00CB2279
		private bool CanToggleChange()
		{
			return false;
		}

		// Token: 0x060359DE RID: 219614 RVA: 0x00CB407C File Offset: 0x00CB227C
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

		// Token: 0x0401C74D RID: 116557
		private CollectGridCardData Data;

		// Token: 0x0401C74E RID: 116558
		public Action<int> CallbackOnClick;

		// Token: 0x0401C74F RID: 116559
		public bool IsNewPhantomArenaActivity;
	}
}
