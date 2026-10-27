using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B27 RID: 15143
	public class IVector2T
	{
		// Token: 0x170067DE RID: 26590
		// (get) Token: 0x06014AE5 RID: 84709 RVA: 0x00302326 File Offset: 0x00300526
		// (set) Token: 0x06014AE6 RID: 84710 RVA: 0x0030232E File Offset: 0x0030052E
		public float X { get; set; }

		// Token: 0x170067DF RID: 26591
		// (get) Token: 0x06014AE7 RID: 84711 RVA: 0x00302337 File Offset: 0x00300537
		// (set) Token: 0x06014AE8 RID: 84712 RVA: 0x0030233F File Offset: 0x0030053F
		public float Y { get; set; }

		// Token: 0x170067E0 RID: 26592
		// (get) Token: 0x06014AE9 RID: 84713 RVA: 0x00302348 File Offset: 0x00300548
		// (set) Token: 0x06014AEA RID: 84714 RVA: 0x00302350 File Offset: 0x00300550
		public byte NullMask { get; set; }

		// Token: 0x06014AEB RID: 84715 RVA: 0x00302359 File Offset: 0x00300559
		public IVector2T()
		{
			this.X = 0f;
			this.Y = 0f;
			this.NullMask = 0;
		}
	}
}
