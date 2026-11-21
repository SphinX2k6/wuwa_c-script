using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Npc.Controller
{
	// Token: 0x020062FE RID: 25342
	[NullableContext(1)]
	[Nullable(0)]
	public class TimetableSavedData
	{
		// Token: 0x0603D4B9 RID: 251065 RVA: 0x011B61B7 File Offset: 0x011B43B7
		public TimetableSavedData(TimetableConfigData config)
		{
			this.TimetableConfig = config;
		}

		// Token: 0x0603D4BA RID: 251066 RVA: 0x011B61DC File Offset: 0x011B43DC
		public TimetableSavedData DeepCopy()
		{
			TimetableSavedData timetableSavedData = new TimetableSavedData(this.TimetableConfig);
			timetableSavedData.BehaviorTreeData = this.BehaviorTreeData.DeepCopy();
			PatrolSavedData patrolData = this.PatrolData;
			timetableSavedData.PatrolData = ((patrolData != null) ? patrolData.DeepCopy() : null);
			timetableSavedData.SavedSelectedBTPath = this.SavedSelectedBTPath;
			return timetableSavedData;
		}

		// Token: 0x0603D4BB RID: 251067 RVA: 0x011B622C File Offset: 0x011B442C
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

		// Token: 0x04020835 RID: 133173
		[Nullable(2)]
		public TimetableConfigData TimetableConfig;

		// Token: 0x04020836 RID: 133174
		public BehaviorTreeSavedData BehaviorTreeData = new BehaviorTreeSavedData();

		// Token: 0x04020837 RID: 133175
		[Nullable(2)]
		public PatrolSavedData PatrolData;

		// Token: 0x04020838 RID: 133176
		public string SavedSelectedBTPath = "";
	}
}
