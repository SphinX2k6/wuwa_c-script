using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005182 RID: 20866
	public class IPlayerAttributeType_UnionUnion
	{
		// Token: 0x17009574 RID: 38260
		// (get) Token: 0x06020D51 RID: 134481 RVA: 0x0048B709 File Offset: 0x00489909
		// (set) Token: 0x06020D52 RID: 134482 RVA: 0x0048B711 File Offset: 0x00489911
		public IPlayerAttributeType_Union Type { get; set; }

		// Token: 0x17009575 RID: 38261
		// (get) Token: 0x06020D53 RID: 134483 RVA: 0x0048B71A File Offset: 0x0048991A
		// (set) Token: 0x06020D54 RID: 134484 RVA: 0x0048B722 File Offset: 0x00489922
		public object Value { get; set; }

		// Token: 0x06020D55 RID: 134485 RVA: 0x0048B72B File Offset: 0x0048992B
		public IPlayerAttributeType_UnionUnion()
		{
			this.Type = IPlayerAttributeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020D56 RID: 134486 RVA: 0x0048B741 File Offset: 0x00489941
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020D57 RID: 134487 RVA: 0x0048B753 File Offset: 0x00489953
		public IPlayerAttributeTypeT AsIPlayerAttributeType()
		{
			return this.As<IPlayerAttributeTypeT>();
		}

		// Token: 0x06020D58 RID: 134488 RVA: 0x0048B75B File Offset: 0x0048995B
		public static IPlayerAttributeType_UnionUnion FromIPlayerAttributeType(IPlayerAttributeTypeT _iplayerattributetype)
		{
			return new IPlayerAttributeType_UnionUnion
			{
				Type = IPlayerAttributeType_Union.IPlayerAttributeType,
				Value = _iplayerattributetype
			};
		}

		// Token: 0x06020D59 RID: 134489 RVA: 0x0048B770 File Offset: 0x00489970
		public IHealthAttributeT AsIHealthAttribute()
		{
			return this.As<IHealthAttributeT>();
		}

		// Token: 0x06020D5A RID: 134490 RVA: 0x0048B778 File Offset: 0x00489978
		public static IPlayerAttributeType_UnionUnion FromIHealthAttribute(IHealthAttributeT _ihealthattribute)
		{
			return new IPlayerAttributeType_UnionUnion
			{
				Type = IPlayerAttributeType_Union.IHealthAttribute,
				Value = _ihealthattribute
			};
		}

		// Token: 0x06020D5B RID: 134491 RVA: 0x0048B78D File Offset: 0x0048998D
		public IStabilityPointAttributeT AsIStabilityPointAttribute()
		{
			return this.As<IStabilityPointAttributeT>();
		}

		// Token: 0x06020D5C RID: 134492 RVA: 0x0048B795 File Offset: 0x00489995
		public static IPlayerAttributeType_UnionUnion FromIStabilityPointAttribute(IStabilityPointAttributeT _istabilitypointattribute)
		{
			return new IPlayerAttributeType_UnionUnion
			{
				Type = IPlayerAttributeType_Union.IStabilityPointAttribute,
				Value = _istabilitypointattribute
			};
		}

		// Token: 0x06020D5D RID: 134493 RVA: 0x0048B7AC File Offset: 0x004899AC
		public static int Pack(FlatBufferBuilder builder, IPlayerAttributeType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPlayerAttributeType_Union.IPlayerAttributeType:
				return IPlayerAttributeType.Pack(builder, _o.AsIPlayerAttributeType()).Value;
			case IPlayerAttributeType_Union.IHealthAttribute:
				return IHealthAttribute.Pack(builder, _o.AsIHealthAttribute()).Value;
			case IPlayerAttributeType_Union.IStabilityPointAttribute:
				return IStabilityPointAttribute.Pack(builder, _o.AsIStabilityPointAttribute()).Value;
			default:
				return 0;
			}
		}
	}
}
