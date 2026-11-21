using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200716D RID: 29037
	public class ILongPressInteractStyleConfig_UnionUnion
	{
		// Token: 0x1700D48F RID: 54415
		// (get) Token: 0x06032772 RID: 206706 RVA: 0x006D2344 File Offset: 0x006D0544
		// (set) Token: 0x06032773 RID: 206707 RVA: 0x006D234C File Offset: 0x006D054C
		public ILongPressInteractStyleConfig_Union Type { get; set; }

		// Token: 0x1700D490 RID: 54416
		// (get) Token: 0x06032774 RID: 206708 RVA: 0x006D2355 File Offset: 0x006D0555
		// (set) Token: 0x06032775 RID: 206709 RVA: 0x006D235D File Offset: 0x006D055D
		public object Value { get; set; }

		// Token: 0x06032776 RID: 206710 RVA: 0x006D2366 File Offset: 0x006D0566
		public ILongPressInteractStyleConfig_UnionUnion()
		{
			this.Type = ILongPressInteractStyleConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032777 RID: 206711 RVA: 0x006D237C File Offset: 0x006D057C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032778 RID: 206712 RVA: 0x006D238E File Offset: 0x006D058E
		public ILongPressInteractStyleConfigT AsILongPressInteractStyleConfig()
		{
			return this.As<ILongPressInteractStyleConfigT>();
		}

		// Token: 0x06032779 RID: 206713 RVA: 0x006D2396 File Offset: 0x006D0596
		public static ILongPressInteractStyleConfig_UnionUnion FromILongPressInteractStyleConfig(ILongPressInteractStyleConfigT _ilongpressinteractstyleconfig)
		{
			return new ILongPressInteractStyleConfig_UnionUnion
			{
				Type = ILongPressInteractStyleConfig_Union.ILongPressInteractStyleConfig,
				Value = _ilongpressinteractstyleconfig
			};
		}

		// Token: 0x0603277A RID: 206714 RVA: 0x006D23AB File Offset: 0x006D05AB
		public ILongPressInteractStyleConfigDefaultT AsILongPressInteractStyleConfigDefault()
		{
			return this.As<ILongPressInteractStyleConfigDefaultT>();
		}

		// Token: 0x0603277B RID: 206715 RVA: 0x006D23B3 File Offset: 0x006D05B3
		public static ILongPressInteractStyleConfig_UnionUnion FromILongPressInteractStyleConfigDefault(ILongPressInteractStyleConfigDefaultT _ilongpressinteractstyleconfigdefault)
		{
			return new ILongPressInteractStyleConfig_UnionUnion
			{
				Type = ILongPressInteractStyleConfig_Union.ILongPressInteractStyleConfigDefault,
				Value = _ilongpressinteractstyleconfigdefault
			};
		}

		// Token: 0x0603277C RID: 206716 RVA: 0x006D23C8 File Offset: 0x006D05C8
		public ILongPressInteractStyleConfigTimeBackInteractT AsILongPressInteractStyleConfigTimeBackInteract()
		{
			return this.As<ILongPressInteractStyleConfigTimeBackInteractT>();
		}

		// Token: 0x0603277D RID: 206717 RVA: 0x006D23D0 File Offset: 0x006D05D0
		public static ILongPressInteractStyleConfig_UnionUnion FromILongPressInteractStyleConfigTimeBackInteract(ILongPressInteractStyleConfigTimeBackInteractT _ilongpressinteractstyleconfigtimebackinteract)
		{
			return new ILongPressInteractStyleConfig_UnionUnion
			{
				Type = ILongPressInteractStyleConfig_Union.ILongPressInteractStyleConfigTimeBackInteract,
				Value = _ilongpressinteractstyleconfigtimebackinteract
			};
		}

		// Token: 0x0603277E RID: 206718 RVA: 0x006D23E5 File Offset: 0x006D05E5
		public ILongPressInteractStyleSwordRiderT AsILongPressInteractStyleSwordRider()
		{
			return this.As<ILongPressInteractStyleSwordRiderT>();
		}

		// Token: 0x0603277F RID: 206719 RVA: 0x006D23ED File Offset: 0x006D05ED
		public static ILongPressInteractStyleConfig_UnionUnion FromILongPressInteractStyleSwordRider(ILongPressInteractStyleSwordRiderT _ilongpressinteractstyleswordrider)
		{
			return new ILongPressInteractStyleConfig_UnionUnion
			{
				Type = ILongPressInteractStyleConfig_Union.ILongPressInteractStyleSwordRider,
				Value = _ilongpressinteractstyleswordrider
			};
		}

		// Token: 0x06032780 RID: 206720 RVA: 0x006D2402 File Offset: 0x006D0602
		public ILongPressInteractStyleCoreFixT AsILongPressInteractStyleCoreFix()
		{
			return this.As<ILongPressInteractStyleCoreFixT>();
		}

		// Token: 0x06032781 RID: 206721 RVA: 0x006D240A File Offset: 0x006D060A
		public static ILongPressInteractStyleConfig_UnionUnion FromILongPressInteractStyleCoreFix(ILongPressInteractStyleCoreFixT _ilongpressinteractstylecorefix)
		{
			return new ILongPressInteractStyleConfig_UnionUnion
			{
				Type = ILongPressInteractStyleConfig_Union.ILongPressInteractStyleCoreFix,
				Value = _ilongpressinteractstylecorefix
			};
		}

		// Token: 0x06032782 RID: 206722 RVA: 0x006D2420 File Offset: 0x006D0620
		public static int Pack(FlatBufferBuilder builder, ILongPressInteractStyleConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILongPressInteractStyleConfig_Union.ILongPressInteractStyleConfig:
				return ILongPressInteractStyleConfig.Pack(builder, _o.AsILongPressInteractStyleConfig()).Value;
			case ILongPressInteractStyleConfig_Union.ILongPressInteractStyleConfigDefault:
				return ILongPressInteractStyleConfigDefault.Pack(builder, _o.AsILongPressInteractStyleConfigDefault()).Value;
			case ILongPressInteractStyleConfig_Union.ILongPressInteractStyleConfigTimeBackInteract:
				return ILongPressInteractStyleConfigTimeBackInteract.Pack(builder, _o.AsILongPressInteractStyleConfigTimeBackInteract()).Value;
			case ILongPressInteractStyleConfig_Union.ILongPressInteractStyleSwordRider:
				return ILongPressInteractStyleSwordRider.Pack(builder, _o.AsILongPressInteractStyleSwordRider()).Value;
			case ILongPressInteractStyleConfig_Union.ILongPressInteractStyleCoreFix:
				return ILongPressInteractStyleCoreFix.Pack(builder, _o.AsILongPressInteractStyleCoreFix()).Value;
			default:
				return 0;
			}
		}
	}
}
