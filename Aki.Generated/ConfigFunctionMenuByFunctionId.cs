using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000371 RID: 881
	public class ConfigFunctionMenuByFunctionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014AB RID: 5291 RVA: 0x000D1D43 File Offset: 0x000CFF43
		static ConfigFunctionMenuByFunctionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunctionMenuByFunctionId.CreateStaticDefaultValue), new Action(ConfigFunctionMenuByFunctionId.ResetStaticDefaultValue));
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x000D1D64 File Offset: 0x000CFF64
		public static void CreateStaticDefaultValue()
		{
			ConfigFunctionMenuByFunctionId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFunctionMenuByFunctionId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_function.db"),
				new ValueTuple<string, object>("文件", "g.功能开启.xlsx"),
				new ValueTuple<string, object>("表名", "FunctionMenu"),
				new ValueTuple<string, object>("语句", "select BinData from `FunctionMenu` where FunctionId=?")
			});
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x000D1DE3 File Offset: 0x000CFFE3
		public static void ResetStaticDefaultValue()
		{
			ConfigFunctionMenuByFunctionId.LogPair = null;
			ConfigFunctionMenuByFunctionId.HandleId = 0;
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x000D1DF1 File Offset: 0x000CFFF1
		public static void Init()
		{
			ConfigFunctionMenuByFunctionId.HandleId = ConfigCommon.InitDataStatement(ConfigFunctionMenuByFunctionId.HandleId, "db_function.db", "select BinData from `FunctionMenu` where FunctionId=?");
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x000D1E0C File Offset: 0x000D000C
		public static FunctionMenu? GetConfig(int p0FunctionId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFunctionMenuByFunctionId.HandleId, ConfigFunctionMenuByFunctionId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FunctionMenuByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FunctionMenu?(FunctionMenu.GetRootAsFunctionMenu(configBuffer));
				}
			}
			ConfigFunctionMenuByFunctionId.LogPair.Clear();
			ConfigFunctionMenuByFunctionId.LogPair.Add(new ValueTuple<string, object>("FunctionId", p0FunctionId));
			if (!ConfigCommon.BindInt(ConfigFunctionMenuByFunctionId.HandleId, 1, p0FunctionId, ConfigFunctionMenuByFunctionId.LogPair) || ConfigCommon.Step(ConfigFunctionMenuByFunctionId.HandleId, true, ConfigFunctionMenuByFunctionId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFunctionMenuByFunctionId.HandleId, ConfigFunctionMenuByFunctionId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFunctionMenuByFunctionId.HandleId, 0, ConfigFunctionMenuByFunctionId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFunctionMenuByFunctionId.HandleId, ConfigFunctionMenuByFunctionId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FunctionMenu rootAsFunctionMenu = FunctionMenu.GetRootAsFunctionMenu(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FunctionMenuByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFunctionMenuByFunctionId.HandleId, ConfigFunctionMenuByFunctionId.LogPair);
			return new FunctionMenu?(rootAsFunctionMenu);
		}

		// Token: 0x040017FB RID: 6139
		private const string DB = "db_function.db";

		// Token: 0x040017FC RID: 6140
		private const string FILE = "g.功能开启.xlsx";

		// Token: 0x040017FD RID: 6141
		private const string TABLE = "FunctionMenu";

		// Token: 0x040017FE RID: 6142
		private const string COMMAND = "select BinData from `FunctionMenu` where FunctionId=?";

		// Token: 0x040017FF RID: 6143
		private const string KEY_PREFIX = "FunctionMenuByFunctionId";

		// Token: 0x04001800 RID: 6144
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001801 RID: 6145
		private static int HandleId;
	}
}
