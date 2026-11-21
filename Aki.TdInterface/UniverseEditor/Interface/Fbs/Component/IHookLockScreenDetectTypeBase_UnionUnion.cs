using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005955 RID: 22869
	public class IHookLockScreenDetectTypeBase_UnionUnion
	{
		// Token: 0x1700A616 RID: 42518
		// (get) Token: 0x06025411 RID: 152593 RVA: 0x0051D5D5 File Offset: 0x0051B7D5
		// (set) Token: 0x06025412 RID: 152594 RVA: 0x0051D5DD File Offset: 0x0051B7DD
		public IHookLockScreenDetectTypeBase_Union Type { get; set; }

		// Token: 0x1700A617 RID: 42519
		// (get) Token: 0x06025413 RID: 152595 RVA: 0x0051D5E6 File Offset: 0x0051B7E6
		// (set) Token: 0x06025414 RID: 152596 RVA: 0x0051D5EE File Offset: 0x0051B7EE
		public object Value { get; set; }

		// Token: 0x06025415 RID: 152597 RVA: 0x0051D5F7 File Offset: 0x0051B7F7
		public IHookLockScreenDetectTypeBase_UnionUnion()
		{
			this.Type = IHookLockScreenDetectTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025416 RID: 152598 RVA: 0x0051D60D File Offset: 0x0051B80D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025417 RID: 152599 RVA: 0x0051D61F File Offset: 0x0051B81F
		public IHookLockScreenDetectTypeBaseT AsIHookLockScreenDetectTypeBase()
		{
			return this.As<IHookLockScreenDetectTypeBaseT>();
		}

		// Token: 0x06025418 RID: 152600 RVA: 0x0051D627 File Offset: 0x0051B827
		public static IHookLockScreenDetectTypeBase_UnionUnion FromIHookLockScreenDetectTypeBase(IHookLockScreenDetectTypeBaseT _ihooklockscreendetecttypebase)
		{
			return new IHookLockScreenDetectTypeBase_UnionUnion
			{
				Type = IHookLockScreenDetectTypeBase_Union.IHookLockScreenDetectTypeBase,
				Value = _ihooklockscreendetecttypebase
			};
		}

		// Token: 0x06025419 RID: 152601 RVA: 0x0051D63C File Offset: 0x0051B83C
		public IHookLockScreenDetectTypeCentralEllipseT AsIHookLockScreenDetectTypeCentralEllipse()
		{
			return this.As<IHookLockScreenDetectTypeCentralEllipseT>();
		}

		// Token: 0x0602541A RID: 152602 RVA: 0x0051D644 File Offset: 0x0051B844
		public static IHookLockScreenDetectTypeBase_UnionUnion FromIHookLockScreenDetectTypeCentralEllipse(IHookLockScreenDetectTypeCentralEllipseT _ihooklockscreendetecttypecentralellipse)
		{
			return new IHookLockScreenDetectTypeBase_UnionUnion
			{
				Type = IHookLockScreenDetectTypeBase_Union.IHookLockScreenDetectTypeCentralEllipse,
				Value = _ihooklockscreendetecttypecentralellipse
			};
		}

		// Token: 0x0602541B RID: 152603 RVA: 0x0051D659 File Offset: 0x0051B859
		public IHookLockScreenDetectTypeFullScreenT AsIHookLockScreenDetectTypeFullScreen()
		{
			return this.As<IHookLockScreenDetectTypeFullScreenT>();
		}

		// Token: 0x0602541C RID: 152604 RVA: 0x0051D661 File Offset: 0x0051B861
		public static IHookLockScreenDetectTypeBase_UnionUnion FromIHookLockScreenDetectTypeFullScreen(IHookLockScreenDetectTypeFullScreenT _ihooklockscreendetecttypefullscreen)
		{
			return new IHookLockScreenDetectTypeBase_UnionUnion
			{
				Type = IHookLockScreenDetectTypeBase_Union.IHookLockScreenDetectTypeFullScreen,
				Value = _ihooklockscreendetecttypefullscreen
			};
		}

		// Token: 0x0602541D RID: 152605 RVA: 0x0051D678 File Offset: 0x0051B878
		public static int Pack(FlatBufferBuilder builder, IHookLockScreenDetectTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IHookLockScreenDetectTypeBase_Union.IHookLockScreenDetectTypeBase:
				return IHookLockScreenDetectTypeBase.Pack(builder, _o.AsIHookLockScreenDetectTypeBase()).Value;
			case IHookLockScreenDetectTypeBase_Union.IHookLockScreenDetectTypeCentralEllipse:
				return IHookLockScreenDetectTypeCentralEllipse.Pack(builder, _o.AsIHookLockScreenDetectTypeCentralEllipse()).Value;
			case IHookLockScreenDetectTypeBase_Union.IHookLockScreenDetectTypeFullScreen:
				return IHookLockScreenDetectTypeFullScreen.Pack(builder, _o.AsIHookLockScreenDetectTypeFullScreen()).Value;
			default:
				return 0;
			}
		}
	}
}
