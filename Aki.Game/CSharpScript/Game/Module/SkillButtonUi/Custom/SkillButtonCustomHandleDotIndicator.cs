using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02004C23 RID: 19491
	public class SkillButtonCustomHandleDotIndicator : SkillButtonCustomHandleBase
	{
		// Token: 0x0603271F RID: 206623 RVA: 0x00BC14B8 File Offset: 0x00BBF6B8
		protected override void OnInit()
		{
			if (this.Params.Count < 1 || this.Params[0] == "")
			{
				this.ActionType = 0;
			}
			else
			{
				int.TryParse(this.Params[0], out this.ActionType);
			}
			if (this.Params.Count >= 2)
			{
				this.IconPath = this.Params[1];
			}
		}

		// Token: 0x06032720 RID: 206624 RVA: 0x00BC152C File Offset: 0x00BBF72C
		public override void Refresh()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.TagIds.Count < 2)
			{
				this.ResetSkillButtonData();
				return;
			}
			if (this.ActionType == 0 || (int)this.SkillButtonData.GetActionType() == this.ActionType)
			{
				BaseTagComponent gameplayTagComponent = this.SkillButtonData.GameplayTagComponent;
				this.SkillButtonData.IsEnableDotIndicator = (gameplayTagComponent != null && gameplayTagComponent.HasTag(this.TagIds[0]));
				this.SkillButtonData.DotIndicatorCount = ((gameplayTagComponent != null) ? gameplayTagComponent.GetTagCount(this.TagIds[1]) : 0);
				this.SkillButtonData.DotIndicatorIconPath = this.IconPath;
				this.CustomHdModifyMark = true;
				this.CustomHdMarkFrom = 5;
				return;
			}
			this.ResetSkillButtonData();
		}

		// Token: 0x06032721 RID: 206625 RVA: 0x00BC15EF File Offset: 0x00BBF7EF
		private void ResetSkillButtonData()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			this.SkillButtonData.IsEnableDotIndicator = false;
			this.SkillButtonData.DotIndicatorCount = 0;
			this.SkillButtonData.DotIndicatorIconPath = null;
		}

		// Token: 0x06032722 RID: 206626 RVA: 0x00BC161E File Offset: 0x00BBF81E
		public override void RefreshByTagChanged()
		{
			this.Refresh();
		}

		// Token: 0x06032723 RID: 206627 RVA: 0x00BC1626 File Offset: 0x00BBF826
		public override bool RefreshOnInputControllerChange()
		{
			this.Refresh();
			return true;
		}

		// Token: 0x0401ADB7 RID: 110007
		private int ActionType;

		// Token: 0x0401ADB8 RID: 110008
		[Nullable(2)]
		private string IconPath;
	}
}
