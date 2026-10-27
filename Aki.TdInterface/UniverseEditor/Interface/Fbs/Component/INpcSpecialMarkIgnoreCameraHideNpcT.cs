using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005654 RID: 22100
	public class INpcSpecialMarkIgnoreCameraHideNpcT
	{
		// Token: 0x1700A3AE RID: 41902
		// (get) Token: 0x06024BD3 RID: 150483 RVA: 0x00511B8E File Offset: 0x0050FD8E
		// (set) Token: 0x06024BD4 RID: 150484 RVA: 0x00511B96 File Offset: 0x0050FD96
		public ESpecialNpcMarkType Type { get; set; }

		// Token: 0x06024BD5 RID: 150485 RVA: 0x00511B9F File Offset: 0x0050FD9F
		public INpcSpecialMarkIgnoreCameraHideNpcT()
		{
			this.Type = ESpecialNpcMarkType.TrafficLight;
		}
	}
}
