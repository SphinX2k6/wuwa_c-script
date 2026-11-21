using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200715E RID: 29022
	public class ILongPressEffectConfigT
	{
		// Token: 0x1700D465 RID: 54373
		// (get) Token: 0x060326CC RID: 206540 RVA: 0x006D0B2C File Offset: 0x006CED2C
		// (set) Token: 0x060326CD RID: 206541 RVA: 0x006D0B34 File Offset: 0x006CED34
		public string CameraShakeBpPath { get; set; }

		// Token: 0x1700D466 RID: 54374
		// (get) Token: 0x060326CE RID: 206542 RVA: 0x006D0B3D File Offset: 0x006CED3D
		// (set) Token: 0x060326CF RID: 206543 RVA: 0x006D0B45 File Offset: 0x006CED45
		public string LongPressSound { get; set; }

		// Token: 0x1700D467 RID: 54375
		// (get) Token: 0x060326D0 RID: 206544 RVA: 0x006D0B4E File Offset: 0x006CED4E
		// (set) Token: 0x060326D1 RID: 206545 RVA: 0x006D0B56 File Offset: 0x006CED56
		public IGamePadInteractVibrationT GamePadVibration { get; set; }

		// Token: 0x1700D468 RID: 54376
		// (get) Token: 0x060326D2 RID: 206546 RVA: 0x006D0B5F File Offset: 0x006CED5F
		// (set) Token: 0x060326D3 RID: 206547 RVA: 0x006D0B67 File Offset: 0x006CED67
		public string LongPressScreenEffect { get; set; }

		// Token: 0x1700D469 RID: 54377
		// (get) Token: 0x060326D4 RID: 206548 RVA: 0x006D0B70 File Offset: 0x006CED70
		// (set) Token: 0x060326D5 RID: 206549 RVA: 0x006D0B78 File Offset: 0x006CED78
		public List<string> PlayEffects { get; set; }

		// Token: 0x1700D46A RID: 54378
		// (get) Token: 0x060326D6 RID: 206550 RVA: 0x006D0B81 File Offset: 0x006CED81
		// (set) Token: 0x060326D7 RID: 206551 RVA: 0x006D0B89 File Offset: 0x006CED89
		public byte NullMask { get; set; }

		// Token: 0x060326D8 RID: 206552 RVA: 0x006D0B92 File Offset: 0x006CED92
		public ILongPressEffectConfigT()
		{
			this.CameraShakeBpPath = null;
			this.LongPressSound = null;
			this.GamePadVibration = null;
			this.LongPressScreenEffect = null;
			this.PlayEffects = null;
			this.NullMask = 0;
		}
	}
}
