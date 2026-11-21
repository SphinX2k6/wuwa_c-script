using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F6F RID: 20335
	public class ICheckIsTargetHoldElementalBoxT
	{
		// Token: 0x1700915D RID: 37213
		// (get) Token: 0x0601FA81 RID: 129665 RVA: 0x00466E77 File Offset: 0x00465077
		// (set) Token: 0x0601FA82 RID: 129666 RVA: 0x00466E7F File Offset: 0x0046507F
		public ECondition Type { get; set; }

		// Token: 0x1700915E RID: 37214
		// (get) Token: 0x0601FA83 RID: 129667 RVA: 0x00466E88 File Offset: 0x00465088
		// (set) Token: 0x0601FA84 RID: 129668 RVA: 0x00466E90 File Offset: 0x00465090
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700915F RID: 37215
		// (get) Token: 0x0601FA85 RID: 129669 RVA: 0x00466E99 File Offset: 0x00465099
		// (set) Token: 0x0601FA86 RID: 129670 RVA: 0x00466EA1 File Offset: 0x004650A1
		public bool IsHolding { get; set; }

		// Token: 0x17009160 RID: 37216
		// (get) Token: 0x0601FA87 RID: 129671 RVA: 0x00466EAA File Offset: 0x004650AA
		// (set) Token: 0x0601FA88 RID: 129672 RVA: 0x00466EB2 File Offset: 0x004650B2
		public EElementalType TargetElementalType { get; set; }

		// Token: 0x17009161 RID: 37217
		// (get) Token: 0x0601FA89 RID: 129673 RVA: 0x00466EBB File Offset: 0x004650BB
		// (set) Token: 0x0601FA8A RID: 129674 RVA: 0x00466EC3 File Offset: 0x004650C3
		public int ElementalBoxId { get; set; }

		// Token: 0x17009162 RID: 37218
		// (get) Token: 0x0601FA8B RID: 129675 RVA: 0x00466ECC File Offset: 0x004650CC
		// (set) Token: 0x0601FA8C RID: 129676 RVA: 0x00466ED4 File Offset: 0x004650D4
		public byte NullMask { get; set; }

		// Token: 0x0601FA8D RID: 129677 RVA: 0x00466EDD File Offset: 0x004650DD
		public ICheckIsTargetHoldElementalBoxT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.IsHolding = false;
			this.TargetElementalType = EElementalType.Fire;
			this.ElementalBoxId = 0;
			this.NullMask = 0;
		}
	}
}
