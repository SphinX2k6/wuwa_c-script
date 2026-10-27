using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000012 RID: 18
	public class ConfigAbyssInstByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600006C RID: 108 RVA: 0x0005C5CF File Offset: 0x0005A7CF
		static ConfigAbyssInstByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssInstByActivityId.CreateStaticDefaultValue), new Action(ConfigAbyssInstByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0005C5F0 File Offset: 0x0005A7F0
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssInstByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssInstByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssInst"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssInst` where ActivityId=?")
			});
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0005C66F File Offset: 0x0005A86F
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssInstByActivityId.LogPair = null;
			ConfigAbyssInstByActivityId.HandleId = 0;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0005C67D File Offset: 0x0005A87D
		public static void Init()
		{
			ConfigAbyssInstByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssInstByActivityId.HandleId, "db_dangoabyss.db", "select BinData from `AbyssInst` where ActivityId=?");
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0005C698 File Offset: 0x0005A898
		[NullableContext(2)]
		public static IReadOnlyList<AbyssInst> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssInstByActivityId.HandleId, ConfigAbyssInstByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssInstByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<AbyssInst> readOnlyList = (IReadOnlyList<AbyssInst>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAbyssInstByActivityId.LogPair.Clear();
			ConfigAbyssInstByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigAbyssInstByActivityId.HandleId, 1, p0ActivityId, ConfigAbyssInstByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigAbyssInstByActivityId.HandleId, ConfigAbyssInstByActivityId.LogPair);
				return null;
			}
			List<AbyssInst> list = new List<AbyssInst>();
			while (ConfigCommon.Step(ConfigAbyssInstByActivityId.HandleId, false, ConfigAbyssInstByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssInstByActivityId.HandleId, 0, ConfigAbyssInstByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssInstByActivityId.HandleId, ConfigAbyssInstByActivityId.LogPair);
					return null;
				}
				AbyssInst rootAsAbyssInst = AbyssInst.GetRootAsAbyssInst(new ByteBuffer(item2));
				list.Add(rootAsAbyssInst);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssInstByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssInstByActivityId.HandleId, ConfigAbyssInstByActivityId.LogPair);
			return list;
		}

		// Token: 0x04000062 RID: 98
		private const string DB = "db_dangoabyss.db";

		// Token: 0x04000063 RID: 99
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x04000064 RID: 100
		private const string TABLE = "AbyssInst";

		// Token: 0x04000065 RID: 101
		private const string COMMAND = "select BinData from `AbyssInst` where ActivityId=?";

		// Token: 0x04000066 RID: 102
		private const string KEY_PREFIX = "AbyssInstByActivityId";

		// Token: 0x04000067 RID: 103
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000068 RID: 104
		private static int HandleId;
	}
}
