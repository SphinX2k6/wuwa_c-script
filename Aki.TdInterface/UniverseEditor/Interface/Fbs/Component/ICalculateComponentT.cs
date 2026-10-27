using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F50 RID: 20304
	public class ICalculateComponentT
	{
		// Token: 0x1700926E RID: 37486
		// (get) Token: 0x060202C5 RID: 131781 RVA: 0x0047A276 File Offset: 0x00478476
		// (set) Token: 0x060202C6 RID: 131782 RVA: 0x0047A27E File Offset: 0x0047847E
		public bool Disabled { get; set; }

		// Token: 0x1700926F RID: 37487
		// (get) Token: 0x060202C7 RID: 131783 RVA: 0x0047A287 File Offset: 0x00478487
		// (set) Token: 0x060202C8 RID: 131784 RVA: 0x0047A28F File Offset: 0x0047848F
		public List<INumberVarT> Vars { get; set; }

		// Token: 0x17009270 RID: 37488
		// (get) Token: 0x060202C9 RID: 131785 RVA: 0x0047A298 File Offset: 0x00478498
		// (set) Token: 0x060202CA RID: 131786 RVA: 0x0047A2A0 File Offset: 0x004784A0
		public List<IFunctionT> Functions { get; set; }

		// Token: 0x17009271 RID: 37489
		// (get) Token: 0x060202CB RID: 131787 RVA: 0x0047A2A9 File Offset: 0x004784A9
		// (set) Token: 0x060202CC RID: 131788 RVA: 0x0047A2B1 File Offset: 0x004784B1
		public byte NullMask { get; set; }

		// Token: 0x060202CD RID: 131789 RVA: 0x0047A2BA File Offset: 0x004784BA
		public ICalculateComponentT()
		{
			this.Disabled = false;
			this.Vars = null;
			this.Functions = null;
			this.NullMask = 0;
		}
	}
}
