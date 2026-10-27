using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006817 RID: 26647
	public class IFlowInfoT
	{
		// Token: 0x1700C5D1 RID: 50641
		// (get) Token: 0x0602E6C8 RID: 190152 RVA: 0x00656038 File Offset: 0x00654238
		// (set) Token: 0x0602E6C9 RID: 190153 RVA: 0x00656040 File Offset: 0x00654240
		public string ObjType { get; set; }

		// Token: 0x1700C5D2 RID: 50642
		// (get) Token: 0x0602E6CA RID: 190154 RVA: 0x00656049 File Offset: 0x00654249
		// (set) Token: 0x0602E6CB RID: 190155 RVA: 0x00656051 File Offset: 0x00654251
		public List<string> Children { get; set; }

		// Token: 0x1700C5D3 RID: 50643
		// (get) Token: 0x0602E6CC RID: 190156 RVA: 0x0065605A File Offset: 0x0065425A
		// (set) Token: 0x0602E6CD RID: 190157 RVA: 0x00656062 File Offset: 0x00654262
		public List<string> Reference { get; set; }

		// Token: 0x1700C5D4 RID: 50644
		// (get) Token: 0x0602E6CE RID: 190158 RVA: 0x0065606B File Offset: 0x0065426B
		// (set) Token: 0x0602E6CF RID: 190159 RVA: 0x00656073 File Offset: 0x00654273
		public List<string> WeakReference { get; set; }

		// Token: 0x1700C5D5 RID: 50645
		// (get) Token: 0x0602E6D0 RID: 190160 RVA: 0x0065607C File Offset: 0x0065427C
		// (set) Token: 0x0602E6D1 RID: 190161 RVA: 0x00656084 File Offset: 0x00654284
		public int Id { get; set; }

		// Token: 0x1700C5D6 RID: 50646
		// (get) Token: 0x0602E6D2 RID: 190162 RVA: 0x0065608D File Offset: 0x0065428D
		// (set) Token: 0x0602E6D3 RID: 190163 RVA: 0x00656095 File Offset: 0x00654295
		public string Name { get; set; }

		// Token: 0x1700C5D7 RID: 50647
		// (get) Token: 0x0602E6D4 RID: 190164 RVA: 0x0065609E File Offset: 0x0065429E
		// (set) Token: 0x0602E6D5 RID: 190165 RVA: 0x006560A6 File Offset: 0x006542A6
		public int DungeonId { get; set; }

		// Token: 0x1700C5D8 RID: 50648
		// (get) Token: 0x0602E6D6 RID: 190166 RVA: 0x006560AF File Offset: 0x006542AF
		// (set) Token: 0x0602E6D7 RID: 190167 RVA: 0x006560B7 File Offset: 0x006542B7
		public bool _Folded { get; set; }

		// Token: 0x1700C5D9 RID: 50649
		// (get) Token: 0x0602E6D8 RID: 190168 RVA: 0x006560C0 File Offset: 0x006542C0
		// (set) Token: 0x0602E6D9 RID: 190169 RVA: 0x006560C8 File Offset: 0x006542C8
		public int _SelectedStateId { get; set; }

		// Token: 0x1700C5DA RID: 50650
		// (get) Token: 0x0602E6DA RID: 190170 RVA: 0x006560D1 File Offset: 0x006542D1
		// (set) Token: 0x0602E6DB RID: 190171 RVA: 0x006560D9 File Offset: 0x006542D9
		public TVarContextUnion VarContext { get; set; }

		// Token: 0x1700C5DB RID: 50651
		// (get) Token: 0x0602E6DC RID: 190172 RVA: 0x006560E2 File Offset: 0x006542E2
		// (set) Token: 0x0602E6DD RID: 190173 RVA: 0x006560EA File Offset: 0x006542EA
		public List<IStateInfoT> States { get; set; }

		// Token: 0x1700C5DC RID: 50652
		// (get) Token: 0x0602E6DE RID: 190174 RVA: 0x006560F3 File Offset: 0x006542F3
		// (set) Token: 0x0602E6DF RID: 190175 RVA: 0x006560FB File Offset: 0x006542FB
		public byte NullMask { get; set; }

		// Token: 0x0602E6E0 RID: 190176 RVA: 0x00656104 File Offset: 0x00654304
		public IFlowInfoT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Id = 0;
			this.Name = null;
			this.DungeonId = 0;
			this._Folded = false;
			this._SelectedStateId = 0;
			this.VarContext = null;
			this.States = null;
			this.NullMask = 0;
		}
	}
}
