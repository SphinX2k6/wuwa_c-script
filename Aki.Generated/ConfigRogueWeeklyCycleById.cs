using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000890 RID: 2192
	public class ConfigRogueWeeklyCycleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003372 RID: 13170 RVA: 0x0017FBEB File Offset: 0x0017DDEB
		static ConfigRogueWeeklyCycleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyCycleById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyCycleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x0017FC0C File Offset: 0x0017DE0C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyCycleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyCycleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyCycle"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyCycle` where Id=?")
			});
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x0017FC8B File Offset: 0x0017DE8B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyCycleById.LogPair = null;
			ConfigRogueWeeklyCycleById.HandleId = 0;
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x0017FC99 File Offset: 0x0017DE99
		public static void Init()
		{
			ConfigRogueWeeklyCycleById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyCycleById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyCycle` where Id=?");
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x0017FCB4 File Offset: 0x0017DEB4
		public static RogueWeeklyCycle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyCycleById.HandleId, ConfigRogueWeeklyCycleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyCycleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeeklyCycle?(RogueWeeklyCycle.GetRootAsRogueWeeklyCycle(configBuffer));
				}
			}
			ConfigRogueWeeklyCycleById.LogPair.Clear();
			ConfigRogueWeeklyCycleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyCycleById.HandleId, 1, p0Id, ConfigRogueWeeklyCycleById.LogPair) || ConfigCommon.Step(ConfigRogueWeeklyCycleById.HandleId, true, ConfigRogueWeeklyCycleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyCycleById.HandleId, ConfigRogueWeeklyCycleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyCycleById.HandleId, 0, ConfigRogueWeeklyCycleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyCycleById.HandleId, ConfigRogueWeeklyCycleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeeklyCycle rootAsRogueWeeklyCycle = RogueWeeklyCycle.GetRootAsRogueWeeklyCycle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyCycleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyCycleById.HandleId, ConfigRogueWeeklyCycleById.LogPair);
			return new RogueWeeklyCycle?(rootAsRogueWeeklyCycle);
		}

		// Token: 0x04003BD6 RID: 15318
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BD7 RID: 15319
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003BD8 RID: 15320
		private const string TABLE = "RogueWeeklyCycle";

		// Token: 0x04003BD9 RID: 15321
		private const string COMMAND = "select BinData from `RogueWeeklyCycle` where Id=?";

		// Token: 0x04003BDA RID: 15322
		private const string KEY_PREFIX = "RogueWeeklyCycleById";

		// Token: 0x04003BDB RID: 15323
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BDC RID: 15324
		private static int HandleId;
	}
}
