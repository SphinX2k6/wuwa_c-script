using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000616 RID: 1558
	public class ConfigNounHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002494 RID: 9364 RVA: 0x00128684 File Offset: 0x00126884
		static ConfigNounHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNounHandBookByType.CreateStaticDefaultValue), new Action(ConfigNounHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x001286A4 File Offset: 0x001268A4
		public static void CreateStaticDefaultValue()
		{
			ConfigNounHandBookByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNounHandBookByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "NounHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `NounHandBook` where Type=?")
			});
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00128723 File Offset: 0x00126923
		public static void ResetStaticDefaultValue()
		{
			ConfigNounHandBookByType.LogPair = null;
			ConfigNounHandBookByType.HandleId = 0;
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00128731 File Offset: 0x00126931
		public static void Init()
		{
			ConfigNounHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigNounHandBookByType.HandleId, "db_handbook.db", "select BinData from `NounHandBook` where Type=?");
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x0012874C File Offset: 0x0012694C
		[NullableContext(2)]
		public static IReadOnlyList<NounHandBook> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNounHandBookByType.HandleId, ConfigNounHandBookByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NounHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<NounHandBook> readOnlyList = (IReadOnlyList<NounHandBook>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNounHandBookByType.LogPair.Clear();
			ConfigNounHandBookByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigNounHandBookByType.HandleId, 1, p0Type, ConfigNounHandBookByType.LogPair))
			{
				ConfigCommon.Reset(ConfigNounHandBookByType.HandleId, ConfigNounHandBookByType.LogPair);
				return null;
			}
			List<NounHandBook> list = new List<NounHandBook>();
			while (ConfigCommon.Step(ConfigNounHandBookByType.HandleId, false, ConfigNounHandBookByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNounHandBookByType.HandleId, 0, ConfigNounHandBookByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNounHandBookByType.HandleId, ConfigNounHandBookByType.LogPair);
					return null;
				}
				NounHandBook rootAsNounHandBook = NounHandBook.GetRootAsNounHandBook(new ByteBuffer(item2));
				list.Add(rootAsNounHandBook);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NounHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNounHandBookByType.HandleId, ConfigNounHandBookByType.LogPair);
			return list;
		}

		// Token: 0x04002A80 RID: 10880
		private const string DB = "db_handbook.db";

		// Token: 0x04002A81 RID: 10881
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002A82 RID: 10882
		private const string TABLE = "NounHandBook";

		// Token: 0x04002A83 RID: 10883
		private const string COMMAND = "select BinData from `NounHandBook` where Type=?";

		// Token: 0x04002A84 RID: 10884
		private const string KEY_PREFIX = "NounHandBookByType";

		// Token: 0x04002A85 RID: 10885
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A86 RID: 10886
		private static int HandleId;
	}
}
