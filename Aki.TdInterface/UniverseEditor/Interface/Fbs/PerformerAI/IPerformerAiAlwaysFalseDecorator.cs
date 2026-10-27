using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004354 RID: 17236
	public struct IPerformerAiAlwaysFalseDecorator : IFlatbufferObject
	{
		// Token: 0x170079A5 RID: 31141
		// (get) Token: 0x060198DE RID: 104670 RVA: 0x003A8A88 File Offset: 0x003A6C88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060198DF RID: 104671 RVA: 0x003A8A95 File Offset: 0x003A6C95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060198E0 RID: 104672 RVA: 0x003A8A9C File Offset: 0x003A6C9C
		public static IPerformerAiAlwaysFalseDecorator GetRootAsIPerformerAiAlwaysFalseDecorator(ByteBuffer _bb)
		{
			return IPerformerAiAlwaysFalseDecorator.GetRootAsIPerformerAiAlwaysFalseDecorator(_bb, default(IPerformerAiAlwaysFalseDecorator));
		}

		// Token: 0x060198E1 RID: 104673 RVA: 0x003A8AB8 File Offset: 0x003A6CB8
		public static IPerformerAiAlwaysFalseDecorator GetRootAsIPerformerAiAlwaysFalseDecorator(ByteBuffer _bb, IPerformerAiAlwaysFalseDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060198E2 RID: 104674 RVA: 0x003A8AD5 File Offset: 0x003A6CD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060198E3 RID: 104675 RVA: 0x003A8AE4 File Offset: 0x003A6CE4
		public IPerformerAiAlwaysFalseDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079A6 RID: 31142
		// (get) Token: 0x060198E4 RID: 104676 RVA: 0x003A8AF4 File Offset: 0x003A6CF4
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

		// Token: 0x060198E5 RID: 104677 RVA: 0x003A8B30 File Offset: 0x003A6D30
		public static Offset<IPerformerAiAlwaysFalseDecorator> CreateIPerformerAiAlwaysFalseDecorator(FlatBufferBuilder builder, EPerformerAiDecoratorType Type = EPerformerAiDecoratorType.Condition)
		{
			builder.StartTable(1);
			IPerformerAiAlwaysFalseDecorator.AddType(builder, Type);
			return IPerformerAiAlwaysFalseDecorator.EndIPerformerAiAlwaysFalseDecorator(builder);
		}

		// Token: 0x060198E6 RID: 104678 RVA: 0x003A8B46 File Offset: 0x003A6D46
		public static void StartIPerformerAiAlwaysFalseDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060198E7 RID: 104679 RVA: 0x003A8B4F File Offset: 0x003A6D4F
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060198E8 RID: 104680 RVA: 0x003A8B5A File Offset: 0x003A6D5A
		public static Offset<IPerformerAiAlwaysFalseDecorator> EndIPerformerAiAlwaysFalseDecorator(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiAlwaysFalseDecorator>(builder.EndTable());
		}

		// Token: 0x060198E9 RID: 104681 RVA: 0x003A8B68 File Offset: 0x003A6D68
		public IPerformerAiAlwaysFalseDecoratorT UnPack()
		{
			IPerformerAiAlwaysFalseDecoratorT performerAiAlwaysFalseDecoratorT = new IPerformerAiAlwaysFalseDecoratorT();
			this.UnPackTo(performerAiAlwaysFalseDecoratorT);
			return performerAiAlwaysFalseDecoratorT;
		}

		// Token: 0x060198EA RID: 104682 RVA: 0x003A8B83 File Offset: 0x003A6D83
		public void UnPackTo(IPerformerAiAlwaysFalseDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060198EB RID: 104683 RVA: 0x003A8B94 File Offset: 0x003A6D94
		public static Offset<IPerformerAiAlwaysFalseDecorator> Pack(FlatBufferBuilder builder, IPerformerAiAlwaysFalseDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiAlwaysFalseDecorator>);
			}
			return IPerformerAiAlwaysFalseDecorator.CreateIPerformerAiAlwaysFalseDecorator(builder, _o.Type);
		}

		// Token: 0x0400C145 RID: 49477
		private Table __p;
	}
}
