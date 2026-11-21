using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047E4 RID: 18404
	public class TPerformerAiDecoratorUnion
	{
		// Token: 0x17008064 RID: 32868
		// (get) Token: 0x0601B2DD RID: 111325 RVA: 0x003DA450 File Offset: 0x003D8650
		// (set) Token: 0x0601B2DE RID: 111326 RVA: 0x003DA458 File Offset: 0x003D8658
		public TPerformerAiDecorator Type { get; set; }

		// Token: 0x17008065 RID: 32869
		// (get) Token: 0x0601B2DF RID: 111327 RVA: 0x003DA461 File Offset: 0x003D8661
		// (set) Token: 0x0601B2E0 RID: 111328 RVA: 0x003DA469 File Offset: 0x003D8669
		public object Value { get; set; }

		// Token: 0x0601B2E1 RID: 111329 RVA: 0x003DA472 File Offset: 0x003D8672
		public TPerformerAiDecoratorUnion()
		{
			this.Type = TPerformerAiDecorator.NONE;
			this.Value = null;
		}

		// Token: 0x0601B2E2 RID: 111330 RVA: 0x003DA488 File Offset: 0x003D8688
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B2E3 RID: 111331 RVA: 0x003DA49A File Offset: 0x003D869A
		public IPerformerAiAlwaysFalseDecoratorT AsIPerformerAiAlwaysFalseDecorator()
		{
			return this.As<IPerformerAiAlwaysFalseDecoratorT>();
		}

		// Token: 0x0601B2E4 RID: 111332 RVA: 0x003DA4A2 File Offset: 0x003D86A2
		public static TPerformerAiDecoratorUnion FromIPerformerAiAlwaysFalseDecorator(IPerformerAiAlwaysFalseDecoratorT _iperformeraialwaysfalsedecorator)
		{
			return new TPerformerAiDecoratorUnion
			{
				Type = TPerformerAiDecorator.IPerformerAiAlwaysFalseDecorator,
				Value = _iperformeraialwaysfalsedecorator
			};
		}

		// Token: 0x0601B2E5 RID: 111333 RVA: 0x003DA4B7 File Offset: 0x003D86B7
		public IPerformerAiAlwaysTrueDecoratorT AsIPerformerAiAlwaysTrueDecorator()
		{
			return this.As<IPerformerAiAlwaysTrueDecoratorT>();
		}

		// Token: 0x0601B2E6 RID: 111334 RVA: 0x003DA4BF File Offset: 0x003D86BF
		public static TPerformerAiDecoratorUnion FromIPerformerAiAlwaysTrueDecorator(IPerformerAiAlwaysTrueDecoratorT _iperformeraialwaystruedecorator)
		{
			return new TPerformerAiDecoratorUnion
			{
				Type = TPerformerAiDecorator.IPerformerAiAlwaysTrueDecorator,
				Value = _iperformeraialwaystruedecorator
			};
		}

		// Token: 0x0601B2E7 RID: 111335 RVA: 0x003DA4D4 File Offset: 0x003D86D4
		public IPerformerAiConditionDecoratorT AsIPerformerAiConditionDecorator()
		{
			return this.As<IPerformerAiConditionDecoratorT>();
		}

		// Token: 0x0601B2E8 RID: 111336 RVA: 0x003DA4DC File Offset: 0x003D86DC
		public static TPerformerAiDecoratorUnion FromIPerformerAiConditionDecorator(IPerformerAiConditionDecoratorT _iperformeraiconditiondecorator)
		{
			return new TPerformerAiDecoratorUnion
			{
				Type = TPerformerAiDecorator.IPerformerAiConditionDecorator,
				Value = _iperformeraiconditiondecorator
			};
		}

		// Token: 0x0601B2E9 RID: 111337 RVA: 0x003DA4F1 File Offset: 0x003D86F1
		public IPerformerAiCoolDownDecoratorT AsIPerformerAiCoolDownDecorator()
		{
			return this.As<IPerformerAiCoolDownDecoratorT>();
		}

		// Token: 0x0601B2EA RID: 111338 RVA: 0x003DA4F9 File Offset: 0x003D86F9
		public static TPerformerAiDecoratorUnion FromIPerformerAiCoolDownDecorator(IPerformerAiCoolDownDecoratorT _iperformeraicooldowndecorator)
		{
			return new TPerformerAiDecoratorUnion
			{
				Type = TPerformerAiDecorator.IPerformerAiCoolDownDecorator,
				Value = _iperformeraicooldowndecorator
			};
		}

		// Token: 0x0601B2EB RID: 111339 RVA: 0x003DA50E File Offset: 0x003D870E
		public IPerformerAiDoOnceDecoratorT AsIPerformerAiDoOnceDecorator()
		{
			return this.As<IPerformerAiDoOnceDecoratorT>();
		}

		// Token: 0x0601B2EC RID: 111340 RVA: 0x003DA516 File Offset: 0x003D8716
		public static TPerformerAiDecoratorUnion FromIPerformerAiDoOnceDecorator(IPerformerAiDoOnceDecoratorT _iperformeraidooncedecorator)
		{
			return new TPerformerAiDecoratorUnion
			{
				Type = TPerformerAiDecorator.IPerformerAiDoOnceDecorator,
				Value = _iperformeraidooncedecorator
			};
		}

		// Token: 0x0601B2ED RID: 111341 RVA: 0x003DA52C File Offset: 0x003D872C
		public static int Pack(FlatBufferBuilder builder, TPerformerAiDecoratorUnion _o)
		{
			switch (_o.Type)
			{
			case TPerformerAiDecorator.IPerformerAiAlwaysFalseDecorator:
				return IPerformerAiAlwaysFalseDecorator.Pack(builder, _o.AsIPerformerAiAlwaysFalseDecorator()).Value;
			case TPerformerAiDecorator.IPerformerAiAlwaysTrueDecorator:
				return IPerformerAiAlwaysTrueDecorator.Pack(builder, _o.AsIPerformerAiAlwaysTrueDecorator()).Value;
			case TPerformerAiDecorator.IPerformerAiConditionDecorator:
				return IPerformerAiConditionDecorator.Pack(builder, _o.AsIPerformerAiConditionDecorator()).Value;
			case TPerformerAiDecorator.IPerformerAiCoolDownDecorator:
				return IPerformerAiCoolDownDecorator.Pack(builder, _o.AsIPerformerAiCoolDownDecorator()).Value;
			case TPerformerAiDecorator.IPerformerAiDoOnceDecorator:
				return IPerformerAiDoOnceDecorator.Pack(builder, _o.AsIPerformerAiDoOnceDecorator()).Value;
			default:
				return 0;
			}
		}
	}
}
