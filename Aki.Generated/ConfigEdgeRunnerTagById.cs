using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000264 RID: 612
	public class ConfigEdgeRunnerTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E5C RID: 3676 RVA: 0x000AE2D3 File Offset: 0x000AC4D3
		static ConfigEdgeRunnerTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerTagById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000AE2F4 File Offset: 0x000AC4F4
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerTag"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerTag` where Id=?")
			});
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x000AE373 File Offset: 0x000AC573
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerTagById.LogPair = null;
			ConfigEdgeRunnerTagById.HandleId = 0;
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x000AE381 File Offset: 0x000AC581
		public static void Init()
		{
			ConfigEdgeRunnerTagById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerTagById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerTag` where Id=?");
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x000AE39C File Offset: 0x000AC59C
		public static EdgeRunnerTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerTagById.HandleId, ConfigEdgeRunnerTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EdgeRunnerTag?(EdgeRunnerTag.GetRootAsEdgeRunnerTag(configBuffer));
				}
			}
			ConfigEdgeRunnerTagById.LogPair.Clear();
			ConfigEdgeRunnerTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEdgeRunnerTagById.HandleId, 1, p0Id, ConfigEdgeRunnerTagById.LogPair) || ConfigCommon.Step(ConfigEdgeRunnerTagById.HandleId, true, ConfigEdgeRunnerTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerTagById.HandleId, ConfigEdgeRunnerTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerTagById.HandleId, 0, ConfigEdgeRunnerTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerTagById.HandleId, ConfigEdgeRunnerTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EdgeRunnerTag rootAsEdgeRunnerTag = EdgeRunnerTag.GetRootAsEdgeRunnerTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerTagById.HandleId, ConfigEdgeRunnerTagById.LogPair);
			return new EdgeRunnerTag?(rootAsEdgeRunnerTag);
		}

		// Token: 0x040010A0 RID: 4256
		private const string DB = "db_edgerunner.db";

		// Token: 0x040010A1 RID: 4257
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x040010A2 RID: 4258
		private const string TABLE = "EdgeRunnerTag";

		// Token: 0x040010A3 RID: 4259
		private const string COMMAND = "select BinData from `EdgeRunnerTag` where Id=?";

		// Token: 0x040010A4 RID: 4260
		private const string KEY_PREFIX = "EdgeRunnerTagById";

		// Token: 0x040010A5 RID: 4261
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010A6 RID: 4262
		private static int HandleId;
	}
}
