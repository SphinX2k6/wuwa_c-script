using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Monster.Component;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02004C20 RID: 19488
	public class SkillButtonCustomHandleHackFollowAttach : SkillButtonCustomHandleBase
	{
		// Token: 0x06032713 RID: 206611 RVA: 0x00BC110F File Offset: 0x00BBF30F
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

		// Token: 0x06032714 RID: 206612 RVA: 0x00BC1144 File Offset: 0x00BBF344
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

		// Token: 0x06032715 RID: 206613 RVA: 0x00BC11AC File Offset: 0x00BBF3AC
		public override void RefreshByTagChanged()
		{
			this.Refresh();
			this.SkillCdModifyMark = true;
		}

		// Token: 0x0401ADB6 RID: 110006
		[Nullable(2)]
		private HackManagementComponent HackComp;
	}
}
