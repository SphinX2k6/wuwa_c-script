using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CD6 RID: 23766
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleFormationChildView : BattleEntityChildView
	{
		// Token: 0x0603C22C RID: 246316 RVA: 0x00E64CAC File Offset: 0x00E62EAC
		protected override void OnActivate()
		{
			SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)base.GetEntityId().Value, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.EntityId
			});
			this.FormationInstance = teamItem;
		}

		// Token: 0x0603C22D RID: 246317 RVA: 0x00E64CE6 File Offset: 0x00E62EE6
		protected override void OnDeactivate()
		{
			this.FormationInstance = null;
		}

		// Token: 0x0603C22E RID: 246318 RVA: 0x00E64CEF File Offset: 0x00E62EEF
		public SceneTeamItem GetFormationInstance()
		{
			return this.FormationInstance;
		}

		// Token: 0x0603C22F RID: 246319 RVA: 0x00E64CF7 File Offset: 0x00E62EF7
		public override bool IsValid()
		{
			return base.IsValid() && this.FormationInstance != null;
		}

		// Token: 0x0401F596 RID: 128406
		protected SceneTeamItem FormationInstance;
	}
}
