using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D9 RID: 2009
	public class ConfigRecallFunctionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F28 RID: 12072 RVA: 0x0016772C File Offset: 0x0016592C
		static ConfigRecallFunctionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallFunctionById.CreateStaticDefaultValue), new Action(ConfigRecallFunctionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x0016774C File Offset: 0x0016594C
		public static void CreateStaticDefaultValue()
		{
			ConfigRecallFunctionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRecallFunctionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questrecall.db"),
				new ValueTuple<string, object>("文件", "r.任务回顾.xlsx"),
				new ValueTuple<string, object>("表名", "RecallFunction"),
				new ValueTuple<string, object>("语句", "select BinData from `RecallFunction` where Id=?")
			});
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x001677CB File Offset: 0x001659CB
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallFunctionById.LogPair = null;
			ConfigRecallFunctionById.HandleId = 0;
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x001677D9 File Offset: 0x001659D9
		public static void Init()
		{
			ConfigRecallFunctionById.HandleId = ConfigCommon.InitDataStatement(ConfigRecallFunctionById.HandleId, "db_questrecall.db", "select BinData from `RecallFunction` where Id=?");
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x001677F4 File Offset: 0x001659F4
		public static RecallFunction? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRecallFunctionById.HandleId, ConfigRecallFunctionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecallFunctionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RecallFunction?(RecallFunction.GetRootAsRecallFunction(configBuffer));
				}
			}
			ConfigRecallFunctionById.LogPair.Clear();
			ConfigRecallFunctionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRecallFunctionById.HandleId, 1, p0Id, ConfigRecallFunctionById.LogPair) || ConfigCommon.Step(ConfigRecallFunctionById.HandleId, true, ConfigRecallFunctionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRecallFunctionById.HandleId, ConfigRecallFunctionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRecallFunctionById.HandleId, 0, ConfigRecallFunctionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRecallFunctionById.HandleId, ConfigRecallFunctionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RecallFunction rootAsRecallFunction = RecallFunction.GetRootAsRecallFunction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecallFunctionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRecallFunctionById.HandleId, ConfigRecallFunctionById.LogPair);
			return new RecallFunction?(rootAsRecallFunction);
		}

		// Token: 0x040036D5 RID: 14037
		private const string DB = "db_questrecall.db";

		// Token: 0x040036D6 RID: 14038
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x040036D7 RID: 14039
		private const string TABLE = "RecallFunction";

		// Token: 0x040036D8 RID: 14040
		private const string COMMAND = "select BinData from `RecallFunction` where Id=?";

		// Token: 0x040036D9 RID: 14041
		private const string KEY_PREFIX = "RecallFunctionById";

		// Token: 0x040036DA RID: 14042
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036DB RID: 14043
		private static int HandleId;
	}
}
