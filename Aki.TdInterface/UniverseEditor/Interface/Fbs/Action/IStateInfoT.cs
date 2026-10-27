using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071BE RID: 29118
	public class IStateInfoT
	{
		// Token: 0x1700D850 RID: 55376
		// (get) Token: 0x06033A68 RID: 211560 RVA: 0x006F4D62 File Offset: 0x006F2F62
		// (set) Token: 0x06033A69 RID: 211561 RVA: 0x006F4D6A File Offset: 0x006F2F6A
		public string ObjType { get; set; }

		// Token: 0x1700D851 RID: 55377
		// (get) Token: 0x06033A6A RID: 211562 RVA: 0x006F4D73 File Offset: 0x006F2F73
		// (set) Token: 0x06033A6B RID: 211563 RVA: 0x006F4D7B File Offset: 0x006F2F7B
		public List<string> Children { get; set; }

		// Token: 0x1700D852 RID: 55378
		// (get) Token: 0x06033A6C RID: 211564 RVA: 0x006F4D84 File Offset: 0x006F2F84
		// (set) Token: 0x06033A6D RID: 211565 RVA: 0x006F4D8C File Offset: 0x006F2F8C
		public List<string> Reference { get; set; }

		// Token: 0x1700D853 RID: 55379
		// (get) Token: 0x06033A6E RID: 211566 RVA: 0x006F4D95 File Offset: 0x006F2F95
		// (set) Token: 0x06033A6F RID: 211567 RVA: 0x006F4D9D File Offset: 0x006F2F9D
		public List<string> WeakReference { get; set; }

		// Token: 0x1700D854 RID: 55380
		// (get) Token: 0x06033A70 RID: 211568 RVA: 0x006F4DA6 File Offset: 0x006F2FA6
		// (set) Token: 0x06033A71 RID: 211569 RVA: 0x006F4DAE File Offset: 0x006F2FAE
		public int Id { get; set; }

		// Token: 0x1700D855 RID: 55381
		// (get) Token: 0x06033A72 RID: 211570 RVA: 0x006F4DB7 File Offset: 0x006F2FB7
		// (set) Token: 0x06033A73 RID: 211571 RVA: 0x006F4DBF File Offset: 0x006F2FBF
		public string Name { get; set; }

		// Token: 0x1700D856 RID: 55382
		// (get) Token: 0x06033A74 RID: 211572 RVA: 0x006F4DC8 File Offset: 0x006F2FC8
		// (set) Token: 0x06033A75 RID: 211573 RVA: 0x006F4DD0 File Offset: 0x006F2FD0
		public bool _Folded { get; set; }

		// Token: 0x1700D857 RID: 55383
		// (get) Token: 0x06033A76 RID: 211574 RVA: 0x006F4DD9 File Offset: 0x006F2FD9
		// (set) Token: 0x06033A77 RID: 211575 RVA: 0x006F4DE1 File Offset: 0x006F2FE1
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700D858 RID: 55384
		// (get) Token: 0x06033A78 RID: 211576 RVA: 0x006F4DEA File Offset: 0x006F2FEA
		// (set) Token: 0x06033A79 RID: 211577 RVA: 0x006F4DF2 File Offset: 0x006F2FF2
		public bool KeepBgm { get; set; }

		// Token: 0x1700D859 RID: 55385
		// (get) Token: 0x06033A7A RID: 211578 RVA: 0x006F4DFB File Offset: 0x006F2FFB
		// (set) Token: 0x06033A7B RID: 211579 RVA: 0x006F4E03 File Offset: 0x006F3003
		public bool OnlyPlayOnce { get; set; }

		// Token: 0x1700D85A RID: 55386
		// (get) Token: 0x06033A7C RID: 211580 RVA: 0x006F4E0C File Offset: 0x006F300C
		// (set) Token: 0x06033A7D RID: 211581 RVA: 0x006F4E14 File Offset: 0x006F3014
		public bool KeepInVehicle { get; set; }

		// Token: 0x1700D85B RID: 55387
		// (get) Token: 0x06033A7E RID: 211582 RVA: 0x006F4E1D File Offset: 0x006F301D
		// (set) Token: 0x06033A7F RID: 211583 RVA: 0x006F4E25 File Offset: 0x006F3025
		public bool AllowMultiReference { get; set; }

		// Token: 0x1700D85C RID: 55388
		// (get) Token: 0x06033A80 RID: 211584 RVA: 0x006F4E2E File Offset: 0x006F302E
		// (set) Token: 0x06033A81 RID: 211585 RVA: 0x006F4E36 File Offset: 0x006F3036
		public bool IgnoreInPlotHandBook { get; set; }

		// Token: 0x1700D85D RID: 55389
		// (get) Token: 0x06033A82 RID: 211586 RVA: 0x006F4E3F File Offset: 0x006F303F
		// (set) Token: 0x06033A83 RID: 211587 RVA: 0x006F4E47 File Offset: 0x006F3047
		public bool DontInterruptMatch { get; set; }

		// Token: 0x1700D85E RID: 55390
		// (get) Token: 0x06033A84 RID: 211588 RVA: 0x006F4E50 File Offset: 0x006F3050
		// (set) Token: 0x06033A85 RID: 211589 RVA: 0x006F4E58 File Offset: 0x006F3058
		public bool IsPreloadFlow { get; set; }

		// Token: 0x1700D85F RID: 55391
		// (get) Token: 0x06033A86 RID: 211590 RVA: 0x006F4E61 File Offset: 0x006F3061
		// (set) Token: 0x06033A87 RID: 211591 RVA: 0x006F4E69 File Offset: 0x006F3069
		public bool IsClientFlow { get; set; }

		// Token: 0x1700D860 RID: 55392
		// (get) Token: 0x06033A88 RID: 211592 RVA: 0x006F4E72 File Offset: 0x006F3072
		// (set) Token: 0x06033A89 RID: 211593 RVA: 0x006F4E7A File Offset: 0x006F307A
		public bool _ShowImport { get; set; }

		// Token: 0x1700D861 RID: 55393
		// (get) Token: 0x06033A8A RID: 211594 RVA: 0x006F4E83 File Offset: 0x006F3083
		// (set) Token: 0x06033A8B RID: 211595 RVA: 0x006F4E8B File Offset: 0x006F308B
		public IPosAT PlotPos { get; set; }

		// Token: 0x1700D862 RID: 55394
		// (get) Token: 0x06033A8C RID: 211596 RVA: 0x006F4E94 File Offset: 0x006F3094
		// (set) Token: 0x06033A8D RID: 211597 RVA: 0x006F4E9C File Offset: 0x006F309C
		public IStateProgramSpecialProcessChangeTeamOptimizationT ProgramSpecialProcess { get; set; }

		// Token: 0x1700D863 RID: 55395
		// (get) Token: 0x06033A8E RID: 211598 RVA: 0x006F4EA5 File Offset: 0x006F30A5
		// (set) Token: 0x06033A8F RID: 211599 RVA: 0x006F4EAD File Offset: 0x006F30AD
		public List<int> _SelectedIndexes { get; set; }

		// Token: 0x1700D864 RID: 55396
		// (get) Token: 0x06033A90 RID: 211600 RVA: 0x006F4EB6 File Offset: 0x006F30B6
		// (set) Token: 0x06033A91 RID: 211601 RVA: 0x006F4EBE File Offset: 0x006F30BE
		public ushort NullMask { get; set; }

		// Token: 0x06033A92 RID: 211602 RVA: 0x006F4EC8 File Offset: 0x006F30C8
		public IStateInfoT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Id = 0;
			this.Name = null;
			this._Folded = false;
			this.Actions = null;
			this.KeepBgm = false;
			this.OnlyPlayOnce = false;
			this.KeepInVehicle = false;
			this.AllowMultiReference = false;
			this.IgnoreInPlotHandBook = false;
			this.DontInterruptMatch = false;
			this.IsPreloadFlow = false;
			this.IsClientFlow = false;
			this._ShowImport = false;
			this.PlotPos = null;
			this.ProgramSpecialProcess = null;
			this._SelectedIndexes = null;
			this.NullMask = 0;
		}
	}
}
