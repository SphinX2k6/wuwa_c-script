using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000202 RID: 514
	public class ConfigDetectionTitlePanelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C0F RID: 3087 RVA: 0x0009DD50 File Offset: 0x0009BF50
		static ConfigDetectionTitlePanelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDetectionTitlePanelById.CreateStaticDefaultValue), new Action(ConfigDetectionTitlePanelById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0009DD70 File Offset: 0x0009BF70
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

		// Token: 0x06000C11 RID: 3089 RVA: 0x0009DDEF File Offset: 0x0009BFEF
		public static void ResetStaticDefaultValue()
		{
			ConfigDetectionTitlePanelById.LogPair = null;
			ConfigDetectionTitlePanelById.HandleId = 0;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0009DDFD File Offset: 0x0009BFFD
		public static void Init()
		{
			ConfigDetectionTitlePanelById.HandleId = ConfigCommon.InitDataStatement(ConfigDetectionTitlePanelById.HandleId, "db_adventure_detect.db", "select BinData from `DetectionTitlePanel` where Id=?");
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0009DE18 File Offset: 0x0009C018
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

		// Token: 0x04000DF2 RID: 3570
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04000DF3 RID: 3571
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04000DF4 RID: 3572
		private const string TABLE = "DetectionTitlePanel";

		// Token: 0x04000DF5 RID: 3573
		private const string COMMAND = "select BinData from `DetectionTitlePanel` where Id=?";

		// Token: 0x04000DF6 RID: 3574
		private const string KEY_PREFIX = "DetectionTitlePanelById";

		// Token: 0x04000DF7 RID: 3575
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DF8 RID: 3576
		private static int HandleId;
	}
}
