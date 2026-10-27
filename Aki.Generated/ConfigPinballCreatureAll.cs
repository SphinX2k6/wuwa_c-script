using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000712 RID: 1810
	public class ConfigPinballCreatureAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A7C RID: 10876 RVA: 0x001498B8 File Offset: 0x00147AB8
		static ConfigPinballCreatureAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballCreatureAll.CreateStaticDefaultValue), new Action(ConfigPinballCreatureAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x001498D8 File Offset: 0x00147AD8
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

		// Token: 0x06002A7E RID: 10878 RVA: 0x00149957 File Offset: 0x00147B57
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballCreatureAll.LogPair = null;
			ConfigPinballCreatureAll.HandleId = 0;
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00149965 File Offset: 0x00147B65
		public static void Init()
		{
			ConfigPinballCreatureAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballCreatureAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballCreature`");
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00149980 File Offset: 0x00147B80
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

		// Token: 0x04003164 RID: 12644
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003165 RID: 12645
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x04003166 RID: 12646
		private const string TABLE = "PinballCreature";

		// Token: 0x04003167 RID: 12647
		private const string COMMAND = "select BinData from `PinballCreature`";

		// Token: 0x04003168 RID: 12648
		private const string KEY_PREFIX = "PinballCreatureAll";

		// Token: 0x04003169 RID: 12649
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400316A RID: 12650
		private static int HandleId;
	}
}
