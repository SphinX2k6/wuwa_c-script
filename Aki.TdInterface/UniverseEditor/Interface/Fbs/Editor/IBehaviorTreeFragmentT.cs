using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C8C RID: 19596
	public class IBehaviorTreeFragmentT
	{
		// Token: 0x17008AD1 RID: 35537
		// (get) Token: 0x0601E0A0 RID: 123040 RVA: 0x00436062 File Offset: 0x00434262
		// (set) Token: 0x0601E0A1 RID: 123041 RVA: 0x0043606A File Offset: 0x0043426A
		public string ObjType { get; set; }

		// Token: 0x17008AD2 RID: 35538
		// (get) Token: 0x0601E0A2 RID: 123042 RVA: 0x00436073 File Offset: 0x00434273
		// (set) Token: 0x0601E0A3 RID: 123043 RVA: 0x0043607B File Offset: 0x0043427B
		public List<string> Children { get; set; }

		// Token: 0x17008AD3 RID: 35539
		// (get) Token: 0x0601E0A4 RID: 123044 RVA: 0x00436084 File Offset: 0x00434284
		// (set) Token: 0x0601E0A5 RID: 123045 RVA: 0x0043608C File Offset: 0x0043428C
		public List<string> Reference { get; set; }

		// Token: 0x17008AD4 RID: 35540
		// (get) Token: 0x0601E0A6 RID: 123046 RVA: 0x00436095 File Offset: 0x00434295
		// (set) Token: 0x0601E0A7 RID: 123047 RVA: 0x0043609D File Offset: 0x0043429D
		public List<string> WeakReference { get; set; }

		// Token: 0x17008AD5 RID: 35541
		// (get) Token: 0x0601E0A8 RID: 123048 RVA: 0x004360A6 File Offset: 0x004342A6
		// (set) Token: 0x0601E0A9 RID: 123049 RVA: 0x004360AE File Offset: 0x004342AE
		public EFragmentType Type { get; set; }

		// Token: 0x17008AD6 RID: 35542
		// (get) Token: 0x0601E0AA RID: 123050 RVA: 0x004360B7 File Offset: 0x004342B7
		// (set) Token: 0x0601E0AB RID: 123051 RVA: 0x004360BF File Offset: 0x004342BF
		public int Id { get; set; }

		// Token: 0x17008AD7 RID: 35543
		// (get) Token: 0x0601E0AC RID: 123052 RVA: 0x004360C8 File Offset: 0x004342C8
		// (set) Token: 0x0601E0AD RID: 123053 RVA: 0x004360D0 File Offset: 0x004342D0
		public string Description { get; set; }

		// Token: 0x17008AD8 RID: 35544
		// (get) Token: 0x0601E0AE RID: 123054 RVA: 0x004360D9 File Offset: 0x004342D9
		// (set) Token: 0x0601E0AF RID: 123055 RVA: 0x004360E1 File Offset: 0x004342E1
		public int DungeonId { get; set; }

		// Token: 0x17008AD9 RID: 35545
		// (get) Token: 0x0601E0B0 RID: 123056 RVA: 0x004360EA File Offset: 0x004342EA
		// (set) Token: 0x0601E0B1 RID: 123057 RVA: 0x004360F2 File Offset: 0x004342F2
		public bool AutoUnbind { get; set; }

		// Token: 0x17008ADA RID: 35546
		// (get) Token: 0x0601E0B2 RID: 123058 RVA: 0x004360FB File Offset: 0x004342FB
		// (set) Token: 0x0601E0B3 RID: 123059 RVA: 0x00436103 File Offset: 0x00434303
		public IBehaviorTreeT Tree { get; set; }

		// Token: 0x17008ADB RID: 35547
		// (get) Token: 0x0601E0B4 RID: 123060 RVA: 0x0043610C File Offset: 0x0043430C
		// (set) Token: 0x0601E0B5 RID: 123061 RVA: 0x00436114 File Offset: 0x00434314
		public bool _IsSelectBt { get; set; }

		// Token: 0x17008ADC RID: 35548
		// (get) Token: 0x0601E0B6 RID: 123062 RVA: 0x0043611D File Offset: 0x0043431D
		// (set) Token: 0x0601E0B7 RID: 123063 RVA: 0x00436125 File Offset: 0x00434325
		public List<string> _HighlightDataPaths { get; set; }

		// Token: 0x17008ADD RID: 35549
		// (get) Token: 0x0601E0B8 RID: 123064 RVA: 0x0043612E File Offset: 0x0043432E
		// (set) Token: 0x0601E0B9 RID: 123065 RVA: 0x00436136 File Offset: 0x00434336
		public string _FocusDataPath { get; set; }

		// Token: 0x17008ADE RID: 35550
		// (get) Token: 0x0601E0BA RID: 123066 RVA: 0x0043613F File Offset: 0x0043433F
		// (set) Token: 0x0601E0BB RID: 123067 RVA: 0x00436147 File Offset: 0x00434347
		public List<IPlaceholderT> _RemovedPlaceholders { get; set; }

		// Token: 0x17008ADF RID: 35551
		// (get) Token: 0x0601E0BC RID: 123068 RVA: 0x00436150 File Offset: 0x00434350
		// (set) Token: 0x0601E0BD RID: 123069 RVA: 0x00436158 File Offset: 0x00434358
		public byte NullMask { get; set; }

		// Token: 0x0601E0BE RID: 123070 RVA: 0x00436164 File Offset: 0x00434364
		public IBehaviorTreeFragmentT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Type = EFragmentType.LevelPlay;
			this.Id = 0;
			this.Description = null;
			this.DungeonId = 0;
			this.AutoUnbind = false;
			this.Tree = null;
			this._IsSelectBt = false;
			this._HighlightDataPaths = null;
			this._FocusDataPath = null;
			this._RemovedPlaceholders = null;
			this.NullMask = 0;
		}
	}
}
