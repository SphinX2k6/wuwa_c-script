using System;
using Aki.Config;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020050E8 RID: 20712
	public class PlotAvgUtils
	{
		// Token: 0x06034FA1 RID: 216993 RVA: 0x00C8C666 File Offset: 0x00C8A866
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

		// Token: 0x06034FA2 RID: 216994 RVA: 0x00C8C67C File Offset: 0x00C8A87C
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

		// Token: 0x06034FA3 RID: 216995 RVA: 0x00C8C700 File Offset: 0x00C8A900
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
