using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D1 RID: 721
	public class ConfigFeiXuePreheatById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010EB RID: 4331 RVA: 0x000BCAE8 File Offset: 0x000BACE8
		static ConfigFeiXuePreheatById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFeiXuePreheatById.CreateStaticDefaultValue), new Action(ConfigFeiXuePreheatById.ResetStaticDefaultValue));
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x000BCB08 File Offset: 0x000BAD08
		public static void CreateStaticDefaultValue()
		{
			ConfigFeiXuePreheatById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFeiXuePreheatById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_feixuepreheat_db.db"),
				new ValueTuple<string, object>("文件", "f.绯雪预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "FeiXuePreheat"),
				new ValueTuple<string, object>("语句", "select BinData from `FeiXuePreheat` where Id=?")
			});
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x000BCB87 File Offset: 0x000BAD87
		public static void ResetStaticDefaultValue()
		{
			ConfigFeiXuePreheatById.LogPair = null;
			ConfigFeiXuePreheatById.HandleId = 0;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x000BCB95 File Offset: 0x000BAD95
		public static void Init()
		{
			ConfigFeiXuePreheatById.HandleId = ConfigCommon.InitDataStatement(ConfigFeiXuePreheatById.HandleId, "db_feixuepreheat_db.db", "select BinData from `FeiXuePreheat` where Id=?");
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x000BCBB0 File Offset: 0x000BADB0
		public static FeiXuePreheat? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFeiXuePreheatById.HandleId, ConfigFeiXuePreheatById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FeiXuePreheatById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FeiXuePreheat?(FeiXuePreheat.GetRootAsFeiXuePreheat(configBuffer));
				}
			}
			ConfigFeiXuePreheatById.LogPair.Clear();
			ConfigFeiXuePreheatById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFeiXuePreheatById.HandleId, 1, p0Id, ConfigFeiXuePreheatById.LogPair) || ConfigCommon.Step(ConfigFeiXuePreheatById.HandleId, true, ConfigFeiXuePreheatById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFeiXuePreheatById.HandleId, ConfigFeiXuePreheatById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFeiXuePreheatById.HandleId, 0, ConfigFeiXuePreheatById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFeiXuePreheatById.HandleId, ConfigFeiXuePreheatById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FeiXuePreheat rootAsFeiXuePreheat = FeiXuePreheat.GetRootAsFeiXuePreheat(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FeiXuePreheatById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFeiXuePreheatById.HandleId, ConfigFeiXuePreheatById.LogPair);
			return new FeiXuePreheat?(rootAsFeiXuePreheat);
		}

		// Token: 0x0400139B RID: 5019
		private const string DB = "db_feixuepreheat_db.db";

		// Token: 0x0400139C RID: 5020
		private const string FILE = "f.绯雪预热签到活动.xlsx";

		// Token: 0x0400139D RID: 5021
		private const string TABLE = "FeiXuePreheat";

		// Token: 0x0400139E RID: 5022
		private const string COMMAND = "select BinData from `FeiXuePreheat` where Id=?";

		// Token: 0x0400139F RID: 5023
		private const string KEY_PREFIX = "FeiXuePreheatById";

		// Token: 0x040013A0 RID: 5024
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013A1 RID: 5025
		private static int HandleId;
	}
}
