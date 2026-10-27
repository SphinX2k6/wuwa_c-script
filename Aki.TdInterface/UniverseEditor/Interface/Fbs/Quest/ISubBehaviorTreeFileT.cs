using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200414C RID: 16716
	public class ISubBehaviorTreeFileT
	{
		// Token: 0x17007674 RID: 30324
		// (get) Token: 0x060188B8 RID: 100536 RVA: 0x00389DD0 File Offset: 0x00387FD0
		// (set) Token: 0x060188B9 RID: 100537 RVA: 0x00389DD8 File Offset: 0x00387FD8
		public int Id { get; set; }

		// Token: 0x17007675 RID: 30325
		// (get) Token: 0x060188BA RID: 100538 RVA: 0x00389DE1 File Offset: 0x00387FE1
		// (set) Token: 0x060188BB RID: 100539 RVA: 0x00389DE9 File Offset: 0x00387FE9
		public string ParentUid { get; set; }

		// Token: 0x17007676 RID: 30326
		// (get) Token: 0x060188BC RID: 100540 RVA: 0x00389DF2 File Offset: 0x00387FF2
		// (set) Token: 0x060188BD RID: 100541 RVA: 0x00389DFA File Offset: 0x00387FFA
		public IBehaviorTreeT Tree { get; set; }

		// Token: 0x17007677 RID: 30327
		// (get) Token: 0x060188BE RID: 100542 RVA: 0x00389E03 File Offset: 0x00388003
		// (set) Token: 0x060188BF RID: 100543 RVA: 0x00389E0B File Offset: 0x0038800B
		public List<string> Children { get; set; }

		// Token: 0x17007678 RID: 30328
		// (get) Token: 0x060188C0 RID: 100544 RVA: 0x00389E14 File Offset: 0x00388014
		// (set) Token: 0x060188C1 RID: 100545 RVA: 0x00389E1C File Offset: 0x0038801C
		public List<string> Reference { get; set; }

		// Token: 0x17007679 RID: 30329
		// (get) Token: 0x060188C2 RID: 100546 RVA: 0x00389E25 File Offset: 0x00388025
		// (set) Token: 0x060188C3 RID: 100547 RVA: 0x00389E2D File Offset: 0x0038802D
		public List<string> WeakReference { get; set; }

		// Token: 0x1700767A RID: 30330
		// (get) Token: 0x060188C4 RID: 100548 RVA: 0x00389E36 File Offset: 0x00388036
		// (set) Token: 0x060188C5 RID: 100549 RVA: 0x00389E3E File Offset: 0x0038803E
		public string _Name { get; set; }

		// Token: 0x1700767B RID: 30331
		// (get) Token: 0x060188C6 RID: 100550 RVA: 0x00389E47 File Offset: 0x00388047
		// (set) Token: 0x060188C7 RID: 100551 RVA: 0x00389E4F File Offset: 0x0038804F
		public string _Path { get; set; }

		// Token: 0x1700767C RID: 30332
		// (get) Token: 0x060188C8 RID: 100552 RVA: 0x00389E58 File Offset: 0x00388058
		// (set) Token: 0x060188C9 RID: 100553 RVA: 0x00389E60 File Offset: 0x00388060
		public byte NullMask { get; set; }

		// Token: 0x060188CA RID: 100554 RVA: 0x00389E6C File Offset: 0x0038806C
		public ISubBehaviorTreeFileT()
		{
			this.Id = 0;
			this.ParentUid = null;
			this.Tree = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this._Name = null;
			this._Path = null;
			this.NullMask = 0;
		}
	}
}
