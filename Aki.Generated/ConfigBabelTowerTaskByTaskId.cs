using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DD RID: 221
	public class ConfigBabelTowerTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x00076E87 File Offset: 0x00075087
		static ConfigBabelTowerTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigBabelTowerTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00076EA8 File Offset: 0x000750A8
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerTask"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerTask` where TaskId=?")
			});
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00076F27 File Offset: 0x00075127
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerTaskByTaskId.LogPair = null;
			ConfigBabelTowerTaskByTaskId.HandleId = 0;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00076F35 File Offset: 0x00075135
		public static void Init()
		{
			ConfigBabelTowerTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerTaskByTaskId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerTask` where TaskId=?");
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00076F50 File Offset: 0x00075150
		public static BabelTowerTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerTaskByTaskId.HandleId, ConfigBabelTowerTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerTask?(BabelTowerTask.GetRootAsBabelTowerTask(configBuffer));
				}
			}
			ConfigBabelTowerTaskByTaskId.LogPair.Clear();
			ConfigBabelTowerTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigBabelTowerTaskByTaskId.HandleId, 1, p0TaskId, ConfigBabelTowerTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigBabelTowerTaskByTaskId.HandleId, true, ConfigBabelTowerTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerTaskByTaskId.HandleId, ConfigBabelTowerTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerTaskByTaskId.HandleId, 0, ConfigBabelTowerTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerTaskByTaskId.HandleId, ConfigBabelTowerTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerTask rootAsBabelTowerTask = BabelTowerTask.GetRootAsBabelTowerTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerTaskByTaskId.HandleId, ConfigBabelTowerTaskByTaskId.LogPair);
			return new BabelTowerTask?(rootAsBabelTowerTask);
		}

		// Token: 0x040005EF RID: 1519
		private const string DB = "db_babeltower.db";

		// Token: 0x040005F0 RID: 1520
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005F1 RID: 1521
		private const string TABLE = "BabelTowerTask";

		// Token: 0x040005F2 RID: 1522
		private const string COMMAND = "select BinData from `BabelTowerTask` where TaskId=?";

		// Token: 0x040005F3 RID: 1523
		private const string KEY_PREFIX = "BabelTowerTaskByTaskId";

		// Token: 0x040005F4 RID: 1524
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005F5 RID: 1525
		private static int HandleId;
	}
}
