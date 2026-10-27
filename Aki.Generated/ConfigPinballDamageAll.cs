using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000716 RID: 1814
	public class ConfigPinballDamageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A94 RID: 10900 RVA: 0x0014A070 File Offset: 0x00148270
		static ConfigPinballDamageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballDamageAll.CreateStaticDefaultValue), new Action(ConfigPinballDamageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x0014A090 File Offset: 0x00148290
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

		// Token: 0x06002A96 RID: 10902 RVA: 0x0014A10F File Offset: 0x0014830F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballDamageAll.LogPair = null;
			ConfigPinballDamageAll.HandleId = 0;
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x0014A11D File Offset: 0x0014831D
		public static void Init()
		{
			ConfigPinballDamageAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballDamageAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballDamage`");
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x0014A138 File Offset: 0x00148338
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

		// Token: 0x04003180 RID: 12672
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003181 RID: 12673
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x04003182 RID: 12674
		private const string TABLE = "PinballDamage";

		// Token: 0x04003183 RID: 12675
		private const string COMMAND = "select BinData from `PinballDamage`";

		// Token: 0x04003184 RID: 12676
		private const string KEY_PREFIX = "PinballDamageAll";

		// Token: 0x04003185 RID: 12677
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003186 RID: 12678
		private static int HandleId;
	}
}
