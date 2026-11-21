using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F1A RID: 16154
	public class IVarRefT
	{
		// Token: 0x17006D64 RID: 28004
		// (get) Token: 0x06015F17 RID: 89879 RVA: 0x00327978 File Offset: 0x00325B78
		// (set) Token: 0x06015F18 RID: 89880 RVA: 0x00327980 File Offset: 0x00325B80
		public EVar Type { get; set; }

		// Token: 0x17006D65 RID: 28005
		// (get) Token: 0x06015F19 RID: 89881 RVA: 0x00327989 File Offset: 0x00325B89
		// (set) Token: 0x06015F1A RID: 89882 RVA: 0x00327991 File Offset: 0x00325B91
		public EVarRefSource Source { get; set; }

		// Token: 0x06015F1B RID: 89883 RVA: 0x0032799A File Offset: 0x00325B9A
		public IVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
		}
	}
}
