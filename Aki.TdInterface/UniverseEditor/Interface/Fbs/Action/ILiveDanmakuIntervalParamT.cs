using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E6 RID: 28902
	public class ILiveDanmakuIntervalParamT
	{
		// Token: 0x1700D3AC RID: 54188
		// (get) Token: 0x06032318 RID: 205592 RVA: 0x006CA420 File Offset: 0x006C8620
		// (set) Token: 0x06032319 RID: 205593 RVA: 0x006CA428 File Offset: 0x006C8628
		public ELiveParamType Type { get; set; }

		// Token: 0x1700D3AD RID: 54189
		// (get) Token: 0x0603231A RID: 205594 RVA: 0x006CA431 File Offset: 0x006C8631
		// (set) Token: 0x0603231B RID: 205595 RVA: 0x006CA439 File Offset: 0x006C8639
		public float SendInterval { get; set; }

		// Token: 0x0603231C RID: 205596 RVA: 0x006CA442 File Offset: 0x006C8642
		public ILiveDanmakuIntervalParamT()
		{
			this.Type = ELiveParamType.Heat;
			this.SendInterval = 0f;
		}
	}
}
