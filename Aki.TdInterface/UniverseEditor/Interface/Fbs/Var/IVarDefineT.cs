using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B00 RID: 15104
	public class IVarDefineT
	{
		// Token: 0x17006796 RID: 26518
		// (get) Token: 0x06014989 RID: 84361 RVA: 0x002FFC83 File Offset: 0x002FDE83
		// (set) Token: 0x0601498A RID: 84362 RVA: 0x002FFC8B File Offset: 0x002FDE8B
		public string Name { get; set; }

		// Token: 0x17006797 RID: 26519
		// (get) Token: 0x0601498B RID: 84363 RVA: 0x002FFC94 File Offset: 0x002FDE94
		// (set) Token: 0x0601498C RID: 84364 RVA: 0x002FFC9C File Offset: 0x002FDE9C
		public EVar Type { get; set; }

		// Token: 0x17006798 RID: 26520
		// (get) Token: 0x0601498D RID: 84365 RVA: 0x002FFCA5 File Offset: 0x002FDEA5
		// (set) Token: 0x0601498E RID: 84366 RVA: 0x002FFCAD File Offset: 0x002FDEAD
		public TVarValueUnion Value { get; set; }

		// Token: 0x17006799 RID: 26521
		// (get) Token: 0x0601498F RID: 84367 RVA: 0x002FFCB6 File Offset: 0x002FDEB6
		// (set) Token: 0x06014990 RID: 84368 RVA: 0x002FFCBE File Offset: 0x002FDEBE
		public EVarAccess Access { get; set; }

		// Token: 0x1700679A RID: 26522
		// (get) Token: 0x06014991 RID: 84369 RVA: 0x002FFCC7 File Offset: 0x002FDEC7
		// (set) Token: 0x06014992 RID: 84370 RVA: 0x002FFCCF File Offset: 0x002FDECF
		public bool IsIgnoreOnRollBack { get; set; }

		// Token: 0x1700679B RID: 26523
		// (get) Token: 0x06014993 RID: 84371 RVA: 0x002FFCD8 File Offset: 0x002FDED8
		// (set) Token: 0x06014994 RID: 84372 RVA: 0x002FFCE0 File Offset: 0x002FDEE0
		public bool IsClient { get; set; }

		// Token: 0x1700679C RID: 26524
		// (get) Token: 0x06014995 RID: 84373 RVA: 0x002FFCE9 File Offset: 0x002FDEE9
		// (set) Token: 0x06014996 RID: 84374 RVA: 0x002FFCF1 File Offset: 0x002FDEF1
		public TVarValidateConfigUnion ValidateConfig { get; set; }

		// Token: 0x1700679D RID: 26525
		// (get) Token: 0x06014997 RID: 84375 RVA: 0x002FFCFA File Offset: 0x002FDEFA
		// (set) Token: 0x06014998 RID: 84376 RVA: 0x002FFD02 File Offset: 0x002FDF02
		public bool IsClientEditable { get; set; }

		// Token: 0x1700679E RID: 26526
		// (get) Token: 0x06014999 RID: 84377 RVA: 0x002FFD0B File Offset: 0x002FDF0B
		// (set) Token: 0x0601499A RID: 84378 RVA: 0x002FFD13 File Offset: 0x002FDF13
		public byte NullMask { get; set; }

		// Token: 0x0601499B RID: 84379 RVA: 0x002FFD1C File Offset: 0x002FDF1C
		public IVarDefineT()
		{
			this.Name = null;
			this.Type = EVar.Boolean;
			this.Value = null;
			this.Access = EVarAccess.Private;
			this.IsIgnoreOnRollBack = false;
			this.IsClient = false;
			this.ValidateConfig = null;
			this.IsClientEditable = false;
			this.NullMask = 0;
		}
	}
}
