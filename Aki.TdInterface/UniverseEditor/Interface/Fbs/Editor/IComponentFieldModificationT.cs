using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CA4 RID: 19620
	public class IComponentFieldModificationT
	{
		// Token: 0x17008AFF RID: 35583
		// (get) Token: 0x0601E16C RID: 123244 RVA: 0x0043742A File Offset: 0x0043562A
		// (set) Token: 0x0601E16D RID: 123245 RVA: 0x00437432 File Offset: 0x00435632
		public bool Enable { get; set; }

		// Token: 0x17008B00 RID: 35584
		// (get) Token: 0x0601E16E RID: 123246 RVA: 0x0043743B File Offset: 0x0043563B
		// (set) Token: 0x0601E16F RID: 123247 RVA: 0x00437443 File Offset: 0x00435643
		public EComponent Type { get; set; }

		// Token: 0x17008B01 RID: 35585
		// (get) Token: 0x0601E170 RID: 123248 RVA: 0x0043744C File Offset: 0x0043564C
		// (set) Token: 0x0601E171 RID: 123249 RVA: 0x00437454 File Offset: 0x00435654
		public string Field { get; set; }

		// Token: 0x17008B02 RID: 35586
		// (get) Token: 0x0601E172 RID: 123250 RVA: 0x0043745D File Offset: 0x0043565D
		// (set) Token: 0x0601E173 RID: 123251 RVA: 0x00437465 File Offset: 0x00435665
		public string Value { get; set; }

		// Token: 0x0601E174 RID: 123252 RVA: 0x0043746E File Offset: 0x0043566E
		public IComponentFieldModificationT()
		{
			this.Enable = false;
			this.Type = EComponent.AirWallSpawnerComponent;
			this.Field = null;
			this.Value = null;
		}
	}
}
