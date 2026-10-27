using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000549 RID: 1353
	public class ConfigMonsterDetectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FC3 RID: 8131 RVA: 0x0010CE3B File Offset: 0x0010B03B
		static ConfigMonsterDetectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDetectionById.CreateStaticDefaultValue), new Action(ConfigMonsterDetectionById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x0010CE5C File Offset: 0x0010B05C
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterDetectionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterDetectionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterDetection` where id=?")
			});
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x0010CEDB File Offset: 0x0010B0DB
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDetectionById.LogPair = null;
			ConfigMonsterDetectionById.HandleId = 0;
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x0010CEE9 File Offset: 0x0010B0E9
		public static void Init()
		{
			ConfigMonsterDetectionById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterDetectionById.HandleId, "db_adventure_detect.db", "select BinData from `MonsterDetection` where id=?");
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x0010CF04 File Offset: 0x0010B104
		public static MonsterDetection? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterDetectionById.HandleId, ConfigMonsterDetectionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterDetection?(MonsterDetection.GetRootAsMonsterDetection(configBuffer));
				}
			}
			ConfigMonsterDetectionById.LogPair.Clear();
			ConfigMonsterDetectionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterDetectionById.HandleId, 1, p0Id, ConfigMonsterDetectionById.LogPair) || ConfigCommon.Step(ConfigMonsterDetectionById.HandleId, true, ConfigMonsterDetectionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterDetectionById.HandleId, ConfigMonsterDetectionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterDetectionById.HandleId, 0, ConfigMonsterDetectionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterDetectionById.HandleId, ConfigMonsterDetectionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterDetection rootAsMonsterDetection = MonsterDetection.GetRootAsMonsterDetection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterDetectionById.HandleId, ConfigMonsterDetectionById.LogPair);
			return new MonsterDetection?(rootAsMonsterDetection);
		}

		// Token: 0x040024E3 RID: 9443
		private const string DB = "db_adventure_detect.db";

		// Token: 0x040024E4 RID: 9444
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x040024E5 RID: 9445
		private const string TABLE = "MonsterDetection";

		// Token: 0x040024E6 RID: 9446
		private const string COMMAND = "select BinData from `MonsterDetection` where id=?";

		// Token: 0x040024E7 RID: 9447
		private const string KEY_PREFIX = "MonsterDetectionById";

		// Token: 0x040024E8 RID: 9448
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024E9 RID: 9449
		private static int HandleId;
	}
}
