using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F34 RID: 28468
	public class ISceneInteractionOperationTypeT
	{
		// Token: 0x1700D399 RID: 54169
		// (get) Token: 0x060324CD RID: 206029 RVA: 0x006CB39A File Offset: 0x006C959A
		// (set) Token: 0x060324CE RID: 206030 RVA: 0x006CB3A2 File Offset: 0x006C95A2
		public ESceneInteractionOperationType Type { get; set; }

		// Token: 0x060324CF RID: 206031 RVA: 0x006CB3AB File Offset: 0x006C95AB
		public ISceneInteractionOperationTypeT()
		{
			this.Type = ESceneInteractionOperationType.Enable;
		}
	}
}
