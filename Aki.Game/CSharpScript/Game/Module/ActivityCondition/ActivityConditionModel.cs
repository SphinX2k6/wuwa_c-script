using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SolarSchool;

namespace CSharpScript.Game.Module.ActivityCondition
{
	// Token: 0x02005A84 RID: 23172
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ActivityConditionModel : ModelBase
	{
		// Token: 0x060391DE RID: 233950 RVA: 0x00FFFB1A File Offset: 0x00FFDD1A
		protected override bool OnInit()
		{
			ActivityConditionModel.RegisterFactories();
			return true;
		}

		// Token: 0x060391DF RID: 233951 RVA: 0x00FFFB22 File Offset: 0x00FFDD22
		protected override bool OnClear()
		{
			ActivityConditionCenter.Instance.ClearAll();
			return true;
		}

		// Token: 0x060391E0 RID: 233952 RVA: 0x00FFFB30 File Offset: 0x00FFDD30
		private static void RegisterFactories()
		{
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionSecondAttrValue, () => new SolarSchoolConditionSecondAttrValue());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionBehaviorCount, () => new SolarSchoolConditionBehaviorCount());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionRoleFavorLevel, () => new SolarSchoolConditionRoleFavorLevel());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionRoleFavorValueFull, () => new SolarSchoolConditionRoleFavorValueFull());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionExamScore, () => new SolarSchoolConditionExamScore());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionRoleUnlocked, () => new SolarSchoolConditionRoleUnlocked());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionDateInRange, () => new SolarSchoolConditionDateInRange());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionDateReached, () => new SolarSchoolConditionDateReached());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionSpecialState, () => new SolarSchoolConditionSpecialState());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionSpecialFinishedCount, () => new SolarSchoolConditionSpecialFinishedCount());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionHasItem, () => new SolarSchoolConditionHasItem());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionRoundCount, () => new SolarSchoolConditionRoundCount());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionLocationUnlocked, () => new SolarSchoolConditionLocationUnlocked());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionWeekday, () => new SolarSchoolConditionWeekday());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionAtLocation, () => new SolarSchoolConditionAtLocation());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionAvgParam, () => new SolarSchoolConditionAvgParam());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionTodayInstance, () => new SolarSchoolConditionTodayInstance());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionEndingSelected, () => new SolarSchoolConditionEndingSelected());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionTired, () => new SolarSchoolConditionTired());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionTimeSlot, () => new SolarSchoolConditionTimeSlot());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionBehaviorUnlocked, () => new SolarSchoolConditionBehaviorUnlocked());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionInfluenceLevel, () => new SolarSchoolConditionInfluenceLevel());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionAttrCount, () => new SolarSchoolConditionAttrCount());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionShopPurchaseCount, () => new SolarSchoolConditionShopPurchaseCount());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionGiftCount, () => new SolarSchoolConditionGiftCount());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionQuestRewardClaimed, () => new SolarSchoolConditionQuestRewardClaimed());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionQuestNodeState, () => new SolarSchoolConditionQuestNodeState());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionItemCountRange, () => new SolarSchoolConditionItemCountRange());
			ActivityConditionModel.RegisterFactory(EActivityConditionType.SolarSchoolConditionEndingUnlocked, () => new SolarSchoolConditionEndingUnlocked());
		}

		// Token: 0x060391E1 RID: 233953 RVA: 0x00FFFF83 File Offset: 0x00FFE183
		private static void RegisterFactory(EActivityConditionType type, Func<ActivityConditionBase> factory)
		{
			ActivityConditionCenter.Instance.RegisterFactory(type, factory);
		}

		// Token: 0x17006CCA RID: 27850
		// (get) Token: 0x060391E2 RID: 233954 RVA: 0x00FFFF91 File Offset: 0x00FFE191
		public static ActivityConditionModel Instance
		{
			get
			{
				return ActivityConditionModel._Instance;
			}
		}

		// Token: 0x060391E3 RID: 233955 RVA: 0x00FFFF98 File Offset: 0x00FFE198
		public static ActivityConditionModel GetOrCreateInstance()
		{
			if (ActivityConditionModel._Instance == null)
			{
				ActivityConditionModel.CreateInstance();
			}
			return ActivityConditionModel._Instance;
		}

		// Token: 0x060391E4 RID: 233956 RVA: 0x00FFFFAC File Offset: 0x00FFE1AC
		public static bool CreateInstance()
		{
			if (ActivityConditionModel._Instance != null)
			{
				return true;
			}
			ActivityConditionModel._Instance = new ActivityConditionModel();
			return true;
		}

		// Token: 0x060391E5 RID: 233957 RVA: 0x00FFFFC2 File Offset: 0x00FFE1C2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060391E6 RID: 233958 RVA: 0x00FFFFC4 File Offset: 0x00FFE1C4
		public static void ResetStaticDefaultValue()
		{
			ActivityConditionModel._Instance = null;
		}

		// Token: 0x060391E7 RID: 233959 RVA: 0x00FFFFCC File Offset: 0x00FFE1CC
		static ActivityConditionModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityConditionModel.CreateStaticDefaultValue), new Action(ActivityConditionModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E0EA RID: 123114
		[Nullable(2)]
		private static ActivityConditionModel _Instance;
	}
}
