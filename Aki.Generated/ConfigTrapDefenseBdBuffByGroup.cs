using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF5 RID: 2805
	public class ConfigTrapDefenseBdBuffByGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041D2 RID: 16850 RVA: 0x001D0F83 File Offset: 0x001CF183
		static ConfigTrapDefenseBdBuffByGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdBuffByGroup.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdBuffByGroup.ResetStaticDefaultValue));
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x001D0FA4 File Offset: 0x001CF1A4
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

		// Token: 0x060041D4 RID: 16852 RVA: 0x001D1023 File Offset: 0x001CF223
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdBuffByGroup.LogPair = null;
			ConfigTrapDefenseBdBuffByGroup.HandleId = 0;
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x001D1031 File Offset: 0x001CF231
		public static void Init()
		{
			ConfigTrapDefenseBdBuffByGroup.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdBuffByGroup.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBdBuff` where GroupId=?");
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x001D104C File Offset: 0x001CF24C
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

		// Token: 0x04004C99 RID: 19609
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004C9A RID: 19610
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x04004C9B RID: 19611
		private const string TABLE = "TrapDefenseBdBuff";

		// Token: 0x04004C9C RID: 19612
		private const string COMMAND = "select BinData from `TrapDefenseBdBuff` where GroupId=?";

		// Token: 0x04004C9D RID: 19613
		private const string KEY_PREFIX = "TrapDefenseBdBuffByGroup";

		// Token: 0x04004C9E RID: 19614
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C9F RID: 19615
		private static int HandleId;
	}
}
