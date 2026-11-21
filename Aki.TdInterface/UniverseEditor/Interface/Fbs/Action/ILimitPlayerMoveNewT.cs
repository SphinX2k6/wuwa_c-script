using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D1 RID: 28881
	public class ILimitPlayerMoveNewT
	{
		// Token: 0x1700D38D RID: 54157
		// (get) Token: 0x06032275 RID: 205429 RVA: 0x006C92CA File Offset: 0x006C74CA
		// (set) Token: 0x06032276 RID: 205430 RVA: 0x006C92D2 File Offset: 0x006C74D2
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x1700D38E RID: 54158
		// (get) Token: 0x06032277 RID: 205431 RVA: 0x006C92DB File Offset: 0x006C74DB
		// (set) Token: 0x06032278 RID: 205432 RVA: 0x006C92E3 File Offset: 0x006C74E3
		public bool Forward { get; set; }

		// Token: 0x1700D38F RID: 54159
		// (get) Token: 0x06032279 RID: 205433 RVA: 0x006C92EC File Offset: 0x006C74EC
		// (set) Token: 0x0603227A RID: 205434 RVA: 0x006C92F4 File Offset: 0x006C74F4
		public bool Back { get; set; }

		// Token: 0x1700D390 RID: 54160
		// (get) Token: 0x0603227B RID: 205435 RVA: 0x006C92FD File Offset: 0x006C74FD
		// (set) Token: 0x0603227C RID: 205436 RVA: 0x006C9305 File Offset: 0x006C7505
		public bool Left { get; set; }

		// Token: 0x1700D391 RID: 54161
		// (get) Token: 0x0603227D RID: 205437 RVA: 0x006C930E File Offset: 0x006C750E
		// (set) Token: 0x0603227E RID: 205438 RVA: 0x006C9316 File Offset: 0x006C7516
		public bool Right { get; set; }

		// Token: 0x0603227F RID: 205439 RVA: 0x006C931F File Offset: 0x006C751F
		public ILimitPlayerMoveNewT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
			this.Forward = false;
			this.Back = false;
			this.Left = false;
			this.Right = false;
		}
	}
}
