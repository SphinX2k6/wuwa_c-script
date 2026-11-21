using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000207 RID: 519
	public class ConfigDarkCoastDeliveryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C2D RID: 3117 RVA: 0x000A21B0 File Offset: 0x000A03B0
		static ConfigDarkCoastDeliveryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDarkCoastDeliveryAll.CreateStaticDefaultValue), new Action(ConfigDarkCoastDeliveryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000A21D0 File Offset: 0x000A03D0
		public static void CreateStaticDefaultValue()
		{
			ConfigDarkCoastDeliveryAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDarkCoastDeliveryAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dragon_ball.db"),
				new ValueTuple<string, object>("文件", "m.鸣素体.xlsx"),
				new ValueTuple<string, object>("表名", "DarkCoastDelivery"),
				new ValueTuple<string, object>("语句", "select BinData from `DarkCoastDelivery`")
			});
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000A224F File Offset: 0x000A044F
		public static void ResetStaticDefaultValue()
		{
			ConfigDarkCoastDeliveryAll.LogPair = null;
			ConfigDarkCoastDeliveryAll.HandleId = 0;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000A225D File Offset: 0x000A045D
		public static void Init()
		{
			ConfigDarkCoastDeliveryAll.HandleId = ConfigCommon.InitDataStatement(ConfigDarkCoastDeliveryAll.HandleId, "db_dragon_ball.db", "select BinData from `DarkCoastDelivery`");
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x000A2278 File Offset: 0x000A0478
		[NullableContext(2)]
		public static IReadOnlyList<DarkCoastDelivery> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDarkCoastDeliveryAll.HandleId, ConfigDarkCoastDeliveryAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DarkCoastDelivery> readOnlyList = (IReadOnlyList<DarkCoastDelivery>)ConfigCommon.GetConfig("DarkCoastDeliveryAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DarkCoastDelivery> list = new List<DarkCoastDelivery>();
			while (ConfigCommon.Step(ConfigDarkCoastDeliveryAll.HandleId, false, ConfigDarkCoastDeliveryAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDarkCoastDeliveryAll.HandleId, 0, ConfigDarkCoastDeliveryAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDarkCoastDeliveryAll.HandleId, ConfigDarkCoastDeliveryAll.LogPair);
					return null;
				}
				DarkCoastDelivery rootAsDarkCoastDelivery = DarkCoastDelivery.GetRootAsDarkCoastDelivery(new ByteBuffer(item2));
				list.Add(rootAsDarkCoastDelivery);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DarkCoastDeliveryAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDarkCoastDeliveryAll.HandleId, ConfigDarkCoastDeliveryAll.LogPair);
			return list;
		}

		// Token: 0x04000E15 RID: 3605
		private const string DB = "db_dragon_ball.db";

		// Token: 0x04000E16 RID: 3606
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x04000E17 RID: 3607
		private const string TABLE = "DarkCoastDelivery";

		// Token: 0x04000E18 RID: 3608
		private const string COMMAND = "select BinData from `DarkCoastDelivery`";

		// Token: 0x04000E19 RID: 3609
		private const string KEY_PREFIX = "DarkCoastDeliveryAll";

		// Token: 0x04000E1A RID: 3610
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E1B RID: 3611
		private static int HandleId;
	}
}
