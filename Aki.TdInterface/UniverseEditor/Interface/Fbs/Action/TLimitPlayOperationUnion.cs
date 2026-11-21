using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F1F RID: 32543
	public class TLimitPlayOperationUnion
	{
		// Token: 0x1700F28D RID: 62093
		// (get) Token: 0x0603AB4B RID: 240459 RVA: 0x007E528E File Offset: 0x007E348E
		// (set) Token: 0x0603AB4C RID: 240460 RVA: 0x007E5296 File Offset: 0x007E3496
		public TLimitPlayOperation Type { get; set; }

		// Token: 0x1700F28E RID: 62094
		// (get) Token: 0x0603AB4D RID: 240461 RVA: 0x007E529F File Offset: 0x007E349F
		// (set) Token: 0x0603AB4E RID: 240462 RVA: 0x007E52A7 File Offset: 0x007E34A7
		public object Value { get; set; }

		// Token: 0x0603AB4F RID: 240463 RVA: 0x007E52B0 File Offset: 0x007E34B0
		public TLimitPlayOperationUnion()
		{
			this.Type = TLimitPlayOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0603AB50 RID: 240464 RVA: 0x007E52C6 File Offset: 0x007E34C6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AB51 RID: 240465 RVA: 0x007E52D8 File Offset: 0x007E34D8
		public ILimitPlayerActionT AsILimitPlayerAction()
		{
			return this.As<ILimitPlayerActionT>();
		}

		// Token: 0x0603AB52 RID: 240466 RVA: 0x007E52E0 File Offset: 0x007E34E0
		public static TLimitPlayOperationUnion FromILimitPlayerAction(ILimitPlayerActionT _ilimitplayeraction)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerAction,
				Value = _ilimitplayeraction
			};
		}

		// Token: 0x0603AB53 RID: 240467 RVA: 0x007E52F5 File Offset: 0x007E34F5
		public ILimitPlayerBlockAllT AsILimitPlayerBlockAll()
		{
			return this.As<ILimitPlayerBlockAllT>();
		}

		// Token: 0x0603AB54 RID: 240468 RVA: 0x007E52FD File Offset: 0x007E34FD
		public static TLimitPlayOperationUnion FromILimitPlayerBlockAll(ILimitPlayerBlockAllT _ilimitplayerblockall)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerBlockAll,
				Value = _ilimitplayerblockall
			};
		}

		// Token: 0x0603AB55 RID: 240469 RVA: 0x007E5312 File Offset: 0x007E3512
		public ILimitPlayerCameraT AsILimitPlayerCamera()
		{
			return this.As<ILimitPlayerCameraT>();
		}

		// Token: 0x0603AB56 RID: 240470 RVA: 0x007E531A File Offset: 0x007E351A
		public static TLimitPlayOperationUnion FromILimitPlayerCamera(ILimitPlayerCameraT _ilimitplayercamera)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerCamera,
				Value = _ilimitplayercamera
			};
		}

		// Token: 0x0603AB57 RID: 240471 RVA: 0x007E532F File Offset: 0x007E352F
		public ILimitPlayerMouseT AsILimitPlayerMouse()
		{
			return this.As<ILimitPlayerMouseT>();
		}

		// Token: 0x0603AB58 RID: 240472 RVA: 0x007E5337 File Offset: 0x007E3537
		public static TLimitPlayOperationUnion FromILimitPlayerMouse(ILimitPlayerMouseT _ilimitplayermouse)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerMouse,
				Value = _ilimitplayermouse
			};
		}

		// Token: 0x0603AB59 RID: 240473 RVA: 0x007E534C File Offset: 0x007E354C
		public ILimitPlayerMoveT AsILimitPlayerMove()
		{
			return this.As<ILimitPlayerMoveT>();
		}

		// Token: 0x0603AB5A RID: 240474 RVA: 0x007E5354 File Offset: 0x007E3554
		public static TLimitPlayOperationUnion FromILimitPlayerMove(ILimitPlayerMoveT _ilimitplayermove)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerMove,
				Value = _ilimitplayermove
			};
		}

		// Token: 0x0603AB5B RID: 240475 RVA: 0x007E5369 File Offset: 0x007E3569
		public ILimitPlayerMoveNewT AsILimitPlayerMoveNew()
		{
			return this.As<ILimitPlayerMoveNewT>();
		}

		// Token: 0x0603AB5C RID: 240476 RVA: 0x007E5371 File Offset: 0x007E3571
		public static TLimitPlayOperationUnion FromILimitPlayerMoveNew(ILimitPlayerMoveNewT _ilimitplayermovenew)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerMoveNew,
				Value = _ilimitplayermovenew
			};
		}

		// Token: 0x0603AB5D RID: 240477 RVA: 0x007E5386 File Offset: 0x007E3586
		public ILimitPlayerUIT AsILimitPlayerUI()
		{
			return this.As<ILimitPlayerUIT>();
		}

		// Token: 0x0603AB5E RID: 240478 RVA: 0x007E538E File Offset: 0x007E358E
		public static TLimitPlayOperationUnion FromILimitPlayerUI(ILimitPlayerUIT _ilimitplayerui)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerUI,
				Value = _ilimitplayerui
			};
		}

		// Token: 0x0603AB5F RID: 240479 RVA: 0x007E53A4 File Offset: 0x007E35A4
		public static int Pack(FlatBufferBuilder builder, TLimitPlayOperationUnion _o)
		{
			switch (_o.Type)
			{
			case TLimitPlayOperation.ILimitPlayerAction:
				return ILimitPlayerAction.Pack(builder, _o.AsILimitPlayerAction()).Value;
			case TLimitPlayOperation.ILimitPlayerBlockAll:
				return ILimitPlayerBlockAll.Pack(builder, _o.AsILimitPlayerBlockAll()).Value;
			case TLimitPlayOperation.ILimitPlayerCamera:
				return ILimitPlayerCamera.Pack(builder, _o.AsILimitPlayerCamera()).Value;
			case TLimitPlayOperation.ILimitPlayerMouse:
				return ILimitPlayerMouse.Pack(builder, _o.AsILimitPlayerMouse()).Value;
			case TLimitPlayOperation.ILimitPlayerMove:
				return ILimitPlayerMove.Pack(builder, _o.AsILimitPlayerMove()).Value;
			case TLimitPlayOperation.ILimitPlayerMoveNew:
				return ILimitPlayerMoveNew.Pack(builder, _o.AsILimitPlayerMoveNew()).Value;
			case TLimitPlayOperation.ILimitPlayerUI:
				return ILimitPlayerUI.Pack(builder, _o.AsILimitPlayerUI()).Value;
			default:
				return 0;
			}
		}
	}
}
