using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A4 RID: 164
	public class ConfigAreaFunctionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003D9 RID: 985 RVA: 0x0006F6B7 File Offset: 0x0006D8B7
		static ConfigAreaFunctionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaFunctionById.CreateStaticDefaultValue), new Action(ConfigAreaFunctionById.ResetStaticDefaultValue));
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0006F6D8 File Offset: 0x0006D8D8
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaFunctionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaFunctionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_areafunction.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/q.区域功能配置/*.csv*"),
				new ValueTuple<string, object>("表名", "AreaFunction"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaFunction` where Id=?")
			});
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0006F757 File Offset: 0x0006D957
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaFunctionById.LogPair = null;
			ConfigAreaFunctionById.HandleId = 0;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0006F765 File Offset: 0x0006D965
		public static void Init()
		{
			ConfigAreaFunctionById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaFunctionById.HandleId, "db_areafunction.db", "select BinData from `AreaFunction` where Id=?");
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0006F780 File Offset: 0x0006D980
		public static AreaFunction? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaFunctionById.HandleId, ConfigAreaFunctionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaFunctionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AreaFunction?(AreaFunction.GetRootAsAreaFunction(configBuffer));
				}
			}
			ConfigAreaFunctionById.LogPair.Clear();
			ConfigAreaFunctionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAreaFunctionById.HandleId, 1, p0Id, ConfigAreaFunctionById.LogPair) || ConfigCommon.Step(ConfigAreaFunctionById.HandleId, true, ConfigAreaFunctionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaFunctionById.HandleId, ConfigAreaFunctionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaFunctionById.HandleId, 0, ConfigAreaFunctionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaFunctionById.HandleId, ConfigAreaFunctionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AreaFunction rootAsAreaFunction = AreaFunction.GetRootAsAreaFunction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaFunctionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaFunctionById.HandleId, ConfigAreaFunctionById.LogPair);
			return new AreaFunction?(rootAsAreaFunction);
		}

		// Token: 0x04000460 RID: 1120
		private const string DB = "db_areafunction.db";

		// Token: 0x04000461 RID: 1121
		private const string FILE = "k.可视化编辑/c.Csv/q.区域功能配置/*.csv*";

		// Token: 0x04000462 RID: 1122
		private const string TABLE = "AreaFunction";

		// Token: 0x04000463 RID: 1123
		private const string COMMAND = "select BinData from `AreaFunction` where Id=?";

		// Token: 0x04000464 RID: 1124
		private const string KEY_PREFIX = "AreaFunctionById";

		// Token: 0x04000465 RID: 1125
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000466 RID: 1126
		private static int HandleId;
	}
}
