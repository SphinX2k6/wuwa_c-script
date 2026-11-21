using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054BB RID: 21691
	public class IChargeSlashHookT
	{
		// Token: 0x17009ABA RID: 39610
		// (get) Token: 0x060222F9 RID: 140025 RVA: 0x004B6751 File Offset: 0x004B4951
		// (set) Token: 0x060222FA RID: 140026 RVA: 0x004B6759 File Offset: 0x004B4959
		public EHookInteractType Type { get; set; }

		// Token: 0x17009ABB RID: 39611
		// (get) Token: 0x060222FB RID: 140027 RVA: 0x004B6762 File Offset: 0x004B4962
		// (set) Token: 0x060222FC RID: 140028 RVA: 0x004B676A File Offset: 0x004B496A
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009ABC RID: 39612
		// (get) Token: 0x060222FD RID: 140029 RVA: 0x004B6773 File Offset: 0x004B4973
		// (set) Token: 0x060222FE RID: 140030 RVA: 0x004B677B File Offset: 0x004B497B
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009ABD RID: 39613
		// (get) Token: 0x060222FF RID: 140031 RVA: 0x004B6784 File Offset: 0x004B4984
		// (set) Token: 0x06022300 RID: 140032 RVA: 0x004B678C File Offset: 0x004B498C
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009ABE RID: 39614
		// (get) Token: 0x06022301 RID: 140033 RVA: 0x004B6795 File Offset: 0x004B4995
		// (set) Token: 0x06022302 RID: 140034 RVA: 0x004B679D File Offset: 0x004B499D
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009ABF RID: 39615
		// (get) Token: 0x06022303 RID: 140035 RVA: 0x004B67A6 File Offset: 0x004B49A6
		// (set) Token: 0x06022304 RID: 140036 RVA: 0x004B67AE File Offset: 0x004B49AE
		public List<int> TargetEntityIds { get; set; }

		// Token: 0x17009AC0 RID: 39616
		// (get) Token: 0x06022305 RID: 140037 RVA: 0x004B67B7 File Offset: 0x004B49B7
		// (set) Token: 0x06022306 RID: 140038 RVA: 0x004B67BF File Offset: 0x004B49BF
		public float MaxRandomDelayTime { get; set; }

		// Token: 0x17009AC1 RID: 39617
		// (get) Token: 0x06022307 RID: 140039 RVA: 0x004B67C8 File Offset: 0x004B49C8
		// (set) Token: 0x06022308 RID: 140040 RVA: 0x004B67D0 File Offset: 0x004B49D0
		public IVectorInfoT CharacterLookAt { get; set; }

		// Token: 0x17009AC2 RID: 39618
		// (get) Token: 0x06022309 RID: 140041 RVA: 0x004B67D9 File Offset: 0x004B49D9
		// (set) Token: 0x0602230A RID: 140042 RVA: 0x004B67E1 File Offset: 0x004B49E1
		public int CharacterLookAtPointId { get; set; }

		// Token: 0x17009AC3 RID: 39619
		// (get) Token: 0x0602230B RID: 140043 RVA: 0x004B67EA File Offset: 0x004B49EA
		// (set) Token: 0x0602230C RID: 140044 RVA: 0x004B67F2 File Offset: 0x004B49F2
		public int SlashBackSafePointId { get; set; }

		// Token: 0x17009AC4 RID: 39620
		// (get) Token: 0x0602230D RID: 140045 RVA: 0x004B67FB File Offset: 0x004B49FB
		// (set) Token: 0x0602230E RID: 140046 RVA: 0x004B6803 File Offset: 0x004B4A03
		public bool IsAdjustCameraConfig { get; set; }

		// Token: 0x17009AC5 RID: 39621
		// (get) Token: 0x0602230F RID: 140047 RVA: 0x004B680C File Offset: 0x004B4A0C
		// (set) Token: 0x06022310 RID: 140048 RVA: 0x004B6814 File Offset: 0x004B4A14
		public byte NullMask { get; set; }

		// Token: 0x06022311 RID: 140049 RVA: 0x004B6820 File Offset: 0x004B4A20
		public IChargeSlashHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.TargetEntityIds = null;
			this.MaxRandomDelayTime = 0f;
			this.CharacterLookAt = null;
			this.CharacterLookAtPointId = 0;
			this.SlashBackSafePointId = 0;
			this.IsAdjustCameraConfig = false;
			this.NullMask = 0;
		}
	}
}
