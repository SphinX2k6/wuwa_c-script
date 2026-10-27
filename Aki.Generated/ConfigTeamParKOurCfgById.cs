using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C4 RID: 2500
	public class ConfigTeamParKOurCfgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AAC RID: 15020 RVA: 0x001A5907 File Offset: 0x001A3B07
		static ConfigTeamParKOurCfgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeamParKOurCfgById.CreateStaticDefaultValue), new Action(ConfigTeamParKOurCfgById.ResetStaticDefaultValue));
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x001A5928 File Offset: 0x001A3B28
		public static void CreateStaticDefaultValue()
		{
			ConfigTeamParKOurCfgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTeamParKOurCfgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teamparkour.db"),
				new ValueTuple<string, object>("文件", "l.联机跑酷活动.xlsx"),
				new ValueTuple<string, object>("表名", "TeamParKOurCfg"),
				new ValueTuple<string, object>("语句", "select BinData from `TeamParKOurCfg` where Id=?")
			});
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x001A59A7 File Offset: 0x001A3BA7
		public static void ResetStaticDefaultValue()
		{
			ConfigTeamParKOurCfgById.LogPair = null;
			ConfigTeamParKOurCfgById.HandleId = 0;
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x001A59B5 File Offset: 0x001A3BB5
		public static void Init()
		{
			ConfigTeamParKOurCfgById.HandleId = ConfigCommon.InitDataStatement(ConfigTeamParKOurCfgById.HandleId, "db_teamparkour.db", "select BinData from `TeamParKOurCfg` where Id=?");
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x001A59D0 File Offset: 0x001A3BD0
		public static TeamParKOurCfg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTeamParKOurCfgById.HandleId, ConfigTeamParKOurCfgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeamParKOurCfgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TeamParKOurCfg?(TeamParKOurCfg.GetRootAsTeamParKOurCfg(configBuffer));
				}
			}
			ConfigTeamParKOurCfgById.LogPair.Clear();
			ConfigTeamParKOurCfgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTeamParKOurCfgById.HandleId, 1, p0Id, ConfigTeamParKOurCfgById.LogPair) || ConfigCommon.Step(ConfigTeamParKOurCfgById.HandleId, true, ConfigTeamParKOurCfgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTeamParKOurCfgById.HandleId, ConfigTeamParKOurCfgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTeamParKOurCfgById.HandleId, 0, ConfigTeamParKOurCfgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTeamParKOurCfgById.HandleId, ConfigTeamParKOurCfgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TeamParKOurCfg rootAsTeamParKOurCfg = TeamParKOurCfg.GetRootAsTeamParKOurCfg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeamParKOurCfgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTeamParKOurCfgById.HandleId, ConfigTeamParKOurCfgById.LogPair);
			return new TeamParKOurCfg?(rootAsTeamParKOurCfg);
		}

		// Token: 0x04004442 RID: 17474
		private const string DB = "db_teamparkour.db";

		// Token: 0x04004443 RID: 17475
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x04004444 RID: 17476
		private const string TABLE = "TeamParKOurCfg";

		// Token: 0x04004445 RID: 17477
		private const string COMMAND = "select BinData from `TeamParKOurCfg` where Id=?";

		// Token: 0x04004446 RID: 17478
		private const string KEY_PREFIX = "TeamParKOurCfgById";

		// Token: 0x04004447 RID: 17479
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004448 RID: 17480
		private static int HandleId;
	}
}
