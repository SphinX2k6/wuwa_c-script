using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025F RID: 607
	public class ConfigEdgeRunnerLordGymById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x000AD8D3 File Offset: 0x000ABAD3
		static ConfigEdgeRunnerLordGymById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerLordGymById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerLordGymById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x000AD8F4 File Offset: 0x000ABAF4
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

		// Token: 0x06000E40 RID: 3648 RVA: 0x000AD973 File Offset: 0x000ABB73
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerLordGymById.LogPair = null;
			ConfigEdgeRunnerLordGymById.HandleId = 0;
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x000AD981 File Offset: 0x000ABB81
		public static void Init()
		{
			ConfigEdgeRunnerLordGymById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerLordGymById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerLordGym` where Id=?");
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x000AD99C File Offset: 0x000ABB9C
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

		// Token: 0x0400107D RID: 4221
		private const string DB = "db_edgerunner.db";

		// Token: 0x0400107E RID: 4222
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x0400107F RID: 4223
		private const string TABLE = "EdgeRunnerLordGym";

		// Token: 0x04001080 RID: 4224
		private const string COMMAND = "select BinData from `EdgeRunnerLordGym` where Id=?";

		// Token: 0x04001081 RID: 4225
		private const string KEY_PREFIX = "EdgeRunnerLordGymById";

		// Token: 0x04001082 RID: 4226
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001083 RID: 4227
		private static int HandleId;
	}
}
