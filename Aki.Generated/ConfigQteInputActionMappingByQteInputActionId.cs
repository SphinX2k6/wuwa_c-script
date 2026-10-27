using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076B RID: 1899
	public class ConfigQteInputActionMappingByQteInputActionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C93 RID: 11411 RVA: 0x0015525F File Offset: 0x0015345F
		static ConfigQteInputActionMappingByQteInputActionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQteInputActionMappingByQteInputActionId.CreateStaticDefaultValue), new Action(ConfigQteInputActionMappingByQteInputActionId.ResetStaticDefaultValue));
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x00155280 File Offset: 0x00153480
		public static void CreateStaticDefaultValue()
		{
			ConfigQteInputActionMappingByQteInputActionId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQteInputActionMappingByQteInputActionId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "QteInputActionMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `QteInputActionMapping` where QteInputActionId=?")
			});
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x001552FF File Offset: 0x001534FF
		public static void ResetStaticDefaultValue()
		{
			ConfigQteInputActionMappingByQteInputActionId.LogPair = null;
			ConfigQteInputActionMappingByQteInputActionId.HandleId = 0;
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x0015530D File Offset: 0x0015350D
		public static void Init()
		{
			ConfigQteInputActionMappingByQteInputActionId.HandleId = ConfigCommon.InitDataStatement(ConfigQteInputActionMappingByQteInputActionId.HandleId, "db_input_settings.db", "select BinData from `QteInputActionMapping` where QteInputActionId=?");
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00155328 File Offset: 0x00153528
		public static QteInputActionMapping? GetConfig(int p0QteInputActionId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQteInputActionMappingByQteInputActionId.HandleId, ConfigQteInputActionMappingByQteInputActionId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QteInputActionMappingByQteInputActionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QteInputActionId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QteInputActionMapping?(QteInputActionMapping.GetRootAsQteInputActionMapping(configBuffer));
				}
			}
			ConfigQteInputActionMappingByQteInputActionId.LogPair.Clear();
			ConfigQteInputActionMappingByQteInputActionId.LogPair.Add(new ValueTuple<string, object>("QteInputActionId", p0QteInputActionId));
			if (!ConfigCommon.BindInt(ConfigQteInputActionMappingByQteInputActionId.HandleId, 1, p0QteInputActionId, ConfigQteInputActionMappingByQteInputActionId.LogPair) || ConfigCommon.Step(ConfigQteInputActionMappingByQteInputActionId.HandleId, true, ConfigQteInputActionMappingByQteInputActionId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQteInputActionMappingByQteInputActionId.HandleId, ConfigQteInputActionMappingByQteInputActionId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQteInputActionMappingByQteInputActionId.HandleId, 0, ConfigQteInputActionMappingByQteInputActionId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQteInputActionMappingByQteInputActionId.HandleId, ConfigQteInputActionMappingByQteInputActionId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QteInputActionMapping rootAsQteInputActionMapping = QteInputActionMapping.GetRootAsQteInputActionMapping(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QteInputActionMappingByQteInputActionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QteInputActionId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQteInputActionMappingByQteInputActionId.HandleId, ConfigQteInputActionMappingByQteInputActionId.LogPair);
			return new QteInputActionMapping?(rootAsQteInputActionMapping);
		}

		// Token: 0x040033D3 RID: 13267
		private const string DB = "db_input_settings.db";

		// Token: 0x040033D4 RID: 13268
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x040033D5 RID: 13269
		private const string TABLE = "QteInputActionMapping";

		// Token: 0x040033D6 RID: 13270
		private const string COMMAND = "select BinData from `QteInputActionMapping` where QteInputActionId=?";

		// Token: 0x040033D7 RID: 13271
		private const string KEY_PREFIX = "QteInputActionMappingByQteInputActionId";

		// Token: 0x040033D8 RID: 13272
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033D9 RID: 13273
		private static int HandleId;
	}
}
