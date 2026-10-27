using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F5 RID: 501
	public class ConfigDarkCoastDeliveryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BC1 RID: 3009 RVA: 0x0009C278 File Offset: 0x0009A478
		static ConfigDarkCoastDeliveryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDarkCoastDeliveryAll.CreateStaticDefaultValue), new Action(ConfigDarkCoastDeliveryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0009C298 File Offset: 0x0009A498
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

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0009C317 File Offset: 0x0009A517
		public static void ResetStaticDefaultValue()
		{
			ConfigDarkCoastDeliveryAll.LogPair = null;
			ConfigDarkCoastDeliveryAll.HandleId = 0;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0009C325 File Offset: 0x0009A525
		public static void Init()
		{
			ConfigDarkCoastDeliveryAll.HandleId = ConfigCommon.InitDataStatement(ConfigDarkCoastDeliveryAll.HandleId, "db_dragon_ball.db", "select BinData from `DarkCoastDelivery`");
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0009C340 File Offset: 0x0009A540
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

		// Token: 0x04000D97 RID: 3479
		private const string DB = "db_dragon_ball.db";

		// Token: 0x04000D98 RID: 3480
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x04000D99 RID: 3481
		private const string TABLE = "DarkCoastDelivery";

		// Token: 0x04000D9A RID: 3482
		private const string COMMAND = "select BinData from `DarkCoastDelivery`";

		// Token: 0x04000D9B RID: 3483
		private const string KEY_PREFIX = "DarkCoastDeliveryAll";

		// Token: 0x04000D9C RID: 3484
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D9D RID: 3485
		private static int HandleId;
	}
}
