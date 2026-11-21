using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036C RID: 876
	public class ConfigFuncMenuReplaceInstSubType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600148D RID: 5261 RVA: 0x000D1344 File Offset: 0x000CF544
		static ConfigFuncMenuReplaceInstSubType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFuncMenuReplaceInstSubType.CreateStaticDefaultValue), new Action(ConfigFuncMenuReplaceInstSubType.ResetStaticDefaultValue));
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x000D1364 File Offset: 0x000CF564
		public static void CreateStaticDefaultValue()
		{
			ConfigFuncMenuReplaceInstSubType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFuncMenuReplaceInstSubType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roulette.db"),
				new ValueTuple<string, object>("文件", "l.轮盘.xlsx"),
				new ValueTuple<string, object>("表名", "FuncMenuReplace"),
				new ValueTuple<string, object>("语句", "select BinData from `FuncMenuReplace` where InstSubType=?")
			});
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x000D13E3 File Offset: 0x000CF5E3
		public static void ResetStaticDefaultValue()
		{
			ConfigFuncMenuReplaceInstSubType.LogPair = null;
			ConfigFuncMenuReplaceInstSubType.HandleId = 0;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000D13F1 File Offset: 0x000CF5F1
		public static void Init()
		{
			ConfigFuncMenuReplaceInstSubType.HandleId = ConfigCommon.InitDataStatement(ConfigFuncMenuReplaceInstSubType.HandleId, "db_roulette.db", "select BinData from `FuncMenuReplace` where InstSubType=?");
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x000D140C File Offset: 0x000CF60C
		public static FuncMenuReplace? GetConfig(int p0InstSubType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFuncMenuReplaceInstSubType.HandleId, ConfigFuncMenuReplaceInstSubType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FuncMenuReplaceInstSubType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstSubType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FuncMenuReplace?(FuncMenuReplace.GetRootAsFuncMenuReplace(configBuffer));
				}
			}
			ConfigFuncMenuReplaceInstSubType.LogPair.Clear();
			ConfigFuncMenuReplaceInstSubType.LogPair.Add(new ValueTuple<string, object>("InstSubType", p0InstSubType));
			if (!ConfigCommon.BindInt(ConfigFuncMenuReplaceInstSubType.HandleId, 1, p0InstSubType, ConfigFuncMenuReplaceInstSubType.LogPair) || ConfigCommon.Step(ConfigFuncMenuReplaceInstSubType.HandleId, true, ConfigFuncMenuReplaceInstSubType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFuncMenuReplaceInstSubType.HandleId, ConfigFuncMenuReplaceInstSubType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFuncMenuReplaceInstSubType.HandleId, 0, ConfigFuncMenuReplaceInstSubType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFuncMenuReplaceInstSubType.HandleId, ConfigFuncMenuReplaceInstSubType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FuncMenuReplace rootAsFuncMenuReplace = FuncMenuReplace.GetRootAsFuncMenuReplace(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FuncMenuReplaceInstSubType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstSubType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFuncMenuReplaceInstSubType.HandleId, ConfigFuncMenuReplaceInstSubType.LogPair);
			return new FuncMenuReplace?(rootAsFuncMenuReplace);
		}

		// Token: 0x040017D8 RID: 6104
		private const string DB = "db_roulette.db";

		// Token: 0x040017D9 RID: 6105
		private const string FILE = "l.轮盘.xlsx";

		// Token: 0x040017DA RID: 6106
		private const string TABLE = "FuncMenuReplace";

		// Token: 0x040017DB RID: 6107
		private const string COMMAND = "select BinData from `FuncMenuReplace` where InstSubType=?";

		// Token: 0x040017DC RID: 6108
		private const string KEY_PREFIX = "FuncMenuReplaceInstSubType";

		// Token: 0x040017DD RID: 6109
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017DE RID: 6110
		private static int HandleId;
	}
}
