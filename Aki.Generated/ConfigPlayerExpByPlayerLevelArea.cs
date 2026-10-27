using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000741 RID: 1857
	public class ConfigPlayerExpByPlayerLevelArea : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B97 RID: 11159 RVA: 0x0014FF3C File Offset: 0x0014E13C
		static ConfigPlayerExpByPlayerLevelArea()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerExpByPlayerLevelArea.CreateStaticDefaultValue), new Action(ConfigPlayerExpByPlayerLevelArea.ResetStaticDefaultValue));
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x0014FF5C File Offset: 0x0014E15C
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayerExpByPlayerLevelArea.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayerExpByPlayerLevelArea.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_player_exp.db"),
				new ValueTuple<string, object>("文件", "j.经验.xlsx"),
				new ValueTuple<string, object>("表名", "PlayerExp"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayerExp` where PlayerLevel >= ? AND PlayerLevel < ?")
			});
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x0014FFDB File Offset: 0x0014E1DB
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerExpByPlayerLevelArea.LogPair = null;
			ConfigPlayerExpByPlayerLevelArea.HandleId = 0;
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x0014FFE9 File Offset: 0x0014E1E9
		public static void Init()
		{
			ConfigPlayerExpByPlayerLevelArea.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerExpByPlayerLevelArea.HandleId, "db_player_exp.db", "select BinData from `PlayerExp` where PlayerLevel >= ? AND PlayerLevel < ?");
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x00150004 File Offset: 0x0014E204
		[NullableContext(2)]
		public static IReadOnlyList<PlayerExp> GetConfigList(int p0PlayerLevel, int p1PlayerLevel, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayerExpByPlayerLevelArea.HandleId, ConfigPlayerExpByPlayerLevelArea.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerExpByPlayerLevelArea");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PlayerLevel);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1PlayerLevel);
				IReadOnlyList<PlayerExp> readOnlyList = (IReadOnlyList<PlayerExp>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPlayerExpByPlayerLevelArea.LogPair.Clear();
			ConfigPlayerExpByPlayerLevelArea.LogPair.Add(new ValueTuple<string, object>("PlayerLevel", p0PlayerLevel));
			ConfigPlayerExpByPlayerLevelArea.LogPair.Add(new ValueTuple<string, object>("PlayerLevel", p1PlayerLevel));
			if (!ConfigCommon.BindInt(ConfigPlayerExpByPlayerLevelArea.HandleId, 1, p0PlayerLevel, ConfigPlayerExpByPlayerLevelArea.LogPair) || !ConfigCommon.BindInt(ConfigPlayerExpByPlayerLevelArea.HandleId, 2, p1PlayerLevel, ConfigPlayerExpByPlayerLevelArea.LogPair))
			{
				ConfigCommon.Reset(ConfigPlayerExpByPlayerLevelArea.HandleId, ConfigPlayerExpByPlayerLevelArea.LogPair);
				return null;
			}
			List<PlayerExp> list = new List<PlayerExp>();
			while (ConfigCommon.Step(ConfigPlayerExpByPlayerLevelArea.HandleId, false, ConfigPlayerExpByPlayerLevelArea.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayerExpByPlayerLevelArea.HandleId, 0, ConfigPlayerExpByPlayerLevelArea.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPlayerExpByPlayerLevelArea.HandleId, ConfigPlayerExpByPlayerLevelArea.LogPair);
					return null;
				}
				PlayerExp rootAsPlayerExp = PlayerExp.GetRootAsPlayerExp(new ByteBuffer(item2));
				list.Add(rootAsPlayerExp);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerExpByPlayerLevelArea");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PlayerLevel);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1PlayerLevel);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPlayerExpByPlayerLevelArea.HandleId, ConfigPlayerExpByPlayerLevelArea.LogPair);
			return list;
		}

		// Token: 0x040032AD RID: 12973
		private const string DB = "db_player_exp.db";

		// Token: 0x040032AE RID: 12974
		private const string FILE = "j.经验.xlsx";

		// Token: 0x040032AF RID: 12975
		private const string TABLE = "PlayerExp";

		// Token: 0x040032B0 RID: 12976
		private const string COMMAND = "select BinData from `PlayerExp` where PlayerLevel >= ? AND PlayerLevel < ?";

		// Token: 0x040032B1 RID: 12977
		private const string KEY_PREFIX = "PlayerExpByPlayerLevelArea";

		// Token: 0x040032B2 RID: 12978
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032B3 RID: 12979
		private static int HandleId;
	}
}
