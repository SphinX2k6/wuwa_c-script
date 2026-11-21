using System;
using Aki.Config;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020040B8 RID: 16568
	public class PlotAvgUtils
	{
		// Token: 0x06029E9A RID: 171674 RVA: 0x00BD994E File Offset: 0x00BD7B4E
		public static EPlotAvgCharacterSpineDirection GetSpineDirectionByPosition(EAvgRolePosition position)
		{
			if (position <= EAvgRolePosition.Left2)
			{
				return EPlotAvgCharacterSpineDirection.Right;
			}
			if (position - EAvgRolePosition.Right1 > 1)
			{
				return EPlotAvgCharacterSpineDirection.Left;
			}
			return EPlotAvgCharacterSpineDirection.Left;
		}

		// Token: 0x06029E9B RID: 171675 RVA: 0x00BD9964 File Offset: 0x00BD7B64
		public static AvgTalkerConfig? GetAvgTalkerConfigByTalkerId(int talkerId)
		{
			if (talkerId == 750088)
			{
				LoginDefine.ELoginSex sex = (LoginDefine.ELoginSex)WorldLevelModel.Instance.Sex;
				if (sex == LoginDefine.ELoginSex.Girl)
				{
					return ConfigAvgTalkerConfigById.GetConfig(850002, true);
				}
				if (sex == LoginDefine.ELoginSex.Boy)
				{
					return ConfigAvgTalkerConfigById.GetConfig(850001, true);
				}
			}
			Speaker? config = ConfigSpeakerById.GetConfig(talkerId, true);
			if (config == null)
			{
				return null;
			}
			int avgTalkerConfig = config.Value.AvgTalkerConfig;
			if (avgTalkerConfig == 0)
			{
				return null;
			}
			return ConfigAvgTalkerConfigById.GetConfig(avgTalkerConfig, true);
		}

		// Token: 0x06029E9C RID: 171676 RVA: 0x00BD99E8 File Offset: 0x00BD7BE8
		public static int GetAvgTalkerIdBySpeakerId(int speakerId)
		{
			Speaker? config = ConfigSpeakerById.GetConfig(speakerId, true);
			if (config == null)
			{
				return 0;
			}
			return config.Value.AvgTalkerConfig;
		}
	}
}
