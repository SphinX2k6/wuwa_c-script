using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004184 RID: 16772
	public struct ICheckSpringFestivalGuessJokerCompleted : IFlatbufferObject
	{
		// Token: 0x170071A0 RID: 29088
		// (get) Token: 0x0601715D RID: 94557 RVA: 0x0034A6A0 File Offset: 0x003488A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601715E RID: 94558 RVA: 0x0034A6AD File Offset: 0x003488AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601715F RID: 94559 RVA: 0x0034A6B4 File Offset: 0x003488B4
		public static ICheckSpringFestivalGuessJokerCompleted GetRootAsICheckSpringFestivalGuessJokerCompleted(ByteBuffer _bb)
		{
			return ICheckSpringFestivalGuessJokerCompleted.GetRootAsICheckSpringFestivalGuessJokerCompleted(_bb, default(ICheckSpringFestivalGuessJokerCompleted));
		}

		// Token: 0x06017160 RID: 94560 RVA: 0x0034A6D0 File Offset: 0x003488D0
		public static ICheckSpringFestivalGuessJokerCompleted GetRootAsICheckSpringFestivalGuessJokerCompleted(ByteBuffer _bb, ICheckSpringFestivalGuessJokerCompleted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017161 RID: 94561 RVA: 0x0034A6ED File Offset: 0x003488ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017162 RID: 94562 RVA: 0x0034A6FC File Offset: 0x003488FC
		public ICheckSpringFestivalGuessJokerCompleted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071A1 RID: 29089
		// (get) Token: 0x06017163 RID: 94563 RVA: 0x0034A70C File Offset: 0x0034890C
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

		// Token: 0x170071A2 RID: 29090
		// (get) Token: 0x06017164 RID: 94564 RVA: 0x0034A748 File Offset: 0x00348948
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

		// Token: 0x170071A3 RID: 29091
		// (get) Token: 0x06017165 RID: 94565 RVA: 0x0034A784 File Offset: 0x00348984
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

		// Token: 0x06017166 RID: 94566 RVA: 0x0034A7C0 File Offset: 0x003489C0
		public static Offset<ICheckSpringFestivalGuessJokerCompleted> CreateICheckSpringFestivalGuessJokerCompleted(FlatBufferBuilder builder, ESpringFestivalGameplayType Type = ESpringFestivalGameplayType.MixDrinks, int Id = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICheckSpringFestivalGuessJokerCompleted.AddId(builder, Id);
			ICheckSpringFestivalGuessJokerCompleted.AddNullMask(builder, NullMask);
			ICheckSpringFestivalGuessJokerCompleted.AddType(builder, Type);
			return ICheckSpringFestivalGuessJokerCompleted.EndICheckSpringFestivalGuessJokerCompleted(builder);
		}

		// Token: 0x06017167 RID: 94567 RVA: 0x0034A7E4 File Offset: 0x003489E4
		public static void StartICheckSpringFestivalGuessJokerCompleted(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017168 RID: 94568 RVA: 0x0034A7ED File Offset: 0x003489ED
		public static void AddType(FlatBufferBuilder builder, ESpringFestivalGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017169 RID: 94569 RVA: 0x0034A7F8 File Offset: 0x003489F8
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601716A RID: 94570 RVA: 0x0034A803 File Offset: 0x00348A03
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601716B RID: 94571 RVA: 0x0034A80E File Offset: 0x00348A0E
		public static Offset<ICheckSpringFestivalGuessJokerCompleted> EndICheckSpringFestivalGuessJokerCompleted(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalGuessJokerCompleted>(builder.EndTable());
		}

		// Token: 0x0601716C RID: 94572 RVA: 0x0034A81C File Offset: 0x00348A1C
		public ICheckSpringFestivalGuessJokerCompletedT UnPack()
		{
			ICheckSpringFestivalGuessJokerCompletedT checkSpringFestivalGuessJokerCompletedT = new ICheckSpringFestivalGuessJokerCompletedT();
			this.UnPackTo(checkSpringFestivalGuessJokerCompletedT);
			return checkSpringFestivalGuessJokerCompletedT;
		}

		// Token: 0x0601716D RID: 94573 RVA: 0x0034A837 File Offset: 0x00348A37
		public void UnPackTo(ICheckSpringFestivalGuessJokerCompletedT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601716E RID: 94574 RVA: 0x0034A860 File Offset: 0x00348A60
		public static Offset<ICheckSpringFestivalGuessJokerCompleted> Pack(FlatBufferBuilder builder, ICheckSpringFestivalGuessJokerCompletedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSpringFestivalGuessJokerCompleted>);
			}
			return ICheckSpringFestivalGuessJokerCompleted.CreateICheckSpringFestivalGuessJokerCompleted(builder, _o.Type, _o.Id, _o.NullMask);
		}

		// Token: 0x0400BFFF RID: 49151
		private Table __p;
	}
}
