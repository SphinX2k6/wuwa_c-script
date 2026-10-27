using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B6 RID: 21686
	public class IKeyRotatorConfigT
	{
		// Token: 0x17009FC4 RID: 40900
		// (get) Token: 0x06023B96 RID: 146326 RVA: 0x004F0853 File Offset: 0x004EEA53
		// (set) Token: 0x06023B97 RID: 146327 RVA: 0x004F085B File Offset: 0x004EEA5B
		public ERotationType Type { get; set; }

		// Token: 0x17009FC5 RID: 40901
		// (get) Token: 0x06023B98 RID: 146328 RVA: 0x004F0864 File Offset: 0x004EEA64
		// (set) Token: 0x06023B99 RID: 146329 RVA: 0x004F086C File Offset: 0x004EEA6C
		public float Time { get; set; }

		// Token: 0x17009FC6 RID: 40902
		// (get) Token: 0x06023B9A RID: 146330 RVA: 0x004F0875 File Offset: 0x004EEA75
		// (set) Token: 0x06023B9B RID: 146331 RVA: 0x004F087D File Offset: 0x004EEA7D
		public float Cd { get; set; }

		// Token: 0x17009FC7 RID: 40903
		// (get) Token: 0x06023B9C RID: 146332 RVA: 0x004F0886 File Offset: 0x004EEA86
		// (set) Token: 0x06023B9D RID: 146333 RVA: 0x004F088E File Offset: 0x004EEA8E
		public string Curve { get; set; }

		// Token: 0x17009FC8 RID: 40904
		// (get) Token: 0x06023B9E RID: 146334 RVA: 0x004F0897 File Offset: 0x004EEA97
		// (set) Token: 0x06023B9F RID: 146335 RVA: 0x004F089F File Offset: 0x004EEA9F
		public IVectorInfoT KeyRotator { get; set; }

		// Token: 0x17009FC9 RID: 40905
		// (get) Token: 0x06023BA0 RID: 146336 RVA: 0x004F08A8 File Offset: 0x004EEAA8
		// (set) Token: 0x06023BA1 RID: 146337 RVA: 0x004F08B0 File Offset: 0x004EEAB0
		public byte NullMask { get; set; }

		// Token: 0x06023BA2 RID: 146338 RVA: 0x004F08B9 File Offset: 0x004EEAB9
		public IKeyRotatorConfigT()
		{
			this.Type = ERotationType.Relative;
			this.Time = 0f;
			this.Cd = 0f;
			this.Curve = null;
			this.KeyRotator = null;
			this.NullMask = 0;
		}
	}
}
