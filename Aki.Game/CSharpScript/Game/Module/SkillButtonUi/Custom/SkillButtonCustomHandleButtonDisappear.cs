using System;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02004C28 RID: 19496
	public class SkillButtonCustomHandleButtonDisappear : SkillButtonCustomHandleBase
	{
		// Token: 0x0603272E RID: 206638 RVA: 0x00BC195C File Offset: 0x00BBFB5C
		protected override void OnInit()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			this.SkillButtonData.ButtonDisappearIconPath = ((this.Params.Count > 0 && this.Params[0] != string.Empty) ? this.Params[0] : null);
		}

		// Token: 0x0603272F RID: 206639 RVA: 0x00BC19B2 File Offset: 0x00BBFBB2
		public override void Refresh()
		{
			this.RefreshByTagChanged();
		}

		// Token: 0x06032730 RID: 206640 RVA: 0x00BC19BC File Offset: 0x00BBFBBC
		public override void RefreshByTagChanged()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.TagIds.Count < 1)
			{
				return;
			}
			BaseTagComponent gameplayTagComponent = this.SkillButtonData.GameplayTagComponent;
			bool flag = gameplayTagComponent != null && gameplayTagComponent.HasTag(this.TagIds[0]);
			if (this.SkillButtonData.IsButtonDisappear == flag)
			{
				return;
			}
			this.SkillButtonData.IsButtonDisappear = flag;
			this.CustomHdModifyMark = true;
			this.CustomHdMarkFrom = 10;
		}
	}
}
