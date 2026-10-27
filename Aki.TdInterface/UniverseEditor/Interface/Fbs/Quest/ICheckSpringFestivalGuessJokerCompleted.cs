using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D6D RID: 15725
	public struct ICheckSpringFestivalGuessJokerCompleted : IFlatbufferObject
	{
		// Token: 0x17006BE6 RID: 27622
		// (get) Token: 0x06015C25 RID: 89125 RVA: 0x00323428 File Offset: 0x00321628
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015C26 RID: 89126 RVA: 0x00323435 File Offset: 0x00321635
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015C27 RID: 89127 RVA: 0x0032343C File Offset: 0x0032163C
		public static ICheckSpringFestivalGuessJokerCompleted GetRootAsICheckSpringFestivalGuessJokerCompleted(ByteBuffer _bb)
		{
			return ICheckSpringFestivalGuessJokerCompleted.GetRootAsICheckSpringFestivalGuessJokerCompleted(_bb, default(ICheckSpringFestivalGuessJokerCompleted));
		}

		// Token: 0x06015C28 RID: 89128 RVA: 0x00323458 File Offset: 0x00321658
		public static ICheckSpringFestivalGuessJokerCompleted GetRootAsICheckSpringFestivalGuessJokerCompleted(ByteBuffer _bb, ICheckSpringFestivalGuessJokerCompleted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015C29 RID: 89129 RVA: 0x00323475 File Offset: 0x00321675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015C2A RID: 89130 RVA: 0x00323484 File Offset: 0x00321684
		public ICheckSpringFestivalGuessJokerCompleted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BE7 RID: 27623
		// (get) Token: 0x06015C2B RID: 89131 RVA: 0x00323494 File Offset: 0x00321694
		public ESpringFestivalGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpringFestivalGameplayType.MixDrinks;
				}
				return (ESpringFestivalGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BE8 RID: 27624
		// (get) Token: 0x06015C2C RID: 89132 RVA: 0x003234D0 File Offset: 0x003216D0
		public int Id
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

		// Token: 0x17006BE9 RID: 27625
		// (get) Token: 0x06015C2D RID: 89133 RVA: 0x0032350C File Offset: 0x0032170C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015C2E RID: 89134 RVA: 0x00323548 File Offset: 0x00321748
		public static Offset<ICheckSpringFestivalGuessJokerCompleted> CreateICheckSpringFestivalGuessJokerCompleted(FlatBufferBuilder builder, ESpringFestivalGameplayType Type = ESpringFestivalGameplayType.MixDrinks, int Id = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICheckSpringFestivalGuessJokerCompleted.AddId(builder, Id);
			ICheckSpringFestivalGuessJokerCompleted.AddNullMask(builder, NullMask);
			ICheckSpringFestivalGuessJokerCompleted.AddType(builder, Type);
			return ICheckSpringFestivalGuessJokerCompleted.EndICheckSpringFestivalGuessJokerCompleted(builder);
		}

		// Token: 0x06015C2F RID: 89135 RVA: 0x0032356C File Offset: 0x0032176C
		public static void StartICheckSpringFestivalGuessJokerCompleted(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015C30 RID: 89136 RVA: 0x00323575 File Offset: 0x00321775
		public static void AddType(FlatBufferBuilder builder, ESpringFestivalGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015C31 RID: 89137 RVA: 0x00323580 File Offset: 0x00321780
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06015C32 RID: 89138 RVA: 0x0032358B File Offset: 0x0032178B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06015C33 RID: 89139 RVA: 0x00323596 File Offset: 0x00321796
		public static Offset<ICheckSpringFestivalGuessJokerCompleted> EndICheckSpringFestivalGuessJokerCompleted(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalGuessJokerCompleted>(builder.EndTable());
		}

		// Token: 0x06015C34 RID: 89140 RVA: 0x003235A4 File Offset: 0x003217A4
		public ICheckSpringFestivalGuessJokerCompletedT UnPack()
		{
			ICheckSpringFestivalGuessJokerCompletedT checkSpringFestivalGuessJokerCompletedT = new ICheckSpringFestivalGuessJokerCompletedT();
			this.UnPackTo(checkSpringFestivalGuessJokerCompletedT);
			return checkSpringFestivalGuessJokerCompletedT;
		}

		// Token: 0x06015C35 RID: 89141 RVA: 0x003235BF File Offset: 0x003217BF
		public void UnPackTo(ICheckSpringFestivalGuessJokerCompletedT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015C36 RID: 89142 RVA: 0x003235E8 File Offset: 0x003217E8
		public static Offset<ICheckSpringFestivalGuessJokerCompleted> Pack(FlatBufferBuilder builder, ICheckSpringFestivalGuessJokerCompletedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSpringFestivalGuessJokerCompleted>);
			}
			return ICheckSpringFestivalGuessJokerCompleted.CreateICheckSpringFestivalGuessJokerCompleted(builder, _o.Type, _o.Id, _o.NullMask);
		}

		// Token: 0x0400B652 RID: 46674
		private Table __p;
	}
}
