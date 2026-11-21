using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B23 RID: 2851
	public class ConfigTravelTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042E6 RID: 17126 RVA: 0x001D72DB File Offset: 0x001D54DB
		static ConfigTravelTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigTravelTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x001D72FC File Offset: 0x001D54FC
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

		// Token: 0x060042E8 RID: 17128 RVA: 0x001D737B File Offset: 0x001D557B
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelTaskByTaskId.LogPair = null;
			ConfigTravelTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x001D7389 File Offset: 0x001D5589
		public static void Init()
		{
			ConfigTravelTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigTravelTaskByTaskId.HandleId, "db_activitymaptravel.db", "select BinData from `TravelTask` where TaskId=?");
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x001D73A4 File Offset: 0x001D55A4
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

		// Token: 0x04004DDB RID: 19931
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04004DDC RID: 19932
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04004DDD RID: 19933
		private const string TABLE = "TravelTask";

		// Token: 0x04004DDE RID: 19934
		private const string COMMAND = "select BinData from `TravelTask` where TaskId=?";

		// Token: 0x04004DDF RID: 19935
		private const string KEY_PREFIX = "TravelTaskByTaskId";

		// Token: 0x04004DE0 RID: 19936
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DE1 RID: 19937
		private static int HandleId;
	}
}
