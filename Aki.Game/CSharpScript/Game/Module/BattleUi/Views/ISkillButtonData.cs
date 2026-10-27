using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CE9 RID: 23785
	[NullableContext(2)]
	public interface ISkillButtonData
	{
		// Token: 0x0603C2FF RID: 246527
		bool IsEnable();

		// Token: 0x0603C300 RID: 246528
		bool IsVisible();

		// Token: 0x0603C301 RID: 246529
		bool IsEnableInput();

		// Token: 0x0603C302 RID: 246530
		void RefreshIsEnable();

		// Token: 0x0603C303 RID: 246531
		ESkillButtonType GetButtonType();

		// Token: 0x17008E03 RID: 36355
		// (get) Token: 0x0603C304 RID: 246532
		bool IsExploreAsFight { get; }

		// Token: 0x0603C305 RID: 246533
		bool GetExploreSkillChange();

		// Token: 0x0603C306 RID: 246534
		void SetExploreSkillChange(bool isExploreSkillChange);

		// Token: 0x0603C307 RID: 246535
		bool HasConfigFollower();

		// Token: 0x0603C308 RID: 246536
		SkillButtonTypeFormationData GetFormationData();

		// Token: 0x0603C309 RID: 246537
		EInputAction GetActionType();

		// Token: 0x0603C30A RID: 246538
		[NullableContext(1)]
		string GetInputAction();

		// Token: 0x17008E04 RID: 36356
		// (get) Token: 0x0603C30B RID: 246539
		bool IsEnableSlideControl { get; }

		// Token: 0x0603C30C RID: 246540
		bool IsEnableLongPress();

		// Token: 0x0603C30D RID: 246541
		bool IsShowLongPress();

		// Token: 0x0603C30E RID: 246542
		bool GetIsLongPressing();

		// Token: 0x0603C30F RID: 246543
		bool GetIsConfigShowLongPress();

		// Token: 0x0603C310 RID: 246544
		bool? GetIsLongPressControlCamera();

		// Token: 0x0603C311 RID: 246545
		double GetLongPressTime();

		// Token: 0x0603C312 RID: 246546
		double GetLongPressDuration();

		// Token: 0x0603C313 RID: 246547
		void RefreshLongPressTime();

		// Token: 0x0603C314 RID: 246548
		void RefreshLongPressDuration();

		// Token: 0x17008E05 RID: 36357
		// (get) Token: 0x0603C315 RID: 246549
		int TotalCoolDownCustom { get; }

		// Token: 0x0603C316 RID: 246550
		float GetRemainingCoolDownCustom();

		// Token: 0x0603C317 RID: 246551
		float GetSkillRemainingCoolDown();

		// Token: 0x0603C318 RID: 246552
		bool HasCdComponent();

		// Token: 0x0603C319 RID: 246553
		bool IsCdVisible();

		// Token: 0x17008E06 RID: 36358
		// (get) Token: 0x0603C31A RID: 246554
		bool HideCoolDownTextCustom { get; }

		// Token: 0x0603C31B RID: 246555
		int GetSkillId();

		// Token: 0x0603C31C RID: 246556
		string GetSkillIconName();

		// Token: 0x0603C31D RID: 246557
		string GetActionName();

		// Token: 0x0603C31E RID: 246558
		string GetSkillTexturePath();

		// Token: 0x0603C31F RID: 246559
		bool IsSkillIdChangeByTag();

		// Token: 0x0603C320 RID: 246560
		bool? IsMultiStageSkill();

		// Token: 0x0603C321 RID: 246561
		string GetMultiSkillTexturePath();

		// Token: 0x0603C322 RID: 246562
		MultiSkillInfo GetMultiSkillInfo();

		// Token: 0x0603C323 RID: 246563
		GroupSkillCdInfo GetGroupSkillCdInfo();

		// Token: 0x0603C324 RID: 246564
		bool HasAttribute();

		// Token: 0x17008E07 RID: 36359
		// (get) Token: 0x0603C325 RID: 246565
		EAttributeType AttributeId { get; }

		// Token: 0x17008E08 RID: 36360
		// (get) Token: 0x0603C326 RID: 246566
		ESkillButtonAttributeUsageMode AttributeUsageMode { get; }

		// Token: 0x17008E09 RID: 36361
		// (get) Token: 0x0603C327 RID: 246567
		int[] AttributeUsageParams { get; }

		// Token: 0x0603C328 RID: 246568
		float GetAttribute();

		// Token: 0x0603C329 RID: 246569
		float GetMaxAttribute();

		// Token: 0x0603C32A RID: 246570
		string GetMaxAttributeEffectPath();

		// Token: 0x0603C32B RID: 246571
		FLinearColor? GetMaxAttributeColor();

		// Token: 0x0603C32C RID: 246572
		int GetMaxAttributeBurstEffectId();

		// Token: 0x0603C32D RID: 246573
		SkillButtonEffect? GetMaxAttributeBurstEffectConfig();

		// Token: 0x17008E0A RID: 36362
		// (get) Token: 0x0603C32E RID: 246574
		bool IsLimitCountCustom { get; }

		// Token: 0x17008E0B RID: 36363
		// (get) Token: 0x0603C32F RID: 246575
		int RemainingCountCustom { get; }

		// Token: 0x17008E0C RID: 36364
		// (get) Token: 0x0603C330 RID: 246576
		bool IsLimitCountVehicleSkill { get; }

		// Token: 0x17008E0D RID: 36365
		// (get) Token: 0x0603C331 RID: 246577
		int RemainingCountVehicleSkill { get; }

		// Token: 0x0603C332 RID: 246578
		bool IsVehicleSkillInCd();

		// Token: 0x0603C333 RID: 246579
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"remainTime",
			"totalTime"
		})]
		ValueTuple<double, double> GetVehicleSkillCd();

		// Token: 0x0603C334 RID: 246580
		void InitVehicleHandle();

		// Token: 0x0603C335 RID: 246581
		bool IsSkillInItemUseBuffCd();

		// Token: 0x0603C336 RID: 246582
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"remainTime",
			"totalTime"
		})]
		ValueTuple<double, double> GetEquippedItemUsingBuffCd();

		// Token: 0x0603C337 RID: 246583
		bool IsSkillInItemUseSkillCd();

		// Token: 0x0603C338 RID: 246584
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"remainTime",
			"totalTime"
		})]
		ValueTuple<double, double> GetEquippedItemUsingSkillCd();

		// Token: 0x0603C339 RID: 246585
		FColor? GetFrameSpriteColor();

		// Token: 0x0603C33A RID: 246586
		SkillButtonEffect? GetCdCompletedEffectConfig();

		// Token: 0x0603C33B RID: 246587
		SkillButtonEffect? GetDynamicEffectConfig();

		// Token: 0x0603C33C RID: 246588
		int GetCdCompletedEffectId();

		// Token: 0x0603C33D RID: 246589
		List<EInputAction> GetValidSharedHoldRingFxActions();

		// Token: 0x17008E0E RID: 36366
		// (get) Token: 0x0603C33E RID: 246590
		bool IsEnableDotIndicator { get; }

		// Token: 0x17008E0F RID: 36367
		// (get) Token: 0x0603C33F RID: 246591
		int DotIndicatorCount { get; }
	}
}
