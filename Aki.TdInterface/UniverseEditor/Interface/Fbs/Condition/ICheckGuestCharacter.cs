using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F05 RID: 20229
	public struct ICheckGuestCharacter : IFlatbufferObject
	{
		// Token: 0x17009074 RID: 36980
		// (get) Token: 0x0601F6C9 RID: 128713 RVA: 0x004606C3 File Offset: 0x0045E8C3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F6CA RID: 128714 RVA: 0x004606D0 File Offset: 0x0045E8D0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F6CB RID: 128715 RVA: 0x004606D8 File Offset: 0x0045E8D8
		public static ICheckGuestCharacter GetRootAsICheckGuestCharacter(ByteBuffer _bb)
		{
			return ICheckGuestCharacter.GetRootAsICheckGuestCharacter(_bb, default(ICheckGuestCharacter));
		}

		// Token: 0x0601F6CC RID: 128716 RVA: 0x004606F4 File Offset: 0x0045E8F4
		public static ICheckGuestCharacter GetRootAsICheckGuestCharacter(ByteBuffer _bb, ICheckGuestCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F6CD RID: 128717 RVA: 0x00460711 File Offset: 0x0045E911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F6CE RID: 128718 RVA: 0x00460720 File Offset: 0x0045E920
		public ICheckGuestCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009075 RID: 36981
		// (get) Token: 0x0601F6CF RID: 128719 RVA: 0x00460730 File Offset: 0x0045E930
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

		// Token: 0x17009076 RID: 36982
		// (get) Token: 0x0601F6D0 RID: 128720 RVA: 0x0046076C File Offset: 0x0045E96C
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

		// Token: 0x0601F6D1 RID: 128721 RVA: 0x004607A8 File Offset: 0x0045E9A8
		public static Offset<ICheckGuestCharacter> CreateICheckGuestCharacter(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int GuestCharacterId = 0)
		{
			builder.StartTable(2);
			ICheckGuestCharacter.AddGuestCharacterId(builder, GuestCharacterId);
			ICheckGuestCharacter.AddType(builder, Type);
			return ICheckGuestCharacter.EndICheckGuestCharacter(builder);
		}

		// Token: 0x0601F6D2 RID: 128722 RVA: 0x004607C5 File Offset: 0x0045E9C5
		public static void StartICheckGuestCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F6D3 RID: 128723 RVA: 0x004607CE File Offset: 0x0045E9CE
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F6D4 RID: 128724 RVA: 0x004607D9 File Offset: 0x0045E9D9
		public static void AddGuestCharacterId(FlatBufferBuilder builder, int guestCharacterId)
		{
			builder.AddInt(1, guestCharacterId, 0);
		}

		// Token: 0x0601F6D5 RID: 128725 RVA: 0x004607E4 File Offset: 0x0045E9E4
		public static Offset<ICheckGuestCharacter> EndICheckGuestCharacter(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGuestCharacter>(builder.EndTable());
		}

		// Token: 0x0601F6D6 RID: 128726 RVA: 0x004607F4 File Offset: 0x0045E9F4
		public ICheckGuestCharacterT UnPack()
		{
			ICheckGuestCharacterT checkGuestCharacterT = new ICheckGuestCharacterT();
			this.UnPackTo(checkGuestCharacterT);
			return checkGuestCharacterT;
		}

		// Token: 0x0601F6D7 RID: 128727 RVA: 0x0046080F File Offset: 0x0045EA0F
		public void UnPackTo(ICheckGuestCharacterT _o)
		{
			_o.Type = this.Type;
			_o.GuestCharacterId = this.GuestCharacterId;
		}

		// Token: 0x0601F6D8 RID: 128728 RVA: 0x0046082C File Offset: 0x0045EA2C
		public static Offset<ICheckGuestCharacter> Pack(FlatBufferBuilder builder, ICheckGuestCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckGuestCharacter>);
			}
			return ICheckGuestCharacter.CreateICheckGuestCharacter(builder, _o.Type, _o.GuestCharacterId);
		}

		// Token: 0x0400DD6F RID: 56687
		private Table __p;
	}
}
