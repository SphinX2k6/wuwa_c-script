using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087F RID: 2175
	public class ConfigRogueWeekTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600330C RID: 13068 RVA: 0x00179F3C File Offset: 0x0017813C
		static ConfigRogueWeekTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeekTagById.CreateStaticDefaultValue), new Action(ConfigRogueWeekTagById.ResetStaticDefaultValue));
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x00179F5C File Offset: 0x0017815C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeekTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeekTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeekTag"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeekTag` where Id=?")
			});
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x00179FDB File Offset: 0x001781DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeekTagById.LogPair = null;
			ConfigRogueWeekTagById.HandleId = 0;
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x00179FE9 File Offset: 0x001781E9
		public static void Init()
		{
			ConfigRogueWeekTagById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeekTagById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeekTag` where Id=?");
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x0017A004 File Offset: 0x00178204
		public static RogueWeekTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeekTagById.HandleId, ConfigRogueWeekTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeekTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeekTag?(RogueWeekTag.GetRootAsRogueWeekTag(configBuffer));
				}
			}
			ConfigRogueWeekTagById.LogPair.Clear();
			ConfigRogueWeekTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeekTagById.HandleId, 1, p0Id, ConfigRogueWeekTagById.LogPair) || ConfigCommon.Step(ConfigRogueWeekTagById.HandleId, true, ConfigRogueWeekTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeekTagById.HandleId, ConfigRogueWeekTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeekTagById.HandleId, 0, ConfigRogueWeekTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeekTagById.HandleId, ConfigRogueWeekTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeekTag rootAsRogueWeekTag = RogueWeekTag.GetRootAsRogueWeekTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeekTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeekTagById.HandleId, ConfigRogueWeekTagById.LogPair);
			return new RogueWeekTag?(rootAsRogueWeekTag);
		}

		// Token: 0x04003B5F RID: 15199
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B60 RID: 15200
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B61 RID: 15201
		private const string TABLE = "RogueWeekTag";

		// Token: 0x04003B62 RID: 15202
		private const string COMMAND = "select BinData from `RogueWeekTag` where Id=?";

		// Token: 0x04003B63 RID: 15203
		private const string KEY_PREFIX = "RogueWeekTagById";

		// Token: 0x04003B64 RID: 15204
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B65 RID: 15205
		private static int HandleId;
	}
}
