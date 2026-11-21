using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006459 RID: 25689
	public class IOutAreaBorderEffectType_UnionUnion
	{
		// Token: 0x1700BDA3 RID: 48547
		// (get) Token: 0x0602BA7A RID: 178810 RVA: 0x005F12B1 File Offset: 0x005EF4B1
		// (set) Token: 0x0602BA7B RID: 178811 RVA: 0x005F12B9 File Offset: 0x005EF4B9
		public IOutAreaBorderEffectType_Union Type { get; set; }

		// Token: 0x1700BDA4 RID: 48548
		// (get) Token: 0x0602BA7C RID: 178812 RVA: 0x005F12C2 File Offset: 0x005EF4C2
		// (set) Token: 0x0602BA7D RID: 178813 RVA: 0x005F12CA File Offset: 0x005EF4CA
		public object Value { get; set; }

		// Token: 0x0602BA7E RID: 178814 RVA: 0x005F12D3 File Offset: 0x005EF4D3
		public IOutAreaBorderEffectType_UnionUnion()
		{
			this.Type = IOutAreaBorderEffectType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BA7F RID: 178815 RVA: 0x005F12E9 File Offset: 0x005EF4E9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BA80 RID: 178816 RVA: 0x005F12FB File Offset: 0x005EF4FB
		public IOutAreaBorderEffectTypeT AsIOutAreaBorderEffectType()
		{
			return this.As<IOutAreaBorderEffectTypeT>();
		}

		// Token: 0x0602BA81 RID: 178817 RVA: 0x005F1303 File Offset: 0x005EF503
		public static IOutAreaBorderEffectType_UnionUnion FromIOutAreaBorderEffectType(IOutAreaBorderEffectTypeT _ioutareabordereffecttype)
		{
			return new IOutAreaBorderEffectType_UnionUnion
			{
				Type = IOutAreaBorderEffectType_Union.IOutAreaBorderEffectType,
				Value = _ioutareabordereffecttype
			};
		}

		// Token: 0x0602BA82 RID: 178818 RVA: 0x005F1318 File Offset: 0x005EF518
		public IOutAreaBorderBuffEffectT AsIOutAreaBorderBuffEffect()
		{
			return this.As<IOutAreaBorderBuffEffectT>();
		}

		// Token: 0x0602BA83 RID: 178819 RVA: 0x005F1320 File Offset: 0x005EF520
		public static IOutAreaBorderEffectType_UnionUnion FromIOutAreaBorderBuffEffect(IOutAreaBorderBuffEffectT _ioutareaborderbuffeffect)
		{
			return new IOutAreaBorderEffectType_UnionUnion
			{
				Type = IOutAreaBorderEffectType_Union.IOutAreaBorderBuffEffect,
				Value = _ioutareaborderbuffeffect
			};
		}

		// Token: 0x0602BA84 RID: 178820 RVA: 0x005F1338 File Offset: 0x005EF538
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
