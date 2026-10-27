using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Entity;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004710 RID: 18192
	public class IRunningTreeConfigT
	{
		// Token: 0x17008250 RID: 33360
		// (get) Token: 0x0601BECD RID: 114381 RVA: 0x003F5875 File Offset: 0x003F3A75
		// (set) Token: 0x0601BECE RID: 114382 RVA: 0x003F587D File Offset: 0x003F3A7D
		public int TreeId { get; set; }

		// Token: 0x17008251 RID: 33361
		// (get) Token: 0x0601BECF RID: 114383 RVA: 0x003F5886 File Offset: 0x003F3A86
		// (set) Token: 0x0601BED0 RID: 114384 RVA: 0x003F588E File Offset: 0x003F3A8E
		public List<IRunningNodeStatusT> Nodes { get; set; }

		// Token: 0x17008252 RID: 33362
		// (get) Token: 0x0601BED1 RID: 114385 RVA: 0x003F5897 File Offset: 0x003F3A97
		// (set) Token: 0x0601BED2 RID: 114386 RVA: 0x003F589F File Offset: 0x003F3A9F
		public List<Record_String_StringT> Vars { get; set; }

		// Token: 0x17008253 RID: 33363
		// (get) Token: 0x0601BED3 RID: 114387 RVA: 0x003F58A8 File Offset: 0x003F3AA8
		// (set) Token: 0x0601BED4 RID: 114388 RVA: 0x003F58B0 File Offset: 0x003F3AB0
		public List<Record_String_StringT> SystemVars { get; set; }

		// Token: 0x17008254 RID: 33364
		// (get) Token: 0x0601BED5 RID: 114389 RVA: 0x003F58B9 File Offset: 0x003F3AB9
		// (set) Token: 0x0601BED6 RID: 114390 RVA: 0x003F58C1 File Offset: 0x003F3AC1
		public IGameCurrBreakNodeInfoT BreakNodeInfo { get; set; }

		// Token: 0x17008255 RID: 33365
		// (get) Token: 0x0601BED7 RID: 114391 RVA: 0x003F58CA File Offset: 0x003F3ACA
		// (set) Token: 0x0601BED8 RID: 114392 RVA: 0x003F58D2 File Offset: 0x003F3AD2
		public bool OnSave { get; set; }

		// Token: 0x17008256 RID: 33366
		// (get) Token: 0x0601BED9 RID: 114393 RVA: 0x003F58DB File Offset: 0x003F3ADB
		// (set) Token: 0x0601BEDA RID: 114394 RVA: 0x003F58E3 File Offset: 0x003F3AE3
		public List<int> Saves { get; set; }

		// Token: 0x17008257 RID: 33367
		// (get) Token: 0x0601BEDB RID: 114395 RVA: 0x003F58EC File Offset: 0x003F3AEC
		// (set) Token: 0x0601BEDC RID: 114396 RVA: 0x003F58F4 File Offset: 0x003F3AF4
		public List<string> OptionGuids { get; set; }

		// Token: 0x17008258 RID: 33368
		// (get) Token: 0x0601BEDD RID: 114397 RVA: 0x003F58FD File Offset: 0x003F3AFD
		// (set) Token: 0x0601BEDE RID: 114398 RVA: 0x003F5905 File Offset: 0x003F3B05
		public List<Record_Int_EActionStateT> AllActions { get; set; }

		// Token: 0x17008259 RID: 33369
		// (get) Token: 0x0601BEDF RID: 114399 RVA: 0x003F590E File Offset: 0x003F3B0E
		// (set) Token: 0x0601BEE0 RID: 114400 RVA: 0x003F5916 File Offset: 0x003F3B16
		public IInstEntityDataT ResetEntityData { get; set; }

		// Token: 0x1700825A RID: 33370
		// (get) Token: 0x0601BEE1 RID: 114401 RVA: 0x003F591F File Offset: 0x003F3B1F
		// (set) Token: 0x0601BEE2 RID: 114402 RVA: 0x003F5927 File Offset: 0x003F3B27
		public IInstEntityDataT ResurrectionEntityData { get; set; }

		// Token: 0x1700825B RID: 33371
		// (get) Token: 0x0601BEE3 RID: 114403 RVA: 0x003F5930 File Offset: 0x003F3B30
		// (set) Token: 0x0601BEE4 RID: 114404 RVA: 0x003F5938 File Offset: 0x003F3B38
		public byte NullMask { get; set; }

		// Token: 0x0601BEE5 RID: 114405 RVA: 0x003F5944 File Offset: 0x003F3B44
		public IRunningTreeConfigT()
		{
			this.TreeId = 0;
			this.Nodes = null;
			this.Vars = null;
			this.SystemVars = null;
			this.BreakNodeInfo = null;
			this.OnSave = false;
			this.Saves = null;
			this.OptionGuids = null;
			this.AllActions = null;
			this.ResetEntityData = null;
			this.ResurrectionEntityData = null;
			this.NullMask = 0;
		}
	}
}
