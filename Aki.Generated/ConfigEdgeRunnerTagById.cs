using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000250 RID: 592
	public class ConfigEdgeRunnerTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DE4 RID: 3556 RVA: 0x000A800F File Offset: 0x000A620F
		static ConfigEdgeRunnerTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerTagById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000A8030 File Offset: 0x000A6230
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

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000A80AF File Offset: 0x000A62AF
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerTagById.LogPair = null;
			ConfigEdgeRunnerTagById.HandleId = 0;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000A80BD File Offset: 0x000A62BD
		public static void Init()
		{
			ConfigEdgeRunnerTagById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerTagById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerTag` where Id=?");
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x000A80D8 File Offset: 0x000A62D8
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

		// Token: 0x04001014 RID: 4116
		private const string DB = "db_edgerunner.db";

		// Token: 0x04001015 RID: 4117
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04001016 RID: 4118
		private const string TABLE = "EdgeRunnerTag";

		// Token: 0x04001017 RID: 4119
		private const string COMMAND = "select BinData from `EdgeRunnerTag` where Id=?";

		// Token: 0x04001018 RID: 4120
		private const string KEY_PREFIX = "EdgeRunnerTagById";

		// Token: 0x04001019 RID: 4121
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400101A RID: 4122
		private static int HandleId;
	}
}
