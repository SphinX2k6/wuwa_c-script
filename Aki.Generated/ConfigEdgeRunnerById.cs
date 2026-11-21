using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025D RID: 605
	public class ConfigEdgeRunnerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E32 RID: 3634 RVA: 0x000AD454 File Offset: 0x000AB654
		static ConfigEdgeRunnerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x000AD474 File Offset: 0x000AB674
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

		// Token: 0x06000E34 RID: 3636 RVA: 0x000AD4F3 File Offset: 0x000AB6F3
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerById.LogPair = null;
			ConfigEdgeRunnerById.HandleId = 0;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000AD501 File Offset: 0x000AB701
		public static void Init()
		{
			ConfigEdgeRunnerById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunner` where Id=?");
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000AD51C File Offset: 0x000AB71C
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

		// Token: 0x0400106F RID: 4207
		private const string DB = "db_edgerunner.db";

		// Token: 0x04001070 RID: 4208
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04001071 RID: 4209
		private const string TABLE = "EdgeRunner";

		// Token: 0x04001072 RID: 4210
		private const string COMMAND = "select BinData from `EdgeRunner` where Id=?";

		// Token: 0x04001073 RID: 4211
		private const string KEY_PREFIX = "EdgeRunnerById";

		// Token: 0x04001074 RID: 4212
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001075 RID: 4213
		private static int HandleId;
	}
}
