using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000525 RID: 1317
	public class ConfigMappingBySheetNameFieldNameAndValue : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EE9 RID: 7913 RVA: 0x00107F1D File Offset: 0x0010611D
		static ConfigMappingBySheetNameFieldNameAndValue()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMappingBySheetNameFieldNameAndValue.CreateStaticDefaultValue), new Action(ConfigMappingBySheetNameFieldNameAndValue.ResetStaticDefaultValue));
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00107F3C File Offset: 0x0010613C
		public static void CreateStaticDefaultValue()
		{
			ConfigMappingBySheetNameFieldNameAndValue.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMappingBySheetNameFieldNameAndValue.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapping.db"),
				new ValueTuple<string, object>("文件", "s.数据枚举对应关系.xlsx"),
				new ValueTuple<string, object>("表名", "Mapping"),
				new ValueTuple<string, object>("语句", "select BinData from `Mapping` where SheetName=? AND FieldName=? AND Value=?")
			});
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00107FBB File Offset: 0x001061BB
		public static void ResetStaticDefaultValue()
		{
			ConfigMappingBySheetNameFieldNameAndValue.LogPair = null;
			ConfigMappingBySheetNameFieldNameAndValue.HandleId = 0;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00107FC9 File Offset: 0x001061C9
		public static void Init()
		{
			ConfigMappingBySheetNameFieldNameAndValue.HandleId = ConfigCommon.InitDataStatement(ConfigMappingBySheetNameFieldNameAndValue.HandleId, "db_mapping.db", "select BinData from `Mapping` where SheetName=? AND FieldName=? AND Value=?");
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00107FE4 File Offset: 0x001061E4
		public static Mapping? GetConfig(string p0SheetName, string p1FieldName, int p2Value, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMappingBySheetNameFieldNameAndValue.HandleId, ConfigMappingBySheetNameFieldNameAndValue.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("MappingBySheetNameFieldNameAndValue");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0SheetName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1FieldName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Value);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Mapping?(Mapping.GetRootAsMapping(configBuffer));
				}
			}
			ConfigMappingBySheetNameFieldNameAndValue.LogPair.Clear();
			ConfigMappingBySheetNameFieldNameAndValue.LogPair.Add(new ValueTuple<string, object>("SheetName", p0SheetName));
			ConfigMappingBySheetNameFieldNameAndValue.LogPair.Add(new ValueTuple<string, object>("FieldName", p1FieldName));
			ConfigMappingBySheetNameFieldNameAndValue.LogPair.Add(new ValueTuple<string, object>("Value", p2Value));
			if (!ConfigCommon.BindString(ConfigMappingBySheetNameFieldNameAndValue.HandleId, 1, p0SheetName, ConfigMappingBySheetNameFieldNameAndValue.LogPair) || !ConfigCommon.BindString(ConfigMappingBySheetNameFieldNameAndValue.HandleId, 2, p1FieldName, ConfigMappingBySheetNameFieldNameAndValue.LogPair) || !ConfigCommon.BindInt(ConfigMappingBySheetNameFieldNameAndValue.HandleId, 3, p2Value, ConfigMappingBySheetNameFieldNameAndValue.LogPair) || ConfigCommon.Step(ConfigMappingBySheetNameFieldNameAndValue.HandleId, true, ConfigMappingBySheetNameFieldNameAndValue.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMappingBySheetNameFieldNameAndValue.HandleId, ConfigMappingBySheetNameFieldNameAndValue.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMappingBySheetNameFieldNameAndValue.HandleId, 0, ConfigMappingBySheetNameFieldNameAndValue.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMappingBySheetNameFieldNameAndValue.HandleId, ConfigMappingBySheetNameFieldNameAndValue.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Mapping rootAsMapping = Mapping.GetRootAsMapping(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("MappingBySheetNameFieldNameAndValue");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0SheetName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1FieldName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Value);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMappingBySheetNameFieldNameAndValue.HandleId, ConfigMappingBySheetNameFieldNameAndValue.LogPair);
			return new Mapping?(rootAsMapping);
		}

		// Token: 0x040023E7 RID: 9191
		private const string DB = "db_mapping.db";

		// Token: 0x040023E8 RID: 9192
		private const string FILE = "s.数据枚举对应关系.xlsx";

		// Token: 0x040023E9 RID: 9193
		private const string TABLE = "Mapping";

		// Token: 0x040023EA RID: 9194
		private const string COMMAND = "select BinData from `Mapping` where SheetName=? AND FieldName=? AND Value=?";

		// Token: 0x040023EB RID: 9195
		private const string KEY_PREFIX = "MappingBySheetNameFieldNameAndValue";

		// Token: 0x040023EC RID: 9196
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023ED RID: 9197
		private static int HandleId;
	}
}
