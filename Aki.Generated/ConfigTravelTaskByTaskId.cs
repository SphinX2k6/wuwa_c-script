using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4E RID: 2638
	public class ConfigTravelTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DE8 RID: 15848 RVA: 0x001B7F47 File Offset: 0x001B6147
		static ConfigTravelTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigTravelTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x001B7F68 File Offset: 0x001B6168
		public static void CreateStaticDefaultValue()
		{
			ConfigTravelTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTravelTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "TravelTask"),
				new ValueTuple<string, object>("语句", "select BinData from `TravelTask` where TaskId=?")
			});
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x001B7FE7 File Offset: 0x001B61E7
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelTaskByTaskId.LogPair = null;
			ConfigTravelTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x001B7FF5 File Offset: 0x001B61F5
		public static void Init()
		{
			ConfigTravelTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigTravelTaskByTaskId.HandleId, "db_activitymaptravel.db", "select BinData from `TravelTask` where TaskId=?");
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x001B8010 File Offset: 0x001B6210
		public static TravelTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTravelTaskByTaskId.HandleId, ConfigTravelTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TravelTask?(TravelTask.GetRootAsTravelTask(configBuffer));
				}
			}
			ConfigTravelTaskByTaskId.LogPair.Clear();
			ConfigTravelTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigTravelTaskByTaskId.HandleId, 1, p0TaskId, ConfigTravelTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigTravelTaskByTaskId.HandleId, true, ConfigTravelTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTravelTaskByTaskId.HandleId, ConfigTravelTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTravelTaskByTaskId.HandleId, 0, ConfigTravelTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTravelTaskByTaskId.HandleId, ConfigTravelTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TravelTask rootAsTravelTask = TravelTask.GetRootAsTravelTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTravelTaskByTaskId.HandleId, ConfigTravelTaskByTaskId.LogPair);
			return new TravelTask?(rootAsTravelTask);
		}

		// Token: 0x04004808 RID: 18440
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04004809 RID: 18441
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x0400480A RID: 18442
		private const string TABLE = "TravelTask";

		// Token: 0x0400480B RID: 18443
		private const string COMMAND = "select BinData from `TravelTask` where TaskId=?";

		// Token: 0x0400480C RID: 18444
		private const string KEY_PREFIX = "TravelTaskByTaskId";

		// Token: 0x0400480D RID: 18445
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400480E RID: 18446
		private static int HandleId;
	}
}
