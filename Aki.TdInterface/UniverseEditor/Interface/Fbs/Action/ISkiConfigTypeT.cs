using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007122 RID: 28962
	public class ISkiConfigTypeT
	{
		// Token: 0x1700D74D RID: 55117
		// (get) Token: 0x060335A7 RID: 210343 RVA: 0x006EC1F3 File Offset: 0x006EA3F3
		// (set) Token: 0x060335A8 RID: 210344 RVA: 0x006EC1FB File Offset: 0x006EA3FB
		public ESkiConfig Type { get; set; }

		// Token: 0x1700D74E RID: 55118
		// (get) Token: 0x060335A9 RID: 210345 RVA: 0x006EC204 File Offset: 0x006EA404
		// (set) Token: 0x060335AA RID: 210346 RVA: 0x006EC20C File Offset: 0x006EA40C
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x060335AB RID: 210347 RVA: 0x006EC215 File Offset: 0x006EA415
		public ISkiConfigTypeT()
		{
			this.Type = ESkiConfig.Open;
			this.Target = null;
		}
	}
}
