using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D2 RID: 722
	public class ConfigFishingActivityLimitTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010F1 RID: 4337 RVA: 0x000B9320 File Offset: 0x000B7520
		static ConfigFishingActivityLimitTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityLimitTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigFishingActivityLimitTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x000B9340 File Offset: 0x000B7540
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingActivityLimitTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingActivityLimitTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼大活动.xlsx"),
				new ValueTuple<string, object>("表名", "FishingActivityLimitTask"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingActivityLimitTask` where TaskId=?")
			});
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x000B93BF File Offset: 0x000B75BF
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityLimitTaskByTaskId.LogPair = null;
			ConfigFishingActivityLimitTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x000B93CD File Offset: 0x000B75CD
		public static void Init()
		{
			ConfigFishingActivityLimitTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityLimitTaskByTaskId.HandleId, "db_fishing.db", "select BinData from `FishingActivityLimitTask` where TaskId=?");
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x000B93E8 File Offset: 0x000B75E8
		public static FishingActivityLimitTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingActivityLimitTaskByTaskId.HandleId, ConfigFishingActivityLimitTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingActivityLimitTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingActivityLimitTask?(FishingActivityLimitTask.GetRootAsFishingActivityLimitTask(configBuffer));
				}
			}
			ConfigFishingActivityLimitTaskByTaskId.LogPair.Clear();
			ConfigFishingActivityLimitTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigFishingActivityLimitTaskByTaskId.HandleId, 1, p0TaskId, ConfigFishingActivityLimitTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigFishingActivityLimitTaskByTaskId.HandleId, true, ConfigFishingActivityLimitTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingActivityLimitTaskByTaskId.HandleId, ConfigFishingActivityLimitTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingActivityLimitTaskByTaskId.HandleId, 0, ConfigFishingActivityLimitTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingActivityLimitTaskByTaskId.HandleId, ConfigFishingActivityLimitTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingActivityLimitTask rootAsFishingActivityLimitTask = FishingActivityLimitTask.GetRootAsFishingActivityLimitTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingActivityLimitTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingActivityLimitTaskByTaskId.HandleId, ConfigFishingActivityLimitTaskByTaskId.LogPair);
			return new FishingActivityLimitTask?(rootAsFishingActivityLimitTask);
		}

		// Token: 0x040013A2 RID: 5026
		private const string DB = "db_fishing.db";

		// Token: 0x040013A3 RID: 5027
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x040013A4 RID: 5028
		private const string TABLE = "FishingActivityLimitTask";

		// Token: 0x040013A5 RID: 5029
		private const string COMMAND = "select BinData from `FishingActivityLimitTask` where TaskId=?";

		// Token: 0x040013A6 RID: 5030
		private const string KEY_PREFIX = "FishingActivityLimitTaskByTaskId";

		// Token: 0x040013A7 RID: 5031
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013A8 RID: 5032
		private static int HandleId;
	}
}
