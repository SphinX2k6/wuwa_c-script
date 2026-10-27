using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CC RID: 30156
	public class IVisualNovelPerformanceUiShakeT
	{
		// Token: 0x1700E511 RID: 58641
		// (get) Token: 0x06036ED6 RID: 224982 RVA: 0x007749AD File Offset: 0x00772BAD
		// (set) Token: 0x06036ED7 RID: 224983 RVA: 0x007749B5 File Offset: 0x00772BB5
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E512 RID: 58642
		// (get) Token: 0x06036ED8 RID: 224984 RVA: 0x007749BE File Offset: 0x00772BBE
		// (set) Token: 0x06036ED9 RID: 224985 RVA: 0x007749C6 File Offset: 0x00772BC6
		public float StartTime { get; set; }

		// Token: 0x1700E513 RID: 58643
		// (get) Token: 0x06036EDA RID: 224986 RVA: 0x007749CF File Offset: 0x00772BCF
		// (set) Token: 0x06036EDB RID: 224987 RVA: 0x007749D7 File Offset: 0x00772BD7
		public EVisualNovelUiShakeType ShakeType { get; set; }

		// Token: 0x1700E514 RID: 58644
		// (get) Token: 0x06036EDC RID: 224988 RVA: 0x007749E0 File Offset: 0x00772BE0
		// (set) Token: 0x06036EDD RID: 224989 RVA: 0x007749E8 File Offset: 0x00772BE8
		public EVisualNovelShakeIntensity Intensity { get; set; }

		// Token: 0x1700E515 RID: 58645
		// (get) Token: 0x06036EDE RID: 224990 RVA: 0x007749F1 File Offset: 0x00772BF1
		// (set) Token: 0x06036EDF RID: 224991 RVA: 0x007749F9 File Offset: 0x00772BF9
		public float Duration { get; set; }

		// Token: 0x1700E516 RID: 58646
		// (get) Token: 0x06036EE0 RID: 224992 RVA: 0x00774A02 File Offset: 0x00772C02
		// (set) Token: 0x06036EE1 RID: 224993 RVA: 0x00774A0A File Offset: 0x00772C0A
		public string ScreenEffectDa { get; set; }

		// Token: 0x1700E517 RID: 58647
		// (get) Token: 0x06036EE2 RID: 224994 RVA: 0x00774A13 File Offset: 0x00772C13
		// (set) Token: 0x06036EE3 RID: 224995 RVA: 0x00774A1B File Offset: 0x00772C1B
		public byte NullMask { get; set; }

		// Token: 0x06036EE4 RID: 224996 RVA: 0x00774A24 File Offset: 0x00772C24
		public IVisualNovelPerformanceUiShakeT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.ShakeType = EVisualNovelUiShakeType.Random;
			this.Intensity = EVisualNovelShakeIntensity.Weak;
			this.Duration = 0f;
			this.ScreenEffectDa = null;
			this.NullMask = 0;
		}
	}
}
