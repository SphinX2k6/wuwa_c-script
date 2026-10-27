using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000229 RID: 553
	public class ConfigDrinksFlavorRangeByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CFA RID: 3322 RVA: 0x000A2E70 File Offset: 0x000A1070
		static ConfigDrinksFlavorRangeByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksFlavorRangeByGroupId.CreateStaticDefaultValue), new Action(ConfigDrinksFlavorRangeByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x000A2E90 File Offset: 0x000A1090
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

		// Token: 0x06000CFC RID: 3324 RVA: 0x000A2F0F File Offset: 0x000A110F
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksFlavorRangeByGroupId.LogPair = null;
			ConfigDrinksFlavorRangeByGroupId.HandleId = 0;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000A2F1D File Offset: 0x000A111D
		public static void Init()
		{
			ConfigDrinksFlavorRangeByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksFlavorRangeByGroupId.HandleId, "db_drinks.db", "select BinData from `DrinksFlavorRange` where FlavorGroupId=?");
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x000A2F38 File Offset: 0x000A1138
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

		// Token: 0x04000F03 RID: 3843
		private const string DB = "db_drinks.db";

		// Token: 0x04000F04 RID: 3844
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F05 RID: 3845
		private const string TABLE = "DrinksFlavorRange";

		// Token: 0x04000F06 RID: 3846
		private const string COMMAND = "select BinData from `DrinksFlavorRange` where FlavorGroupId=?";

		// Token: 0x04000F07 RID: 3847
		private const string KEY_PREFIX = "DrinksFlavorRangeByGroupId";

		// Token: 0x04000F08 RID: 3848
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F09 RID: 3849
		private static int HandleId;
	}
}
