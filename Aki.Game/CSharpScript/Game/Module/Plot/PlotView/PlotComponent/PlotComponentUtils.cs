using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005088 RID: 20616
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotComponentUtils
	{
		// Token: 0x06034D09 RID: 216329 RVA: 0x00C7DC70 File Offset: 0x00C7BE70
		public static float GetTalkWaitTime(ITalkItem talkItem)
		{
			float? waitTime = talkItem.WaitTime;
			if (waitTime == null)
			{
				waitTime = new float?(PlotModel.Instance.PlotGlobalConfig.JumpWaitTime);
			}
			float? num = waitTime;
			double? num2 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
			double minWaitingTime = PlotModel.Instance.PlotTemplate.MinWaitingTime;
			if (num2.GetValueOrDefault() < minWaitingTime & num2 != null)
			{
				waitTime = new float?((float)PlotModel.Instance.PlotTemplate.MinWaitingTime);
			}
			waitTime = new float?((float)TimeUtil.Instance.SetTimeMillisecond((double)waitTime.Value));
			return waitTime.Value;
		}

		// Token: 0x06034D0A RID: 216330 RVA: 0x00C7DD24 File Offset: 0x00C7BF24
		public static bool GetContentTextNeedRefresh(ITalkItem talkItem)
		{
			return PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelD;
		}

		// Token: 0x06034D0B RID: 216331 RVA: 0x00C7DD40 File Offset: 0x00C7BF40
		public static float GetTextWriterAnimSpeed(bool bIsInteraction)
		{
			float result;
			if (bIsInteraction)
			{
				result = PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedInteraction;
			}
			else if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC)
			{
				result = PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedLevelC;
			}
			else
			{
				result = PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedLevelD;
			}
			return result;
		}

		// Token: 0x06034D0C RID: 216332 RVA: 0x00C7DDA4 File Offset: 0x00C7BFA4
		public static float GetTextScrollDelayCharNum()
		{
			return (float)ConfigCommonParamById.GetIntConfig("PlotAutoScrollDelayCharNum").Value;
		}

		// Token: 0x06034D0D RID: 216333 RVA: 0x00C7DDC4 File Offset: 0x00C7BFC4
		public static float GetTextWriterAnimDuration(ITalkItem talkItem, UUIText textComponent, float speed)
		{
			ICaptionParam captionParams = talkItem.CaptionParams;
			if (captionParams != null && captionParams.StartTime == null)
			{
				return captionParams.TotalTime.GetValueOrDefault();
			}
			return (float)textComponent.GetDisplayCharLength() / speed;
		}

		// Token: 0x06034D0E RID: 216334 RVA: 0x00C7DE04 File Offset: 0x00C7C004
		public static float GetAutoPlayEndWaitTime(bool bIsInteraction)
		{
			float num = 1f;
			if (bIsInteraction)
			{
				num = PlotModel.Instance.PlotGlobalConfig.EndWaitTimeInteraction;
			}
			else if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC)
			{
				num = PlotModel.Instance.PlotGlobalConfig.EndWaitTimeLevelC;
			}
			if ((double)num < PlotModel.Instance.PlotTemplate.MinWaitingTime)
			{
				num = (float)PlotModel.Instance.PlotTemplate.MinWaitingTime;
			}
			return num * 1000f;
		}
	}
}
