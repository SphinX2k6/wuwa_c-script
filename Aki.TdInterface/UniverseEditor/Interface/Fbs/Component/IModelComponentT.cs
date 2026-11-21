using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AED RID: 23277
	public class IModelComponentT
	{
		// Token: 0x1700A9DC RID: 43484
		// (get) Token: 0x060263DA RID: 156634 RVA: 0x0053D9B2 File Offset: 0x0053BBB2
		// (set) Token: 0x060263DB RID: 156635 RVA: 0x0053D9BA File Offset: 0x0053BBBA
		public bool Disabled { get; set; }

		// Token: 0x1700A9DD RID: 43485
		// (get) Token: 0x060263DC RID: 156636 RVA: 0x0053D9C3 File Offset: 0x0053BBC3
		// (set) Token: 0x060263DD RID: 156637 RVA: 0x0053D9CB File Offset: 0x0053BBCB
		public TModelTypeUnion ModelType { get; set; }

		// Token: 0x1700A9DE RID: 43486
		// (get) Token: 0x060263DE RID: 156638 RVA: 0x0053D9D4 File Offset: 0x0053BBD4
		// (set) Token: 0x060263DF RID: 156639 RVA: 0x0053D9DC File Offset: 0x0053BBDC
		public int HalfHeight { get; set; }

		// Token: 0x1700A9DF RID: 43487
		// (get) Token: 0x060263E0 RID: 156640 RVA: 0x0053D9E5 File Offset: 0x0053BBE5
		// (set) Token: 0x060263E1 RID: 156641 RVA: 0x0053D9ED File Offset: 0x0053BBED
		public int TrackHeight { get; set; }

		// Token: 0x1700A9E0 RID: 43488
		// (get) Token: 0x060263E2 RID: 156642 RVA: 0x0053D9F6 File Offset: 0x0053BBF6
		// (set) Token: 0x060263E3 RID: 156643 RVA: 0x0053D9FE File Offset: 0x0053BBFE
		public List<int> PerformanceTags { get; set; }

		// Token: 0x1700A9E1 RID: 43489
		// (get) Token: 0x060263E4 RID: 156644 RVA: 0x0053DA07 File Offset: 0x0053BC07
		// (set) Token: 0x060263E5 RID: 156645 RVA: 0x0053DA0F File Offset: 0x0053BC0F
		public bool AoiFadeOut { get; set; }

		// Token: 0x1700A9E2 RID: 43490
		// (get) Token: 0x060263E6 RID: 156646 RVA: 0x0053DA18 File Offset: 0x0053BC18
		// (set) Token: 0x060263E7 RID: 156647 RVA: 0x0053DA20 File Offset: 0x0053BC20
		public string PerformanceFaceSkeletalMeshPath { get; set; }

		// Token: 0x1700A9E3 RID: 43491
		// (get) Token: 0x060263E8 RID: 156648 RVA: 0x0053DA29 File Offset: 0x0053BC29
		// (set) Token: 0x060263E9 RID: 156649 RVA: 0x0053DA31 File Offset: 0x0053BC31
		public bool IsUseSeqFace { get; set; }

		// Token: 0x1700A9E4 RID: 43492
		// (get) Token: 0x060263EA RID: 156650 RVA: 0x0053DA3A File Offset: 0x0053BC3A
		// (set) Token: 0x060263EB RID: 156651 RVA: 0x0053DA42 File Offset: 0x0053BC42
		public EAbpAnimScheme AbpAnimScheme { get; set; }

		// Token: 0x1700A9E5 RID: 43493
		// (get) Token: 0x060263EC RID: 156652 RVA: 0x0053DA4B File Offset: 0x0053BC4B
		// (set) Token: 0x060263ED RID: 156653 RVA: 0x0053DA53 File Offset: 0x0053BC53
		public ICollisionChannelConfigT CollisionChannelConfig { get; set; }

		// Token: 0x1700A9E6 RID: 43494
		// (get) Token: 0x060263EE RID: 156654 RVA: 0x0053DA5C File Offset: 0x0053BC5C
		// (set) Token: 0x060263EF RID: 156655 RVA: 0x0053DA64 File Offset: 0x0053BC64
		public List<string> DefaultDecorationIds { get; set; }

		// Token: 0x1700A9E7 RID: 43495
		// (get) Token: 0x060263F0 RID: 156656 RVA: 0x0053DA6D File Offset: 0x0053BC6D
		// (set) Token: 0x060263F1 RID: 156657 RVA: 0x0053DA75 File Offset: 0x0053BC75
		public byte NullMask { get; set; }

		// Token: 0x060263F2 RID: 156658 RVA: 0x0053DA80 File Offset: 0x0053BC80
		public IModelComponentT()
		{
			this.Disabled = false;
			this.ModelType = null;
			this.HalfHeight = 0;
			this.TrackHeight = 0;
			this.PerformanceTags = null;
			this.AoiFadeOut = false;
			this.PerformanceFaceSkeletalMeshPath = null;
			this.IsUseSeqFace = false;
			this.AbpAnimScheme = EAbpAnimScheme.Default;
			this.CollisionChannelConfig = null;
			this.DefaultDecorationIds = null;
			this.NullMask = 0;
		}
	}
}
