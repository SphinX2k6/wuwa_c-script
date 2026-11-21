using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AC RID: 172
	public class ConfigAreaFunctionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000409 RID: 1033 RVA: 0x00073F6B File Offset: 0x0007216B
		static ConfigAreaFunctionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaFunctionById.CreateStaticDefaultValue), new Action(ConfigAreaFunctionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00073F8C File Offset: 0x0007218C
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

		// Token: 0x0600040B RID: 1035 RVA: 0x0007400B File Offset: 0x0007220B
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaFunctionById.LogPair = null;
			ConfigAreaFunctionById.HandleId = 0;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00074019 File Offset: 0x00072219
		public static void Init()
		{
			ConfigAreaFunctionById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaFunctionById.HandleId, "db_areafunction.db", "select BinData from `AreaFunction` where Id=?");
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00074034 File Offset: 0x00072234
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

		// Token: 0x04000498 RID: 1176
		private const string DB = "db_areafunction.db";

		// Token: 0x04000499 RID: 1177
		private const string FILE = "k.可视化编辑/c.Csv/q.区域功能配置/*.csv*";

		// Token: 0x0400049A RID: 1178
		private const string TABLE = "AreaFunction";

		// Token: 0x0400049B RID: 1179
		private const string COMMAND = "select BinData from `AreaFunction` where Id=?";

		// Token: 0x0400049C RID: 1180
		private const string KEY_PREFIX = "AreaFunctionById";

		// Token: 0x0400049D RID: 1181
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400049E RID: 1182
		private static int HandleId;
	}
}
