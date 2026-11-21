using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000773 RID: 1907
	public class ConfigPreheatSignReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CC3 RID: 11459 RVA: 0x00159CE3 File Offset: 0x00157EE3
		static ConfigPreheatSignReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatSignReById.CreateStaticDefaultValue), new Action(ConfigPreheatSignReById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00159D04 File Offset: 0x00157F04
		public static void CreateStaticDefaultValue()
		{
			ConfigPreheatSignReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreheatSignReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_preheat.db"),
				new ValueTuple<string, object>("文件", "y.预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "PreheatSignRe"),
				new ValueTuple<string, object>("语句", "select BinData from `PreheatSignRe` where Id=?")
			});
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x00159D83 File Offset: 0x00157F83
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatSignReById.LogPair = null;
			ConfigPreheatSignReById.HandleId = 0;
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x00159D91 File Offset: 0x00157F91
		public static void Init()
		{
			ConfigPreheatSignReById.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatSignReById.HandleId, "db_preheat.db", "select BinData from `PreheatSignRe` where Id=?");
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x00159DAC File Offset: 0x00157FAC
		public static PreheatSignRe? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreheatSignReById.HandleId, ConfigPreheatSignReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreheatSignReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PreheatSignRe?(PreheatSignRe.GetRootAsPreheatSignRe(configBuffer));
				}
			}
			ConfigPreheatSignReById.LogPair.Clear();
			ConfigPreheatSignReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPreheatSignReById.HandleId, 1, p0Id, ConfigPreheatSignReById.LogPair) || ConfigCommon.Step(ConfigPreheatSignReById.HandleId, true, ConfigPreheatSignReById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPreheatSignReById.HandleId, ConfigPreheatSignReById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreheatSignReById.HandleId, 0, ConfigPreheatSignReById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPreheatSignReById.HandleId, ConfigPreheatSignReById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PreheatSignRe rootAsPreheatSignRe = PreheatSignRe.GetRootAsPreheatSignRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreheatSignReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPreheatSignReById.HandleId, ConfigPreheatSignReById.LogPair);
			return new PreheatSignRe?(rootAsPreheatSignRe);
		}

		// Token: 0x0400340B RID: 13323
		private const string DB = "db_preheat.db";

		// Token: 0x0400340C RID: 13324
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x0400340D RID: 13325
		private const string TABLE = "PreheatSignRe";

		// Token: 0x0400340E RID: 13326
		private const string COMMAND = "select BinData from `PreheatSignRe` where Id=?";

		// Token: 0x0400340F RID: 13327
		private const string KEY_PREFIX = "PreheatSignReById";

		// Token: 0x04003410 RID: 13328
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003411 RID: 13329
		private static int HandleId;
	}
}
