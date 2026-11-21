using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007214 RID: 29204
	public class IMonsterMoveSplineConfigT
	{
		// Token: 0x1700D5C3 RID: 54723
		// (get) Token: 0x06032D10 RID: 208144 RVA: 0x006DCCAC File Offset: 0x006DAEAC
		// (set) Token: 0x06032D11 RID: 208145 RVA: 0x006DCCB4 File Offset: 0x006DAEB4
		public int TargetEntityId { get; set; }

		// Token: 0x1700D5C4 RID: 54724
		// (get) Token: 0x06032D12 RID: 208146 RVA: 0x006DCCBD File Offset: 0x006DAEBD
		// (set) Token: 0x06032D13 RID: 208147 RVA: 0x006DCCC5 File Offset: 0x006DAEC5
		public int SplineEntityId { get; set; }

		// Token: 0x1700D5C5 RID: 54725
		// (get) Token: 0x06032D14 RID: 208148 RVA: 0x006DCCCE File Offset: 0x006DAECE
		// (set) Token: 0x06032D15 RID: 208149 RVA: 0x006DCCD6 File Offset: 0x006DAED6
		public bool IsStrict { get; set; }

		// Token: 0x1700D5C6 RID: 54726
		// (get) Token: 0x06032D16 RID: 208150 RVA: 0x006DCCDF File Offset: 0x006DAEDF
		// (set) Token: 0x06032D17 RID: 208151 RVA: 0x006DCCE7 File Offset: 0x006DAEE7
		public byte NullMask { get; set; }

		// Token: 0x06032D18 RID: 208152 RVA: 0x006DCCF0 File Offset: 0x006DAEF0
		public IMonsterMoveSplineConfigT()
		{
			this.TargetEntityId = 0;
			this.SplineEntityId = 0;
			this.IsStrict = false;
			this.NullMask = 0;
		}
	}
}
