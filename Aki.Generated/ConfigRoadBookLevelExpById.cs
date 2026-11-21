using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000830 RID: 2096
	public class ConfigRoadBookLevelExpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003132 RID: 12594 RVA: 0x00172D2B File Offset: 0x00170F2B
		static ConfigRoadBookLevelExpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookLevelExpById.CreateStaticDefaultValue), new Action(ConfigRoadBookLevelExpById.ResetStaticDefaultValue));
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x00172D4C File Offset: 0x00170F4C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadBookLevelExpById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadBookLevelExpById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "RoadBookLevelExp"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadBookLevelExp` where Id=?")
			});
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x00172DCB File Offset: 0x00170FCB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookLevelExpById.LogPair = null;
			ConfigRoadBookLevelExpById.HandleId = 0;
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x00172DD9 File Offset: 0x00170FD9
		public static void Init()
		{
			ConfigRoadBookLevelExpById.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookLevelExpById.HandleId, "db_roadbook.db", "select BinData from `RoadBookLevelExp` where Id=?");
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x00172DF4 File Offset: 0x00170FF4
		public static RoadBookLevelExp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadBookLevelExpById.HandleId, ConfigRoadBookLevelExpById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookLevelExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoadBookLevelExp?(RoadBookLevelExp.GetRootAsRoadBookLevelExp(configBuffer));
				}
			}
			ConfigRoadBookLevelExpById.LogPair.Clear();
			ConfigRoadBookLevelExpById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoadBookLevelExpById.HandleId, 1, p0Id, ConfigRoadBookLevelExpById.LogPair) || ConfigCommon.Step(ConfigRoadBookLevelExpById.HandleId, true, ConfigRoadBookLevelExpById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoadBookLevelExpById.HandleId, ConfigRoadBookLevelExpById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadBookLevelExpById.HandleId, 0, ConfigRoadBookLevelExpById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoadBookLevelExpById.HandleId, ConfigRoadBookLevelExpById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoadBookLevelExp rootAsRoadBookLevelExp = RoadBookLevelExp.GetRootAsRoadBookLevelExp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookLevelExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoadBookLevelExpById.HandleId, ConfigRoadBookLevelExpById.LogPair);
			return new RoadBookLevelExp?(rootAsRoadBookLevelExp);
		}

		// Token: 0x04003936 RID: 14646
		private const string DB = "db_roadbook.db";

		// Token: 0x04003937 RID: 14647
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04003938 RID: 14648
		private const string TABLE = "RoadBookLevelExp";

		// Token: 0x04003939 RID: 14649
		private const string COMMAND = "select BinData from `RoadBookLevelExp` where Id=?";

		// Token: 0x0400393A RID: 14650
		private const string KEY_PREFIX = "RoadBookLevelExpById";

		// Token: 0x0400393B RID: 14651
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400393C RID: 14652
		private static int HandleId;
	}
}
