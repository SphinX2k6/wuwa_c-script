using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000249 RID: 585
	public class ConfigEdgeRunnerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DBA RID: 3514 RVA: 0x000A7190 File Offset: 0x000A5390
		static ConfigEdgeRunnerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x000A71B0 File Offset: 0x000A53B0
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunner"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunner` where Id=?")
			});
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000A722F File Offset: 0x000A542F
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerById.LogPair = null;
			ConfigEdgeRunnerById.HandleId = 0;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000A723D File Offset: 0x000A543D
		public static void Init()
		{
			ConfigEdgeRunnerById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunner` where Id=?");
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x000A7258 File Offset: 0x000A5458
		public static EdgeRunner? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerById.HandleId, ConfigEdgeRunnerById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EdgeRunner?(EdgeRunner.GetRootAsEdgeRunner(configBuffer));
				}
			}
			ConfigEdgeRunnerById.LogPair.Clear();
			ConfigEdgeRunnerById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEdgeRunnerById.HandleId, 1, p0Id, ConfigEdgeRunnerById.LogPair) || ConfigCommon.Step(ConfigEdgeRunnerById.HandleId, true, ConfigEdgeRunnerById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerById.HandleId, ConfigEdgeRunnerById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerById.HandleId, 0, ConfigEdgeRunnerById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerById.HandleId, ConfigEdgeRunnerById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EdgeRunner rootAsEdgeRunner = EdgeRunner.GetRootAsEdgeRunner(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerById.HandleId, ConfigEdgeRunnerById.LogPair);
			return new EdgeRunner?(rootAsEdgeRunner);
		}

		// Token: 0x04000FE3 RID: 4067
		private const string DB = "db_edgerunner.db";

		// Token: 0x04000FE4 RID: 4068
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04000FE5 RID: 4069
		private const string TABLE = "EdgeRunner";

		// Token: 0x04000FE6 RID: 4070
		private const string COMMAND = "select BinData from `EdgeRunner` where Id=?";

		// Token: 0x04000FE7 RID: 4071
		private const string KEY_PREFIX = "EdgeRunnerById";

		// Token: 0x04000FE8 RID: 4072
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FE9 RID: 4073
		private static int HandleId;
	}
}
