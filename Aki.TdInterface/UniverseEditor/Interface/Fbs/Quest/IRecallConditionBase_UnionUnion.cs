using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004077 RID: 16503
	public class IRecallConditionBase_UnionUnion
	{
		// Token: 0x17007472 RID: 29810
		// (get) Token: 0x06017FD1 RID: 98257 RVA: 0x003762E2 File Offset: 0x003744E2
		// (set) Token: 0x06017FD2 RID: 98258 RVA: 0x003762EA File Offset: 0x003744EA
		public IRecallConditionBase_Union Type { get; set; }

		// Token: 0x17007473 RID: 29811
		// (get) Token: 0x06017FD3 RID: 98259 RVA: 0x003762F3 File Offset: 0x003744F3
		// (set) Token: 0x06017FD4 RID: 98260 RVA: 0x003762FB File Offset: 0x003744FB
		public object Value { get; set; }

		// Token: 0x06017FD5 RID: 98261 RVA: 0x00376304 File Offset: 0x00374504
		public IRecallConditionBase_UnionUnion()
		{
			this.Type = IRecallConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017FD6 RID: 98262 RVA: 0x0037631A File Offset: 0x0037451A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017FD7 RID: 98263 RVA: 0x0037632C File Offset: 0x0037452C
		public IRecallConditionBaseT AsIRecallConditionBase()
		{
			return this.As<IRecallConditionBaseT>();
		}

		// Token: 0x06017FD8 RID: 98264 RVA: 0x00376334 File Offset: 0x00374534
		public static IRecallConditionBase_UnionUnion FromIRecallConditionBase(IRecallConditionBaseT _irecallconditionbase)
		{
			return new IRecallConditionBase_UnionUnion
			{
				Type = IRecallConditionBase_Union.IRecallConditionBase,
				Value = _irecallconditionbase
			};
		}

		// Token: 0x06017FD9 RID: 98265 RVA: 0x00376349 File Offset: 0x00374549
		public IRecallConditionByEntityTypeT AsIRecallConditionByEntityType()
		{
			return this.As<IRecallConditionByEntityTypeT>();
		}

		// Token: 0x06017FDA RID: 98266 RVA: 0x00376351 File Offset: 0x00374551
		public static IRecallConditionBase_UnionUnion FromIRecallConditionByEntityType(IRecallConditionByEntityTypeT _irecallconditionbyentitytype)
		{
			return new IRecallConditionBase_UnionUnion
			{
				Type = IRecallConditionBase_Union.IRecallConditionByEntityType,
				Value = _irecallconditionbyentitytype
			};
		}

		// Token: 0x06017FDB RID: 98267 RVA: 0x00376366 File Offset: 0x00374566
		public IRecallConditionByTemplateT AsIRecallConditionByTemplate()
		{
			return this.As<IRecallConditionByTemplateT>();
		}

		// Token: 0x06017FDC RID: 98268 RVA: 0x0037636E File Offset: 0x0037456E
		public static IRecallConditionBase_UnionUnion FromIRecallConditionByTemplate(IRecallConditionByTemplateT _irecallconditionbytemplate)
		{
			return new IRecallConditionBase_UnionUnion
			{
				Type = IRecallConditionBase_Union.IRecallConditionByTemplate,
				Value = _irecallconditionbytemplate
			};
		}

		// Token: 0x06017FDD RID: 98269 RVA: 0x00376383 File Offset: 0x00374583
		public IRecallConditionByGroupT AsIRecallConditionByGroup()
		{
			return this.As<IRecallConditionByGroupT>();
		}

		// Token: 0x06017FDE RID: 98270 RVA: 0x0037638B File Offset: 0x0037458B
		public static IRecallConditionBase_UnionUnion FromIRecallConditionByGroup(IRecallConditionByGroupT _irecallconditionbygroup)
		{
			return new IRecallConditionBase_UnionUnion
			{
				Type = IRecallConditionBase_Union.IRecallConditionByGroup,
				Value = _irecallconditionbygroup
			};
		}

		// Token: 0x06017FDF RID: 98271 RVA: 0x003763A0 File Offset: 0x003745A0
		public static int Pack(FlatBufferBuilder builder, IRecallConditionBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRecallConditionBase_Union.IRecallConditionBase:
				return IRecallConditionBase.Pack(builder, _o.AsIRecallConditionBase()).Value;
			case IRecallConditionBase_Union.IRecallConditionByEntityType:
				return IRecallConditionByEntityType.Pack(builder, _o.AsIRecallConditionByEntityType()).Value;
			case IRecallConditionBase_Union.IRecallConditionByTemplate:
				return IRecallConditionByTemplate.Pack(builder, _o.AsIRecallConditionByTemplate()).Value;
			case IRecallConditionBase_Union.IRecallConditionByGroup:
				return IRecallConditionByGroup.Pack(builder, _o.AsIRecallConditionByGroup()).Value;
			default:
				return 0;
			}
		}
	}
}
