using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032D RID: 813
	public class ConfigFloroRanchTechByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001313 RID: 4883 RVA: 0x000C5330 File Offset: 0x000C3530
		static ConfigFloroRanchTechByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTechByActivityId.CreateStaticDefaultValue), new Action(ConfigFloroRanchTechByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x000C5350 File Offset: 0x000C3550
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTechByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTechByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTech"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTech` where ActivityId=?")
			});
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x000C53CF File Offset: 0x000C35CF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTechByActivityId.LogPair = null;
			ConfigFloroRanchTechByActivityId.HandleId = 0;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x000C53DD File Offset: 0x000C35DD
		public static void Init()
		{
			ConfigFloroRanchTechByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTechByActivityId.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTech` where ActivityId=?");
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x000C53F8 File Offset: 0x000C35F8
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchTech> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTechByActivityId.HandleId, ConfigFloroRanchTechByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTechByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<FloroRanchTech> readOnlyList = (IReadOnlyList<FloroRanchTech>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFloroRanchTechByActivityId.LogPair.Clear();
			ConfigFloroRanchTechByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFloroRanchTechByActivityId.HandleId, 1, p0ActivityId, ConfigFloroRanchTechByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigFloroRanchTechByActivityId.HandleId, ConfigFloroRanchTechByActivityId.LogPair);
				return null;
			}
			List<FloroRanchTech> list = new List<FloroRanchTech>();
			while (ConfigCommon.Step(ConfigFloroRanchTechByActivityId.HandleId, false, ConfigFloroRanchTechByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTechByActivityId.HandleId, 0, ConfigFloroRanchTechByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchTechByActivityId.HandleId, ConfigFloroRanchTechByActivityId.LogPair);
					return null;
				}
				FloroRanchTech rootAsFloroRanchTech = FloroRanchTech.GetRootAsFloroRanchTech(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchTech);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTechByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchTechByActivityId.HandleId, ConfigFloroRanchTechByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400161F RID: 5663
		private const string DB = "db_flororanch.db";

		// Token: 0x04001620 RID: 5664
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001621 RID: 5665
		private const string TABLE = "FloroRanchTech";

		// Token: 0x04001622 RID: 5666
		private const string COMMAND = "select BinData from `FloroRanchTech` where ActivityId=?";

		// Token: 0x04001623 RID: 5667
		private const string KEY_PREFIX = "FloroRanchTechByActivityId";

		// Token: 0x04001624 RID: 5668
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001625 RID: 5669
		private static int HandleId;
	}
}
