using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E64 RID: 28260
	public struct IRemovePreloadResourcePhantomCharacter : IFlatbufferObject
	{
		// Token: 0x1700D27B RID: 53883
		// (get) Token: 0x06031EF6 RID: 204534 RVA: 0x006C1784 File Offset: 0x006BF984
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031EF7 RID: 204535 RVA: 0x006C1791 File Offset: 0x006BF991
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031EF8 RID: 204536 RVA: 0x006C1798 File Offset: 0x006BF998
		public static IRemovePreloadResourcePhantomCharacter GetRootAsIRemovePreloadResourcePhantomCharacter(ByteBuffer _bb)
		{
			return IRemovePreloadResourcePhantomCharacter.GetRootAsIRemovePreloadResourcePhantomCharacter(_bb, default(IRemovePreloadResourcePhantomCharacter));
		}

		// Token: 0x06031EF9 RID: 204537 RVA: 0x006C17B4 File Offset: 0x006BF9B4
		public static IRemovePreloadResourcePhantomCharacter GetRootAsIRemovePreloadResourcePhantomCharacter(ByteBuffer _bb, IRemovePreloadResourcePhantomCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031EFA RID: 204538 RVA: 0x006C17D1 File Offset: 0x006BF9D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031EFB RID: 204539 RVA: 0x006C17E0 File Offset: 0x006BF9E0
		public IRemovePreloadResourcePhantomCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D27C RID: 53884
		// (get) Token: 0x06031EFC RID: 204540 RVA: 0x006C17F0 File Offset: 0x006BF9F0
		public ERemovePreloadResourceObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				}
				return (ERemovePreloadResourceObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D27D RID: 53885
		// (get) Token: 0x06031EFD RID: 204541 RVA: 0x006C182C File Offset: 0x006BFA2C
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

		// Token: 0x1700D27E RID: 53886
		// (get) Token: 0x06031EFE RID: 204542 RVA: 0x006C1868 File Offset: 0x006BFA68
		public IDelayRemoveAfterSkillFinish? DelayReMove
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IDelayRemoveAfterSkillFinish?(default(IDelayRemoveAfterSkillFinish).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06031EFF RID: 204543 RVA: 0x006C18C5 File Offset: 0x006BFAC5
		public static Offset<IRemovePreloadResourcePhantomCharacter> CreateIRemovePreloadResourcePhantomCharacter(FlatBufferBuilder builder, ERemovePreloadResourceObjectType Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter, int Id = 0, Offset<IDelayRemoveAfterSkillFinish> DelayReMoveOffset = default(Offset<IDelayRemoveAfterSkillFinish>))
		{
			builder.StartTable(3);
			IRemovePreloadResourcePhantomCharacter.AddDelayReMove(builder, DelayReMoveOffset);
			IRemovePreloadResourcePhantomCharacter.AddId(builder, Id);
			IRemovePreloadResourcePhantomCharacter.AddType(builder, Type);
			return IRemovePreloadResourcePhantomCharacter.EndIRemovePreloadResourcePhantomCharacter(builder);
		}

		// Token: 0x06031F00 RID: 204544 RVA: 0x006C18E9 File Offset: 0x006BFAE9
		public static void StartIRemovePreloadResourcePhantomCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031F01 RID: 204545 RVA: 0x006C18F2 File Offset: 0x006BFAF2
		public static void AddType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031F02 RID: 204546 RVA: 0x006C18FD File Offset: 0x006BFAFD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06031F03 RID: 204547 RVA: 0x006C1908 File Offset: 0x006BFB08
		public static void AddDelayReMove(FlatBufferBuilder builder, Offset<IDelayRemoveAfterSkillFinish> delayReMoveOffset)
		{
			builder.AddOffset(2, delayReMoveOffset.Value, 0);
		}

		// Token: 0x06031F04 RID: 204548 RVA: 0x006C1918 File Offset: 0x006BFB18
		public static Offset<IRemovePreloadResourcePhantomCharacter> EndIRemovePreloadResourcePhantomCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadResourcePhantomCharacter>(builder.EndTable());
		}

		// Token: 0x06031F05 RID: 204549 RVA: 0x006C1928 File Offset: 0x006BFB28
		public IRemovePreloadResourcePhantomCharacterT UnPack()
		{
			IRemovePreloadResourcePhantomCharacterT removePreloadResourcePhantomCharacterT = new IRemovePreloadResourcePhantomCharacterT();
			this.UnPackTo(removePreloadResourcePhantomCharacterT);
			return removePreloadResourcePhantomCharacterT;
		}

		// Token: 0x06031F06 RID: 204550 RVA: 0x006C1944 File Offset: 0x006BFB44
		public void UnPackTo(IRemovePreloadResourcePhantomCharacterT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.DelayReMove = ((this.DelayReMove != null) ? this.DelayReMove.Value.UnPack() : null);
		}

		// Token: 0x06031F07 RID: 204551 RVA: 0x006C1998 File Offset: 0x006BFB98
		public static Offset<IRemovePreloadResourcePhantomCharacter> Pack(FlatBufferBuilder builder, IRemovePreloadResourcePhantomCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemovePreloadResourcePhantomCharacter>);
			}
			Offset<IDelayRemoveAfterSkillFinish> delayReMoveOffset = (_o.DelayReMove == null) ? default(Offset<IDelayRemoveAfterSkillFinish>) : IDelayRemoveAfterSkillFinish.Pack(builder, _o.DelayReMove);
			return IRemovePreloadResourcePhantomCharacter.CreateIRemovePreloadResourcePhantomCharacter(builder, _o.Type, _o.Id, delayReMoveOffset);
		}

		// Token: 0x0401184D RID: 71757
		private Table __p;
	}
}
