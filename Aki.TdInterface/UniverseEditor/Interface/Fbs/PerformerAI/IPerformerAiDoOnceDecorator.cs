using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004369 RID: 17257
	public struct IPerformerAiDoOnceDecorator : IFlatbufferObject
	{
		// Token: 0x170079C7 RID: 31175
		// (get) Token: 0x06019982 RID: 104834 RVA: 0x003A9B76 File Offset: 0x003A7D76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019983 RID: 104835 RVA: 0x003A9B83 File Offset: 0x003A7D83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019984 RID: 104836 RVA: 0x003A9B8C File Offset: 0x003A7D8C
		public static IPerformerAiDoOnceDecorator GetRootAsIPerformerAiDoOnceDecorator(ByteBuffer _bb)
		{
			return IPerformerAiDoOnceDecorator.GetRootAsIPerformerAiDoOnceDecorator(_bb, default(IPerformerAiDoOnceDecorator));
		}

		// Token: 0x06019985 RID: 104837 RVA: 0x003A9BA8 File Offset: 0x003A7DA8
		public static IPerformerAiDoOnceDecorator GetRootAsIPerformerAiDoOnceDecorator(ByteBuffer _bb, IPerformerAiDoOnceDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019986 RID: 104838 RVA: 0x003A9BC5 File Offset: 0x003A7DC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019987 RID: 104839 RVA: 0x003A9BD4 File Offset: 0x003A7DD4
		public IPerformerAiDoOnceDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079C8 RID: 31176
		// (get) Token: 0x06019988 RID: 104840 RVA: 0x003A9BE4 File Offset: 0x003A7DE4
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

		// Token: 0x06019989 RID: 104841 RVA: 0x003A9C20 File Offset: 0x003A7E20
		public static Offset<IPerformerAiDoOnceDecorator> CreateIPerformerAiDoOnceDecorator(FlatBufferBuilder builder, EPerformerAiDecoratorType Type = EPerformerAiDecoratorType.Condition)
		{
			builder.StartTable(1);
			IPerformerAiDoOnceDecorator.AddType(builder, Type);
			return IPerformerAiDoOnceDecorator.EndIPerformerAiDoOnceDecorator(builder);
		}

		// Token: 0x0601998A RID: 104842 RVA: 0x003A9C36 File Offset: 0x003A7E36
		public static void StartIPerformerAiDoOnceDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601998B RID: 104843 RVA: 0x003A9C3F File Offset: 0x003A7E3F
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601998C RID: 104844 RVA: 0x003A9C4A File Offset: 0x003A7E4A
		public static Offset<IPerformerAiDoOnceDecorator> EndIPerformerAiDoOnceDecorator(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiDoOnceDecorator>(builder.EndTable());
		}

		// Token: 0x0601998D RID: 104845 RVA: 0x003A9C58 File Offset: 0x003A7E58
		public IPerformerAiDoOnceDecoratorT UnPack()
		{
			IPerformerAiDoOnceDecoratorT performerAiDoOnceDecoratorT = new IPerformerAiDoOnceDecoratorT();
			this.UnPackTo(performerAiDoOnceDecoratorT);
			return performerAiDoOnceDecoratorT;
		}

		// Token: 0x0601998E RID: 104846 RVA: 0x003A9C73 File Offset: 0x003A7E73
		public void UnPackTo(IPerformerAiDoOnceDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601998F RID: 104847 RVA: 0x003A9C84 File Offset: 0x003A7E84
		public static Offset<IPerformerAiDoOnceDecorator> Pack(FlatBufferBuilder builder, IPerformerAiDoOnceDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiDoOnceDecorator>);
			}
			return IPerformerAiDoOnceDecorator.CreateIPerformerAiDoOnceDecorator(builder, _o.Type);
		}

		// Token: 0x0400C162 RID: 49506
		private Table __p;
	}
}
