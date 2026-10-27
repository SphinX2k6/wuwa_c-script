using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D0 RID: 21968
	public class IMotorSlideSplinePointT
	{
		// Token: 0x1700A278 RID: 41592
		// (get) Token: 0x060246AF RID: 149167 RVA: 0x005071E1 File Offset: 0x005053E1
		// (set) Token: 0x060246B0 RID: 149168 RVA: 0x005071E9 File Offset: 0x005053E9
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700A279 RID: 41593
		// (get) Token: 0x060246B1 RID: 149169 RVA: 0x005071F2 File Offset: 0x005053F2
		// (set) Token: 0x060246B2 RID: 149170 RVA: 0x005071FA File Offset: 0x005053FA
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x1700A27A RID: 41594
		// (get) Token: 0x060246B3 RID: 149171 RVA: 0x00507203 File Offset: 0x00505403
		// (set) Token: 0x060246B4 RID: 149172 RVA: 0x0050720B File Offset: 0x0050540B
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x1700A27B RID: 41595
		// (get) Token: 0x060246B5 RID: 149173 RVA: 0x00507214 File Offset: 0x00505414
		// (set) Token: 0x060246B6 RID: 149174 RVA: 0x0050721C File Offset: 0x0050541C
		public ESplineLine LineType { get; set; }

		// Token: 0x1700A27C RID: 41596
		// (get) Token: 0x060246B7 RID: 149175 RVA: 0x00507225 File Offset: 0x00505425
		// (set) Token: 0x060246B8 RID: 149176 RVA: 0x0050722D File Offset: 0x0050542D
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x1700A27D RID: 41597
		// (get) Token: 0x060246B9 RID: 149177 RVA: 0x00507236 File Offset: 0x00505436
		// (set) Token: 0x060246BA RID: 149178 RVA: 0x0050723E File Offset: 0x0050543E
		public float MaxSpeed { get; set; }

		// Token: 0x1700A27E RID: 41598
		// (get) Token: 0x060246BB RID: 149179 RVA: 0x00507247 File Offset: 0x00505447
		// (set) Token: 0x060246BC RID: 149180 RVA: 0x0050724F File Offset: 0x0050544F
		public float AbsAcceleration { get; set; }

		// Token: 0x1700A27F RID: 41599
		// (get) Token: 0x060246BD RID: 149181 RVA: 0x00507258 File Offset: 0x00505458
		// (set) Token: 0x060246BE RID: 149182 RVA: 0x00507260 File Offset: 0x00505460
		public EMotorSlideOffDirection OffDirection { get; set; }

		// Token: 0x1700A280 RID: 41600
		// (get) Token: 0x060246BF RID: 149183 RVA: 0x00507269 File Offset: 0x00505469
		// (set) Token: 0x060246C0 RID: 149184 RVA: 0x00507271 File Offset: 0x00505471
		public int LeftTargetId { get; set; }

		// Token: 0x1700A281 RID: 41601
		// (get) Token: 0x060246C1 RID: 149185 RVA: 0x0050727A File Offset: 0x0050547A
		// (set) Token: 0x060246C2 RID: 149186 RVA: 0x00507282 File Offset: 0x00505482
		public int RightTargetId { get; set; }

		// Token: 0x1700A282 RID: 41602
		// (get) Token: 0x060246C3 RID: 149187 RVA: 0x0050728B File Offset: 0x0050548B
		// (set) Token: 0x060246C4 RID: 149188 RVA: 0x00507293 File Offset: 0x00505493
		public int SubCameraTag { get; set; }

		// Token: 0x1700A283 RID: 41603
		// (get) Token: 0x060246C5 RID: 149189 RVA: 0x0050729C File Offset: 0x0050549C
		// (set) Token: 0x060246C6 RID: 149190 RVA: 0x005072A4 File Offset: 0x005054A4
		public byte NullMask { get; set; }

		// Token: 0x060246C7 RID: 149191 RVA: 0x005072B0 File Offset: 0x005054B0
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
