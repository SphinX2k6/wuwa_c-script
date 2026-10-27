using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005417 RID: 21527
	public class IInhaledPerResultType_UnionUnion
	{
		// Token: 0x17009E5F RID: 40543
		// (get) Token: 0x060235AF RID: 144815 RVA: 0x004E4AE9 File Offset: 0x004E2CE9
		// (set) Token: 0x060235B0 RID: 144816 RVA: 0x004E4AF1 File Offset: 0x004E2CF1
		public IInhaledPerResultType_Union Type { get; set; }

		// Token: 0x17009E60 RID: 40544
		// (get) Token: 0x060235B1 RID: 144817 RVA: 0x004E4AFA File Offset: 0x004E2CFA
		// (set) Token: 0x060235B2 RID: 144818 RVA: 0x004E4B02 File Offset: 0x004E2D02
		public object Value { get; set; }

		// Token: 0x060235B3 RID: 144819 RVA: 0x004E4B0B File Offset: 0x004E2D0B
		public IInhaledPerResultType_UnionUnion()
		{
			this.Type = IInhaledPerResultType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060235B4 RID: 144820 RVA: 0x004E4B21 File Offset: 0x004E2D21
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060235B5 RID: 144821 RVA: 0x004E4B33 File Offset: 0x004E2D33
		public IInhaledPerResultTypeT AsIInhaledPerResultType()
		{
			return this.As<IInhaledPerResultTypeT>();
		}

		// Token: 0x060235B6 RID: 144822 RVA: 0x004E4B3B File Offset: 0x004E2D3B
		public static IInhaledPerResultType_UnionUnion FromIInhaledPerResultType(IInhaledPerResultTypeT _iinhaledperresulttype)
		{
			return new IInhaledPerResultType_UnionUnion
			{
				Type = IInhaledPerResultType_Union.IInhaledPerResultType,
				Value = _iinhaledperresulttype
			};
		}

		// Token: 0x060235B7 RID: 144823 RVA: 0x004E4B50 File Offset: 0x004E2D50
		public IInhaledDestroySelfT AsIInhaledDestroySelf()
		{
			return this.As<IInhaledDestroySelfT>();
		}

		// Token: 0x060235B8 RID: 144824 RVA: 0x004E4B58 File Offset: 0x004E2D58
		public static IInhaledPerResultType_UnionUnion FromIInhaledDestroySelf(IInhaledDestroySelfT _iinhaleddestroyself)
		{
			return new IInhaledPerResultType_UnionUnion
			{
				Type = IInhaledPerResultType_Union.IInhaledDestroySelf,
				Value = _iinhaleddestroyself
			};
		}

		// Token: 0x060235B9 RID: 144825 RVA: 0x004E4B6D File Offset: 0x004E2D6D
		public IInhaledChangeSelfStateT AsIInhaledChangeSelfState()
		{
			return this.As<IInhaledChangeSelfStateT>();
		}

		// Token: 0x060235BA RID: 144826 RVA: 0x004E4B75 File Offset: 0x004E2D75
		public static IInhaledPerResultType_UnionUnion FromIInhaledChangeSelfState(IInhaledChangeSelfStateT _iinhaledchangeselfstate)
		{
			return new IInhaledPerResultType_UnionUnion
			{
				Type = IInhaledPerResultType_Union.IInhaledChangeSelfState,
				Value = _iinhaledchangeselfstate
			};
		}

		// Token: 0x060235BB RID: 144827 RVA: 0x004E4B8C File Offset: 0x004E2D8C
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
