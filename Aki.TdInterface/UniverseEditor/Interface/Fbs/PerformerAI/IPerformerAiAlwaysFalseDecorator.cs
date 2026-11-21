using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047B6 RID: 18358
	public struct IPerformerAiAlwaysFalseDecorator : IFlatbufferObject
	{
		// Token: 0x17007FDA RID: 32730
		// (get) Token: 0x0601B06C RID: 110700 RVA: 0x003D44B0 File Offset: 0x003D26B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B06D RID: 110701 RVA: 0x003D44BD File Offset: 0x003D26BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B06E RID: 110702 RVA: 0x003D44C4 File Offset: 0x003D26C4
		public static IPerformerAiAlwaysFalseDecorator GetRootAsIPerformerAiAlwaysFalseDecorator(ByteBuffer _bb)
		{
			return IPerformerAiAlwaysFalseDecorator.GetRootAsIPerformerAiAlwaysFalseDecorator(_bb, default(IPerformerAiAlwaysFalseDecorator));
		}

		// Token: 0x0601B06F RID: 110703 RVA: 0x003D44E0 File Offset: 0x003D26E0
		public static IPerformerAiAlwaysFalseDecorator GetRootAsIPerformerAiAlwaysFalseDecorator(ByteBuffer _bb, IPerformerAiAlwaysFalseDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B070 RID: 110704 RVA: 0x003D44FD File Offset: 0x003D26FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B071 RID: 110705 RVA: 0x003D450C File Offset: 0x003D270C
		public IPerformerAiAlwaysFalseDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FDB RID: 32731
		// (get) Token: 0x0601B072 RID: 110706 RVA: 0x003D451C File Offset: 0x003D271C
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

		// Token: 0x0601B073 RID: 110707 RVA: 0x003D4558 File Offset: 0x003D2758
		public static Offset<IPerformerAiAlwaysFalseDecorator> CreateIPerformerAiAlwaysFalseDecorator(FlatBufferBuilder builder, EPerformerAiDecoratorType Type = EPerformerAiDecoratorType.Condition)
		{
			builder.StartTable(1);
			IPerformerAiAlwaysFalseDecorator.AddType(builder, Type);
			return IPerformerAiAlwaysFalseDecorator.EndIPerformerAiAlwaysFalseDecorator(builder);
		}

		// Token: 0x0601B074 RID: 110708 RVA: 0x003D456E File Offset: 0x003D276E
		public static void StartIPerformerAiAlwaysFalseDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B075 RID: 110709 RVA: 0x003D4577 File Offset: 0x003D2777
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B076 RID: 110710 RVA: 0x003D4582 File Offset: 0x003D2782
		public static Offset<IPerformerAiAlwaysFalseDecorator> EndIPerformerAiAlwaysFalseDecorator(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiAlwaysFalseDecorator>(builder.EndTable());
		}

		// Token: 0x0601B077 RID: 110711 RVA: 0x003D4590 File Offset: 0x003D2790
		public IPerformerAiAlwaysFalseDecoratorT UnPack()
		{
			IPerformerAiAlwaysFalseDecoratorT performerAiAlwaysFalseDecoratorT = new IPerformerAiAlwaysFalseDecoratorT();
			this.UnPackTo(performerAiAlwaysFalseDecoratorT);
			return performerAiAlwaysFalseDecoratorT;
		}

		// Token: 0x0601B078 RID: 110712 RVA: 0x003D45AB File Offset: 0x003D27AB
		public void UnPackTo(IPerformerAiAlwaysFalseDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B079 RID: 110713 RVA: 0x003D45BC File Offset: 0x003D27BC
		public static Offset<IPerformerAiAlwaysFalseDecorator> Pack(FlatBufferBuilder builder, IPerformerAiAlwaysFalseDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiAlwaysFalseDecorator>);
			}
			return IPerformerAiAlwaysFalseDecorator.CreateIPerformerAiAlwaysFalseDecorator(builder, _o.Type);
		}

		// Token: 0x0400CB63 RID: 52067
		private Table __p;
	}
}
