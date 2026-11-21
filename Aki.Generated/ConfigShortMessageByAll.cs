using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000972 RID: 2418
	public class ConfigShortMessageByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038BF RID: 14527 RVA: 0x0019D6D0 File Offset: 0x0019B8D0
		static ConfigShortMessageByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShortMessageByAll.CreateStaticDefaultValue), new Action(ConfigShortMessageByAll.ResetStaticDefaultValue));
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x0019D6F0 File Offset: 0x0019B8F0
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

		// Token: 0x060038C1 RID: 14529 RVA: 0x0019D76F File Offset: 0x0019B96F
		public static void ResetStaticDefaultValue()
		{
			ConfigShortMessageByAll.LogPair = null;
			ConfigShortMessageByAll.HandleId = 0;
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x0019D77D File Offset: 0x0019B97D
		public static void Init()
		{
			ConfigShortMessageByAll.HandleId = ConfigCommon.InitDataStatement(ConfigShortMessageByAll.HandleId, "db_phonemsg.db", "select BinData from `ShortMessage`");
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x0019D798 File Offset: 0x0019B998
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

		// Token: 0x04004204 RID: 16900
		private const string DB = "db_phonemsg.db";

		// Token: 0x04004205 RID: 16901
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04004206 RID: 16902
		private const string TABLE = "ShortMessage";

		// Token: 0x04004207 RID: 16903
		private const string COMMAND = "select BinData from `ShortMessage`";

		// Token: 0x04004208 RID: 16904
		private const string KEY_PREFIX = "ShortMessageByAll";

		// Token: 0x04004209 RID: 16905
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400420A RID: 16906
		private static int HandleId;
	}
}
