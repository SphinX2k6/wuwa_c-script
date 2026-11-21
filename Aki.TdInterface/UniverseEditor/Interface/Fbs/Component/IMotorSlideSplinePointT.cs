using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B6E RID: 23406
	public class IMotorSlideSplinePointT
	{
		// Token: 0x1700AB00 RID: 43776
		// (get) Token: 0x060268BC RID: 157884 RVA: 0x00547759 File Offset: 0x00545959
		// (set) Token: 0x060268BD RID: 157885 RVA: 0x00547761 File Offset: 0x00545961
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700AB01 RID: 43777
		// (get) Token: 0x060268BE RID: 157886 RVA: 0x0054776A File Offset: 0x0054596A
		// (set) Token: 0x060268BF RID: 157887 RVA: 0x00547772 File Offset: 0x00545972
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700AB02 RID: 43778
		// (get) Token: 0x060268C0 RID: 157888 RVA: 0x0054777B File Offset: 0x0054597B
		// (set) Token: 0x060268C1 RID: 157889 RVA: 0x00547783 File Offset: 0x00545983
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700AB03 RID: 43779
		// (get) Token: 0x060268C2 RID: 157890 RVA: 0x0054778C File Offset: 0x0054598C
		// (set) Token: 0x060268C3 RID: 157891 RVA: 0x00547794 File Offset: 0x00545994
		public ESplineLine LineType { get; set; }

		// Token: 0x1700AB04 RID: 43780
		// (get) Token: 0x060268C4 RID: 157892 RVA: 0x0054779D File Offset: 0x0054599D
		// (set) Token: 0x060268C5 RID: 157893 RVA: 0x005477A5 File Offset: 0x005459A5
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700AB05 RID: 43781
		// (get) Token: 0x060268C6 RID: 157894 RVA: 0x005477AE File Offset: 0x005459AE
		// (set) Token: 0x060268C7 RID: 157895 RVA: 0x005477B6 File Offset: 0x005459B6
		public float MaxSpeed { get; set; }

		// Token: 0x1700AB06 RID: 43782
		// (get) Token: 0x060268C8 RID: 157896 RVA: 0x005477BF File Offset: 0x005459BF
		// (set) Token: 0x060268C9 RID: 157897 RVA: 0x005477C7 File Offset: 0x005459C7
		public float AbsAcceleration { get; set; }

		// Token: 0x1700AB07 RID: 43783
		// (get) Token: 0x060268CA RID: 157898 RVA: 0x005477D0 File Offset: 0x005459D0
		// (set) Token: 0x060268CB RID: 157899 RVA: 0x005477D8 File Offset: 0x005459D8
		public EMotorSlideOffDirection OffDirection { get; set; }

		// Token: 0x1700AB08 RID: 43784
		// (get) Token: 0x060268CC RID: 157900 RVA: 0x005477E1 File Offset: 0x005459E1
		// (set) Token: 0x060268CD RID: 157901 RVA: 0x005477E9 File Offset: 0x005459E9
		public int LeftTargetId { get; set; }

		// Token: 0x1700AB09 RID: 43785
		// (get) Token: 0x060268CE RID: 157902 RVA: 0x005477F2 File Offset: 0x005459F2
		// (set) Token: 0x060268CF RID: 157903 RVA: 0x005477FA File Offset: 0x005459FA
		public int RightTargetId { get; set; }

		// Token: 0x1700AB0A RID: 43786
		// (get) Token: 0x060268D0 RID: 157904 RVA: 0x00547803 File Offset: 0x00545A03
		// (set) Token: 0x060268D1 RID: 157905 RVA: 0x0054780B File Offset: 0x00545A0B
		public int SubCameraTag { get; set; }

		// Token: 0x1700AB0B RID: 43787
		// (get) Token: 0x060268D2 RID: 157906 RVA: 0x00547814 File Offset: 0x00545A14
		// (set) Token: 0x060268D3 RID: 157907 RVA: 0x0054781C File Offset: 0x00545A1C
		public byte NullMask { get; set; }

		// Token: 0x060268D4 RID: 157908 RVA: 0x00547828 File Offset: 0x00545A28
		public IMotorSlideSplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.MaxSpeed = 0f;
			this.AbsAcceleration = 0f;
			this.OffDirection = EMotorSlideOffDirection.Left;
			this.LeftTargetId = 0;
			this.RightTargetId = 0;
			this.SubCameraTag = 0;
			this.NullMask = 0;
		}
	}
}
