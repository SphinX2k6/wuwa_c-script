using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004632 RID: 17970
	public class ITimerConfigT
	{
		// Token: 0x17007DB3 RID: 32179
		// (get) Token: 0x0601A4C1 RID: 107713 RVA: 0x003BE3A9 File Offset: 0x003BC5A9
		// (set) Token: 0x0601A4C2 RID: 107714 RVA: 0x003BE3B1 File Offset: 0x003BC5B1
		public int Time { get; set; }

		// Token: 0x17007DB4 RID: 32180
		// (get) Token: 0x0601A4C3 RID: 107715 RVA: 0x003BE3BA File Offset: 0x003BC5BA
		// (set) Token: 0x0601A4C4 RID: 107716 RVA: 0x003BE3C2 File Offset: 0x003BC5C2
		public TVarRefUnion VarForTime { get; set; }

		// Token: 0x17007DB5 RID: 32181
		// (get) Token: 0x0601A4C5 RID: 107717 RVA: 0x003BE3CB File Offset: 0x003BC5CB
		// (set) Token: 0x0601A4C6 RID: 107718 RVA: 0x003BE3D3 File Offset: 0x003BC5D3
		public ETimerType TimerType { get; set; }

		// Token: 0x17007DB6 RID: 32182
		// (get) Token: 0x0601A4C7 RID: 107719 RVA: 0x003BE3DC File Offset: 0x003BC5DC
		// (set) Token: 0x0601A4C8 RID: 107720 RVA: 0x003BE3E4 File Offset: 0x003BC5E4
		public ITimerUiConfigT UiConfig { get; set; }

		// Token: 0x17007DB7 RID: 32183
		// (get) Token: 0x0601A4C9 RID: 107721 RVA: 0x003BE3ED File Offset: 0x003BC5ED
		// (set) Token: 0x0601A4CA RID: 107722 RVA: 0x003BE3F5 File Offset: 0x003BC5F5
		public byte NullMask { get; set; }

		// Token: 0x0601A4CB RID: 107723 RVA: 0x003BE3FE File Offset: 0x003BC5FE
		public ITimerConfigT()
		{
			this.Time = 0;
			this.VarForTime = null;
			this.TimerType = ETimerType.CountDownChallenge;
			this.UiConfig = null;
			this.NullMask = 0;
		}
	}
}
