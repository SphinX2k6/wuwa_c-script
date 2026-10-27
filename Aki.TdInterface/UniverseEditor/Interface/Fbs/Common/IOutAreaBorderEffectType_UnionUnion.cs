using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E1C RID: 24092
	public class IOutAreaBorderEffectType_UnionUnion
	{
		// Token: 0x1700B43D RID: 46141
		// (get) Token: 0x060293F0 RID: 168944 RVA: 0x005A8581 File Offset: 0x005A6781
		// (set) Token: 0x060293F1 RID: 168945 RVA: 0x005A8589 File Offset: 0x005A6789
		public IOutAreaBorderEffectType_Union Type { get; set; }

		// Token: 0x1700B43E RID: 46142
		// (get) Token: 0x060293F2 RID: 168946 RVA: 0x005A8592 File Offset: 0x005A6792
		// (set) Token: 0x060293F3 RID: 168947 RVA: 0x005A859A File Offset: 0x005A679A
		public object Value { get; set; }

		// Token: 0x060293F4 RID: 168948 RVA: 0x005A85A3 File Offset: 0x005A67A3
		public IOutAreaBorderEffectType_UnionUnion()
		{
			this.Type = IOutAreaBorderEffectType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060293F5 RID: 168949 RVA: 0x005A85B9 File Offset: 0x005A67B9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060293F6 RID: 168950 RVA: 0x005A85CB File Offset: 0x005A67CB
		public IOutAreaBorderEffectTypeT AsIOutAreaBorderEffectType()
		{
			return this.As<IOutAreaBorderEffectTypeT>();
		}

		// Token: 0x060293F7 RID: 168951 RVA: 0x005A85D3 File Offset: 0x005A67D3
		public static IOutAreaBorderEffectType_UnionUnion FromIOutAreaBorderEffectType(IOutAreaBorderEffectTypeT _ioutareabordereffecttype)
		{
			return new IOutAreaBorderEffectType_UnionUnion
			{
				Type = IOutAreaBorderEffectType_Union.IOutAreaBorderEffectType,
				Value = _ioutareabordereffecttype
			};
		}

		// Token: 0x060293F8 RID: 168952 RVA: 0x005A85E8 File Offset: 0x005A67E8
		public IOutAreaBorderBuffEffectT AsIOutAreaBorderBuffEffect()
		{
			return this.As<IOutAreaBorderBuffEffectT>();
		}

		// Token: 0x060293F9 RID: 168953 RVA: 0x005A85F0 File Offset: 0x005A67F0
		public static IOutAreaBorderEffectType_UnionUnion FromIOutAreaBorderBuffEffect(IOutAreaBorderBuffEffectT _ioutareaborderbuffeffect)
		{
			return new IOutAreaBorderEffectType_UnionUnion
			{
				Type = IOutAreaBorderEffectType_Union.IOutAreaBorderBuffEffect,
				Value = _ioutareaborderbuffeffect
			};
		}

		// Token: 0x060293FA RID: 168954 RVA: 0x005A8608 File Offset: 0x005A6808
		public static int Pack(FlatBufferBuilder builder, IOutAreaBorderEffectType_UnionUnion _o)
		{
			IOutAreaBorderEffectType_Union type = _o.Type;
			if (type == IOutAreaBorderEffectType_Union.IOutAreaBorderEffectType)
			{
				return IOutAreaBorderEffectType.Pack(builder, _o.AsIOutAreaBorderEffectType()).Value;
			}
			if (type != IOutAreaBorderEffectType_Union.IOutAreaBorderBuffEffect)
			{
				return 0;
			}
			return IOutAreaBorderBuffEffect.Pack(builder, _o.AsIOutAreaBorderBuffEffect()).Value;
		}
	}
}
