using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F13 RID: 28435
	public class IRunActorCustomEventT
	{
		// Token: 0x1700D366 RID: 54118
		// (get) Token: 0x060323D3 RID: 205779 RVA: 0x006C98D7 File Offset: 0x006C7AD7
		// (set) Token: 0x060323D4 RID: 205780 RVA: 0x006C98DF File Offset: 0x006C7ADF
		public IActorRefT ActorRef { get; set; }

		// Token: 0x1700D367 RID: 54119
		// (get) Token: 0x060323D5 RID: 205781 RVA: 0x006C98E8 File Offset: 0x006C7AE8
		// (set) Token: 0x060323D6 RID: 205782 RVA: 0x006C98F0 File Offset: 0x006C7AF0
		public string EventName { get; set; }

		// Token: 0x060323D7 RID: 205783 RVA: 0x006C98F9 File Offset: 0x006C7AF9
		public IRunActorCustomEventT()
		{
			this.ActorRef = null;
			this.EventName = null;
		}
	}
}
