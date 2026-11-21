using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000881 RID: 2177
	public class ConfigRogueSeasonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003318 RID: 13080 RVA: 0x0017DCB3 File Offset: 0x0017BEB3
		static ConfigRogueSeasonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueSeasonById.CreateStaticDefaultValue), new Action(ConfigRogueSeasonById.ResetStaticDefaultValue));
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x0017DCD4 File Offset: 0x0017BED4
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueSeasonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueSeasonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueSeason"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueSeason` where Id=?")
			});
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x0017DD53 File Offset: 0x0017BF53
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueSeasonById.LogPair = null;
			ConfigRogueSeasonById.HandleId = 0;
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x0017DD61 File Offset: 0x0017BF61
		public static void Init()
		{
			ConfigRogueSeasonById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueSeasonById.HandleId, "db_rogue.db", "select BinData from `RogueSeason` where Id=?");
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x0017DD7C File Offset: 0x0017BF7C
		public static RogueSeason? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueSeasonById.HandleId, ConfigRogueSeasonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueSeason?(RogueSeason.GetRootAsRogueSeason(configBuffer));
				}
			}
			ConfigRogueSeasonById.LogPair.Clear();
			ConfigRogueSeasonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueSeasonById.HandleId, 1, p0Id, ConfigRogueSeasonById.LogPair) || ConfigCommon.Step(ConfigRogueSeasonById.HandleId, true, ConfigRogueSeasonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueSeasonById.HandleId, ConfigRogueSeasonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueSeasonById.HandleId, 0, ConfigRogueSeasonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueSeasonById.HandleId, ConfigRogueSeasonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueSeason rootAsRogueSeason = RogueSeason.GetRootAsRogueSeason(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueSeasonById.HandleId, ConfigRogueSeasonById.LogPair);
			return new RogueSeason?(rootAsRogueSeason);
		}

		// Token: 0x04003B6D RID: 15213
		private const string DB = "db_rogue.db";

		// Token: 0x04003B6E RID: 15214
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003B6F RID: 15215
		private const string TABLE = "RogueSeason";

		// Token: 0x04003B70 RID: 15216
		private const string COMMAND = "select BinData from `RogueSeason` where Id=?";

		// Token: 0x04003B71 RID: 15217
		private const string KEY_PREFIX = "RogueSeasonById";

		// Token: 0x04003B72 RID: 15218
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B73 RID: 15219
		private static int HandleId;
	}
}
