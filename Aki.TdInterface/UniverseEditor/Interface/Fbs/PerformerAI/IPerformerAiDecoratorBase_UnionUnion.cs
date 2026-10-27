using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004367 RID: 17255
	public class IPerformerAiDecoratorBase_UnionUnion
	{
		// Token: 0x170079C5 RID: 31173
		// (get) Token: 0x0601996E RID: 104814 RVA: 0x003A9965 File Offset: 0x003A7B65
		// (set) Token: 0x0601996F RID: 104815 RVA: 0x003A996D File Offset: 0x003A7B6D
		public IPerformerAiDecoratorBase_Union Type { get; set; }

		// Token: 0x170079C6 RID: 31174
		// (get) Token: 0x06019970 RID: 104816 RVA: 0x003A9976 File Offset: 0x003A7B76
		// (set) Token: 0x06019971 RID: 104817 RVA: 0x003A997E File Offset: 0x003A7B7E
		public object Value { get; set; }

		// Token: 0x06019972 RID: 104818 RVA: 0x003A9987 File Offset: 0x003A7B87
		public IPerformerAiDecoratorBase_UnionUnion()
		{
			this.Type = IPerformerAiDecoratorBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019973 RID: 104819 RVA: 0x003A999D File Offset: 0x003A7B9D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019974 RID: 104820 RVA: 0x003A99AF File Offset: 0x003A7BAF
		public IPerformerAiDecoratorBaseT AsIPerformerAiDecoratorBase()
		{
			return this.As<IPerformerAiDecoratorBaseT>();
		}

		// Token: 0x06019975 RID: 104821 RVA: 0x003A99B7 File Offset: 0x003A7BB7
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiDecoratorBase(IPerformerAiDecoratorBaseT _iperformeraidecoratorbase)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiDecoratorBase,
				Value = _iperformeraidecoratorbase
			};
		}

		// Token: 0x06019976 RID: 104822 RVA: 0x003A99CC File Offset: 0x003A7BCC
		public IPerformerAiConditionDecoratorT AsIPerformerAiConditionDecorator()
		{
			return this.As<IPerformerAiConditionDecoratorT>();
		}

		// Token: 0x06019977 RID: 104823 RVA: 0x003A99D4 File Offset: 0x003A7BD4
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiConditionDecorator(IPerformerAiConditionDecoratorT _iperformeraiconditiondecorator)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiConditionDecorator,
				Value = _iperformeraiconditiondecorator
			};
		}

		// Token: 0x06019978 RID: 104824 RVA: 0x003A99E9 File Offset: 0x003A7BE9
		public IPerformerAiAlwaysFalseDecoratorT AsIPerformerAiAlwaysFalseDecorator()
		{
			return this.As<IPerformerAiAlwaysFalseDecoratorT>();
		}

		// Token: 0x06019979 RID: 104825 RVA: 0x003A99F1 File Offset: 0x003A7BF1
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiAlwaysFalseDecorator(IPerformerAiAlwaysFalseDecoratorT _iperformeraialwaysfalsedecorator)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiAlwaysFalseDecorator,
				Value = _iperformeraialwaysfalsedecorator
			};
		}

		// Token: 0x0601997A RID: 104826 RVA: 0x003A9A06 File Offset: 0x003A7C06
		public IPerformerAiAlwaysTrueDecoratorT AsIPerformerAiAlwaysTrueDecorator()
		{
			return this.As<IPerformerAiAlwaysTrueDecoratorT>();
		}

		// Token: 0x0601997B RID: 104827 RVA: 0x003A9A0E File Offset: 0x003A7C0E
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiAlwaysTrueDecorator(IPerformerAiAlwaysTrueDecoratorT _iperformeraialwaystruedecorator)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiAlwaysTrueDecorator,
				Value = _iperformeraialwaystruedecorator
			};
		}

		// Token: 0x0601997C RID: 104828 RVA: 0x003A9A23 File Offset: 0x003A7C23
		public IPerformerAiDoOnceDecoratorT AsIPerformerAiDoOnceDecorator()
		{
			return this.As<IPerformerAiDoOnceDecoratorT>();
		}

		// Token: 0x0601997D RID: 104829 RVA: 0x003A9A2B File Offset: 0x003A7C2B
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiDoOnceDecorator(IPerformerAiDoOnceDecoratorT _iperformeraidooncedecorator)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiDoOnceDecorator,
				Value = _iperformeraidooncedecorator
			};
		}

		// Token: 0x0601997E RID: 104830 RVA: 0x003A9A40 File Offset: 0x003A7C40
		public IPerformerAiCoolDownDecoratorT AsIPerformerAiCoolDownDecorator()
		{
			return this.As<IPerformerAiCoolDownDecoratorT>();
		}

		// Token: 0x0601997F RID: 104831 RVA: 0x003A9A48 File Offset: 0x003A7C48
		public static IPerformerAiDecoratorBase_UnionUnion FromIPerformerAiCoolDownDecorator(IPerformerAiCoolDownDecoratorT _iperformeraicooldowndecorator)
		{
			return new IPerformerAiDecoratorBase_UnionUnion
			{
				Type = IPerformerAiDecoratorBase_Union.IPerformerAiCoolDownDecorator,
				Value = _iperformeraicooldowndecorator
			};
		}

		// Token: 0x06019980 RID: 104832 RVA: 0x003A9A60 File Offset: 0x003A7C60
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
