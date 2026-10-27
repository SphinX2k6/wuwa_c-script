using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000760 RID: 1888
	public class ConfigPreOpenDetectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C51 RID: 11345 RVA: 0x00153C67 File Offset: 0x00151E67
		static ConfigPreOpenDetectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreOpenDetectionById.CreateStaticDefaultValue), new Action(ConfigPreOpenDetectionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x00153C88 File Offset: 0x00151E88
		public static void CreateStaticDefaultValue()
		{
			ConfigPreOpenDetectionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreOpenDetectionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "PreOpenDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `PreOpenDetection` where Id=?")
			});
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00153D07 File Offset: 0x00151F07
		public static void ResetStaticDefaultValue()
		{
			ConfigPreOpenDetectionById.LogPair = null;
			ConfigPreOpenDetectionById.HandleId = 0;
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00153D15 File Offset: 0x00151F15
		public static void Init()
		{
			ConfigPreOpenDetectionById.HandleId = ConfigCommon.InitDataStatement(ConfigPreOpenDetectionById.HandleId, "db_adventure_detect.db", "select BinData from `PreOpenDetection` where Id=?");
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x00153D30 File Offset: 0x00151F30
		public static PreOpenDetection? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreOpenDetectionById.HandleId, ConfigPreOpenDetectionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreOpenDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PreOpenDetection?(PreOpenDetection.GetRootAsPreOpenDetection(configBuffer));
				}
			}
			ConfigPreOpenDetectionById.LogPair.Clear();
			ConfigPreOpenDetectionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPreOpenDetectionById.HandleId, 1, p0Id, ConfigPreOpenDetectionById.LogPair) || ConfigCommon.Step(ConfigPreOpenDetectionById.HandleId, true, ConfigPreOpenDetectionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPreOpenDetectionById.HandleId, ConfigPreOpenDetectionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreOpenDetectionById.HandleId, 0, ConfigPreOpenDetectionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPreOpenDetectionById.HandleId, ConfigPreOpenDetectionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PreOpenDetection rootAsPreOpenDetection = PreOpenDetection.GetRootAsPreOpenDetection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreOpenDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPreOpenDetectionById.HandleId, ConfigPreOpenDetectionById.LogPair);
			return new PreOpenDetection?(rootAsPreOpenDetection);
		}

		// Token: 0x04003386 RID: 13190
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04003387 RID: 13191
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04003388 RID: 13192
		private const string TABLE = "PreOpenDetection";

		// Token: 0x04003389 RID: 13193
		private const string COMMAND = "select BinData from `PreOpenDetection` where Id=?";

		// Token: 0x0400338A RID: 13194
		private const string KEY_PREFIX = "PreOpenDetectionById";

		// Token: 0x0400338B RID: 13195
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400338C RID: 13196
		private static int HandleId;
	}
}
