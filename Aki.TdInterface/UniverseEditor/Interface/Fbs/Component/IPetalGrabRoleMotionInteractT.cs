using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005728 RID: 22312
	public class IPetalGrabRoleMotionInteractT
	{
		// Token: 0x1700A63D RID: 42557
		// (get) Token: 0x06025560 RID: 152928 RVA: 0x00526D20 File Offset: 0x00524F20
		// (set) Token: 0x06025561 RID: 152929 RVA: 0x00526D28 File Offset: 0x00524F28
		public ERoleMotionInteractType Type { get; set; }

		// Token: 0x1700A63E RID: 42558
		// (get) Token: 0x06025562 RID: 152930 RVA: 0x00526D31 File Offset: 0x00524F31
		// (set) Token: 0x06025563 RID: 152931 RVA: 0x00526D39 File Offset: 0x00524F39
		public EPetalGrabHandType HandOption { get; set; }

		// Token: 0x1700A63F RID: 42559
		// (get) Token: 0x06025564 RID: 152932 RVA: 0x00526D42 File Offset: 0x00524F42
		// (set) Token: 0x06025565 RID: 152933 RVA: 0x00526D4A File Offset: 0x00524F4A
		public IPosAndRotT GrabPointOffset { get; set; }

		// Token: 0x1700A640 RID: 42560
		// (get) Token: 0x06025566 RID: 152934 RVA: 0x00526D53 File Offset: 0x00524F53
		// (set) Token: 0x06025567 RID: 152935 RVA: 0x00526D5B File Offset: 0x00524F5B
		public List<IPetalGrabEventT> GrabEvents { get; set; }

		// Token: 0x1700A641 RID: 42561
		// (get) Token: 0x06025568 RID: 152936 RVA: 0x00526D64 File Offset: 0x00524F64
		// (set) Token: 0x06025569 RID: 152937 RVA: 0x00526D6C File Offset: 0x00524F6C
		public int NextPointEntityId { get; set; }

		// Token: 0x1700A642 RID: 42562
		// (get) Token: 0x0602556A RID: 152938 RVA: 0x00526D75 File Offset: 0x00524F75
		// (set) Token: 0x0602556B RID: 152939 RVA: 0x00526D7D File Offset: 0x00524F7D
		public byte NullMask { get; set; }

		// Token: 0x0602556C RID: 152940 RVA: 0x00526D86 File Offset: 0x00524F86
		public IPetalGrabRoleMotionInteractT()
		{
			this.Type = ERoleMotionInteractType.PetalGrab;
			this.HandOption = EPetalGrabHandType.LeftHand;
			this.GrabPointOffset = null;
			this.GrabEvents = null;
			this.NextPointEntityId = 0;
			this.NullMask = 0;
		}
	}
}
