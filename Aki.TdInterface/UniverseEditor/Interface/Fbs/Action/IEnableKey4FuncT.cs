using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE1 RID: 27873
	public class IEnableKey4FuncT
	{
		// Token: 0x1700CC6D RID: 52333
		// (get) Token: 0x060300C2 RID: 196802 RVA: 0x006897B0 File Offset: 0x006879B0
		// (set) Token: 0x060300C3 RID: 196803 RVA: 0x006897B8 File Offset: 0x006879B8
		public bool IsEnable { get; set; }

		// Token: 0x1700CC6E RID: 52334
		// (get) Token: 0x060300C4 RID: 196804 RVA: 0x006897C1 File Offset: 0x006879C1
		// (set) Token: 0x060300C5 RID: 196805 RVA: 0x006897C9 File Offset: 0x006879C9
		public EEnableKey4FuncKey FuncKey { get; set; }

		// Token: 0x060300C6 RID: 196806 RVA: 0x006897D2 File Offset: 0x006879D2
		public IEnableKey4FuncT()
		{
			this.IsEnable = false;
			this.FuncKey = EEnableKey4FuncKey.TimeScaled;
		}
	}
}
