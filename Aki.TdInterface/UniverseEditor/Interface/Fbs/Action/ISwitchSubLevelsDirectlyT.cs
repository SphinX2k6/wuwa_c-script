using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200726F RID: 29295
	public class ISwitchSubLevelsDirectlyT
	{
		// Token: 0x1700D95D RID: 55645
		// (get) Token: 0x06033F9C RID: 212892 RVA: 0x006FD64A File Offset: 0x006FB84A
		// (set) Token: 0x06033F9D RID: 212893 RVA: 0x006FD652 File Offset: 0x006FB852
		public ESwitchSubLevelsType Type { get; set; }

		// Token: 0x1700D95E RID: 55646
		// (get) Token: 0x06033F9E RID: 212894 RVA: 0x006FD65B File Offset: 0x006FB85B
		// (set) Token: 0x06033F9F RID: 212895 RVA: 0x006FD663 File Offset: 0x006FB863
		public List<string> LoadLevels { get; set; }

		// Token: 0x1700D95F RID: 55647
		// (get) Token: 0x06033FA0 RID: 212896 RVA: 0x006FD66C File Offset: 0x006FB86C
		// (set) Token: 0x06033FA1 RID: 212897 RVA: 0x006FD674 File Offset: 0x006FB874
		public List<string> UnloadLevels { get; set; }

		// Token: 0x1700D960 RID: 55648
		// (get) Token: 0x06033FA2 RID: 212898 RVA: 0x006FD67D File Offset: 0x006FB87D
		// (set) Token: 0x06033FA3 RID: 212899 RVA: 0x006FD685 File Offset: 0x006FB885
		public int TeleportEntityId { get; set; }

		// Token: 0x1700D961 RID: 55649
		// (get) Token: 0x06033FA4 RID: 212900 RVA: 0x006FD68E File Offset: 0x006FB88E
		// (set) Token: 0x06033FA5 RID: 212901 RVA: 0x006FD696 File Offset: 0x006FB896
		public bool IsWaitForSwitchComplete { get; set; }

		// Token: 0x1700D962 RID: 55650
		// (get) Token: 0x06033FA6 RID: 212902 RVA: 0x006FD69F File Offset: 0x006FB89F
		// (set) Token: 0x06033FA7 RID: 212903 RVA: 0x006FD6A7 File Offset: 0x006FB8A7
		public byte NullMask { get; set; }

		// Token: 0x06033FA8 RID: 212904 RVA: 0x006FD6B0 File Offset: 0x006FB8B0
		public ISwitchSubLevelsDirectlyT()
		{
			this.Type = ESwitchSubLevelsType.Directly;
			this.LoadLevels = null;
			this.UnloadLevels = null;
			this.TeleportEntityId = 0;
			this.IsWaitForSwitchComplete = false;
			this.NullMask = 0;
		}
	}
}
