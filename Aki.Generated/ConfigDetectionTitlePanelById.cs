using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000214 RID: 532
	public class ConfigDetectionTitlePanelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C7B RID: 3195 RVA: 0x000A3C88 File Offset: 0x000A1E88
		static ConfigDetectionTitlePanelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDetectionTitlePanelById.CreateStaticDefaultValue), new Action(ConfigDetectionTitlePanelById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x000A3CA8 File Offset: 0x000A1EA8
		public static void CreateStaticDefaultValue()
		{
			ConfigDetectionTitlePanelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDetectionTitlePanelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "DetectionTitlePanel"),
				new ValueTuple<string, object>("语句", "select BinData from `DetectionTitlePanel` where Id=?")
			});
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x000A3D27 File Offset: 0x000A1F27
		public static void ResetStaticDefaultValue()
		{
			ConfigDetectionTitlePanelById.LogPair = null;
			ConfigDetectionTitlePanelById.HandleId = 0;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000A3D35 File Offset: 0x000A1F35
		public static void Init()
		{
			ConfigDetectionTitlePanelById.HandleId = ConfigCommon.InitDataStatement(ConfigDetectionTitlePanelById.HandleId, "db_adventure_detect.db", "select BinData from `DetectionTitlePanel` where Id=?");
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000A3D50 File Offset: 0x000A1F50
		public static DetectionTitlePanel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDetectionTitlePanelById.HandleId, ConfigDetectionTitlePanelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DetectionTitlePanelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DetectionTitlePanel?(DetectionTitlePanel.GetRootAsDetectionTitlePanel(configBuffer));
				}
			}
			ConfigDetectionTitlePanelById.LogPair.Clear();
			ConfigDetectionTitlePanelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDetectionTitlePanelById.HandleId, 1, p0Id, ConfigDetectionTitlePanelById.LogPair) || ConfigCommon.Step(ConfigDetectionTitlePanelById.HandleId, true, ConfigDetectionTitlePanelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDetectionTitlePanelById.HandleId, ConfigDetectionTitlePanelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDetectionTitlePanelById.HandleId, 0, ConfigDetectionTitlePanelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDetectionTitlePanelById.HandleId, ConfigDetectionTitlePanelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DetectionTitlePanel rootAsDetectionTitlePanel = DetectionTitlePanel.GetRootAsDetectionTitlePanel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DetectionTitlePanelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDetectionTitlePanelById.HandleId, ConfigDetectionTitlePanelById.LogPair);
			return new DetectionTitlePanel?(rootAsDetectionTitlePanel);
		}

		// Token: 0x04000E70 RID: 3696
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04000E71 RID: 3697
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04000E72 RID: 3698
		private const string TABLE = "DetectionTitlePanel";

		// Token: 0x04000E73 RID: 3699
		private const string COMMAND = "select BinData from `DetectionTitlePanel` where Id=?";

		// Token: 0x04000E74 RID: 3700
		private const string KEY_PREFIX = "DetectionTitlePanelById";

		// Token: 0x04000E75 RID: 3701
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E76 RID: 3702
		private static int HandleId;
	}
}
