using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EAE RID: 20142
	public class IAnimalModelConfigT
	{
		// Token: 0x17009085 RID: 36997
		// (get) Token: 0x0601FB86 RID: 129926 RVA: 0x0046A976 File Offset: 0x00468B76
		// (set) Token: 0x0601FB87 RID: 129927 RVA: 0x0046A97E File Offset: 0x00468B7E
		public EAnimalModelType Type { get; set; }

		// Token: 0x0601FB88 RID: 129928 RVA: 0x0046A987 File Offset: 0x00468B87
		public IAnimalModelConfigT()
		{
			this.Type = EAnimalModelType.Mesh;
		}
	}
}
