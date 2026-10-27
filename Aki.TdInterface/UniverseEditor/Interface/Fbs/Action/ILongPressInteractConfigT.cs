using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A3F RID: 27199
	public class ILongPressInteractConfigT
	{
		// Token: 0x1700C9CB RID: 51659
		// (get) Token: 0x0602F9F2 RID: 195058 RVA: 0x0067B9A4 File Offset: 0x00679BA4
		// (set) Token: 0x0602F9F3 RID: 195059 RVA: 0x0067B9AC File Offset: 0x00679BAC
		public float PressDuration { get; set; }

		// Token: 0x1700C9CC RID: 51660
		// (get) Token: 0x0602F9F4 RID: 195060 RVA: 0x0067B9B5 File Offset: 0x00679BB5
		// (set) Token: 0x0602F9F5 RID: 195061 RVA: 0x0067B9BD File Offset: 0x00679BBD
		public ILongPressEffectConfigT PressEffect { get; set; }

		// Token: 0x1700C9CD RID: 51661
		// (get) Token: 0x0602F9F6 RID: 195062 RVA: 0x0067B9C6 File Offset: 0x00679BC6
		// (set) Token: 0x0602F9F7 RID: 195063 RVA: 0x0067B9CE File Offset: 0x00679BCE
		public TLongPressInteractStyleConfigUnion Style { get; set; }

		// Token: 0x1700C9CE RID: 51662
		// (get) Token: 0x0602F9F8 RID: 195064 RVA: 0x0067B9D7 File Offset: 0x00679BD7
		// (set) Token: 0x0602F9F9 RID: 195065 RVA: 0x0067B9DF File Offset: 0x00679BDF
		public bool ResetFromCurrentProgress { get; set; }

		// Token: 0x1700C9CF RID: 51663
		// (get) Token: 0x0602F9FA RID: 195066 RVA: 0x0067B9E8 File Offset: 0x00679BE8
		// (set) Token: 0x0602F9FB RID: 195067 RVA: 0x0067B9F0 File Offset: 0x00679BF0
		public ILongPressButtonActionMappingT LongPressButtonActionMapping { get; set; }

		// Token: 0x1700C9D0 RID: 51664
		// (get) Token: 0x0602F9FC RID: 195068 RVA: 0x0067B9F9 File Offset: 0x00679BF9
		// (set) Token: 0x0602F9FD RID: 195069 RVA: 0x0067BA01 File Offset: 0x00679C01
		public List<IActionInfoT> LongPressStartActions { get; set; }

		// Token: 0x1700C9D1 RID: 51665
		// (get) Token: 0x0602F9FE RID: 195070 RVA: 0x0067BA0A File Offset: 0x00679C0A
		// (set) Token: 0x0602F9FF RID: 195071 RVA: 0x0067BA12 File Offset: 0x00679C12
		public List<IActionInfoT> LongPressInterruptedActions { get; set; }

		// Token: 0x1700C9D2 RID: 51666
		// (get) Token: 0x0602FA00 RID: 195072 RVA: 0x0067BA1B File Offset: 0x00679C1B
		// (set) Token: 0x0602FA01 RID: 195073 RVA: 0x0067BA23 File Offset: 0x00679C23
		public List<IActionInfoT> LongPressSuccessActions { get; set; }

		// Token: 0x1700C9D3 RID: 51667
		// (get) Token: 0x0602FA02 RID: 195074 RVA: 0x0067BA2C File Offset: 0x00679C2C
		// (set) Token: 0x0602FA03 RID: 195075 RVA: 0x0067BA34 File Offset: 0x00679C34
		public List<ILongPressProgressActionT> LongPressProgressActions { get; set; }

		// Token: 0x1700C9D4 RID: 51668
		// (get) Token: 0x0602FA04 RID: 195076 RVA: 0x0067BA3D File Offset: 0x00679C3D
		// (set) Token: 0x0602FA05 RID: 195077 RVA: 0x0067BA45 File Offset: 0x00679C45
		public byte NullMask { get; set; }

		// Token: 0x0602FA06 RID: 195078 RVA: 0x0067BA50 File Offset: 0x00679C50
		public ILongPressInteractConfigT()
		{
			this.PressDuration = 0f;
			this.PressEffect = null;
			this.Style = null;
			this.ResetFromCurrentProgress = false;
			this.LongPressButtonActionMapping = null;
			this.LongPressStartActions = null;
			this.LongPressInterruptedActions = null;
			this.LongPressSuccessActions = null;
			this.LongPressProgressActions = null;
			this.NullMask = 0;
		}
	}
}
