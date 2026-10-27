using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A2A RID: 27178
	public class ILimitPlayerOption_UnionUnion
	{
		// Token: 0x1700C998 RID: 51608
		// (get) Token: 0x0602F8EE RID: 194798 RVA: 0x0067968D File Offset: 0x0067788D
		// (set) Token: 0x0602F8EF RID: 194799 RVA: 0x00679695 File Offset: 0x00677895
		public ILimitPlayerOption_Union Type { get; set; }

		// Token: 0x1700C999 RID: 51609
		// (get) Token: 0x0602F8F0 RID: 194800 RVA: 0x0067969E File Offset: 0x0067789E
		// (set) Token: 0x0602F8F1 RID: 194801 RVA: 0x006796A6 File Offset: 0x006778A6
		public object Value { get; set; }

		// Token: 0x0602F8F2 RID: 194802 RVA: 0x006796AF File Offset: 0x006778AF
		public ILimitPlayerOption_UnionUnion()
		{
			this.Type = ILimitPlayerOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F8F3 RID: 194803 RVA: 0x006796C5 File Offset: 0x006778C5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F8F4 RID: 194804 RVA: 0x006796D7 File Offset: 0x006778D7
		public ILimitPlayerOptionT AsILimitPlayerOption()
		{
			return this.As<ILimitPlayerOptionT>();
		}

		// Token: 0x0602F8F5 RID: 194805 RVA: 0x006796DF File Offset: 0x006778DF
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerOption(ILimitPlayerOptionT _ilimitplayeroption)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerOption,
				Value = _ilimitplayeroption
			};
		}

		// Token: 0x0602F8F6 RID: 194806 RVA: 0x006796F4 File Offset: 0x006778F4
		public ILimitPlayerMoveT AsILimitPlayerMove()
		{
			return this.As<ILimitPlayerMoveT>();
		}

		// Token: 0x0602F8F7 RID: 194807 RVA: 0x006796FC File Offset: 0x006778FC
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerMove(ILimitPlayerMoveT _ilimitplayermove)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerMove,
				Value = _ilimitplayermove
			};
		}

		// Token: 0x0602F8F8 RID: 194808 RVA: 0x00679711 File Offset: 0x00677911
		public ILimitPlayerActionT AsILimitPlayerAction()
		{
			return this.As<ILimitPlayerActionT>();
		}

		// Token: 0x0602F8F9 RID: 194809 RVA: 0x00679719 File Offset: 0x00677919
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerAction(ILimitPlayerActionT _ilimitplayeraction)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerAction,
				Value = _ilimitplayeraction
			};
		}

		// Token: 0x0602F8FA RID: 194810 RVA: 0x0067972E File Offset: 0x0067792E
		public ILimitPlayerCameraT AsILimitPlayerCamera()
		{
			return this.As<ILimitPlayerCameraT>();
		}

		// Token: 0x0602F8FB RID: 194811 RVA: 0x00679736 File Offset: 0x00677936
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerCamera(ILimitPlayerCameraT _ilimitplayercamera)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerCamera,
				Value = _ilimitplayercamera
			};
		}

		// Token: 0x0602F8FC RID: 194812 RVA: 0x0067974B File Offset: 0x0067794B
		public ILimitPlayerMouseT AsILimitPlayerMouse()
		{
			return this.As<ILimitPlayerMouseT>();
		}

		// Token: 0x0602F8FD RID: 194813 RVA: 0x00679753 File Offset: 0x00677953
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerMouse(ILimitPlayerMouseT _ilimitplayermouse)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerMouse,
				Value = _ilimitplayermouse
			};
		}

		// Token: 0x0602F8FE RID: 194814 RVA: 0x00679768 File Offset: 0x00677968
		public ILimitPlayerMoveNewT AsILimitPlayerMoveNew()
		{
			return this.As<ILimitPlayerMoveNewT>();
		}

		// Token: 0x0602F8FF RID: 194815 RVA: 0x00679770 File Offset: 0x00677970
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerMoveNew(ILimitPlayerMoveNewT _ilimitplayermovenew)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerMoveNew,
				Value = _ilimitplayermovenew
			};
		}

		// Token: 0x0602F900 RID: 194816 RVA: 0x00679785 File Offset: 0x00677985
		public ILimitPlayerUIT AsILimitPlayerUI()
		{
			return this.As<ILimitPlayerUIT>();
		}

		// Token: 0x0602F901 RID: 194817 RVA: 0x0067978D File Offset: 0x0067798D
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerUI(ILimitPlayerUIT _ilimitplayerui)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerUI,
				Value = _ilimitplayerui
			};
		}

		// Token: 0x0602F902 RID: 194818 RVA: 0x006797A2 File Offset: 0x006779A2
		public ILimitPlayerBlockAllT AsILimitPlayerBlockAll()
		{
			return this.As<ILimitPlayerBlockAllT>();
		}

		// Token: 0x0602F903 RID: 194819 RVA: 0x006797AA File Offset: 0x006779AA
		public static ILimitPlayerOption_UnionUnion FromILimitPlayerBlockAll(ILimitPlayerBlockAllT _ilimitplayerblockall)
		{
			return new ILimitPlayerOption_UnionUnion
			{
				Type = ILimitPlayerOption_Union.ILimitPlayerBlockAll,
				Value = _ilimitplayerblockall
			};
		}

		// Token: 0x0602F904 RID: 194820 RVA: 0x006797C0 File Offset: 0x006779C0
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
