using System;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02003BD9 RID: 15321
	public class SkillButtonCustomHandleButtonDisappear : SkillButtonCustomHandleBase
	{
		// Token: 0x060274E1 RID: 160993 RVA: 0x00B06574 File Offset: 0x00B04774
		protected override void OnInit()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			this.SkillButtonData.ButtonDisappearIconPath = ((this.Params.Count > 0 && this.Params[0] != string.Empty) ? this.Params[0] : null);
		}

		// Token: 0x060274E2 RID: 160994 RVA: 0x00B065CA File Offset: 0x00B047CA
		public override void Refresh()
		{
			this.RefreshByTagChanged();
		}

		// Token: 0x060274E3 RID: 160995 RVA: 0x00B065D4 File Offset: 0x00B047D4
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
