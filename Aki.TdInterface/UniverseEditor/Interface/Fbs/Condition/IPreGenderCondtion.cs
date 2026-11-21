using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200518D RID: 20877
	public struct IPreGenderCondtion : IFlatbufferObject
	{
		// Token: 0x17009585 RID: 38277
		// (get) Token: 0x06020DA1 RID: 134561 RVA: 0x0048BF70 File Offset: 0x0048A170
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020DA2 RID: 134562 RVA: 0x0048BF7D File Offset: 0x0048A17D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020DA3 RID: 134563 RVA: 0x0048BF84 File Offset: 0x0048A184
		public static IPreGenderCondtion GetRootAsIPreGenderCondtion(ByteBuffer _bb)
		{
			return IPreGenderCondtion.GetRootAsIPreGenderCondtion(_bb, default(IPreGenderCondtion));
		}

		// Token: 0x06020DA4 RID: 134564 RVA: 0x0048BFA0 File Offset: 0x0048A1A0
		public static IPreGenderCondtion GetRootAsIPreGenderCondtion(ByteBuffer _bb, IPreGenderCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020DA5 RID: 134565 RVA: 0x0048BFBD File Offset: 0x0048A1BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020DA6 RID: 134566 RVA: 0x0048BFCC File Offset: 0x0048A1CC
		public IPreGenderCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009586 RID: 38278
		// (get) Token: 0x06020DA7 RID: 134567 RVA: 0x0048BFDC File Offset: 0x0048A1DC
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009587 RID: 38279
		// (get) Token: 0x06020DA8 RID: 134568 RVA: 0x0048C018 File Offset: 0x0048A218
		public EGender Gender
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EGender.M;
				}
				return (EGender)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020DA9 RID: 134569 RVA: 0x0048C054 File Offset: 0x0048A254
		public static Offset<IPreGenderCondtion> CreateIPreGenderCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, EGender Gender = EGender.M)
		{
			builder.StartTable(2);
			IPreGenderCondtion.AddGender(builder, Gender);
			IPreGenderCondtion.AddType(builder, Type);
			return IPreGenderCondtion.EndIPreGenderCondtion(builder);
		}

		// Token: 0x06020DAA RID: 134570 RVA: 0x0048C071 File Offset: 0x0048A271
		public static void StartIPreGenderCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020DAB RID: 134571 RVA: 0x0048C07A File Offset: 0x0048A27A
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020DAC RID: 134572 RVA: 0x0048C085 File Offset: 0x0048A285
		public static void AddGender(FlatBufferBuilder builder, EGender gender)
		{
			builder.AddByte(1, (byte)gender, 0);
		}

		// Token: 0x06020DAD RID: 134573 RVA: 0x0048C090 File Offset: 0x0048A290
		public static Offset<IPreGenderCondtion> EndIPreGenderCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IPreGenderCondtion>(builder.EndTable());
		}

		// Token: 0x06020DAE RID: 134574 RVA: 0x0048C0A0 File Offset: 0x0048A2A0
		public IPreGenderCondtionT UnPack()
		{
			IPreGenderCondtionT preGenderCondtionT = new IPreGenderCondtionT();
			this.UnPackTo(preGenderCondtionT);
			return preGenderCondtionT;
		}

		// Token: 0x06020DAF RID: 134575 RVA: 0x0048C0BB File Offset: 0x0048A2BB
		public void UnPackTo(IPreGenderCondtionT _o)
		{
			_o.Type = this.Type;
			_o.Gender = this.Gender;
		}

		// Token: 0x06020DB0 RID: 134576 RVA: 0x0048C0D8 File Offset: 0x0048A2D8
		public static Offset<IPreGenderCondtion> Pack(FlatBufferBuilder builder, IPreGenderCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreGenderCondtion>);
			}
			return IPreGenderCondtion.CreateIPreGenderCondtion(builder, _o.Type, _o.Gender);
		}

		// Token: 0x0400E175 RID: 57717
		private Table __p;
	}
}
