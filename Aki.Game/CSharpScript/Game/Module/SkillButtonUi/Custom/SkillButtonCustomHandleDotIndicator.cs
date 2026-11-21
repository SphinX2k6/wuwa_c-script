using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02003BD4 RID: 15316
	public class SkillButtonCustomHandleDotIndicator : SkillButtonCustomHandleBase
	{
		// Token: 0x060274D2 RID: 160978 RVA: 0x00B060D0 File Offset: 0x00B042D0
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

		// Token: 0x060274D3 RID: 160979 RVA: 0x00B06144 File Offset: 0x00B04344
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

		// Token: 0x060274D4 RID: 160980 RVA: 0x00B06207 File Offset: 0x00B04407
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

		// Token: 0x060274D5 RID: 160981 RVA: 0x00B06236 File Offset: 0x00B04436
		public override void RefreshByTagChanged()
		{
			this.Refresh();
		}

		// Token: 0x060274D6 RID: 160982 RVA: 0x00B0623E File Offset: 0x00B0443E
		public override bool RefreshOnInputControllerChange()
		{
			this.Refresh();
			return true;
		}

		// Token: 0x04015714 RID: 87828
		private int ActionType;

		// Token: 0x04015715 RID: 87829
		[Nullable(2)]
		private string IconPath;
	}
}
