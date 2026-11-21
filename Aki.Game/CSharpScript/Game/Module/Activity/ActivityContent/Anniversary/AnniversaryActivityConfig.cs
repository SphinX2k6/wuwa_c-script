using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02005860 RID: 22624
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class AnniversaryActivityConfig : ConfigBase
	{
		// Token: 0x06037C73 RID: 228467 RVA: 0x00F98BEF File Offset: 0x00F96DEF
		public IReadOnlyList<AnniversaryEntrance> GetAnniversaryEntranceAll()
		{
			return ConfigAnniversaryEntranceAll.GetConfigList(true);
		}

		// Token: 0x06037C74 RID: 228468 RVA: 0x00F98BF7 File Offset: 0x00F96DF7
		public IReadOnlyList<PersonProgressCurve> GetPersonProgressCurveAll()
		{
			return ConfigPersonProgressCurveAll.GetConfigList(true);
		}

		// Token: 0x06037C75 RID: 228469 RVA: 0x00F98BFF File Offset: 0x00F96DFF
		public IReadOnlyList<WorldProgressCurve> GetWorldProgressCurveAll()
		{
			return ConfigWorldProgressCurveAll.GetConfigList(true);
		}

		// Token: 0x06037C76 RID: 228470 RVA: 0x00F98C07 File Offset: 0x00F96E07
		public AnniversaryEntrance? GetAnniversaryEntranceById(int id)
		{
			return ConfigAnniversaryEntranceById.GetConfig(id, true);
		}

		// Token: 0x06037C77 RID: 228471 RVA: 0x00F98C10 File Offset: 0x00F96E10
		public AnniversaryEntrance? GetAnniversaryEntranceByActivityId(int activityId)
		{
			return ConfigAnniversaryEntranceByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x06037C78 RID: 228472 RVA: 0x00F98C19 File Offset: 0x00F96E19
		public PersonProgressCurve? GetPersonProgressCurveById(int id)
		{
			return ConfigPersonProgressCurveById.GetConfig(id, true);
		}

		// Token: 0x06037C79 RID: 228473 RVA: 0x00F98C22 File Offset: 0x00F96E22
		public WorldProgressCurve? GetWorldProgressCurveById(int id)
		{
			return ConfigWorldProgressCurveById.GetConfig(id, true);
		}

		// Token: 0x06037C7A RID: 228474 RVA: 0x00F98C2C File Offset: 0x00F96E2C
		public IReadOnlyList<WorldProgressCurve> GetWorldProgressCurveHadReward()
		{
			IReadOnlyList<WorldProgressCurve> configList = ConfigWorldProgressCurveAll.GetConfigList(true);
			if (configList != null)
			{
				List<WorldProgressCurve> list = new List<WorldProgressCurve>();
				foreach (WorldProgressCurve item in configList)
				{
					if (item.DropId > 0)
					{
						list.Add(item);
					}
				}
				return list;
			}
			return null;
		}

		// Token: 0x17006B27 RID: 27431
		// (get) Token: 0x06037C7B RID: 228475 RVA: 0x00F98C94 File Offset: 0x00F96E94
		[Nullable(1)]
		public static AnniversaryActivityConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return AnniversaryActivityConfig._Instance;
			}
		}

		// Token: 0x06037C7C RID: 228476 RVA: 0x00F98C9B File Offset: 0x00F96E9B
		[NullableContext(1)]
		public static AnniversaryActivityConfig GetOrCreateInstance()
		{
			if (AnniversaryActivityConfig._Instance == null)
			{
				AnniversaryActivityConfig.CreateInstance();
			}
			return AnniversaryActivityConfig._Instance;
		}

		// Token: 0x06037C7D RID: 228477 RVA: 0x00F98CAF File Offset: 0x00F96EAF
		public static bool CreateInstance()
		{
			if (AnniversaryActivityConfig._Instance != null)
			{
				return true;
			}
			AnniversaryActivityConfig._Instance = new AnniversaryActivityConfig();
			return true;
		}

		// Token: 0x06037C7E RID: 228478 RVA: 0x00F98CC5 File Offset: 0x00F96EC5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037C7F RID: 228479 RVA: 0x00F98CC7 File Offset: 0x00F96EC7
		public static void ResetStaticDefaultValue()
		{
			AnniversaryActivityConfig._Instance = null;
		}

		// Token: 0x06037C80 RID: 228480 RVA: 0x00F98CCF File Offset: 0x00F96ECF
		static AnniversaryActivityConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AnniversaryActivityConfig.CreateStaticDefaultValue), new Action(AnniversaryActivityConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401D6ED RID: 120557
		private static AnniversaryActivityConfig _Instance;
	}
}
