using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F31 RID: 32561
	public class TLongPressInteractStyleConfigUnion
	{
		// Token: 0x1700F299 RID: 62105
		// (get) Token: 0x0603ABB1 RID: 240561 RVA: 0x007E5C8A File Offset: 0x007E3E8A
		// (set) Token: 0x0603ABB2 RID: 240562 RVA: 0x007E5C92 File Offset: 0x007E3E92
		public TLongPressInteractStyleConfig Type { get; set; }

		// Token: 0x1700F29A RID: 62106
		// (get) Token: 0x0603ABB3 RID: 240563 RVA: 0x007E5C9B File Offset: 0x007E3E9B
		// (set) Token: 0x0603ABB4 RID: 240564 RVA: 0x007E5CA3 File Offset: 0x007E3EA3
		public object Value { get; set; }

		// Token: 0x0603ABB5 RID: 240565 RVA: 0x007E5CAC File Offset: 0x007E3EAC
		public TLongPressInteractStyleConfigUnion()
		{
			this.Type = TLongPressInteractStyleConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603ABB6 RID: 240566 RVA: 0x007E5CC2 File Offset: 0x007E3EC2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ABB7 RID: 240567 RVA: 0x007E5CD4 File Offset: 0x007E3ED4
		public ILongPressInteractStyleConfigDefaultT AsILongPressInteractStyleConfigDefault()
		{
			return this.As<ILongPressInteractStyleConfigDefaultT>();
		}

		// Token: 0x0603ABB8 RID: 240568 RVA: 0x007E5CDC File Offset: 0x007E3EDC
		public static TLongPressInteractStyleConfigUnion FromILongPressInteractStyleConfigDefault(ILongPressInteractStyleConfigDefaultT _ilongpressinteractstyleconfigdefault)
		{
			return new TLongPressInteractStyleConfigUnion
			{
				Type = TLongPressInteractStyleConfig.ILongPressInteractStyleConfigDefault,
				Value = _ilongpressinteractstyleconfigdefault
			};
		}

		// Token: 0x0603ABB9 RID: 240569 RVA: 0x007E5CF1 File Offset: 0x007E3EF1
		public ILongPressInteractStyleConfigTimeBackInteractT AsILongPressInteractStyleConfigTimeBackInteract()
		{
			return this.As<ILongPressInteractStyleConfigTimeBackInteractT>();
		}

		// Token: 0x0603ABBA RID: 240570 RVA: 0x007E5CF9 File Offset: 0x007E3EF9
		public static TLongPressInteractStyleConfigUnion FromILongPressInteractStyleConfigTimeBackInteract(ILongPressInteractStyleConfigTimeBackInteractT _ilongpressinteractstyleconfigtimebackinteract)
		{
			return new TLongPressInteractStyleConfigUnion
			{
				Type = TLongPressInteractStyleConfig.ILongPressInteractStyleConfigTimeBackInteract,
				Value = _ilongpressinteractstyleconfigtimebackinteract
			};
		}

		// Token: 0x0603ABBB RID: 240571 RVA: 0x007E5D0E File Offset: 0x007E3F0E
		public ILongPressInteractStyleCoreFixT AsILongPressInteractStyleCoreFix()
		{
			return this.As<ILongPressInteractStyleCoreFixT>();
		}

		// Token: 0x0603ABBC RID: 240572 RVA: 0x007E5D16 File Offset: 0x007E3F16
		public static TLongPressInteractStyleConfigUnion FromILongPressInteractStyleCoreFix(ILongPressInteractStyleCoreFixT _ilongpressinteractstylecorefix)
		{
			return new TLongPressInteractStyleConfigUnion
			{
				Type = TLongPressInteractStyleConfig.ILongPressInteractStyleCoreFix,
				Value = _ilongpressinteractstylecorefix
			};
		}

		// Token: 0x0603ABBD RID: 240573 RVA: 0x007E5D2B File Offset: 0x007E3F2B
		public ILongPressInteractStyleSwordRiderT AsILongPressInteractStyleSwordRider()
		{
			return this.As<ILongPressInteractStyleSwordRiderT>();
		}

		// Token: 0x0603ABBE RID: 240574 RVA: 0x007E5D33 File Offset: 0x007E3F33
		public static TLongPressInteractStyleConfigUnion FromILongPressInteractStyleSwordRider(ILongPressInteractStyleSwordRiderT _ilongpressinteractstyleswordrider)
		{
			return new TLongPressInteractStyleConfigUnion
			{
				Type = TLongPressInteractStyleConfig.ILongPressInteractStyleSwordRider,
				Value = _ilongpressinteractstyleswordrider
			};
		}

		// Token: 0x0603ABBF RID: 240575 RVA: 0x007E5D48 File Offset: 0x007E3F48
		public static int Pack(FlatBufferBuilder builder, TLongPressInteractStyleConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TLongPressInteractStyleConfig.ILongPressInteractStyleConfigDefault:
				return ILongPressInteractStyleConfigDefault.Pack(builder, _o.AsILongPressInteractStyleConfigDefault()).Value;
			case TLongPressInteractStyleConfig.ILongPressInteractStyleConfigTimeBackInteract:
				return ILongPressInteractStyleConfigTimeBackInteract.Pack(builder, _o.AsILongPressInteractStyleConfigTimeBackInteract()).Value;
			case TLongPressInteractStyleConfig.ILongPressInteractStyleCoreFix:
				return ILongPressInteractStyleCoreFix.Pack(builder, _o.AsILongPressInteractStyleCoreFix()).Value;
			case TLongPressInteractStyleConfig.ILongPressInteractStyleSwordRider:
				return ILongPressInteractStyleSwordRider.Pack(builder, _o.AsILongPressInteractStyleSwordRider()).Value;
			default:
				return 0;
			}
		}
	}
}
