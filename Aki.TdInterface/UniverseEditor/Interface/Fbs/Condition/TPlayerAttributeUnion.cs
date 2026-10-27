using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D52 RID: 19794
	public class TPlayerAttributeUnion
	{
		// Token: 0x17008F51 RID: 36689
		// (get) Token: 0x0601F688 RID: 128648 RVA: 0x00460580 File Offset: 0x0045E780
		// (set) Token: 0x0601F689 RID: 128649 RVA: 0x00460588 File Offset: 0x0045E788
		public TPlayerAttribute Type { get; set; }

		// Token: 0x17008F52 RID: 36690
		// (get) Token: 0x0601F68A RID: 128650 RVA: 0x00460591 File Offset: 0x0045E791
		// (set) Token: 0x0601F68B RID: 128651 RVA: 0x00460599 File Offset: 0x0045E799
		public object Value { get; set; }

		// Token: 0x0601F68C RID: 128652 RVA: 0x004605A2 File Offset: 0x0045E7A2
		public TPlayerAttributeUnion()
		{
			this.Type = TPlayerAttribute.NONE;
			this.Value = null;
		}

		// Token: 0x0601F68D RID: 128653 RVA: 0x004605B8 File Offset: 0x0045E7B8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F68E RID: 128654 RVA: 0x004605CA File Offset: 0x0045E7CA
		public IHealthAttributeT AsIHealthAttribute()
		{
			return this.As<IHealthAttributeT>();
		}

		// Token: 0x0601F68F RID: 128655 RVA: 0x004605D2 File Offset: 0x0045E7D2
		public static TPlayerAttributeUnion FromIHealthAttribute(IHealthAttributeT _ihealthattribute)
		{
			return new TPlayerAttributeUnion
			{
				Type = TPlayerAttribute.IHealthAttribute,
				Value = _ihealthattribute
			};
		}

		// Token: 0x0601F690 RID: 128656 RVA: 0x004605E7 File Offset: 0x0045E7E7
		public IStabilityPointAttributeT AsIStabilityPointAttribute()
		{
			return this.As<IStabilityPointAttributeT>();
		}

		// Token: 0x0601F691 RID: 128657 RVA: 0x004605EF File Offset: 0x0045E7EF
		public static TPlayerAttributeUnion FromIStabilityPointAttribute(IStabilityPointAttributeT _istabilitypointattribute)
		{
			return new TPlayerAttributeUnion
			{
				Type = TPlayerAttribute.IStabilityPointAttribute,
				Value = _istabilitypointattribute
			};
		}

		// Token: 0x0601F692 RID: 128658 RVA: 0x00460604 File Offset: 0x0045E804
		public static int Pack(FlatBufferBuilder builder, TPlayerAttributeUnion _o)
		{
			TPlayerAttribute type = _o.Type;
			if (type == TPlayerAttribute.IHealthAttribute)
			{
				return IHealthAttribute.Pack(builder, _o.AsIHealthAttribute()).Value;
			}
			if (type != TPlayerAttribute.IStabilityPointAttribute)
			{
				return 0;
			}
			return IStabilityPointAttribute.Pack(builder, _o.AsIStabilityPointAttribute()).Value;
		}
	}
}
