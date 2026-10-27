using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ABF RID: 27327
	public class IModifyMaterialConfigT
	{
		// Token: 0x1700CAC6 RID: 51910
		// (get) Token: 0x0602FE4E RID: 196174 RVA: 0x00683DBA File Offset: 0x00681FBA
		// (set) Token: 0x0602FE4F RID: 196175 RVA: 0x00683DC2 File Offset: 0x00681FC2
		public EModifyActorMaterialType Type { get; set; }

		// Token: 0x0602FE50 RID: 196176 RVA: 0x00683DCB File Offset: 0x00681FCB
		public IModifyMaterialConfigT()
		{
			this.Type = EModifyActorMaterialType.ChangeMaterialData;
		}
	}
}
