using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000577 RID: 1399
	public class ConfigMoraleAreaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020D7 RID: 8407 RVA: 0x001169C8 File Offset: 0x00114BC8
		static ConfigMoraleAreaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleAreaAll.CreateStaticDefaultValue), new Action(ConfigMoraleAreaAll.ResetStaticDefaultValue));
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x001169E8 File Offset: 0x00114BE8
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleAreaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleAreaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleArea"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleArea`")
			});
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00116A67 File Offset: 0x00114C67
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleAreaAll.LogPair = null;
			ConfigMoraleAreaAll.HandleId = 0;
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00116A75 File Offset: 0x00114C75
		public static void Init()
		{
			ConfigMoraleAreaAll.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleAreaAll.HandleId, "db_moraleplay.db", "select BinData from `MoraleArea`");
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00116A90 File Offset: 0x00114C90
		[NullableContext(2)]
		public static IReadOnlyList<MoraleArea> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleAreaAll.HandleId, ConfigMoraleAreaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MoraleArea> readOnlyList = (IReadOnlyList<MoraleArea>)ConfigCommon.GetConfig("MoraleAreaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MoraleArea> list = new List<MoraleArea>();
			while (ConfigCommon.Step(ConfigMoraleAreaAll.HandleId, false, ConfigMoraleAreaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleAreaAll.HandleId, 0, ConfigMoraleAreaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMoraleAreaAll.HandleId, ConfigMoraleAreaAll.LogPair);
					return null;
				}
				MoraleArea rootAsMoraleArea = MoraleArea.GetRootAsMoraleArea(new ByteBuffer(item2));
				list.Add(rootAsMoraleArea);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MoraleAreaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMoraleAreaAll.HandleId, ConfigMoraleAreaAll.LogPair);
			return list;
		}

		// Token: 0x04002625 RID: 9765
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002626 RID: 9766
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002627 RID: 9767
		private const string TABLE = "MoraleArea";

		// Token: 0x04002628 RID: 9768
		private const string COMMAND = "select BinData from `MoraleArea`";

		// Token: 0x04002629 RID: 9769
		private const string KEY_PREFIX = "MoraleAreaAll";

		// Token: 0x0400262A RID: 9770
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400262B RID: 9771
		private static int HandleId;
	}
}
