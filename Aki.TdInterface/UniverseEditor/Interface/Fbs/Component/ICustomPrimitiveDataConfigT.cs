using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200505B RID: 20571
	public class ICustomPrimitiveDataConfigT
	{
		// Token: 0x1700953F RID: 38207
		// (get) Token: 0x06020F79 RID: 135033 RVA: 0x00494FE3 File Offset: 0x004931E3
		// (set) Token: 0x06020F7A RID: 135034 RVA: 0x00494FEB File Offset: 0x004931EB
		public EProceduralMaterialType Type { get; set; }

		// Token: 0x17009540 RID: 38208
		// (get) Token: 0x06020F7B RID: 135035 RVA: 0x00494FF4 File Offset: 0x004931F4
		// (set) Token: 0x06020F7C RID: 135036 RVA: 0x00494FFC File Offset: 0x004931FC
		public List<ICustomPrimitiveMappingT> PrimitiveConfigs { get; set; }

		// Token: 0x17009541 RID: 38209
		// (get) Token: 0x06020F7D RID: 135037 RVA: 0x00495005 File Offset: 0x00493205
		// (set) Token: 0x06020F7E RID: 135038 RVA: 0x0049500D File Offset: 0x0049320D
		public bool IsChildEffective { get; set; }

		// Token: 0x17009542 RID: 38210
		// (get) Token: 0x06020F7F RID: 135039 RVA: 0x00495016 File Offset: 0x00493216
		// (set) Token: 0x06020F80 RID: 135040 RVA: 0x0049501E File Offset: 0x0049321E
		public byte NullMask { get; set; }

		// Token: 0x06020F81 RID: 135041 RVA: 0x00495027 File Offset: 0x00493227
		public ICustomPrimitiveDataConfigT()
		{
			this.Type = EProceduralMaterialType.CustomPrimitiveData;
			this.PrimitiveConfigs = null;
			this.IsChildEffective = false;
			this.NullMask = 0;
		}
	}
}
