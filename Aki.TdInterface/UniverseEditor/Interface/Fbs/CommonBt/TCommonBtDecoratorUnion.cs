using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ED9 RID: 24281
	public class TCommonBtDecoratorUnion
	{
		// Token: 0x1700B5A0 RID: 46496
		// (get) Token: 0x06029B4E RID: 170830 RVA: 0x005B9755 File Offset: 0x005B7955
		// (set) Token: 0x06029B4F RID: 170831 RVA: 0x005B975D File Offset: 0x005B795D
		public TCommonBtDecorator Type { get; set; }

		// Token: 0x1700B5A1 RID: 46497
		// (get) Token: 0x06029B50 RID: 170832 RVA: 0x005B9766 File Offset: 0x005B7966
		// (set) Token: 0x06029B51 RID: 170833 RVA: 0x005B976E File Offset: 0x005B796E
		public object Value { get; set; }

		// Token: 0x06029B52 RID: 170834 RVA: 0x005B9777 File Offset: 0x005B7977
		public TCommonBtDecoratorUnion()
		{
			this.Type = TCommonBtDecorator.NONE;
			this.Value = null;
		}

		// Token: 0x06029B53 RID: 170835 RVA: 0x005B978D File Offset: 0x005B798D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029B54 RID: 170836 RVA: 0x005B979F File Offset: 0x005B799F
		public ICommonBtAlwaysFalseDecoratorT AsICommonBtAlwaysFalseDecorator()
		{
			return this.As<ICommonBtAlwaysFalseDecoratorT>();
		}

		// Token: 0x06029B55 RID: 170837 RVA: 0x005B97A7 File Offset: 0x005B79A7
		public static TCommonBtDecoratorUnion FromICommonBtAlwaysFalseDecorator(ICommonBtAlwaysFalseDecoratorT _icommonbtalwaysfalsedecorator)
		{
			return new TCommonBtDecoratorUnion
			{
				Type = TCommonBtDecorator.ICommonBtAlwaysFalseDecorator,
				Value = _icommonbtalwaysfalsedecorator
			};
		}

		// Token: 0x06029B56 RID: 170838 RVA: 0x005B97BC File Offset: 0x005B79BC
		public ICommonBtAlwaysTrueDecoratorT AsICommonBtAlwaysTrueDecorator()
		{
			return this.As<ICommonBtAlwaysTrueDecoratorT>();
		}

		// Token: 0x06029B57 RID: 170839 RVA: 0x005B97C4 File Offset: 0x005B79C4
		public static TCommonBtDecoratorUnion FromICommonBtAlwaysTrueDecorator(ICommonBtAlwaysTrueDecoratorT _icommonbtalwaystruedecorator)
		{
			return new TCommonBtDecoratorUnion
			{
				Type = TCommonBtDecorator.ICommonBtAlwaysTrueDecorator,
				Value = _icommonbtalwaystruedecorator
			};
		}

		// Token: 0x06029B58 RID: 170840 RVA: 0x005B97D9 File Offset: 0x005B79D9
		public ICommonBtConditionDecoratorT AsICommonBtConditionDecorator()
		{
			return this.As<ICommonBtConditionDecoratorT>();
		}

		// Token: 0x06029B59 RID: 170841 RVA: 0x005B97E1 File Offset: 0x005B79E1
		public static TCommonBtDecoratorUnion FromICommonBtConditionDecorator(ICommonBtConditionDecoratorT _icommonbtconditiondecorator)
		{
			return new TCommonBtDecoratorUnion
			{
				Type = TCommonBtDecorator.ICommonBtConditionDecorator,
				Value = _icommonbtconditiondecorator
			};
		}

		// Token: 0x06029B5A RID: 170842 RVA: 0x005B97F6 File Offset: 0x005B79F6
		public ICommonBtCoolDownDecoratorT AsICommonBtCoolDownDecorator()
		{
			return this.As<ICommonBtCoolDownDecoratorT>();
		}

		// Token: 0x06029B5B RID: 170843 RVA: 0x005B97FE File Offset: 0x005B79FE
		public static TCommonBtDecoratorUnion FromICommonBtCoolDownDecorator(ICommonBtCoolDownDecoratorT _icommonbtcooldowndecorator)
		{
			return new TCommonBtDecoratorUnion
			{
				Type = TCommonBtDecorator.ICommonBtCoolDownDecorator,
				Value = _icommonbtcooldowndecorator
			};
		}

		// Token: 0x06029B5C RID: 170844 RVA: 0x005B9813 File Offset: 0x005B7A13
		public ICommonBtDoOnceDecoratorT AsICommonBtDoOnceDecorator()
		{
			return this.As<ICommonBtDoOnceDecoratorT>();
		}

		// Token: 0x06029B5D RID: 170845 RVA: 0x005B981B File Offset: 0x005B7A1B
		public static TCommonBtDecoratorUnion FromICommonBtDoOnceDecorator(ICommonBtDoOnceDecoratorT _icommonbtdooncedecorator)
		{
			return new TCommonBtDecoratorUnion
			{
				Type = TCommonBtDecorator.ICommonBtDoOnceDecorator,
				Value = _icommonbtdooncedecorator
			};
		}

		// Token: 0x06029B5E RID: 170846 RVA: 0x005B9830 File Offset: 0x005B7A30
		public static int Pack(FlatBufferBuilder builder, TCommonBtDecoratorUnion _o)
		{
			switch (_o.Type)
			{
			case TCommonBtDecorator.ICommonBtAlwaysFalseDecorator:
				return ICommonBtAlwaysFalseDecorator.Pack(builder, _o.AsICommonBtAlwaysFalseDecorator()).Value;
			case TCommonBtDecorator.ICommonBtAlwaysTrueDecorator:
				return ICommonBtAlwaysTrueDecorator.Pack(builder, _o.AsICommonBtAlwaysTrueDecorator()).Value;
			case TCommonBtDecorator.ICommonBtConditionDecorator:
				return ICommonBtConditionDecorator.Pack(builder, _o.AsICommonBtConditionDecorator()).Value;
			case TCommonBtDecorator.ICommonBtCoolDownDecorator:
				return ICommonBtCoolDownDecorator.Pack(builder, _o.AsICommonBtCoolDownDecorator()).Value;
			case TCommonBtDecorator.ICommonBtDoOnceDecorator:
				return ICommonBtDoOnceDecorator.Pack(builder, _o.AsICommonBtDoOnceDecorator()).Value;
			default:
				return 0;
			}
		}
	}
}
