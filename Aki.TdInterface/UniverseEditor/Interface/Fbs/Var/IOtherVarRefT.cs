using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EAB RID: 16043
	public class IOtherVarRefT
	{
		// Token: 0x17006C95 RID: 27797
		// (get) Token: 0x06015B1C RID: 88860 RVA: 0x0031FC35 File Offset: 0x0031DE35
		// (set) Token: 0x06015B1D RID: 88861 RVA: 0x0031FC3D File Offset: 0x0031DE3D
		public EVar Type { get; set; }

		// Token: 0x17006C96 RID: 27798
		// (get) Token: 0x06015B1E RID: 88862 RVA: 0x0031FC46 File Offset: 0x0031DE46
		// (set) Token: 0x06015B1F RID: 88863 RVA: 0x0031FC4E File Offset: 0x0031DE4E
		public EVarRefSource Source { get; set; }

		// Token: 0x17006C97 RID: 27799
		// (get) Token: 0x06015B20 RID: 88864 RVA: 0x0031FC57 File Offset: 0x0031DE57
		// (set) Token: 0x06015B21 RID: 88865 RVA: 0x0031FC5F File Offset: 0x0031DE5F
		public ERefType RefType { get; set; }

		// Token: 0x17006C98 RID: 27800
		// (get) Token: 0x06015B22 RID: 88866 RVA: 0x0031FC68 File Offset: 0x0031DE68
		// (set) Token: 0x06015B23 RID: 88867 RVA: 0x0031FC70 File Offset: 0x0031DE70
		public int RefId { get; set; }

		// Token: 0x17006C99 RID: 27801
		// (get) Token: 0x06015B24 RID: 88868 RVA: 0x0031FC79 File Offset: 0x0031DE79
		// (set) Token: 0x06015B25 RID: 88869 RVA: 0x0031FC81 File Offset: 0x0031DE81
		public string Name { get; set; }

		// Token: 0x06015B26 RID: 88870 RVA: 0x0031FC8A File Offset: 0x0031DE8A
		public IOtherVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
			this.RefType = ERefType.Entity;
			this.RefId = 0;
			this.Name = null;
		}
	}
}
