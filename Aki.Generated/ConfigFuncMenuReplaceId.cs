using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036B RID: 875
	public class ConfigFuncMenuReplaceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001487 RID: 5255 RVA: 0x000D10FB File Offset: 0x000CF2FB
		static ConfigFuncMenuReplaceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFuncMenuReplaceId.CreateStaticDefaultValue), new Action(ConfigFuncMenuReplaceId.ResetStaticDefaultValue));
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x000D111C File Offset: 0x000CF31C
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

		// Token: 0x06001489 RID: 5257 RVA: 0x000D119B File Offset: 0x000CF39B
		public static void ResetStaticDefaultValue()
		{
			ConfigFuncMenuReplaceId.LogPair = null;
			ConfigFuncMenuReplaceId.HandleId = 0;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x000D11A9 File Offset: 0x000CF3A9
		public static void Init()
		{
			ConfigFuncMenuReplaceId.HandleId = ConfigCommon.InitDataStatement(ConfigFuncMenuReplaceId.HandleId, "db_roulette.db", "select BinData from `FuncMenuReplace` where Id=?");
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000D11C4 File Offset: 0x000CF3C4
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

		// Token: 0x040017D1 RID: 6097
		private const string DB = "db_roulette.db";

		// Token: 0x040017D2 RID: 6098
		private const string FILE = "l.轮盘.xlsx";

		// Token: 0x040017D3 RID: 6099
		private const string TABLE = "FuncMenuReplace";

		// Token: 0x040017D4 RID: 6100
		private const string COMMAND = "select BinData from `FuncMenuReplace` where Id=?";

		// Token: 0x040017D5 RID: 6101
		private const string KEY_PREFIX = "FuncMenuReplaceId";

		// Token: 0x040017D6 RID: 6102
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017D7 RID: 6103
		private static int HandleId;
	}
}
