using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02004E32 RID: 20018
	public class BattleUiSpecialRoleDataBase
	{
		// Token: 0x060325F5 RID: 206325 RVA: 0x00E211EF File Offset: 0x00E1F3EF
		[NullableContext(1)]
		public virtual void Init(BattleUiRoleData roleData)
		{
			this.RoleData = roleData;
			this.OnInit();
		}

		// Token: 0x060325F6 RID: 206326 RVA: 0x00E211FE File Offset: 0x00E1F3FE
		public virtual void Clear()
		{
			this.OnClear();
			this.RoleData = null;
		}

		// Token: 0x060325F7 RID: 206327 RVA: 0x00E2120D File Offset: 0x00E1F40D
		public virtual void OnChangeRole(bool isCurEntity)
		{
		}

		// Token: 0x060325F8 RID: 206328 RVA: 0x00E2120F File Offset: 0x00E1F40F
		protected virtual void OnInit()
		{
		}

		// Token: 0x060325F9 RID: 206329 RVA: 0x00E21211 File Offset: 0x00E1F411
		protected virtual void OnClear()
		{
		}

		// Token: 0x0401AB66 RID: 109414
		[Nullable(2)]
		protected BattleUiRoleData RoleData;
	}
}
