using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A1 RID: 161
	public class ConfigAnimalStandbyMontageByBp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x00072680 File Offset: 0x00070880
		static ConfigAnimalStandbyMontageByBp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnimalStandbyMontageByBp.CreateStaticDefaultValue), new Action(ConfigAnimalStandbyMontageByBp.ResetStaticDefaultValue));
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000726A0 File Offset: 0x000708A0
		public static void CreateStaticDefaultValue()
		{
			ConfigAnimalStandbyMontageByBp.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAnimalStandbyMontageByBp.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_animalstandbymotnageconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/d.动物待机动作/*.csv*"),
				new ValueTuple<string, object>("表名", "AnimalStandbyMontage"),
				new ValueTuple<string, object>("语句", "select BinData from `AnimalStandbyMontage` where Bp=?")
			});
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0007271F File Offset: 0x0007091F
		public static void ResetStaticDefaultValue()
		{
			ConfigAnimalStandbyMontageByBp.LogPair = null;
			ConfigAnimalStandbyMontageByBp.HandleId = 0;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0007272D File Offset: 0x0007092D
		public static void Init()
		{
			ConfigAnimalStandbyMontageByBp.HandleId = ConfigCommon.InitDataStatement(ConfigAnimalStandbyMontageByBp.HandleId, "db_animalstandbymotnageconfig.db", "select BinData from `AnimalStandbyMontage` where Bp=?");
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00072748 File Offset: 0x00070948
		[return: Nullable(2)]
		public static IReadOnlyList<AnimalStandbyMontage> GetConfigList(string p0Bp, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAnimalStandbyMontageByBp.HandleId, ConfigAnimalStandbyMontageByBp.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AnimalStandbyMontage> readOnlyList = (IReadOnlyList<AnimalStandbyMontage>)ConfigCommon.GetConfig("AnimalStandbyMontageByBp#" + p0Bp);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAnimalStandbyMontageByBp.LogPair.Clear();
			ConfigAnimalStandbyMontageByBp.LogPair.Add(new ValueTuple<string, object>("Bp", p0Bp));
			if (!ConfigCommon.BindString(ConfigAnimalStandbyMontageByBp.HandleId, 1, p0Bp, ConfigAnimalStandbyMontageByBp.LogPair))
			{
				ConfigCommon.Reset(ConfigAnimalStandbyMontageByBp.HandleId, ConfigAnimalStandbyMontageByBp.LogPair);
				return null;
			}
			List<AnimalStandbyMontage> list = new List<AnimalStandbyMontage>();
			while (ConfigCommon.Step(ConfigAnimalStandbyMontageByBp.HandleId, false, ConfigAnimalStandbyMontageByBp.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAnimalStandbyMontageByBp.HandleId, 0, ConfigAnimalStandbyMontageByBp.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAnimalStandbyMontageByBp.HandleId, ConfigAnimalStandbyMontageByBp.LogPair);
					return null;
				}
				AnimalStandbyMontage rootAsAnimalStandbyMontage = AnimalStandbyMontage.GetRootAsAnimalStandbyMontage(new ByteBuffer(item2));
				list.Add(rootAsAnimalStandbyMontage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AnimalStandbyMontageByBp#" + p0Bp, list, list.Count);
			}
			ConfigCommon.Reset(ConfigAnimalStandbyMontageByBp.HandleId, ConfigAnimalStandbyMontageByBp.LogPair);
			return list;
		}

		// Token: 0x0400044B RID: 1099
		private const string DB = "db_animalstandbymotnageconfig.db";

		// Token: 0x0400044C RID: 1100
		private const string FILE = "k.可视化编辑/c.Csv/d.动物待机动作/*.csv*";

		// Token: 0x0400044D RID: 1101
		private const string TABLE = "AnimalStandbyMontage";

		// Token: 0x0400044E RID: 1102
		private const string COMMAND = "select BinData from `AnimalStandbyMontage` where Bp=?";

		// Token: 0x0400044F RID: 1103
		private const string KEY_PREFIX = "AnimalStandbyMontageByBp";

		// Token: 0x04000450 RID: 1104
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000451 RID: 1105
		private static int HandleId;
	}
}
