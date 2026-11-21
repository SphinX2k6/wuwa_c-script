using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020041A6 RID: 16806
	public class CommonCardItem : CommonBaseCardItem<int>
	{
		// Token: 0x0602A8E0 RID: 174304 RVA: 0x00C0176C File Offset: 0x00BFF96C
		protected override void OnRegisterCardComponent()
		{
			if (PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				this.ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>
				{
					new TCardComponentsRegisterInfoByItem(ECardItemComponent.CommonBaseCardComponent, base.GetRootItem())
				};
			}
			else
			{
				this.ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>
				{
					new TCardComponentsRegisterInfoByItem(ECardItemComponent.NewCommonBaseCardComponent, base.GetRootItem())
				};
			}
			this.ComponentsRegisterInfoByResourceId = new List<TCardComponentsRegisterInfoByResourceId>
			{
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardSpineComponent, "UiItem_SoundRemnantItem512Spine", base.GetSpineRootItem())
			};
		}

		// Token: 0x0602A8E1 RID: 174305 RVA: 0x00C017E4 File Offset: 0x00BFF9E4
		public override void Refresh(int cardId)
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardId);
			Dictionary<int, int> dictionary = phantomBattleCardConfig.InitAttack();
			CardSpineData cardSpineData = PhantomArenaModel.Instance.CreateCardSpineData(cardId);
			ECardFaceType cardFaceType = PhantomArenaModel.Instance.GetCardFaceType(cardId);
			CommonBaseCardComponentData data = new CommonBaseCardComponentData
			{
				CardId = cardId,
				Cost = phantomBattleCardConfig.Cost,
				Attack = (dictionary.ContainsKey(0) ? dictionary[0] : 0),
				Life = (dictionary.ContainsKey(1) ? dictionary[1] : 0),
				Element = phantomBattleCardConfig.Element,
				CardFaceTexturePath = phantomBattleCardConfig.CardFaceTexture,
				ShowCardFaceTexture = (cardFaceType == ECardFaceType.Texture),
				OutlookUnlocked = PhantomArenaModel.Instance.IsCardOutlookUnlock(cardId)
			};
			ICommonBaseCardComponent commonBaseCardComponent = this.GetCommonBaseCardComponent();
			if (commonBaseCardComponent != null)
			{
				commonBaseCardComponent.Refresh(data);
			}
			CardSpineComponentData data2 = new CardSpineComponentData
			{
				CardSpineData = cardSpineData,
				ShowSpine = (cardFaceType == ECardFaceType.Spine)
			};
			CardSpineComponent component = base.GetComponent<CardSpineComponent>(ECardItemComponent.CardSpineComponent);
			if (component == null)
			{
				return;
			}
			component.Refresh(data2);
		}

		// Token: 0x0602A8E2 RID: 174306 RVA: 0x00C018DE File Offset: 0x00BFFADE
		[NullableContext(1)]
		private ICommonBaseCardComponent GetCommonBaseCardComponent()
		{
			if (PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return base.GetComponent<CommonBaseCardComponent>(ECardItemComponent.CommonBaseCardComponent);
			}
			return base.GetComponent<NewCommonBaseCardComponent>(ECardItemComponent.NewCommonBaseCardComponent);
		}
	}
}
