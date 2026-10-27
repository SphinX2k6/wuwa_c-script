using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200419D RID: 16797
	public class ITakePhoto2TargetPlayMontageConditionT
	{
		// Token: 0x17007724 RID: 30500
		// (get) Token: 0x06018B8F RID: 101263 RVA: 0x0038F599 File Offset: 0x0038D799
		// (set) Token: 0x06018B90 RID: 101264 RVA: 0x0038F5A1 File Offset: 0x0038D7A1
		public string MontagePath { get; set; }

		// Token: 0x06018B91 RID: 101265 RVA: 0x0038F5AA File Offset: 0x0038D7AA
		public ITakePhoto2TargetPlayMontageConditionT()
		{
			this.MontagePath = null;
		}
	}
}
