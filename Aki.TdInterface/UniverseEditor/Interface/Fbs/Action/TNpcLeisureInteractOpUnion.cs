using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F64 RID: 32612
	public class TNpcLeisureInteractOpUnion
	{
		// Token: 0x1700F2BB RID: 62139
		// (get) Token: 0x0603AC9B RID: 240795 RVA: 0x007E717A File Offset: 0x007E537A
		// (set) Token: 0x0603AC9C RID: 240796 RVA: 0x007E7182 File Offset: 0x007E5382
		public TNpcLeisureInteractOp Type { get; set; }

		// Token: 0x1700F2BC RID: 62140
		// (get) Token: 0x0603AC9D RID: 240797 RVA: 0x007E718B File Offset: 0x007E538B
		// (set) Token: 0x0603AC9E RID: 240798 RVA: 0x007E7193 File Offset: 0x007E5393
		public object Value { get; set; }

		// Token: 0x0603AC9F RID: 240799 RVA: 0x007E719C File Offset: 0x007E539C
		public TNpcLeisureInteractOpUnion()
		{
			this.Type = TNpcLeisureInteractOp.NONE;
			this.Value = null;
		}

		// Token: 0x0603ACA0 RID: 240800 RVA: 0x007E71B2 File Offset: 0x007E53B2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ACA1 RID: 240801 RVA: 0x007E71C4 File Offset: 0x007E53C4
		public INpcExitCurrentInteractT AsINpcExitCurrentInteract()
		{
			return this.As<INpcExitCurrentInteractT>();
		}

		// Token: 0x0603ACA2 RID: 240802 RVA: 0x007E71CC File Offset: 0x007E53CC
		public static TNpcLeisureInteractOpUnion FromINpcExitCurrentInteract(INpcExitCurrentInteractT _inpcexitcurrentinteract)
		{
			return new TNpcLeisureInteractOpUnion
			{
				Type = TNpcLeisureInteractOp.INpcExitCurrentInteract,
				Value = _inpcexitcurrentinteract
			};
		}

		// Token: 0x0603ACA3 RID: 240803 RVA: 0x007E71E1 File Offset: 0x007E53E1
		public INpcSitDownT AsINpcSitDown()
		{
			return this.As<INpcSitDownT>();
		}

		// Token: 0x0603ACA4 RID: 240804 RVA: 0x007E71E9 File Offset: 0x007E53E9
		public static TNpcLeisureInteractOpUnion FromINpcSitDown(INpcSitDownT _inpcsitdown)
		{
			return new TNpcLeisureInteractOpUnion
			{
				Type = TNpcLeisureInteractOp.INpcSitDown,
				Value = _inpcsitdown
			};
		}

		// Token: 0x0603ACA5 RID: 240805 RVA: 0x007E71FE File Offset: 0x007E53FE
		public INpcSwingT AsINpcSwing()
		{
			return this.As<INpcSwingT>();
		}

		// Token: 0x0603ACA6 RID: 240806 RVA: 0x007E7206 File Offset: 0x007E5406
		public static TNpcLeisureInteractOpUnion FromINpcSwing(INpcSwingT _inpcswing)
		{
			return new TNpcLeisureInteractOpUnion
			{
				Type = TNpcLeisureInteractOp.INpcSwing,
				Value = _inpcswing
			};
		}

		// Token: 0x0603ACA7 RID: 240807 RVA: 0x007E721B File Offset: 0x007E541B
		public INpcSwingGetUpT AsINpcSwingGetUp()
		{
			return this.As<INpcSwingGetUpT>();
		}

		// Token: 0x0603ACA8 RID: 240808 RVA: 0x007E7223 File Offset: 0x007E5423
		public static TNpcLeisureInteractOpUnion FromINpcSwingGetUp(INpcSwingGetUpT _inpcswinggetup)
		{
			return new TNpcLeisureInteractOpUnion
			{
				Type = TNpcLeisureInteractOp.INpcSwingGetUp,
				Value = _inpcswinggetup
			};
		}

		// Token: 0x0603ACA9 RID: 240809 RVA: 0x007E7238 File Offset: 0x007E5438
		public static int Pack(FlatBufferBuilder builder, TNpcLeisureInteractOpUnion _o)
		{
			switch (_o.Type)
			{
			case TNpcLeisureInteractOp.INpcExitCurrentInteract:
				return INpcExitCurrentInteract.Pack(builder, _o.AsINpcExitCurrentInteract()).Value;
			case TNpcLeisureInteractOp.INpcSitDown:
				return INpcSitDown.Pack(builder, _o.AsINpcSitDown()).Value;
			case TNpcLeisureInteractOp.INpcSwing:
				return INpcSwing.Pack(builder, _o.AsINpcSwing()).Value;
			case TNpcLeisureInteractOp.INpcSwingGetUp:
				return INpcSwingGetUp.Pack(builder, _o.AsINpcSwingGetUp()).Value;
			default:
				return 0;
			}
		}
	}
}
