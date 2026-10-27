using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053CF RID: 21455
	public class IHookLockScreenDetectTypeBase_UnionUnion
	{
		// Token: 0x17009DDC RID: 40412
		// (get) Token: 0x06023359 RID: 144217 RVA: 0x004E05A9 File Offset: 0x004DE7A9
		// (set) Token: 0x0602335A RID: 144218 RVA: 0x004E05B1 File Offset: 0x004DE7B1
		public IHookLockScreenDetectTypeBase_Union Type { get; set; }

		// Token: 0x17009DDD RID: 40413
		// (get) Token: 0x0602335B RID: 144219 RVA: 0x004E05BA File Offset: 0x004DE7BA
		// (set) Token: 0x0602335C RID: 144220 RVA: 0x004E05C2 File Offset: 0x004DE7C2
		public object Value { get; set; }

		// Token: 0x0602335D RID: 144221 RVA: 0x004E05CB File Offset: 0x004DE7CB
		public IHookLockScreenDetectTypeBase_UnionUnion()
		{
			this.Type = IHookLockScreenDetectTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602335E RID: 144222 RVA: 0x004E05E1 File Offset: 0x004DE7E1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602335F RID: 144223 RVA: 0x004E05F3 File Offset: 0x004DE7F3
		public IHookLockScreenDetectTypeBaseT AsIHookLockScreenDetectTypeBase()
		{
			return this.As<IHookLockScreenDetectTypeBaseT>();
		}

		// Token: 0x06023360 RID: 144224 RVA: 0x004E05FB File Offset: 0x004DE7FB
		public static IHookLockScreenDetectTypeBase_UnionUnion FromIHookLockScreenDetectTypeBase(IHookLockScreenDetectTypeBaseT _ihooklockscreendetecttypebase)
		{
			return new IHookLockScreenDetectTypeBase_UnionUnion
			{
				Type = IHookLockScreenDetectTypeBase_Union.IHookLockScreenDetectTypeBase,
				Value = _ihooklockscreendetecttypebase
			};
		}

		// Token: 0x06023361 RID: 144225 RVA: 0x004E0610 File Offset: 0x004DE810
		public IHookLockScreenDetectTypeCentralEllipseT AsIHookLockScreenDetectTypeCentralEllipse()
		{
			return this.As<IHookLockScreenDetectTypeCentralEllipseT>();
		}

		// Token: 0x06023362 RID: 144226 RVA: 0x004E0618 File Offset: 0x004DE818
		public static IHookLockScreenDetectTypeBase_UnionUnion FromIHookLockScreenDetectTypeCentralEllipse(IHookLockScreenDetectTypeCentralEllipseT _ihooklockscreendetecttypecentralellipse)
		{
			return new IHookLockScreenDetectTypeBase_UnionUnion
			{
				Type = IHookLockScreenDetectTypeBase_Union.IHookLockScreenDetectTypeCentralEllipse,
				Value = _ihooklockscreendetecttypecentralellipse
			};
		}

		// Token: 0x06023363 RID: 144227 RVA: 0x004E062D File Offset: 0x004DE82D
		public IHookLockScreenDetectTypeFullScreenT AsIHookLockScreenDetectTypeFullScreen()
		{
			return this.As<IHookLockScreenDetectTypeFullScreenT>();
		}

		// Token: 0x06023364 RID: 144228 RVA: 0x004E0635 File Offset: 0x004DE835
		public static IHookLockScreenDetectTypeBase_UnionUnion FromIHookLockScreenDetectTypeFullScreen(IHookLockScreenDetectTypeFullScreenT _ihooklockscreendetecttypefullscreen)
		{
			return new IHookLockScreenDetectTypeBase_UnionUnion
			{
				Type = IHookLockScreenDetectTypeBase_Union.IHookLockScreenDetectTypeFullScreen,
				Value = _ihooklockscreendetecttypefullscreen
			};
		}

		// Token: 0x06023365 RID: 144229 RVA: 0x004E064C File Offset: 0x004DE84C
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
