using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046E9 RID: 18153
	public class IEntityClientRunningDataT
	{
		// Token: 0x170081A4 RID: 33188
		// (get) Token: 0x0601BC1D RID: 113693 RVA: 0x003EF578 File Offset: 0x003ED778
		// (set) Token: 0x0601BC1E RID: 113694 RVA: 0x003EF580 File Offset: 0x003ED780
		public int ConfigId { get; set; }

		// Token: 0x170081A5 RID: 33189
		// (get) Token: 0x0601BC1F RID: 113695 RVA: 0x003EF589 File Offset: 0x003ED789
		// (set) Token: 0x0601BC20 RID: 113696 RVA: 0x003EF591 File Offset: 0x003ED791
		public EEntityClientCreateState CreateState { get; set; }

		// Token: 0x170081A6 RID: 33190
		// (get) Token: 0x0601BC21 RID: 113697 RVA: 0x003EF59A File Offset: 0x003ED79A
		// (set) Token: 0x0601BC22 RID: 113698 RVA: 0x003EF5A2 File Offset: 0x003ED7A2
		public string Reason { get; set; }

		// Token: 0x170081A7 RID: 33191
		// (get) Token: 0x0601BC23 RID: 113699 RVA: 0x003EF5AB File Offset: 0x003ED7AB
		// (set) Token: 0x0601BC24 RID: 113700 RVA: 0x003EF5B3 File Offset: 0x003ED7B3
		public bool IsClientVisible { get; set; }

		// Token: 0x170081A8 RID: 33192
		// (get) Token: 0x0601BC25 RID: 113701 RVA: 0x003EF5BC File Offset: 0x003ED7BC
		// (set) Token: 0x0601BC26 RID: 113702 RVA: 0x003EF5C4 File Offset: 0x003ED7C4
		public bool IsInRange { get; set; }

		// Token: 0x170081A9 RID: 33193
		// (get) Token: 0x0601BC27 RID: 113703 RVA: 0x003EF5CD File Offset: 0x003ED7CD
		// (set) Token: 0x0601BC28 RID: 113704 RVA: 0x003EF5D5 File Offset: 0x003ED7D5
		public string Tags { get; set; }

		// Token: 0x170081AA RID: 33194
		// (get) Token: 0x0601BC29 RID: 113705 RVA: 0x003EF5DE File Offset: 0x003ED7DE
		// (set) Token: 0x0601BC2A RID: 113706 RVA: 0x003EF5E6 File Offset: 0x003ED7E6
		public byte NullMask { get; set; }

		// Token: 0x0601BC2B RID: 113707 RVA: 0x003EF5EF File Offset: 0x003ED7EF
		public IEntityClientRunningDataT()
		{
			this.ConfigId = 0;
			this.CreateState = EEntityClientCreateState.None;
			this.Reason = null;
			this.IsClientVisible = false;
			this.IsInRange = false;
			this.Tags = null;
			this.NullMask = 0;
		}
	}
}
