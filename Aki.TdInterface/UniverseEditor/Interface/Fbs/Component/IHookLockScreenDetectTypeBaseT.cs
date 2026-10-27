using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053CC RID: 21452
	public class IHookLockScreenDetectTypeBaseT
	{
		// Token: 0x17009DDB RID: 40411
		// (get) Token: 0x06023355 RID: 144213 RVA: 0x004E0566 File Offset: 0x004DE766
		// (set) Token: 0x06023356 RID: 144214 RVA: 0x004E056E File Offset: 0x004DE76E
		public EHookLockScreenDetectType Type { get; set; }

		// Token: 0x06023357 RID: 144215 RVA: 0x004E0577 File Offset: 0x004DE777
		public IHookLockScreenDetectTypeBaseT()
		{
			this.Type = EHookLockScreenDetectType.CentralEllipse;
		}
	}
}
