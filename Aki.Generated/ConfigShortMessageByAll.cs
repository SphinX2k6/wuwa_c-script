using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000927 RID: 2343
	public class ConfigShortMessageByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036FD RID: 14077 RVA: 0x001904B0 File Offset: 0x0018E6B0
		static ConfigShortMessageByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShortMessageByAll.CreateStaticDefaultValue), new Action(ConfigShortMessageByAll.ResetStaticDefaultValue));
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x001904D0 File Offset: 0x0018E6D0
		public static void CreateStaticDefaultValue()
		{
			ConfigShortMessageByAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigShortMessageByAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ShortMessage"),
				new ValueTuple<string, object>("语句", "select BinData from `ShortMessage`")
			});
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x0019054F File Offset: 0x0018E74F
		public static void ResetStaticDefaultValue()
		{
			ConfigShortMessageByAll.LogPair = null;
			ConfigShortMessageByAll.HandleId = 0;
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x0019055D File Offset: 0x0018E75D
		public static void Init()
		{
			ConfigShortMessageByAll.HandleId = ConfigCommon.InitDataStatement(ConfigShortMessageByAll.HandleId, "db_phonemsg.db", "select BinData from `ShortMessage`");
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x00190578 File Offset: 0x0018E778
		[NullableContext(2)]
		public static IReadOnlyList<ShortMessage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigShortMessageByAll.HandleId, ConfigShortMessageByAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ShortMessage> readOnlyList = (IReadOnlyList<ShortMessage>)ConfigCommon.GetConfig("ShortMessageByAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ShortMessage> list = new List<ShortMessage>();
			while (ConfigCommon.Step(ConfigShortMessageByAll.HandleId, false, ConfigShortMessageByAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigShortMessageByAll.HandleId, 0, ConfigShortMessageByAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigShortMessageByAll.HandleId, ConfigShortMessageByAll.LogPair);
					return null;
				}
				ShortMessage rootAsShortMessage = ShortMessage.GetRootAsShortMessage(new ByteBuffer(item2));
				list.Add(rootAsShortMessage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ShortMessageByAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigShortMessageByAll.HandleId, ConfigShortMessageByAll.LogPair);
			return list;
		}

		// Token: 0x04003FF7 RID: 16375
		private const string DB = "db_phonemsg.db";

		// Token: 0x04003FF8 RID: 16376
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04003FF9 RID: 16377
		private const string TABLE = "ShortMessage";

		// Token: 0x04003FFA RID: 16378
		private const string COMMAND = "select BinData from `ShortMessage`";

		// Token: 0x04003FFB RID: 16379
		private const string KEY_PREFIX = "ShortMessageByAll";

		// Token: 0x04003FFC RID: 16380
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FFD RID: 16381
		private static int HandleId;
	}
}
