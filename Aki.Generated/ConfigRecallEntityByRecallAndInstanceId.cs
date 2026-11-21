using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D7 RID: 2007
	public class ConfigRecallEntityByRecallAndInstanceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F1C RID: 12060 RVA: 0x00167247 File Offset: 0x00165447
		static ConfigRecallEntityByRecallAndInstanceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallEntityByRecallAndInstanceId.CreateStaticDefaultValue), new Action(ConfigRecallEntityByRecallAndInstanceId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x00167268 File Offset: 0x00165468
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

		// Token: 0x06002F1E RID: 12062 RVA: 0x001672E7 File Offset: 0x001654E7
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallEntityByRecallAndInstanceId.LogPair = null;
			ConfigRecallEntityByRecallAndInstanceId.HandleId = 0;
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x001672F5 File Offset: 0x001654F5
		public static void Init()
		{
			ConfigRecallEntityByRecallAndInstanceId.HandleId = ConfigCommon.InitDataStatement(ConfigRecallEntityByRecallAndInstanceId.HandleId, "db_questrecall.db", "select BinData from `RecallEntity` where RecallId=? AND InstanceId=?");
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x00167310 File Offset: 0x00165510
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

		// Token: 0x040036C7 RID: 14023
		private const string DB = "db_questrecall.db";

		// Token: 0x040036C8 RID: 14024
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x040036C9 RID: 14025
		private const string TABLE = "RecallEntity";

		// Token: 0x040036CA RID: 14026
		private const string COMMAND = "select BinData from `RecallEntity` where RecallId=? AND InstanceId=?";

		// Token: 0x040036CB RID: 14027
		private const string KEY_PREFIX = "RecallEntityByRecallAndInstanceId";

		// Token: 0x040036CC RID: 14028
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036CD RID: 14029
		private static int HandleId;
	}
}
