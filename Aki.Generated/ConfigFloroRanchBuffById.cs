using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000310 RID: 784
	public class ConfigFloroRanchBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001265 RID: 4709 RVA: 0x000C183F File Offset: 0x000BFA3F
		static ConfigFloroRanchBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchBuffById.CreateStaticDefaultValue), new Action(ConfigFloroRanchBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000C1860 File Offset: 0x000BFA60
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchbuff.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_buff.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchBuff` where Id=?")
			});
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000C18DF File Offset: 0x000BFADF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchBuffById.LogPair = null;
			ConfigFloroRanchBuffById.HandleId = 0;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x000C18ED File Offset: 0x000BFAED
		public static void Init()
		{
			ConfigFloroRanchBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchBuffById.HandleId, "db_flororanchbuff.db", "select BinData from `FloroRanchBuff` where Id=?");
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x000C1908 File Offset: 0x000BFB08
		public static FloroRanchBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchBuffById.HandleId, ConfigFloroRanchBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchBuff?(FloroRanchBuff.GetRootAsFloroRanchBuff(configBuffer));
				}
			}
			ConfigFloroRanchBuffById.LogPair.Clear();
			ConfigFloroRanchBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchBuffById.HandleId, 1, p0Id, ConfigFloroRanchBuffById.LogPair) || ConfigCommon.Step(ConfigFloroRanchBuffById.HandleId, true, ConfigFloroRanchBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchBuffById.HandleId, ConfigFloroRanchBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchBuffById.HandleId, 0, ConfigFloroRanchBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchBuffById.HandleId, ConfigFloroRanchBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchBuff rootAsFloroRanchBuff = FloroRanchBuff.GetRootAsFloroRanchBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchBuffById.HandleId, ConfigFloroRanchBuffById.LogPair);
			return new FloroRanchBuff?(rootAsFloroRanchBuff);
		}

		// Token: 0x04001554 RID: 5460
		private const string DB = "db_flororanchbuff.db";

		// Token: 0x04001555 RID: 5461
		private const string FILE = "f.弗洛洛牧场_buff.xlsx";

		// Token: 0x04001556 RID: 5462
		private const string TABLE = "FloroRanchBuff";

		// Token: 0x04001557 RID: 5463
		private const string COMMAND = "select BinData from `FloroRanchBuff` where Id=?";

		// Token: 0x04001558 RID: 5464
		private const string KEY_PREFIX = "FloroRanchBuffById";

		// Token: 0x04001559 RID: 5465
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400155A RID: 5466
		private static int HandleId;
	}
}
