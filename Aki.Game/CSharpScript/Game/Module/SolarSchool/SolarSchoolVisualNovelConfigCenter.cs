using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.ActivityCondition;
using CSharpScript.Game.Module.Plot.Avg;
using CSharpScript.Game.Module.VisualNovel;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A6D RID: 23149
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelConfigCenter : VisualNovelConfigCenter
	{
		// Token: 0x0603906B RID: 233579 RVA: 0x00FF938D File Offset: 0x00FF758D
		public override string GetCgResourcePath(string path, string maleVariant)
		{
			if (SolarSchoolGamePlayModel.Instance.GetPlayerGender() != EPlayerGender.Male || string.IsNullOrEmpty(maleVariant))
			{
				return path;
			}
			return maleVariant;
		}

		// Token: 0x0603906C RID: 233580 RVA: 0x00FF93AC File Offset: 0x00FF75AC
		public override VisualNovelCharacterResource? GetCharacterResource(int speakerId)
		{
			AvgTalkerConfig? avgTalkerConfigByTalkerId = PlotAvgUtils.GetAvgTalkerConfigByTalkerId(speakerId);
			if (avgTalkerConfigByTalkerId == null)
			{
				return null;
			}
			VisualNovelTransform? portraitTransform = SolarSchoolVisualNovelConfigCenter.ParseTransform(avgTalkerConfigByTalkerId.Value.SolarSchoolPortraitTransform);
			return new VisualNovelCharacterResource?(new VisualNovelCharacterResource(avgTalkerConfigByTalkerId.Value.SolarSchoolSpineAtlas, avgTalkerConfigByTalkerId.Value.SolarSchoolSpineSkeletonData, avgTalkerConfigByTalkerId.Value.SolarSchoolPortraitTexture, portraitTransform));
		}

		// Token: 0x0603906D RID: 233581 RVA: 0x00FF9420 File Offset: 0x00FF7620
		public override int GetDefaultCharacterAnimationId(int speakerId)
		{
			if (PlotAvgUtils.GetAvgTalkerConfigByTalkerId(speakerId) == null)
			{
				return 0;
			}
			AvgTalkerConfig? avgTalkerConfig;
			return avgTalkerConfig.GetValueOrDefault().SolarSchoolDefaultExpressionId;
		}

		// Token: 0x0603906E RID: 233582 RVA: 0x00FF9450 File Offset: 0x00FF7650
		public override VisualNovelTransform GetCharacterHeadIconTransform(int speakerId)
		{
			AvgTalkerConfig? avgTalkerConfig;
			VisualNovelTransform? visualNovelTransform = SolarSchoolVisualNovelConfigCenter.ParseTransform(((PlotAvgUtils.GetAvgTalkerConfigByTalkerId(speakerId) != null) ? avgTalkerConfig.GetValueOrDefault().SolarSchoolHeadIconTransform : null) ?? string.Empty);
			if (visualNovelTransform == null)
			{
				return new VisualNovelTransform(0f, 0f, 1f);
			}
			return visualNovelTransform.GetValueOrDefault();
		}

		// Token: 0x0603906F RID: 233583 RVA: 0x00FF94B4 File Offset: 0x00FF76B4
		public override VisualNovelCharacterAnimation? GetCharacterAnimation(int animationId)
		{
			AvgSolarSchoolRoleAnimation? config = ConfigAvgSolarSchoolRoleAnimationById.GetConfig(animationId, true);
			if (config == null)
			{
				return null;
			}
			int avgTalkerId = config.Value.AvgTalkerId;
			if (avgTalkerId == 850001 || avgTalkerId == 850002)
			{
				avgTalkerId = this.GetAvgTalkerId(750088);
			}
			return new VisualNovelCharacterAnimation?(new VisualNovelCharacterAnimation(avgTalkerId, config.Value.BodyAnimation, config.Value.MouthAnimation, config.Value.MouthOpenSmallAnimation, config.Value.MouthOpenLargeAnimation, config.Value.EyeAnimation, config.Value.BlinkAnimation));
		}

		// Token: 0x06039070 RID: 233584 RVA: 0x00FF9570 File Offset: 0x00FF7770
		public override bool IsOptionConditionMet(ITalkOptionSystemCondition condition)
		{
			ITalkOptionConditionSolarSchool system = condition.System;
			return system == null || ActivityConditionCenter.Instance.CheckGroup(system.ConditionGroupId);
		}

		// Token: 0x06039071 RID: 233585 RVA: 0x00FF959C File Offset: 0x00FF779C
		public override string GetOptionConditionText(ITalkOptionSystemCondition condition)
		{
			ITalkOptionConditionSolarSchool system = condition.System;
			if (system == null)
			{
				return string.Empty;
			}
			return SolarSchoolUtils.GetConditionHintText(system.ConditionGroupId);
		}

		// Token: 0x06039072 RID: 233586 RVA: 0x00FF95C4 File Offset: 0x00FF77C4
		private static VisualNovelTransform? ParseTransform(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return null;
			}
			VisualNovelPortraitTransformConfig visualNovelPortraitTransformConfig = Json.Parse<VisualNovelPortraitTransformConfig>(value, null);
			return new VisualNovelTransform?(new VisualNovelTransform(visualNovelPortraitTransformConfig.PosX, visualNovelPortraitTransformConfig.PosY, visualNovelPortraitTransformConfig.Scale));
		}
	}
}
