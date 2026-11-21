using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006923 RID: 26915
	public class ICarPaintChangeBpActorFuncT
	{
		// Token: 0x1700C625 RID: 50725
		// (get) Token: 0x0602E1FA RID: 188922 RVA: 0x0064D6E7 File Offset: 0x0064B8E7
		// (set) Token: 0x0602E1FB RID: 188923 RVA: 0x0064D6EF File Offset: 0x0064B8EF
		public EBpActorFuncType Type { get; set; }

		// Token: 0x1700C626 RID: 50726
		// (get) Token: 0x0602E1FC RID: 188924 RVA: 0x0064D6F8 File Offset: 0x0064B8F8
		// (set) Token: 0x0602E1FD RID: 188925 RVA: 0x0064D700 File Offset: 0x0064B900
		public IActorRefT BpActor { get; set; }

		// Token: 0x0602E1FE RID: 188926 RVA: 0x0064D709 File Offset: 0x0064B909
		public ICarPaintChangeBpActorFuncT()
		{
			this.Type = EBpActorFuncType.CarPaintChange;
			this.BpActor = null;
		}
	}
}
