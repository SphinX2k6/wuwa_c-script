using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068ED RID: 26861
	public class ICameraGazeT
	{
		// Token: 0x1700C575 RID: 50549
		// (get) Token: 0x0602DFC0 RID: 188352 RVA: 0x00648F82 File Offset: 0x00647182
		// (set) Token: 0x0602DFC1 RID: 188353 RVA: 0x00648F8A File Offset: 0x0064718A
		public float FadeInTime { get; set; }

		// Token: 0x1700C576 RID: 50550
		// (get) Token: 0x0602DFC2 RID: 188354 RVA: 0x00648F93 File Offset: 0x00647193
		// (set) Token: 0x0602DFC3 RID: 188355 RVA: 0x00648F9B File Offset: 0x0064719B
		public float StayTime { get; set; }

		// Token: 0x1700C577 RID: 50551
		// (get) Token: 0x0602DFC4 RID: 188356 RVA: 0x00648FA4 File Offset: 0x006471A4
		// (set) Token: 0x0602DFC5 RID: 188357 RVA: 0x00648FAC File Offset: 0x006471AC
		public float FadeOutTime { get; set; }

		// Token: 0x1700C578 RID: 50552
		// (get) Token: 0x0602DFC6 RID: 188358 RVA: 0x00648FB5 File Offset: 0x006471B5
		// (set) Token: 0x0602DFC7 RID: 188359 RVA: 0x00648FBD File Offset: 0x006471BD
		public bool LockCamera { get; set; }

		// Token: 0x1700C579 RID: 50553
		// (get) Token: 0x0602DFC8 RID: 188360 RVA: 0x00648FC6 File Offset: 0x006471C6
		// (set) Token: 0x0602DFC9 RID: 188361 RVA: 0x00648FCE File Offset: 0x006471CE
		public int LockPriority { get; set; }

		// Token: 0x1700C57A RID: 50554
		// (get) Token: 0x0602DFCA RID: 188362 RVA: 0x00648FD7 File Offset: 0x006471D7
		// (set) Token: 0x0602DFCB RID: 188363 RVA: 0x00648FDF File Offset: 0x006471DF
		public bool GazeInHook { get; set; }

		// Token: 0x1700C57B RID: 50555
		// (get) Token: 0x0602DFCC RID: 188364 RVA: 0x00648FE8 File Offset: 0x006471E8
		// (set) Token: 0x0602DFCD RID: 188365 RVA: 0x00648FF0 File Offset: 0x006471F0
		public byte NullMask { get; set; }

		// Token: 0x0602DFCE RID: 188366 RVA: 0x00648FFC File Offset: 0x006471FC
		public ICameraGazeT()
		{
			this.FadeInTime = 0f;
			this.StayTime = 0f;
			this.FadeOutTime = 0f;
			this.LockCamera = false;
			this.LockPriority = 0;
			this.GazeInHook = false;
			this.NullMask = 0;
		}
	}
}
