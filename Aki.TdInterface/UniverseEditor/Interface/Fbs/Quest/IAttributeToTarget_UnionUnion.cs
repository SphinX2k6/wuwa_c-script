using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D26 RID: 15654
	public class IAttributeToTarget_UnionUnion
	{
		// Token: 0x17006B5B RID: 27483
		// (get) Token: 0x060159A3 RID: 88483 RVA: 0x0031E685 File Offset: 0x0031C885
		// (set) Token: 0x060159A4 RID: 88484 RVA: 0x0031E68D File Offset: 0x0031C88D
		public IAttributeToTarget_Union Type { get; set; }

		// Token: 0x17006B5C RID: 27484
		// (get) Token: 0x060159A5 RID: 88485 RVA: 0x0031E696 File Offset: 0x0031C896
		// (set) Token: 0x060159A6 RID: 88486 RVA: 0x0031E69E File Offset: 0x0031C89E
		public object Value { get; set; }

		// Token: 0x060159A7 RID: 88487 RVA: 0x0031E6A7 File Offset: 0x0031C8A7
		public IAttributeToTarget_UnionUnion()
		{
			this.Type = IAttributeToTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060159A8 RID: 88488 RVA: 0x0031E6BD File Offset: 0x0031C8BD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060159A9 RID: 88489 RVA: 0x0031E6CF File Offset: 0x0031C8CF
		public IAttributeToTargetT AsIAttributeToTarget()
		{
			return this.As<IAttributeToTargetT>();
		}

		// Token: 0x060159AA RID: 88490 RVA: 0x0031E6D7 File Offset: 0x0031C8D7
		public static IAttributeToTarget_UnionUnion FromIAttributeToTarget(IAttributeToTargetT _iattributetotarget)
		{
			return new IAttributeToTarget_UnionUnion
			{
				Type = IAttributeToTarget_Union.IAttributeToTarget,
				Value = _iattributetotarget
			};
		}

		// Token: 0x060159AB RID: 88491 RVA: 0x0031E6EC File Offset: 0x0031C8EC
		public IHealthAttributeToTargetT AsIHealthAttributeToTarget()
		{
			return this.As<IHealthAttributeToTargetT>();
		}

		// Token: 0x060159AC RID: 88492 RVA: 0x0031E6F4 File Offset: 0x0031C8F4
		public static IAttributeToTarget_UnionUnion FromIHealthAttributeToTarget(IHealthAttributeToTargetT _ihealthattributetotarget)
		{
			return new IAttributeToTarget_UnionUnion
			{
				Type = IAttributeToTarget_Union.IHealthAttributeToTarget,
				Value = _ihealthattributetotarget
			};
		}

		// Token: 0x060159AD RID: 88493 RVA: 0x0031E70C File Offset: 0x0031C90C
		public static int Pack(FlatBufferBuilder builder, IAttributeToTarget_UnionUnion _o)
		{
			IAttributeToTarget_Union type = _o.Type;
			if (type == IAttributeToTarget_Union.IAttributeToTarget)
			{
				return IAttributeToTarget.Pack(builder, _o.AsIAttributeToTarget()).Value;
			}
			if (type != IAttributeToTarget_Union.IHealthAttributeToTarget)
			{
				return 0;
			}
			return IHealthAttributeToTarget.Pack(builder, _o.AsIHealthAttributeToTarget()).Value;
		}
	}
}
