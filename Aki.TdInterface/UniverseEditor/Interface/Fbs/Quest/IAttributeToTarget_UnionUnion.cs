using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200413D RID: 16701
	public class IAttributeToTarget_UnionUnion
	{
		// Token: 0x17007115 RID: 28949
		// (get) Token: 0x06016EDB RID: 93915 RVA: 0x003458FD File Offset: 0x00343AFD
		// (set) Token: 0x06016EDC RID: 93916 RVA: 0x00345905 File Offset: 0x00343B05
		public IAttributeToTarget_Union Type { get; set; }

		// Token: 0x17007116 RID: 28950
		// (get) Token: 0x06016EDD RID: 93917 RVA: 0x0034590E File Offset: 0x00343B0E
		// (set) Token: 0x06016EDE RID: 93918 RVA: 0x00345916 File Offset: 0x00343B16
		public object Value { get; set; }

		// Token: 0x06016EDF RID: 93919 RVA: 0x0034591F File Offset: 0x00343B1F
		public IAttributeToTarget_UnionUnion()
		{
			this.Type = IAttributeToTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016EE0 RID: 93920 RVA: 0x00345935 File Offset: 0x00343B35
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016EE1 RID: 93921 RVA: 0x00345947 File Offset: 0x00343B47
		public IAttributeToTargetT AsIAttributeToTarget()
		{
			return this.As<IAttributeToTargetT>();
		}

		// Token: 0x06016EE2 RID: 93922 RVA: 0x0034594F File Offset: 0x00343B4F
		public static IAttributeToTarget_UnionUnion FromIAttributeToTarget(IAttributeToTargetT _iattributetotarget)
		{
			return new IAttributeToTarget_UnionUnion
			{
				Type = IAttributeToTarget_Union.IAttributeToTarget,
				Value = _iattributetotarget
			};
		}

		// Token: 0x06016EE3 RID: 93923 RVA: 0x00345964 File Offset: 0x00343B64
		public IHealthAttributeToTargetT AsIHealthAttributeToTarget()
		{
			return this.As<IHealthAttributeToTargetT>();
		}

		// Token: 0x06016EE4 RID: 93924 RVA: 0x0034596C File Offset: 0x00343B6C
		public static IAttributeToTarget_UnionUnion FromIHealthAttributeToTarget(IHealthAttributeToTargetT _ihealthattributetotarget)
		{
			return new IAttributeToTarget_UnionUnion
			{
				Type = IAttributeToTarget_Union.IHealthAttributeToTarget,
				Value = _ihealthattributetotarget
			};
		}

		// Token: 0x06016EE5 RID: 93925 RVA: 0x00345984 File Offset: 0x00343B84
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
