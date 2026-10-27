using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000292 RID: 658
	public class ConfigExploreActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F71 RID: 3953 RVA: 0x000B0D44 File Offset: 0x000AEF44
		static ConfigExploreActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreActivityById.CreateStaticDefaultValue), new Action(ConfigExploreActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x000B0D64 File Offset: 0x000AEF64
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

		// Token: 0x06000F73 RID: 3955 RVA: 0x000B0DE3 File Offset: 0x000AEFE3
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreActivityById.LogPair = null;
			ConfigExploreActivityById.HandleId = 0;
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x000B0DF1 File Offset: 0x000AEFF1
		public static void Init()
		{
			ConfigExploreActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreActivityById.HandleId, "db_exploreactivity.db", "select BinData from `ExploreActivity` where Id=?");
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000B0E0C File Offset: 0x000AF00C
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

		// Token: 0x040011E2 RID: 4578
		private const string DB = "db_exploreactivity.db";

		// Token: 0x040011E3 RID: 4579
		private const string FILE = "t.探索度活动.xlsx";

		// Token: 0x040011E4 RID: 4580
		private const string TABLE = "ExploreActivity";

		// Token: 0x040011E5 RID: 4581
		private const string COMMAND = "select BinData from `ExploreActivity` where Id=?";

		// Token: 0x040011E6 RID: 4582
		private const string KEY_PREFIX = "ExploreActivityById";

		// Token: 0x040011E7 RID: 4583
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011E8 RID: 4584
		private static int HandleId;
	}
}
