using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007253 RID: 29267
	public class IMotorEnterSlideT
	{
		// Token: 0x1700D69E RID: 54942
		// (get) Token: 0x06032FE6 RID: 208870 RVA: 0x006E24C4 File Offset: 0x006E06C4
		// (set) Token: 0x06032FE7 RID: 208871 RVA: 0x006E24CC File Offset: 0x006E06CC
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D69F RID: 54943
		// (get) Token: 0x06032FE8 RID: 208872 RVA: 0x006E24D5 File Offset: 0x006E06D5
		// (set) Token: 0x06032FE9 RID: 208873 RVA: 0x006E24DD File Offset: 0x006E06DD
		public int EntityId { get; set; }

		// Token: 0x1700D6A0 RID: 54944
		// (get) Token: 0x06032FEA RID: 208874 RVA: 0x006E24E6 File Offset: 0x006E06E6
		// (set) Token: 0x06032FEB RID: 208875 RVA: 0x006E24EE File Offset: 0x006E06EE
		public EMotorEnterSlideMode EnterMode { get; set; }

		// Token: 0x1700D6A1 RID: 54945
		// (get) Token: 0x06032FEC RID: 208876 RVA: 0x006E24F7 File Offset: 0x006E06F7
		// (set) Token: 0x06032FED RID: 208877 RVA: 0x006E24FF File Offset: 0x006E06FF
		public byte NullMask { get; set; }

		// Token: 0x06032FEE RID: 208878 RVA: 0x006E2508 File Offset: 0x006E0708
		public IMotorEnterSlideT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.EntityId = 0;
			this.EnterMode = EMotorEnterSlideMode.Jump;
			this.NullMask = 0;
		}
	}
}
