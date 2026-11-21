using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F48 RID: 28488
	public class IGroupAiCommunicateModeT
	{
		// Token: 0x1700D0CC RID: 53452
		// (get) Token: 0x060314EE RID: 201966 RVA: 0x006ADD32 File Offset: 0x006ABF32
		// (set) Token: 0x060314EF RID: 201967 RVA: 0x006ADD3A File Offset: 0x006ABF3A
		public EGroupAiCommunicateType Type { get; set; }

		// Token: 0x060314F0 RID: 201968 RVA: 0x006ADD43 File Offset: 0x006ABF43
		public IGroupAiCommunicateModeT()
		{
			this.Type = EGroupAiCommunicateType.AddTag;
		}
	}
}
