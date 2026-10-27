using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BB RID: 1979
	public class ConfigRecallConfigByRecallId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E74 RID: 11892 RVA: 0x0015FF60 File Offset: 0x0015E160
		static ConfigRecallConfigByRecallId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallConfigByRecallId.CreateStaticDefaultValue), new Action(ConfigRecallConfigByRecallId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x0015FF80 File Offset: 0x0015E180
		public static void CreateStaticDefaultValue()
		{
			ConfigRecallConfigByRecallId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRecallConfigByRecallId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questrecall.db"),
				new ValueTuple<string, object>("文件", "r.任务回顾.xlsx"),
				new ValueTuple<string, object>("表名", "RecallConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RecallConfig` where RecallId=?")
			});
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x0015FFFF File Offset: 0x0015E1FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallConfigByRecallId.LogPair = null;
			ConfigRecallConfigByRecallId.HandleId = 0;
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x0016000D File Offset: 0x0015E20D
		public static void Init()
		{
			ConfigRecallConfigByRecallId.HandleId = ConfigCommon.InitDataStatement(ConfigRecallConfigByRecallId.HandleId, "db_questrecall.db", "select BinData from `RecallConfig` where RecallId=?");
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x00160028 File Offset: 0x0015E228
		public static RecallConfig? GetConfig(int p0RecallId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRecallConfigByRecallId.HandleId, ConfigRecallConfigByRecallId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecallConfigByRecallId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RecallId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RecallConfig?(RecallConfig.GetRootAsRecallConfig(configBuffer));
				}
			}
			ConfigRecallConfigByRecallId.LogPair.Clear();
			ConfigRecallConfigByRecallId.LogPair.Add(new ValueTuple<string, object>("RecallId", p0RecallId));
			if (!ConfigCommon.BindInt(ConfigRecallConfigByRecallId.HandleId, 1, p0RecallId, ConfigRecallConfigByRecallId.LogPair) || ConfigCommon.Step(ConfigRecallConfigByRecallId.HandleId, true, ConfigRecallConfigByRecallId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRecallConfigByRecallId.HandleId, ConfigRecallConfigByRecallId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRecallConfigByRecallId.HandleId, 0, ConfigRecallConfigByRecallId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRecallConfigByRecallId.HandleId, ConfigRecallConfigByRecallId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RecallConfig rootAsRecallConfig = RecallConfig.GetRootAsRecallConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecallConfigByRecallId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RecallId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRecallConfigByRecallId.HandleId, ConfigRecallConfigByRecallId.LogPair);
			return new RecallConfig?(rootAsRecallConfig);
		}

		// Token: 0x04003603 RID: 13827
		private const string DB = "db_questrecall.db";

		// Token: 0x04003604 RID: 13828
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x04003605 RID: 13829
		private const string TABLE = "RecallConfig";

		// Token: 0x04003606 RID: 13830
		private const string COMMAND = "select BinData from `RecallConfig` where RecallId=?";

		// Token: 0x04003607 RID: 13831
		private const string KEY_PREFIX = "RecallConfigByRecallId";

		// Token: 0x04003608 RID: 13832
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003609 RID: 13833
		private static int HandleId;
	}
}
