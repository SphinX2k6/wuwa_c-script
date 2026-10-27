using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x020051CF RID: 20943
	public class CardItemCreatorFactory : IStaticVariableResetter
	{
		// Token: 0x060359BC RID: 219580 RVA: 0x00CB375F File Offset: 0x00CB195F
		static CardItemCreatorFactory()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CardItemCreatorFactory.CreateStaticDefaultValue), new Action(CardItemCreatorFactory.ResetStaticDefaultValue));
		}

		// Token: 0x060359BD RID: 219581 RVA: 0x00CB3780 File Offset: 0x00CB1980
		public static void CreateStaticDefaultValue()
		{
			CardItemCreatorFactory.FactoryMap = new CommonCreatorFactory<ICardComponentBase>();
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<CommonBaseCardComponent>(ECardItemComponent.CommonBaseCardComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<NewCommonBaseCardComponent>(ECardItemComponent.NewCommonBaseCardComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<CardLockComponent>(ECardItemComponent.CardLockComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<BattleCardComponent>(ECardItemComponent.BattleCardComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<NewBattleCardComponent>(ECardItemComponent.NewBattleCardComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<CardReplaceComponent>(ECardItemComponent.CardReplaceComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<CardCommonComponent>(ECardItemComponent.CardChooseComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<CardCheckComponent>(ECardItemComponent.CardCheckComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<CardCommonComponent>(ECardItemComponent.CardSelectedComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<CardSpineComponent>(ECardItemComponent.CardSpineComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<CardAllInDeckComponent>(ECardItemComponent.CardAllInDeckComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<CardDisabledComponent>(ECardItemComponent.CardDisabledComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<CardSkillComponent>(ECardItemComponent.CardSkillComponent);
			CardItemCreatorFactory.FactoryMap.RegisterWithKey<CardEffectCountComponent>(ECardItemComponent.CardEffectCountComponent);
		}

		// Token: 0x060359BE RID: 219582 RVA: 0x00CB387C File Offset: 0x00CB1A7C
		public static void ResetStaticDefaultValue()
		{
			CardItemCreatorFactory.FactoryMap = null;
		}

		// Token: 0x060359BF RID: 219583 RVA: 0x00CB3884 File Offset: 0x00CB1A84
		[NullableContext(1)]
		public static T GetComponent<[Nullable(0)] T>(ECardItemComponent name) where T : ICardComponentBase, new()
		{
			return CardItemCreatorFactory.FactoryMap.GetComponentWithKey<T>(name);
		}

		// Token: 0x0401C746 RID: 116550
		[Nullable(1)]
		private static CommonCreatorFactory<ICardComponentBase> FactoryMap;
	}
}
