using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004058 RID: 16472
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotComponentUtils
	{
		// Token: 0x06029BFE RID: 171006 RVA: 0x00BCB048 File Offset: 0x00BC9248
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

		// Token: 0x06029BFF RID: 171007 RVA: 0x00BCB0FC File Offset: 0x00BC92FC
		public static bool GetContentTextNeedRefresh(ITalkItem talkItem)
		{
			return PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelD;
		}

		// Token: 0x06029C00 RID: 171008 RVA: 0x00BCB118 File Offset: 0x00BC9318
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

		// Token: 0x06029C01 RID: 171009 RVA: 0x00BCB17C File Offset: 0x00BC937C
		public static float GetTextScrollDelayCharNum()
		{
			return (float)ConfigCommonParamById.GetIntConfig("PlotAutoScrollDelayCharNum").Value;
		}

		// Token: 0x06029C02 RID: 171010 RVA: 0x00BCB19C File Offset: 0x00BC939C
		public static float GetTextWriterAnimDuration(ITalkItem talkItem, UUIText textComponent, float speed)
		{
			ICaptionParam captionParams = talkItem.CaptionParams;
			if (captionParams != null && captionParams.StartTime == null)
			{
				return captionParams.TotalTime.GetValueOrDefault();
			}
			return (float)textComponent.GetDisplayCharLength() / speed;
		}

		// Token: 0x06029C03 RID: 171011 RVA: 0x00BCB1DC File Offset: 0x00BC93DC
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
