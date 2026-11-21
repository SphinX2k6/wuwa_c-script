using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004074 RID: 16500
	public class ITrackTipsActorT
	{
		// Token: 0x1700705B RID: 28763
		// (get) Token: 0x06016B65 RID: 93029 RVA: 0x0033EF06 File Offset: 0x0033D106
		// (set) Token: 0x06016B66 RID: 93030 RVA: 0x0033EF0E File Offset: 0x0033D10E
		public ETipsActorType Type { get; set; }

		// Token: 0x1700705C RID: 28764
		// (get) Token: 0x06016B67 RID: 93031 RVA: 0x0033EF17 File Offset: 0x0033D117
		// (set) Token: 0x06016B68 RID: 93032 RVA: 0x0033EF1F File Offset: 0x0033D11F
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x1700705D RID: 28765
		// (get) Token: 0x06016B69 RID: 93033 RVA: 0x0033EF28 File Offset: 0x0033D128
		// (set) Token: 0x06016B6A RID: 93034 RVA: 0x0033EF30 File Offset: 0x0033D130
		public int EntityId { get; set; }

		// Token: 0x1700705E RID: 28766
		// (get) Token: 0x06016B6B RID: 93035 RVA: 0x0033EF39 File Offset: 0x0033D139
		// (set) Token: 0x06016B6C RID: 93036 RVA: 0x0033EF41 File Offset: 0x0033D141
		public float Width { get; set; }

		// Token: 0x1700705F RID: 28767
		// (get) Token: 0x06016B6D RID: 93037 RVA: 0x0033EF4A File Offset: 0x0033D14A
		// (set) Token: 0x06016B6E RID: 93038 RVA: 0x0033EF52 File Offset: 0x0033D152
		public byte NullMask { get; set; }

		// Token: 0x06016B6F RID: 93039 RVA: 0x0033EF5B File Offset: 0x0033D15B
		public ITrackTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.EntityId = 0;
			this.Width = 0f;
			this.NullMask = 0;
		}
	}
}
