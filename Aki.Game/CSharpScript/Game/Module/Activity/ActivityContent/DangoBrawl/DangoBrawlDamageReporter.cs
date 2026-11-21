using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056AA RID: 22186
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlDamageReporter
	{
		// Token: 0x06036CC7 RID: 224455 RVA: 0x00F4AB0F File Offset: 0x00F48D0F
		public DangoBrawlBattleLogAggregator GetLog()
		{
			return this.LogAgg;
		}

		// Token: 0x06036CC8 RID: 224456 RVA: 0x00F4AB18 File Offset: 0x00F48D18
		public void Report(DangoBrawlDamageEvent evt)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			int fighterUid = DangoBrawlDamageReporter.IsHealForLog(evt.Source) ? evt.TargetFighterUid : evt.SourceFighterUid;
			bool flag = battleManager != null && battleManager.GetIsSelfByFighterUid(fighterUid);
			if (DangoBrawlDamageReporter.IsDamageForLog(evt.Source))
			{
				this.LogAgg.AddDamage(evt, flag);
				EventSystem.Instance.Emit<bool, bool>(EEventName.OnDangoBrawlBattleLogChanged, flag, false);
			}
			else if (DangoBrawlDamageReporter.IsHealForLog(evt.Source))
			{
				this.LogAgg.AddHeal(evt, flag);
				EventSystem.Instance.Emit<bool, bool>(EEventName.OnDangoBrawlBattleLogChanged, flag, true);
			}
			else
			{
				EDangoBrawlDamageSource source = evt.Source;
			}
			this.DispatchDamageText(evt);
			if (DangoBrawlDamageReporter.IsHitFlashSource(evt.Source) && battleManager != null)
			{
				battleManager.PlayHitFlash(evt.TargetFighterUid);
			}
		}

		// Token: 0x06036CC9 RID: 224457 RVA: 0x00F4ABE4 File Offset: 0x00F48DE4
		private static bool IsHitFlashSource(EDangoBrawlDamageSource src)
		{
			return src == EDangoBrawlDamageSource.Weapon;
		}

		// Token: 0x06036CCA RID: 224458 RVA: 0x00F4ABFC File Offset: 0x00F48DFC
		private unsafe void DispatchDamageText(DangoBrawlDamageEvent evt)
		{
			DangoBrawlDamageShow? dangoBrawlDamageShow = this.ResolveDamageShow(evt);
			if (dangoBrawlDamageShow == null)
			{
				return;
			}
			this.DispatchDamageDA(evt.TargetFighterUid, dangoBrawlDamageShow.Value);
			int sceneDamageConfig = dangoBrawlDamageShow.Value.SceneDamageConfig;
			int uidamageConfig = dangoBrawlDamageShow.Value.UIDamageConfig;
			if (sceneDamageConfig == 0 && uidamageConfig == 0)
			{
				return;
			}
			EDangoBrawlDamageSource source = evt.Source;
			bool flag = source - EDangoBrawlDamageSource.Heal <= 3;
			bool isCure = flag;
			if (sceneDamageConfig != 0)
			{
				DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
				if (battleManager != null)
				{
					battleManager.ShowSceneDamageText(sceneDamageConfig, evt.TargetFighterUid, evt.Value, evt.IsCrit, isCure);
				}
			}
			if (uidamageConfig != 0 && DangoBrawlDamageReporter.ShouldShowUiDamageText(evt.Source))
			{
				if (evt.SourceItemUid == 0)
				{
					if (DangoBrawlDamageReporter.ShouldWarnMissingItemUid(evt.Source))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.DangoBrawl;
						ELogAuthor author = ELogAuthor.WHJ;
						string message = "[DispatchDamageText] 配置了 UI 飘字(UIDamageConfig!=0) 但来源无道具 UID(SourceItemUid=0)";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("source", evt.Source);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uiDamageConfigId", uidamageConfig);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("targetFighterUid", evt.TargetFighterUid);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						return;
					}
				}
				else
				{
					EventSystem.Instance.Emit<DangoBrawlDamageEvent, int>(EEventName.OnDangoBrawlDamageUiText, evt, uidamageConfig);
				}
			}
		}

		// Token: 0x06036CCB RID: 224459 RVA: 0x00F4AD6C File Offset: 0x00F48F6C
		private static bool ShouldWarnMissingItemUid(EDangoBrawlDamageSource src)
		{
			switch (src)
			{
			case EDangoBrawlDamageSource.Fatigue:
				return false;
			case EDangoBrawlDamageSource.Reflect:
				return false;
			case EDangoBrawlDamageSource.Shield:
				return false;
			case EDangoBrawlDamageSource.BuffGain:
				return false;
			case EDangoBrawlDamageSource.Lifesteal:
				return false;
			}
			return true;
		}

		// Token: 0x06036CCC RID: 224460 RVA: 0x00F4ADB4 File Offset: 0x00F48FB4
		private static bool ShouldShowUiDamageText(EDangoBrawlDamageSource src)
		{
			return src != EDangoBrawlDamageSource.BuffTick;
		}

		// Token: 0x06036CCD RID: 224461 RVA: 0x00F4ADCC File Offset: 0x00F48FCC
		public unsafe void ReportEffectShow(int ownerFighterUid, int effectId)
		{
			if (effectId == 0)
			{
				return;
			}
			DangoBrawlEffect? effectConfigById = DangoBrawlConfig.Instance.GetEffectConfigById(effectId);
			if (effectConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[ReportEffectShow] Effect 配置查不到";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ownerFighterUid", ownerFighterUid);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("effectId", effectId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (effectConfigById.Value.ShowId == 0)
			{
				return;
			}
			DangoBrawlDamageShow? damageShowConfig = DangoBrawlConfig.Instance.GetDamageShowConfig(effectConfigById.Value.ShowId);
			if (damageShowConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.DangoBrawl;
				ELogAuthor author2 = ELogAuthor.WHJ;
				string message2 = "[ReportEffectShow] DamageShow 配置查不到";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ownerFighterUid", ownerFighterUid);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("effectId", effectId);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			this.DispatchDamageDA(ownerFighterUid, damageShowConfig.Value);
		}

		// Token: 0x06036CCE RID: 224462 RVA: 0x00F4AEFC File Offset: 0x00F490FC
		private void DispatchDamageDA(int targetFighterUid, DangoBrawlDamageShow showConfig)
		{
			string targetDA = showConfig.TargetDA;
			string oppositeDA = showConfig.OppositeDA;
			if (string.IsNullOrEmpty(targetDA) && string.IsNullOrEmpty(oppositeDA))
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			battleManager.ShowDamageDA(targetFighterUid, targetDA, oppositeDA, showConfig.DAInternal);
		}

		// Token: 0x06036CCF RID: 224463 RVA: 0x00F4AF4C File Offset: 0x00F4914C
		private DangoBrawlDamageShow? ResolveDamageShow(DangoBrawlDamageEvent evt)
		{
			DangoBrawlConfig instance = DangoBrawlConfig.Instance;
			if (evt.ShowType != 0)
			{
				return instance.GetDamageShowConfig(evt.ShowType);
			}
			DangoBrawlActivity? activityConfigById = instance.GetActivityConfigById(ActivityDangoBrawlController.Instance.MyActivityId);
			if (activityConfigById == null)
			{
				return null;
			}
			int num;
			switch (evt.Source)
			{
			case EDangoBrawlDamageSource.Heal:
				num = activityConfigById.Value.DamageTxtHeal;
				goto IL_B0;
			case EDangoBrawlDamageSource.Shield:
				num = activityConfigById.Value.DamageTxtShield;
				goto IL_B0;
			case EDangoBrawlDamageSource.Lifesteal:
				num = activityConfigById.Value.DamageTxtLifeSteal;
				goto IL_B0;
			}
			num = activityConfigById.Value.DamageTxtNormal;
			IL_B0:
			int num2 = num;
			if (num2 == 0)
			{
				return null;
			}
			return instance.GetDamageShowConfig(num2);
		}

		// Token: 0x06036CD0 RID: 224464 RVA: 0x00F4B020 File Offset: 0x00F49220
		public void Reset()
		{
			this.LogAgg.Reset();
		}

		// Token: 0x06036CD1 RID: 224465 RVA: 0x00F4B030 File Offset: 0x00F49230
		private static bool IsDamageForLog(EDangoBrawlDamageSource src)
		{
			switch (src)
			{
			case EDangoBrawlDamageSource.Weapon:
				return true;
			case EDangoBrawlDamageSource.BuffTick:
				return true;
			case EDangoBrawlDamageSource.Fatigue:
				break;
			case EDangoBrawlDamageSource.Reflect:
				return true;
			default:
				if (src == EDangoBrawlDamageSource.BuffWeaponDamage)
				{
					return true;
				}
				break;
			}
			return false;
		}

		// Token: 0x06036CD2 RID: 224466 RVA: 0x00F4B06C File Offset: 0x00F4926C
		private static bool IsHealForLog(EDangoBrawlDamageSource src)
		{
			return src == EDangoBrawlDamageSource.Heal || src == EDangoBrawlDamageSource.Lifesteal;
		}

		// Token: 0x0401CEE7 RID: 118503
		private readonly DangoBrawlBattleLogAggregator LogAgg = new DangoBrawlBattleLogAggregator();
	}
}
