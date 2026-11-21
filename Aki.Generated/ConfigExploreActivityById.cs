using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A6 RID: 678
	public class ConfigExploreActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FE9 RID: 4073 RVA: 0x000B7008 File Offset: 0x000B5208
		static ConfigExploreActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreActivityById.CreateStaticDefaultValue), new Action(ConfigExploreActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x000B7028 File Offset: 0x000B5228
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_exploreactivity.db"),
				new ValueTuple<string, object>("文件", "t.探索度活动.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreActivity` where Id=?")
			});
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x000B70A7 File Offset: 0x000B52A7
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreActivityById.LogPair = null;
			ConfigExploreActivityById.HandleId = 0;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x000B70B5 File Offset: 0x000B52B5
		public static void Init()
		{
			ConfigExploreActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreActivityById.HandleId, "db_exploreactivity.db", "select BinData from `ExploreActivity` where Id=?");
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x000B70D0 File Offset: 0x000B52D0
		public static ExploreActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreActivityById.HandleId, ConfigExploreActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreActivity?(ExploreActivity.GetRootAsExploreActivity(configBuffer));
				}
			}
			ConfigExploreActivityById.LogPair.Clear();
			ConfigExploreActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExploreActivityById.HandleId, 1, p0Id, ConfigExploreActivityById.LogPair) || ConfigCommon.Step(ConfigExploreActivityById.HandleId, true, ConfigExploreActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreActivityById.HandleId, ConfigExploreActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreActivityById.HandleId, 0, ConfigExploreActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreActivityById.HandleId, ConfigExploreActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreActivity rootAsExploreActivity = ExploreActivity.GetRootAsExploreActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreActivityById.HandleId, ConfigExploreActivityById.LogPair);
			return new ExploreActivity?(rootAsExploreActivity);
		}

		// Token: 0x0400126E RID: 4718
		private const string DB = "db_exploreactivity.db";

		// Token: 0x0400126F RID: 4719
		private const string FILE = "t.探索度活动.xlsx";

		// Token: 0x04001270 RID: 4720
		private const string TABLE = "ExploreActivity";

		// Token: 0x04001271 RID: 4721
		private const string COMMAND = "select BinData from `ExploreActivity` where Id=?";

		// Token: 0x04001272 RID: 4722
		private const string KEY_PREFIX = "ExploreActivityById";

		// Token: 0x04001273 RID: 4723
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001274 RID: 4724
		private static int HandleId;
	}
}
