using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CB8 RID: 19640
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleFormationChildView : BattleEntityChildView
	{
		// Token: 0x06031182 RID: 201090 RVA: 0x00DB5288 File Offset: 0x00DB3488
		protected override void OnActivate()
		{
			SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)base.GetEntityId().Value, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.EntityId
			});
			this.FormationInstance = teamItem;
		}

		// Token: 0x06031183 RID: 201091 RVA: 0x00DB52C2 File Offset: 0x00DB34C2
		protected override void OnDeactivate()
		{
			this.FormationInstance = null;
		}

		// Token: 0x06031184 RID: 201092 RVA: 0x00DB52CB File Offset: 0x00DB34CB
		public SceneTeamItem GetFormationInstance()
		{
			return this.FormationInstance;
		}

		// Token: 0x06031185 RID: 201093 RVA: 0x00DB52D3 File Offset: 0x00DB34D3
		public override bool IsValid()
		{
			return base.IsValid() && this.FormationInstance != null;
		}

		// Token: 0x0401A04F RID: 106575
		protected SceneTeamItem FormationInstance;
	}
}
