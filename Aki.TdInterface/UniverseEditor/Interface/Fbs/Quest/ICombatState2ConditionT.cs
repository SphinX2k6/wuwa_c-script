using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D92 RID: 15762
	public class ICombatState2ConditionT
	{
		// Token: 0x17006C65 RID: 27749
		// (get) Token: 0x06015E3A RID: 89658 RVA: 0x00329375 File Offset: 0x00327575
		// (set) Token: 0x06015E3B RID: 89659 RVA: 0x0032937D File Offset: 0x0032757D
		public int EntityId { get; set; }

		// Token: 0x17006C66 RID: 27750
		// (get) Token: 0x06015E3C RID: 89660 RVA: 0x00329386 File Offset: 0x00327586
		// (set) Token: 0x06015E3D RID: 89661 RVA: 0x0032938E File Offset: 0x0032758E
		public string State { get; set; }

		// Token: 0x17006C67 RID: 27751
		// (get) Token: 0x06015E3E RID: 89662 RVA: 0x00329397 File Offset: 0x00327597
		// (set) Token: 0x06015E3F RID: 89663 RVA: 0x0032939F File Offset: 0x0032759F
		public ECompare Compare { get; set; }

		// Token: 0x17006C68 RID: 27752
		// (get) Token: 0x06015E40 RID: 89664 RVA: 0x003293A8 File Offset: 0x003275A8
		// (set) Token: 0x06015E41 RID: 89665 RVA: 0x003293B0 File Offset: 0x003275B0
		public EDetectTarget DetectTarget { get; set; }

		// Token: 0x17006C69 RID: 27753
		// (get) Token: 0x06015E42 RID: 89666 RVA: 0x003293B9 File Offset: 0x003275B9
		// (set) Token: 0x06015E43 RID: 89667 RVA: 0x003293C1 File Offset: 0x003275C1
		public byte NullMask { get; set; }

		// Token: 0x06015E44 RID: 89668 RVA: 0x003293CA File Offset: 0x003275CA
		public ICombatState2ConditionT()
		{
			this.EntityId = 0;
			this.State = null;
			this.Compare = ECompare.Eq;
			this.DetectTarget = EDetectTarget.ControlledRole;
			this.NullMask = 0;
		}
	}
}
