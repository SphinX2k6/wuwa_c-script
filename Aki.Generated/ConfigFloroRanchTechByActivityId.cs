using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000342 RID: 834
	public class ConfigFloroRanchTechByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001391 RID: 5009 RVA: 0x000CB83C File Offset: 0x000C9A3C
		static ConfigFloroRanchTechByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTechByActivityId.CreateStaticDefaultValue), new Action(ConfigFloroRanchTechByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x000CB85C File Offset: 0x000C9A5C
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

		// Token: 0x06001393 RID: 5011 RVA: 0x000CB8DB File Offset: 0x000C9ADB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTechByActivityId.LogPair = null;
			ConfigFloroRanchTechByActivityId.HandleId = 0;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x000CB8E9 File Offset: 0x000C9AE9
		public static void Init()
		{
			ConfigFloroRanchTechByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTechByActivityId.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTech` where ActivityId=?");
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x000CB904 File Offset: 0x000C9B04
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

		// Token: 0x040016B2 RID: 5810
		private const string DB = "db_flororanch.db";

		// Token: 0x040016B3 RID: 5811
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040016B4 RID: 5812
		private const string TABLE = "FloroRanchTech";

		// Token: 0x040016B5 RID: 5813
		private const string COMMAND = "select BinData from `FloroRanchTech` where ActivityId=?";

		// Token: 0x040016B6 RID: 5814
		private const string KEY_PREFIX = "FloroRanchTechByActivityId";

		// Token: 0x040016B7 RID: 5815
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016B8 RID: 5816
		private static int HandleId;
	}
}
