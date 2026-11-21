using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200769A RID: 30362
	public class IRunActorCustomEventT
	{
		// Token: 0x1700DEC2 RID: 57026
		// (get) Token: 0x0603542B RID: 218155 RVA: 0x0072583F File Offset: 0x00723A3F
		// (set) Token: 0x0603542C RID: 218156 RVA: 0x00725847 File Offset: 0x00723A47
		public IActorRefT ActorRef { get; set; }

		// Token: 0x1700DEC3 RID: 57027
		// (get) Token: 0x0603542D RID: 218157 RVA: 0x00725850 File Offset: 0x00723A50
		// (set) Token: 0x0603542E RID: 218158 RVA: 0x00725858 File Offset: 0x00723A58
		public string EventName { get; set; }

		// Token: 0x0603542F RID: 218159 RVA: 0x00725861 File Offset: 0x00723A61
		public IRunActorCustomEventT()
		{
			this.ActorRef = null;
			this.EventName = null;
		}
	}
}
