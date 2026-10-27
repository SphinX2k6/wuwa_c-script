using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000099 RID: 153
	public class ConfigAnimalStandbyMontageByBp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000396 RID: 918 RVA: 0x0006DDCC File Offset: 0x0006BFCC
		static ConfigAnimalStandbyMontageByBp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnimalStandbyMontageByBp.CreateStaticDefaultValue), new Action(ConfigAnimalStandbyMontageByBp.ResetStaticDefaultValue));
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0006DDEC File Offset: 0x0006BFEC
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

		// Token: 0x06000398 RID: 920 RVA: 0x0006DE6B File Offset: 0x0006C06B
		public static void ResetStaticDefaultValue()
		{
			ConfigAnimalStandbyMontageByBp.LogPair = null;
			ConfigAnimalStandbyMontageByBp.HandleId = 0;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0006DE79 File Offset: 0x0006C079
		public static void Init()
		{
			ConfigAnimalStandbyMontageByBp.HandleId = ConfigCommon.InitDataStatement(ConfigAnimalStandbyMontageByBp.HandleId, "db_animalstandbymotnageconfig.db", "select BinData from `AnimalStandbyMontage` where Bp=?");
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0006DE94 File Offset: 0x0006C094
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

		// Token: 0x04000413 RID: 1043
		private const string DB = "db_animalstandbymotnageconfig.db";

		// Token: 0x04000414 RID: 1044
		private const string FILE = "k.可视化编辑/c.Csv/d.动物待机动作/*.csv*";

		// Token: 0x04000415 RID: 1045
		private const string TABLE = "AnimalStandbyMontage";

		// Token: 0x04000416 RID: 1046
		private const string COMMAND = "select BinData from `AnimalStandbyMontage` where Bp=?";

		// Token: 0x04000417 RID: 1047
		private const string KEY_PREFIX = "AnimalStandbyMontageByBp";

		// Token: 0x04000418 RID: 1048
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000419 RID: 1049
		private static int HandleId;
	}
}
