using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B5 RID: 30389
	public class ISceneInspectionT
	{
		// Token: 0x1700DEEB RID: 57067
		// (get) Token: 0x060354F3 RID: 218355 RVA: 0x00726CE6 File Offset: 0x00724EE6
		// (set) Token: 0x060354F4 RID: 218356 RVA: 0x00726CEE File Offset: 0x00724EEE
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700DEEC RID: 57068
		// (get) Token: 0x060354F5 RID: 218357 RVA: 0x00726CF7 File Offset: 0x00724EF7
		// (set) Token: 0x060354F6 RID: 218358 RVA: 0x00726CFF File Offset: 0x00724EFF
		public string SaveVarName { get; set; }

		// Token: 0x1700DEED RID: 57069
		// (get) Token: 0x060354F7 RID: 218359 RVA: 0x00726D08 File Offset: 0x00724F08
		// (set) Token: 0x060354F8 RID: 218360 RVA: 0x00726D10 File Offset: 0x00724F10
		public List<ISceneInspectionPointT> InteractPoints { get; set; }

		// Token: 0x060354F9 RID: 218361 RVA: 0x00726D19 File Offset: 0x00724F19
		public ISceneInspectionT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.SaveVarName = null;
			this.InteractPoints = null;
		}
	}
}
