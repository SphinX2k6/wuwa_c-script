using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038A RID: 906
	public class ConfigGeographyHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001542 RID: 5442 RVA: 0x000D1D57 File Offset: 0x000CFF57
		static ConfigGeographyHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyHandBookByType.CreateStaticDefaultValue), new Action(ConfigGeographyHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x000D1D78 File Offset: 0x000CFF78
		public static void CreateStaticDefaultValue()
		{
			ConfigGeographyHandBookByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGeographyHandBookByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "GeographyHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `GeographyHandBook` where Type=?")
			});
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000D1DF7 File Offset: 0x000CFFF7
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyHandBookByType.LogPair = null;
			ConfigGeographyHandBookByType.HandleId = 0;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000D1E05 File Offset: 0x000D0005
		public static void Init()
		{
			ConfigGeographyHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyHandBookByType.HandleId, "db_handbook.db", "select BinData from `GeographyHandBook` where Type=?");
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000D1E20 File Offset: 0x000D0020
		[NullableContext(2)]
		public static IReadOnlyList<GeographyHandBook> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGeographyHandBookByType.HandleId, ConfigGeographyHandBookByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<GeographyHandBook> readOnlyList = (IReadOnlyList<GeographyHandBook>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigGeographyHandBookByType.LogPair.Clear();
			ConfigGeographyHandBookByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigGeographyHandBookByType.HandleId, 1, p0Type, ConfigGeographyHandBookByType.LogPair))
			{
				ConfigCommon.Reset(ConfigGeographyHandBookByType.HandleId, ConfigGeographyHandBookByType.LogPair);
				return null;
			}
			List<GeographyHandBook> list = new List<GeographyHandBook>();
			while (ConfigCommon.Step(ConfigGeographyHandBookByType.HandleId, false, ConfigGeographyHandBookByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGeographyHandBookByType.HandleId, 0, ConfigGeographyHandBookByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGeographyHandBookByType.HandleId, ConfigGeographyHandBookByType.LogPair);
					return null;
				}
				GeographyHandBook rootAsGeographyHandBook = GeographyHandBook.GetRootAsGeographyHandBook(new ByteBuffer(item2));
				list.Add(rootAsGeographyHandBook);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigGeographyHandBookByType.HandleId, ConfigGeographyHandBookByType.LogPair);
			return list;
		}

		// Token: 0x040018AA RID: 6314
		private const string DB = "db_handbook.db";

		// Token: 0x040018AB RID: 6315
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040018AC RID: 6316
		private const string TABLE = "GeographyHandBook";

		// Token: 0x040018AD RID: 6317
		private const string COMMAND = "select BinData from `GeographyHandBook` where Type=?";

		// Token: 0x040018AE RID: 6318
		private const string KEY_PREFIX = "GeographyHandBookByType";

		// Token: 0x040018AF RID: 6319
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018B0 RID: 6320
		private static int HandleId;
	}
}
