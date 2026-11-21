using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058E8 RID: 22760
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolDayEndTask : SolarSchoolTaskBase
	{
		// Token: 0x060381CA RID: 229834 RVA: 0x00FAEC3F File Offset: 0x00FACE3F
		public SolarSchoolDayEndTask(List<SolarSchoolActionBase> actions)
		{
			this.Actions = actions;
		}

		// Token: 0x060381CB RID: 229835 RVA: 0x00FAEC4E File Offset: 0x00FACE4E
		protected override void OnExecute()
		{
			base.RunThen(this.Actions, delegate()
			{
				base.Complete(null);
			});
		}

		// Token: 0x0401D8E7 RID: 121063
		private readonly List<SolarSchoolActionBase> Actions;
	}
}
