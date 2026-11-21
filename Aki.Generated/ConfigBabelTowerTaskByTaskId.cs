using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000EC RID: 236
	public class ConfigBabelTowerTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x0007C7EB File Offset: 0x0007A9EB
		static ConfigBabelTowerTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigBabelTowerTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0007C80C File Offset: 0x0007AA0C
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

		// Token: 0x0600058B RID: 1419 RVA: 0x0007C88B File Offset: 0x0007AA8B
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerTaskByTaskId.LogPair = null;
			ConfigBabelTowerTaskByTaskId.HandleId = 0;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0007C899 File Offset: 0x0007AA99
		public static void Init()
		{
			ConfigBabelTowerTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerTaskByTaskId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerTask` where TaskId=?");
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0007C8B4 File Offset: 0x0007AAB4
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

		// Token: 0x04000658 RID: 1624
		private const string DB = "db_babeltower.db";

		// Token: 0x04000659 RID: 1625
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x0400065A RID: 1626
		private const string TABLE = "BabelTowerTask";

		// Token: 0x0400065B RID: 1627
		private const string COMMAND = "select BinData from `BabelTowerTask` where TaskId=?";

		// Token: 0x0400065C RID: 1628
		private const string KEY_PREFIX = "BabelTowerTaskByTaskId";

		// Token: 0x0400065D RID: 1629
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400065E RID: 1630
		private static int HandleId;
	}
}
