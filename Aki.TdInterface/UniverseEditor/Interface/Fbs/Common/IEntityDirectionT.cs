using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063E4 RID: 25572
	public class IEntityDirectionT
	{
		// Token: 0x1700BCF6 RID: 48374
		// (get) Token: 0x0602B71E RID: 177950 RVA: 0x005EB5FB File Offset: 0x005E97FB
		// (set) Token: 0x0602B71F RID: 177951 RVA: 0x005EB603 File Offset: 0x005E9803
		public int EntityId { get; set; }

		// Token: 0x1700BCF7 RID: 48375
		// (get) Token: 0x0602B720 RID: 177952 RVA: 0x005EB60C File Offset: 0x005E980C
		// (set) Token: 0x0602B721 RID: 177953 RVA: 0x005EB614 File Offset: 0x005E9814
		public IVectorInfoT GravityDirection { get; set; }

		// Token: 0x0602B722 RID: 177954 RVA: 0x005EB61D File Offset: 0x005E981D
		public IEntityDirectionT()
		{
			this.EntityId = 0;
			this.GravityDirection = null;
		}
	}
}
