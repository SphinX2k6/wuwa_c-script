using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F5 RID: 2037
	public class ConfigRhythmShipLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FD0 RID: 12240 RVA: 0x001677B3 File Offset: 0x001659B3
		static ConfigRhythmShipLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipLevelById.CreateStaticDefaultValue), new Action(ConfigRhythmShipLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x001677D4 File Offset: 0x001659D4
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

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00167853 File Offset: 0x00165A53
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipLevelById.LogPair = null;
			ConfigRhythmShipLevelById.HandleId = 0;
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00167861 File Offset: 0x00165A61
		public static void Init()
		{
			ConfigRhythmShipLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipLevelById.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipLevel` where Id=?");
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x0016787C File Offset: 0x00165A7C
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

		// Token: 0x04003799 RID: 14233
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400379A RID: 14234
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400379B RID: 14235
		private const string TABLE = "RhythmShipLevel";

		// Token: 0x0400379C RID: 14236
		private const string COMMAND = "select BinData from `RhythmShipLevel` where Id=?";

		// Token: 0x0400379D RID: 14237
		private const string KEY_PREFIX = "RhythmShipLevelById";

		// Token: 0x0400379E RID: 14238
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400379F RID: 14239
		private static int HandleId;
	}
}
