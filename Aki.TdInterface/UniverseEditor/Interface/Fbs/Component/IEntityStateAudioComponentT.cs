using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005719 RID: 22297
	public class IEntityStateAudioComponentT
	{
		// Token: 0x1700A0D0 RID: 41168
		// (get) Token: 0x06023D30 RID: 146736 RVA: 0x004EC9A2 File Offset: 0x004EABA2
		// (set) Token: 0x06023D31 RID: 146737 RVA: 0x004EC9AA File Offset: 0x004EABAA
		public bool Disabled { get; set; }

		// Token: 0x1700A0D1 RID: 41169
		// (get) Token: 0x06023D32 RID: 146738 RVA: 0x004EC9B3 File Offset: 0x004EABB3
		// (set) Token: 0x06023D33 RID: 146739 RVA: 0x004EC9BB File Offset: 0x004EABBB
		public TAkEventTypeUnion AkEventType { get; set; }

		// Token: 0x1700A0D2 RID: 41170
		// (get) Token: 0x06023D34 RID: 146740 RVA: 0x004EC9C4 File Offset: 0x004EABC4
		// (set) Token: 0x06023D35 RID: 146741 RVA: 0x004EC9CC File Offset: 0x004EABCC
		public EAudioRangeType AudioRangeType { get; set; }

		// Token: 0x1700A0D3 RID: 41171
		// (get) Token: 0x06023D36 RID: 146742 RVA: 0x004EC9D5 File Offset: 0x004EABD5
		// (set) Token: 0x06023D37 RID: 146743 RVA: 0x004EC9DD File Offset: 0x004EABDD
		public List<IEntityStateAudioConfigT> Config { get; set; }

		// Token: 0x1700A0D4 RID: 41172
		// (get) Token: 0x06023D38 RID: 146744 RVA: 0x004EC9E6 File Offset: 0x004EABE6
		// (set) Token: 0x06023D39 RID: 146745 RVA: 0x004EC9EE File Offset: 0x004EABEE
		public byte NullMask { get; set; }

		// Token: 0x06023D3A RID: 146746 RVA: 0x004EC9F7 File Offset: 0x004EABF7
		public IEntityStateAudioComponentT()
		{
			this.Disabled = false;
			this.AkEventType = null;
			this.AudioRangeType = EAudioRangeType.SceneActorRefComp;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
