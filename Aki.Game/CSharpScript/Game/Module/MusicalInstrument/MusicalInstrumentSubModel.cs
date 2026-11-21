using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200435E RID: 17246
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class MusicalInstrumentSubModel
	{
		// Token: 0x0602B8BB RID: 178363
		public new abstract EInstrumentType GetType();

		// Token: 0x0602B8BC RID: 178364
		public abstract void OnRegister();

		// Token: 0x0602B8BD RID: 178365
		public abstract void OnClear();

		// Token: 0x0602B8BE RID: 178366 RVA: 0x00C3BD3F File Offset: 0x00C39F3F
		public MusicalInstrumentQteData GetQteData()
		{
			return this.QteData;
		}

		// Token: 0x0602B8BF RID: 178367 RVA: 0x00C3BD47 File Offset: 0x00C39F47
		[NullableContext(1)]
		public void SetQteData(MusicalInstrumentQteData data)
		{
			this.QteData = data;
		}

		// Token: 0x0602B8C0 RID: 178368 RVA: 0x00C3BD50 File Offset: 0x00C39F50
		public void ClearQteData()
		{
			this.QteData = null;
		}

		// Token: 0x04017843 RID: 96323
		private MusicalInstrumentQteData QteData;

		// Token: 0x04017844 RID: 96324
		public bool IsInputRestricted;
	}
}
