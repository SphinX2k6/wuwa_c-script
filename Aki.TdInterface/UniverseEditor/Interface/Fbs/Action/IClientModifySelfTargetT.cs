using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063D4 RID: 25556
	public class IClientModifySelfTargetT
	{
		// Token: 0x1700BE64 RID: 48740
		// (get) Token: 0x0602C351 RID: 181073 RVA: 0x00611962 File Offset: 0x0060FB62
		// (set) Token: 0x0602C352 RID: 181074 RVA: 0x0061196A File Offset: 0x0060FB6A
		public EClientModifyTargetType Type { get; set; }

		// Token: 0x0602C353 RID: 181075 RVA: 0x00611973 File Offset: 0x0060FB73
		public IClientModifySelfTargetT()
		{
			this.Type = EClientModifyTargetType.Self;
		}
	}
}
