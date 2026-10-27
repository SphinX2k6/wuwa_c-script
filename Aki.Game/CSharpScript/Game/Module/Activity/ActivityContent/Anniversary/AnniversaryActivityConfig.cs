using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02006910 RID: 26896
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class AnniversaryActivityConfig : ConfigBase
	{
		// Token: 0x0604311B RID: 274715 RVA: 0x010575C3 File Offset: 0x010557C3
		public IReadOnlyList<AnniversaryEntrance> GetAnniversaryEntranceAll()
		{
			return ConfigAnniversaryEntranceAll.GetConfigList(true);
		}

		// Token: 0x0604311C RID: 274716 RVA: 0x010575CB File Offset: 0x010557CB
		public IReadOnlyList<PersonProgressCurve> GetPersonProgressCurveAll()
		{
			return ConfigPersonProgressCurveAll.GetConfigList(true);
		}

		// Token: 0x0604311D RID: 274717 RVA: 0x010575D3 File Offset: 0x010557D3
		public IReadOnlyList<WorldProgressCurve> GetWorldProgressCurveAll()
		{
			return ConfigWorldProgressCurveAll.GetConfigList(true);
		}

		// Token: 0x0604311E RID: 274718 RVA: 0x010575DB File Offset: 0x010557DB
		public AnniversaryEntrance? GetAnniversaryEntranceById(int id)
		{
			return ConfigAnniversaryEntranceById.GetConfig(id, true);
		}

		// Token: 0x0604311F RID: 274719 RVA: 0x010575E4 File Offset: 0x010557E4
		public AnniversaryEntrance? GetAnniversaryEntranceByActivityId(int activityId)
		{
			return ConfigAnniversaryEntranceByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x06043120 RID: 274720 RVA: 0x010575ED File Offset: 0x010557ED
		public PersonProgressCurve? GetPersonProgressCurveById(int id)
		{
			return ConfigPersonProgressCurveById.GetConfig(id, true);
		}

		// Token: 0x06043121 RID: 274721 RVA: 0x010575F6 File Offset: 0x010557F6
		public WorldProgressCurve? GetWorldProgressCurveById(int id)
		{
			return ConfigWorldProgressCurveById.GetConfig(id, true);
		}

		// Token: 0x06043122 RID: 274722 RVA: 0x01057600 File Offset: 0x01055800
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

		// Token: 0x170097E7 RID: 38887
		// (get) Token: 0x06043123 RID: 274723 RVA: 0x01057668 File Offset: 0x01055868
		[Nullable(1)]
		public static AnniversaryActivityConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return AnniversaryActivityConfig._Instance;
			}
		}

		// Token: 0x06043124 RID: 274724 RVA: 0x0105766F File Offset: 0x0105586F
		[NullableContext(1)]
		public static AnniversaryActivityConfig GetOrCreateInstance()
		{
			if (AnniversaryActivityConfig._Instance == null)
			{
				AnniversaryActivityConfig.CreateInstance();
			}
			return AnniversaryActivityConfig._Instance;
		}

		// Token: 0x06043125 RID: 274725 RVA: 0x01057683 File Offset: 0x01055883
		public static bool CreateInstance()
		{
			if (AnniversaryActivityConfig._Instance != null)
			{
				return true;
			}
			AnniversaryActivityConfig._Instance = new AnniversaryActivityConfig();
			return true;
		}

		// Token: 0x06043126 RID: 274726 RVA: 0x01057699 File Offset: 0x01055899
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043127 RID: 274727 RVA: 0x0105769B File Offset: 0x0105589B
		public static void ResetStaticDefaultValue()
		{
			AnniversaryActivityConfig._Instance = null;
		}

		// Token: 0x06043128 RID: 274728 RVA: 0x010576A3 File Offset: 0x010558A3
		static AnniversaryActivityConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AnniversaryActivityConfig.CreateStaticDefaultValue), new Action(AnniversaryActivityConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04022E91 RID: 142993
		private static AnniversaryActivityConfig _Instance;
	}
}
