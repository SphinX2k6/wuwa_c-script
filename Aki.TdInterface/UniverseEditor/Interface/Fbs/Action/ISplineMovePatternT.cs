using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007960 RID: 31072
	public class ISplineMovePatternT
	{
		// Token: 0x1700E3DF RID: 58335
		// (get) Token: 0x06036B88 RID: 224136 RVA: 0x0075238C File Offset: 0x0075058C
		// (set) Token: 0x06036B89 RID: 224137 RVA: 0x00752394 File Offset: 0x00750594
		public ESplineMovePattern Type { get; set; }

		// Token: 0x1700E3E0 RID: 58336
		// (get) Token: 0x06036B8A RID: 224138 RVA: 0x0075239D File Offset: 0x0075059D
		// (set) Token: 0x06036B8B RID: 224139 RVA: 0x007523A5 File Offset: 0x007505A5
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700E3E1 RID: 58337
		// (get) Token: 0x06036B8C RID: 224140 RVA: 0x007523AE File Offset: 0x007505AE
		// (set) Token: 0x06036B8D RID: 224141 RVA: 0x007523B6 File Offset: 0x007505B6
		public bool IsOneWay { get; set; }

		// Token: 0x1700E3E2 RID: 58338
		// (get) Token: 0x06036B8E RID: 224142 RVA: 0x007523BF File Offset: 0x007505BF
		// (set) Token: 0x06036B8F RID: 224143 RVA: 0x007523C7 File Offset: 0x007505C7
		public float LayerVerticalLimit { get; set; }

		// Token: 0x1700E3E3 RID: 58339
		// (get) Token: 0x06036B90 RID: 224144 RVA: 0x007523D0 File Offset: 0x007505D0
		// (set) Token: 0x06036B91 RID: 224145 RVA: 0x007523D8 File Offset: 0x007505D8
		public bool DynamicGravity { get; set; }

		// Token: 0x1700E3E4 RID: 58340
		// (get) Token: 0x06036B92 RID: 224146 RVA: 0x007523E1 File Offset: 0x007505E1
		// (set) Token: 0x06036B93 RID: 224147 RVA: 0x007523E9 File Offset: 0x007505E9
		public float GravitySwitchAngularVelocity { get; set; }

		// Token: 0x1700E3E5 RID: 58341
		// (get) Token: 0x06036B94 RID: 224148 RVA: 0x007523F2 File Offset: 0x007505F2
		// (set) Token: 0x06036B95 RID: 224149 RVA: 0x007523FA File Offset: 0x007505FA
		public int AutoExitDistance { get; set; }

		// Token: 0x1700E3E6 RID: 58342
		// (get) Token: 0x06036B96 RID: 224150 RVA: 0x00752403 File Offset: 0x00750603
		// (set) Token: 0x06036B97 RID: 224151 RVA: 0x0075240B File Offset: 0x0075060B
		public byte NullMask { get; set; }

		// Token: 0x06036B98 RID: 224152 RVA: 0x00752414 File Offset: 0x00750614
		public ISplineMovePatternT()
		{
			this.Type = ESplineMovePattern.PathLine;
			this.MaxOffsetDistance = 0f;
			this.IsOneWay = false;
			this.LayerVerticalLimit = 0f;
			this.DynamicGravity = false;
			this.GravitySwitchAngularVelocity = 0f;
			this.AutoExitDistance = 0;
			this.NullMask = 0;
		}
	}
}
