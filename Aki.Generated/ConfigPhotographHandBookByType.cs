using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F6 RID: 1782
	public class ConfigPhotographHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029D4 RID: 10708 RVA: 0x001493F4 File Offset: 0x001475F4
		static ConfigPhotographHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotographHandBookByType.CreateStaticDefaultValue), new Action(ConfigPhotographHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00149414 File Offset: 0x00147614
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotographHandBookByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotographHandBookByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhotographHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotographHandBook` where Type = ?")
			});
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00149493 File Offset: 0x00147693
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotographHandBookByType.LogPair = null;
			ConfigPhotographHandBookByType.HandleId = 0;
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x001494A1 File Offset: 0x001476A1
		public static void Init()
		{
			ConfigPhotographHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotographHandBookByType.HandleId, "db_handbook.db", "select BinData from `PhotographHandBook` where Type = ?");
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x001494BC File Offset: 0x001476BC
		[NullableContext(2)]
		public static IReadOnlyList<PhotographHandBook> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotographHandBookByType.HandleId, ConfigPhotographHandBookByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotographHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<PhotographHandBook> readOnlyList = (IReadOnlyList<PhotographHandBook>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotographHandBookByType.LogPair.Clear();
			ConfigPhotographHandBookByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigPhotographHandBookByType.HandleId, 1, p0Type, ConfigPhotographHandBookByType.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotographHandBookByType.HandleId, ConfigPhotographHandBookByType.LogPair);
				return null;
			}
			List<PhotographHandBook> list = new List<PhotographHandBook>();
			while (ConfigCommon.Step(ConfigPhotographHandBookByType.HandleId, false, ConfigPhotographHandBookByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotographHandBookByType.HandleId, 0, ConfigPhotographHandBookByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotographHandBookByType.HandleId, ConfigPhotographHandBookByType.LogPair);
					return null;
				}
				PhotographHandBook rootAsPhotographHandBook = PhotographHandBook.GetRootAsPhotographHandBook(new ByteBuffer(item2));
				list.Add(rootAsPhotographHandBook);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotographHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotographHandBookByType.HandleId, ConfigPhotographHandBookByType.LogPair);
			return list;
		}

		// Token: 0x040030A0 RID: 12448
		private const string DB = "db_handbook.db";

		// Token: 0x040030A1 RID: 12449
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040030A2 RID: 12450
		private const string TABLE = "PhotographHandBook";

		// Token: 0x040030A3 RID: 12451
		private const string COMMAND = "select BinData from `PhotographHandBook` where Type = ?";

		// Token: 0x040030A4 RID: 12452
		private const string KEY_PREFIX = "PhotographHandBookByType";

		// Token: 0x040030A5 RID: 12453
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030A6 RID: 12454
		private static int HandleId;
	}
}
