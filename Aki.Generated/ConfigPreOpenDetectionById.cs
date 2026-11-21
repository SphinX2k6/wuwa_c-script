using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000778 RID: 1912
	public class ConfigPreOpenDetectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CE1 RID: 11489 RVA: 0x0015A6E3 File Offset: 0x001588E3
		static ConfigPreOpenDetectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreOpenDetectionById.CreateStaticDefaultValue), new Action(ConfigPreOpenDetectionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x0015A704 File Offset: 0x00158904
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

		// Token: 0x06002CE3 RID: 11491 RVA: 0x0015A783 File Offset: 0x00158983
		public static void ResetStaticDefaultValue()
		{
			ConfigPreOpenDetectionById.LogPair = null;
			ConfigPreOpenDetectionById.HandleId = 0;
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x0015A791 File Offset: 0x00158991
		public static void Init()
		{
			ConfigPreOpenDetectionById.HandleId = ConfigCommon.InitDataStatement(ConfigPreOpenDetectionById.HandleId, "db_adventure_detect.db", "select BinData from `PreOpenDetection` where Id=?");
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x0015A7AC File Offset: 0x001589AC
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

		// Token: 0x0400342E RID: 13358
		private const string DB = "db_adventure_detect.db";

		// Token: 0x0400342F RID: 13359
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04003430 RID: 13360
		private const string TABLE = "PreOpenDetection";

		// Token: 0x04003431 RID: 13361
		private const string COMMAND = "select BinData from `PreOpenDetection` where Id=?";

		// Token: 0x04003432 RID: 13362
		private const string KEY_PREFIX = "PreOpenDetectionById";

		// Token: 0x04003433 RID: 13363
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003434 RID: 13364
		private static int HandleId;
	}
}
