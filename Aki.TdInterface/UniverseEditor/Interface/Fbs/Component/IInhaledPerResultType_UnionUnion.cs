using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200599D RID: 22941
	public class IInhaledPerResultType_UnionUnion
	{
		// Token: 0x1700A699 RID: 42649
		// (get) Token: 0x06025667 RID: 153191 RVA: 0x00521B15 File Offset: 0x0051FD15
		// (set) Token: 0x06025668 RID: 153192 RVA: 0x00521B1D File Offset: 0x0051FD1D
		public IInhaledPerResultType_Union Type { get; set; }

		// Token: 0x1700A69A RID: 42650
		// (get) Token: 0x06025669 RID: 153193 RVA: 0x00521B26 File Offset: 0x0051FD26
		// (set) Token: 0x0602566A RID: 153194 RVA: 0x00521B2E File Offset: 0x0051FD2E
		public object Value { get; set; }

		// Token: 0x0602566B RID: 153195 RVA: 0x00521B37 File Offset: 0x0051FD37
		public IInhaledPerResultType_UnionUnion()
		{
			this.Type = IInhaledPerResultType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602566C RID: 153196 RVA: 0x00521B4D File Offset: 0x0051FD4D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602566D RID: 153197 RVA: 0x00521B5F File Offset: 0x0051FD5F
		public IInhaledPerResultTypeT AsIInhaledPerResultType()
		{
			return this.As<IInhaledPerResultTypeT>();
		}

		// Token: 0x0602566E RID: 153198 RVA: 0x00521B67 File Offset: 0x0051FD67
		public static IInhaledPerResultType_UnionUnion FromIInhaledPerResultType(IInhaledPerResultTypeT _iinhaledperresulttype)
		{
			return new IInhaledPerResultType_UnionUnion
			{
				Type = IInhaledPerResultType_Union.IInhaledPerResultType,
				Value = _iinhaledperresulttype
			};
		}

		// Token: 0x0602566F RID: 153199 RVA: 0x00521B7C File Offset: 0x0051FD7C
		public IInhaledDestroySelfT AsIInhaledDestroySelf()
		{
			return this.As<IInhaledDestroySelfT>();
		}

		// Token: 0x06025670 RID: 153200 RVA: 0x00521B84 File Offset: 0x0051FD84
		public static IInhaledPerResultType_UnionUnion FromIInhaledDestroySelf(IInhaledDestroySelfT _iinhaleddestroyself)
		{
			return new IInhaledPerResultType_UnionUnion
			{
				Type = IInhaledPerResultType_Union.IInhaledDestroySelf,
				Value = _iinhaleddestroyself
			};
		}

		// Token: 0x06025671 RID: 153201 RVA: 0x00521B99 File Offset: 0x0051FD99
		public IInhaledChangeSelfStateT AsIInhaledChangeSelfState()
		{
			return this.As<IInhaledChangeSelfStateT>();
		}

		// Token: 0x06025672 RID: 153202 RVA: 0x00521BA1 File Offset: 0x0051FDA1
		public static IInhaledPerResultType_UnionUnion FromIInhaledChangeSelfState(IInhaledChangeSelfStateT _iinhaledchangeselfstate)
		{
			return new IInhaledPerResultType_UnionUnion
			{
				Type = IInhaledPerResultType_Union.IInhaledChangeSelfState,
				Value = _iinhaledchangeselfstate
			};
		}

		// Token: 0x06025673 RID: 153203 RVA: 0x00521BB8 File Offset: 0x0051FDB8
		public static int Pack(FlatBufferBuilder builder, IInhaledPerResultType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInhaledPerResultType_Union.IInhaledPerResultType:
				return IInhaledPerResultType.Pack(builder, _o.AsIInhaledPerResultType()).Value;
			case IInhaledPerResultType_Union.IInhaledDestroySelf:
				return IInhaledDestroySelf.Pack(builder, _o.AsIInhaledDestroySelf()).Value;
			case IInhaledPerResultType_Union.IInhaledChangeSelfState:
				return IInhaledChangeSelfState.Pack(builder, _o.AsIInhaledChangeSelfState()).Value;
			default:
				return 0;
			}
		}
	}
}
