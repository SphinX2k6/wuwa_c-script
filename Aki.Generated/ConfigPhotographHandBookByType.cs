using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DE RID: 1758
	public class ConfigPhotographHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002944 RID: 10564 RVA: 0x00142978 File Offset: 0x00140B78
		static ConfigPhotographHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotographHandBookByType.CreateStaticDefaultValue), new Action(ConfigPhotographHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x00142998 File Offset: 0x00140B98
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

		// Token: 0x06002946 RID: 10566 RVA: 0x00142A17 File Offset: 0x00140C17
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotographHandBookByType.LogPair = null;
			ConfigPhotographHandBookByType.HandleId = 0;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00142A25 File Offset: 0x00140C25
		public static void Init()
		{
			ConfigPhotographHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotographHandBookByType.HandleId, "db_handbook.db", "select BinData from `PhotographHandBook` where Type = ?");
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00142A40 File Offset: 0x00140C40
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

		// Token: 0x04002FF8 RID: 12280
		private const string DB = "db_handbook.db";

		// Token: 0x04002FF9 RID: 12281
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002FFA RID: 12282
		private const string TABLE = "PhotographHandBook";

		// Token: 0x04002FFB RID: 12283
		private const string COMMAND = "select BinData from `PhotographHandBook` where Type = ?";

		// Token: 0x04002FFC RID: 12284
		private const string KEY_PREFIX = "PhotographHandBookByType";

		// Token: 0x04002FFD RID: 12285
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FFE RID: 12286
		private static int HandleId;
	}
}
