using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047B9 RID: 18361
	public struct IPerformerAiAlwaysTrueDecorator : IFlatbufferObject
	{
		// Token: 0x17007FDD RID: 32733
		// (get) Token: 0x0601B07E RID: 110718 RVA: 0x003D4625 File Offset: 0x003D2825
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B07F RID: 110719 RVA: 0x003D4632 File Offset: 0x003D2832
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B080 RID: 110720 RVA: 0x003D463C File Offset: 0x003D283C
		public static IPerformerAiAlwaysTrueDecorator GetRootAsIPerformerAiAlwaysTrueDecorator(ByteBuffer _bb)
		{
			return IPerformerAiAlwaysTrueDecorator.GetRootAsIPerformerAiAlwaysTrueDecorator(_bb, default(IPerformerAiAlwaysTrueDecorator));
		}

		// Token: 0x0601B081 RID: 110721 RVA: 0x003D4658 File Offset: 0x003D2858
		public static IPerformerAiAlwaysTrueDecorator GetRootAsIPerformerAiAlwaysTrueDecorator(ByteBuffer _bb, IPerformerAiAlwaysTrueDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B082 RID: 110722 RVA: 0x003D4675 File Offset: 0x003D2875
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B083 RID: 110723 RVA: 0x003D4684 File Offset: 0x003D2884
		public IPerformerAiAlwaysTrueDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FDE RID: 32734
		// (get) Token: 0x0601B084 RID: 110724 RVA: 0x003D4694 File Offset: 0x003D2894
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

		// Token: 0x0601B085 RID: 110725 RVA: 0x003D46D0 File Offset: 0x003D28D0
		public static Offset<IPerformerAiAlwaysTrueDecorator> CreateIPerformerAiAlwaysTrueDecorator(FlatBufferBuilder builder, EPerformerAiDecoratorType Type = EPerformerAiDecoratorType.Condition)
		{
			builder.StartTable(1);
			IPerformerAiAlwaysTrueDecorator.AddType(builder, Type);
			return IPerformerAiAlwaysTrueDecorator.EndIPerformerAiAlwaysTrueDecorator(builder);
		}

		// Token: 0x0601B086 RID: 110726 RVA: 0x003D46E6 File Offset: 0x003D28E6
		public static void StartIPerformerAiAlwaysTrueDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B087 RID: 110727 RVA: 0x003D46EF File Offset: 0x003D28EF
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B088 RID: 110728 RVA: 0x003D46FA File Offset: 0x003D28FA
		public static Offset<IPerformerAiAlwaysTrueDecorator> EndIPerformerAiAlwaysTrueDecorator(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiAlwaysTrueDecorator>(builder.EndTable());
		}

		// Token: 0x0601B089 RID: 110729 RVA: 0x003D4708 File Offset: 0x003D2908
		public IPerformerAiAlwaysTrueDecoratorT UnPack()
		{
			IPerformerAiAlwaysTrueDecoratorT performerAiAlwaysTrueDecoratorT = new IPerformerAiAlwaysTrueDecoratorT();
			this.UnPackTo(performerAiAlwaysTrueDecoratorT);
			return performerAiAlwaysTrueDecoratorT;
		}

		// Token: 0x0601B08A RID: 110730 RVA: 0x003D4723 File Offset: 0x003D2923
		public void UnPackTo(IPerformerAiAlwaysTrueDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B08B RID: 110731 RVA: 0x003D4734 File Offset: 0x003D2934
		public static Offset<IPerformerAiAlwaysTrueDecorator> Pack(FlatBufferBuilder builder, IPerformerAiAlwaysTrueDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiAlwaysTrueDecorator>);
			}
			return IPerformerAiAlwaysTrueDecorator.CreateIPerformerAiAlwaysTrueDecorator(builder, _o.Type);
		}

		// Token: 0x0400CB65 RID: 52069
		private Table __p;
	}
}
