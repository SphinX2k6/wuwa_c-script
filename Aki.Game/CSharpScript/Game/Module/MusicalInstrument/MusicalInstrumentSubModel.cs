using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200537B RID: 21371
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class MusicalInstrumentSubModel
	{
		// Token: 0x06036975 RID: 223605
		public new abstract EInstrumentType GetType();

		// Token: 0x06036976 RID: 223606
		public abstract void OnRegister();

		// Token: 0x06036977 RID: 223607
		public abstract void OnClear();

		// Token: 0x06036978 RID: 223608 RVA: 0x00CECE47 File Offset: 0x00CEB047
		public MusicalInstrumentQteData GetQteData()
		{
			return this.QteData;
		}

		// Token: 0x06036979 RID: 223609 RVA: 0x00CECE4F File Offset: 0x00CEB04F
		[NullableContext(1)]
		public void SetQteData(MusicalInstrumentQteData data)
		{
			this.QteData = data;
		}

		// Token: 0x0603697A RID: 223610 RVA: 0x00CECE58 File Offset: 0x00CEB058
		public void ClearQteData()
		{
			this.QteData = null;
		}

		// Token: 0x0401CDAB RID: 118187
		private MusicalInstrumentQteData QteData;

		// Token: 0x0401CDAC RID: 118188
		public bool IsInputRestricted;
	}
}
