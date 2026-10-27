using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E54 RID: 20052
	public class IActorAttachTargetT
	{
		// Token: 0x17008F84 RID: 36740
		// (get) Token: 0x0601F7AC RID: 128940 RVA: 0x00462AF7 File Offset: 0x00460CF7
		// (set) Token: 0x0601F7AD RID: 128941 RVA: 0x00462AFF File Offset: 0x00460CFF
		public EAttachType Type { get; set; }

		// Token: 0x17008F85 RID: 36741
		// (get) Token: 0x0601F7AE RID: 128942 RVA: 0x00462B08 File Offset: 0x00460D08
		// (set) Token: 0x0601F7AF RID: 128943 RVA: 0x00462B10 File Offset: 0x00460D10
		public IActorRefT ActorRef { get; set; }

		// Token: 0x0601F7B0 RID: 128944 RVA: 0x00462B19 File Offset: 0x00460D19
		public IActorAttachTargetT()
		{
			this.Type = EAttachType.Actor;
			this.ActorRef = null;
		}
	}
}
