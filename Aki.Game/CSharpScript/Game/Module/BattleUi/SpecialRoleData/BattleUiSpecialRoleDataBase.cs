using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02005E4D RID: 24141
	public class BattleUiSpecialRoleDataBase
	{
		// Token: 0x0603D665 RID: 251493 RVA: 0x00ECFC7F File Offset: 0x00ECDE7F
		[NullableContext(1)]
		public virtual void Init(BattleUiRoleData roleData)
		{
			this.RoleData = roleData;
			this.OnInit();
		}

		// Token: 0x0603D666 RID: 251494 RVA: 0x00ECFC8E File Offset: 0x00ECDE8E
		public virtual void Clear()
		{
			this.OnClear();
			this.RoleData = null;
		}

		// Token: 0x0603D667 RID: 251495 RVA: 0x00ECFC9D File Offset: 0x00ECDE9D
		public virtual void OnChangeRole(bool isCurEntity)
		{
		}

		// Token: 0x0603D668 RID: 251496 RVA: 0x00ECFC9F File Offset: 0x00ECDE9F
		protected virtual void OnInit()
		{
		}

		// Token: 0x0603D669 RID: 251497 RVA: 0x00ECFCA1 File Offset: 0x00ECDEA1
		protected virtual void OnClear()
		{
		}

		// Token: 0x0402009F RID: 131231
		[Nullable(2)]
		protected BattleUiRoleData RoleData;
	}
}
