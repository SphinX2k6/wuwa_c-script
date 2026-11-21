using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D8 RID: 2008
	public class ConfigRecallEntityByRecallId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F22 RID: 12066 RVA: 0x001674E5 File Offset: 0x001656E5
		static ConfigRecallEntityByRecallId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallEntityByRecallId.CreateStaticDefaultValue), new Action(ConfigRecallEntityByRecallId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x00167504 File Offset: 0x00165704
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

		// Token: 0x06002F24 RID: 12068 RVA: 0x00167583 File Offset: 0x00165783
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallEntityByRecallId.LogPair = null;
			ConfigRecallEntityByRecallId.HandleId = 0;
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00167591 File Offset: 0x00165791
		public static void Init()
		{
			ConfigRecallEntityByRecallId.HandleId = ConfigCommon.InitDataStatement(ConfigRecallEntityByRecallId.HandleId, "db_questrecall.db", "select BinData from `RecallEntity` where RecallId=?");
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x001675AC File Offset: 0x001657AC
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

		// Token: 0x040036CE RID: 14030
		private const string DB = "db_questrecall.db";

		// Token: 0x040036CF RID: 14031
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x040036D0 RID: 14032
		private const string TABLE = "RecallEntity";

		// Token: 0x040036D1 RID: 14033
		private const string COMMAND = "select BinData from `RecallEntity` where RecallId=?";

		// Token: 0x040036D2 RID: 14034
		private const string KEY_PREFIX = "RecallEntityByRecallId";

		// Token: 0x040036D3 RID: 14035
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036D4 RID: 14036
		private static int HandleId;
	}
}
