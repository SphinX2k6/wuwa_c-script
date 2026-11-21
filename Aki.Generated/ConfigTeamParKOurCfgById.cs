using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A99 RID: 2713
	public class ConfigTeamParKOurCfgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FAA RID: 16298 RVA: 0x001C4C9B File Offset: 0x001C2E9B
		static ConfigTeamParKOurCfgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeamParKOurCfgById.CreateStaticDefaultValue), new Action(ConfigTeamParKOurCfgById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x001C4CBC File Offset: 0x001C2EBC
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

		// Token: 0x06003FAC RID: 16300 RVA: 0x001C4D3B File Offset: 0x001C2F3B
		public static void ResetStaticDefaultValue()
		{
			ConfigTeamParKOurCfgById.LogPair = null;
			ConfigTeamParKOurCfgById.HandleId = 0;
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x001C4D49 File Offset: 0x001C2F49
		public static void Init()
		{
			ConfigTeamParKOurCfgById.HandleId = ConfigCommon.InitDataStatement(ConfigTeamParKOurCfgById.HandleId, "db_teamparkour.db", "select BinData from `TeamParKOurCfg` where Id=?");
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x001C4D64 File Offset: 0x001C2F64
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

		// Token: 0x04004A15 RID: 18965
		private const string DB = "db_teamparkour.db";

		// Token: 0x04004A16 RID: 18966
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x04004A17 RID: 18967
		private const string TABLE = "TeamParKOurCfg";

		// Token: 0x04004A18 RID: 18968
		private const string COMMAND = "select BinData from `TeamParKOurCfg` where Id=?";

		// Token: 0x04004A19 RID: 18969
		private const string KEY_PREFIX = "TeamParKOurCfgById";

		// Token: 0x04004A1A RID: 18970
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A1B RID: 18971
		private static int HandleId;
	}
}
