using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007757 RID: 30551
	public class ISetActorVarT
	{
		// Token: 0x1700DFF0 RID: 57328
		// (get) Token: 0x060359ED RID: 219629 RVA: 0x0072FEC2 File Offset: 0x0072E0C2
		// (set) Token: 0x060359EE RID: 219630 RVA: 0x0072FECA File Offset: 0x0072E0CA
		public IActorRefT ActorRef { get; set; }

		// Token: 0x1700DFF1 RID: 57329
		// (get) Token: 0x060359EF RID: 219631 RVA: 0x0072FED3 File Offset: 0x0072E0D3
		// (set) Token: 0x060359F0 RID: 219632 RVA: 0x0072FEDB File Offset: 0x0072E0DB
		public string VarLeft { get; set; }

		// Token: 0x1700DFF2 RID: 57330
		// (get) Token: 0x060359F1 RID: 219633 RVA: 0x0072FEE4 File Offset: 0x0072E0E4
		// (set) Token: 0x060359F2 RID: 219634 RVA: 0x0072FEEC File Offset: 0x0072E0EC
		public TVarRefUnion VarRight { get; set; }

		// Token: 0x060359F3 RID: 219635 RVA: 0x0072FEF5 File Offset: 0x0072E0F5
		public ISetActorVarT()
		{
			this.ActorRef = null;
			this.VarLeft = null;
			this.VarRight = null;
		}
	}
}
