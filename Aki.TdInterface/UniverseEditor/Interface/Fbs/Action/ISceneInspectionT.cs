using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F2E RID: 28462
	public class ISceneInspectionT
	{
		// Token: 0x1700D38F RID: 54159
		// (get) Token: 0x0603249B RID: 205979 RVA: 0x006CAD7E File Offset: 0x006C8F7E
		// (set) Token: 0x0603249C RID: 205980 RVA: 0x006CAD86 File Offset: 0x006C8F86
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D390 RID: 54160
		// (get) Token: 0x0603249D RID: 205981 RVA: 0x006CAD8F File Offset: 0x006C8F8F
		// (set) Token: 0x0603249E RID: 205982 RVA: 0x006CAD97 File Offset: 0x006C8F97
		public string SaveVarName { get; set; }

		// Token: 0x1700D391 RID: 54161
		// (get) Token: 0x0603249F RID: 205983 RVA: 0x006CADA0 File Offset: 0x006C8FA0
		// (set) Token: 0x060324A0 RID: 205984 RVA: 0x006CADA8 File Offset: 0x006C8FA8
		public List<ISceneInspectionPointT> InteractPoints { get; set; }

		// Token: 0x060324A1 RID: 205985 RVA: 0x006CADB1 File Offset: 0x006C8FB1
		public ISceneInspectionT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.SaveVarName = null;
			this.InteractPoints = null;
		}
	}
}
