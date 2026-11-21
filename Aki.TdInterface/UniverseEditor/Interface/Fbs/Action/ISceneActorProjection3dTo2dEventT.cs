using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B2 RID: 30386
	public class ISceneActorProjection3dTo2dEventT
	{
		// Token: 0x1700DEE4 RID: 57060
		// (get) Token: 0x060354D1 RID: 218321 RVA: 0x00726858 File Offset: 0x00724A58
		// (set) Token: 0x060354D2 RID: 218322 RVA: 0x00726860 File Offset: 0x00724A60
		public ESceneActorEventType Type { get; set; }

		// Token: 0x1700DEE5 RID: 57061
		// (get) Token: 0x060354D3 RID: 218323 RVA: 0x00726869 File Offset: 0x00724A69
		// (set) Token: 0x060354D4 RID: 218324 RVA: 0x00726871 File Offset: 0x00724A71
		public IActorRefT BpActor { get; set; }

		// Token: 0x1700DEE6 RID: 57062
		// (get) Token: 0x060354D5 RID: 218325 RVA: 0x0072687A File Offset: 0x00724A7A
		// (set) Token: 0x060354D6 RID: 218326 RVA: 0x00726882 File Offset: 0x00724A82
		public IActorRefT PPVolume { get; set; }

		// Token: 0x060354D7 RID: 218327 RVA: 0x0072688B File Offset: 0x00724A8B
		public ISceneActorProjection3dTo2dEventT()
		{
			this.Type = ESceneActorEventType.PlayMusicPlants;
			this.BpActor = null;
			this.PPVolume = null;
		}
	}
}
