using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036E RID: 878
	public class ConfigFuncMenuWheelByFuncId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001499 RID: 5273 RVA: 0x000D171F File Offset: 0x000CF91F
		static ConfigFuncMenuWheelByFuncId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFuncMenuWheelByFuncId.CreateStaticDefaultValue), new Action(ConfigFuncMenuWheelByFuncId.ResetStaticDefaultValue));
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x000D1740 File Offset: 0x000CF940
		public static void CreateStaticDefaultValue()
		{
			ConfigFuncMenuWheelByFuncId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFuncMenuWheelByFuncId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roulette.db"),
				new ValueTuple<string, object>("文件", "l.轮盘.xlsx"),
				new ValueTuple<string, object>("表名", "FuncMenuWheel"),
				new ValueTuple<string, object>("语句", "select BinData from `FuncMenuWheel` where FuncId=?")
			});
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x000D17BF File Offset: 0x000CF9BF
		public static void ResetStaticDefaultValue()
		{
			ConfigFuncMenuWheelByFuncId.LogPair = null;
			ConfigFuncMenuWheelByFuncId.HandleId = 0;
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x000D17CD File Offset: 0x000CF9CD
		public static void Init()
		{
			ConfigFuncMenuWheelByFuncId.HandleId = ConfigCommon.InitDataStatement(ConfigFuncMenuWheelByFuncId.HandleId, "db_roulette.db", "select BinData from `FuncMenuWheel` where FuncId=?");
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x000D17E8 File Offset: 0x000CF9E8
		public static FuncMenuWheel? GetConfig(int p0FuncId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFuncMenuWheelByFuncId.HandleId, ConfigFuncMenuWheelByFuncId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FuncMenuWheelByFuncId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FuncId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FuncMenuWheel?(FuncMenuWheel.GetRootAsFuncMenuWheel(configBuffer));
				}
			}
			ConfigFuncMenuWheelByFuncId.LogPair.Clear();
			ConfigFuncMenuWheelByFuncId.LogPair.Add(new ValueTuple<string, object>("FuncId", p0FuncId));
			if (!ConfigCommon.BindInt(ConfigFuncMenuWheelByFuncId.HandleId, 1, p0FuncId, ConfigFuncMenuWheelByFuncId.LogPair) || ConfigCommon.Step(ConfigFuncMenuWheelByFuncId.HandleId, true, ConfigFuncMenuWheelByFuncId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFuncMenuWheelByFuncId.HandleId, ConfigFuncMenuWheelByFuncId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFuncMenuWheelByFuncId.HandleId, 0, ConfigFuncMenuWheelByFuncId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFuncMenuWheelByFuncId.HandleId, ConfigFuncMenuWheelByFuncId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FuncMenuWheel rootAsFuncMenuWheel = FuncMenuWheel.GetRootAsFuncMenuWheel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FuncMenuWheelByFuncId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FuncId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFuncMenuWheelByFuncId.HandleId, ConfigFuncMenuWheelByFuncId.LogPair);
			return new FuncMenuWheel?(rootAsFuncMenuWheel);
		}

		// Token: 0x040017E6 RID: 6118
		private const string DB = "db_roulette.db";

		// Token: 0x040017E7 RID: 6119
		private const string FILE = "l.轮盘.xlsx";

		// Token: 0x040017E8 RID: 6120
		private const string TABLE = "FuncMenuWheel";

		// Token: 0x040017E9 RID: 6121
		private const string COMMAND = "select BinData from `FuncMenuWheel` where FuncId=?";

		// Token: 0x040017EA RID: 6122
		private const string KEY_PREFIX = "FuncMenuWheelByFuncId";

		// Token: 0x040017EB RID: 6123
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017EC RID: 6124
		private static int HandleId;
	}
}
