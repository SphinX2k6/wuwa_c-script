using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004824 RID: 18468
	public class IBehaviorTreeFragmentT
	{
		// Token: 0x17008486 RID: 33926
		// (get) Token: 0x0601C8A3 RID: 116899 RVA: 0x00409712 File Offset: 0x00407912
		// (set) Token: 0x0601C8A4 RID: 116900 RVA: 0x0040971A File Offset: 0x0040791A
		public string ObjType { get; set; }

		// Token: 0x17008487 RID: 33927
		// (get) Token: 0x0601C8A5 RID: 116901 RVA: 0x00409723 File Offset: 0x00407923
		// (set) Token: 0x0601C8A6 RID: 116902 RVA: 0x0040972B File Offset: 0x0040792B
		public List<string> Children { get; set; }

		// Token: 0x17008488 RID: 33928
		// (get) Token: 0x0601C8A7 RID: 116903 RVA: 0x00409734 File Offset: 0x00407934
		// (set) Token: 0x0601C8A8 RID: 116904 RVA: 0x0040973C File Offset: 0x0040793C
		public List<string> Reference { get; set; }

		// Token: 0x17008489 RID: 33929
		// (get) Token: 0x0601C8A9 RID: 116905 RVA: 0x00409745 File Offset: 0x00407945
		// (set) Token: 0x0601C8AA RID: 116906 RVA: 0x0040974D File Offset: 0x0040794D
		public List<string> WeakReference { get; set; }

		// Token: 0x1700848A RID: 33930
		// (get) Token: 0x0601C8AB RID: 116907 RVA: 0x00409756 File Offset: 0x00407956
		// (set) Token: 0x0601C8AC RID: 116908 RVA: 0x0040975E File Offset: 0x0040795E
		public EFragmentType Type { get; set; }

		// Token: 0x1700848B RID: 33931
		// (get) Token: 0x0601C8AD RID: 116909 RVA: 0x00409767 File Offset: 0x00407967
		// (set) Token: 0x0601C8AE RID: 116910 RVA: 0x0040976F File Offset: 0x0040796F
		public int Id { get; set; }

		// Token: 0x1700848C RID: 33932
		// (get) Token: 0x0601C8AF RID: 116911 RVA: 0x00409778 File Offset: 0x00407978
		// (set) Token: 0x0601C8B0 RID: 116912 RVA: 0x00409780 File Offset: 0x00407980
		public string Description { get; set; }

		// Token: 0x1700848D RID: 33933
		// (get) Token: 0x0601C8B1 RID: 116913 RVA: 0x00409789 File Offset: 0x00407989
		// (set) Token: 0x0601C8B2 RID: 116914 RVA: 0x00409791 File Offset: 0x00407991
		public int DungeonId { get; set; }

		// Token: 0x1700848E RID: 33934
		// (get) Token: 0x0601C8B3 RID: 116915 RVA: 0x0040979A File Offset: 0x0040799A
		// (set) Token: 0x0601C8B4 RID: 116916 RVA: 0x004097A2 File Offset: 0x004079A2
		public bool AutoUnbind { get; set; }

		// Token: 0x1700848F RID: 33935
		// (get) Token: 0x0601C8B5 RID: 116917 RVA: 0x004097AB File Offset: 0x004079AB
		// (set) Token: 0x0601C8B6 RID: 116918 RVA: 0x004097B3 File Offset: 0x004079B3
		public IBehaviorTreeT Tree { get; set; }

		// Token: 0x17008490 RID: 33936
		// (get) Token: 0x0601C8B7 RID: 116919 RVA: 0x004097BC File Offset: 0x004079BC
		// (set) Token: 0x0601C8B8 RID: 116920 RVA: 0x004097C4 File Offset: 0x004079C4
		public bool _IsSelectBt { get; set; }

		// Token: 0x17008491 RID: 33937
		// (get) Token: 0x0601C8B9 RID: 116921 RVA: 0x004097CD File Offset: 0x004079CD
		// (set) Token: 0x0601C8BA RID: 116922 RVA: 0x004097D5 File Offset: 0x004079D5
		public List<string> _HighlightDataPaths { get; set; }

		// Token: 0x17008492 RID: 33938
		// (get) Token: 0x0601C8BB RID: 116923 RVA: 0x004097DE File Offset: 0x004079DE
		// (set) Token: 0x0601C8BC RID: 116924 RVA: 0x004097E6 File Offset: 0x004079E6
		public string _FocusDataPath { get; set; }

		// Token: 0x17008493 RID: 33939
		// (get) Token: 0x0601C8BD RID: 116925 RVA: 0x004097EF File Offset: 0x004079EF
		// (set) Token: 0x0601C8BE RID: 116926 RVA: 0x004097F7 File Offset: 0x004079F7
		public List<IPlaceholderT> _RemovedPlaceholders { get; set; }

		// Token: 0x17008494 RID: 33940
		// (get) Token: 0x0601C8BF RID: 116927 RVA: 0x00409800 File Offset: 0x00407A00
		// (set) Token: 0x0601C8C0 RID: 116928 RVA: 0x00409808 File Offset: 0x00407A08
		public byte NullMask { get; set; }

		// Token: 0x0601C8C1 RID: 116929 RVA: 0x00409814 File Offset: 0x00407A14
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
