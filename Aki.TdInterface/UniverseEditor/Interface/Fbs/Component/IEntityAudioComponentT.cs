using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056BC RID: 22204
	public class IEntityAudioComponentT
	{
		// Token: 0x17009FD1 RID: 40913
		// (get) Token: 0x06023933 RID: 145715 RVA: 0x004E45F7 File Offset: 0x004E27F7
		// (set) Token: 0x06023934 RID: 145716 RVA: 0x004E45FF File Offset: 0x004E27FF
		public bool Disabled { get; set; }

		// Token: 0x17009FD2 RID: 40914
		// (get) Token: 0x06023935 RID: 145717 RVA: 0x004E4608 File Offset: 0x004E2808
		// (set) Token: 0x06023936 RID: 145718 RVA: 0x004E4610 File Offset: 0x004E2810
		public TAkEventTypeUnion AkEventType { get; set; }

		// Token: 0x17009FD3 RID: 40915
		// (get) Token: 0x06023937 RID: 145719 RVA: 0x004E4619 File Offset: 0x004E2819
		// (set) Token: 0x06023938 RID: 145720 RVA: 0x004E4621 File Offset: 0x004E2821
		public EAudioRangeType AudioRangeType { get; set; }

		// Token: 0x17009FD4 RID: 40916
		// (get) Token: 0x06023939 RID: 145721 RVA: 0x004E462A File Offset: 0x004E282A
		// (set) Token: 0x0602393A RID: 145722 RVA: 0x004E4632 File Offset: 0x004E2832
		public byte NullMask { get; set; }

		// Token: 0x0602393B RID: 145723 RVA: 0x004E463B File Offset: 0x004E283B
		public IEntityAudioComponentT()
		{
			this.Disabled = false;
			this.AkEventType = null;
			this.AudioRangeType = EAudioRangeType.SceneActorRefComp;
			this.NullMask = 0;
		}
	}
}
