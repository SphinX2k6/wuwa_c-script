using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000594 RID: 1428
	public class ConfigMotorFightMonsterRefreshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002185 RID: 8581 RVA: 0x001170A8 File Offset: 0x001152A8
		static ConfigMotorFightMonsterRefreshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightMonsterRefreshById.CreateStaticDefaultValue), new Action(ConfigMotorFightMonsterRefreshById.ResetStaticDefaultValue));
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x001170C8 File Offset: 0x001152C8
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightMonsterRefreshById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightMonsterRefreshById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightMonsterRefresh"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightMonsterRefresh` where Id=?")
			});
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00117147 File Offset: 0x00115347
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightMonsterRefreshById.LogPair = null;
			ConfigMotorFightMonsterRefreshById.HandleId = 0;
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00117155 File Offset: 0x00115355
		public static void Init()
		{
			ConfigMotorFightMonsterRefreshById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightMonsterRefreshById.HandleId, "db_motorfight.db", "select BinData from `MotorFightMonsterRefresh` where Id=?");
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00117170 File Offset: 0x00115370
		public static MotorFightMonsterRefresh? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightMonsterRefreshById.HandleId, ConfigMotorFightMonsterRefreshById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightMonsterRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightMonsterRefresh?(MotorFightMonsterRefresh.GetRootAsMotorFightMonsterRefresh(configBuffer));
				}
			}
			ConfigMotorFightMonsterRefreshById.LogPair.Clear();
			ConfigMotorFightMonsterRefreshById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightMonsterRefreshById.HandleId, 1, p0Id, ConfigMotorFightMonsterRefreshById.LogPair) || ConfigCommon.Step(ConfigMotorFightMonsterRefreshById.HandleId, true, ConfigMotorFightMonsterRefreshById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightMonsterRefreshById.HandleId, ConfigMotorFightMonsterRefreshById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightMonsterRefreshById.HandleId, 0, ConfigMotorFightMonsterRefreshById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightMonsterRefreshById.HandleId, ConfigMotorFightMonsterRefreshById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightMonsterRefresh rootAsMotorFightMonsterRefresh = MotorFightMonsterRefresh.GetRootAsMotorFightMonsterRefresh(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightMonsterRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightMonsterRefreshById.HandleId, ConfigMotorFightMonsterRefreshById.LogPair);
			return new MotorFightMonsterRefresh?(rootAsMotorFightMonsterRefresh);
		}

		// Token: 0x040026F0 RID: 9968
		private const string DB = "db_motorfight.db";

		// Token: 0x040026F1 RID: 9969
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x040026F2 RID: 9970
		private const string TABLE = "MotorFightMonsterRefresh";

		// Token: 0x040026F3 RID: 9971
		private const string COMMAND = "select BinData from `MotorFightMonsterRefresh` where Id=?";

		// Token: 0x040026F4 RID: 9972
		private const string KEY_PREFIX = "MotorFightMonsterRefreshById";

		// Token: 0x040026F5 RID: 9973
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026F6 RID: 9974
		private static int HandleId;
	}
}
