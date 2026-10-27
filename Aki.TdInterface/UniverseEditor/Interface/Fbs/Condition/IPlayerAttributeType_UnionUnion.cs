using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C89 RID: 19593
	public class IPlayerAttributeType_UnionUnion
	{
		// Token: 0x17008E46 RID: 36422
		// (get) Token: 0x0601F12F RID: 127279 RVA: 0x00457BB9 File Offset: 0x00455DB9
		// (set) Token: 0x0601F130 RID: 127280 RVA: 0x00457BC1 File Offset: 0x00455DC1
		public IPlayerAttributeType_Union Type { get; set; }

		// Token: 0x17008E47 RID: 36423
		// (get) Token: 0x0601F131 RID: 127281 RVA: 0x00457BCA File Offset: 0x00455DCA
		// (set) Token: 0x0601F132 RID: 127282 RVA: 0x00457BD2 File Offset: 0x00455DD2
		public object Value { get; set; }

		// Token: 0x0601F133 RID: 127283 RVA: 0x00457BDB File Offset: 0x00455DDB
		public IPlayerAttributeType_UnionUnion()
		{
			this.Type = IPlayerAttributeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F134 RID: 127284 RVA: 0x00457BF1 File Offset: 0x00455DF1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F135 RID: 127285 RVA: 0x00457C03 File Offset: 0x00455E03
		public IPlayerAttributeTypeT AsIPlayerAttributeType()
		{
			return this.As<IPlayerAttributeTypeT>();
		}

		// Token: 0x0601F136 RID: 127286 RVA: 0x00457C0B File Offset: 0x00455E0B
		public static IPlayerAttributeType_UnionUnion FromIPlayerAttributeType(IPlayerAttributeTypeT _iplayerattributetype)
		{
			return new IPlayerAttributeType_UnionUnion
			{
				Type = IPlayerAttributeType_Union.IPlayerAttributeType,
				Value = _iplayerattributetype
			};
		}

		// Token: 0x0601F137 RID: 127287 RVA: 0x00457C20 File Offset: 0x00455E20
		public IHealthAttributeT AsIHealthAttribute()
		{
			return this.As<IHealthAttributeT>();
		}

		// Token: 0x0601F138 RID: 127288 RVA: 0x00457C28 File Offset: 0x00455E28
		public static IPlayerAttributeType_UnionUnion FromIHealthAttribute(IHealthAttributeT _ihealthattribute)
		{
			return new IPlayerAttributeType_UnionUnion
			{
				Type = IPlayerAttributeType_Union.IHealthAttribute,
				Value = _ihealthattribute
			};
		}

		// Token: 0x0601F139 RID: 127289 RVA: 0x00457C3D File Offset: 0x00455E3D
		public IStabilityPointAttributeT AsIStabilityPointAttribute()
		{
			return this.As<IStabilityPointAttributeT>();
		}

		// Token: 0x0601F13A RID: 127290 RVA: 0x00457C45 File Offset: 0x00455E45
		public static IPlayerAttributeType_UnionUnion FromIStabilityPointAttribute(IStabilityPointAttributeT _istabilitypointattribute)
		{
			return new IPlayerAttributeType_UnionUnion
			{
				Type = IPlayerAttributeType_Union.IStabilityPointAttribute,
				Value = _istabilitypointattribute
			};
		}

		// Token: 0x0601F13B RID: 127291 RVA: 0x00457C5C File Offset: 0x00455E5C
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
