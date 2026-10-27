using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000814 RID: 2068
	public class ConfigRoadBookLevelExpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600308A RID: 12426 RVA: 0x0016BA43 File Offset: 0x00169C43
		static ConfigRoadBookLevelExpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookLevelExpById.CreateStaticDefaultValue), new Action(ConfigRoadBookLevelExpById.ResetStaticDefaultValue));
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x0016BA64 File Offset: 0x00169C64
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

		// Token: 0x0600308C RID: 12428 RVA: 0x0016BAE3 File Offset: 0x00169CE3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookLevelExpById.LogPair = null;
			ConfigRoadBookLevelExpById.HandleId = 0;
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x0016BAF1 File Offset: 0x00169CF1
		public static void Init()
		{
			ConfigRoadBookLevelExpById.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookLevelExpById.HandleId, "db_roadbook.db", "select BinData from `RoadBookLevelExp` where Id=?");
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x0016BB0C File Offset: 0x00169D0C
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

		// Token: 0x04003872 RID: 14450
		private const string DB = "db_roadbook.db";

		// Token: 0x04003873 RID: 14451
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04003874 RID: 14452
		private const string TABLE = "RoadBookLevelExp";

		// Token: 0x04003875 RID: 14453
		private const string COMMAND = "select BinData from `RoadBookLevelExp` where Id=?";

		// Token: 0x04003876 RID: 14454
		private const string KEY_PREFIX = "RoadBookLevelExpById";

		// Token: 0x04003877 RID: 14455
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003878 RID: 14456
		private static int HandleId;
	}
}
