using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BC RID: 700
	public class ConfigFeiXuePreheatById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600106D RID: 4205 RVA: 0x000B65DC File Offset: 0x000B47DC
		static ConfigFeiXuePreheatById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFeiXuePreheatById.CreateStaticDefaultValue), new Action(ConfigFeiXuePreheatById.ResetStaticDefaultValue));
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x000B65FC File Offset: 0x000B47FC
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

		// Token: 0x0600106F RID: 4207 RVA: 0x000B667B File Offset: 0x000B487B
		public static void ResetStaticDefaultValue()
		{
			ConfigFeiXuePreheatById.LogPair = null;
			ConfigFeiXuePreheatById.HandleId = 0;
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x000B6689 File Offset: 0x000B4889
		public static void Init()
		{
			ConfigFeiXuePreheatById.HandleId = ConfigCommon.InitDataStatement(ConfigFeiXuePreheatById.HandleId, "db_feixuepreheat_db.db", "select BinData from `FeiXuePreheat` where Id=?");
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x000B66A4 File Offset: 0x000B48A4
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

		// Token: 0x04001308 RID: 4872
		private const string DB = "db_feixuepreheat_db.db";

		// Token: 0x04001309 RID: 4873
		private const string FILE = "f.绯雪预热签到活动.xlsx";

		// Token: 0x0400130A RID: 4874
		private const string TABLE = "FeiXuePreheat";

		// Token: 0x0400130B RID: 4875
		private const string COMMAND = "select BinData from `FeiXuePreheat` where Id=?";

		// Token: 0x0400130C RID: 4876
		private const string KEY_PREFIX = "FeiXuePreheatById";

		// Token: 0x0400130D RID: 4877
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400130E RID: 4878
		private static int HandleId;
	}
}
