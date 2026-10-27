using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D70 RID: 15728
	public struct ICheckSpringFestivalMixDrinksCompleted : IFlatbufferObject
	{
		// Token: 0x17006BED RID: 27629
		// (get) Token: 0x06015C3F RID: 89151 RVA: 0x003236B8 File Offset: 0x003218B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015C40 RID: 89152 RVA: 0x003236C5 File Offset: 0x003218C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015C41 RID: 89153 RVA: 0x003236CC File Offset: 0x003218CC
		public static ICheckSpringFestivalMixDrinksCompleted GetRootAsICheckSpringFestivalMixDrinksCompleted(ByteBuffer _bb)
		{
			return ICheckSpringFestivalMixDrinksCompleted.GetRootAsICheckSpringFestivalMixDrinksCompleted(_bb, default(ICheckSpringFestivalMixDrinksCompleted));
		}

		// Token: 0x06015C42 RID: 89154 RVA: 0x003236E8 File Offset: 0x003218E8
		public static ICheckSpringFestivalMixDrinksCompleted GetRootAsICheckSpringFestivalMixDrinksCompleted(ByteBuffer _bb, ICheckSpringFestivalMixDrinksCompleted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015C43 RID: 89155 RVA: 0x00323705 File Offset: 0x00321905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015C44 RID: 89156 RVA: 0x00323714 File Offset: 0x00321914
		public ICheckSpringFestivalMixDrinksCompleted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BEE RID: 27630
		// (get) Token: 0x06015C45 RID: 89157 RVA: 0x00323724 File Offset: 0x00321924
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

		// Token: 0x17006BEF RID: 27631
		// (get) Token: 0x06015C46 RID: 89158 RVA: 0x00323760 File Offset: 0x00321960
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

		// Token: 0x17006BF0 RID: 27632
		// (get) Token: 0x06015C47 RID: 89159 RVA: 0x0032379C File Offset: 0x0032199C
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

		// Token: 0x06015C48 RID: 89160 RVA: 0x003237D8 File Offset: 0x003219D8
		public static Offset<ICheckSpringFestivalMixDrinksCompleted> CreateICheckSpringFestivalMixDrinksCompleted(FlatBufferBuilder builder, ESpringFestivalGameplayType Type = ESpringFestivalGameplayType.MixDrinks, int Id = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICheckSpringFestivalMixDrinksCompleted.AddId(builder, Id);
			ICheckSpringFestivalMixDrinksCompleted.AddNullMask(builder, NullMask);
			ICheckSpringFestivalMixDrinksCompleted.AddType(builder, Type);
			return ICheckSpringFestivalMixDrinksCompleted.EndICheckSpringFestivalMixDrinksCompleted(builder);
		}

		// Token: 0x06015C49 RID: 89161 RVA: 0x003237FC File Offset: 0x003219FC
		public static void StartICheckSpringFestivalMixDrinksCompleted(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015C4A RID: 89162 RVA: 0x00323805 File Offset: 0x00321A05
		public static void AddType(FlatBufferBuilder builder, ESpringFestivalGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015C4B RID: 89163 RVA: 0x00323810 File Offset: 0x00321A10
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06015C4C RID: 89164 RVA: 0x0032381B File Offset: 0x00321A1B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06015C4D RID: 89165 RVA: 0x00323826 File Offset: 0x00321A26
		public static Offset<ICheckSpringFestivalMixDrinksCompleted> EndICheckSpringFestivalMixDrinksCompleted(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalMixDrinksCompleted>(builder.EndTable());
		}

		// Token: 0x06015C4E RID: 89166 RVA: 0x00323834 File Offset: 0x00321A34
		public ICheckSpringFestivalMixDrinksCompletedT UnPack()
		{
			ICheckSpringFestivalMixDrinksCompletedT checkSpringFestivalMixDrinksCompletedT = new ICheckSpringFestivalMixDrinksCompletedT();
			this.UnPackTo(checkSpringFestivalMixDrinksCompletedT);
			return checkSpringFestivalMixDrinksCompletedT;
		}

		// Token: 0x06015C4F RID: 89167 RVA: 0x0032384F File Offset: 0x00321A4F
		public void UnPackTo(ICheckSpringFestivalMixDrinksCompletedT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015C50 RID: 89168 RVA: 0x00323878 File Offset: 0x00321A78
		public static Offset<ICheckSpringFestivalMixDrinksCompleted> Pack(FlatBufferBuilder builder, ICheckSpringFestivalMixDrinksCompletedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSpringFestivalMixDrinksCompleted>);
			}
			return ICheckSpringFestivalMixDrinksCompleted.CreateICheckSpringFestivalMixDrinksCompleted(builder, _o.Type, _o.Id, _o.NullMask);
		}

		// Token: 0x0400B656 RID: 46678
		private Table __p;
	}
}
