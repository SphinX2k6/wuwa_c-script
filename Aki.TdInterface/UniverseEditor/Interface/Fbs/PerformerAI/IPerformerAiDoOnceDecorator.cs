using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047CB RID: 18379
	public struct IPerformerAiDoOnceDecorator : IFlatbufferObject
	{
		// Token: 0x17007FFC RID: 32764
		// (get) Token: 0x0601B110 RID: 110864 RVA: 0x003D559E File Offset: 0x003D379E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B111 RID: 110865 RVA: 0x003D55AB File Offset: 0x003D37AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B112 RID: 110866 RVA: 0x003D55B4 File Offset: 0x003D37B4
		public static IPerformerAiDoOnceDecorator GetRootAsIPerformerAiDoOnceDecorator(ByteBuffer _bb)
		{
			return IPerformerAiDoOnceDecorator.GetRootAsIPerformerAiDoOnceDecorator(_bb, default(IPerformerAiDoOnceDecorator));
		}

		// Token: 0x0601B113 RID: 110867 RVA: 0x003D55D0 File Offset: 0x003D37D0
		public static IPerformerAiDoOnceDecorator GetRootAsIPerformerAiDoOnceDecorator(ByteBuffer _bb, IPerformerAiDoOnceDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B114 RID: 110868 RVA: 0x003D55ED File Offset: 0x003D37ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B115 RID: 110869 RVA: 0x003D55FC File Offset: 0x003D37FC
		public IPerformerAiDoOnceDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FFD RID: 32765
		// (get) Token: 0x0601B116 RID: 110870 RVA: 0x003D560C File Offset: 0x003D380C
		public EPerformerAiDecoratorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiDecoratorType.Condition;
				}
				return (EPerformerAiDecoratorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B117 RID: 110871 RVA: 0x003D5648 File Offset: 0x003D3848
		public static Offset<IPerformerAiDoOnceDecorator> CreateIPerformerAiDoOnceDecorator(FlatBufferBuilder builder, EPerformerAiDecoratorType Type = EPerformerAiDecoratorType.Condition)
		{
			builder.StartTable(1);
			IPerformerAiDoOnceDecorator.AddType(builder, Type);
			return IPerformerAiDoOnceDecorator.EndIPerformerAiDoOnceDecorator(builder);
		}

		// Token: 0x0601B118 RID: 110872 RVA: 0x003D565E File Offset: 0x003D385E
		public static void StartIPerformerAiDoOnceDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B119 RID: 110873 RVA: 0x003D5667 File Offset: 0x003D3867
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B11A RID: 110874 RVA: 0x003D5672 File Offset: 0x003D3872
		public static Offset<IPerformerAiDoOnceDecorator> EndIPerformerAiDoOnceDecorator(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiDoOnceDecorator>(builder.EndTable());
		}

		// Token: 0x0601B11B RID: 110875 RVA: 0x003D5680 File Offset: 0x003D3880
		public IPerformerAiDoOnceDecoratorT UnPack()
		{
			IPerformerAiDoOnceDecoratorT performerAiDoOnceDecoratorT = new IPerformerAiDoOnceDecoratorT();
			this.UnPackTo(performerAiDoOnceDecoratorT);
			return performerAiDoOnceDecoratorT;
		}

		// Token: 0x0601B11C RID: 110876 RVA: 0x003D569B File Offset: 0x003D389B
		public void UnPackTo(IPerformerAiDoOnceDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B11D RID: 110877 RVA: 0x003D56AC File Offset: 0x003D38AC
		public static Offset<IPerformerAiDoOnceDecorator> Pack(FlatBufferBuilder builder, IPerformerAiDoOnceDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiDoOnceDecorator>);
			}
			return IPerformerAiDoOnceDecorator.CreateIPerformerAiDoOnceDecorator(builder, _o.Type);
		}

		// Token: 0x0400CB80 RID: 52096
		private Table __p;
	}
}
