using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047C2 RID: 18370
	public struct IPerformerAiCoolDownDecorator : IFlatbufferObject
	{
		// Token: 0x17007FF2 RID: 32754
		// (get) Token: 0x0601B0D4 RID: 110804 RVA: 0x003D5017 File Offset: 0x003D3217
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B0D5 RID: 110805 RVA: 0x003D5024 File Offset: 0x003D3224
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B0D6 RID: 110806 RVA: 0x003D502C File Offset: 0x003D322C
		public static IPerformerAiCoolDownDecorator GetRootAsIPerformerAiCoolDownDecorator(ByteBuffer _bb)
		{
			return IPerformerAiCoolDownDecorator.GetRootAsIPerformerAiCoolDownDecorator(_bb, default(IPerformerAiCoolDownDecorator));
		}

		// Token: 0x0601B0D7 RID: 110807 RVA: 0x003D5048 File Offset: 0x003D3248
		public static IPerformerAiCoolDownDecorator GetRootAsIPerformerAiCoolDownDecorator(ByteBuffer _bb, IPerformerAiCoolDownDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B0D8 RID: 110808 RVA: 0x003D5065 File Offset: 0x003D3265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B0D9 RID: 110809 RVA: 0x003D5074 File Offset: 0x003D3274
		public IPerformerAiCoolDownDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FF3 RID: 32755
		// (get) Token: 0x0601B0DA RID: 110810 RVA: 0x003D5084 File Offset: 0x003D3284
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

		// Token: 0x17007FF4 RID: 32756
		// (get) Token: 0x0601B0DB RID: 110811 RVA: 0x003D50C0 File Offset: 0x003D32C0
		public int CoolDown
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B0DC RID: 110812 RVA: 0x003D50FC File Offset: 0x003D32FC
		public static Offset<IPerformerAiCoolDownDecorator> CreateIPerformerAiCoolDownDecorator(FlatBufferBuilder builder, EPerformerAiDecoratorType Type = EPerformerAiDecoratorType.Condition, int CoolDown = 0)
		{
			builder.StartTable(2);
			IPerformerAiCoolDownDecorator.AddCoolDown(builder, CoolDown);
			IPerformerAiCoolDownDecorator.AddType(builder, Type);
			return IPerformerAiCoolDownDecorator.EndIPerformerAiCoolDownDecorator(builder);
		}

		// Token: 0x0601B0DD RID: 110813 RVA: 0x003D5119 File Offset: 0x003D3319
		public static void StartIPerformerAiCoolDownDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B0DE RID: 110814 RVA: 0x003D5122 File Offset: 0x003D3322
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B0DF RID: 110815 RVA: 0x003D512D File Offset: 0x003D332D
		public static void AddCoolDown(FlatBufferBuilder builder, int coolDown)
		{
			builder.AddInt(1, coolDown, 0);
		}

		// Token: 0x0601B0E0 RID: 110816 RVA: 0x003D5138 File Offset: 0x003D3338
		public static Offset<IPerformerAiCoolDownDecorator> EndIPerformerAiCoolDownDecorator(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiCoolDownDecorator>(builder.EndTable());
		}

		// Token: 0x0601B0E1 RID: 110817 RVA: 0x003D5148 File Offset: 0x003D3348
		public IPerformerAiCoolDownDecoratorT UnPack()
		{
			IPerformerAiCoolDownDecoratorT performerAiCoolDownDecoratorT = new IPerformerAiCoolDownDecoratorT();
			this.UnPackTo(performerAiCoolDownDecoratorT);
			return performerAiCoolDownDecoratorT;
		}

		// Token: 0x0601B0E2 RID: 110818 RVA: 0x003D5163 File Offset: 0x003D3363
		public void UnPackTo(IPerformerAiCoolDownDecoratorT _o)
		{
			_o.Type = this.Type;
			_o.CoolDown = this.CoolDown;
		}

		// Token: 0x0601B0E3 RID: 110819 RVA: 0x003D5180 File Offset: 0x003D3380
		public static Offset<IPerformerAiCoolDownDecorator> Pack(FlatBufferBuilder builder, IPerformerAiCoolDownDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiCoolDownDecorator>);
			}
			return IPerformerAiCoolDownDecorator.CreateIPerformerAiCoolDownDecorator(builder, _o.Type, _o.CoolDown);
		}

		// Token: 0x0400CB71 RID: 52081
		private Table __p;
	}
}
