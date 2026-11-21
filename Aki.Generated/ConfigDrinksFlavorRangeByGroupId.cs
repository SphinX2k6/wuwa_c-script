using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023B RID: 571
	public class ConfigDrinksFlavorRangeByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D66 RID: 3430 RVA: 0x000A8DA8 File Offset: 0x000A6FA8
		static ConfigDrinksFlavorRangeByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksFlavorRangeByGroupId.CreateStaticDefaultValue), new Action(ConfigDrinksFlavorRangeByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000A8DC8 File Offset: 0x000A6FC8
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksFlavorRangeByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksFlavorRangeByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksFlavorRange"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksFlavorRange` where FlavorGroupId=?")
			});
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x000A8E47 File Offset: 0x000A7047
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksFlavorRangeByGroupId.LogPair = null;
			ConfigDrinksFlavorRangeByGroupId.HandleId = 0;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x000A8E55 File Offset: 0x000A7055
		public static void Init()
		{
			ConfigDrinksFlavorRangeByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksFlavorRangeByGroupId.HandleId, "db_drinks.db", "select BinData from `DrinksFlavorRange` where FlavorGroupId=?");
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x000A8E70 File Offset: 0x000A7070
		[NullableContext(2)]
		public static IReadOnlyList<DrinksFlavorRange> GetConfigList(int p0FlavorGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksFlavorRangeByGroupId.HandleId, ConfigDrinksFlavorRangeByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksFlavorRangeByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FlavorGroupId);
				IReadOnlyList<DrinksFlavorRange> readOnlyList = (IReadOnlyList<DrinksFlavorRange>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDrinksFlavorRangeByGroupId.LogPair.Clear();
			ConfigDrinksFlavorRangeByGroupId.LogPair.Add(new ValueTuple<string, object>("FlavorGroupId", p0FlavorGroupId));
			if (!ConfigCommon.BindInt(ConfigDrinksFlavorRangeByGroupId.HandleId, 1, p0FlavorGroupId, ConfigDrinksFlavorRangeByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigDrinksFlavorRangeByGroupId.HandleId, ConfigDrinksFlavorRangeByGroupId.LogPair);
				return null;
			}
			List<DrinksFlavorRange> list = new List<DrinksFlavorRange>();
			while (ConfigCommon.Step(ConfigDrinksFlavorRangeByGroupId.HandleId, false, ConfigDrinksFlavorRangeByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksFlavorRangeByGroupId.HandleId, 0, ConfigDrinksFlavorRangeByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDrinksFlavorRangeByGroupId.HandleId, ConfigDrinksFlavorRangeByGroupId.LogPair);
					return null;
				}
				DrinksFlavorRange rootAsDrinksFlavorRange = DrinksFlavorRange.GetRootAsDrinksFlavorRange(new ByteBuffer(item2));
				list.Add(rootAsDrinksFlavorRange);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksFlavorRangeByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FlavorGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDrinksFlavorRangeByGroupId.HandleId, ConfigDrinksFlavorRangeByGroupId.LogPair);
			return list;
		}

		// Token: 0x04000F81 RID: 3969
		private const string DB = "db_drinks.db";

		// Token: 0x04000F82 RID: 3970
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F83 RID: 3971
		private const string TABLE = "DrinksFlavorRange";

		// Token: 0x04000F84 RID: 3972
		private const string COMMAND = "select BinData from `DrinksFlavorRange` where FlavorGroupId=?";

		// Token: 0x04000F85 RID: 3973
		private const string KEY_PREFIX = "DrinksFlavorRangeByGroupId";

		// Token: 0x04000F86 RID: 3974
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F87 RID: 3975
		private static int HandleId;
	}
}
