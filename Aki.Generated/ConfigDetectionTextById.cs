using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000201 RID: 513
	public class ConfigDetectionTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C09 RID: 3081 RVA: 0x0009DB08 File Offset: 0x0009BD08
		static ConfigDetectionTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDetectionTextById.CreateStaticDefaultValue), new Action(ConfigDetectionTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0009DB28 File Offset: 0x0009BD28
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

		// Token: 0x06000C0B RID: 3083 RVA: 0x0009DBA7 File Offset: 0x0009BDA7
		public static void ResetStaticDefaultValue()
		{
			ConfigDetectionTextById.LogPair = null;
			ConfigDetectionTextById.HandleId = 0;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0009DBB5 File Offset: 0x0009BDB5
		public static void Init()
		{
			ConfigDetectionTextById.HandleId = ConfigCommon.InitDataStatement(ConfigDetectionTextById.HandleId, "db_adventure_detect.db", "select BinData from `DetectionText` where Id=?");
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0009DBD0 File Offset: 0x0009BDD0
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

		// Token: 0x04000DEB RID: 3563
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04000DEC RID: 3564
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04000DED RID: 3565
		private const string TABLE = "DetectionText";

		// Token: 0x04000DEE RID: 3566
		private const string COMMAND = "select BinData from `DetectionText` where Id=?";

		// Token: 0x04000DEF RID: 3567
		private const string KEY_PREFIX = "DetectionTextById";

		// Token: 0x04000DF0 RID: 3568
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DF1 RID: 3569
		private static int HandleId;
	}
}
