using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E9C RID: 24220
	public class IRotatorComponentT
	{
		// Token: 0x1700B2CF RID: 45775
		// (get) Token: 0x060288CC RID: 166092 RVA: 0x0058B527 File Offset: 0x00589727
		// (set) Token: 0x060288CD RID: 166093 RVA: 0x0058B52F File Offset: 0x0058972F
		public bool Disabled { get; set; }

		// Token: 0x1700B2D0 RID: 45776
		// (get) Token: 0x060288CE RID: 166094 RVA: 0x0058B538 File Offset: 0x00589738
		// (set) Token: 0x060288CF RID: 166095 RVA: 0x0058B540 File Offset: 0x00589740
		public string Content { get; set; }

		// Token: 0x1700B2D1 RID: 45777
		// (get) Token: 0x060288D0 RID: 166096 RVA: 0x0058B549 File Offset: 0x00589749
		// (set) Token: 0x060288D1 RID: 166097 RVA: 0x0058B551 File Offset: 0x00589751
		public string Icon { get; set; }

		// Token: 0x1700B2D2 RID: 45778
		// (get) Token: 0x060288D2 RID: 166098 RVA: 0x0058B55A File Offset: 0x0058975A
		// (set) Token: 0x060288D3 RID: 166099 RVA: 0x0058B562 File Offset: 0x00589762
		public IVectorInfoT RotatorSpeed { get; set; }

		// Token: 0x1700B2D3 RID: 45779
		// (get) Token: 0x060288D4 RID: 166100 RVA: 0x0058B56B File Offset: 0x0058976B
		// (set) Token: 0x060288D5 RID: 166101 RVA: 0x0058B573 File Offset: 0x00589773
		public IVectorInfoT LocationOffset { get; set; }

		// Token: 0x1700B2D4 RID: 45780
		// (get) Token: 0x060288D6 RID: 166102 RVA: 0x0058B57C File Offset: 0x0058977C
		// (set) Token: 0x060288D7 RID: 166103 RVA: 0x0058B584 File Offset: 0x00589784
		public IVectorInfoT RotationOffset { get; set; }

		// Token: 0x1700B2D5 RID: 45781
		// (get) Token: 0x060288D8 RID: 166104 RVA: 0x0058B58D File Offset: 0x0058978D
		// (set) Token: 0x060288D9 RID: 166105 RVA: 0x0058B595 File Offset: 0x00589795
		public IVectorInfoT RotationMapping { get; set; }

		// Token: 0x1700B2D6 RID: 45782
		// (get) Token: 0x060288DA RID: 166106 RVA: 0x0058B59E File Offset: 0x0058979E
		// (set) Token: 0x060288DB RID: 166107 RVA: 0x0058B5A6 File Offset: 0x005897A6
		public bool IsLocalSpace { get; set; }

		// Token: 0x1700B2D7 RID: 45783
		// (get) Token: 0x060288DC RID: 166108 RVA: 0x0058B5AF File Offset: 0x005897AF
		// (set) Token: 0x060288DD RID: 166109 RVA: 0x0058B5B7 File Offset: 0x005897B7
		public int EntityId { get; set; }

		// Token: 0x1700B2D8 RID: 45784
		// (get) Token: 0x060288DE RID: 166110 RVA: 0x0058B5C0 File Offset: 0x005897C0
		// (set) Token: 0x060288DF RID: 166111 RVA: 0x0058B5C8 File Offset: 0x005897C8
		public bool IsRotatorSelf { get; set; }

		// Token: 0x1700B2D9 RID: 45785
		// (get) Token: 0x060288E0 RID: 166112 RVA: 0x0058B5D1 File Offset: 0x005897D1
		// (set) Token: 0x060288E1 RID: 166113 RVA: 0x0058B5D9 File Offset: 0x005897D9
		public IEventRotatorT InteractAction { get; set; }

		// Token: 0x1700B2DA RID: 45786
		// (get) Token: 0x060288E2 RID: 166114 RVA: 0x0058B5E2 File Offset: 0x005897E2
		// (set) Token: 0x060288E3 RID: 166115 RVA: 0x0058B5EA File Offset: 0x005897EA
		public bool IsLockZ { get; set; }

		// Token: 0x1700B2DB RID: 45787
		// (get) Token: 0x060288E4 RID: 166116 RVA: 0x0058B5F3 File Offset: 0x005897F3
		// (set) Token: 0x060288E5 RID: 166117 RVA: 0x0058B5FB File Offset: 0x005897FB
		public bool IsRecovery { get; set; }

		// Token: 0x1700B2DC RID: 45788
		// (get) Token: 0x060288E6 RID: 166118 RVA: 0x0058B604 File Offset: 0x00589804
		// (set) Token: 0x060288E7 RID: 166119 RVA: 0x0058B60C File Offset: 0x0058980C
		public byte NullMask { get; set; }

		// Token: 0x060288E8 RID: 166120 RVA: 0x0058B618 File Offset: 0x00589818
		public IRotatorComponentT()
		{
			this.Disabled = false;
			this.Content = null;
			this.Icon = null;
			this.RotatorSpeed = null;
			this.LocationOffset = null;
			this.RotationOffset = null;
			this.RotationMapping = null;
			this.IsLocalSpace = false;
			this.EntityId = 0;
			this.IsRotatorSelf = false;
			this.InteractAction = null;
			this.IsLockZ = false;
			this.IsRecovery = false;
			this.NullMask = 0;
		}
	}
}
