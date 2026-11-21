using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EA0 RID: 20128
	public class ICheckElementalBoxStateT
	{
		// Token: 0x17008F97 RID: 36759
		// (get) Token: 0x0601F327 RID: 127783 RVA: 0x00459993 File Offset: 0x00457B93
		// (set) Token: 0x0601F328 RID: 127784 RVA: 0x0045999B File Offset: 0x00457B9B
		public ECondition Type { get; set; }

		// Token: 0x17008F98 RID: 36760
		// (get) Token: 0x0601F329 RID: 127785 RVA: 0x004599A4 File Offset: 0x00457BA4
		// (set) Token: 0x0601F32A RID: 127786 RVA: 0x004599AC File Offset: 0x00457BAC
		public TElementalBoxStateTargetUnion Target { get; set; }

		// Token: 0x0601F32B RID: 127787 RVA: 0x004599B5 File Offset: 0x00457BB5
		public ICheckElementalBoxStateT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
		}
	}
}
