using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Plot.Avg;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037A6 RID: 14246
	[NullableContext(1)]
	[Nullable(0)]
	public class VisualNovelConfigCenter
	{
		// Token: 0x060250F3 RID: 151795 RVA: 0x00A766F9 File Offset: 0x00A748F9
		public virtual string GetCgResourcePath(string path, string maleVariant)
		{
			return path;
		}

		// Token: 0x060250F4 RID: 151796 RVA: 0x00A766FC File Offset: 0x00A748FC
		public string GetCgPrefabPath(int cgId)
		{
			AvgCg? config = ConfigAvgCgById.GetConfig(cgId, true);
			if (config == null || string.IsNullOrEmpty(config.Value.Data))
			{
				return string.Empty;
			}
			VisualNovelCgConfig visualNovelCgConfig = Json.Parse<VisualNovelCgConfig>(config.Value.Data, null);
			if (!(visualNovelCgConfig.Type == "Prefab"))
			{
				return string.Empty;
			}
			return this.GetCgResourcePath(visualNovelCgConfig.PrefabPath, visualNovelCgConfig.PrefabPathMaleVariant);
		}

		// Token: 0x060250F5 RID: 151797 RVA: 0x00A7677C File Offset: 0x00A7497C
		public virtual int GetAvgTalkerId(int speakerId)
		{
			if (PlotAvgUtils.GetAvgTalkerConfigByTalkerId(speakerId) == null)
			{
				return 0;
			}
			AvgTalkerConfig? avgTalkerConfig;
			return avgTalkerConfig.GetValueOrDefault().Id;
		}

		// Token: 0x060250F6 RID: 151798 RVA: 0x00A767AC File Offset: 0x00A749AC
		public virtual VisualNovelCharacterResource? GetCharacterResource(int speakerId)
		{
			return null;
		}

		// Token: 0x060250F7 RID: 151799 RVA: 0x00A767C2 File Offset: 0x00A749C2
		public virtual int GetDefaultCharacterAnimationId(int speakerId)
		{
			return 0;
		}

		// Token: 0x060250F8 RID: 151800 RVA: 0x00A767C5 File Offset: 0x00A749C5
		public virtual VisualNovelTransform GetCharacterHeadIconTransform(int speakerId)
		{
			return new VisualNovelTransform(0f, 0f, 1f);
		}

		// Token: 0x060250F9 RID: 151801 RVA: 0x00A767DC File Offset: 0x00A749DC
		public virtual VisualNovelCharacterAnimation? GetCharacterAnimation(int animationId)
		{
			return null;
		}

		// Token: 0x060250FA RID: 151802 RVA: 0x00A767F2 File Offset: 0x00A749F2
		public virtual bool IsOptionConditionMet(ITalkOptionSystemCondition condition)
		{
			return true;
		}

		// Token: 0x060250FB RID: 151803 RVA: 0x00A767F5 File Offset: 0x00A749F5
		public virtual string GetOptionConditionText(ITalkOptionSystemCondition condition)
		{
			return string.Empty;
		}
	}
}
