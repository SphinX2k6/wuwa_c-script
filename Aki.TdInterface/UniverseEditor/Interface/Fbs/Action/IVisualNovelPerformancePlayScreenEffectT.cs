using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B7 RID: 30135
	public class IVisualNovelPerformancePlayScreenEffectT
	{
		// Token: 0x1700E4C6 RID: 58566
		// (get) Token: 0x06036DE6 RID: 224742 RVA: 0x00772D7D File Offset: 0x00770F7D
		// (set) Token: 0x06036DE7 RID: 224743 RVA: 0x00772D85 File Offset: 0x00770F85
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E4C7 RID: 58567
		// (get) Token: 0x06036DE8 RID: 224744 RVA: 0x00772D8E File Offset: 0x00770F8E
		// (set) Token: 0x06036DE9 RID: 224745 RVA: 0x00772D96 File Offset: 0x00770F96
		public float StartTime { get; set; }

		// Token: 0x1700E4C8 RID: 58568
		// (get) Token: 0x06036DEA RID: 224746 RVA: 0x00772D9F File Offset: 0x00770F9F
		// (set) Token: 0x06036DEB RID: 224747 RVA: 0x00772DA7 File Offset: 0x00770FA7
		public string ScreenEffectDa { get; set; }

		// Token: 0x1700E4C9 RID: 58569
		// (get) Token: 0x06036DEC RID: 224748 RVA: 0x00772DB0 File Offset: 0x00770FB0
		// (set) Token: 0x06036DED RID: 224749 RVA: 0x00772DB8 File Offset: 0x00770FB8
		public float DestroyCountdown { get; set; }

		// Token: 0x1700E4CA RID: 58570
		// (get) Token: 0x06036DEE RID: 224750 RVA: 0x00772DC1 File Offset: 0x00770FC1
		// (set) Token: 0x06036DEF RID: 224751 RVA: 0x00772DC9 File Offset: 0x00770FC9
		public byte NullMask { get; set; }

		// Token: 0x06036DF0 RID: 224752 RVA: 0x00772DD2 File Offset: 0x00770FD2
		public IVisualNovelPerformancePlayScreenEffectT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.ScreenEffectDa = null;
			this.DestroyCountdown = 0f;
			this.NullMask = 0;
		}
	}
}
