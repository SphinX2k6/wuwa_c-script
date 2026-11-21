using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000568 RID: 1384
	public class ConfigMonsterHandBookByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600207D RID: 8317 RVA: 0x001148B4 File Offset: 0x00112AB4
		static ConfigMonsterHandBookByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookByType.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookByType.ResetStaticDefaultValue));
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x001148D4 File Offset: 0x00112AD4
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

		// Token: 0x0600207F RID: 8319 RVA: 0x00114953 File Offset: 0x00112B53
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookByType.LogPair = null;
			ConfigMonsterHandBookByType.HandleId = 0;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00114961 File Offset: 0x00112B61
		public static void Init()
		{
			ConfigMonsterHandBookByType.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookByType.HandleId, "db_handbook.db", "select BinData from `MonsterHandBook` where Type=?");
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x0011497C File Offset: 0x00112B7C
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

		// Token: 0x040025BC RID: 9660
		private const string DB = "db_handbook.db";

		// Token: 0x040025BD RID: 9661
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040025BE RID: 9662
		private const string TABLE = "MonsterHandBook";

		// Token: 0x040025BF RID: 9663
		private const string COMMAND = "select BinData from `MonsterHandBook` where Type=?";

		// Token: 0x040025C0 RID: 9664
		private const string KEY_PREFIX = "MonsterHandBookByType";

		// Token: 0x040025C1 RID: 9665
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025C2 RID: 9666
		private static int HandleId;
	}
}
