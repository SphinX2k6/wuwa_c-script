using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000892 RID: 2194
	public class ConfigRogueWeeklyParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600337E RID: 13182 RVA: 0x0017FFC7 File Offset: 0x0017E1C7
		static ConfigRogueWeeklyParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyParamById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyParamById.ResetStaticDefaultValue));
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x0017FFE8 File Offset: 0x0017E1E8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyParam"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyParam` where Id=?")
			});
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x00180067 File Offset: 0x0017E267
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyParamById.LogPair = null;
			ConfigRogueWeeklyParamById.HandleId = 0;
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x00180075 File Offset: 0x0017E275
		public static void Init()
		{
			ConfigRogueWeeklyParamById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyParamById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyParam` where Id=?");
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00180090 File Offset: 0x0017E290
		public static RogueWeeklyParam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyParamById.HandleId, ConfigRogueWeeklyParamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeeklyParam?(RogueWeeklyParam.GetRootAsRogueWeeklyParam(configBuffer));
				}
			}
			ConfigRogueWeeklyParamById.LogPair.Clear();
			ConfigRogueWeeklyParamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyParamById.HandleId, 1, p0Id, ConfigRogueWeeklyParamById.LogPair) || ConfigCommon.Step(ConfigRogueWeeklyParamById.HandleId, true, ConfigRogueWeeklyParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyParamById.HandleId, ConfigRogueWeeklyParamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyParamById.HandleId, 0, ConfigRogueWeeklyParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyParamById.HandleId, ConfigRogueWeeklyParamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeeklyParam rootAsRogueWeeklyParam = RogueWeeklyParam.GetRootAsRogueWeeklyParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyParamById.HandleId, ConfigRogueWeeklyParamById.LogPair);
			return new RogueWeeklyParam?(rootAsRogueWeeklyParam);
		}

		// Token: 0x04003BE4 RID: 15332
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BE5 RID: 15333
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003BE6 RID: 15334
		private const string TABLE = "RogueWeeklyParam";

		// Token: 0x04003BE7 RID: 15335
		private const string COMMAND = "select BinData from `RogueWeeklyParam` where Id=?";

		// Token: 0x04003BE8 RID: 15336
		private const string KEY_PREFIX = "RogueWeeklyParamById";

		// Token: 0x04003BE9 RID: 15337
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BEA RID: 15338
		private static int HandleId;
	}
}
