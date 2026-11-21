using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200547F RID: 21631
	public class ICalculateComponentT
	{
		// Token: 0x170099E7 RID: 39399
		// (get) Token: 0x06022017 RID: 139287 RVA: 0x004B0266 File Offset: 0x004AE466
		// (set) Token: 0x06022018 RID: 139288 RVA: 0x004B026E File Offset: 0x004AE46E
		public bool Disabled { get; set; }

		// Token: 0x170099E8 RID: 39400
		// (get) Token: 0x06022019 RID: 139289 RVA: 0x004B0277 File Offset: 0x004AE477
		// (set) Token: 0x0602201A RID: 139290 RVA: 0x004B027F File Offset: 0x004AE47F
		public List<INumberVarT> Vars { get; set; }

		// Token: 0x170099E9 RID: 39401
		// (get) Token: 0x0602201B RID: 139291 RVA: 0x004B0288 File Offset: 0x004AE488
		// (set) Token: 0x0602201C RID: 139292 RVA: 0x004B0290 File Offset: 0x004AE490
		public List<IFunctionT> Functions { get; set; }

		// Token: 0x170099EA RID: 39402
		// (get) Token: 0x0602201D RID: 139293 RVA: 0x004B0299 File Offset: 0x004AE499
		// (set) Token: 0x0602201E RID: 139294 RVA: 0x004B02A1 File Offset: 0x004AE4A1
		public byte NullMask { get; set; }

		// Token: 0x0602201F RID: 139295 RVA: 0x004B02AA File Offset: 0x004AE4AA
		public ICalculateComponentT()
		{
			this.Disabled = false;
			this.Vars = null;
			this.Functions = null;
			this.NullMask = 0;
		}
	}
}
