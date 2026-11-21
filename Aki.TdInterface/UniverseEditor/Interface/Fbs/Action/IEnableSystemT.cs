using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D0E RID: 27918
	public class IEnableSystemT
	{
		// Token: 0x1700CCDD RID: 52445
		// (get) Token: 0x0603026E RID: 197230 RVA: 0x0068C718 File Offset: 0x0068A918
		// (set) Token: 0x0603026F RID: 197231 RVA: 0x0068C720 File Offset: 0x0068A920
		public ESystem SystemType { get; set; }

		// Token: 0x1700CCDE RID: 52446
		// (get) Token: 0x06030270 RID: 197232 RVA: 0x0068C729 File Offset: 0x0068A929
		// (set) Token: 0x06030271 RID: 197233 RVA: 0x0068C731 File Offset: 0x0068A931
		public bool IsEnable { get; set; }

		// Token: 0x06030272 RID: 197234 RVA: 0x0068C73A File Offset: 0x0068A93A
		public IEnableSystemT()
		{
			this.SystemType = ESystem.None;
			this.IsEnable = false;
		}
	}
}
