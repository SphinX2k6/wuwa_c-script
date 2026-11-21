using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DD RID: 2013
	public class ConfigRecordConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F40 RID: 12096 RVA: 0x00167EE3 File Offset: 0x001660E3
		static ConfigRecordConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRecordConfigById.CreateStaticDefaultValue), new Action(ConfigRecordConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x00167F04 File Offset: 0x00166104
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

		// Token: 0x06002F42 RID: 12098 RVA: 0x00167F83 File Offset: 0x00166183
		public static void ResetStaticDefaultValue()
		{
			ConfigRecordConfigById.LogPair = null;
			ConfigRecordConfigById.HandleId = 0;
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00167F91 File Offset: 0x00166191
		public static void Init()
		{
			ConfigRecordConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRecordConfigById.HandleId, "db_adventurerecord.db", "select BinData from `RecordConfig` where Id=?");
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x00167FAC File Offset: 0x001661AC
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

		// Token: 0x040036F1 RID: 14065
		private const string DB = "db_adventurerecord.db";

		// Token: 0x040036F2 RID: 14066
		private const string FILE = "j.记录.xlsx";

		// Token: 0x040036F3 RID: 14067
		private const string TABLE = "RecordConfig";

		// Token: 0x040036F4 RID: 14068
		private const string COMMAND = "select BinData from `RecordConfig` where Id=?";

		// Token: 0x040036F5 RID: 14069
		private const string KEY_PREFIX = "RecordConfigById";

		// Token: 0x040036F6 RID: 14070
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036F7 RID: 14071
		private static int HandleId;
	}
}
