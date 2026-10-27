using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000357 RID: 855
	public class ConfigFuncMenuReplaceInstSubType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600140F RID: 5135 RVA: 0x000CAE38 File Offset: 0x000C9038
		static ConfigFuncMenuReplaceInstSubType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFuncMenuReplaceInstSubType.CreateStaticDefaultValue), new Action(ConfigFuncMenuReplaceInstSubType.ResetStaticDefaultValue));
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x000CAE58 File Offset: 0x000C9058
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

		// Token: 0x06001411 RID: 5137 RVA: 0x000CAED7 File Offset: 0x000C90D7
		public static void ResetStaticDefaultValue()
		{
			ConfigFuncMenuReplaceInstSubType.LogPair = null;
			ConfigFuncMenuReplaceInstSubType.HandleId = 0;
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x000CAEE5 File Offset: 0x000C90E5
		public static void Init()
		{
			ConfigFuncMenuReplaceInstSubType.HandleId = ConfigCommon.InitDataStatement(ConfigFuncMenuReplaceInstSubType.HandleId, "db_roulette.db", "select BinData from `FuncMenuReplace` where InstSubType=?");
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x000CAF00 File Offset: 0x000C9100
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

		// Token: 0x04001745 RID: 5957
		private const string DB = "db_roulette.db";

		// Token: 0x04001746 RID: 5958
		private const string FILE = "l.轮盘.xlsx";

		// Token: 0x04001747 RID: 5959
		private const string TABLE = "FuncMenuReplace";

		// Token: 0x04001748 RID: 5960
		private const string COMMAND = "select BinData from `FuncMenuReplace` where InstSubType=?";

		// Token: 0x04001749 RID: 5961
		private const string KEY_PREFIX = "FuncMenuReplaceInstSubType";

		// Token: 0x0400174A RID: 5962
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400174B RID: 5963
		private static int HandleId;
	}
}
