using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B2D RID: 15149
	public class IWoodenBoxProliferateParamsT
	{
		// Token: 0x170067F2 RID: 26610
		// (get) Token: 0x06014B2D RID: 84781 RVA: 0x00302C7A File Offset: 0x00300E7A
		// (set) Token: 0x06014B2E RID: 84782 RVA: 0x00302C82 File Offset: 0x00300E82
		public EParamsPreset Type { get; set; }

		// Token: 0x170067F3 RID: 26611
		// (get) Token: 0x06014B2F RID: 84783 RVA: 0x00302C8B File Offset: 0x00300E8B
		// (set) Token: 0x06014B30 RID: 84784 RVA: 0x00302C93 File Offset: 0x00300E93
		public TWoodenBoxProliferateSpawnConfigUnion SpawnConfig { get; set; }

		// Token: 0x170067F4 RID: 26612
		// (get) Token: 0x06014B31 RID: 84785 RVA: 0x00302C9C File Offset: 0x00300E9C
		// (set) Token: 0x06014B32 RID: 84786 RVA: 0x00302CA4 File Offset: 0x00300EA4
		public EWoodenBoxProliferateVisualType ProliferateVisualType { get; set; }

		// Token: 0x170067F5 RID: 26613
		// (get) Token: 0x06014B33 RID: 84787 RVA: 0x00302CAD File Offset: 0x00300EAD
		// (set) Token: 0x06014B34 RID: 84788 RVA: 0x00302CB5 File Offset: 0x00300EB5
		public string ProliferateReadyState { get; set; }

		// Token: 0x170067F6 RID: 26614
		// (get) Token: 0x06014B35 RID: 84789 RVA: 0x00302CBE File Offset: 0x00300EBE
		// (set) Token: 0x06014B36 RID: 84790 RVA: 0x00302CC6 File Offset: 0x00300EC6
		public string ProliferatedState { get; set; }

		// Token: 0x170067F7 RID: 26615
		// (get) Token: 0x06014B37 RID: 84791 RVA: 0x00302CCF File Offset: 0x00300ECF
		// (set) Token: 0x06014B38 RID: 84792 RVA: 0x00302CD7 File Offset: 0x00300ED7
		public float ProliferateDuration { get; set; }

		// Token: 0x170067F8 RID: 26616
		// (get) Token: 0x06014B39 RID: 84793 RVA: 0x00302CE0 File Offset: 0x00300EE0
		// (set) Token: 0x06014B3A RID: 84794 RVA: 0x00302CE8 File Offset: 0x00300EE8
		public byte NullMask { get; set; }

		// Token: 0x06014B3B RID: 84795 RVA: 0x00302CF1 File Offset: 0x00300EF1
		public IWoodenBoxProliferateParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.SpawnConfig = null;
			this.ProliferateVisualType = EWoodenBoxProliferateVisualType.SlenderJadeBamboo;
			this.ProliferateReadyState = null;
			this.ProliferatedState = null;
			this.ProliferateDuration = 0f;
			this.NullMask = 0;
		}
	}
}
