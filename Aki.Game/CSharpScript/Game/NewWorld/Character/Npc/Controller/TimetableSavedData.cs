using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Npc.Controller
{
	// Token: 0x02007099 RID: 28825
	[NullableContext(1)]
	[Nullable(0)]
	public class TimetableSavedData
	{
		// Token: 0x060463CE RID: 287694 RVA: 0x011930AB File Offset: 0x011912AB
		public TimetableSavedData(TimetableConfigData config)
		{
			this.TimetableConfig = config;
		}

		// Token: 0x060463CF RID: 287695 RVA: 0x011930D0 File Offset: 0x011912D0
		public TimetableSavedData DeepCopy()
		{
			TimetableSavedData timetableSavedData = new TimetableSavedData(this.TimetableConfig);
			timetableSavedData.BehaviorTreeData = this.BehaviorTreeData.DeepCopy();
			PatrolSavedData patrolData = this.PatrolData;
			timetableSavedData.PatrolData = ((patrolData != null) ? patrolData.DeepCopy() : null);
			timetableSavedData.SavedSelectedBTPath = this.SavedSelectedBTPath;
			return timetableSavedData;
		}

		// Token: 0x060463D0 RID: 287696 RVA: 0x01193120 File Offset: 0x01191320
		public bool IsValid()
		{
			if (this.TimetableConfig == null)
			{
				return false;
			}
			if (this.SavedSelectedBTPath != this.BehaviorTreeData.Path)
			{
				return false;
			}
			if (!this.BehaviorTreeData.IsValid())
			{
				PatrolSavedData patrolData = this.PatrolData;
				if (patrolData == null || !patrolData.IsValid())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024CE3 RID: 150755
		[Nullable(2)]
		public TimetableConfigData TimetableConfig;

		// Token: 0x04024CE4 RID: 150756
		public BehaviorTreeSavedData BehaviorTreeData = new BehaviorTreeSavedData();

		// Token: 0x04024CE5 RID: 150757
		[Nullable(2)]
		public PatrolSavedData PatrolData;

		// Token: 0x04024CE6 RID: 150758
		public string SavedSelectedBTPath = "";
	}
}
