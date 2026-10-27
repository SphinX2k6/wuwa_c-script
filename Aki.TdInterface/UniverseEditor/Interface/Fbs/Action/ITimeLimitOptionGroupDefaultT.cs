using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E3 RID: 29667
	public class ITimeLimitOptionGroupDefaultT
	{
		// Token: 0x1700E15B RID: 57691
		// (get) Token: 0x06035E4F RID: 220751 RVA: 0x00755C86 File Offset: 0x00753E86
		// (set) Token: 0x06035E50 RID: 220752 RVA: 0x00755C8E File Offset: 0x00753E8E
		public ETimeLimitOptionGroupStyle Type { get; set; }

		// Token: 0x1700E15C RID: 57692
		// (get) Token: 0x06035E51 RID: 220753 RVA: 0x00755C97 File Offset: 0x00753E97
		// (set) Token: 0x06035E52 RID: 220754 RVA: 0x00755C9F File Offset: 0x00753E9F
		public int TimeoutOptionIndex { get; set; }

		// Token: 0x1700E15D RID: 57693
		// (get) Token: 0x06035E53 RID: 220755 RVA: 0x00755CA8 File Offset: 0x00753EA8
		// (set) Token: 0x06035E54 RID: 220756 RVA: 0x00755CB0 File Offset: 0x00753EB0
		public float TimeLimit { get; set; }

		// Token: 0x06035E55 RID: 220757 RVA: 0x00755CB9 File Offset: 0x00753EB9
		public ITimeLimitOptionGroupDefaultT()
		{
			this.Type = ETimeLimitOptionGroupStyle.Default;
			this.TimeoutOptionIndex = 0;
			this.TimeLimit = 0f;
		}
	}
}
