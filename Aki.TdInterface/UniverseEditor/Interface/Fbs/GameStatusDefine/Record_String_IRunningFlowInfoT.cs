using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004719 RID: 18201
	public class Record_String_IRunningFlowInfoT
	{
		// Token: 0x17008269 RID: 33385
		// (get) Token: 0x0601BF25 RID: 114469 RVA: 0x003F6177 File Offset: 0x003F4377
		// (set) Token: 0x0601BF26 RID: 114470 RVA: 0x003F617F File Offset: 0x003F437F
		public string Key { get; set; }

		// Token: 0x1700826A RID: 33386
		// (get) Token: 0x0601BF27 RID: 114471 RVA: 0x003F6188 File Offset: 0x003F4388
		// (set) Token: 0x0601BF28 RID: 114472 RVA: 0x003F6190 File Offset: 0x003F4390
		public IRunningFlowInfoT Value { get; set; }

		// Token: 0x0601BF29 RID: 114473 RVA: 0x003F6199 File Offset: 0x003F4399
		public Record_String_IRunningFlowInfoT()
		{
			this.Key = null;
			this.Value = null;
		}
	}
}
