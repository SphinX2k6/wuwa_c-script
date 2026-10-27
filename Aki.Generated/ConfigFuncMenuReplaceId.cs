using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000356 RID: 854
	public class ConfigFuncMenuReplaceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001409 RID: 5129 RVA: 0x000CABEF File Offset: 0x000C8DEF
		static ConfigFuncMenuReplaceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFuncMenuReplaceId.CreateStaticDefaultValue), new Action(ConfigFuncMenuReplaceId.ResetStaticDefaultValue));
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x000CAC10 File Offset: 0x000C8E10
		public static void CreateStaticDefaultValue()
		{
			ConfigFuncMenuReplaceId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFuncMenuReplaceId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roulette.db"),
				new ValueTuple<string, object>("文件", "l.轮盘.xlsx"),
				new ValueTuple<string, object>("表名", "FuncMenuReplace"),
				new ValueTuple<string, object>("语句", "select BinData from `FuncMenuReplace` where Id=?")
			});
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x000CAC8F File Offset: 0x000C8E8F
		public static void ResetStaticDefaultValue()
		{
			ConfigFuncMenuReplaceId.LogPair = null;
			ConfigFuncMenuReplaceId.HandleId = 0;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x000CAC9D File Offset: 0x000C8E9D
		public static void Init()
		{
			ConfigFuncMenuReplaceId.HandleId = ConfigCommon.InitDataStatement(ConfigFuncMenuReplaceId.HandleId, "db_roulette.db", "select BinData from `FuncMenuReplace` where Id=?");
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x000CACB8 File Offset: 0x000C8EB8
		public static FuncMenuReplace? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFuncMenuReplaceId.HandleId, ConfigFuncMenuReplaceId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FuncMenuReplaceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FuncMenuReplace?(FuncMenuReplace.GetRootAsFuncMenuReplace(configBuffer));
				}
			}
			ConfigFuncMenuReplaceId.LogPair.Clear();
			ConfigFuncMenuReplaceId.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFuncMenuReplaceId.HandleId, 1, p0Id, ConfigFuncMenuReplaceId.LogPair) || ConfigCommon.Step(ConfigFuncMenuReplaceId.HandleId, true, ConfigFuncMenuReplaceId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFuncMenuReplaceId.HandleId, ConfigFuncMenuReplaceId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFuncMenuReplaceId.HandleId, 0, ConfigFuncMenuReplaceId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFuncMenuReplaceId.HandleId, ConfigFuncMenuReplaceId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FuncMenuReplace rootAsFuncMenuReplace = FuncMenuReplace.GetRootAsFuncMenuReplace(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FuncMenuReplaceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFuncMenuReplaceId.HandleId, ConfigFuncMenuReplaceId.LogPair);
			return new FuncMenuReplace?(rootAsFuncMenuReplace);
		}

		// Token: 0x0400173E RID: 5950
		private const string DB = "db_roulette.db";

		// Token: 0x0400173F RID: 5951
		private const string FILE = "l.轮盘.xlsx";

		// Token: 0x04001740 RID: 5952
		private const string TABLE = "FuncMenuReplace";

		// Token: 0x04001741 RID: 5953
		private const string COMMAND = "select BinData from `FuncMenuReplace` where Id=?";

		// Token: 0x04001742 RID: 5954
		private const string KEY_PREFIX = "FuncMenuReplaceId";

		// Token: 0x04001743 RID: 5955
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001744 RID: 5956
		private static int HandleId;
	}
}
