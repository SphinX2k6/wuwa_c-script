using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFA RID: 2810
	public class ConfigTrapDefenseBdGroupByBd : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041F0 RID: 16880 RVA: 0x001D1A7B File Offset: 0x001CFC7B
		static ConfigTrapDefenseBdGroupByBd()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdGroupByBd.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdGroupByBd.ResetStaticDefaultValue));
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x001D1A9C File Offset: 0x001CFC9C
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

		// Token: 0x060041F2 RID: 16882 RVA: 0x001D1B1B File Offset: 0x001CFD1B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdGroupByBd.LogPair = null;
			ConfigTrapDefenseBdGroupByBd.HandleId = 0;
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x001D1B29 File Offset: 0x001CFD29
		public static void Init()
		{
			ConfigTrapDefenseBdGroupByBd.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdGroupByBd.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdGroup` where BelongBd=?");
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x001D1B44 File Offset: 0x001CFD44
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

		// Token: 0x04004CBC RID: 19644
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CBD RID: 19645
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x04004CBE RID: 19646
		private const string TABLE = "TrapDefenseBdGroup";

		// Token: 0x04004CBF RID: 19647
		private const string COMMAND = "select BinData from `TrapDefenseBdGroup` where BelongBd=?";

		// Token: 0x04004CC0 RID: 19648
		private const string KEY_PREFIX = "TrapDefenseBdGroupByBd";

		// Token: 0x04004CC1 RID: 19649
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CC2 RID: 19650
		private static int HandleId;
	}
}
