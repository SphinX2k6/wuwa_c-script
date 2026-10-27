using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C1 RID: 1985
	public class ConfigRecordConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E98 RID: 11928 RVA: 0x00160BFB File Offset: 0x0015EDFB
		static ConfigRecordConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecordConfigById.CreateStaticDefaultValue), new Action(ConfigRecordConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00160C1C File Offset: 0x0015EE1C
		public static void CreateStaticDefaultValue()
		{
			ConfigRecordConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRecordConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventurerecord.db"),
				new ValueTuple<string, object>("文件", "j.记录.xlsx"),
				new ValueTuple<string, object>("表名", "RecordConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RecordConfig` where Id=?")
			});
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00160C9B File Offset: 0x0015EE9B
		public static void ResetStaticDefaultValue()
		{
			ConfigRecordConfigById.LogPair = null;
			ConfigRecordConfigById.HandleId = 0;
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00160CA9 File Offset: 0x0015EEA9
		public static void Init()
		{
			ConfigRecordConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRecordConfigById.HandleId, "db_adventurerecord.db", "select BinData from `RecordConfig` where Id=?");
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00160CC4 File Offset: 0x0015EEC4
		public static RecordConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRecordConfigById.HandleId, ConfigRecordConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecordConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RecordConfig?(RecordConfig.GetRootAsRecordConfig(configBuffer));
				}
			}
			ConfigRecordConfigById.LogPair.Clear();
			ConfigRecordConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRecordConfigById.HandleId, 1, p0Id, ConfigRecordConfigById.LogPair) || ConfigCommon.Step(ConfigRecordConfigById.HandleId, true, ConfigRecordConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRecordConfigById.HandleId, ConfigRecordConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRecordConfigById.HandleId, 0, ConfigRecordConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRecordConfigById.HandleId, ConfigRecordConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RecordConfig rootAsRecordConfig = RecordConfig.GetRootAsRecordConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RecordConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRecordConfigById.HandleId, ConfigRecordConfigById.LogPair);
			return new RecordConfig?(rootAsRecordConfig);
		}

		// Token: 0x0400362D RID: 13869
		private const string DB = "db_adventurerecord.db";

		// Token: 0x0400362E RID: 13870
		private const string FILE = "j.记录.xlsx";

		// Token: 0x0400362F RID: 13871
		private const string TABLE = "RecordConfig";

		// Token: 0x04003630 RID: 13872
		private const string COMMAND = "select BinData from `RecordConfig` where Id=?";

		// Token: 0x04003631 RID: 13873
		private const string KEY_PREFIX = "RecordConfigById";

		// Token: 0x04003632 RID: 13874
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003633 RID: 13875
		private static int HandleId;
	}
}
