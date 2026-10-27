using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A20 RID: 2592
	public class ConfigTrapDefenseBdBuffByGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CD4 RID: 15572 RVA: 0x001B1BEF File Offset: 0x001AFDEF
		static ConfigTrapDefenseBdBuffByGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdBuffByGroup.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdBuffByGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x001B1C10 File Offset: 0x001AFE10
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBdBuffByGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBdBuffByGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_增益.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBdBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBdBuff` where GroupId=?")
			});
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x001B1C8F File Offset: 0x001AFE8F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdBuffByGroup.LogPair = null;
			ConfigTrapDefenseBdBuffByGroup.HandleId = 0;
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x001B1C9D File Offset: 0x001AFE9D
		public static void Init()
		{
			ConfigTrapDefenseBdBuffByGroup.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdBuffByGroup.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdBuff` where GroupId=?");
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x001B1CB8 File Offset: 0x001AFEB8
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseBdBuff> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBdBuffByGroup.HandleId, ConfigTrapDefenseBdBuffByGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdBuffByGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<TrapDefenseBdBuff> readOnlyList = (IReadOnlyList<TrapDefenseBdBuff>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrapDefenseBdBuffByGroup.LogPair.Clear();
			ConfigTrapDefenseBdBuffByGroup.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBdBuffByGroup.HandleId, 1, p0GroupId, ConfigTrapDefenseBdBuffByGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdBuffByGroup.HandleId, ConfigTrapDefenseBdBuffByGroup.LogPair);
				return null;
			}
			List<TrapDefenseBdBuff> list = new List<TrapDefenseBdBuff>();
			while (ConfigCommon.Step(ConfigTrapDefenseBdBuffByGroup.HandleId, false, ConfigTrapDefenseBdBuffByGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBdBuffByGroup.HandleId, 0, ConfigTrapDefenseBdBuffByGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseBdBuffByGroup.HandleId, ConfigTrapDefenseBdBuffByGroup.LogPair);
					return null;
				}
				TrapDefenseBdBuff rootAsTrapDefenseBdBuff = TrapDefenseBdBuff.GetRootAsTrapDefenseBdBuff(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseBdBuff);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdBuffByGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBdBuffByGroup.HandleId, ConfigTrapDefenseBdBuffByGroup.LogPair);
			return list;
		}

		// Token: 0x040046C6 RID: 18118
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046C7 RID: 18119
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x040046C8 RID: 18120
		private const string TABLE = "TrapDefenseBdBuff";

		// Token: 0x040046C9 RID: 18121
		private const string COMMAND = "select BinData from `TrapDefenseBdBuff` where GroupId=?";

		// Token: 0x040046CA RID: 18122
		private const string KEY_PREFIX = "TrapDefenseBdBuffByGroup";

		// Token: 0x040046CB RID: 18123
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046CC RID: 18124
		private static int HandleId;
	}
}
