using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000785 RID: 1925
	public class ConfigQteInputActionMappingByQteInputActionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D2F RID: 11567 RVA: 0x0015C16B File Offset: 0x0015A36B
		static ConfigQteInputActionMappingByQteInputActionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQteInputActionMappingByQteInputActionId.CreateStaticDefaultValue), new Action(ConfigQteInputActionMappingByQteInputActionId.ResetStaticDefaultValue));
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x0015C18C File Offset: 0x0015A38C
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

		// Token: 0x06002D31 RID: 11569 RVA: 0x0015C20B File Offset: 0x0015A40B
		public static void ResetStaticDefaultValue()
		{
			ConfigQteInputActionMappingByQteInputActionId.LogPair = null;
			ConfigQteInputActionMappingByQteInputActionId.HandleId = 0;
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x0015C219 File Offset: 0x0015A419
		public static void Init()
		{
			ConfigQteInputActionMappingByQteInputActionId.HandleId = ConfigCommon.InitDataStatement(ConfigQteInputActionMappingByQteInputActionId.HandleId, "db_input_settings.db", "select BinData from `QteInputActionMapping` where QteInputActionId=?");
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x0015C234 File Offset: 0x0015A434
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

		// Token: 0x04003489 RID: 13449
		private const string DB = "db_input_settings.db";

		// Token: 0x0400348A RID: 13450
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x0400348B RID: 13451
		private const string TABLE = "QteInputActionMapping";

		// Token: 0x0400348C RID: 13452
		private const string COMMAND = "select BinData from `QteInputActionMapping` where QteInputActionId=?";

		// Token: 0x0400348D RID: 13453
		private const string KEY_PREFIX = "QteInputActionMappingByQteInputActionId";

		// Token: 0x0400348E RID: 13454
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400348F RID: 13455
		private static int HandleId;
	}
}
