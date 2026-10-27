using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200770E RID: 30478
	public class TLongPressInteractStyleConfigUnion
	{
		// Token: 0x1700E64D RID: 58957
		// (get) Token: 0x06037694 RID: 226964 RVA: 0x00780FD0 File Offset: 0x0077F1D0
		// (set) Token: 0x06037695 RID: 226965 RVA: 0x00780FD8 File Offset: 0x0077F1D8
		public TLongPressInteractStyleConfig Type { get; set; }

		// Token: 0x1700E64E RID: 58958
		// (get) Token: 0x06037696 RID: 226966 RVA: 0x00780FE1 File Offset: 0x0077F1E1
		// (set) Token: 0x06037697 RID: 226967 RVA: 0x00780FE9 File Offset: 0x0077F1E9
		public object Value { get; set; }

		// Token: 0x06037698 RID: 226968 RVA: 0x00780FF2 File Offset: 0x0077F1F2
		public TLongPressInteractStyleConfigUnion()
		{
			this.Type = TLongPressInteractStyleConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06037699 RID: 226969 RVA: 0x00781008 File Offset: 0x0077F208
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603769A RID: 226970 RVA: 0x0078101A File Offset: 0x0077F21A
		public ILongPressInteractStyleConfigDefaultT AsILongPressInteractStyleConfigDefault()
		{
			return this.As<ILongPressInteractStyleConfigDefaultT>();
		}

		// Token: 0x0603769B RID: 226971 RVA: 0x00781022 File Offset: 0x0077F222
		public static TLongPressInteractStyleConfigUnion FromILongPressInteractStyleConfigDefault(ILongPressInteractStyleConfigDefaultT _ilongpressinteractstyleconfigdefault)
		{
			return new TLongPressInteractStyleConfigUnion
			{
				Type = TLongPressInteractStyleConfig.ILongPressInteractStyleConfigDefault,
				Value = _ilongpressinteractstyleconfigdefault
			};
		}

		// Token: 0x0603769C RID: 226972 RVA: 0x00781037 File Offset: 0x0077F237
		public ILongPressInteractStyleConfigTimeBackInteractT AsILongPressInteractStyleConfigTimeBackInteract()
		{
			return this.As<ILongPressInteractStyleConfigTimeBackInteractT>();
		}

		// Token: 0x0603769D RID: 226973 RVA: 0x0078103F File Offset: 0x0077F23F
		public static TLongPressInteractStyleConfigUnion FromILongPressInteractStyleConfigTimeBackInteract(ILongPressInteractStyleConfigTimeBackInteractT _ilongpressinteractstyleconfigtimebackinteract)
		{
			return new TLongPressInteractStyleConfigUnion
			{
				Type = TLongPressInteractStyleConfig.ILongPressInteractStyleConfigTimeBackInteract,
				Value = _ilongpressinteractstyleconfigtimebackinteract
			};
		}

		// Token: 0x0603769E RID: 226974 RVA: 0x00781054 File Offset: 0x0077F254
		public ILongPressInteractStyleCoreFixT AsILongPressInteractStyleCoreFix()
		{
			return this.As<ILongPressInteractStyleCoreFixT>();
		}

		// Token: 0x0603769F RID: 226975 RVA: 0x0078105C File Offset: 0x0077F25C
		public static TLongPressInteractStyleConfigUnion FromILongPressInteractStyleCoreFix(ILongPressInteractStyleCoreFixT _ilongpressinteractstylecorefix)
		{
			return new TLongPressInteractStyleConfigUnion
			{
				Type = TLongPressInteractStyleConfig.ILongPressInteractStyleCoreFix,
				Value = _ilongpressinteractstylecorefix
			};
		}

		// Token: 0x060376A0 RID: 226976 RVA: 0x00781071 File Offset: 0x0077F271
		public ILongPressInteractStyleSwordRiderT AsILongPressInteractStyleSwordRider()
		{
			return this.As<ILongPressInteractStyleSwordRiderT>();
		}

		// Token: 0x060376A1 RID: 226977 RVA: 0x00781079 File Offset: 0x0077F279
		public static TLongPressInteractStyleConfigUnion FromILongPressInteractStyleSwordRider(ILongPressInteractStyleSwordRiderT _ilongpressinteractstyleswordrider)
		{
			return new TLongPressInteractStyleConfigUnion
			{
				Type = TLongPressInteractStyleConfig.ILongPressInteractStyleSwordRider,
				Value = _ilongpressinteractstyleswordrider
			};
		}

		// Token: 0x060376A2 RID: 226978 RVA: 0x00781090 File Offset: 0x0077F290
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
