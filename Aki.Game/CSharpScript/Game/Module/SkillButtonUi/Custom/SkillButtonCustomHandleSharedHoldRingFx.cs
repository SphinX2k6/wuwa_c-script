using System;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02004C24 RID: 19492
	public class SkillButtonCustomHandleSharedHoldRingFx : SkillButtonCustomHandleBase
	{
		// Token: 0x06032725 RID: 206629 RVA: 0x00BC1638 File Offset: 0x00BBF838
		public override void Refresh()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.Params.Count < 2)
			{
				return;
			}
			this.SkillButtonData.SharedHoldRingFxActions = new EInputAction[this.Params.Count];
			for (int i = 0; i < this.Params.Count; i++)
			{
				this.SkillButtonData.SharedHoldRingFxActions[i] = (EInputAction)((byte)int.Parse(this.Params[i]));
			}
			this.CustomHdModifyMark = true;
			this.CustomHdMarkFrom = 6;
		}
	}
}
