using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007601 RID: 30209
	public class IResetEntityT
	{
		// Token: 0x1700DE02 RID: 56834
		// (get) Token: 0x06035025 RID: 217125 RVA: 0x0071F1FD File Offset: 0x0071D3FD
		// (set) Token: 0x06035026 RID: 217126 RVA: 0x0071F205 File Offset: 0x0071D405
		public TResetEntityConfigUnion ResetEntityConfig { get; set; }

		// Token: 0x06035027 RID: 217127 RVA: 0x0071F20E File Offset: 0x0071D40E
		public IResetEntityT()
		{
			this.ResetEntityConfig = null;
		}
	}
}
