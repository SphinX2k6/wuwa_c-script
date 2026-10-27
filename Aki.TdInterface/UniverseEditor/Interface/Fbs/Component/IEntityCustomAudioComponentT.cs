using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005175 RID: 20853
	public class IEntityCustomAudioComponentT
	{
		// Token: 0x17009851 RID: 38993
		// (get) Token: 0x06021B49 RID: 138057 RVA: 0x004AD5C9 File Offset: 0x004AB7C9
		// (set) Token: 0x06021B4A RID: 138058 RVA: 0x004AD5D1 File Offset: 0x004AB7D1
		public bool Disabled { get; set; }

		// Token: 0x17009852 RID: 38994
		// (get) Token: 0x06021B4B RID: 138059 RVA: 0x004AD5DA File Offset: 0x004AB7DA
		// (set) Token: 0x06021B4C RID: 138060 RVA: 0x004AD5E2 File Offset: 0x004AB7E2
		public TAkEventTypeUnion AkEventType { get; set; }

		// Token: 0x17009853 RID: 38995
		// (get) Token: 0x06021B4D RID: 138061 RVA: 0x004AD5EB File Offset: 0x004AB7EB
		// (set) Token: 0x06021B4E RID: 138062 RVA: 0x004AD5F3 File Offset: 0x004AB7F3
		public EAudioRangeType AudioRangeType { get; set; }

		// Token: 0x17009854 RID: 38996
		// (get) Token: 0x06021B4F RID: 138063 RVA: 0x004AD5FC File Offset: 0x004AB7FC
		// (set) Token: 0x06021B50 RID: 138064 RVA: 0x004AD604 File Offset: 0x004AB804
		public TAudioControlTypeUnion AudioControlType { get; set; }

		// Token: 0x17009855 RID: 38997
		// (get) Token: 0x06021B51 RID: 138065 RVA: 0x004AD60D File Offset: 0x004AB80D
		// (set) Token: 0x06021B52 RID: 138066 RVA: 0x004AD615 File Offset: 0x004AB815
		public byte NullMask { get; set; }

		// Token: 0x06021B53 RID: 138067 RVA: 0x004AD61E File Offset: 0x004AB81E
		public IEntityCustomAudioComponentT()
		{
			this.Disabled = false;
			this.AkEventType = null;
			this.AudioRangeType = EAudioRangeType.SceneActorRefComp;
			this.AudioControlType = null;
			this.NullMask = 0;
		}
	}
}
