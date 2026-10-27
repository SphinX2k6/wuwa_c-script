using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BE RID: 1982
	public class ConfigRecallEntityByRecallId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E86 RID: 11910 RVA: 0x001605D9 File Offset: 0x0015E7D9
		static ConfigRecallEntityByRecallId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallEntityByRecallId.CreateStaticDefaultValue), new Action(ConfigRecallEntityByRecallId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x001605F8 File Offset: 0x0015E7F8
		public static void CreateStaticDefaultValue()
		{
			ConfigRecallEntityByRecallId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRecallEntityByRecallId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questrecall.db"),
				new ValueTuple<string, object>("文件", "r.任务回顾.xlsx"),
				new ValueTuple<string, object>("表名", "RecallEntity"),
				new ValueTuple<string, object>("语句", "select BinData from `RecallEntity` where RecallId=?")
			});
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x00160677 File Offset: 0x0015E877
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallEntityByRecallId.LogPair = null;
			ConfigRecallEntityByRecallId.HandleId = 0;
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00160685 File Offset: 0x0015E885
		public static void Init()
		{
			ConfigRecallEntityByRecallId.HandleId = ConfigCommon.InitDataStatement(ConfigRecallEntityByRecallId.HandleId, "db_questrecall.db", "select BinData from `RecallEntity` where RecallId=?");
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x001606A0 File Offset: 0x0015E8A0
		public static RecallEntity? GetConfig(int p0RecallId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRecallEntityByRecallId.HandleId, ConfigRecallEntityByRecallId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecallEntityByRecallId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RecallId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RecallEntity?(RecallEntity.GetRootAsRecallEntity(configBuffer));
				}
			}
			ConfigRecallEntityByRecallId.LogPair.Clear();
			ConfigRecallEntityByRecallId.LogPair.Add(new ValueTuple<string, object>("RecallId", p0RecallId));
			if (!ConfigCommon.BindInt(ConfigRecallEntityByRecallId.HandleId, 1, p0RecallId, ConfigRecallEntityByRecallId.LogPair) || ConfigCommon.Step(ConfigRecallEntityByRecallId.HandleId, true, ConfigRecallEntityByRecallId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRecallEntityByRecallId.HandleId, ConfigRecallEntityByRecallId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRecallEntityByRecallId.HandleId, 0, ConfigRecallEntityByRecallId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRecallEntityByRecallId.HandleId, ConfigRecallEntityByRecallId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RecallEntity rootAsRecallEntity = RecallEntity.GetRootAsRecallEntity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecallEntityByRecallId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RecallId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRecallEntityByRecallId.HandleId, ConfigRecallEntityByRecallId.LogPair);
			return new RecallEntity?(rootAsRecallEntity);
		}

		// Token: 0x04003618 RID: 13848
		private const string DB = "db_questrecall.db";

		// Token: 0x04003619 RID: 13849
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x0400361A RID: 13850
		private const string TABLE = "RecallEntity";

		// Token: 0x0400361B RID: 13851
		private const string COMMAND = "select BinData from `RecallEntity` where RecallId=?";

		// Token: 0x0400361C RID: 13852
		private const string KEY_PREFIX = "RecallEntityByRecallId";

		// Token: 0x0400361D RID: 13853
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400361E RID: 13854
		private static int HandleId;
	}
}
