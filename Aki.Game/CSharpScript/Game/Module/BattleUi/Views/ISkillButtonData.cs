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
	// Token: 0x02004CCB RID: 19659
	[NullableContext(2)]
	public interface ISkillButtonData
	{
		// Token: 0x06031255 RID: 201301
		bool IsEnable();

		// Token: 0x06031256 RID: 201302
		bool IsVisible();

		// Token: 0x06031257 RID: 201303
		bool IsEnableInput();

		// Token: 0x06031258 RID: 201304
		void RefreshIsEnable();

		// Token: 0x06031259 RID: 201305
		ESkillButtonType GetButtonType();

		// Token: 0x170061D5 RID: 25045
		// (get) Token: 0x0603125A RID: 201306
		bool IsExploreAsFight { get; }

		// Token: 0x0603125B RID: 201307
		bool GetExploreSkillChange();

		// Token: 0x0603125C RID: 201308
		void SetExploreSkillChange(bool isExploreSkillChange);

		// Token: 0x0603125D RID: 201309
		bool HasConfigFollower();

		// Token: 0x0603125E RID: 201310
		SkillButtonTypeFormationData GetFormationData();

		// Token: 0x0603125F RID: 201311
		EInputAction GetActionType();

		// Token: 0x06031260 RID: 201312
		[NullableContext(1)]
		string GetInputAction();

		// Token: 0x170061D6 RID: 25046
		// (get) Token: 0x06031261 RID: 201313
		bool IsEnableSlideControl { get; }

		// Token: 0x06031262 RID: 201314
		bool IsEnableLongPress();

		// Token: 0x06031263 RID: 201315
		bool IsShowLongPress();

		// Token: 0x06031264 RID: 201316
		bool GetIsLongPressing();

		// Token: 0x06031265 RID: 201317
		bool GetIsConfigShowLongPress();

		// Token: 0x06031266 RID: 201318
		bool? GetIsLongPressControlCamera();

		// Token: 0x06031267 RID: 201319
		double GetLongPressTime();

		// Token: 0x06031268 RID: 201320
		double GetLongPressDuration();

		// Token: 0x06031269 RID: 201321
		void RefreshLongPressTime();

		// Token: 0x0603126A RID: 201322
		void RefreshLongPressDuration();

		// Token: 0x170061D7 RID: 25047
		// (get) Token: 0x0603126B RID: 201323
		int TotalCoolDownCustom { get; }

		// Token: 0x0603126C RID: 201324
		float GetRemainingCoolDownCustom();

		// Token: 0x0603126D RID: 201325
		float GetSkillRemainingCoolDown();

		// Token: 0x0603126E RID: 201326
		bool HasCdComponent();

		// Token: 0x0603126F RID: 201327
		bool IsCdVisible();

		// Token: 0x170061D8 RID: 25048
		// (get) Token: 0x06031270 RID: 201328
		bool HideCoolDownTextCustom { get; }

		// Token: 0x06031271 RID: 201329
		int GetSkillId();

		// Token: 0x06031272 RID: 201330
		string GetSkillIconName();

		// Token: 0x06031273 RID: 201331
		string GetActionName();

		// Token: 0x06031274 RID: 201332
		string GetSkillTexturePath();

		// Token: 0x06031275 RID: 201333
		bool IsSkillIdChangeByTag();

		// Token: 0x06031276 RID: 201334
		bool? IsMultiStageSkill();

		// Token: 0x06031277 RID: 201335
		string GetMultiSkillTexturePath();

		// Token: 0x06031278 RID: 201336
		MultiSkillInfo GetMultiSkillInfo();

		// Token: 0x06031279 RID: 201337
		GroupSkillCdInfo GetGroupSkillCdInfo();

		// Token: 0x0603127A RID: 201338
		bool HasAttribute();

		// Token: 0x170061D9 RID: 25049
		// (get) Token: 0x0603127B RID: 201339
		EAttributeType AttributeId { get; }

		// Token: 0x170061DA RID: 25050
		// (get) Token: 0x0603127C RID: 201340
		ESkillButtonAttributeUsageMode AttributeUsageMode { get; }

		// Token: 0x170061DB RID: 25051
		// (get) Token: 0x0603127D RID: 201341
		int[] AttributeUsageParams { get; }

		// Token: 0x0603127E RID: 201342
		float GetAttribute();

		// Token: 0x0603127F RID: 201343
		float GetMaxAttribute();

		// Token: 0x06031280 RID: 201344
		string GetMaxAttributeEffectPath();

		// Token: 0x06031281 RID: 201345
		FLinearColor? GetMaxAttributeColor();

		// Token: 0x06031282 RID: 201346
		int GetMaxAttributeBurstEffectId();

		// Token: 0x06031283 RID: 201347
		SkillButtonEffect? GetMaxAttributeBurstEffectConfig();

		// Token: 0x170061DC RID: 25052
		// (get) Token: 0x06031284 RID: 201348
		bool IsLimitCountCustom { get; }

		// Token: 0x170061DD RID: 25053
		// (get) Token: 0x06031285 RID: 201349
		int RemainingCountCustom { get; }

		// Token: 0x170061DE RID: 25054
		// (get) Token: 0x06031286 RID: 201350
		bool IsLimitCountVehicleSkill { get; }

		// Token: 0x170061DF RID: 25055
		// (get) Token: 0x06031287 RID: 201351
		int RemainingCountVehicleSkill { get; }

		// Token: 0x06031288 RID: 201352
		bool IsVehicleSkillInCd();

		// Token: 0x06031289 RID: 201353
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"remainTime",
			"totalTime"
		})]
		ValueTuple<double, double> GetVehicleSkillCd();

		// Token: 0x0603128A RID: 201354
		void InitVehicleHandle();

		// Token: 0x0603128B RID: 201355
		bool IsSkillInItemUseBuffCd();

		// Token: 0x0603128C RID: 201356
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"remainTime",
			"totalTime"
		})]
		ValueTuple<double, double> GetEquippedItemUsingBuffCd();

		// Token: 0x0603128D RID: 201357
		bool IsSkillInItemUseSkillCd();

		// Token: 0x0603128E RID: 201358
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"remainTime",
			"totalTime"
		})]
		ValueTuple<double, double> GetEquippedItemUsingSkillCd();

		// Token: 0x0603128F RID: 201359
		FColor? GetFrameSpriteColor();

		// Token: 0x06031290 RID: 201360
		SkillButtonEffect? GetCdCompletedEffectConfig();

		// Token: 0x06031291 RID: 201361
		SkillButtonEffect? GetDynamicEffectConfig();

		// Token: 0x06031292 RID: 201362
		int GetCdCompletedEffectId();

		// Token: 0x06031293 RID: 201363
		List<EInputAction> GetValidSharedHoldRingFxActions();

		// Token: 0x170061E0 RID: 25056
		// (get) Token: 0x06031294 RID: 201364
		bool IsEnableDotIndicator { get; }

		// Token: 0x170061E1 RID: 25057
		// (get) Token: 0x06031295 RID: 201365
		int DotIndicatorCount { get; }
	}
}
