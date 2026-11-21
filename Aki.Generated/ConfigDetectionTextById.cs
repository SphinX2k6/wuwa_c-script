using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000213 RID: 531
	public class ConfigDetectionTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C75 RID: 3189 RVA: 0x000A3A40 File Offset: 0x000A1C40
		static ConfigDetectionTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDetectionTextById.CreateStaticDefaultValue), new Action(ConfigDetectionTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x000A3A60 File Offset: 0x000A1C60
		public static void CreateStaticDefaultValue()
		{
			ConfigDetectionTextById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDetectionTextById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "DetectionText"),
				new ValueTuple<string, object>("语句", "select BinData from `DetectionText` where Id=?")
			});
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x000A3ADF File Offset: 0x000A1CDF
		public static void ResetStaticDefaultValue()
		{
			ConfigDetectionTextById.LogPair = null;
			ConfigDetectionTextById.HandleId = 0;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x000A3AED File Offset: 0x000A1CED
		public static void Init()
		{
			ConfigDetectionTextById.HandleId = ConfigCommon.InitDataStatement(ConfigDetectionTextById.HandleId, "db_adventure_detect.db", "select BinData from `DetectionText` where Id=?");
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x000A3B08 File Offset: 0x000A1D08
		public static DetectionText? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDetectionTextById.HandleId, ConfigDetectionTextById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DetectionTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DetectionText?(DetectionText.GetRootAsDetectionText(configBuffer));
				}
			}
			ConfigDetectionTextById.LogPair.Clear();
			ConfigDetectionTextById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDetectionTextById.HandleId, 1, p0Id, ConfigDetectionTextById.LogPair) || ConfigCommon.Step(ConfigDetectionTextById.HandleId, true, ConfigDetectionTextById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDetectionTextById.HandleId, ConfigDetectionTextById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDetectionTextById.HandleId, 0, ConfigDetectionTextById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDetectionTextById.HandleId, ConfigDetectionTextById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DetectionText rootAsDetectionText = DetectionText.GetRootAsDetectionText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DetectionTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDetectionTextById.HandleId, ConfigDetectionTextById.LogPair);
			return new DetectionText?(rootAsDetectionText);
		}

		// Token: 0x04000E69 RID: 3689
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04000E6A RID: 3690
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04000E6B RID: 3691
		private const string TABLE = "DetectionText";

		// Token: 0x04000E6C RID: 3692
		private const string COMMAND = "select BinData from `DetectionText` where Id=?";

		// Token: 0x04000E6D RID: 3693
		private const string KEY_PREFIX = "DetectionTextById";

		// Token: 0x04000E6E RID: 3694
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E6F RID: 3695
		private static int HandleId;
	}
}
