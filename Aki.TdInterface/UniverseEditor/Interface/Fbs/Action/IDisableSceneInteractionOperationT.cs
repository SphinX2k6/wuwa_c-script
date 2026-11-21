using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C60 RID: 27744
	public class IDisableSceneInteractionOperationT
	{
		// Token: 0x1700CB76 RID: 52086
		// (get) Token: 0x0602FC84 RID: 195716 RVA: 0x00681EFE File Offset: 0x006800FE
		// (set) Token: 0x0602FC85 RID: 195717 RVA: 0x00681F06 File Offset: 0x00680106
		public ESceneInteractionOperationType Type { get; set; }

		// Token: 0x0602FC86 RID: 195718 RVA: 0x00681F0F File Offset: 0x0068010F
		public IDisableSceneInteractionOperationT()
		{
			this.Type = ESceneInteractionOperationType.Enable;
		}
	}
}
