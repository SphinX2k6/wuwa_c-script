using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02003474 RID: 13428
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectUtil
	{
		// Token: 0x0602245F RID: 140383 RVA: 0x009B59C0 File Offset: 0x009B3BC0
		public static string GetEffectPath(string effectId)
		{
			return ConfigEffectConfigById.GetConfig(effectId, true).Value.Path;
		}

		// Token: 0x06022460 RID: 140384 RVA: 0x009B59E4 File Offset: 0x009B3BE4
		public static int? SpawnUiEffect(string effectId, string reason, FTransformDouble? transform = null, [Nullable(2)] EffectContext context = null)
		{
			FTransformDouble valueOrDefault = transform.GetValueOrDefault();
			if (transform == null)
			{
				valueOrDefault = new FTransformDouble();
				transform = new FTransformDouble?(valueOrDefault);
			}
			string effectPath = EffectUtil.GetEffectPath(effectId);
			return new int?(EffectSystem.Instance.SpawnEffect(GlobalData.World, transform, effectPath, reason, null, EEffectType.UiScene3D, null, null, null, false, false));
		}

		// Token: 0x06022461 RID: 140385 RVA: 0x009B5A37 File Offset: 0x009B3C37
		public static string GetPreviewReplaceEffectPath(string oldPath)
		{
			return oldPath;
		}

		// Token: 0x06022462 RID: 140386 RVA: 0x009B5A3C File Offset: 0x009B3C3C
		public static void RefreshAdditionTimeScale(int effect, PawnTimeScaleComponent timeScaleComp)
		{
			if (timeScaleComp == null || !timeScaleComp.Valid)
			{
				return;
			}
			ForeverTimeScale topForeverTimeScaleConfig = timeScaleComp.GetTopForeverTimeScaleConfig(new ESourceEffectGroup?(ESourceEffectGroup.LogicAndView));
			if (topForeverTimeScaleConfig == null)
			{
				return;
			}
			EffectSystem.Instance.SetAdditionTimeScale(topForeverTimeScaleConfig.SourceType, effect, topForeverTimeScaleConfig.TimeDilation);
		}

		// Token: 0x06022463 RID: 140387 RVA: 0x009B5A84 File Offset: 0x009B3C84
		public static void SetEffectTimeScale(int effect, PawnTimeScaleComponent timeScaleComp, float entityTimeDilation, ETimeScaleType timeScaleType = ETimeScaleType.FollowEntity)
		{
			float freezeTimeScale = timeScaleComp.FreezeTimeScale;
			EffectSystem.Instance.SetTimeScale(effect, freezeTimeScale * entityTimeDilation, true);
			if (timeScaleType == ETimeScaleType.FollowEntity)
			{
				EffectUtil.RefreshAdditionTimeScale(effect, timeScaleComp);
				return;
			}
			CharacterModel instance = CharacterModel.Instance;
			float timeScale = (instance != null) ? instance.InverseSelfCenteredTimeDilation : 1f;
			EffectSystem.Instance.SetAdditionTimeScale(ETimeScaleSourceType.SelfCentered, effect, timeScale);
		}

		// Token: 0x06022464 RID: 140388 RVA: 0x009B5AD8 File Offset: 0x009B3CD8
		public static void SetAdditionalEffectTimeScaleByEntity(EntityHandle entityHandle, int effectId)
		{
			if (entityHandle == null || !entityHandle.Valid)
			{
				return;
			}
			PawnTimeScaleComponent component = entityHandle.Entity.GetComponent<PawnTimeScaleComponent>();
			if (component == null || !component.Valid)
			{
				return;
			}
			EffectUtil.SetEffectTimeScale(effectId, component, entityHandle.Entity.TimeDilation, ETimeScaleType.FollowEntity);
		}

		// Token: 0x06022465 RID: 140389 RVA: 0x009B5B28 File Offset: 0x009B3D28
		public static void ListenForeverTimeScale(int effect, PawnTimeScaleComponent timeScaleComp)
		{
			EffectUtil.<>c__DisplayClass6_0 CS$<>8__locals1 = new EffectUtil.<>c__DisplayClass6_0();
			CS$<>8__locals1.effect = effect;
			CS$<>8__locals1.timeScaleComp = timeScaleComp;
			CS$<>8__locals1.entity = CS$<>8__locals1.timeScaleComp.Entity;
			EventSystem.Instance.AddWithTarget<ETimeScaleSourceType, float, int>(CS$<>8__locals1.entity, EEventName.OnForeverTimeDilationAdd, new Action<ETimeScaleSourceType, float, int>(CS$<>8__locals1.<ListenForeverTimeScale>g__OnSelfCenteredChanged|0));
			EventSystem.Instance.AddWithTarget<ETimeScaleSourceType, float, int>(CS$<>8__locals1.entity, EEventName.OnForeverTimeDilationRemove, new Action<ETimeScaleSourceType, float, int>(CS$<>8__locals1.<ListenForeverTimeScale>g__OnSelfCenteredChanged|0));
			EffectSystem.Instance.AddFinishCallback(CS$<>8__locals1.effect, delegate(int finishedHandle)
			{
				if (!CS$<>8__locals1.entity.Valid)
				{
					return;
				}
				EventSystem.Instance.RemoveWithTarget<ETimeScaleSourceType, float, int>(CS$<>8__locals1.entity, EEventName.OnForeverTimeDilationAdd, new Action<ETimeScaleSourceType, float, int>(base.<ListenForeverTimeScale>g__OnSelfCenteredChanged|0));
				EventSystem.Instance.RemoveWithTarget<ETimeScaleSourceType, float, int>(CS$<>8__locals1.entity, EEventName.OnForeverTimeDilationRemove, new Action<ETimeScaleSourceType, float, int>(base.<ListenForeverTimeScale>g__OnSelfCenteredChanged|0));
			});
		}
	}
}
