using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200555B RID: 21851
	public class IModelComponentT
	{
		// Token: 0x1700A167 RID: 41319
		// (get) Token: 0x06024237 RID: 148023 RVA: 0x004FE119 File Offset: 0x004FC319
		// (set) Token: 0x06024238 RID: 148024 RVA: 0x004FE121 File Offset: 0x004FC321
		public bool Disabled { get; set; }

		// Token: 0x1700A168 RID: 41320
		// (get) Token: 0x06024239 RID: 148025 RVA: 0x004FE12A File Offset: 0x004FC32A
		// (set) Token: 0x0602423A RID: 148026 RVA: 0x004FE132 File Offset: 0x004FC332
		public TModelTypeUnion ModelType { get; set; }

		// Token: 0x1700A169 RID: 41321
		// (get) Token: 0x0602423B RID: 148027 RVA: 0x004FE13B File Offset: 0x004FC33B
		// (set) Token: 0x0602423C RID: 148028 RVA: 0x004FE143 File Offset: 0x004FC343
		public int HalfHeight { get; set; }

		// Token: 0x1700A16A RID: 41322
		// (get) Token: 0x0602423D RID: 148029 RVA: 0x004FE14C File Offset: 0x004FC34C
		// (set) Token: 0x0602423E RID: 148030 RVA: 0x004FE154 File Offset: 0x004FC354
		public int TrackHeight { get; set; }

		// Token: 0x1700A16B RID: 41323
		// (get) Token: 0x0602423F RID: 148031 RVA: 0x004FE15D File Offset: 0x004FC35D
		// (set) Token: 0x06024240 RID: 148032 RVA: 0x004FE165 File Offset: 0x004FC365
		public List<int> PerformanceTags { get; set; }

		// Token: 0x1700A16C RID: 41324
		// (get) Token: 0x06024241 RID: 148033 RVA: 0x004FE16E File Offset: 0x004FC36E
		// (set) Token: 0x06024242 RID: 148034 RVA: 0x004FE176 File Offset: 0x004FC376
		public bool AoiFadeOut { get; set; }

		// Token: 0x1700A16D RID: 41325
		// (get) Token: 0x06024243 RID: 148035 RVA: 0x004FE17F File Offset: 0x004FC37F
		// (set) Token: 0x06024244 RID: 148036 RVA: 0x004FE187 File Offset: 0x004FC387
		public string PerformanceFaceSkeletalMeshPath { get; set; }

		// Token: 0x1700A16E RID: 41326
		// (get) Token: 0x06024245 RID: 148037 RVA: 0x004FE190 File Offset: 0x004FC390
		// (set) Token: 0x06024246 RID: 148038 RVA: 0x004FE198 File Offset: 0x004FC398
		public bool IsUseSeqFace { get; set; }

		// Token: 0x1700A16F RID: 41327
		// (get) Token: 0x06024247 RID: 148039 RVA: 0x004FE1A1 File Offset: 0x004FC3A1
		// (set) Token: 0x06024248 RID: 148040 RVA: 0x004FE1A9 File Offset: 0x004FC3A9
		public EAbpAnimScheme AbpAnimScheme { get; set; }

		// Token: 0x1700A170 RID: 41328
		// (get) Token: 0x06024249 RID: 148041 RVA: 0x004FE1B2 File Offset: 0x004FC3B2
		// (set) Token: 0x0602424A RID: 148042 RVA: 0x004FE1BA File Offset: 0x004FC3BA
		public ICollisionChannelConfigT CollisionChannelConfig { get; set; }

		// Token: 0x1700A171 RID: 41329
		// (get) Token: 0x0602424B RID: 148043 RVA: 0x004FE1C3 File Offset: 0x004FC3C3
		// (set) Token: 0x0602424C RID: 148044 RVA: 0x004FE1CB File Offset: 0x004FC3CB
		public byte NullMask { get; set; }

		// Token: 0x0602424D RID: 148045 RVA: 0x004FE1D4 File Offset: 0x004FC3D4
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
			this.AbpAnimScheme = EAbpAnimScheme.Scheme1;
			this.CollisionChannelConfig = null;
			this.NullMask = 0;
		}
	}
}
