using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200797B RID: 31099
	public class ISpringArmSoftZoneConfigT
	{
		// Token: 0x1700E40A RID: 58378
		// (get) Token: 0x06036C5C RID: 224348 RVA: 0x00753A26 File Offset: 0x00751C26
		// (set) Token: 0x06036C5D RID: 224349 RVA: 0x00753A2E File Offset: 0x00751C2E
		public ISingleAxisSpringArmSoftZoneConfigT LeftRightConfig { get; set; }

		// Token: 0x1700E40B RID: 58379
		// (get) Token: 0x06036C5E RID: 224350 RVA: 0x00753A37 File Offset: 0x00751C37
		// (set) Token: 0x06036C5F RID: 224351 RVA: 0x00753A3F File Offset: 0x00751C3F
		public ISingleAxisSpringArmSoftZoneConfigT ForwardBackConfig { get; set; }

		// Token: 0x1700E40C RID: 58380
		// (get) Token: 0x06036C60 RID: 224352 RVA: 0x00753A48 File Offset: 0x00751C48
		// (set) Token: 0x06036C61 RID: 224353 RVA: 0x00753A50 File Offset: 0x00751C50
		public ISingleAxisSpringArmSoftZoneConfigT UpDownConfig { get; set; }

		// Token: 0x06036C62 RID: 224354 RVA: 0x00753A59 File Offset: 0x00751C59
		public ISpringArmSoftZoneConfigT()
		{
			this.LeftRightConfig = null;
			this.ForwardBackConfig = null;
			this.UpDownConfig = null;
		}
	}
}
