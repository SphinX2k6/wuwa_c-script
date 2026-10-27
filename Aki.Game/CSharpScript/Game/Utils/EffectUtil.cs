using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200454C RID: 17740
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectUtil
	{
		// Token: 0x0602DD7D RID: 187773 RVA: 0x00A8A2A4 File Offset: 0x00A884A4
		public static string GetEffectPath(string effectId)
		{
			return ConfigEffectConfigById.GetConfig(effectId, true).Value.Path;
		}

		// Token: 0x0602DD7E RID: 187774 RVA: 0x00A8A2C8 File Offset: 0x00A884C8
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

		// Token: 0x0602DD7F RID: 187775 RVA: 0x00A8A31B File Offset: 0x00A8851B
		public static string GetPreviewReplaceEffectPath(string oldPath)
		{
			return oldPath;
		}

		// Token: 0x0602DD80 RID: 187776 RVA: 0x00A8A320 File Offset: 0x00A88520
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

		// Token: 0x0602DD81 RID: 187777 RVA: 0x00A8A368 File Offset: 0x00A88568
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

		// Token: 0x0602DD82 RID: 187778 RVA: 0x00A8A3BC File Offset: 0x00A885BC
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

		// Token: 0x0602DD83 RID: 187779 RVA: 0x00A8A40C File Offset: 0x00A8860C
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
