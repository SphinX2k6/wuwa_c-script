using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000811 RID: 2065
	public class ConfigRhythmShipLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003078 RID: 12408 RVA: 0x0016EA9B File Offset: 0x0016CC9B
		static ConfigRhythmShipLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipLevelById.CreateStaticDefaultValue), new Action(ConfigRhythmShipLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x0016EABC File Offset: 0x0016CCBC
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmShipLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmShipLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmShipLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmShipLevel` where Id=?")
			});
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x0016EB3B File Offset: 0x0016CD3B
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipLevelById.LogPair = null;
			ConfigRhythmShipLevelById.HandleId = 0;
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x0016EB49 File Offset: 0x0016CD49
		public static void Init()
		{
			ConfigRhythmShipLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipLevelById.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipLevel` where Id=?");
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x0016EB64 File Offset: 0x0016CD64
		public static RhythmShipLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmShipLevelById.HandleId, ConfigRhythmShipLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmShipLevel?(RhythmShipLevel.GetRootAsRhythmShipLevel(configBuffer));
				}
			}
			ConfigRhythmShipLevelById.LogPair.Clear();
			ConfigRhythmShipLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmShipLevelById.HandleId, 1, p0Id, ConfigRhythmShipLevelById.LogPair) || ConfigCommon.Step(ConfigRhythmShipLevelById.HandleId, true, ConfigRhythmShipLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmShipLevelById.HandleId, ConfigRhythmShipLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmShipLevelById.HandleId, 0, ConfigRhythmShipLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmShipLevelById.HandleId, ConfigRhythmShipLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmShipLevel rootAsRhythmShipLevel = RhythmShipLevel.GetRootAsRhythmShipLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmShipLevelById.HandleId, ConfigRhythmShipLevelById.LogPair);
			return new RhythmShipLevel?(rootAsRhythmShipLevel);
		}

		// Token: 0x0400385D RID: 14429
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400385E RID: 14430
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400385F RID: 14431
		private const string TABLE = "RhythmShipLevel";

		// Token: 0x04003860 RID: 14432
		private const string COMMAND = "select BinData from `RhythmShipLevel` where Id=?";

		// Token: 0x04003861 RID: 14433
		private const string KEY_PREFIX = "RhythmShipLevelById";

		// Token: 0x04003862 RID: 14434
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003863 RID: 14435
		private static int HandleId;
	}
}
