using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086B RID: 2155
	public class ConfigRogueTokenBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003294 RID: 12948 RVA: 0x001776B8 File Offset: 0x001758B8
		static ConfigRogueTokenBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTokenBySeasonId.CreateStaticDefaultValue), new Action(ConfigRogueTokenBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x001776D8 File Offset: 0x001758D8
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

		// Token: 0x06003296 RID: 12950 RVA: 0x00177757 File Offset: 0x00175957
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTokenBySeasonId.LogPair = null;
			ConfigRogueTokenBySeasonId.HandleId = 0;
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x00177765 File Offset: 0x00175965
		public static void Init()
		{
			ConfigRogueTokenBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTokenBySeasonId.HandleId, "db_rogue.db", "select BinData from `RogueToken` where SeasonId=?");
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x00177780 File Offset: 0x00175980
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

		// Token: 0x04003AD3 RID: 15059
		private const string DB = "db_rogue.db";

		// Token: 0x04003AD4 RID: 15060
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003AD5 RID: 15061
		private const string TABLE = "RogueToken";

		// Token: 0x04003AD6 RID: 15062
		private const string COMMAND = "select BinData from `RogueToken` where SeasonId=?";

		// Token: 0x04003AD7 RID: 15063
		private const string KEY_PREFIX = "RogueTokenBySeasonId";

		// Token: 0x04003AD8 RID: 15064
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AD9 RID: 15065
		private static int HandleId;
	}
}
