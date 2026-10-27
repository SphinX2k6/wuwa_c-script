using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004357 RID: 17239
	public struct IPerformerAiAlwaysTrueDecorator : IFlatbufferObject
	{
		// Token: 0x170079A8 RID: 31144
		// (get) Token: 0x060198F0 RID: 104688 RVA: 0x003A8BFD File Offset: 0x003A6DFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060198F1 RID: 104689 RVA: 0x003A8C0A File Offset: 0x003A6E0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060198F2 RID: 104690 RVA: 0x003A8C14 File Offset: 0x003A6E14
		public static IPerformerAiAlwaysTrueDecorator GetRootAsIPerformerAiAlwaysTrueDecorator(ByteBuffer _bb)
		{
			return IPerformerAiAlwaysTrueDecorator.GetRootAsIPerformerAiAlwaysTrueDecorator(_bb, default(IPerformerAiAlwaysTrueDecorator));
		}

		// Token: 0x060198F3 RID: 104691 RVA: 0x003A8C30 File Offset: 0x003A6E30
		public static IPerformerAiAlwaysTrueDecorator GetRootAsIPerformerAiAlwaysTrueDecorator(ByteBuffer _bb, IPerformerAiAlwaysTrueDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060198F4 RID: 104692 RVA: 0x003A8C4D File Offset: 0x003A6E4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060198F5 RID: 104693 RVA: 0x003A8C5C File Offset: 0x003A6E5C
		public IPerformerAiAlwaysTrueDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079A9 RID: 31145
		// (get) Token: 0x060198F6 RID: 104694 RVA: 0x003A8C6C File Offset: 0x003A6E6C
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

		// Token: 0x060198F7 RID: 104695 RVA: 0x003A8CA8 File Offset: 0x003A6EA8
		public static Offset<IPerformerAiAlwaysTrueDecorator> CreateIPerformerAiAlwaysTrueDecorator(FlatBufferBuilder builder, EPerformerAiDecoratorType Type = EPerformerAiDecoratorType.Condition)
		{
			builder.StartTable(1);
			IPerformerAiAlwaysTrueDecorator.AddType(builder, Type);
			return IPerformerAiAlwaysTrueDecorator.EndIPerformerAiAlwaysTrueDecorator(builder);
		}

		// Token: 0x060198F8 RID: 104696 RVA: 0x003A8CBE File Offset: 0x003A6EBE
		public static void StartIPerformerAiAlwaysTrueDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060198F9 RID: 104697 RVA: 0x003A8CC7 File Offset: 0x003A6EC7
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060198FA RID: 104698 RVA: 0x003A8CD2 File Offset: 0x003A6ED2
		public static Offset<IPerformerAiAlwaysTrueDecorator> EndIPerformerAiAlwaysTrueDecorator(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiAlwaysTrueDecorator>(builder.EndTable());
		}

		// Token: 0x060198FB RID: 104699 RVA: 0x003A8CE0 File Offset: 0x003A6EE0
		public IPerformerAiAlwaysTrueDecoratorT UnPack()
		{
			IPerformerAiAlwaysTrueDecoratorT performerAiAlwaysTrueDecoratorT = new IPerformerAiAlwaysTrueDecoratorT();
			this.UnPackTo(performerAiAlwaysTrueDecoratorT);
			return performerAiAlwaysTrueDecoratorT;
		}

		// Token: 0x060198FC RID: 104700 RVA: 0x003A8CFB File Offset: 0x003A6EFB
		public void UnPackTo(IPerformerAiAlwaysTrueDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060198FD RID: 104701 RVA: 0x003A8D0C File Offset: 0x003A6F0C
		public static Offset<IPerformerAiAlwaysTrueDecorator> Pack(FlatBufferBuilder builder, IPerformerAiAlwaysTrueDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiAlwaysTrueDecorator>);
			}
			return IPerformerAiAlwaysTrueDecorator.CreateIPerformerAiAlwaysTrueDecorator(builder, _o.Type);
		}

		// Token: 0x0400C147 RID: 49479
		private Table __p;
	}
}
