using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200770B RID: 30475
	public class TLimitPlayOperationUnion
	{
		// Token: 0x1700E64B RID: 58955
		// (get) Token: 0x0603767E RID: 226942 RVA: 0x00780D82 File Offset: 0x0077EF82
		// (set) Token: 0x0603767F RID: 226943 RVA: 0x00780D8A File Offset: 0x0077EF8A
		public TLimitPlayOperation Type { get; set; }

		// Token: 0x1700E64C RID: 58956
		// (get) Token: 0x06037680 RID: 226944 RVA: 0x00780D93 File Offset: 0x0077EF93
		// (set) Token: 0x06037681 RID: 226945 RVA: 0x00780D9B File Offset: 0x0077EF9B
		public object Value { get; set; }

		// Token: 0x06037682 RID: 226946 RVA: 0x00780DA4 File Offset: 0x0077EFA4
		public TLimitPlayOperationUnion()
		{
			this.Type = TLimitPlayOperation.NONE;
			this.Value = null;
		}

		// Token: 0x06037683 RID: 226947 RVA: 0x00780DBA File Offset: 0x0077EFBA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037684 RID: 226948 RVA: 0x00780DCC File Offset: 0x0077EFCC
		public ILimitPlayerActionT AsILimitPlayerAction()
		{
			return this.As<ILimitPlayerActionT>();
		}

		// Token: 0x06037685 RID: 226949 RVA: 0x00780DD4 File Offset: 0x0077EFD4
		public static TLimitPlayOperationUnion FromILimitPlayerAction(ILimitPlayerActionT _ilimitplayeraction)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerAction,
				Value = _ilimitplayeraction
			};
		}

		// Token: 0x06037686 RID: 226950 RVA: 0x00780DE9 File Offset: 0x0077EFE9
		public ILimitPlayerBlockAllT AsILimitPlayerBlockAll()
		{
			return this.As<ILimitPlayerBlockAllT>();
		}

		// Token: 0x06037687 RID: 226951 RVA: 0x00780DF1 File Offset: 0x0077EFF1
		public static TLimitPlayOperationUnion FromILimitPlayerBlockAll(ILimitPlayerBlockAllT _ilimitplayerblockall)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerBlockAll,
				Value = _ilimitplayerblockall
			};
		}

		// Token: 0x06037688 RID: 226952 RVA: 0x00780E06 File Offset: 0x0077F006
		public ILimitPlayerCameraT AsILimitPlayerCamera()
		{
			return this.As<ILimitPlayerCameraT>();
		}

		// Token: 0x06037689 RID: 226953 RVA: 0x00780E0E File Offset: 0x0077F00E
		public static TLimitPlayOperationUnion FromILimitPlayerCamera(ILimitPlayerCameraT _ilimitplayercamera)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerCamera,
				Value = _ilimitplayercamera
			};
		}

		// Token: 0x0603768A RID: 226954 RVA: 0x00780E23 File Offset: 0x0077F023
		public ILimitPlayerMouseT AsILimitPlayerMouse()
		{
			return this.As<ILimitPlayerMouseT>();
		}

		// Token: 0x0603768B RID: 226955 RVA: 0x00780E2B File Offset: 0x0077F02B
		public static TLimitPlayOperationUnion FromILimitPlayerMouse(ILimitPlayerMouseT _ilimitplayermouse)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerMouse,
				Value = _ilimitplayermouse
			};
		}

		// Token: 0x0603768C RID: 226956 RVA: 0x00780E40 File Offset: 0x0077F040
		public ILimitPlayerMoveT AsILimitPlayerMove()
		{
			return this.As<ILimitPlayerMoveT>();
		}

		// Token: 0x0603768D RID: 226957 RVA: 0x00780E48 File Offset: 0x0077F048
		public static TLimitPlayOperationUnion FromILimitPlayerMove(ILimitPlayerMoveT _ilimitplayermove)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerMove,
				Value = _ilimitplayermove
			};
		}

		// Token: 0x0603768E RID: 226958 RVA: 0x00780E5D File Offset: 0x0077F05D
		public ILimitPlayerMoveNewT AsILimitPlayerMoveNew()
		{
			return this.As<ILimitPlayerMoveNewT>();
		}

		// Token: 0x0603768F RID: 226959 RVA: 0x00780E65 File Offset: 0x0077F065
		public static TLimitPlayOperationUnion FromILimitPlayerMoveNew(ILimitPlayerMoveNewT _ilimitplayermovenew)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerMoveNew,
				Value = _ilimitplayermovenew
			};
		}

		// Token: 0x06037690 RID: 226960 RVA: 0x00780E7A File Offset: 0x0077F07A
		public ILimitPlayerUIT AsILimitPlayerUI()
		{
			return this.As<ILimitPlayerUIT>();
		}

		// Token: 0x06037691 RID: 226961 RVA: 0x00780E82 File Offset: 0x0077F082
		public static TLimitPlayOperationUnion FromILimitPlayerUI(ILimitPlayerUIT _ilimitplayerui)
		{
			return new TLimitPlayOperationUnion
			{
				Type = TLimitPlayOperation.ILimitPlayerUI,
				Value = _ilimitplayerui
			};
		}

		// Token: 0x06037692 RID: 226962 RVA: 0x00780E98 File Offset: 0x0077F098
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
