using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024B RID: 587
	public class ConfigEdgeRunnerLordGymById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DC6 RID: 3526 RVA: 0x000A760F File Offset: 0x000A580F
		static ConfigEdgeRunnerLordGymById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerLordGymById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerLordGymById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x000A7630 File Offset: 0x000A5830
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerLordGymById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerLordGymById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerLordGym"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerLordGym` where Id=?")
			});
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x000A76AF File Offset: 0x000A58AF
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerLordGymById.LogPair = null;
			ConfigEdgeRunnerLordGymById.HandleId = 0;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x000A76BD File Offset: 0x000A58BD
		public static void Init()
		{
			ConfigEdgeRunnerLordGymById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerLordGymById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerLordGym` where Id=?");
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x000A76D8 File Offset: 0x000A58D8
		public static EdgeRunnerLordGym? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerLordGymById.HandleId, ConfigEdgeRunnerLordGymById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerLordGymById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EdgeRunnerLordGym?(EdgeRunnerLordGym.GetRootAsEdgeRunnerLordGym(configBuffer));
				}
			}
			ConfigEdgeRunnerLordGymById.LogPair.Clear();
			ConfigEdgeRunnerLordGymById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEdgeRunnerLordGymById.HandleId, 1, p0Id, ConfigEdgeRunnerLordGymById.LogPair) || ConfigCommon.Step(ConfigEdgeRunnerLordGymById.HandleId, true, ConfigEdgeRunnerLordGymById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerLordGymById.HandleId, ConfigEdgeRunnerLordGymById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerLordGymById.HandleId, 0, ConfigEdgeRunnerLordGymById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerLordGymById.HandleId, ConfigEdgeRunnerLordGymById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EdgeRunnerLordGym rootAsEdgeRunnerLordGym = EdgeRunnerLordGym.GetRootAsEdgeRunnerLordGym(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerLordGymById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerLordGymById.HandleId, ConfigEdgeRunnerLordGymById.LogPair);
			return new EdgeRunnerLordGym?(rootAsEdgeRunnerLordGym);
		}

		// Token: 0x04000FF1 RID: 4081
		private const string DB = "db_edgerunner.db";

		// Token: 0x04000FF2 RID: 4082
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04000FF3 RID: 4083
		private const string TABLE = "EdgeRunnerLordGym";

		// Token: 0x04000FF4 RID: 4084
		private const string COMMAND = "select BinData from `EdgeRunnerLordGym` where Id=?";

		// Token: 0x04000FF5 RID: 4085
		private const string KEY_PREFIX = "EdgeRunnerLordGymById";

		// Token: 0x04000FF6 RID: 4086
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FF7 RID: 4087
		private static int HandleId;
	}
}
