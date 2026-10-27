using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200727B RID: 29307
	public class ISyncVarToActorStateT
	{
		// Token: 0x1700D972 RID: 55666
		// (get) Token: 0x06034001 RID: 212993 RVA: 0x006FE17E File Offset: 0x006FC37E
		// (set) Token: 0x06034002 RID: 212994 RVA: 0x006FE186 File Offset: 0x006FC386
		public string VarName { get; set; }

		// Token: 0x1700D973 RID: 55667
		// (get) Token: 0x06034003 RID: 212995 RVA: 0x006FE18F File Offset: 0x006FC38F
		// (set) Token: 0x06034004 RID: 212996 RVA: 0x006FE197 File Offset: 0x006FC397
		public string StateKey { get; set; }

		// Token: 0x06034005 RID: 212997 RVA: 0x006FE1A0 File Offset: 0x006FC3A0
		public ISyncVarToActorStateT()
		{
			this.VarName = null;
			this.StateKey = null;
		}
	}
}
