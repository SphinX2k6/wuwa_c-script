using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200053B RID: 1339
	public class ConfigMappingBySheetNameFieldNameAndValue : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F6D RID: 8045 RVA: 0x0010E671 File Offset: 0x0010C871
		static ConfigMappingBySheetNameFieldNameAndValue()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMappingBySheetNameFieldNameAndValue.CreateStaticDefaultValue), new Action(ConfigMappingBySheetNameFieldNameAndValue.ResetStaticDefaultValue));
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x0010E690 File Offset: 0x0010C890
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

		// Token: 0x06001F6F RID: 8047 RVA: 0x0010E70F File Offset: 0x0010C90F
		public static void ResetStaticDefaultValue()
		{
			ConfigMappingBySheetNameFieldNameAndValue.LogPair = null;
			ConfigMappingBySheetNameFieldNameAndValue.HandleId = 0;
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x0010E71D File Offset: 0x0010C91D
		public static void Init()
		{
			ConfigMappingBySheetNameFieldNameAndValue.HandleId = ConfigCommon.InitDataStatement(ConfigMappingBySheetNameFieldNameAndValue.HandleId, "db_mapping.db", "select BinData from `Mapping` where SheetName=? AND FieldName=? AND Value=?");
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x0010E738 File Offset: 0x0010C938
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

		// Token: 0x04002481 RID: 9345
		private const string DB = "db_mapping.db";

		// Token: 0x04002482 RID: 9346
		private const string FILE = "s.数据枚举对应关系.xlsx";

		// Token: 0x04002483 RID: 9347
		private const string TABLE = "Mapping";

		// Token: 0x04002484 RID: 9348
		private const string COMMAND = "select BinData from `Mapping` where SheetName=? AND FieldName=? AND Value=?";

		// Token: 0x04002485 RID: 9349
		private const string KEY_PREFIX = "MappingBySheetNameFieldNameAndValue";

		// Token: 0x04002486 RID: 9350
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002487 RID: 9351
		private static int HandleId;
	}
}
