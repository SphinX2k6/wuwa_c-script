using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004360 RID: 17248
	public struct IPerformerAiCoolDownDecorator : IFlatbufferObject
	{
		// Token: 0x170079BD RID: 31165
		// (get) Token: 0x06019946 RID: 104774 RVA: 0x003A95EF File Offset: 0x003A77EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019947 RID: 104775 RVA: 0x003A95FC File Offset: 0x003A77FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019948 RID: 104776 RVA: 0x003A9604 File Offset: 0x003A7804
		public static IPerformerAiCoolDownDecorator GetRootAsIPerformerAiCoolDownDecorator(ByteBuffer _bb)
		{
			return IPerformerAiCoolDownDecorator.GetRootAsIPerformerAiCoolDownDecorator(_bb, default(IPerformerAiCoolDownDecorator));
		}

		// Token: 0x06019949 RID: 104777 RVA: 0x003A9620 File Offset: 0x003A7820
		public static IPerformerAiCoolDownDecorator GetRootAsIPerformerAiCoolDownDecorator(ByteBuffer _bb, IPerformerAiCoolDownDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601994A RID: 104778 RVA: 0x003A963D File Offset: 0x003A783D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601994B RID: 104779 RVA: 0x003A964C File Offset: 0x003A784C
		public IPerformerAiCoolDownDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079BE RID: 31166
		// (get) Token: 0x0601994C RID: 104780 RVA: 0x003A965C File Offset: 0x003A785C
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

		// Token: 0x170079BF RID: 31167
		// (get) Token: 0x0601994D RID: 104781 RVA: 0x003A9698 File Offset: 0x003A7898
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

		// Token: 0x0601994E RID: 104782 RVA: 0x003A96D4 File Offset: 0x003A78D4
		public static Offset<IPerformerAiCoolDownDecorator> CreateIPerformerAiCoolDownDecorator(FlatBufferBuilder builder, EPerformerAiDecoratorType Type = EPerformerAiDecoratorType.Condition, int CoolDown = 0)
		{
			builder.StartTable(2);
			IPerformerAiCoolDownDecorator.AddCoolDown(builder, CoolDown);
			IPerformerAiCoolDownDecorator.AddType(builder, Type);
			return IPerformerAiCoolDownDecorator.EndIPerformerAiCoolDownDecorator(builder);
		}

		// Token: 0x0601994F RID: 104783 RVA: 0x003A96F1 File Offset: 0x003A78F1
		public static void StartIPerformerAiCoolDownDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019950 RID: 104784 RVA: 0x003A96FA File Offset: 0x003A78FA
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019951 RID: 104785 RVA: 0x003A9705 File Offset: 0x003A7905
		public static void AddCoolDown(FlatBufferBuilder builder, int coolDown)
		{
			builder.AddInt(1, coolDown, 0);
		}

		// Token: 0x06019952 RID: 104786 RVA: 0x003A9710 File Offset: 0x003A7910
		public static Offset<IPerformerAiCoolDownDecorator> EndIPerformerAiCoolDownDecorator(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiCoolDownDecorator>(builder.EndTable());
		}

		// Token: 0x06019953 RID: 104787 RVA: 0x003A9720 File Offset: 0x003A7920
		public IPerformerAiCoolDownDecoratorT UnPack()
		{
			IPerformerAiCoolDownDecoratorT performerAiCoolDownDecoratorT = new IPerformerAiCoolDownDecoratorT();
			this.UnPackTo(performerAiCoolDownDecoratorT);
			return performerAiCoolDownDecoratorT;
		}

		// Token: 0x06019954 RID: 104788 RVA: 0x003A973B File Offset: 0x003A793B
		public void UnPackTo(IPerformerAiCoolDownDecoratorT _o)
		{
			_o.Type = this.Type;
			_o.CoolDown = this.CoolDown;
		}

		// Token: 0x06019955 RID: 104789 RVA: 0x003A9758 File Offset: 0x003A7958
		public static Offset<IPerformerAiCoolDownDecorator> Pack(FlatBufferBuilder builder, IPerformerAiCoolDownDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiCoolDownDecorator>);
			}
			return IPerformerAiCoolDownDecorator.CreateIPerformerAiCoolDownDecorator(builder, _o.Type, _o.CoolDown);
		}

		// Token: 0x0400C153 RID: 49491
		private Table __p;
	}
}
