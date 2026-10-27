using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031C RID: 796
	public class ConfigFloroRanchInsByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012AD RID: 4781 RVA: 0x000C301C File Offset: 0x000C121C
		static ConfigFloroRanchInsByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchInsByActivityId.CreateStaticDefaultValue), new Action(ConfigFloroRanchInsByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000C303C File Offset: 0x000C123C
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchInsByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchInsByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchIns"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchIns` where ActivityId=?")
			});
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000C30BB File Offset: 0x000C12BB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchInsByActivityId.LogPair = null;
			ConfigFloroRanchInsByActivityId.HandleId = 0;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000C30C9 File Offset: 0x000C12C9
		public static void Init()
		{
			ConfigFloroRanchInsByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchInsByActivityId.HandleId, "db_flororanch.db", "select BinData from `FloroRanchIns` where ActivityId=?");
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x000C30E4 File Offset: 0x000C12E4
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchIns> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchInsByActivityId.HandleId, ConfigFloroRanchInsByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchInsByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<FloroRanchIns> readOnlyList = (IReadOnlyList<FloroRanchIns>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFloroRanchInsByActivityId.LogPair.Clear();
			ConfigFloroRanchInsByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFloroRanchInsByActivityId.HandleId, 1, p0ActivityId, ConfigFloroRanchInsByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigFloroRanchInsByActivityId.HandleId, ConfigFloroRanchInsByActivityId.LogPair);
				return null;
			}
			List<FloroRanchIns> list = new List<FloroRanchIns>();
			while (ConfigCommon.Step(ConfigFloroRanchInsByActivityId.HandleId, false, ConfigFloroRanchInsByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchInsByActivityId.HandleId, 0, ConfigFloroRanchInsByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchInsByActivityId.HandleId, ConfigFloroRanchInsByActivityId.LogPair);
					return null;
				}
				FloroRanchIns rootAsFloroRanchIns = FloroRanchIns.GetRootAsFloroRanchIns(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchIns);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchInsByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchInsByActivityId.HandleId, ConfigFloroRanchInsByActivityId.LogPair);
			return list;
		}

		// Token: 0x040015A8 RID: 5544
		private const string DB = "db_flororanch.db";

		// Token: 0x040015A9 RID: 5545
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015AA RID: 5546
		private const string TABLE = "FloroRanchIns";

		// Token: 0x040015AB RID: 5547
		private const string COMMAND = "select BinData from `FloroRanchIns` where ActivityId=?";

		// Token: 0x040015AC RID: 5548
		private const string KEY_PREFIX = "FloroRanchInsByActivityId";

		// Token: 0x040015AD RID: 5549
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015AE RID: 5550
		private static int HandleId;
	}
}
