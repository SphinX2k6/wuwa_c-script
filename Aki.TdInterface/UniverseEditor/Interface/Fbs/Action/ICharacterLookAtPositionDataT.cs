using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BE RID: 27070
	public class ICharacterLookAtPositionDataT
	{
		// Token: 0x1700C733 RID: 50995
		// (get) Token: 0x0602E6FA RID: 190202 RVA: 0x0065612F File Offset: 0x0065432F
		// (set) Token: 0x0602E6FB RID: 190203 RVA: 0x00656137 File Offset: 0x00654337
		public ECharacterLookAt Type { get; set; }

		// Token: 0x1700C734 RID: 50996
		// (get) Token: 0x0602E6FC RID: 190204 RVA: 0x00656140 File Offset: 0x00654340
		// (set) Token: 0x0602E6FD RID: 190205 RVA: 0x00656148 File Offset: 0x00654348
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0602E6FE RID: 190206 RVA: 0x00656151 File Offset: 0x00654351
		public ICharacterLookAtPositionDataT()
		{
			this.Type = ECharacterLookAt.Empty;
			this.Pos = null;
		}
	}
}
