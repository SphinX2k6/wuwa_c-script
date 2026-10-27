using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020051D2 RID: 20946
	public class CardOutlookPreviewItem : CommonBaseCardItem<int>
	{
		// Token: 0x060359D1 RID: 219601 RVA: 0x00CB3C48 File Offset: 0x00CB1E48
		protected override void OnRegisterCardComponent()
		{
			this.ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>
			{
				new TCardComponentsRegisterInfoByItem(ECardItemComponent.CommonBaseCardComponent, base.GetRootItem())
			};
			this.ComponentsRegisterInfoByResourceId = new List<TCardComponentsRegisterInfoByResourceId>
			{
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardSpineComponent, "UiItem_SoundRemnantItem512Spine", base.GetSpineRootItem())
			};
		}

		// Token: 0x060359D2 RID: 219602 RVA: 0x00CB3C98 File Offset: 0x00CB1E98
		public override void Refresh(int cardId)
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
			bool flag = !PhantomArenaModel.Instance.CheckCardSpineConfigValid(cardId);
			Dictionary<int, int> dictionary = phantomBattleCardConfig.InitAttack();
			CommonBaseCardComponentData commonBaseCardComponentData = new CommonBaseCardComponentData();
			commonBaseCardComponentData.CardId = cardId;
			commonBaseCardComponentData.Cost = phantomBattleCardConfig.Cost;
			commonBaseCardComponentData.Attack = (dictionary.ContainsKey(0) ? dictionary[0] : 0);
			commonBaseCardComponentData.Life = (dictionary.ContainsKey(1) ? dictionary[1] : 0);
			commonBaseCardComponentData.Element = phantomBattleCardConfig.Element;
			commonBaseCardComponentData.CardFaceTexturePath = phantomBattleCardConfig.CardFaceTexture;
			commonBaseCardComponentData.ShowCardFaceTexture = flag;
			commonBaseCardComponentData.OutlookUnlocked = true;
			commonBaseCardComponentData.CanToggleExecuteChange = (() => false);
			CommonBaseCardComponentData data = commonBaseCardComponentData;
			CommonBaseCardComponent component = base.GetComponent<CommonBaseCardComponent>(ECardItemComponent.CommonBaseCardComponent);
			if (component != null)
			{
				component.Refresh(data);
			}
			CardSpineComponentData data2 = new CardSpineComponentData
			{
				CardSpineData = PhantomArenaModel.Instance.CreateCardSpineData(cardId),
				ShowSpine = !flag
			};
			CardSpineComponent component2 = base.GetComponent<CardSpineComponent>(ECardItemComponent.CardSpineComponent);
			if (component2 == null)
			{
				return;
			}
			component2.Refresh(data2);
		}
	}
}
