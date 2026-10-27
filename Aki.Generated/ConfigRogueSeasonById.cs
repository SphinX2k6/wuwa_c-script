using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000865 RID: 2149
	public class ConfigRogueSeasonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003270 RID: 12912 RVA: 0x001769CB File Offset: 0x00174BCB
		static ConfigRogueSeasonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueSeasonById.CreateStaticDefaultValue), new Action(ConfigRogueSeasonById.ResetStaticDefaultValue));
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x001769EC File Offset: 0x00174BEC
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

		// Token: 0x06003272 RID: 12914 RVA: 0x00176A6B File Offset: 0x00174C6B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueSeasonById.LogPair = null;
			ConfigRogueSeasonById.HandleId = 0;
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x00176A79 File Offset: 0x00174C79
		public static void Init()
		{
			ConfigRogueSeasonById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueSeasonById.HandleId, "db_rogue.db", "select BinData from `RogueSeason` where Id=?");
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x00176A94 File Offset: 0x00174C94
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

		// Token: 0x04003AA9 RID: 15017
		private const string DB = "db_rogue.db";

		// Token: 0x04003AAA RID: 15018
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003AAB RID: 15019
		private const string TABLE = "RogueSeason";

		// Token: 0x04003AAC RID: 15020
		private const string COMMAND = "select BinData from `RogueSeason` where Id=?";

		// Token: 0x04003AAD RID: 15021
		private const string KEY_PREFIX = "RogueSeasonById";

		// Token: 0x04003AAE RID: 15022
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AAF RID: 15023
		private static int HandleId;
	}
}
