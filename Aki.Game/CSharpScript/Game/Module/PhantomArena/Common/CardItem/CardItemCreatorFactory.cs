using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x0200419F RID: 16799
	public class CardItemCreatorFactory : IStaticVariableResetter
	{
		// Token: 0x0602A8B7 RID: 174263 RVA: 0x00C00D9B File Offset: 0x00BFEF9B
		static CardItemCreatorFactory()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CardItemCreatorFactory.CreateStaticDefaultValue), new Action(CardItemCreatorFactory.ResetStaticDefaultValue));
		}

		// Token: 0x0602A8B8 RID: 174264 RVA: 0x00C00DBC File Offset: 0x00BFEFBC
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

		// Token: 0x0602A8B9 RID: 174265 RVA: 0x00C00EB8 File Offset: 0x00BFF0B8
		public static void ResetStaticDefaultValue()
		{
			CardItemCreatorFactory.FactoryMap = null;
		}

		// Token: 0x0602A8BA RID: 174266 RVA: 0x00C00EC0 File Offset: 0x00BFF0C0
		[NullableContext(1)]
		public static T GetComponent<[Nullable(0)] T>(ECardItemComponent name) where T : ICardComponentBase, new()
		{
			return CardItemCreatorFactory.FactoryMap.GetComponentWithKey<T>(name);
		}

		// Token: 0x0401717B RID: 94587
		[Nullable(1)]
		private static CommonCreatorFactory<ICardComponentBase> FactoryMap;
	}
}
