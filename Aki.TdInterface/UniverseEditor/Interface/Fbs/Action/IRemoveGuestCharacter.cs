using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E4F RID: 28239
	public struct IRemoveGuestCharacter : IFlatbufferObject
	{
		// Token: 0x1700D263 RID: 53859
		// (get) Token: 0x06031E68 RID: 204392 RVA: 0x006C08E7 File Offset: 0x006BEAE7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031E69 RID: 204393 RVA: 0x006C08F4 File Offset: 0x006BEAF4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031E6A RID: 204394 RVA: 0x006C08FC File Offset: 0x006BEAFC
		public static IRemoveGuestCharacter GetRootAsIRemoveGuestCharacter(ByteBuffer _bb)
		{
			return IRemoveGuestCharacter.GetRootAsIRemoveGuestCharacter(_bb, default(IRemoveGuestCharacter));
		}

		// Token: 0x06031E6B RID: 204395 RVA: 0x006C0918 File Offset: 0x006BEB18
		public static IRemoveGuestCharacter GetRootAsIRemoveGuestCharacter(ByteBuffer _bb, IRemoveGuestCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E6C RID: 204396 RVA: 0x006C0935 File Offset: 0x006BEB35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E6D RID: 204397 RVA: 0x006C0944 File Offset: 0x006BEB44
		public IRemoveGuestCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D264 RID: 53860
		// (get) Token: 0x06031E6E RID: 204398 RVA: 0x006C0954 File Offset: 0x006BEB54
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

		// Token: 0x06031E6F RID: 204399 RVA: 0x006C0990 File Offset: 0x006BEB90
		public static Offset<IRemoveGuestCharacter> CreateIRemoveGuestCharacter(FlatBufferBuilder builder, int GuestCharacterId = 0)
		{
			builder.StartTable(1);
			IRemoveGuestCharacter.AddGuestCharacterId(builder, GuestCharacterId);
			return IRemoveGuestCharacter.EndIRemoveGuestCharacter(builder);
		}

		// Token: 0x06031E70 RID: 204400 RVA: 0x006C09A6 File Offset: 0x006BEBA6
		public static void StartIRemoveGuestCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031E71 RID: 204401 RVA: 0x006C09AF File Offset: 0x006BEBAF
		public static void AddGuestCharacterId(FlatBufferBuilder builder, int guestCharacterId)
		{
			builder.AddInt(0, guestCharacterId, 0);
		}

		// Token: 0x06031E72 RID: 204402 RVA: 0x006C09BA File Offset: 0x006BEBBA
		public static Offset<IRemoveGuestCharacter> EndIRemoveGuestCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveGuestCharacter>(builder.EndTable());
		}

		// Token: 0x06031E73 RID: 204403 RVA: 0x006C09C8 File Offset: 0x006BEBC8
		public IRemoveGuestCharacterT UnPack()
		{
			IRemoveGuestCharacterT removeGuestCharacterT = new IRemoveGuestCharacterT();
			this.UnPackTo(removeGuestCharacterT);
			return removeGuestCharacterT;
		}

		// Token: 0x06031E74 RID: 204404 RVA: 0x006C09E3 File Offset: 0x006BEBE3
		public void UnPackTo(IRemoveGuestCharacterT _o)
		{
			_o.GuestCharacterId = this.GuestCharacterId;
		}

		// Token: 0x06031E75 RID: 204405 RVA: 0x006C09F4 File Offset: 0x006BEBF4
		public static Offset<IRemoveGuestCharacter> Pack(FlatBufferBuilder builder, IRemoveGuestCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveGuestCharacter>);
			}
			return IRemoveGuestCharacter.CreateIRemoveGuestCharacter(builder, _o.GuestCharacterId);
		}

		// Token: 0x04011836 RID: 71734
		private Table __p;
	}
}
