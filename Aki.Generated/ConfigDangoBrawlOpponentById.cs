using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D6 RID: 470
	public class ConfigDangoBrawlOpponentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B07 RID: 2823 RVA: 0x00097E4C File Offset: 0x0009604C
		static ConfigDangoBrawlOpponentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlOpponentById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlOpponentById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00097E6C File Offset: 0x0009606C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlOpponentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlOpponentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlOpponent"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlOpponent` where Id=?")
			});
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00097EEB File Offset: 0x000960EB
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlOpponentById.LogPair = null;
			ConfigDangoBrawlOpponentById.HandleId = 0;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00097EF9 File Offset: 0x000960F9
		public static void Init()
		{
			ConfigDangoBrawlOpponentById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlOpponentById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlOpponent` where Id=?");
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00097F14 File Offset: 0x00096114
		public static DangoBrawlOpponent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlOpponentById.HandleId, ConfigDangoBrawlOpponentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlOpponentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlOpponent?(DangoBrawlOpponent.GetRootAsDangoBrawlOpponent(configBuffer));
				}
			}
			ConfigDangoBrawlOpponentById.LogPair.Clear();
			ConfigDangoBrawlOpponentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlOpponentById.HandleId, 1, p0Id, ConfigDangoBrawlOpponentById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlOpponentById.HandleId, true, ConfigDangoBrawlOpponentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlOpponentById.HandleId, ConfigDangoBrawlOpponentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlOpponentById.HandleId, 0, ConfigDangoBrawlOpponentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlOpponentById.HandleId, ConfigDangoBrawlOpponentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlOpponent rootAsDangoBrawlOpponent = DangoBrawlOpponent.GetRootAsDangoBrawlOpponent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlOpponentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlOpponentById.HandleId, ConfigDangoBrawlOpponentById.LogPair);
			return new DangoBrawlOpponent?(rootAsDangoBrawlOpponent);
		}

		// Token: 0x04000CBE RID: 3262
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CBF RID: 3263
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CC0 RID: 3264
		private const string TABLE = "DangoBrawlOpponent";

		// Token: 0x04000CC1 RID: 3265
		private const string COMMAND = "select BinData from `DangoBrawlOpponent` where Id=?";

		// Token: 0x04000CC2 RID: 3266
		private const string KEY_PREFIX = "DangoBrawlOpponentById";

		// Token: 0x04000CC3 RID: 3267
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CC4 RID: 3268
		private static int HandleId;
	}
}
