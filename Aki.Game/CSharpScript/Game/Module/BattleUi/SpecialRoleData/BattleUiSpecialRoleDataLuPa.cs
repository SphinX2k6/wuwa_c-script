using System;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02005E51 RID: 24145
	public class BattleUiSpecialRoleDataLuPa : BattleUiSpecialRoleDataBase
	{
		// Token: 0x0603D676 RID: 251510 RVA: 0x00ECFE44 File Offset: 0x00ECE044
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

		// Token: 0x0603D677 RID: 251511 RVA: 0x00ECFE94 File Offset: 0x00ECE094
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
