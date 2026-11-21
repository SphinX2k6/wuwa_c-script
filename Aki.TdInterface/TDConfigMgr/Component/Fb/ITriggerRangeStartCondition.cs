using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C47 RID: 3143
	public class ITriggerRangeStartCondition : ISpawnMonsterStartCondition
	{
		// Token: 0x06004800 RID: 18432 RVA: 0x000B6643 File Offset: 0x000B4843
		public static ITriggerRangeStartCondition Create(ITriggerRangeStartCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerRangeStartCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06004801 RID: 18433 RVA: 0x000B6662 File Offset: 0x000B4862
		public override ESpawnMonsterStartCondition Type
		{
			get
			{
				return (ESpawnMonsterStartCondition)this.Instance.Type;
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06004802 RID: 18434 RVA: 0x000B666F File Offset: 0x000B486F
		public virtual int Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x04002872 RID: 10354
		private ITriggerRangeStartCondition Instance;
	}
}
