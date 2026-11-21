using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005200 RID: 20992
	public class ITrafficMatchTargetType_UnionUnion
	{
		// Token: 0x17009642 RID: 38466
		// (get) Token: 0x060210F9 RID: 135417 RVA: 0x00491851 File Offset: 0x0048FA51
		// (set) Token: 0x060210FA RID: 135418 RVA: 0x00491859 File Offset: 0x0048FA59
		public ITrafficMatchTargetType_Union Type { get; set; }

		// Token: 0x17009643 RID: 38467
		// (get) Token: 0x060210FB RID: 135419 RVA: 0x00491862 File Offset: 0x0048FA62
		// (set) Token: 0x060210FC RID: 135420 RVA: 0x0049186A File Offset: 0x0048FA6A
		public object Value { get; set; }

		// Token: 0x060210FD RID: 135421 RVA: 0x00491873 File Offset: 0x0048FA73
		public ITrafficMatchTargetType_UnionUnion()
		{
			this.Type = ITrafficMatchTargetType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060210FE RID: 135422 RVA: 0x00491889 File Offset: 0x0048FA89
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060210FF RID: 135423 RVA: 0x0049189B File Offset: 0x0048FA9B
		public ITrafficMatchTargetTypeT AsITrafficMatchTargetType()
		{
			return this.As<ITrafficMatchTargetTypeT>();
		}

		// Token: 0x06021100 RID: 135424 RVA: 0x004918A3 File Offset: 0x0048FAA3
		public static ITrafficMatchTargetType_UnionUnion FromITrafficMatchTargetType(ITrafficMatchTargetTypeT _itrafficmatchtargettype)
		{
			return new ITrafficMatchTargetType_UnionUnion
			{
				Type = ITrafficMatchTargetType_Union.ITrafficMatchTargetType,
				Value = _itrafficmatchtargettype
			};
		}

		// Token: 0x06021101 RID: 135425 RVA: 0x004918B8 File Offset: 0x0048FAB8
		public ITrafficMatchTargetByEntityLogicT AsITrafficMatchTargetByEntityLogic()
		{
			return this.As<ITrafficMatchTargetByEntityLogicT>();
		}

		// Token: 0x06021102 RID: 135426 RVA: 0x004918C0 File Offset: 0x0048FAC0
		public static ITrafficMatchTargetType_UnionUnion FromITrafficMatchTargetByEntityLogic(ITrafficMatchTargetByEntityLogicT _itrafficmatchtargetbyentitylogic)
		{
			return new ITrafficMatchTargetType_UnionUnion
			{
				Type = ITrafficMatchTargetType_Union.ITrafficMatchTargetByEntityLogic,
				Value = _itrafficmatchtargetbyentitylogic
			};
		}

		// Token: 0x06021103 RID: 135427 RVA: 0x004918D8 File Offset: 0x0048FAD8
		public static int Pack(FlatBufferBuilder builder, ITrafficMatchTargetType_UnionUnion _o)
		{
			ITrafficMatchTargetType_Union type = _o.Type;
			if (type == ITrafficMatchTargetType_Union.ITrafficMatchTargetType)
			{
				return ITrafficMatchTargetType.Pack(builder, _o.AsITrafficMatchTargetType()).Value;
			}
			if (type != ITrafficMatchTargetType_Union.ITrafficMatchTargetByEntityLogic)
			{
				return 0;
			}
			return ITrafficMatchTargetByEntityLogic.Pack(builder, _o.AsITrafficMatchTargetByEntityLogic()).Value;
		}
	}
}
