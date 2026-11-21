using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B19 RID: 2841
	public class ConfigTrapDefenseTechByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042AA RID: 17066 RVA: 0x001D5C08 File Offset: 0x001D3E08
		static ConfigTrapDefenseTechByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseTechByActivityId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseTechByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x001D5C28 File Offset: 0x001D3E28
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseTechByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseTechByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseTech"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseTech` where ActivityId=?")
			});
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x001D5CA7 File Offset: 0x001D3EA7
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseTechByActivityId.LogPair = null;
			ConfigTrapDefenseTechByActivityId.HandleId = 0;
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x001D5CB5 File Offset: 0x001D3EB5
		public static void Init()
		{
			ConfigTrapDefenseTechByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseTechByActivityId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseTech` where ActivityId=?");
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x001D5CD0 File Offset: 0x001D3ED0
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseTech> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseTechByActivityId.HandleId, ConfigTrapDefenseTechByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseTechByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TrapDefenseTech> readOnlyList = (IReadOnlyList<TrapDefenseTech>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrapDefenseTechByActivityId.LogPair.Clear();
			ConfigTrapDefenseTechByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseTechByActivityId.HandleId, 1, p0ActivityId, ConfigTrapDefenseTechByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTrapDefenseTechByActivityId.HandleId, ConfigTrapDefenseTechByActivityId.LogPair);
				return null;
			}
			List<TrapDefenseTech> list = new List<TrapDefenseTech>();
			while (ConfigCommon.Step(ConfigTrapDefenseTechByActivityId.HandleId, false, ConfigTrapDefenseTechByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseTechByActivityId.HandleId, 0, ConfigTrapDefenseTechByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseTechByActivityId.HandleId, ConfigTrapDefenseTechByActivityId.LogPair);
					return null;
				}
				TrapDefenseTech rootAsTrapDefenseTech = TrapDefenseTech.GetRootAsTrapDefenseTech(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseTech);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseTechByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseTechByActivityId.HandleId, ConfigTrapDefenseTechByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004D95 RID: 19861
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D96 RID: 19862
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004D97 RID: 19863
		private const string TABLE = "TrapDefenseTech";

		// Token: 0x04004D98 RID: 19864
		private const string COMMAND = "select BinData from `TrapDefenseTech` where ActivityId=?";

		// Token: 0x04004D99 RID: 19865
		private const string KEY_PREFIX = "TrapDefenseTechByActivityId";

		// Token: 0x04004D9A RID: 19866
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D9B RID: 19867
		private static int HandleId;
	}
}
