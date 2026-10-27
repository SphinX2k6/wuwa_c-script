using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062B2 RID: 25266
	public class ICarPaintChangeBpActorFuncT
	{
		// Token: 0x1700BC9D RID: 48285
		// (get) Token: 0x0602BA99 RID: 178841 RVA: 0x006028DF File Offset: 0x00600ADF
		// (set) Token: 0x0602BA9A RID: 178842 RVA: 0x006028E7 File Offset: 0x00600AE7
		public EBpActorFuncType Type { get; set; }

		// Token: 0x1700BC9E RID: 48286
		// (get) Token: 0x0602BA9B RID: 178843 RVA: 0x006028F0 File Offset: 0x00600AF0
		// (set) Token: 0x0602BA9C RID: 178844 RVA: 0x006028F8 File Offset: 0x00600AF8
		public IActorRefT BpActor { get; set; }

		// Token: 0x0602BA9D RID: 178845 RVA: 0x00602901 File Offset: 0x00600B01
		public ICarPaintChangeBpActorFuncT()
		{
			this.Type = EBpActorFuncType.CarPaintChange;
			this.BpActor = null;
		}
	}
}
