using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004382 RID: 17282
	public class TPerformerAiDecoratorUnion
	{
		// Token: 0x17007A2F RID: 31279
		// (get) Token: 0x06019B4F RID: 105295 RVA: 0x003AEA28 File Offset: 0x003ACC28
		// (set) Token: 0x06019B50 RID: 105296 RVA: 0x003AEA30 File Offset: 0x003ACC30
		public TPerformerAiDecorator Type { get; set; }

		// Token: 0x17007A30 RID: 31280
		// (get) Token: 0x06019B51 RID: 105297 RVA: 0x003AEA39 File Offset: 0x003ACC39
		// (set) Token: 0x06019B52 RID: 105298 RVA: 0x003AEA41 File Offset: 0x003ACC41
		public object Value { get; set; }

		// Token: 0x06019B53 RID: 105299 RVA: 0x003AEA4A File Offset: 0x003ACC4A
		public TPerformerAiDecoratorUnion()
		{
			this.Type = TPerformerAiDecorator.NONE;
			this.Value = null;
		}

		// Token: 0x06019B54 RID: 105300 RVA: 0x003AEA60 File Offset: 0x003ACC60
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019B55 RID: 105301 RVA: 0x003AEA72 File Offset: 0x003ACC72
		public IPerformerAiAlwaysFalseDecoratorT AsIPerformerAiAlwaysFalseDecorator()
		{
			return this.As<IPerformerAiAlwaysFalseDecoratorT>();
		}

		// Token: 0x06019B56 RID: 105302 RVA: 0x003AEA7A File Offset: 0x003ACC7A
		public static TPerformerAiDecoratorUnion FromIPerformerAiAlwaysFalseDecorator(IPerformerAiAlwaysFalseDecoratorT _iperformeraialwaysfalsedecorator)
		{
			return new TPerformerAiDecoratorUnion
			{
				Type = TPerformerAiDecorator.IPerformerAiAlwaysFalseDecorator,
				Value = _iperformeraialwaysfalsedecorator
			};
		}

		// Token: 0x06019B57 RID: 105303 RVA: 0x003AEA8F File Offset: 0x003ACC8F
		public IPerformerAiAlwaysTrueDecoratorT AsIPerformerAiAlwaysTrueDecorator()
		{
			return this.As<IPerformerAiAlwaysTrueDecoratorT>();
		}

		// Token: 0x06019B58 RID: 105304 RVA: 0x003AEA97 File Offset: 0x003ACC97
		public static TPerformerAiDecoratorUnion FromIPerformerAiAlwaysTrueDecorator(IPerformerAiAlwaysTrueDecoratorT _iperformeraialwaystruedecorator)
		{
			return new TPerformerAiDecoratorUnion
			{
				Type = TPerformerAiDecorator.IPerformerAiAlwaysTrueDecorator,
				Value = _iperformeraialwaystruedecorator
			};
		}

		// Token: 0x06019B59 RID: 105305 RVA: 0x003AEAAC File Offset: 0x003ACCAC
		public IPerformerAiConditionDecoratorT AsIPerformerAiConditionDecorator()
		{
			return this.As<IPerformerAiConditionDecoratorT>();
		}

		// Token: 0x06019B5A RID: 105306 RVA: 0x003AEAB4 File Offset: 0x003ACCB4
		public static TPerformerAiDecoratorUnion FromIPerformerAiConditionDecorator(IPerformerAiConditionDecoratorT _iperformeraiconditiondecorator)
		{
			return new TPerformerAiDecoratorUnion
			{
				Type = TPerformerAiDecorator.IPerformerAiConditionDecorator,
				Value = _iperformeraiconditiondecorator
			};
		}

		// Token: 0x06019B5B RID: 105307 RVA: 0x003AEAC9 File Offset: 0x003ACCC9
		public IPerformerAiCoolDownDecoratorT AsIPerformerAiCoolDownDecorator()
		{
			return this.As<IPerformerAiCoolDownDecoratorT>();
		}

		// Token: 0x06019B5C RID: 105308 RVA: 0x003AEAD1 File Offset: 0x003ACCD1
		public static TPerformerAiDecoratorUnion FromIPerformerAiCoolDownDecorator(IPerformerAiCoolDownDecoratorT _iperformeraicooldowndecorator)
		{
			return new TPerformerAiDecoratorUnion
			{
				Type = TPerformerAiDecorator.IPerformerAiCoolDownDecorator,
				Value = _iperformeraicooldowndecorator
			};
		}

		// Token: 0x06019B5D RID: 105309 RVA: 0x003AEAE6 File Offset: 0x003ACCE6
		public IPerformerAiDoOnceDecoratorT AsIPerformerAiDoOnceDecorator()
		{
			return this.As<IPerformerAiDoOnceDecoratorT>();
		}

		// Token: 0x06019B5E RID: 105310 RVA: 0x003AEAEE File Offset: 0x003ACCEE
		public static TPerformerAiDecoratorUnion FromIPerformerAiDoOnceDecorator(IPerformerAiDoOnceDecoratorT _iperformeraidooncedecorator)
		{
			return new TPerformerAiDecoratorUnion
			{
				Type = TPerformerAiDecorator.IPerformerAiDoOnceDecorator,
				Value = _iperformeraidooncedecorator
			};
		}

		// Token: 0x06019B5F RID: 105311 RVA: 0x003AEB04 File Offset: 0x003ACD04
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
