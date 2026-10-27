using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F2B RID: 28459
	public class ISceneActorProjection3dTo2dEventT
	{
		// Token: 0x1700D388 RID: 54152
		// (get) Token: 0x06032479 RID: 205945 RVA: 0x006CA8F0 File Offset: 0x006C8AF0
		// (set) Token: 0x0603247A RID: 205946 RVA: 0x006CA8F8 File Offset: 0x006C8AF8
		public ESceneActorEventType Type { get; set; }

		// Token: 0x1700D389 RID: 54153
		// (get) Token: 0x0603247B RID: 205947 RVA: 0x006CA901 File Offset: 0x006C8B01
		// (set) Token: 0x0603247C RID: 205948 RVA: 0x006CA909 File Offset: 0x006C8B09
		public IActorRefT BpActor { get; set; }

		// Token: 0x1700D38A RID: 54154
		// (get) Token: 0x0603247D RID: 205949 RVA: 0x006CA912 File Offset: 0x006C8B12
		// (set) Token: 0x0603247E RID: 205950 RVA: 0x006CA91A File Offset: 0x006C8B1A
		public IActorRefT PPVolume { get; set; }

		// Token: 0x0603247F RID: 205951 RVA: 0x006CA923 File Offset: 0x006C8B23
		public ISceneActorProjection3dTo2dEventT()
		{
			this.Type = ESceneActorEventType.PlayMusicPlants;
			this.BpActor = null;
			this.PPVolume = null;
		}
	}
}
