using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CDA RID: 19674
	public class IStabilityPointAttributeT
	{
		// Token: 0x17008ED0 RID: 36560
		// (get) Token: 0x0601F38F RID: 127887 RVA: 0x0045B892 File Offset: 0x00459A92
		// (set) Token: 0x0601F390 RID: 127888 RVA: 0x0045B89A File Offset: 0x00459A9A
		public EPlayerAttributeType Type { get; set; }

		// Token: 0x17008ED1 RID: 36561
		// (get) Token: 0x0601F391 RID: 127889 RVA: 0x0045B8A3 File Offset: 0x00459AA3
		// (set) Token: 0x0601F392 RID: 127890 RVA: 0x0045B8AB File Offset: 0x00459AAB
		public ECompare Compare { get; set; }

		// Token: 0x17008ED2 RID: 36562
		// (get) Token: 0x0601F393 RID: 127891 RVA: 0x0045B8B4 File Offset: 0x00459AB4
		// (set) Token: 0x0601F394 RID: 127892 RVA: 0x0045B8BC File Offset: 0x00459ABC
		public int Value { get; set; }

		// Token: 0x17008ED3 RID: 36563
		// (get) Token: 0x0601F395 RID: 127893 RVA: 0x0045B8C5 File Offset: 0x00459AC5
		// (set) Token: 0x0601F396 RID: 127894 RVA: 0x0045B8CD File Offset: 0x00459ACD
		public int ValueGroup { get; set; }

		// Token: 0x17008ED4 RID: 36564
		// (get) Token: 0x0601F397 RID: 127895 RVA: 0x0045B8D6 File Offset: 0x00459AD6
		// (set) Token: 0x0601F398 RID: 127896 RVA: 0x0045B8DE File Offset: 0x00459ADE
		public byte NullMask { get; set; }

		// Token: 0x0601F399 RID: 127897 RVA: 0x0045B8E7 File Offset: 0x00459AE7
		public IStabilityPointAttributeT()
		{
			this.Type = EPlayerAttributeType.Health;
			this.Compare = ECompare.Eq;
			this.Value = 0;
			this.ValueGroup = 0;
			this.NullMask = 0;
		}
	}
}
