using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BD RID: 1981
	public class ConfigRecallEntityByRecallAndInstanceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E80 RID: 11904 RVA: 0x0016033B File Offset: 0x0015E53B
		static ConfigRecallEntityByRecallAndInstanceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallEntityByRecallAndInstanceId.CreateStaticDefaultValue), new Action(ConfigRecallEntityByRecallAndInstanceId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x0016035C File Offset: 0x0015E55C
		public static void CreateStaticDefaultValue()
		{
			ConfigRecallEntityByRecallAndInstanceId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRecallEntityByRecallAndInstanceId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questrecall.db"),
				new ValueTuple<string, object>("文件", "r.任务回顾.xlsx"),
				new ValueTuple<string, object>("表名", "RecallEntity"),
				new ValueTuple<string, object>("语句", "select BinData from `RecallEntity` where RecallId=? AND InstanceId=?")
			});
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x001603DB File Offset: 0x0015E5DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallEntityByRecallAndInstanceId.LogPair = null;
			ConfigRecallEntityByRecallAndInstanceId.HandleId = 0;
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x001603E9 File Offset: 0x0015E5E9
		public static void Init()
		{
			ConfigRecallEntityByRecallAndInstanceId.HandleId = ConfigCommon.InitDataStatement(ConfigRecallEntityByRecallAndInstanceId.HandleId, "db_questrecall.db", "select BinData from `RecallEntity` where RecallId=? AND InstanceId=?");
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00160404 File Offset: 0x0015E604
		public static RecallEntity? GetConfig(int p0RecallId, int p1InstanceId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRecallEntityByRecallAndInstanceId.HandleId, ConfigRecallEntityByRecallAndInstanceId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RecallEntityByRecallAndInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RecallId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InstanceId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RecallEntity?(RecallEntity.GetRootAsRecallEntity(configBuffer));
				}
			}
			ConfigRecallEntityByRecallAndInstanceId.LogPair.Clear();
			ConfigRecallEntityByRecallAndInstanceId.LogPair.Add(new ValueTuple<string, object>("RecallId", p0RecallId));
			ConfigRecallEntityByRecallAndInstanceId.LogPair.Add(new ValueTuple<string, object>("InstanceId", p1InstanceId));
			if (!ConfigCommon.BindInt(ConfigRecallEntityByRecallAndInstanceId.HandleId, 1, p0RecallId, ConfigRecallEntityByRecallAndInstanceId.LogPair) || !ConfigCommon.BindInt(ConfigRecallEntityByRecallAndInstanceId.HandleId, 2, p1InstanceId, ConfigRecallEntityByRecallAndInstanceId.LogPair) || ConfigCommon.Step(ConfigRecallEntityByRecallAndInstanceId.HandleId, true, ConfigRecallEntityByRecallAndInstanceId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRecallEntityByRecallAndInstanceId.HandleId, ConfigRecallEntityByRecallAndInstanceId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRecallEntityByRecallAndInstanceId.HandleId, 0, ConfigRecallEntityByRecallAndInstanceId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRecallEntityByRecallAndInstanceId.HandleId, ConfigRecallEntityByRecallAndInstanceId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RecallEntity rootAsRecallEntity = RecallEntity.GetRootAsRecallEntity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RecallEntityByRecallAndInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RecallId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InstanceId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRecallEntityByRecallAndInstanceId.HandleId, ConfigRecallEntityByRecallAndInstanceId.LogPair);
			return new RecallEntity?(rootAsRecallEntity);
		}

		// Token: 0x04003611 RID: 13841
		private const string DB = "db_questrecall.db";

		// Token: 0x04003612 RID: 13842
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x04003613 RID: 13843
		private const string TABLE = "RecallEntity";

		// Token: 0x04003614 RID: 13844
		private const string COMMAND = "select BinData from `RecallEntity` where RecallId=? AND InstanceId=?";

		// Token: 0x04003615 RID: 13845
		private const string KEY_PREFIX = "RecallEntityByRecallAndInstanceId";

		// Token: 0x04003616 RID: 13846
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003617 RID: 13847
		private static int HandleId;
	}
}
