using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072A RID: 1834
	public class ConfigPinballCreatureAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B0C RID: 11020 RVA: 0x00150334 File Offset: 0x0014E534
		static ConfigPinballCreatureAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballCreatureAll.CreateStaticDefaultValue), new Action(ConfigPinballCreatureAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x00150354 File Offset: 0x0014E554
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballCreatureAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballCreatureAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_局内.xlsx"),
				new ValueTuple<string, object>("表名", "PinballCreature"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballCreature`")
			});
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x001503D3 File Offset: 0x0014E5D3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballCreatureAll.LogPair = null;
			ConfigPinballCreatureAll.HandleId = 0;
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x001503E1 File Offset: 0x0014E5E1
		public static void Init()
		{
			ConfigPinballCreatureAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballCreatureAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballCreature`");
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x001503FC File Offset: 0x0014E5FC
		[NullableContext(2)]
		public static IReadOnlyList<PinballCreature> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballCreatureAll.HandleId, ConfigPinballCreatureAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PinballCreature> readOnlyList = (IReadOnlyList<PinballCreature>)ConfigCommon.GetConfig("PinballCreatureAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PinballCreature> list = new List<PinballCreature>();
			while (ConfigCommon.Step(ConfigPinballCreatureAll.HandleId, false, ConfigPinballCreatureAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballCreatureAll.HandleId, 0, ConfigPinballCreatureAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballCreatureAll.HandleId, ConfigPinballCreatureAll.LogPair);
					return null;
				}
				PinballCreature rootAsPinballCreature = PinballCreature.GetRootAsPinballCreature(new ByteBuffer(item2));
				list.Add(rootAsPinballCreature);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PinballCreatureAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballCreatureAll.HandleId, ConfigPinballCreatureAll.LogPair);
			return list;
		}

		// Token: 0x0400320C RID: 12812
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400320D RID: 12813
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x0400320E RID: 12814
		private const string TABLE = "PinballCreature";

		// Token: 0x0400320F RID: 12815
		private const string COMMAND = "select BinData from `PinballCreature`";

		// Token: 0x04003210 RID: 12816
		private const string KEY_PREFIX = "PinballCreatureAll";

		// Token: 0x04003211 RID: 12817
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003212 RID: 12818
		private static int HandleId;
	}
}
