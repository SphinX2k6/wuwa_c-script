using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006710 RID: 26384
	public class IActorFxEmoteOverrideConfigT
	{
		// Token: 0x1700BFCA RID: 49098
		// (get) Token: 0x0602CAE5 RID: 183013 RVA: 0x0061D10D File Offset: 0x0061B30D
		// (set) Token: 0x0602CAE6 RID: 183014 RVA: 0x0061D115 File Offset: 0x0061B315
		public string SocketName { get; set; }

		// Token: 0x1700BFCB RID: 49099
		// (get) Token: 0x0602CAE7 RID: 183015 RVA: 0x0061D11E File Offset: 0x0061B31E
		// (set) Token: 0x0602CAE8 RID: 183016 RVA: 0x0061D126 File Offset: 0x0061B326
		public IVectorInfoT RelativePosition { get; set; }

		// Token: 0x1700BFCC RID: 49100
		// (get) Token: 0x0602CAE9 RID: 183017 RVA: 0x0061D12F File Offset: 0x0061B32F
		// (set) Token: 0x0602CAEA RID: 183018 RVA: 0x0061D137 File Offset: 0x0061B337
		public IVectorInfoT RelativeRotation { get; set; }

		// Token: 0x1700BFCD RID: 49101
		// (get) Token: 0x0602CAEB RID: 183019 RVA: 0x0061D140 File Offset: 0x0061B340
		// (set) Token: 0x0602CAEC RID: 183020 RVA: 0x0061D148 File Offset: 0x0061B348
		public IVectorInfoT Scale { get; set; }

		// Token: 0x0602CAED RID: 183021 RVA: 0x0061D151 File Offset: 0x0061B351
		public IActorFxEmoteOverrideConfigT()
		{
			this.SocketName = null;
			this.RelativePosition = null;
			this.RelativeRotation = null;
			this.Scale = null;
		}
	}
}
