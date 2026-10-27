using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A44 RID: 2628
	public class ConfigTrapDefenseTechByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DAC RID: 15788 RVA: 0x001B6874 File Offset: 0x001B4A74
		static ConfigTrapDefenseTechByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseTechByActivityId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseTechByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x001B6894 File Offset: 0x001B4A94
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

		// Token: 0x06003DAE RID: 15790 RVA: 0x001B6913 File Offset: 0x001B4B13
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseTechByActivityId.LogPair = null;
			ConfigTrapDefenseTechByActivityId.HandleId = 0;
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x001B6921 File Offset: 0x001B4B21
		public static void Init()
		{
			ConfigTrapDefenseTechByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseTechByActivityId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseTech` where ActivityId=?");
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x001B693C File Offset: 0x001B4B3C
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

		// Token: 0x040047C2 RID: 18370
		private const string DB = "db_trapdefense.db";

		// Token: 0x040047C3 RID: 18371
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x040047C4 RID: 18372
		private const string TABLE = "TrapDefenseTech";

		// Token: 0x040047C5 RID: 18373
		private const string COMMAND = "select BinData from `TrapDefenseTech` where ActivityId=?";

		// Token: 0x040047C6 RID: 18374
		private const string KEY_PREFIX = "TrapDefenseTechByActivityId";

		// Token: 0x040047C7 RID: 18375
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047C8 RID: 18376
		private static int HandleId;
	}
}
