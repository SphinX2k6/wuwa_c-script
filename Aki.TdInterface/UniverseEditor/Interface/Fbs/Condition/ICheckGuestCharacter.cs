using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A42 RID: 19010
	public struct ICheckGuestCharacter : IFlatbufferObject
	{
		// Token: 0x1700899F RID: 35231
		// (get) Token: 0x0601DC40 RID: 121920 RVA: 0x0042F7CB File Offset: 0x0042D9CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DC41 RID: 121921 RVA: 0x0042F7D8 File Offset: 0x0042D9D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DC42 RID: 121922 RVA: 0x0042F7E0 File Offset: 0x0042D9E0
		public static ICheckGuestCharacter GetRootAsICheckGuestCharacter(ByteBuffer _bb)
		{
			return ICheckGuestCharacter.GetRootAsICheckGuestCharacter(_bb, default(ICheckGuestCharacter));
		}

		// Token: 0x0601DC43 RID: 121923 RVA: 0x0042F7FC File Offset: 0x0042D9FC
		public static ICheckGuestCharacter GetRootAsICheckGuestCharacter(ByteBuffer _bb, ICheckGuestCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DC44 RID: 121924 RVA: 0x0042F819 File Offset: 0x0042DA19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DC45 RID: 121925 RVA: 0x0042F828 File Offset: 0x0042DA28
		public ICheckGuestCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089A0 RID: 35232
		// (get) Token: 0x0601DC46 RID: 121926 RVA: 0x0042F838 File Offset: 0x0042DA38
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170089A1 RID: 35233
		// (get) Token: 0x0601DC47 RID: 121927 RVA: 0x0042F874 File Offset: 0x0042DA74
		public int GuestCharacterId
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

		// Token: 0x0601DC48 RID: 121928 RVA: 0x0042F8B0 File Offset: 0x0042DAB0
		public static Offset<ICheckGuestCharacter> CreateICheckGuestCharacter(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int GuestCharacterId = 0)
		{
			builder.StartTable(2);
			ICheckGuestCharacter.AddGuestCharacterId(builder, GuestCharacterId);
			ICheckGuestCharacter.AddType(builder, Type);
			return ICheckGuestCharacter.EndICheckGuestCharacter(builder);
		}

		// Token: 0x0601DC49 RID: 121929 RVA: 0x0042F8CD File Offset: 0x0042DACD
		public static void StartICheckGuestCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DC4A RID: 121930 RVA: 0x0042F8D6 File Offset: 0x0042DAD6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DC4B RID: 121931 RVA: 0x0042F8E1 File Offset: 0x0042DAE1
		public static void AddGuestCharacterId(FlatBufferBuilder builder, int guestCharacterId)
		{
			builder.AddInt(1, guestCharacterId, 0);
		}

		// Token: 0x0601DC4C RID: 121932 RVA: 0x0042F8EC File Offset: 0x0042DAEC
		public static Offset<ICheckGuestCharacter> EndICheckGuestCharacter(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGuestCharacter>(builder.EndTable());
		}

		// Token: 0x0601DC4D RID: 121933 RVA: 0x0042F8FC File Offset: 0x0042DAFC
		public ICheckGuestCharacterT UnPack()
		{
			ICheckGuestCharacterT checkGuestCharacterT = new ICheckGuestCharacterT();
			this.UnPackTo(checkGuestCharacterT);
			return checkGuestCharacterT;
		}

		// Token: 0x0601DC4E RID: 121934 RVA: 0x0042F917 File Offset: 0x0042DB17
		public void UnPackTo(ICheckGuestCharacterT _o)
		{
			_o.Type = this.Type;
			_o.GuestCharacterId = this.GuestCharacterId;
		}

		// Token: 0x0601DC4F RID: 121935 RVA: 0x0042F934 File Offset: 0x0042DB34
		public static Offset<ICheckGuestCharacter> Pack(FlatBufferBuilder builder, ICheckGuestCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckGuestCharacter>);
			}
			return ICheckGuestCharacter.CreateICheckGuestCharacter(builder, _o.Type, _o.GuestCharacterId);
		}

		// Token: 0x0400D298 RID: 53912
		private Table __p;
	}
}
