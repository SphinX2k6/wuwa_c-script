using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005157 RID: 20823
	public class IEntityAudioComponentT
	{
		// Token: 0x170097E4 RID: 38884
		// (get) Token: 0x060219DF RID: 137695 RVA: 0x004AA66B File Offset: 0x004A886B
		// (set) Token: 0x060219E0 RID: 137696 RVA: 0x004AA673 File Offset: 0x004A8873
		public bool Disabled { get; set; }

		// Token: 0x170097E5 RID: 38885
		// (get) Token: 0x060219E1 RID: 137697 RVA: 0x004AA67C File Offset: 0x004A887C
		// (set) Token: 0x060219E2 RID: 137698 RVA: 0x004AA684 File Offset: 0x004A8884
		public TAkEventTypeUnion AkEventType { get; set; }

		// Token: 0x170097E6 RID: 38886
		// (get) Token: 0x060219E3 RID: 137699 RVA: 0x004AA68D File Offset: 0x004A888D
		// (set) Token: 0x060219E4 RID: 137700 RVA: 0x004AA695 File Offset: 0x004A8895
		public EAudioRangeType AudioRangeType { get; set; }

		// Token: 0x170097E7 RID: 38887
		// (get) Token: 0x060219E5 RID: 137701 RVA: 0x004AA69E File Offset: 0x004A889E
		// (set) Token: 0x060219E6 RID: 137702 RVA: 0x004AA6A6 File Offset: 0x004A88A6
		public byte NullMask { get; set; }

		// Token: 0x060219E7 RID: 137703 RVA: 0x004AA6AF File Offset: 0x004A88AF
		public IEntityAudioComponentT()
		{
			this.Disabled = false;
			this.AkEventType = null;
			this.AudioRangeType = EAudioRangeType.SceneActorRefComp;
			this.NullMask = 0;
		}
	}
}
