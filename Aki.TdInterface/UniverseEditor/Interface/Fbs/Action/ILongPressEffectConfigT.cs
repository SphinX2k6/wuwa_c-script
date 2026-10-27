using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A3C RID: 27196
	public class ILongPressEffectConfigT
	{
		// Token: 0x1700C9BA RID: 51642
		// (get) Token: 0x0602F9A6 RID: 194982 RVA: 0x0067AA6C File Offset: 0x00678C6C
		// (set) Token: 0x0602F9A7 RID: 194983 RVA: 0x0067AA74 File Offset: 0x00678C74
		public string CameraShakeBpPath { get; set; }

		// Token: 0x1700C9BB RID: 51643
		// (get) Token: 0x0602F9A8 RID: 194984 RVA: 0x0067AA7D File Offset: 0x00678C7D
		// (set) Token: 0x0602F9A9 RID: 194985 RVA: 0x0067AA85 File Offset: 0x00678C85
		public string LongPressSound { get; set; }

		// Token: 0x1700C9BC RID: 51644
		// (get) Token: 0x0602F9AA RID: 194986 RVA: 0x0067AA8E File Offset: 0x00678C8E
		// (set) Token: 0x0602F9AB RID: 194987 RVA: 0x0067AA96 File Offset: 0x00678C96
		public IGamePadInteractVibrationT GamePadVibration { get; set; }

		// Token: 0x1700C9BD RID: 51645
		// (get) Token: 0x0602F9AC RID: 194988 RVA: 0x0067AA9F File Offset: 0x00678C9F
		// (set) Token: 0x0602F9AD RID: 194989 RVA: 0x0067AAA7 File Offset: 0x00678CA7
		public string LongPressScreenEffect { get; set; }

		// Token: 0x1700C9BE RID: 51646
		// (get) Token: 0x0602F9AE RID: 194990 RVA: 0x0067AAB0 File Offset: 0x00678CB0
		// (set) Token: 0x0602F9AF RID: 194991 RVA: 0x0067AAB8 File Offset: 0x00678CB8
		public List<string> PlayEffects { get; set; }

		// Token: 0x1700C9BF RID: 51647
		// (get) Token: 0x0602F9B0 RID: 194992 RVA: 0x0067AAC1 File Offset: 0x00678CC1
		// (set) Token: 0x0602F9B1 RID: 194993 RVA: 0x0067AAC9 File Offset: 0x00678CC9
		public byte NullMask { get; set; }

		// Token: 0x0602F9B2 RID: 194994 RVA: 0x0067AAD2 File Offset: 0x00678CD2
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
