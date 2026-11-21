using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Entity;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B78 RID: 19320
	public class IRunningTreeConfigT
	{
		// Token: 0x17008891 RID: 34961
		// (get) Token: 0x0601D6A2 RID: 120482 RVA: 0x00421B11 File Offset: 0x0041FD11
		// (set) Token: 0x0601D6A3 RID: 120483 RVA: 0x00421B19 File Offset: 0x0041FD19
		public int TreeId { get; set; }

		// Token: 0x17008892 RID: 34962
		// (get) Token: 0x0601D6A4 RID: 120484 RVA: 0x00421B22 File Offset: 0x0041FD22
		// (set) Token: 0x0601D6A5 RID: 120485 RVA: 0x00421B2A File Offset: 0x0041FD2A
		public List<IRunningNodeStatusT> Nodes { get; set; }

		// Token: 0x17008893 RID: 34963
		// (get) Token: 0x0601D6A6 RID: 120486 RVA: 0x00421B33 File Offset: 0x0041FD33
		// (set) Token: 0x0601D6A7 RID: 120487 RVA: 0x00421B3B File Offset: 0x0041FD3B
		public List<Record_String_StringT> Vars { get; set; }

		// Token: 0x17008894 RID: 34964
		// (get) Token: 0x0601D6A8 RID: 120488 RVA: 0x00421B44 File Offset: 0x0041FD44
		// (set) Token: 0x0601D6A9 RID: 120489 RVA: 0x00421B4C File Offset: 0x0041FD4C
		public List<Record_String_StringT> SystemVars { get; set; }

		// Token: 0x17008895 RID: 34965
		// (get) Token: 0x0601D6AA RID: 120490 RVA: 0x00421B55 File Offset: 0x0041FD55
		// (set) Token: 0x0601D6AB RID: 120491 RVA: 0x00421B5D File Offset: 0x0041FD5D
		public IGameCurrBreakNodeInfoT BreakNodeInfo { get; set; }

		// Token: 0x17008896 RID: 34966
		// (get) Token: 0x0601D6AC RID: 120492 RVA: 0x00421B66 File Offset: 0x0041FD66
		// (set) Token: 0x0601D6AD RID: 120493 RVA: 0x00421B6E File Offset: 0x0041FD6E
		public bool OnSave { get; set; }

		// Token: 0x17008897 RID: 34967
		// (get) Token: 0x0601D6AE RID: 120494 RVA: 0x00421B77 File Offset: 0x0041FD77
		// (set) Token: 0x0601D6AF RID: 120495 RVA: 0x00421B7F File Offset: 0x0041FD7F
		public List<int> Saves { get; set; }

		// Token: 0x17008898 RID: 34968
		// (get) Token: 0x0601D6B0 RID: 120496 RVA: 0x00421B88 File Offset: 0x0041FD88
		// (set) Token: 0x0601D6B1 RID: 120497 RVA: 0x00421B90 File Offset: 0x0041FD90
		public List<string> OptionGuids { get; set; }

		// Token: 0x17008899 RID: 34969
		// (get) Token: 0x0601D6B2 RID: 120498 RVA: 0x00421B99 File Offset: 0x0041FD99
		// (set) Token: 0x0601D6B3 RID: 120499 RVA: 0x00421BA1 File Offset: 0x0041FDA1
		public List<Record_Int_EActionStateT> AllActions { get; set; }

		// Token: 0x1700889A RID: 34970
		// (get) Token: 0x0601D6B4 RID: 120500 RVA: 0x00421BAA File Offset: 0x0041FDAA
		// (set) Token: 0x0601D6B5 RID: 120501 RVA: 0x00421BB2 File Offset: 0x0041FDB2
		public IInstEntityDataT ResetEntityData { get; set; }

		// Token: 0x1700889B RID: 34971
		// (get) Token: 0x0601D6B6 RID: 120502 RVA: 0x00421BBB File Offset: 0x0041FDBB
		// (set) Token: 0x0601D6B7 RID: 120503 RVA: 0x00421BC3 File Offset: 0x0041FDC3
		public IInstEntityDataT ResurrectionEntityData { get; set; }

		// Token: 0x1700889C RID: 34972
		// (get) Token: 0x0601D6B8 RID: 120504 RVA: 0x00421BCC File Offset: 0x0041FDCC
		// (set) Token: 0x0601D6B9 RID: 120505 RVA: 0x00421BD4 File Offset: 0x0041FDD4
		public byte NullMask { get; set; }

		// Token: 0x0601D6BA RID: 120506 RVA: 0x00421BE0 File Offset: 0x0041FDE0
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
