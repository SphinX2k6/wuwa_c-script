using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047CA RID: 18378
	public class IEntityPrefabT
	{
		// Token: 0x17008407 RID: 33799
		// (get) Token: 0x0601C641 RID: 116289 RVA: 0x004048D7 File Offset: 0x00402AD7
		// (set) Token: 0x0601C642 RID: 116290 RVA: 0x004048DF File Offset: 0x00402ADF
		public string ObjType { get; set; }

		// Token: 0x17008408 RID: 33800
		// (get) Token: 0x0601C643 RID: 116291 RVA: 0x004048E8 File Offset: 0x00402AE8
		// (set) Token: 0x0601C644 RID: 116292 RVA: 0x004048F0 File Offset: 0x00402AF0
		public List<string> Children { get; set; }

		// Token: 0x17008409 RID: 33801
		// (get) Token: 0x0601C645 RID: 116293 RVA: 0x004048F9 File Offset: 0x00402AF9
		// (set) Token: 0x0601C646 RID: 116294 RVA: 0x00404901 File Offset: 0x00402B01
		public List<string> Reference { get; set; }

		// Token: 0x1700840A RID: 33802
		// (get) Token: 0x0601C647 RID: 116295 RVA: 0x0040490A File Offset: 0x00402B0A
		// (set) Token: 0x0601C648 RID: 116296 RVA: 0x00404912 File Offset: 0x00402B12
		public List<string> WeakReference { get; set; }

		// Token: 0x1700840B RID: 33803
		// (get) Token: 0x0601C649 RID: 116297 RVA: 0x0040491B File Offset: 0x00402B1B
		// (set) Token: 0x0601C64A RID: 116298 RVA: 0x00404923 File Offset: 0x00402B23
		public int PrefabId { get; set; }

		// Token: 0x1700840C RID: 33804
		// (get) Token: 0x0601C64B RID: 116299 RVA: 0x0040492C File Offset: 0x00402B2C
		// (set) Token: 0x0601C64C RID: 116300 RVA: 0x00404934 File Offset: 0x00402B34
		public string Name { get; set; }

		// Token: 0x1700840D RID: 33805
		// (get) Token: 0x0601C64D RID: 116301 RVA: 0x0040493D File Offset: 0x00402B3D
		// (set) Token: 0x0601C64E RID: 116302 RVA: 0x00404945 File Offset: 0x00402B45
		public List<IEntityPrefabElementT> Entities { get; set; }

		// Token: 0x1700840E RID: 33806
		// (get) Token: 0x0601C64F RID: 116303 RVA: 0x0040494E File Offset: 0x00402B4E
		// (set) Token: 0x0601C650 RID: 116304 RVA: 0x00404956 File Offset: 0x00402B56
		public string BpPath { get; set; }

		// Token: 0x1700840F RID: 33807
		// (get) Token: 0x0601C651 RID: 116305 RVA: 0x0040495F File Offset: 0x00402B5F
		// (set) Token: 0x0601C652 RID: 116306 RVA: 0x00404967 File Offset: 0x00402B67
		public int _SelectedEntityId { get; set; }

		// Token: 0x17008410 RID: 33808
		// (get) Token: 0x0601C653 RID: 116307 RVA: 0x00404970 File Offset: 0x00402B70
		// (set) Token: 0x0601C654 RID: 116308 RVA: 0x00404978 File Offset: 0x00402B78
		public byte NullMask { get; set; }

		// Token: 0x0601C655 RID: 116309 RVA: 0x00404984 File Offset: 0x00402B84
		public IEntityPrefabT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.PrefabId = 0;
			this.Name = null;
			this.Entities = null;
			this.BpPath = null;
			this._SelectedEntityId = 0;
			this.NullMask = 0;
		}
	}
}
