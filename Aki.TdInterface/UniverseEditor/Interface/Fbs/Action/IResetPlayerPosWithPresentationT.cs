using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E9E RID: 28318
	public class IResetPlayerPosWithPresentationT
	{
		// Token: 0x1700D2D9 RID: 53977
		// (get) Token: 0x060320D1 RID: 205009 RVA: 0x006C4EDB File Offset: 0x006C30DB
		// (set) Token: 0x060320D2 RID: 205010 RVA: 0x006C4EE3 File Offset: 0x006C30E3
		public IResetPresentationFailureT Presentation { get; set; }

		// Token: 0x1700D2DA RID: 53978
		// (get) Token: 0x060320D3 RID: 205011 RVA: 0x006C4EEC File Offset: 0x006C30EC
		// (set) Token: 0x060320D4 RID: 205012 RVA: 0x006C4EF4 File Offset: 0x006C30F4
		public TResetPosTypeUnion ResetPosConfig { get; set; }

		// Token: 0x1700D2DB RID: 53979
		// (get) Token: 0x060320D5 RID: 205013 RVA: 0x006C4EFD File Offset: 0x006C30FD
		// (set) Token: 0x060320D6 RID: 205014 RVA: 0x006C4F05 File Offset: 0x006C3105
		public bool NeedWaitResetPos { get; set; }

		// Token: 0x1700D2DC RID: 53980
		// (get) Token: 0x060320D7 RID: 205015 RVA: 0x006C4F0E File Offset: 0x006C310E
		// (set) Token: 0x060320D8 RID: 205016 RVA: 0x006C4F16 File Offset: 0x006C3116
		public byte NullMask { get; set; }

		// Token: 0x060320D9 RID: 205017 RVA: 0x006C4F1F File Offset: 0x006C311F
		public IResetPlayerPosWithPresentationT()
		{
			this.Presentation = null;
			this.ResetPosConfig = null;
			this.NeedWaitResetPos = false;
			this.NullMask = 0;
		}
	}
}
