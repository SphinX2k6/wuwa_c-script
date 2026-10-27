using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006210 RID: 25104
	public class IBlendAnimTypeBase_UnionUnion
	{
		// Token: 0x1700BB18 RID: 47896
		// (get) Token: 0x0602B455 RID: 177237 RVA: 0x005F5E1D File Offset: 0x005F401D
		// (set) Token: 0x0602B456 RID: 177238 RVA: 0x005F5E25 File Offset: 0x005F4025
		public IBlendAnimTypeBase_Union Type { get; set; }

		// Token: 0x1700BB19 RID: 47897
		// (get) Token: 0x0602B457 RID: 177239 RVA: 0x005F5E2E File Offset: 0x005F402E
		// (set) Token: 0x0602B458 RID: 177240 RVA: 0x005F5E36 File Offset: 0x005F4036
		public object Value { get; set; }

		// Token: 0x0602B459 RID: 177241 RVA: 0x005F5E3F File Offset: 0x005F403F
		public IBlendAnimTypeBase_UnionUnion()
		{
			this.Type = IBlendAnimTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B45A RID: 177242 RVA: 0x005F5E55 File Offset: 0x005F4055
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B45B RID: 177243 RVA: 0x005F5E67 File Offset: 0x005F4067
		public IBlendAnimTypeBaseT AsIBlendAnimTypeBase()
		{
			return this.As<IBlendAnimTypeBaseT>();
		}

		// Token: 0x0602B45C RID: 177244 RVA: 0x005F5E6F File Offset: 0x005F406F
		public static IBlendAnimTypeBase_UnionUnion FromIBlendAnimTypeBase(IBlendAnimTypeBaseT _iblendanimtypebase)
		{
			return new IBlendAnimTypeBase_UnionUnion
			{
				Type = IBlendAnimTypeBase_Union.IBlendAnimTypeBase,
				Value = _iblendanimtypebase
			};
		}

		// Token: 0x0602B45D RID: 177245 RVA: 0x005F5E84 File Offset: 0x005F4084
		public ISetStateMachineBlendAnimTypeT AsISetStateMachineBlendAnimType()
		{
			return this.As<ISetStateMachineBlendAnimTypeT>();
		}

		// Token: 0x0602B45E RID: 177246 RVA: 0x005F5E8C File Offset: 0x005F408C
		public static IBlendAnimTypeBase_UnionUnion FromISetStateMachineBlendAnimType(ISetStateMachineBlendAnimTypeT _isetstatemachineblendanimtype)
		{
			return new IBlendAnimTypeBase_UnionUnion
			{
				Type = IBlendAnimTypeBase_Union.ISetStateMachineBlendAnimType,
				Value = _isetstatemachineblendanimtype
			};
		}

		// Token: 0x0602B45F RID: 177247 RVA: 0x005F5EA1 File Offset: 0x005F40A1
		public ISetAnimSequenceBlendAnimTypeT AsISetAnimSequenceBlendAnimType()
		{
			return this.As<ISetAnimSequenceBlendAnimTypeT>();
		}

		// Token: 0x0602B460 RID: 177248 RVA: 0x005F5EA9 File Offset: 0x005F40A9
		public static IBlendAnimTypeBase_UnionUnion FromISetAnimSequenceBlendAnimType(ISetAnimSequenceBlendAnimTypeT _isetanimsequenceblendanimtype)
		{
			return new IBlendAnimTypeBase_UnionUnion
			{
				Type = IBlendAnimTypeBase_Union.ISetAnimSequenceBlendAnimType,
				Value = _isetanimsequenceblendanimtype
			};
		}

		// Token: 0x0602B461 RID: 177249 RVA: 0x005F5EC0 File Offset: 0x005F40C0
		public static int Pack(FlatBufferBuilder builder, IBlendAnimTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBlendAnimTypeBase_Union.IBlendAnimTypeBase:
				return IBlendAnimTypeBase.Pack(builder, _o.AsIBlendAnimTypeBase()).Value;
			case IBlendAnimTypeBase_Union.ISetStateMachineBlendAnimType:
				return ISetStateMachineBlendAnimType.Pack(builder, _o.AsISetStateMachineBlendAnimType()).Value;
			case IBlendAnimTypeBase_Union.ISetAnimSequenceBlendAnimType:
				return ISetAnimSequenceBlendAnimType.Pack(builder, _o.AsISetAnimSequenceBlendAnimType()).Value;
			default:
				return 0;
			}
		}
	}
}
