using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200524E RID: 21070
	public class TPlayerAttributeUnion
	{
		// Token: 0x1700968A RID: 38538
		// (get) Token: 0x060212D1 RID: 135889 RVA: 0x00494554 File Offset: 0x00492754
		// (set) Token: 0x060212D2 RID: 135890 RVA: 0x0049455C File Offset: 0x0049275C
		public TPlayerAttribute Type { get; set; }

		// Token: 0x1700968B RID: 38539
		// (get) Token: 0x060212D3 RID: 135891 RVA: 0x00494565 File Offset: 0x00492765
		// (set) Token: 0x060212D4 RID: 135892 RVA: 0x0049456D File Offset: 0x0049276D
		public object Value { get; set; }

		// Token: 0x060212D5 RID: 135893 RVA: 0x00494576 File Offset: 0x00492776
		public TPlayerAttributeUnion()
		{
			this.Type = TPlayerAttribute.NONE;
			this.Value = null;
		}

		// Token: 0x060212D6 RID: 135894 RVA: 0x0049458C File Offset: 0x0049278C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060212D7 RID: 135895 RVA: 0x0049459E File Offset: 0x0049279E
		public IHealthAttributeT AsIHealthAttribute()
		{
			return this.As<IHealthAttributeT>();
		}

		// Token: 0x060212D8 RID: 135896 RVA: 0x004945A6 File Offset: 0x004927A6
		public static TPlayerAttributeUnion FromIHealthAttribute(IHealthAttributeT _ihealthattribute)
		{
			return new TPlayerAttributeUnion
			{
				Type = TPlayerAttribute.IHealthAttribute,
				Value = _ihealthattribute
			};
		}

		// Token: 0x060212D9 RID: 135897 RVA: 0x004945BB File Offset: 0x004927BB
		public IStabilityPointAttributeT AsIStabilityPointAttribute()
		{
			return this.As<IStabilityPointAttributeT>();
		}

		// Token: 0x060212DA RID: 135898 RVA: 0x004945C3 File Offset: 0x004927C3
		public static TPlayerAttributeUnion FromIStabilityPointAttribute(IStabilityPointAttributeT _istabilitypointattribute)
		{
			return new TPlayerAttributeUnion
			{
				Type = TPlayerAttribute.IStabilityPointAttribute,
				Value = _istabilitypointattribute
			};
		}

		// Token: 0x060212DB RID: 135899 RVA: 0x004945D8 File Offset: 0x004927D8
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
