using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C8 RID: 21704
	public class ILevelAIComponentT
	{
		// Token: 0x17009FF0 RID: 40944
		// (get) Token: 0x06023C50 RID: 146512 RVA: 0x004F2057 File Offset: 0x004F0257
		// (set) Token: 0x06023C51 RID: 146513 RVA: 0x004F205F File Offset: 0x004F025F
		public bool Disabled { get; set; }

		// Token: 0x17009FF1 RID: 40945
		// (get) Token: 0x06023C52 RID: 146514 RVA: 0x004F2068 File Offset: 0x004F0268
		// (set) Token: 0x06023C53 RID: 146515 RVA: 0x004F2070 File Offset: 0x004F0270
		public List<ILevelAIStateT> States { get; set; }

		// Token: 0x17009FF2 RID: 40946
		// (get) Token: 0x06023C54 RID: 146516 RVA: 0x004F2079 File Offset: 0x004F0279
		// (set) Token: 0x06023C55 RID: 146517 RVA: 0x004F2081 File Offset: 0x004F0281
		public string BtTreeAsset { get; set; }

		// Token: 0x17009FF3 RID: 40947
		// (get) Token: 0x06023C56 RID: 146518 RVA: 0x004F208A File Offset: 0x004F028A
		// (set) Token: 0x06023C57 RID: 146519 RVA: 0x004F2092 File Offset: 0x004F0292
		public ICommonBtOverrideT CommonBtOverride { get; set; }

		// Token: 0x17009FF4 RID: 40948
		// (get) Token: 0x06023C58 RID: 146520 RVA: 0x004F209B File Offset: 0x004F029B
		// (set) Token: 0x06023C59 RID: 146521 RVA: 0x004F20A3 File Offset: 0x004F02A3
		public byte NullMask { get; set; }

		// Token: 0x06023C5A RID: 146522 RVA: 0x004F20AC File Offset: 0x004F02AC
		public ILevelAIComponentT()
		{
			this.Disabled = false;
			this.States = null;
			this.BtTreeAsset = null;
			this.CommonBtOverride = null;
			this.NullMask = 0;
		}
	}
}
