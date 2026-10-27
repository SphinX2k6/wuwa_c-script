using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005E9D RID: 24221
	public class ICommonBtT
	{
		// Token: 0x1700B4F4 RID: 46324
		// (get) Token: 0x060297CE RID: 169934 RVA: 0x005AF6D4 File Offset: 0x005AD8D4
		// (set) Token: 0x060297CF RID: 169935 RVA: 0x005AF6DC File Offset: 0x005AD8DC
		public string ObjType { get; set; }

		// Token: 0x1700B4F5 RID: 46325
		// (get) Token: 0x060297D0 RID: 169936 RVA: 0x005AF6E5 File Offset: 0x005AD8E5
		// (set) Token: 0x060297D1 RID: 169937 RVA: 0x005AF6ED File Offset: 0x005AD8ED
		public List<string> Children { get; set; }

		// Token: 0x1700B4F6 RID: 46326
		// (get) Token: 0x060297D2 RID: 169938 RVA: 0x005AF6F6 File Offset: 0x005AD8F6
		// (set) Token: 0x060297D3 RID: 169939 RVA: 0x005AF6FE File Offset: 0x005AD8FE
		public List<string> Reference { get; set; }

		// Token: 0x1700B4F7 RID: 46327
		// (get) Token: 0x060297D4 RID: 169940 RVA: 0x005AF707 File Offset: 0x005AD907
		// (set) Token: 0x060297D5 RID: 169941 RVA: 0x005AF70F File Offset: 0x005AD90F
		public List<string> WeakReference { get; set; }

		// Token: 0x1700B4F8 RID: 46328
		// (get) Token: 0x060297D6 RID: 169942 RVA: 0x005AF718 File Offset: 0x005AD918
		// (set) Token: 0x060297D7 RID: 169943 RVA: 0x005AF720 File Offset: 0x005AD920
		public int Id { get; set; }

		// Token: 0x1700B4F9 RID: 46329
		// (get) Token: 0x060297D8 RID: 169944 RVA: 0x005AF729 File Offset: 0x005AD929
		// (set) Token: 0x060297D9 RID: 169945 RVA: 0x005AF731 File Offset: 0x005AD931
		public string Name { get; set; }

		// Token: 0x1700B4FA RID: 46330
		// (get) Token: 0x060297DA RID: 169946 RVA: 0x005AF73A File Offset: 0x005AD93A
		// (set) Token: 0x060297DB RID: 169947 RVA: 0x005AF742 File Offset: 0x005AD942
		public int LevelId { get; set; }

		// Token: 0x1700B4FB RID: 46331
		// (get) Token: 0x060297DC RID: 169948 RVA: 0x005AF74B File Offset: 0x005AD94B
		// (set) Token: 0x060297DD RID: 169949 RVA: 0x005AF753 File Offset: 0x005AD953
		public string AssetPath { get; set; }

		// Token: 0x1700B4FC RID: 46332
		// (get) Token: 0x060297DE RID: 169950 RVA: 0x005AF75C File Offset: 0x005AD95C
		// (set) Token: 0x060297DF RID: 169951 RVA: 0x005AF764 File Offset: 0x005AD964
		public ICommonBtTreeT Tree { get; set; }

		// Token: 0x1700B4FD RID: 46333
		// (get) Token: 0x060297E0 RID: 169952 RVA: 0x005AF76D File Offset: 0x005AD96D
		// (set) Token: 0x060297E1 RID: 169953 RVA: 0x005AF775 File Offset: 0x005AD975
		public List<ICommonBtPlaceholderT> Placeholders { get; set; }

		// Token: 0x1700B4FE RID: 46334
		// (get) Token: 0x060297E2 RID: 169954 RVA: 0x005AF77E File Offset: 0x005AD97E
		// (set) Token: 0x060297E3 RID: 169955 RVA: 0x005AF786 File Offset: 0x005AD986
		public bool _IsSelectBt { get; set; }

		// Token: 0x1700B4FF RID: 46335
		// (get) Token: 0x060297E4 RID: 169956 RVA: 0x005AF78F File Offset: 0x005AD98F
		// (set) Token: 0x060297E5 RID: 169957 RVA: 0x005AF797 File Offset: 0x005AD997
		public bool _IsShowTaskId { get; set; }

		// Token: 0x1700B500 RID: 46336
		// (get) Token: 0x060297E6 RID: 169958 RVA: 0x005AF7A0 File Offset: 0x005AD9A0
		// (set) Token: 0x060297E7 RID: 169959 RVA: 0x005AF7A8 File Offset: 0x005AD9A8
		public List<string> _HighlightDataPaths { get; set; }

		// Token: 0x1700B501 RID: 46337
		// (get) Token: 0x060297E8 RID: 169960 RVA: 0x005AF7B1 File Offset: 0x005AD9B1
		// (set) Token: 0x060297E9 RID: 169961 RVA: 0x005AF7B9 File Offset: 0x005AD9B9
		public string _FocusDataPath { get; set; }

		// Token: 0x1700B502 RID: 46338
		// (get) Token: 0x060297EA RID: 169962 RVA: 0x005AF7C2 File Offset: 0x005AD9C2
		// (set) Token: 0x060297EB RID: 169963 RVA: 0x005AF7CA File Offset: 0x005AD9CA
		public string _FocusPlaceholderName { get; set; }

		// Token: 0x1700B503 RID: 46339
		// (get) Token: 0x060297EC RID: 169964 RVA: 0x005AF7D3 File Offset: 0x005AD9D3
		// (set) Token: 0x060297ED RID: 169965 RVA: 0x005AF7DB File Offset: 0x005AD9DB
		public byte NullMask { get; set; }

		// Token: 0x060297EE RID: 169966 RVA: 0x005AF7E4 File Offset: 0x005AD9E4
		public ICommonBtT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Id = 0;
			this.Name = null;
			this.LevelId = 0;
			this.AssetPath = null;
			this.Tree = null;
			this.Placeholders = null;
			this._IsSelectBt = false;
			this._IsShowTaskId = false;
			this._HighlightDataPaths = null;
			this._FocusDataPath = null;
			this._FocusPlaceholderName = null;
			this.NullMask = 0;
		}
	}
}
