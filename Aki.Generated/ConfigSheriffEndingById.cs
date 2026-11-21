using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000961 RID: 2401
	public class ConfigSheriffEndingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003859 RID: 14425 RVA: 0x0019B14B File Offset: 0x0019934B
		static ConfigSheriffEndingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffEndingById.CreateStaticDefaultValue), new Action(ConfigSheriffEndingById.ResetStaticDefaultValue));
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x0019B16C File Offset: 0x0019936C
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffEndingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffEndingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffEnding"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffEnding` where Id=?")
			});
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x0019B1EB File Offset: 0x001993EB
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffEndingById.LogPair = null;
			ConfigSheriffEndingById.HandleId = 0;
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x0019B1F9 File Offset: 0x001993F9
		public static void Init()
		{
			ConfigSheriffEndingById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffEndingById.HandleId, "db_sheriff.db", "select BinData from `SheriffEnding` where Id=?");
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x0019B214 File Offset: 0x00199414
		public static SheriffEnding? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffEndingById.HandleId, ConfigSheriffEndingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffEnding?(SheriffEnding.GetRootAsSheriffEnding(configBuffer));
				}
			}
			ConfigSheriffEndingById.LogPair.Clear();
			ConfigSheriffEndingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffEndingById.HandleId, 1, p0Id, ConfigSheriffEndingById.LogPair) || ConfigCommon.Step(ConfigSheriffEndingById.HandleId, true, ConfigSheriffEndingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffEndingById.HandleId, ConfigSheriffEndingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffEndingById.HandleId, 0, ConfigSheriffEndingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffEndingById.HandleId, ConfigSheriffEndingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffEnding rootAsSheriffEnding = SheriffEnding.GetRootAsSheriffEnding(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffEndingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffEndingById.HandleId, ConfigSheriffEndingById.LogPair);
			return new SheriffEnding?(rootAsSheriffEnding);
		}

		// Token: 0x0400418D RID: 16781
		private const string DB = "db_sheriff.db";

		// Token: 0x0400418E RID: 16782
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x0400418F RID: 16783
		private const string TABLE = "SheriffEnding";

		// Token: 0x04004190 RID: 16784
		private const string COMMAND = "select BinData from `SheriffEnding` where Id=?";

		// Token: 0x04004191 RID: 16785
		private const string KEY_PREFIX = "SheriffEndingById";

		// Token: 0x04004192 RID: 16786
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004193 RID: 16787
		private static int HandleId;
	}
}
