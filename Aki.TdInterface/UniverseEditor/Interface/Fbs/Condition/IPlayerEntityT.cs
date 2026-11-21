using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005185 RID: 20869
	public class IPlayerEntityT
	{
		// Token: 0x17009578 RID: 38264
		// (get) Token: 0x06020D6D RID: 134509 RVA: 0x0048B986 File Offset: 0x00489B86
		// (set) Token: 0x06020D6E RID: 134510 RVA: 0x0048B98E File Offset: 0x00489B8E
		public ETargetEntityType Type { get; set; }

		// Token: 0x06020D6F RID: 134511 RVA: 0x0048B997 File Offset: 0x00489B97
		public IPlayerEntityT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
