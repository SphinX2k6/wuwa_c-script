using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088B RID: 2187
	public class ConfigRogueWeeklyBFById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003354 RID: 13140 RVA: 0x0017F1FB File Offset: 0x0017D3FB
		static ConfigRogueWeeklyBFById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyBFById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyBFById.ResetStaticDefaultValue));
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x0017F21C File Offset: 0x0017D41C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyBFById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyBFById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常黑石花奖励.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyBF"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyBF` where Id=?")
			});
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x0017F29B File Offset: 0x0017D49B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyBFById.LogPair = null;
			ConfigRogueWeeklyBFById.HandleId = 0;
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x0017F2A9 File Offset: 0x0017D4A9
		public static void Init()
		{
			ConfigRogueWeeklyBFById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyBFById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyBF` where Id=?");
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x0017F2C4 File Offset: 0x0017D4C4
		public static RogueWeeklyBF? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyBFById.HandleId, ConfigRogueWeeklyBFById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBFById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeeklyBF?(RogueWeeklyBF.GetRootAsRogueWeeklyBF(configBuffer));
				}
			}
			ConfigRogueWeeklyBFById.LogPair.Clear();
			ConfigRogueWeeklyBFById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyBFById.HandleId, 1, p0Id, ConfigRogueWeeklyBFById.LogPair) || ConfigCommon.Step(ConfigRogueWeeklyBFById.HandleId, true, ConfigRogueWeeklyBFById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyBFById.HandleId, ConfigRogueWeeklyBFById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyBFById.HandleId, 0, ConfigRogueWeeklyBFById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyBFById.HandleId, ConfigRogueWeeklyBFById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeeklyBF rootAsRogueWeeklyBF = RogueWeeklyBF.GetRootAsRogueWeeklyBF(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBFById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyBFById.HandleId, ConfigRogueWeeklyBFById.LogPair);
			return new RogueWeeklyBF?(rootAsRogueWeeklyBF);
		}

		// Token: 0x04003BB3 RID: 15283
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BB4 RID: 15284
		private const string FILE = "r.肉鸽周常黑石花奖励.xlsx";

		// Token: 0x04003BB5 RID: 15285
		private const string TABLE = "RogueWeeklyBF";

		// Token: 0x04003BB6 RID: 15286
		private const string COMMAND = "select BinData from `RogueWeeklyBF` where Id=?";

		// Token: 0x04003BB7 RID: 15287
		private const string KEY_PREFIX = "RogueWeeklyBFById";

		// Token: 0x04003BB8 RID: 15288
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BB9 RID: 15289
		private static int HandleId;
	}
}
