using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070CE RID: 28878
	public class ILimitPlayerMoveT
	{
		// Token: 0x1700D384 RID: 54148
		// (get) Token: 0x06032257 RID: 205399 RVA: 0x006C8F66 File Offset: 0x006C7166
		// (set) Token: 0x06032258 RID: 205400 RVA: 0x006C8F6E File Offset: 0x006C716E
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x1700D385 RID: 54149
		// (get) Token: 0x06032259 RID: 205401 RVA: 0x006C8F77 File Offset: 0x006C7177
		// (set) Token: 0x0603225A RID: 205402 RVA: 0x006C8F7F File Offset: 0x006C717F
		public bool IsOnlyForward { get; set; }

		// Token: 0x1700D386 RID: 54150
		// (get) Token: 0x0603225B RID: 205403 RVA: 0x006C8F88 File Offset: 0x006C7188
		// (set) Token: 0x0603225C RID: 205404 RVA: 0x006C8F90 File Offset: 0x006C7190
		public byte NullMask { get; set; }

		// Token: 0x0603225D RID: 205405 RVA: 0x006C8F99 File Offset: 0x006C7199
		public ILimitPlayerMoveT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
			this.IsOnlyForward = false;
			this.NullMask = 0;
		}
	}
}
