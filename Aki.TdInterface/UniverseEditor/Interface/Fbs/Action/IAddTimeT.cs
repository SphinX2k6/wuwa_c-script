using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006138 RID: 24888
	public class IAddTimeT
	{
		// Token: 0x1700B783 RID: 46979
		// (get) Token: 0x0602A8FA RID: 174330 RVA: 0x005DC5B9 File Offset: 0x005DA7B9
		// (set) Token: 0x0602A8FB RID: 174331 RVA: 0x005DC5C1 File Offset: 0x005DA7C1
		public EChangeTimerType Type { get; set; }

		// Token: 0x1700B784 RID: 46980
		// (get) Token: 0x0602A8FC RID: 174332 RVA: 0x005DC5CA File Offset: 0x005DA7CA
		// (set) Token: 0x0602A8FD RID: 174333 RVA: 0x005DC5D2 File Offset: 0x005DA7D2
		public int Time { get; set; }

		// Token: 0x1700B785 RID: 46981
		// (get) Token: 0x0602A8FE RID: 174334 RVA: 0x005DC5DB File Offset: 0x005DA7DB
		// (set) Token: 0x0602A8FF RID: 174335 RVA: 0x005DC5E3 File Offset: 0x005DA7E3
		public TVarRefUnion VarForTime { get; set; }

		// Token: 0x1700B786 RID: 46982
		// (get) Token: 0x0602A900 RID: 174336 RVA: 0x005DC5EC File Offset: 0x005DA7EC
		// (set) Token: 0x0602A901 RID: 174337 RVA: 0x005DC5F4 File Offset: 0x005DA7F4
		public IChangeTimerUiConfigT UiConfig { get; set; }

		// Token: 0x1700B787 RID: 46983
		// (get) Token: 0x0602A902 RID: 174338 RVA: 0x005DC5FD File Offset: 0x005DA7FD
		// (set) Token: 0x0602A903 RID: 174339 RVA: 0x005DC605 File Offset: 0x005DA805
		public byte NullMask { get; set; }

		// Token: 0x0602A904 RID: 174340 RVA: 0x005DC60E File Offset: 0x005DA80E
		public IAddTimeT()
		{
			this.Type = EChangeTimerType.Add;
			this.Time = 0;
			this.VarForTime = null;
			this.UiConfig = new IChangeTimerUiConfigT();
			this.NullMask = 0;
		}
	}
}
