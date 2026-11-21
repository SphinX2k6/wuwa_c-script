using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006881 RID: 26753
	public class IBlendAnimTypeBase_UnionUnion
	{
		// Token: 0x1700C49E RID: 50334
		// (get) Token: 0x0602DBAE RID: 187310 RVA: 0x00640A09 File Offset: 0x0063EC09
		// (set) Token: 0x0602DBAF RID: 187311 RVA: 0x00640A11 File Offset: 0x0063EC11
		public IBlendAnimTypeBase_Union Type { get; set; }

		// Token: 0x1700C49F RID: 50335
		// (get) Token: 0x0602DBB0 RID: 187312 RVA: 0x00640A1A File Offset: 0x0063EC1A
		// (set) Token: 0x0602DBB1 RID: 187313 RVA: 0x00640A22 File Offset: 0x0063EC22
		public object Value { get; set; }

		// Token: 0x0602DBB2 RID: 187314 RVA: 0x00640A2B File Offset: 0x0063EC2B
		public IBlendAnimTypeBase_UnionUnion()
		{
			this.Type = IBlendAnimTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DBB3 RID: 187315 RVA: 0x00640A41 File Offset: 0x0063EC41
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DBB4 RID: 187316 RVA: 0x00640A53 File Offset: 0x0063EC53
		public IBlendAnimTypeBaseT AsIBlendAnimTypeBase()
		{
			return this.As<IBlendAnimTypeBaseT>();
		}

		// Token: 0x0602DBB5 RID: 187317 RVA: 0x00640A5B File Offset: 0x0063EC5B
		public static IBlendAnimTypeBase_UnionUnion FromIBlendAnimTypeBase(IBlendAnimTypeBaseT _iblendanimtypebase)
		{
			return new IBlendAnimTypeBase_UnionUnion
			{
				Type = IBlendAnimTypeBase_Union.IBlendAnimTypeBase,
				Value = _iblendanimtypebase
			};
		}

		// Token: 0x0602DBB6 RID: 187318 RVA: 0x00640A70 File Offset: 0x0063EC70
		public ISetStateMachineBlendAnimTypeT AsISetStateMachineBlendAnimType()
		{
			return this.As<ISetStateMachineBlendAnimTypeT>();
		}

		// Token: 0x0602DBB7 RID: 187319 RVA: 0x00640A78 File Offset: 0x0063EC78
		public static IBlendAnimTypeBase_UnionUnion FromISetStateMachineBlendAnimType(ISetStateMachineBlendAnimTypeT _isetstatemachineblendanimtype)
		{
			return new IBlendAnimTypeBase_UnionUnion
			{
				Type = IBlendAnimTypeBase_Union.ISetStateMachineBlendAnimType,
				Value = _isetstatemachineblendanimtype
			};
		}

		// Token: 0x0602DBB8 RID: 187320 RVA: 0x00640A8D File Offset: 0x0063EC8D
		public ISetAnimSequenceBlendAnimTypeT AsISetAnimSequenceBlendAnimType()
		{
			return this.As<ISetAnimSequenceBlendAnimTypeT>();
		}

		// Token: 0x0602DBB9 RID: 187321 RVA: 0x00640A95 File Offset: 0x0063EC95
		public static IBlendAnimTypeBase_UnionUnion FromISetAnimSequenceBlendAnimType(ISetAnimSequenceBlendAnimTypeT _isetanimsequenceblendanimtype)
		{
			return new IBlendAnimTypeBase_UnionUnion
			{
				Type = IBlendAnimTypeBase_Union.ISetAnimSequenceBlendAnimType,
				Value = _isetanimsequenceblendanimtype
			};
		}

		// Token: 0x0602DBBA RID: 187322 RVA: 0x00640AAC File Offset: 0x0063ECAC
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
