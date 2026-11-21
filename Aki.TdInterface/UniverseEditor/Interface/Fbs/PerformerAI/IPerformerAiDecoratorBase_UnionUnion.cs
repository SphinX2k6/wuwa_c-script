using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047C9 RID: 18377
	public class IPerformerAiDecoratorBase_UnionUnion
	{
		// Token: 0x17007FFA RID: 32762
		// (get) Token: 0x0601B0FC RID: 110844 RVA: 0x003D538D File Offset: 0x003D358D
		// (set) Token: 0x0601B0FD RID: 110845 RVA: 0x003D5395 File Offset: 0x003D3595
		public IPerformerAiDecoratorBase_Union Type { get; set; }

		// Token: 0x17007FFB RID: 32763
		// (get) Token: 0x0601B0FE RID: 110846 RVA: 0x003D539E File Offset: 0x003D359E
		// (set) Token: 0x0601B0FF RID: 110847 RVA: 0x003D53A6 File Offset: 0x003D35A6
		public object Value { get; set; }

		// Token: 0x0601B100 RID: 110848 RVA: 0x003D53AF File Offset: 0x003D35AF
		public IPerformerAiDecoratorBase_UnionUnion()
		{
			this.Type = IPerformerAiDecoratorBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601B101 RID: 110849 RVA: 0x003D53C5 File Offset: 0x003D35C5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B102 RID: 110850 RVA: 0x003D53D7 File Offset: 0x003D35D7
		public IPerformerAiDecoratorBaseT AsIPerformerAiDecoratorBase()
		{
			return this.As<IPerformerAiDecoratorBaseT>();
		}

		// Token: 0x0601B103 RID: 110851 RVA: 0x003D53DF File Offset: 0x003D35DF
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiDecoratorBase(IPerformerAiDecoratorBaseT _iperformeraidecoratorbase)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiDecoratorBase,
				Value = _iperformeraidecoratorbase
			};
		}

		// Token: 0x0601B104 RID: 110852 RVA: 0x003D53F4 File Offset: 0x003D35F4
		public IPerformerAiConditionDecoratorT AsIPerformerAiConditionDecorator()
		{
			return this.As<IPerformerAiConditionDecoratorT>();
		}

		// Token: 0x0601B105 RID: 110853 RVA: 0x003D53FC File Offset: 0x003D35FC
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiConditionDecorator(IPerformerAiConditionDecoratorT _iperformeraiconditiondecorator)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiConditionDecorator,
				Value = _iperformeraiconditiondecorator
			};
		}

		// Token: 0x0601B106 RID: 110854 RVA: 0x003D5411 File Offset: 0x003D3611
		public IPerformerAiAlwaysFalseDecoratorT AsIPerformerAiAlwaysFalseDecorator()
		{
			return this.As<IPerformerAiAlwaysFalseDecoratorT>();
		}

		// Token: 0x0601B107 RID: 110855 RVA: 0x003D5419 File Offset: 0x003D3619
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiAlwaysFalseDecorator(IPerformerAiAlwaysFalseDecoratorT _iperformeraialwaysfalsedecorator)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiAlwaysFalseDecorator,
				Value = _iperformeraialwaysfalsedecorator
			};
		}

		// Token: 0x0601B108 RID: 110856 RVA: 0x003D542E File Offset: 0x003D362E
		public IPerformerAiAlwaysTrueDecoratorT AsIPerformerAiAlwaysTrueDecorator()
		{
			return this.As<IPerformerAiAlwaysTrueDecoratorT>();
		}

		// Token: 0x0601B109 RID: 110857 RVA: 0x003D5436 File Offset: 0x003D3636
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiAlwaysTrueDecorator(IPerformerAiAlwaysTrueDecoratorT _iperformeraialwaystruedecorator)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiAlwaysTrueDecorator,
				Value = _iperformeraialwaystruedecorator
			};
		}

		// Token: 0x0601B10A RID: 110858 RVA: 0x003D544B File Offset: 0x003D364B
		public IPerformerAiDoOnceDecoratorT AsIPerformerAiDoOnceDecorator()
		{
			return this.As<IPerformerAiDoOnceDecoratorT>();
		}

		// Token: 0x0601B10B RID: 110859 RVA: 0x003D5453 File Offset: 0x003D3653
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiDoOnceDecorator(IPerformerAiDoOnceDecoratorT _iperformeraidooncedecorator)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiDoOnceDecorator,
				Value = _iperformeraidooncedecorator
			};
		}

		// Token: 0x0601B10C RID: 110860 RVA: 0x003D5468 File Offset: 0x003D3668
		public IPerformerAiCoolDownDecoratorT AsIPerformerAiCoolDownDecorator()
		{
			return this.As<IPerformerAiCoolDownDecoratorT>();
		}

		// Token: 0x0601B10D RID: 110861 RVA: 0x003D5470 File Offset: 0x003D3670
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiCoolDownDecorator(IPerformerAiCoolDownDecoratorT _iperformeraicooldowndecorator)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiCoolDownDecorator,
				Value = _iperformeraicooldowndecorator
			};
		}

		// Token: 0x0601B10E RID: 110862 RVA: 0x003D5488 File Offset: 0x003D3688
		public static int Pack(FlatBufferBuilder builder, IPerformerAiDecoratorBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPerformerAiDecoratorBase_Union.IPerformerAiDecoratorBase:
				return IPerformerAiDecoratorBase.Pack(builder, _o.AsIPerformerAiDecoratorBase()).Value;
			case IPerformerAiDecoratorBase_Union.IPerformerAiConditionDecorator:
				return IPerformerAiConditionDecorator.Pack(builder, _o.AsIPerformerAiConditionDecorator()).Value;
			case IPerformerAiDecoratorBase_Union.IPerformerAiAlwaysFalseDecorator:
				return IPerformerAiAlwaysFalseDecorator.Pack(builder, _o.AsIPerformerAiAlwaysFalseDecorator()).Value;
			case IPerformerAiDecoratorBase_Union.IPerformerAiAlwaysTrueDecorator:
				return IPerformerAiAlwaysTrueDecorator.Pack(builder, _o.AsIPerformerAiAlwaysTrueDecorator()).Value;
			case IPerformerAiDecoratorBase_Union.IPerformerAiDoOnceDecorator:
				return IPerformerAiDoOnceDecorator.Pack(builder, _o.AsIPerformerAiDoOnceDecorator()).Value;
			case IPerformerAiDecoratorBase_Union.IPerformerAiCoolDownDecorator:
				return IPerformerAiCoolDownDecorator.Pack(builder, _o.AsIPerformerAiCoolDownDecorator()).Value;
			default:
				return 0;
			}
		}
	}
}
