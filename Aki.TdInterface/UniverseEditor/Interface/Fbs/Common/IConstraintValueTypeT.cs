using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063BD RID: 25533
	public class IConstraintValueTypeT
	{
		// Token: 0x1700BCAC RID: 48300
		// (get) Token: 0x0602B5BE RID: 177598 RVA: 0x005E88C6 File Offset: 0x005E6AC6
		// (set) Token: 0x0602B5BF RID: 177599 RVA: 0x005E88CE File Offset: 0x005E6ACE
		public EConstraintValueType Type { get; set; }

		// Token: 0x0602B5C0 RID: 177600 RVA: 0x005E88D7 File Offset: 0x005E6AD7
		public IConstraintValueTypeT()
		{
			this.Type = EConstraintValueType.Max;
		}
	}
}
