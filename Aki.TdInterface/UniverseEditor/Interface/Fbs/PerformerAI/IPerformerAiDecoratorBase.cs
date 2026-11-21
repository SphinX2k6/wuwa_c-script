using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047C5 RID: 18373
	public struct IPerformerAiDecoratorBase : IFlatbufferObject
	{
		// Token: 0x17007FF7 RID: 32759
		// (get) Token: 0x0601B0EA RID: 110826 RVA: 0x003D5216 File Offset: 0x003D3416
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B0EB RID: 110827 RVA: 0x003D5223 File Offset: 0x003D3423
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B0EC RID: 110828 RVA: 0x003D522C File Offset: 0x003D342C
		public static IPerformerAiDecoratorBase GetRootAsIPerformerAiDecoratorBase(ByteBuffer _bb)
		{
			return IPerformerAiDecoratorBase.GetRootAsIPerformerAiDecoratorBase(_bb, default(IPerformerAiDecoratorBase));
		}

		// Token: 0x0601B0ED RID: 110829 RVA: 0x003D5248 File Offset: 0x003D3448
		public static IPerformerAiDecoratorBase GetRootAsIPerformerAiDecoratorBase(ByteBuffer _bb, IPerformerAiDecoratorBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B0EE RID: 110830 RVA: 0x003D5265 File Offset: 0x003D3465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B0EF RID: 110831 RVA: 0x003D5274 File Offset: 0x003D3474
		public IPerformerAiDecoratorBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FF8 RID: 32760
		// (get) Token: 0x0601B0F0 RID: 110832 RVA: 0x003D5284 File Offset: 0x003D3484
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

		// Token: 0x0601B0F1 RID: 110833 RVA: 0x003D52C0 File Offset: 0x003D34C0
		public static Offset<IPerformerAiDecoratorBase> CreateIPerformerAiDecoratorBase(FlatBufferBuilder builder, EPerformerAiDecoratorType Type = EPerformerAiDecoratorType.Condition)
		{
			builder.StartTable(1);
			IPerformerAiDecoratorBase.AddType(builder, Type);
			return IPerformerAiDecoratorBase.EndIPerformerAiDecoratorBase(builder);
		}

		// Token: 0x0601B0F2 RID: 110834 RVA: 0x003D52D6 File Offset: 0x003D34D6
		public static void StartIPerformerAiDecoratorBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B0F3 RID: 110835 RVA: 0x003D52DF File Offset: 0x003D34DF
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B0F4 RID: 110836 RVA: 0x003D52EA File Offset: 0x003D34EA
		public static Offset<IPerformerAiDecoratorBase> EndIPerformerAiDecoratorBase(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiDecoratorBase>(builder.EndTable());
		}

		// Token: 0x0601B0F5 RID: 110837 RVA: 0x003D52F8 File Offset: 0x003D34F8
		public IPerformerAiDecoratorBaseT UnPack()
		{
			IPerformerAiDecoratorBaseT performerAiDecoratorBaseT = new IPerformerAiDecoratorBaseT();
			this.UnPackTo(performerAiDecoratorBaseT);
			return performerAiDecoratorBaseT;
		}

		// Token: 0x0601B0F6 RID: 110838 RVA: 0x003D5313 File Offset: 0x003D3513
		public void UnPackTo(IPerformerAiDecoratorBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B0F7 RID: 110839 RVA: 0x003D5324 File Offset: 0x003D3524
		public static Offset<IPerformerAiDecoratorBase> Pack(FlatBufferBuilder builder, IPerformerAiDecoratorBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiDecoratorBase>);
			}
			return IPerformerAiDecoratorBase.CreateIPerformerAiDecoratorBase(builder, _o.Type);
		}

		// Token: 0x0400CB74 RID: 52084
		private Table __p;
	}
}
