using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000552 RID: 1362
	public class ConfigMonsterHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FF9 RID: 8185 RVA: 0x0010E160 File Offset: 0x0010C360
		static ConfigMonsterHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookByType.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0010E180 File Offset: 0x0010C380
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterHandBookByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterHandBookByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterHandBook` where Type=?")
			});
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x0010E1FF File Offset: 0x0010C3FF
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookByType.LogPair = null;
			ConfigMonsterHandBookByType.HandleId = 0;
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0010E20D File Offset: 0x0010C40D
		public static void Init()
		{
			ConfigMonsterHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookByType.HandleId, "db_handbook.db", "select BinData from `MonsterHandBook` where Type=?");
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x0010E228 File Offset: 0x0010C428
		[NullableContext(2)]
		public static IReadOnlyList<MonsterHandBook> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterHandBookByType.HandleId, ConfigMonsterHandBookByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<MonsterHandBook> readOnlyList = (IReadOnlyList<MonsterHandBook>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMonsterHandBookByType.LogPair.Clear();
			ConfigMonsterHandBookByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigMonsterHandBookByType.HandleId, 1, p0Type, ConfigMonsterHandBookByType.LogPair))
			{
				ConfigCommon.Reset(ConfigMonsterHandBookByType.HandleId, ConfigMonsterHandBookByType.LogPair);
				return null;
			}
			List<MonsterHandBook> list = new List<MonsterHandBook>();
			while (ConfigCommon.Step(ConfigMonsterHandBookByType.HandleId, false, ConfigMonsterHandBookByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterHandBookByType.HandleId, 0, ConfigMonsterHandBookByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMonsterHandBookByType.HandleId, ConfigMonsterHandBookByType.LogPair);
					return null;
				}
				MonsterHandBook rootAsMonsterHandBook = MonsterHandBook.GetRootAsMonsterHandBook(new ByteBuffer(item2));
				list.Add(rootAsMonsterHandBook);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterHandBookByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMonsterHandBookByType.HandleId, ConfigMonsterHandBookByType.LogPair);
			return list;
		}

		// Token: 0x04002522 RID: 9506
		private const string DB = "db_handbook.db";

		// Token: 0x04002523 RID: 9507
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002524 RID: 9508
		private const string TABLE = "MonsterHandBook";

		// Token: 0x04002525 RID: 9509
		private const string COMMAND = "select BinData from `MonsterHandBook` where Type=?";

		// Token: 0x04002526 RID: 9510
		private const string KEY_PREFIX = "MonsterHandBookByType";

		// Token: 0x04002527 RID: 9511
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002528 RID: 9512
		private static int HandleId;
	}
}
