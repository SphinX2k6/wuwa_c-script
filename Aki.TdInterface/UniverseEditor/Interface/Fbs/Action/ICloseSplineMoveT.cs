using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AAB RID: 27307
	public class ICloseSplineMoveT
	{
		// Token: 0x1700C895 RID: 51349
		// (get) Token: 0x0602EDF9 RID: 191993 RVA: 0x006630F9 File Offset: 0x006612F9
		// (set) Token: 0x0602EDFA RID: 191994 RVA: 0x00663101 File Offset: 0x00661301
		public ESplineMoveConfigType Type { get; set; }

		// Token: 0x1700C896 RID: 51350
		// (get) Token: 0x0602EDFB RID: 191995 RVA: 0x0066310A File Offset: 0x0066130A
		// (set) Token: 0x0602EDFC RID: 191996 RVA: 0x00663112 File Offset: 0x00661312
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700C897 RID: 51351
		// (get) Token: 0x0602EDFD RID: 191997 RVA: 0x0066311B File Offset: 0x0066131B
		// (set) Token: 0x0602EDFE RID: 191998 RVA: 0x00663123 File Offset: 0x00661323
		public int SplineEntityId { get; set; }

		// Token: 0x0602EDFF RID: 191999 RVA: 0x0066312C File Offset: 0x0066132C
		public ICloseSplineMoveT()
		{
			this.Type = ESplineMoveConfigType.Open;
			this.Target = null;
			this.SplineEntityId = 0;
		}
	}
}
