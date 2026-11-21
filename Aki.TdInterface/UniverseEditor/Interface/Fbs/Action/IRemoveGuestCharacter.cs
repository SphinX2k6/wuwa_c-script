using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D0 RID: 30160
	public struct IRemoveGuestCharacter : IFlatbufferObject
	{
		// Token: 0x1700DDB5 RID: 56757
		// (get) Token: 0x06034E90 RID: 216720 RVA: 0x0071C3E7 File Offset: 0x0071A5E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034E91 RID: 216721 RVA: 0x0071C3F4 File Offset: 0x0071A5F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034E92 RID: 216722 RVA: 0x0071C3FC File Offset: 0x0071A5FC
		public static IRemoveGuestCharacter GetRootAsIRemoveGuestCharacter(ByteBuffer _bb)
		{
			return IRemoveGuestCharacter.GetRootAsIRemoveGuestCharacter(_bb, default(IRemoveGuestCharacter));
		}

		// Token: 0x06034E93 RID: 216723 RVA: 0x0071C418 File Offset: 0x0071A618
		public static IRemoveGuestCharacter GetRootAsIRemoveGuestCharacter(ByteBuffer _bb, IRemoveGuestCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034E94 RID: 216724 RVA: 0x0071C435 File Offset: 0x0071A635
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034E95 RID: 216725 RVA: 0x0071C444 File Offset: 0x0071A644
		public IRemoveGuestCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDB6 RID: 56758
		// (get) Token: 0x06034E96 RID: 216726 RVA: 0x0071C454 File Offset: 0x0071A654
		public int GuestCharacterId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034E97 RID: 216727 RVA: 0x0071C490 File Offset: 0x0071A690
		public static Offset<IRemoveGuestCharacter> CreateIRemoveGuestCharacter(FlatBufferBuilder builder, int GuestCharacterId = 0)
		{
			builder.StartTable(1);
			IRemoveGuestCharacter.AddGuestCharacterId(builder, GuestCharacterId);
			return IRemoveGuestCharacter.EndIRemoveGuestCharacter(builder);
		}

		// Token: 0x06034E98 RID: 216728 RVA: 0x0071C4A6 File Offset: 0x0071A6A6
		public static void StartIRemoveGuestCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034E99 RID: 216729 RVA: 0x0071C4AF File Offset: 0x0071A6AF
		public static void AddGuestCharacterId(FlatBufferBuilder builder, int guestCharacterId)
		{
			builder.AddInt(0, guestCharacterId, 0);
		}

		// Token: 0x06034E9A RID: 216730 RVA: 0x0071C4BA File Offset: 0x0071A6BA
		public static Offset<IRemoveGuestCharacter> EndIRemoveGuestCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveGuestCharacter>(builder.EndTable());
		}

		// Token: 0x06034E9B RID: 216731 RVA: 0x0071C4C8 File Offset: 0x0071A6C8
		public IRemoveGuestCharacterT UnPack()
		{
			IRemoveGuestCharacterT removeGuestCharacterT = new IRemoveGuestCharacterT();
			this.UnPackTo(removeGuestCharacterT);
			return removeGuestCharacterT;
		}

		// Token: 0x06034E9C RID: 216732 RVA: 0x0071C4E3 File Offset: 0x0071A6E3
		public void UnPackTo(IRemoveGuestCharacterT _o)
		{
			_o.GuestCharacterId = this.GuestCharacterId;
		}

		// Token: 0x06034E9D RID: 216733 RVA: 0x0071C4F4 File Offset: 0x0071A6F4
		public static Offset<IRemoveGuestCharacter> Pack(FlatBufferBuilder builder, IRemoveGuestCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveGuestCharacter>);
			}
			return IRemoveGuestCharacter.CreateIRemoveGuestCharacter(builder, _o.GuestCharacterId);
		}

		// Token: 0x040127B8 RID: 75704
		private Table __p;
	}
}
