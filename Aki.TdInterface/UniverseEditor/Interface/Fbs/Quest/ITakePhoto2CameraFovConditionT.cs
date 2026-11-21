using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045C0 RID: 17856
	public class ITakePhoto2CameraFovConditionT
	{
		// Token: 0x17007CC4 RID: 31940
		// (get) Token: 0x0601A0D7 RID: 106711 RVA: 0x003B65D0 File Offset: 0x003B47D0
		// (set) Token: 0x0601A0D8 RID: 106712 RVA: 0x003B65D8 File Offset: 0x003B47D8
		public int MinFov { get; set; }

		// Token: 0x17007CC5 RID: 31941
		// (get) Token: 0x0601A0D9 RID: 106713 RVA: 0x003B65E1 File Offset: 0x003B47E1
		// (set) Token: 0x0601A0DA RID: 106714 RVA: 0x003B65E9 File Offset: 0x003B47E9
		public int MaxFov { get; set; }

		// Token: 0x0601A0DB RID: 106715 RVA: 0x003B65F2 File Offset: 0x003B47F2
		public ITakePhoto2CameraFovConditionT()
		{
			this.MinFov = 0;
			this.MaxFov = 0;
		}
	}
}
