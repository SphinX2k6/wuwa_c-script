using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000389 RID: 905
	public class ConfigGeographyHandBookByTabTypeAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600153C RID: 5436 RVA: 0x000D1AC7 File Offset: 0x000CFCC7
		static ConfigGeographyHandBookByTabTypeAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyHandBookByTabTypeAndType.CreateStaticDefaultValue), new Action(ConfigGeographyHandBookByTabTypeAndType.ResetStaticDefaultValue));
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x000D1AE8 File Offset: 0x000CFCE8
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

		// Token: 0x0600153E RID: 5438 RVA: 0x000D1B67 File Offset: 0x000CFD67
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyHandBookByTabTypeAndType.LogPair = null;
			ConfigGeographyHandBookByTabTypeAndType.HandleId = 0;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x000D1B75 File Offset: 0x000CFD75
		public static void Init()
		{
			ConfigGeographyHandBookByTabTypeAndType.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyHandBookByTabTypeAndType.HandleId, "db_handbook.db", "select BinData from `GeographyHandBook` where GeographyTabType=? and Type=?");
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x000D1B90 File Offset: 0x000CFD90
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

		// Token: 0x040018A3 RID: 6307
		private const string DB = "db_handbook.db";

		// Token: 0x040018A4 RID: 6308
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040018A5 RID: 6309
		private const string TABLE = "GeographyHandBook";

		// Token: 0x040018A6 RID: 6310
		private const string COMMAND = "select BinData from `GeographyHandBook` where GeographyTabType=? and Type=?";

		// Token: 0x040018A7 RID: 6311
		private const string KEY_PREFIX = "GeographyHandBookByTabTypeAndType";

		// Token: 0x040018A8 RID: 6312
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018A9 RID: 6313
		private static int HandleId;
	}
}
