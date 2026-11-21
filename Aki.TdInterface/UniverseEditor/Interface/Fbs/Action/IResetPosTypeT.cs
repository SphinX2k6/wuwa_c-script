using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200762B RID: 30251
	public class IResetPosTypeT
	{
		// Token: 0x1700DE3E RID: 56894
		// (get) Token: 0x06035151 RID: 217425 RVA: 0x007211C2 File Offset: 0x0071F3C2
		// (set) Token: 0x06035152 RID: 217426 RVA: 0x007211CA File Offset: 0x0071F3CA
		public EResetPosType Type { get; set; }

		// Token: 0x06035153 RID: 217427 RVA: 0x007211D3 File Offset: 0x0071F3D3
		public IResetPosTypeT()
		{
			this.Type = EResetPosType.PosEntity;
		}
	}
}
