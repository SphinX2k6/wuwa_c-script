using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000887 RID: 2183
	public class ConfigRogueTokenBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600333C RID: 13116 RVA: 0x0017E9A0 File Offset: 0x0017CBA0
		static ConfigRogueTokenBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTokenBySeasonId.CreateStaticDefaultValue), new Action(ConfigRogueTokenBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x0017E9C0 File Offset: 0x0017CBC0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueTokenBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueTokenBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueToken"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueToken` where SeasonId=?")
			});
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x0017EA3F File Offset: 0x0017CC3F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTokenBySeasonId.LogPair = null;
			ConfigRogueTokenBySeasonId.HandleId = 0;
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x0017EA4D File Offset: 0x0017CC4D
		public static void Init()
		{
			ConfigRogueTokenBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTokenBySeasonId.HandleId, "db_rogue.db", "select BinData from `RogueToken` where SeasonId=?");
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x0017EA68 File Offset: 0x0017CC68
		[NullableContext(2)]
		public static IReadOnlyList<RogueToken> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueTokenBySeasonId.HandleId, ConfigRogueTokenBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTokenBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<RogueToken> readOnlyList = (IReadOnlyList<RogueToken>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRogueTokenBySeasonId.LogPair.Clear();
			ConfigRogueTokenBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigRogueTokenBySeasonId.HandleId, 1, p0SeasonId, ConfigRogueTokenBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigRogueTokenBySeasonId.HandleId, ConfigRogueTokenBySeasonId.LogPair);
				return null;
			}
			List<RogueToken> list = new List<RogueToken>();
			while (ConfigCommon.Step(ConfigRogueTokenBySeasonId.HandleId, false, ConfigRogueTokenBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueTokenBySeasonId.HandleId, 0, ConfigRogueTokenBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueTokenBySeasonId.HandleId, ConfigRogueTokenBySeasonId.LogPair);
					return null;
				}
				RogueToken rootAsRogueToken = RogueToken.GetRootAsRogueToken(new ByteBuffer(item2));
				list.Add(rootAsRogueToken);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTokenBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueTokenBySeasonId.HandleId, ConfigRogueTokenBySeasonId.LogPair);
			return list;
		}

		// Token: 0x04003B97 RID: 15255
		private const string DB = "db_rogue.db";

		// Token: 0x04003B98 RID: 15256
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003B99 RID: 15257
		private const string TABLE = "RogueToken";

		// Token: 0x04003B9A RID: 15258
		private const string COMMAND = "select BinData from `RogueToken` where SeasonId=?";

		// Token: 0x04003B9B RID: 15259
		private const string KEY_PREFIX = "RogueTokenBySeasonId";

		// Token: 0x04003B9C RID: 15260
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B9D RID: 15261
		private static int HandleId;
	}
}
