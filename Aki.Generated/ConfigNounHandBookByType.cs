using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200062E RID: 1582
	public class ConfigNounHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002524 RID: 9508 RVA: 0x0012F100 File Offset: 0x0012D300
		static ConfigNounHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNounHandBookByType.CreateStaticDefaultValue), new Action(ConfigNounHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x0012F120 File Offset: 0x0012D320
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

		// Token: 0x06002526 RID: 9510 RVA: 0x0012F19F File Offset: 0x0012D39F
		public static void ResetStaticDefaultValue()
		{
			ConfigNounHandBookByType.LogPair = null;
			ConfigNounHandBookByType.HandleId = 0;
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x0012F1AD File Offset: 0x0012D3AD
		public static void Init()
		{
			ConfigNounHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigNounHandBookByType.HandleId, "db_handbook.db", "select BinData from `NounHandBook` where Type=?");
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0012F1C8 File Offset: 0x0012D3C8
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

		// Token: 0x04002B28 RID: 11048
		private const string DB = "db_handbook.db";

		// Token: 0x04002B29 RID: 11049
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002B2A RID: 11050
		private const string TABLE = "NounHandBook";

		// Token: 0x04002B2B RID: 11051
		private const string COMMAND = "select BinData from `NounHandBook` where Type=?";

		// Token: 0x04002B2C RID: 11052
		private const string KEY_PREFIX = "NounHandBookByType";

		// Token: 0x04002B2D RID: 11053
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B2E RID: 11054
		private static int HandleId;
	}
}
