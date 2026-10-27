using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A25 RID: 2597
	public class ConfigTrapDefenseBdGroupByBd : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CF2 RID: 15602 RVA: 0x001B26E7 File Offset: 0x001B08E7
		static ConfigTrapDefenseBdGroupByBd()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdGroupByBd.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdGroupByBd.ResetStaticDefaultValue));
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x001B2708 File Offset: 0x001B0908
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBdGroupByBd.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBdGroupByBd.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_增益.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBdGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBdGroup` where BelongBd=?")
			});
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x001B2787 File Offset: 0x001B0987
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdGroupByBd.LogPair = null;
			ConfigTrapDefenseBdGroupByBd.HandleId = 0;
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x001B2795 File Offset: 0x001B0995
		public static void Init()
		{
			ConfigTrapDefenseBdGroupByBd.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdGroupByBd.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdGroup` where BelongBd=?");
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x001B27B0 File Offset: 0x001B09B0
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseBdGroup> GetConfigList(int p0BelongBd, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBdGroupByBd.HandleId, ConfigTrapDefenseBdGroupByBd.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdGroupByBd");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BelongBd);
				IReadOnlyList<TrapDefenseBdGroup> readOnlyList = (IReadOnlyList<TrapDefenseBdGroup>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrapDefenseBdGroupByBd.LogPair.Clear();
			ConfigTrapDefenseBdGroupByBd.LogPair.Add(new ValueTuple<string, object>("BelongBd", p0BelongBd));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBdGroupByBd.HandleId, 1, p0BelongBd, ConfigTrapDefenseBdGroupByBd.LogPair))
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdGroupByBd.HandleId, ConfigTrapDefenseBdGroupByBd.LogPair);
				return null;
			}
			List<TrapDefenseBdGroup> list = new List<TrapDefenseBdGroup>();
			while (ConfigCommon.Step(ConfigTrapDefenseBdGroupByBd.HandleId, false, ConfigTrapDefenseBdGroupByBd.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBdGroupByBd.HandleId, 0, ConfigTrapDefenseBdGroupByBd.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseBdGroupByBd.HandleId, ConfigTrapDefenseBdGroupByBd.LogPair);
					return null;
				}
				TrapDefenseBdGroup rootAsTrapDefenseBdGroup = TrapDefenseBdGroup.GetRootAsTrapDefenseBdGroup(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseBdGroup);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdGroupByBd");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BelongBd);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBdGroupByBd.HandleId, ConfigTrapDefenseBdGroupByBd.LogPair);
			return list;
		}

		// Token: 0x040046E9 RID: 18153
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046EA RID: 18154
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x040046EB RID: 18155
		private const string TABLE = "TrapDefenseBdGroup";

		// Token: 0x040046EC RID: 18156
		private const string COMMAND = "select BinData from `TrapDefenseBdGroup` where BelongBd=?";

		// Token: 0x040046ED RID: 18157
		private const string KEY_PREFIX = "TrapDefenseBdGroupByBd";

		// Token: 0x040046EE RID: 18158
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046EF RID: 18159
		private static int HandleId;
	}
}
