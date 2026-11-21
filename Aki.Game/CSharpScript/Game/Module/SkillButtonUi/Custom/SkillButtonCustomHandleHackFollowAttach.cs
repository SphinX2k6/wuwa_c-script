using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Monster.Component;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02003BD1 RID: 15313
	public class SkillButtonCustomHandleHackFollowAttach : SkillButtonCustomHandleBase
	{
		// Token: 0x060274C6 RID: 160966 RVA: 0x00B05D4D File Offset: 0x00B03F4D
		protected override void OnInit()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			EntityHandle entityHandle = this.SkillButtonData.GetEntityHandle();
			HackManagementComponent hackComp;
			if (entityHandle == null)
			{
				hackComp = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				hackComp = ((entity != null) ? entity.GetComponent<HackManagementComponent>() : null);
			}
			this.HackComp = hackComp;
		}

		// Token: 0x060274C7 RID: 160967 RVA: 0x00B05D84 File Offset: 0x00B03F84
		public override void Refresh()
		{
			if (this.SkillButtonData == null || this.HackComp == null)
			{
				return;
			}
			if (this.TagIds.Count < 1)
			{
				return;
			}
			BaseTagComponent gameplayTagComponent = this.SkillButtonData.GameplayTagComponent;
			this.SkillButtonData.IsLimitCountCustom = true;
			this.SkillButtonData.RemainingCountCustom = ((gameplayTagComponent != null) ? gameplayTagComponent.GetTagCount(this.TagIds[0]) : 0);
		}

		// Token: 0x060274C8 RID: 160968 RVA: 0x00B05DEC File Offset: 0x00B03FEC
		public override void RefreshByTagChanged()
		{
			this.Refresh();
			this.SkillCdModifyMark = true;
		}

		// Token: 0x04015713 RID: 87827
		[Nullable(2)]
		private HackManagementComponent HackComp;
	}
}
