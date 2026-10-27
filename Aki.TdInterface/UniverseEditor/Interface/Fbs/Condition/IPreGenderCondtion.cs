using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C94 RID: 19604
	public struct IPreGenderCondtion : IFlatbufferObject
	{
		// Token: 0x17008E57 RID: 36439
		// (get) Token: 0x0601F17F RID: 127359 RVA: 0x00458420 File Offset: 0x00456620
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F180 RID: 127360 RVA: 0x0045842D File Offset: 0x0045662D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F181 RID: 127361 RVA: 0x00458434 File Offset: 0x00456634
		public static IPreGenderCondtion GetRootAsIPreGenderCondtion(ByteBuffer _bb)
		{
			return IPreGenderCondtion.GetRootAsIPreGenderCondtion(_bb, default(IPreGenderCondtion));
		}

		// Token: 0x0601F182 RID: 127362 RVA: 0x00458450 File Offset: 0x00456650
		public static IPreGenderCondtion GetRootAsIPreGenderCondtion(ByteBuffer _bb, IPreGenderCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F183 RID: 127363 RVA: 0x0045846D File Offset: 0x0045666D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F184 RID: 127364 RVA: 0x0045847C File Offset: 0x0045667C
		public IPreGenderCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E58 RID: 36440
		// (get) Token: 0x0601F185 RID: 127365 RVA: 0x0045848C File Offset: 0x0045668C
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

		// Token: 0x17008E59 RID: 36441
		// (get) Token: 0x0601F186 RID: 127366 RVA: 0x004584C8 File Offset: 0x004566C8
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

		// Token: 0x0601F187 RID: 127367 RVA: 0x00458504 File Offset: 0x00456704
		public static Offset<IPreGenderCondtion> CreateIPreGenderCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, EGender Gender = EGender.M)
		{
			builder.StartTable(2);
			IPreGenderCondtion.AddGender(builder, Gender);
			IPreGenderCondtion.AddType(builder, Type);
			return IPreGenderCondtion.EndIPreGenderCondtion(builder);
		}

		// Token: 0x0601F188 RID: 127368 RVA: 0x00458521 File Offset: 0x00456721
		public static void StartIPreGenderCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F189 RID: 127369 RVA: 0x0045852A File Offset: 0x0045672A
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F18A RID: 127370 RVA: 0x00458535 File Offset: 0x00456735
		public static void AddGender(FlatBufferBuilder builder, EGender gender)
		{
			builder.AddByte(1, (byte)gender, 0);
		}

		// Token: 0x0601F18B RID: 127371 RVA: 0x00458540 File Offset: 0x00456740
		public static Offset<IPreGenderCondtion> EndIPreGenderCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IPreGenderCondtion>(builder.EndTable());
		}

		// Token: 0x0601F18C RID: 127372 RVA: 0x00458550 File Offset: 0x00456750
		public IPreGenderCondtionT UnPack()
		{
			IPreGenderCondtionT preGenderCondtionT = new IPreGenderCondtionT();
			this.UnPackTo(preGenderCondtionT);
			return preGenderCondtionT;
		}

		// Token: 0x0601F18D RID: 127373 RVA: 0x0045856B File Offset: 0x0045676B
		public void UnPackTo(IPreGenderCondtionT _o)
		{
			_o.Type = this.Type;
			_o.Gender = this.Gender;
		}

		// Token: 0x0601F18E RID: 127374 RVA: 0x00458588 File Offset: 0x00456788
		public static Offset<IPreGenderCondtion> Pack(FlatBufferBuilder builder, IPreGenderCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreGenderCondtion>);
			}
			return IPreGenderCondtion.CreateIPreGenderCondtion(builder, _o.Type, _o.Gender);
		}

		// Token: 0x0400D64E RID: 54862
		private Table __p;
	}
}
