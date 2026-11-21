using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070DA RID: 28890
	public class ILimitPlayerOption_UnionUnion
	{
		// Token: 0x1700D398 RID: 54168
		// (get) Token: 0x060322AE RID: 205486 RVA: 0x006C99E5 File Offset: 0x006C7BE5
		// (set) Token: 0x060322AF RID: 205487 RVA: 0x006C99ED File Offset: 0x006C7BED
		public ILimitPlayerOption_Union Type { get; set; }

		// Token: 0x1700D399 RID: 54169
		// (get) Token: 0x060322B0 RID: 205488 RVA: 0x006C99F6 File Offset: 0x006C7BF6
		// (set) Token: 0x060322B1 RID: 205489 RVA: 0x006C99FE File Offset: 0x006C7BFE
		public object Value { get; set; }

		// Token: 0x060322B2 RID: 205490 RVA: 0x006C9A07 File Offset: 0x006C7C07
		public ILimitPlayerOption_UnionUnion()
		{
			this.Type = ILimitPlayerOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060322B3 RID: 205491 RVA: 0x006C9A1D File Offset: 0x006C7C1D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060322B4 RID: 205492 RVA: 0x006C9A2F File Offset: 0x006C7C2F
		public ILimitPlayerOptionT AsILimitPlayerOption()
		{
			return this.As<ILimitPlayerOptionT>();
		}

		// Token: 0x060322B5 RID: 205493 RVA: 0x006C9A37 File Offset: 0x006C7C37
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerOption(ILimitPlayerOptionT _ilimitplayeroption)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerOption,
				Value = _ilimitplayeroption
			};
		}

		// Token: 0x060322B6 RID: 205494 RVA: 0x006C9A4C File Offset: 0x006C7C4C
		public ILimitPlayerMoveT AsILimitPlayerMove()
		{
			return this.As<ILimitPlayerMoveT>();
		}

		// Token: 0x060322B7 RID: 205495 RVA: 0x006C9A54 File Offset: 0x006C7C54
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerMove(ILimitPlayerMoveT _ilimitplayermove)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerMove,
				Value = _ilimitplayermove
			};
		}

		// Token: 0x060322B8 RID: 205496 RVA: 0x006C9A69 File Offset: 0x006C7C69
		public ILimitPlayerActionT AsILimitPlayerAction()
		{
			return this.As<ILimitPlayerActionT>();
		}

		// Token: 0x060322B9 RID: 205497 RVA: 0x006C9A71 File Offset: 0x006C7C71
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerAction(ILimitPlayerActionT _ilimitplayeraction)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerAction,
				Value = _ilimitplayeraction
			};
		}

		// Token: 0x060322BA RID: 205498 RVA: 0x006C9A86 File Offset: 0x006C7C86
		public ILimitPlayerCameraT AsILimitPlayerCamera()
		{
			return this.As<ILimitPlayerCameraT>();
		}

		// Token: 0x060322BB RID: 205499 RVA: 0x006C9A8E File Offset: 0x006C7C8E
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerCamera(ILimitPlayerCameraT _ilimitplayercamera)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerCamera,
				Value = _ilimitplayercamera
			};
		}

		// Token: 0x060322BC RID: 205500 RVA: 0x006C9AA3 File Offset: 0x006C7CA3
		public ILimitPlayerMouseT AsILimitPlayerMouse()
		{
			return this.As<ILimitPlayerMouseT>();
		}

		// Token: 0x060322BD RID: 205501 RVA: 0x006C9AAB File Offset: 0x006C7CAB
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerMouse(ILimitPlayerMouseT _ilimitplayermouse)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerMouse,
				Value = _ilimitplayermouse
			};
		}

		// Token: 0x060322BE RID: 205502 RVA: 0x006C9AC0 File Offset: 0x006C7CC0
		public ILimitPlayerMoveNewT AsILimitPlayerMoveNew()
		{
			return this.As<ILimitPlayerMoveNewT>();
		}

		// Token: 0x060322BF RID: 205503 RVA: 0x006C9AC8 File Offset: 0x006C7CC8
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerMoveNew(ILimitPlayerMoveNewT _ilimitplayermovenew)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerMoveNew,
				Value = _ilimitplayermovenew
			};
		}

		// Token: 0x060322C0 RID: 205504 RVA: 0x006C9ADD File Offset: 0x006C7CDD
		public ILimitPlayerUIT AsILimitPlayerUI()
		{
			return this.As<ILimitPlayerUIT>();
		}

		// Token: 0x060322C1 RID: 205505 RVA: 0x006C9AE5 File Offset: 0x006C7CE5
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerUI(ILimitPlayerUIT _ilimitplayerui)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerUI,
				Value = _ilimitplayerui
			};
		}

		// Token: 0x060322C2 RID: 205506 RVA: 0x006C9AFA File Offset: 0x006C7CFA
		public ILimitPlayerBlockAllT AsILimitPlayerBlockAll()
		{
			return this.As<ILimitPlayerBlockAllT>();
		}

		// Token: 0x060322C3 RID: 205507 RVA: 0x006C9B02 File Offset: 0x006C7D02
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerBlockAll(ILimitPlayerBlockAllT _ilimitplayerblockall)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerBlockAll,
				Value = _ilimitplayerblockall
			};
		}

		// Token: 0x060322C4 RID: 205508 RVA: 0x006C9B18 File Offset: 0x006C7D18
		public static int Pack(FlatBufferBuilder builder, ILimitPlayerOption_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILimitPlayerOption_Union.ILimitPlayerOption:
				return ILimitPlayerOption.Pack(builder, _o.AsILimitPlayerOption()).Value;
			case ILimitPlayerOption_Union.ILimitPlayerMove:
				return ILimitPlayerMove.Pack(builder, _o.AsILimitPlayerMove()).Value;
			case ILimitPlayerOption_Union.ILimitPlayerAction:
				return ILimitPlayerAction.Pack(builder, _o.AsILimitPlayerAction()).Value;
			case ILimitPlayerOption_Union.ILimitPlayerCamera:
				return ILimitPlayerCamera.Pack(builder, _o.AsILimitPlayerCamera()).Value;
			case ILimitPlayerOption_Union.ILimitPlayerMouse:
				return ILimitPlayerMouse.Pack(builder, _o.AsILimitPlayerMouse()).Value;
			case ILimitPlayerOption_Union.ILimitPlayerMoveNew:
				return ILimitPlayerMoveNew.Pack(builder, _o.AsILimitPlayerMoveNew()).Value;
			case ILimitPlayerOption_Union.ILimitPlayerUI:
				return ILimitPlayerUI.Pack(builder, _o.AsILimitPlayerUI()).Value;
			case ILimitPlayerOption_Union.ILimitPlayerBlockAll:
				return ILimitPlayerBlockAll.Pack(builder, _o.AsILimitPlayerBlockAll()).Value;
			default:
				return 0;
			}
		}
	}
}
