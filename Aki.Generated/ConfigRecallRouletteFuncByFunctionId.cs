using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DB RID: 2011
	public class ConfigRecallRouletteFuncByFunctionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F34 RID: 12084 RVA: 0x00167B07 File Offset: 0x00165D07
		static ConfigRecallRouletteFuncByFunctionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallRouletteFuncByFunctionId.CreateStaticDefaultValue), new Action(ConfigRecallRouletteFuncByFunctionId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00167B28 File Offset: 0x00165D28
		public static void CreateStaticDefaultValue()
		{
			ConfigRecallRouletteFuncByFunctionId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRecallRouletteFuncByFunctionId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questrecall.db"),
				new ValueTuple<string, object>("文件", "r.任务回顾.xlsx"),
				new ValueTuple<string, object>("表名", "RecallRouletteFunc"),
				new ValueTuple<string, object>("语句", "select BinData from `RecallRouletteFunc` where FunctionId=?")
			});
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x00167BA7 File Offset: 0x00165DA7
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallRouletteFuncByFunctionId.LogPair = null;
			ConfigRecallRouletteFuncByFunctionId.HandleId = 0;
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x00167BB5 File Offset: 0x00165DB5
		public static void Init()
		{
			ConfigRecallRouletteFuncByFunctionId.HandleId = ConfigCommon.InitDataStatement(ConfigRecallRouletteFuncByFunctionId.HandleId, "db_questrecall.db", "select BinData from `RecallRouletteFunc` where FunctionId=?");
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00167BD0 File Offset: 0x00165DD0
		public static RecallRouletteFunc? GetConfig(int p0FunctionId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRecallRouletteFuncByFunctionId.HandleId, ConfigRecallRouletteFuncByFunctionId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecallRouletteFuncByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RecallRouletteFunc?(RecallRouletteFunc.GetRootAsRecallRouletteFunc(configBuffer));
				}
			}
			ConfigRecallRouletteFuncByFunctionId.LogPair.Clear();
			ConfigRecallRouletteFuncByFunctionId.LogPair.Add(new ValueTuple<string, object>("FunctionId", p0FunctionId));
			if (!ConfigCommon.BindInt(ConfigRecallRouletteFuncByFunctionId.HandleId, 1, p0FunctionId, ConfigRecallRouletteFuncByFunctionId.LogPair) || ConfigCommon.Step(ConfigRecallRouletteFuncByFunctionId.HandleId, true, ConfigRecallRouletteFuncByFunctionId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRecallRouletteFuncByFunctionId.HandleId, ConfigRecallRouletteFuncByFunctionId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRecallRouletteFuncByFunctionId.HandleId, 0, ConfigRecallRouletteFuncByFunctionId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRecallRouletteFuncByFunctionId.HandleId, ConfigRecallRouletteFuncByFunctionId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RecallRouletteFunc rootAsRecallRouletteFunc = RecallRouletteFunc.GetRootAsRecallRouletteFunc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecallRouletteFuncByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRecallRouletteFuncByFunctionId.HandleId, ConfigRecallRouletteFuncByFunctionId.LogPair);
			return new RecallRouletteFunc?(rootAsRecallRouletteFunc);
		}

		// Token: 0x040036E3 RID: 14051
		private const string DB = "db_questrecall.db";

		// Token: 0x040036E4 RID: 14052
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x040036E5 RID: 14053
		private const string TABLE = "RecallRouletteFunc";

		// Token: 0x040036E6 RID: 14054
		private const string COMMAND = "select BinData from `RecallRouletteFunc` where FunctionId=?";

		// Token: 0x040036E7 RID: 14055
		private const string KEY_PREFIX = "RecallRouletteFuncByFunctionId";

		// Token: 0x040036E8 RID: 14056
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036E9 RID: 14057
		private static int HandleId;
	}
}
