using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D5 RID: 2005
	public class ConfigRecallConfigByRecallId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F10 RID: 12048 RVA: 0x00166E6C File Offset: 0x0016506C
		static ConfigRecallConfigByRecallId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecallConfigByRecallId.CreateStaticDefaultValue), new Action(ConfigRecallConfigByRecallId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x00166E8C File Offset: 0x0016508C
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

		// Token: 0x06002F12 RID: 12050 RVA: 0x00166F0B File Offset: 0x0016510B
		public static void ResetStaticDefaultValue()
		{
			ConfigRecallConfigByRecallId.LogPair = null;
			ConfigRecallConfigByRecallId.HandleId = 0;
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x00166F19 File Offset: 0x00165119
		public static void Init()
		{
			ConfigRecallConfigByRecallId.HandleId = ConfigCommon.InitDataStatement(ConfigRecallConfigByRecallId.HandleId, "db_questrecall.db", "select BinData from `RecallConfig` where RecallId=?");
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x00166F34 File Offset: 0x00165134
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

		// Token: 0x040036B9 RID: 14009
		private const string DB = "db_questrecall.db";

		// Token: 0x040036BA RID: 14010
		private const string FILE = "r.任务回顾.xlsx";

		// Token: 0x040036BB RID: 14011
		private const string TABLE = "RecallConfig";

		// Token: 0x040036BC RID: 14012
		private const string COMMAND = "select BinData from `RecallConfig` where RecallId=?";

		// Token: 0x040036BD RID: 14013
		private const string KEY_PREFIX = "RecallConfigByRecallId";

		// Token: 0x040036BE RID: 14014
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036BF RID: 14015
		private static int HandleId;
	}
}
