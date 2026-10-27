using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A4B RID: 27211
	public class ILongPressInteractStyleConfig_UnionUnion
	{
		// Token: 0x1700C9E4 RID: 51684
		// (get) Token: 0x0602FA4C RID: 195148 RVA: 0x0067C284 File Offset: 0x0067A484
		// (set) Token: 0x0602FA4D RID: 195149 RVA: 0x0067C28C File Offset: 0x0067A48C
		public ILongPressInteractStyleConfig_Union Type { get; set; }

		// Token: 0x1700C9E5 RID: 51685
		// (get) Token: 0x0602FA4E RID: 195150 RVA: 0x0067C295 File Offset: 0x0067A495
		// (set) Token: 0x0602FA4F RID: 195151 RVA: 0x0067C29D File Offset: 0x0067A49D
		public object Value { get; set; }

		// Token: 0x0602FA50 RID: 195152 RVA: 0x0067C2A6 File Offset: 0x0067A4A6
		public ILongPressInteractStyleConfig_UnionUnion()
		{
			this.Type = ILongPressInteractStyleConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FA51 RID: 195153 RVA: 0x0067C2BC File Offset: 0x0067A4BC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FA52 RID: 195154 RVA: 0x0067C2CE File Offset: 0x0067A4CE
		public ILongPressInteractStyleConfigT AsILongPressInteractStyleConfig()
		{
			return this.As<ILongPressInteractStyleConfigT>();
		}

		// Token: 0x0602FA53 RID: 195155 RVA: 0x0067C2D6 File Offset: 0x0067A4D6
		public static ILongPressInteractStyleConfig_UnionUnion FromILongPressInteractStyleConfig(ILongPressInteractStyleConfigT _ilongpressinteractstyleconfig)
		{
			return new ILongPressInteractStyleConfig_UnionUnion
			{
				Type = ILongPressInteractStyleConfig_Union.ILongPressInteractStyleConfig,
				Value = _ilongpressinteractstyleconfig
			};
		}

		// Token: 0x0602FA54 RID: 195156 RVA: 0x0067C2EB File Offset: 0x0067A4EB
		public ILongPressInteractStyleConfigDefaultT AsILongPressInteractStyleConfigDefault()
		{
			return this.As<ILongPressInteractStyleConfigDefaultT>();
		}

		// Token: 0x0602FA55 RID: 195157 RVA: 0x0067C2F3 File Offset: 0x0067A4F3
		public static ILongPressInteractStyleConfig_UnionUnion FromILongPressInteractStyleConfigDefault(ILongPressInteractStyleConfigDefaultT _ilongpressinteractstyleconfigdefault)
		{
			return new ILongPressInteractStyleConfig_UnionUnion
			{
				Type = ILongPressInteractStyleConfig_Union.ILongPressInteractStyleConfigDefault,
				Value = _ilongpressinteractstyleconfigdefault
			};
		}

		// Token: 0x0602FA56 RID: 195158 RVA: 0x0067C308 File Offset: 0x0067A508
		public ILongPressInteractStyleConfigTimeBackInteractT AsILongPressInteractStyleConfigTimeBackInteract()
		{
			return this.As<ILongPressInteractStyleConfigTimeBackInteractT>();
		}

		// Token: 0x0602FA57 RID: 195159 RVA: 0x0067C310 File Offset: 0x0067A510
		public static ILongPressInteractStyleConfig_UnionUnion FromILongPressInteractStyleConfigTimeBackInteract(ILongPressInteractStyleConfigTimeBackInteractT _ilongpressinteractstyleconfigtimebackinteract)
		{
			return new ILongPressInteractStyleConfig_UnionUnion
			{
				Type = ILongPressInteractStyleConfig_Union.ILongPressInteractStyleConfigTimeBackInteract,
				Value = _ilongpressinteractstyleconfigtimebackinteract
			};
		}

		// Token: 0x0602FA58 RID: 195160 RVA: 0x0067C325 File Offset: 0x0067A525
		public ILongPressInteractStyleSwordRiderT AsILongPressInteractStyleSwordRider()
		{
			return this.As<ILongPressInteractStyleSwordRiderT>();
		}

		// Token: 0x0602FA59 RID: 195161 RVA: 0x0067C32D File Offset: 0x0067A52D
		public static ILongPressInteractStyleConfig_UnionUnion FromILongPressInteractStyleSwordRider(ILongPressInteractStyleSwordRiderT _ilongpressinteractstyleswordrider)
		{
			return new ILongPressInteractStyleConfig_UnionUnion
			{
				Type = ILongPressInteractStyleConfig_Union.ILongPressInteractStyleSwordRider,
				Value = _ilongpressinteractstyleswordrider
			};
		}

		// Token: 0x0602FA5A RID: 195162 RVA: 0x0067C342 File Offset: 0x0067A542
		public ILongPressInteractStyleCoreFixT AsILongPressInteractStyleCoreFix()
		{
			return this.As<ILongPressInteractStyleCoreFixT>();
		}

		// Token: 0x0602FA5B RID: 195163 RVA: 0x0067C34A File Offset: 0x0067A54A
		public static ILongPressInteractStyleConfig_UnionUnion FromILongPressInteractStyleCoreFix(ILongPressInteractStyleCoreFixT _ilongpressinteractstylecorefix)
		{
			return new ILongPressInteractStyleConfig_UnionUnion
			{
				Type = ILongPressInteractStyleConfig_Union.ILongPressInteractStyleCoreFix,
				Value = _ilongpressinteractstylecorefix
			};
		}

		// Token: 0x0602FA5C RID: 195164 RVA: 0x0067C360 File Offset: 0x0067A560
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
