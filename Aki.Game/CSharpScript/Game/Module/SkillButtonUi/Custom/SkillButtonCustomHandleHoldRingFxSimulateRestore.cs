using System;
using System.Collections.Generic;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02003BD6 RID: 15318
	public class SkillButtonCustomHandleHoldRingFxSimulateRestore : SkillButtonCustomHandleBase
	{
		// Token: 0x060274DA RID: 160986 RVA: 0x00B062E4 File Offset: 0x00B044E4
		public override void Refresh()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.Params.Count < 1 || this.Params.Count != this.TagIds.Count)
			{
				return;
			}
			this.SkillButtonData.HoldRingFxRestoreMap = new Dictionary<int, int>();
			for (int i = 0; i < this.Params.Count; i++)
			{
				this.SkillButtonData.HoldRingFxRestoreMap.Add(this.TagIds[i], int.Parse(this.Params[i]));
			}
			this.CustomHdModifyMark = true;
			this.CustomHdMarkFrom = 7;
		}
	}
}
