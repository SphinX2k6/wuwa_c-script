using System;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02004E36 RID: 20022
	public class BattleUiSpecialRoleDataLuPa : BattleUiSpecialRoleDataBase
	{
		// Token: 0x06032606 RID: 206342 RVA: 0x00E213B4 File Offset: 0x00E1F5B4
		protected override void OnInit()
		{
			BattleUiRoleData roleData = this.RoleData;
			bool flag;
			if (roleData == null)
			{
				flag = false;
			}
			else
			{
				CharacterActorComponent actorComp = roleData.ActorComp;
				flag = ((actorComp != null) ? new bool?(actorComp.IsAutonomousProxy) : null).GetValueOrDefault();
			}
			if (flag)
			{
				HudUnitController.Instance.TryCreateHud(EHudUnitType.LuPaAim);
			}
		}

		// Token: 0x06032607 RID: 206343 RVA: 0x00E21404 File Offset: 0x00E1F604
		protected override void OnClear()
		{
			BattleUiRoleData roleData = this.RoleData;
			bool flag;
			if (roleData == null)
			{
				flag = false;
			}
			else
			{
				CharacterActorComponent actorComp = roleData.ActorComp;
				flag = ((actorComp != null) ? new bool?(actorComp.IsAutonomousProxy) : null).GetValueOrDefault();
			}
			if (flag)
			{
				HudUnitController.Instance.TryDestroyHud(EHudUnitType.LuPaAim);
			}
		}
	}
}
