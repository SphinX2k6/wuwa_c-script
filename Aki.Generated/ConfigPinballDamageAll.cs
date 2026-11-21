using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072E RID: 1838
	public class ConfigPinballDamageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B24 RID: 11044 RVA: 0x00150AEC File Offset: 0x0014ECEC
		static ConfigPinballDamageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballDamageAll.CreateStaticDefaultValue), new Action(ConfigPinballDamageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x00150B0C File Offset: 0x0014ED0C
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballDamageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballDamageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_局内.xlsx"),
				new ValueTuple<string, object>("表名", "PinballDamage"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballDamage`")
			});
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00150B8B File Offset: 0x0014ED8B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballDamageAll.LogPair = null;
			ConfigPinballDamageAll.HandleId = 0;
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x00150B99 File Offset: 0x0014ED99
		public static void Init()
		{
			ConfigPinballDamageAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballDamageAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballDamage`");
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x00150BB4 File Offset: 0x0014EDB4
		[NullableContext(2)]
		public static IReadOnlyList<PinballDamage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballDamageAll.HandleId, ConfigPinballDamageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PinballDamage> readOnlyList = (IReadOnlyList<PinballDamage>)ConfigCommon.GetConfig("PinballDamageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PinballDamage> list = new List<PinballDamage>();
			while (ConfigCommon.Step(ConfigPinballDamageAll.HandleId, false, ConfigPinballDamageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballDamageAll.HandleId, 0, ConfigPinballDamageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballDamageAll.HandleId, ConfigPinballDamageAll.LogPair);
					return null;
				}
				PinballDamage rootAsPinballDamage = PinballDamage.GetRootAsPinballDamage(new ByteBuffer(item2));
				list.Add(rootAsPinballDamage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PinballDamageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballDamageAll.HandleId, ConfigPinballDamageAll.LogPair);
			return list;
		}

		// Token: 0x04003228 RID: 12840
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003229 RID: 12841
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x0400322A RID: 12842
		private const string TABLE = "PinballDamage";

		// Token: 0x0400322B RID: 12843
		private const string COMMAND = "select BinData from `PinballDamage`";

		// Token: 0x0400322C RID: 12844
		private const string KEY_PREFIX = "PinballDamageAll";

		// Token: 0x0400322D RID: 12845
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400322E RID: 12846
		private static int HandleId;
	}
}
