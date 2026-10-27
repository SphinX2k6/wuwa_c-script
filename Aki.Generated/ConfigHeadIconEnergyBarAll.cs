using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D1 RID: 977
	public class ConfigHeadIconEnergyBarAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016ED RID: 5869 RVA: 0x000DB1D4 File Offset: 0x000D93D4
		static ConfigHeadIconEnergyBarAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHeadIconEnergyBarAll.CreateStaticDefaultValue), new Action(ConfigHeadIconEnergyBarAll.ResetStaticDefaultValue));
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x000DB1F4 File Offset: 0x000D93F4
		public static void CreateStaticDefaultValue()
		{
			ConfigHeadIconEnergyBarAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHeadIconEnergyBarAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battleheadicon.db"),
				new ValueTuple<string, object>("文件", "j.角色战斗界面头像.xlsx"),
				new ValueTuple<string, object>("表名", "HeadIconEnergyBar"),
				new ValueTuple<string, object>("语句", "select BinData from `HeadIconEnergyBar`")
			});
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x000DB273 File Offset: 0x000D9473
		public static void ResetStaticDefaultValue()
		{
			ConfigHeadIconEnergyBarAll.LogPair = null;
			ConfigHeadIconEnergyBarAll.HandleId = 0;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x000DB281 File Offset: 0x000D9481
		public static void Init()
		{
			ConfigHeadIconEnergyBarAll.HandleId = ConfigCommon.InitDataStatement(ConfigHeadIconEnergyBarAll.HandleId, "db_battleheadicon.db", "select BinData from `HeadIconEnergyBar`");
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x000DB29C File Offset: 0x000D949C
		[NullableContext(2)]
		public static IReadOnlyList<HeadIconEnergyBar> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHeadIconEnergyBarAll.HandleId, ConfigHeadIconEnergyBarAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<HeadIconEnergyBar> readOnlyList = (IReadOnlyList<HeadIconEnergyBar>)ConfigCommon.GetConfig("HeadIconEnergyBarAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<HeadIconEnergyBar> list = new List<HeadIconEnergyBar>();
			while (ConfigCommon.Step(ConfigHeadIconEnergyBarAll.HandleId, false, ConfigHeadIconEnergyBarAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHeadIconEnergyBarAll.HandleId, 0, ConfigHeadIconEnergyBarAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHeadIconEnergyBarAll.HandleId, ConfigHeadIconEnergyBarAll.LogPair);
					return null;
				}
				HeadIconEnergyBar rootAsHeadIconEnergyBar = HeadIconEnergyBar.GetRootAsHeadIconEnergyBar(new ByteBuffer(item2));
				list.Add(rootAsHeadIconEnergyBar);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("HeadIconEnergyBarAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigHeadIconEnergyBarAll.HandleId, ConfigHeadIconEnergyBarAll.LogPair);
			return list;
		}

		// Token: 0x04001A9B RID: 6811
		private const string DB = "db_battleheadicon.db";

		// Token: 0x04001A9C RID: 6812
		private const string FILE = "j.角色战斗界面头像.xlsx";

		// Token: 0x04001A9D RID: 6813
		private const string TABLE = "HeadIconEnergyBar";

		// Token: 0x04001A9E RID: 6814
		private const string COMMAND = "select BinData from `HeadIconEnergyBar`";

		// Token: 0x04001A9F RID: 6815
		private const string KEY_PREFIX = "HeadIconEnergyBarAll";

		// Token: 0x04001AA0 RID: 6816
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AA1 RID: 6817
		private static int HandleId;
	}
}
