using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039F RID: 927
	public class ConfigGeographyHandBookByTabTypeAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015C0 RID: 5568 RVA: 0x000D821B File Offset: 0x000D641B
		static ConfigGeographyHandBookByTabTypeAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyHandBookByTabTypeAndType.CreateStaticDefaultValue), new Action(ConfigGeographyHandBookByTabTypeAndType.ResetStaticDefaultValue));
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x000D823C File Offset: 0x000D643C
		public static void CreateStaticDefaultValue()
		{
			ConfigGeographyHandBookByTabTypeAndType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGeographyHandBookByTabTypeAndType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "GeographyHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `GeographyHandBook` where GeographyTabType=? and Type=?")
			});
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x000D82BB File Offset: 0x000D64BB
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyHandBookByTabTypeAndType.LogPair = null;
			ConfigGeographyHandBookByTabTypeAndType.HandleId = 0;
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000D82C9 File Offset: 0x000D64C9
		public static void Init()
		{
			ConfigGeographyHandBookByTabTypeAndType.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyHandBookByTabTypeAndType.HandleId, "db_handbook.db", "select BinData from `GeographyHandBook` where GeographyTabType=? and Type=?");
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x000D82E4 File Offset: 0x000D64E4
		[NullableContext(2)]
		public static IReadOnlyList<GeographyHandBook> GetConfigList(int p0GeographyTabType, int p1Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGeographyHandBookByTabTypeAndType.HandleId, ConfigGeographyHandBookByTabTypeAndType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyHandBookByTabTypeAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GeographyTabType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				IReadOnlyList<GeographyHandBook> readOnlyList = (IReadOnlyList<GeographyHandBook>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigGeographyHandBookByTabTypeAndType.LogPair.Clear();
			ConfigGeographyHandBookByTabTypeAndType.LogPair.Add(new ValueTuple<string, object>("GeographyTabType", p0GeographyTabType));
			ConfigGeographyHandBookByTabTypeAndType.LogPair.Add(new ValueTuple<string, object>("Type", p1Type));
			if (!ConfigCommon.BindInt(ConfigGeographyHandBookByTabTypeAndType.HandleId, 1, p0GeographyTabType, ConfigGeographyHandBookByTabTypeAndType.LogPair) || !ConfigCommon.BindInt(ConfigGeographyHandBookByTabTypeAndType.HandleId, 2, p1Type, ConfigGeographyHandBookByTabTypeAndType.LogPair))
			{
				ConfigCommon.Reset(ConfigGeographyHandBookByTabTypeAndType.HandleId, ConfigGeographyHandBookByTabTypeAndType.LogPair);
				return null;
			}
			List<GeographyHandBook> list = new List<GeographyHandBook>();
			while (ConfigCommon.Step(ConfigGeographyHandBookByTabTypeAndType.HandleId, false, ConfigGeographyHandBookByTabTypeAndType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGeographyHandBookByTabTypeAndType.HandleId, 0, ConfigGeographyHandBookByTabTypeAndType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGeographyHandBookByTabTypeAndType.HandleId, ConfigGeographyHandBookByTabTypeAndType.LogPair);
					return null;
				}
				GeographyHandBook rootAsGeographyHandBook = GeographyHandBook.GetRootAsGeographyHandBook(new ByteBuffer(item2));
				list.Add(rootAsGeographyHandBook);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyHandBookByTabTypeAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GeographyTabType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigGeographyHandBookByTabTypeAndType.HandleId, ConfigGeographyHandBookByTabTypeAndType.LogPair);
			return list;
		}

		// Token: 0x0400193D RID: 6461
		private const string DB = "db_handbook.db";

		// Token: 0x0400193E RID: 6462
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400193F RID: 6463
		private const string TABLE = "GeographyHandBook";

		// Token: 0x04001940 RID: 6464
		private const string COMMAND = "select BinData from `GeographyHandBook` where GeographyTabType=? and Type=?";

		// Token: 0x04001941 RID: 6465
		private const string KEY_PREFIX = "GeographyHandBookByTabTypeAndType";

		// Token: 0x04001942 RID: 6466
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001943 RID: 6467
		private static int HandleId;
	}
}
