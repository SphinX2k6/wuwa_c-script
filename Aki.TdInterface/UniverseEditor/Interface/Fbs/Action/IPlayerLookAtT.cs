using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007478 RID: 29816
	public class IPlayerLookAtT
	{
		// Token: 0x1700DB0D RID: 56077
		// (get) Token: 0x06034325 RID: 213797 RVA: 0x00707F57 File Offset: 0x00706157
		// (set) Token: 0x06034326 RID: 213798 RVA: 0x00707F5F File Offset: 0x0070615F
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700DB0E RID: 56078
		// (get) Token: 0x06034327 RID: 213799 RVA: 0x00707F68 File Offset: 0x00706168
		// (set) Token: 0x06034328 RID: 213800 RVA: 0x00707F70 File Offset: 0x00706170
		public bool CameraMove { get; set; }

		// Token: 0x1700DB0F RID: 56079
		// (get) Token: 0x06034329 RID: 213801 RVA: 0x00707F79 File Offset: 0x00706179
		// (set) Token: 0x0603432A RID: 213802 RVA: 0x00707F81 File Offset: 0x00706181
		public bool PlayAnimation { get; set; }

		// Token: 0x1700DB10 RID: 56080
		// (get) Token: 0x0603432B RID: 213803 RVA: 0x00707F8A File Offset: 0x0070618A
		// (set) Token: 0x0603432C RID: 213804 RVA: 0x00707F92 File Offset: 0x00706192
		public byte NullMask { get; set; }

		// Token: 0x0603432D RID: 213805 RVA: 0x00707F9B File Offset: 0x0070619B
		public IPlayerLookAtT()
		{
			this.Pos = null;
			this.CameraMove = false;
			this.PlayAnimation = false;
			this.NullMask = 0;
		}
	}
}
