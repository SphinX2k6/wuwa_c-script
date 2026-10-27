using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DEF RID: 15855
	public class IEavesdropGamePlayConfigT
	{
		// Token: 0x17006D93 RID: 28051
		// (get) Token: 0x060162A5 RID: 90789 RVA: 0x00333C76 File Offset: 0x00331E76
		// (set) Token: 0x060162A6 RID: 90790 RVA: 0x00333C7E File Offset: 0x00331E7E
		public ESpecialGamePlayConfigType Type { get; set; }

		// Token: 0x17006D94 RID: 28052
		// (get) Token: 0x060162A7 RID: 90791 RVA: 0x00333C87 File Offset: 0x00331E87
		// (set) Token: 0x060162A8 RID: 90792 RVA: 0x00333C8F File Offset: 0x00331E8F
		public int EavesdropEntityId { get; set; }

		// Token: 0x17006D95 RID: 28053
		// (get) Token: 0x060162A9 RID: 90793 RVA: 0x00333C98 File Offset: 0x00331E98
		// (set) Token: 0x060162AA RID: 90794 RVA: 0x00333CA0 File Offset: 0x00331EA0
		public int HintRangeEntityId { get; set; }

		// Token: 0x17006D96 RID: 28054
		// (get) Token: 0x060162AB RID: 90795 RVA: 0x00333CA9 File Offset: 0x00331EA9
		// (set) Token: 0x060162AC RID: 90796 RVA: 0x00333CB1 File Offset: 0x00331EB1
		public int ListenableRangeEntityId { get; set; }

		// Token: 0x17006D97 RID: 28055
		// (get) Token: 0x060162AD RID: 90797 RVA: 0x00333CBA File Offset: 0x00331EBA
		// (set) Token: 0x060162AE RID: 90798 RVA: 0x00333CC2 File Offset: 0x00331EC2
		public int TooCloseRangeEntityId { get; set; }

		// Token: 0x17006D98 RID: 28056
		// (get) Token: 0x060162AF RID: 90799 RVA: 0x00333CCB File Offset: 0x00331ECB
		// (set) Token: 0x060162B0 RID: 90800 RVA: 0x00333CD3 File Offset: 0x00331ED3
		public int HintTag { get; set; }

		// Token: 0x17006D99 RID: 28057
		// (get) Token: 0x060162B1 RID: 90801 RVA: 0x00333CDC File Offset: 0x00331EDC
		// (set) Token: 0x060162B2 RID: 90802 RVA: 0x00333CE4 File Offset: 0x00331EE4
		public int ListenableTag { get; set; }

		// Token: 0x17006D9A RID: 28058
		// (get) Token: 0x060162B3 RID: 90803 RVA: 0x00333CED File Offset: 0x00331EED
		// (set) Token: 0x060162B4 RID: 90804 RVA: 0x00333CF5 File Offset: 0x00331EF5
		public int TooCloseTag { get; set; }

		// Token: 0x17006D9B RID: 28059
		// (get) Token: 0x060162B5 RID: 90805 RVA: 0x00333CFE File Offset: 0x00331EFE
		// (set) Token: 0x060162B6 RID: 90806 RVA: 0x00333D06 File Offset: 0x00331F06
		public int ListenedTag { get; set; }

		// Token: 0x060162B7 RID: 90807 RVA: 0x00333D10 File Offset: 0x00331F10
		public IEavesdropGamePlayConfigT()
		{
			this.Type = ESpecialGamePlayConfigType.Stalking;
			this.EavesdropEntityId = 0;
			this.HintRangeEntityId = 0;
			this.ListenableRangeEntityId = 0;
			this.TooCloseRangeEntityId = 0;
			this.HintTag = 0;
			this.ListenableTag = 0;
			this.TooCloseTag = 0;
			this.ListenedTag = 0;
		}
	}
}
