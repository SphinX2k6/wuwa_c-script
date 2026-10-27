using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BEA RID: 15338
	public class IActorRefVolumeT
	{
		// Token: 0x1700693B RID: 26939
		// (get) Token: 0x06015175 RID: 86389 RVA: 0x0030E68A File Offset: 0x0030C88A
		// (set) Token: 0x06015176 RID: 86390 RVA: 0x0030E692 File Offset: 0x0030C892
		public ETriggerShape Type { get; set; }

		// Token: 0x06015177 RID: 86391 RVA: 0x0030E69B File Offset: 0x0030C89B
		public IActorRefVolumeT()
		{
			this.Type = ETriggerShape.Box;
		}
	}
}
