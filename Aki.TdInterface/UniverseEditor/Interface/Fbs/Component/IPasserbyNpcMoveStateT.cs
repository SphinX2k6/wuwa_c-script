using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056CC RID: 22220
	public class IPasserbyNpcMoveStateT
	{
		// Token: 0x1700A55D RID: 42333
		// (get) Token: 0x060251E6 RID: 152038 RVA: 0x0051FE02 File Offset: 0x0051E002
		// (set) Token: 0x060251E7 RID: 152039 RVA: 0x0051FE0A File Offset: 0x0051E00A
		public EPatrolMoveState MoveState { get; set; }

		// Token: 0x1700A55E RID: 42334
		// (get) Token: 0x060251E8 RID: 152040 RVA: 0x0051FE13 File Offset: 0x0051E013
		// (set) Token: 0x060251E9 RID: 152041 RVA: 0x0051FE1B File Offset: 0x0051E01B
		public ECharPositionStateType CharPositionState { get; set; }

		// Token: 0x1700A55F RID: 42335
		// (get) Token: 0x060251EA RID: 152042 RVA: 0x0051FE24 File Offset: 0x0051E024
		// (set) Token: 0x060251EB RID: 152043 RVA: 0x0051FE2C File Offset: 0x0051E02C
		public int MoveSpeed { get; set; }

		// Token: 0x1700A560 RID: 42336
		// (get) Token: 0x060251EC RID: 152044 RVA: 0x0051FE35 File Offset: 0x0051E035
		// (set) Token: 0x060251ED RID: 152045 RVA: 0x0051FE3D File Offset: 0x0051E03D
		public bool UseAbpMappingSpeed { get; set; }

		// Token: 0x1700A561 RID: 42337
		// (get) Token: 0x060251EE RID: 152046 RVA: 0x0051FE46 File Offset: 0x0051E046
		// (set) Token: 0x060251EF RID: 152047 RVA: 0x0051FE4E File Offset: 0x0051E04E
		public byte NullMask { get; set; }

		// Token: 0x060251F0 RID: 152048 RVA: 0x0051FE57 File Offset: 0x0051E057
		public IPasserbyNpcMoveStateT()
		{
			this.MoveState = EPatrolMoveState.None;
			this.CharPositionState = ECharPositionStateType.Ground;
			this.MoveSpeed = 0;
			this.UseAbpMappingSpeed = false;
			this.NullMask = 0;
		}
	}
}
