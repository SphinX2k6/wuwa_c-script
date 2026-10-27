using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A94 RID: 19092
	public class ICheckIsInDragActorPlayT
	{
		// Token: 0x17008A54 RID: 35412
		// (get) Token: 0x0601DF26 RID: 122662 RVA: 0x00434800 File Offset: 0x00432A00
		// (set) Token: 0x0601DF27 RID: 122663 RVA: 0x00434808 File Offset: 0x00432A08
		public ECondition Type { get; set; }

		// Token: 0x17008A55 RID: 35413
		// (get) Token: 0x0601DF28 RID: 122664 RVA: 0x00434811 File Offset: 0x00432A11
		// (set) Token: 0x0601DF29 RID: 122665 RVA: 0x00434819 File Offset: 0x00432A19
		public bool IsIn { get; set; }

		// Token: 0x0601DF2A RID: 122666 RVA: 0x00434822 File Offset: 0x00432A22
		public ICheckIsInDragActorPlayT()
		{
			this.Type = ECondition.CompareVar;
			this.IsIn = false;
		}
	}
}
