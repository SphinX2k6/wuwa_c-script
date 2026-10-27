using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000524 RID: 1316
	public class ConfigMappingBySheetNameAndFieldName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EE3 RID: 7907 RVA: 0x00107C98 File Offset: 0x00105E98
		static ConfigMappingBySheetNameAndFieldName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMappingBySheetNameAndFieldName.CreateStaticDefaultValue), new Action(ConfigMappingBySheetNameAndFieldName.ResetStaticDefaultValue));
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00107CB8 File Offset: 0x00105EB8
		public static void CreateStaticDefaultValue()
		{
			ConfigMappingBySheetNameAndFieldName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMappingBySheetNameAndFieldName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapping.db"),
				new ValueTuple<string, object>("文件", "s.数据枚举对应关系.xlsx"),
				new ValueTuple<string, object>("表名", "Mapping"),
				new ValueTuple<string, object>("语句", "select BinData from `Mapping` where SheetName=? AND FieldName=?")
			});
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00107D37 File Offset: 0x00105F37
		public static void ResetStaticDefaultValue()
		{
			ConfigMappingBySheetNameAndFieldName.LogPair = null;
			ConfigMappingBySheetNameAndFieldName.HandleId = 0;
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00107D45 File Offset: 0x00105F45
		public static void Init()
		{
			ConfigMappingBySheetNameAndFieldName.HandleId = ConfigCommon.InitDataStatement(ConfigMappingBySheetNameAndFieldName.HandleId, "db_mapping.db", "select BinData from `Mapping` where SheetName=? AND FieldName=?");
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00107D60 File Offset: 0x00105F60
		[return: Nullable(2)]
		public static IReadOnlyList<Mapping> GetConfigList(string p0SheetName, string p1FieldName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMappingBySheetNameAndFieldName.HandleId, ConfigMappingBySheetNameAndFieldName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MappingBySheetNameAndFieldName");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0SheetName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1FieldName);
				IReadOnlyList<Mapping> readOnlyList = (IReadOnlyList<Mapping>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMappingBySheetNameAndFieldName.LogPair.Clear();
			ConfigMappingBySheetNameAndFieldName.LogPair.Add(new ValueTuple<string, object>("SheetName", p0SheetName));
			ConfigMappingBySheetNameAndFieldName.LogPair.Add(new ValueTuple<string, object>("FieldName", p1FieldName));
			if (!ConfigCommon.BindString(ConfigMappingBySheetNameAndFieldName.HandleId, 1, p0SheetName, ConfigMappingBySheetNameAndFieldName.LogPair) || !ConfigCommon.BindString(ConfigMappingBySheetNameAndFieldName.HandleId, 2, p1FieldName, ConfigMappingBySheetNameAndFieldName.LogPair))
			{
				ConfigCommon.Reset(ConfigMappingBySheetNameAndFieldName.HandleId, ConfigMappingBySheetNameAndFieldName.LogPair);
				return null;
			}
			List<Mapping> list = new List<Mapping>();
			while (ConfigCommon.Step(ConfigMappingBySheetNameAndFieldName.HandleId, false, ConfigMappingBySheetNameAndFieldName.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMappingBySheetNameAndFieldName.HandleId, 0, ConfigMappingBySheetNameAndFieldName.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMappingBySheetNameAndFieldName.HandleId, ConfigMappingBySheetNameAndFieldName.LogPair);
					return null;
				}
				Mapping rootAsMapping = Mapping.GetRootAsMapping(new ByteBuffer(item2));
				list.Add(rootAsMapping);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MappingBySheetNameAndFieldName");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0SheetName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1FieldName);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMappingBySheetNameAndFieldName.HandleId, ConfigMappingBySheetNameAndFieldName.LogPair);
			return list;
		}

		// Token: 0x040023E0 RID: 9184
		private const string DB = "db_mapping.db";

		// Token: 0x040023E1 RID: 9185
		private const string FILE = "s.数据枚举对应关系.xlsx";

		// Token: 0x040023E2 RID: 9186
		private const string TABLE = "Mapping";

		// Token: 0x040023E3 RID: 9187
		private const string COMMAND = "select BinData from `Mapping` where SheetName=? AND FieldName=?";

		// Token: 0x040023E4 RID: 9188
		private const string KEY_PREFIX = "MappingBySheetNameAndFieldName";

		// Token: 0x040023E5 RID: 9189
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023E6 RID: 9190
		private static int HandleId;
	}
}
