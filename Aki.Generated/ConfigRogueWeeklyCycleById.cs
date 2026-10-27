using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000874 RID: 2164
	public class ConfigRogueWeeklyCycleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032CA RID: 13002 RVA: 0x00178903 File Offset: 0x00176B03
		static ConfigRogueWeeklyCycleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyCycleById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyCycleById.ResetStaticDefaultValue));
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x00178924 File Offset: 0x00176B24
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

		// Token: 0x060032CC RID: 13004 RVA: 0x001789A3 File Offset: 0x00176BA3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyCycleById.LogPair = null;
			ConfigRogueWeeklyCycleById.HandleId = 0;
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x001789B1 File Offset: 0x00176BB1
		public static void Init()
		{
			ConfigRogueWeeklyCycleById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyCycleById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyCycle` where Id=?");
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x001789CC File Offset: 0x00176BCC
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

		// Token: 0x04003B12 RID: 15122
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B13 RID: 15123
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B14 RID: 15124
		private const string TABLE = "RogueWeeklyCycle";

		// Token: 0x04003B15 RID: 15125
		private const string COMMAND = "select BinData from `RogueWeeklyCycle` where Id=?";

		// Token: 0x04003B16 RID: 15126
		private const string KEY_PREFIX = "RogueWeeklyCycleById";

		// Token: 0x04003B17 RID: 15127
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B18 RID: 15128
		private static int HandleId;
	}
}
