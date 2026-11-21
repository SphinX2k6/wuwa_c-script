using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064FB RID: 25851
	public class ICommonBtDecoratorBase_UnionUnion
	{
		// Token: 0x1700BE97 RID: 48791
		// (get) Token: 0x0602BFED RID: 180205 RVA: 0x005FD5BD File Offset: 0x005FB7BD
		// (set) Token: 0x0602BFEE RID: 180206 RVA: 0x005FD5C5 File Offset: 0x005FB7C5
		public ICommonBtDecoratorBase_Union Type { get; set; }

		// Token: 0x1700BE98 RID: 48792
		// (get) Token: 0x0602BFEF RID: 180207 RVA: 0x005FD5CE File Offset: 0x005FB7CE
		// (set) Token: 0x0602BFF0 RID: 180208 RVA: 0x005FD5D6 File Offset: 0x005FB7D6
		public object Value { get; set; }

		// Token: 0x0602BFF1 RID: 180209 RVA: 0x005FD5DF File Offset: 0x005FB7DF
		public ICommonBtDecoratorBase_UnionUnion()
		{
			this.Type = ICommonBtDecoratorBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BFF2 RID: 180210 RVA: 0x005FD5F5 File Offset: 0x005FB7F5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BFF3 RID: 180211 RVA: 0x005FD607 File Offset: 0x005FB807
		public ICommonBtDecoratorBaseT AsICommonBtDecoratorBase()
		{
			return this.As<ICommonBtDecoratorBaseT>();
		}

		// Token: 0x0602BFF4 RID: 180212 RVA: 0x005FD60F File Offset: 0x005FB80F
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtDecoratorBase(ICommonBtDecoratorBaseT _icommonbtdecoratorbase)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtDecoratorBase,
				Value = _icommonbtdecoratorbase
			};
		}

		// Token: 0x0602BFF5 RID: 180213 RVA: 0x005FD624 File Offset: 0x005FB824
		public ICommonBtConditionDecoratorT AsICommonBtConditionDecorator()
		{
			return this.As<ICommonBtConditionDecoratorT>();
		}

		// Token: 0x0602BFF6 RID: 180214 RVA: 0x005FD62C File Offset: 0x005FB82C
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtConditionDecorator(ICommonBtConditionDecoratorT _icommonbtconditiondecorator)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtConditionDecorator,
				Value = _icommonbtconditiondecorator
			};
		}

		// Token: 0x0602BFF7 RID: 180215 RVA: 0x005FD641 File Offset: 0x005FB841
		public ICommonBtAlwaysFalseDecoratorT AsICommonBtAlwaysFalseDecorator()
		{
			return this.As<ICommonBtAlwaysFalseDecoratorT>();
		}

		// Token: 0x0602BFF8 RID: 180216 RVA: 0x005FD649 File Offset: 0x005FB849
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtAlwaysFalseDecorator(ICommonBtAlwaysFalseDecoratorT _icommonbtalwaysfalsedecorator)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtAlwaysFalseDecorator,
				Value = _icommonbtalwaysfalsedecorator
			};
		}

		// Token: 0x0602BFF9 RID: 180217 RVA: 0x005FD65E File Offset: 0x005FB85E
		public ICommonBtAlwaysTrueDecoratorT AsICommonBtAlwaysTrueDecorator()
		{
			return this.As<ICommonBtAlwaysTrueDecoratorT>();
		}

		// Token: 0x0602BFFA RID: 180218 RVA: 0x005FD666 File Offset: 0x005FB866
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtAlwaysTrueDecorator(ICommonBtAlwaysTrueDecoratorT _icommonbtalwaystruedecorator)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtAlwaysTrueDecorator,
				Value = _icommonbtalwaystruedecorator
			};
		}

		// Token: 0x0602BFFB RID: 180219 RVA: 0x005FD67B File Offset: 0x005FB87B
		public ICommonBtDoOnceDecoratorT AsICommonBtDoOnceDecorator()
		{
			return this.As<ICommonBtDoOnceDecoratorT>();
		}

		// Token: 0x0602BFFC RID: 180220 RVA: 0x005FD683 File Offset: 0x005FB883
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtDoOnceDecorator(ICommonBtDoOnceDecoratorT _icommonbtdooncedecorator)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtDoOnceDecorator,
				Value = _icommonbtdooncedecorator
			};
		}

		// Token: 0x0602BFFD RID: 180221 RVA: 0x005FD698 File Offset: 0x005FB898
		public ICommonBtCoolDownDecoratorT AsICommonBtCoolDownDecorator()
		{
			return this.As<ICommonBtCoolDownDecoratorT>();
		}

		// Token: 0x0602BFFE RID: 180222 RVA: 0x005FD6A0 File Offset: 0x005FB8A0
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtCoolDownDecorator(ICommonBtCoolDownDecoratorT _icommonbtcooldowndecorator)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtCoolDownDecorator,
				Value = _icommonbtcooldowndecorator
			};
		}

		// Token: 0x0602BFFF RID: 180223 RVA: 0x005FD6B8 File Offset: 0x005FB8B8
		public static int Pack(FlatBufferBuilder builder, ICommonBtDecoratorBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICommonBtDecoratorBase_Union.ICommonBtDecoratorBase:
				return ICommonBtDecoratorBase.Pack(builder, _o.AsICommonBtDecoratorBase()).Value;
			case ICommonBtDecoratorBase_Union.ICommonBtConditionDecorator:
				return ICommonBtConditionDecorator.Pack(builder, _o.AsICommonBtConditionDecorator()).Value;
			case ICommonBtDecoratorBase_Union.ICommonBtAlwaysFalseDecorator:
				return ICommonBtAlwaysFalseDecorator.Pack(builder, _o.AsICommonBtAlwaysFalseDecorator()).Value;
			case ICommonBtDecoratorBase_Union.ICommonBtAlwaysTrueDecorator:
				return ICommonBtAlwaysTrueDecorator.Pack(builder, _o.AsICommonBtAlwaysTrueDecorator()).Value;
			case ICommonBtDecoratorBase_Union.ICommonBtDoOnceDecorator:
				return ICommonBtDoOnceDecorator.Pack(builder, _o.AsICommonBtDoOnceDecorator()).Value;
			case ICommonBtDecoratorBase_Union.ICommonBtCoolDownDecorator:
				return ICommonBtCoolDownDecorator.Pack(builder, _o.AsICommonBtCoolDownDecorator()).Value;
			default:
				return 0;
			}
		}
	}
}
