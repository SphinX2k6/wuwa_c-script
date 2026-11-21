using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C06 RID: 27654
	public class IDestroySelfT
	{
		// Token: 0x1700CAC1 RID: 51905
		// (get) Token: 0x0602F991 RID: 194961 RVA: 0x0067CA08 File Offset: 0x0067AC08
		// (set) Token: 0x0602F992 RID: 194962 RVA: 0x0067CA10 File Offset: 0x0067AC10
		public bool DelayDestroy { get; set; }

		// Token: 0x1700CAC2 RID: 51906
		// (get) Token: 0x0602F993 RID: 194963 RVA: 0x0067CA19 File Offset: 0x0067AC19
		// (set) Token: 0x0602F994 RID: 194964 RVA: 0x0067CA21 File Offset: 0x0067AC21
		public byte NullMask { get; set; }

		// Token: 0x0602F995 RID: 194965 RVA: 0x0067CA2A File Offset: 0x0067AC2A
		public IDestroySelfT()
		{
			this.DelayDestroy = false;
			this.NullMask = 0;
		}
	}
}
