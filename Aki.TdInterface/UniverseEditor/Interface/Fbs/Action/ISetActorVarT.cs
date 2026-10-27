using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F91 RID: 28561
	public class ISetActorVarT
	{
		// Token: 0x1700D421 RID: 54305
		// (get) Token: 0x0603279D RID: 206749 RVA: 0x006D050A File Offset: 0x006CE70A
		// (set) Token: 0x0603279E RID: 206750 RVA: 0x006D0512 File Offset: 0x006CE712
		public IActorRefT ActorRef { get; set; }

		// Token: 0x1700D422 RID: 54306
		// (get) Token: 0x0603279F RID: 206751 RVA: 0x006D051B File Offset: 0x006CE71B
		// (set) Token: 0x060327A0 RID: 206752 RVA: 0x006D0523 File Offset: 0x006CE723
		public string VarLeft { get; set; }

		// Token: 0x1700D423 RID: 54307
		// (get) Token: 0x060327A1 RID: 206753 RVA: 0x006D052C File Offset: 0x006CE72C
		// (set) Token: 0x060327A2 RID: 206754 RVA: 0x006D0534 File Offset: 0x006CE734
		public TVarRefUnion VarRight { get; set; }

		// Token: 0x060327A3 RID: 206755 RVA: 0x006D053D File Offset: 0x006CE73D
		public ISetActorVarT()
		{
			this.ActorRef = null;
			this.VarLeft = null;
			this.VarRight = null;
		}
	}
}
