using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AFA RID: 19194
	public class ICheckPlayerRelativeAngleT
	{
		// Token: 0x17008B34 RID: 35636
		// (get) Token: 0x0601E2C1 RID: 123585 RVA: 0x0043B3D0 File Offset: 0x004395D0
		// (set) Token: 0x0601E2C2 RID: 123586 RVA: 0x0043B3D8 File Offset: 0x004395D8
		public ECondition Type { get; set; }

		// Token: 0x17008B35 RID: 35637
		// (get) Token: 0x0601E2C3 RID: 123587 RVA: 0x0043B3E1 File Offset: 0x004395E1
		// (set) Token: 0x0601E2C4 RID: 123588 RVA: 0x0043B3E9 File Offset: 0x004395E9
		public int TargetEntityId { get; set; }

		// Token: 0x17008B36 RID: 35638
		// (get) Token: 0x0601E2C5 RID: 123589 RVA: 0x0043B3F2 File Offset: 0x004395F2
		// (set) Token: 0x0601E2C6 RID: 123590 RVA: 0x0043B3FA File Offset: 0x004395FA
		public IVectorInfoT BaseVector { get; set; }

		// Token: 0x17008B37 RID: 35639
		// (get) Token: 0x0601E2C7 RID: 123591 RVA: 0x0043B403 File Offset: 0x00439603
		// (set) Token: 0x0601E2C8 RID: 123592 RVA: 0x0043B40B File Offset: 0x0043960B
		public EVectorSpace BaseVectorSpace { get; set; }

		// Token: 0x17008B38 RID: 35640
		// (get) Token: 0x0601E2C9 RID: 123593 RVA: 0x0043B414 File Offset: 0x00439614
		// (set) Token: 0x0601E2CA RID: 123594 RVA: 0x0043B41C File Offset: 0x0043961C
		public List<IAngleRangeT> ValidAngleRanges { get; set; }

		// Token: 0x17008B39 RID: 35641
		// (get) Token: 0x0601E2CB RID: 123595 RVA: 0x0043B425 File Offset: 0x00439625
		// (set) Token: 0x0601E2CC RID: 123596 RVA: 0x0043B42D File Offset: 0x0043962D
		public byte NullMask { get; set; }

		// Token: 0x0601E2CD RID: 123597 RVA: 0x0043B436 File Offset: 0x00439636
		public ICheckPlayerRelativeAngleT()
		{
			this.Type = ECondition.CompareVar;
			this.TargetEntityId = 0;
			this.BaseVector = null;
			this.BaseVectorSpace = EVectorSpace.World;
			this.ValidAngleRanges = null;
			this.NullMask = 0;
		}
	}
}
