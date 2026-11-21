using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A0 RID: 928
	public class ConfigGeographyHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015C6 RID: 5574 RVA: 0x000D84AB File Offset: 0x000D66AB
		static ConfigGeographyHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyHandBookByType.CreateStaticDefaultValue), new Action(ConfigGeographyHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000D84CC File Offset: 0x000D66CC
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

		// Token: 0x060015C8 RID: 5576 RVA: 0x000D854B File Offset: 0x000D674B
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyHandBookByType.LogPair = null;
			ConfigGeographyHandBookByType.HandleId = 0;
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000D8559 File Offset: 0x000D6759
		public static void Init()
		{
			ConfigGeographyHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyHandBookByType.HandleId, "db_handbook.db", "select BinData from `GeographyHandBook` where Type=?");
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x000D8574 File Offset: 0x000D6774
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

		// Token: 0x04001944 RID: 6468
		private const string DB = "db_handbook.db";

		// Token: 0x04001945 RID: 6469
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001946 RID: 6470
		private const string TABLE = "GeographyHandBook";

		// Token: 0x04001947 RID: 6471
		private const string COMMAND = "select BinData from `GeographyHandBook` where Type=?";

		// Token: 0x04001948 RID: 6472
		private const string KEY_PREFIX = "GeographyHandBookByType";

		// Token: 0x04001949 RID: 6473
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400194A RID: 6474
		private static int HandleId;
	}
}
