using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200574F RID: 22351
	public class IExploreSkillInteractComponentT
	{
		// Token: 0x1700A18C RID: 41356
		// (get) Token: 0x06024044 RID: 147524 RVA: 0x004F46A3 File Offset: 0x004F28A3
		// (set) Token: 0x06024045 RID: 147525 RVA: 0x004F46AB File Offset: 0x004F28AB
		public bool Disabled { get; set; }

		// Token: 0x1700A18D RID: 41357
		// (get) Token: 0x06024046 RID: 147526 RVA: 0x004F46B4 File Offset: 0x004F28B4
		// (set) Token: 0x06024047 RID: 147527 RVA: 0x004F46BC File Offset: 0x004F28BC
		public string ExploreSkillUiResource { get; set; }

		// Token: 0x1700A18E RID: 41358
		// (get) Token: 0x06024048 RID: 147528 RVA: 0x004F46C5 File Offset: 0x004F28C5
		// (set) Token: 0x06024049 RID: 147529 RVA: 0x004F46CD File Offset: 0x004F28CD
		public TExploreSkillInteractOptionUnion Option { get; set; }

		// Token: 0x1700A18F RID: 41359
		// (get) Token: 0x0602404A RID: 147530 RVA: 0x004F46D6 File Offset: 0x004F28D6
		// (set) Token: 0x0602404B RID: 147531 RVA: 0x004F46DE File Offset: 0x004F28DE
		public int PlayerStateRestritionId { get; set; }

		// Token: 0x1700A190 RID: 41360
		// (get) Token: 0x0602404C RID: 147532 RVA: 0x004F46E7 File Offset: 0x004F28E7
		// (set) Token: 0x0602404D RID: 147533 RVA: 0x004F46EF File Offset: 0x004F28EF
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700A191 RID: 41361
		// (get) Token: 0x0602404E RID: 147534 RVA: 0x004F46F8 File Offset: 0x004F28F8
		// (set) Token: 0x0602404F RID: 147535 RVA: 0x004F4700 File Offset: 0x004F2900
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700A192 RID: 41362
		// (get) Token: 0x06024050 RID: 147536 RVA: 0x004F4709 File Offset: 0x004F2909
		// (set) Token: 0x06024051 RID: 147537 RVA: 0x004F4711 File Offset: 0x004F2911
		public TExploreSkillSearchTargetCfgUnion SearchTargetCfg { get; set; }

		// Token: 0x1700A193 RID: 41363
		// (get) Token: 0x06024052 RID: 147538 RVA: 0x004F471A File Offset: 0x004F291A
		// (set) Token: 0x06024053 RID: 147539 RVA: 0x004F4722 File Offset: 0x004F2922
		public IIgnoresCollisionCfgT IgnoresCollisionCfg { get; set; }

		// Token: 0x1700A194 RID: 41364
		// (get) Token: 0x06024054 RID: 147540 RVA: 0x004F472B File Offset: 0x004F292B
		// (set) Token: 0x06024055 RID: 147541 RVA: 0x004F4733 File Offset: 0x004F2933
		public List<string> SelfInteractBlockDetectionKeys { get; set; }

		// Token: 0x1700A195 RID: 41365
		// (get) Token: 0x06024056 RID: 147542 RVA: 0x004F473C File Offset: 0x004F293C
		// (set) Token: 0x06024057 RID: 147543 RVA: 0x004F4744 File Offset: 0x004F2944
		public byte NullMask { get; set; }

		// Token: 0x06024058 RID: 147544 RVA: 0x004F4750 File Offset: 0x004F2950
		public IExploreSkillInteractComponentT()
		{
			this.Disabled = false;
			this.ExploreSkillUiResource = null;
			this.Option = null;
			this.PlayerStateRestritionId = 0;
			this.MatchRoleOption = null;
			this.Condition = null;
			this.SearchTargetCfg = null;
			this.IgnoresCollisionCfg = null;
			this.SelfInteractBlockDetectionKeys = null;
			this.NullMask = 0;
		}
	}
}
