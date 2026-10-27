using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200773B RID: 30523
	public class TNpcLeisureInteractOpUnion
	{
		// Token: 0x1700E66B RID: 58987
		// (get) Token: 0x06037760 RID: 227168 RVA: 0x007821EA File Offset: 0x007803EA
		// (set) Token: 0x06037761 RID: 227169 RVA: 0x007821F2 File Offset: 0x007803F2
		public TNpcLeisureInteractOp Type { get; set; }

		// Token: 0x1700E66C RID: 58988
		// (get) Token: 0x06037762 RID: 227170 RVA: 0x007821FB File Offset: 0x007803FB
		// (set) Token: 0x06037763 RID: 227171 RVA: 0x00782203 File Offset: 0x00780403
		public object Value { get; set; }

		// Token: 0x06037764 RID: 227172 RVA: 0x0078220C File Offset: 0x0078040C
		public TNpcLeisureInteractOpUnion()
		{
			this.Type = TNpcLeisureInteractOp.NONE;
			this.Value = null;
		}

		// Token: 0x06037765 RID: 227173 RVA: 0x00782222 File Offset: 0x00780422
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037766 RID: 227174 RVA: 0x00782234 File Offset: 0x00780434
		public INpcExitCurrentInteractT AsINpcExitCurrentInteract()
		{
			return this.As<INpcExitCurrentInteractT>();
		}

		// Token: 0x06037767 RID: 227175 RVA: 0x0078223C File Offset: 0x0078043C
		public static TNpcLeisureInteractOpUnion FromINpcExitCurrentInteract(INpcExitCurrentInteractT _inpcexitcurrentinteract)
		{
			return new TNpcLeisureInteractOpUnion
			{
				Type = TNpcLeisureInteractOp.INpcExitCurrentInteract,
				Value = _inpcexitcurrentinteract
			};
		}

		// Token: 0x06037768 RID: 227176 RVA: 0x00782251 File Offset: 0x00780451
		public INpcSitDownT AsINpcSitDown()
		{
			return this.As<INpcSitDownT>();
		}

		// Token: 0x06037769 RID: 227177 RVA: 0x00782259 File Offset: 0x00780459
		public static TNpcLeisureInteractOpUnion FromINpcSitDown(INpcSitDownT _inpcsitdown)
		{
			return new TNpcLeisureInteractOpUnion
			{
				Type = TNpcLeisureInteractOp.INpcSitDown,
				Value = _inpcsitdown
			};
		}

		// Token: 0x0603776A RID: 227178 RVA: 0x0078226E File Offset: 0x0078046E
		public INpcSwingT AsINpcSwing()
		{
			return this.As<INpcSwingT>();
		}

		// Token: 0x0603776B RID: 227179 RVA: 0x00782276 File Offset: 0x00780476
		public static TNpcLeisureInteractOpUnion FromINpcSwing(INpcSwingT _inpcswing)
		{
			return new TNpcLeisureInteractOpUnion
			{
				Type = TNpcLeisureInteractOp.INpcSwing,
				Value = _inpcswing
			};
		}

		// Token: 0x0603776C RID: 227180 RVA: 0x0078228B File Offset: 0x0078048B
		public INpcSwingGetUpT AsINpcSwingGetUp()
		{
			return this.As<INpcSwingGetUpT>();
		}

		// Token: 0x0603776D RID: 227181 RVA: 0x00782293 File Offset: 0x00780493
		public static TNpcLeisureInteractOpUnion FromINpcSwingGetUp(INpcSwingGetUpT _inpcswinggetup)
		{
			return new TNpcLeisureInteractOpUnion
			{
				Type = TNpcLeisureInteractOp.INpcSwingGetUp,
				Value = _inpcswinggetup
			};
		}

		// Token: 0x0603776E RID: 227182 RVA: 0x007822A8 File Offset: 0x007804A8
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
