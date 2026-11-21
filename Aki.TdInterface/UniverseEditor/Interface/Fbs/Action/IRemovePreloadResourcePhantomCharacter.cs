using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E5 RID: 30181
	public struct IRemovePreloadResourcePhantomCharacter : IFlatbufferObject
	{
		// Token: 0x1700DDCD RID: 56781
		// (get) Token: 0x06034F1E RID: 216862 RVA: 0x0071D284 File Offset: 0x0071B484
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034F1F RID: 216863 RVA: 0x0071D291 File Offset: 0x0071B491
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034F20 RID: 216864 RVA: 0x0071D298 File Offset: 0x0071B498
		public static IRemovePreloadResourcePhantomCharacter GetRootAsIRemovePreloadResourcePhantomCharacter(ByteBuffer _bb)
		{
			return IRemovePreloadResourcePhantomCharacter.GetRootAsIRemovePreloadResourcePhantomCharacter(_bb, default(IRemovePreloadResourcePhantomCharacter));
		}

		// Token: 0x06034F21 RID: 216865 RVA: 0x0071D2B4 File Offset: 0x0071B4B4
		public static IRemovePreloadResourcePhantomCharacter GetRootAsIRemovePreloadResourcePhantomCharacter(ByteBuffer _bb, IRemovePreloadResourcePhantomCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034F22 RID: 216866 RVA: 0x0071D2D1 File Offset: 0x0071B4D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034F23 RID: 216867 RVA: 0x0071D2E0 File Offset: 0x0071B4E0
		public IRemovePreloadResourcePhantomCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDCE RID: 56782
		// (get) Token: 0x06034F24 RID: 216868 RVA: 0x0071D2F0 File Offset: 0x0071B4F0
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

		// Token: 0x1700DDCF RID: 56783
		// (get) Token: 0x06034F25 RID: 216869 RVA: 0x0071D32C File Offset: 0x0071B52C
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

		// Token: 0x1700DDD0 RID: 56784
		// (get) Token: 0x06034F26 RID: 216870 RVA: 0x0071D368 File Offset: 0x0071B568
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

		// Token: 0x06034F27 RID: 216871 RVA: 0x0071D3C5 File Offset: 0x0071B5C5
		public static Offset<IRemovePreloadResourcePhantomCharacter> CreateIRemovePreloadResourcePhantomCharacter(FlatBufferBuilder builder, ERemovePreloadResourceObjectType Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter, int Id = 0, Offset<IDelayRemoveAfterSkillFinish> DelayReMoveOffset = default(Offset<IDelayRemoveAfterSkillFinish>))
		{
			builder.StartTable(3);
			IRemovePreloadResourcePhantomCharacter.AddDelayReMove(builder, DelayReMoveOffset);
			IRemovePreloadResourcePhantomCharacter.AddId(builder, Id);
			IRemovePreloadResourcePhantomCharacter.AddType(builder, Type);
			return IRemovePreloadResourcePhantomCharacter.EndIRemovePreloadResourcePhantomCharacter(builder);
		}

		// Token: 0x06034F28 RID: 216872 RVA: 0x0071D3E9 File Offset: 0x0071B5E9
		public static void StartIRemovePreloadResourcePhantomCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034F29 RID: 216873 RVA: 0x0071D3F2 File Offset: 0x0071B5F2
		public static void AddType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034F2A RID: 216874 RVA: 0x0071D3FD File Offset: 0x0071B5FD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06034F2B RID: 216875 RVA: 0x0071D408 File Offset: 0x0071B608
		public static void AddDelayReMove(FlatBufferBuilder builder, Offset<IDelayRemoveAfterSkillFinish> delayReMoveOffset)
		{
			builder.AddOffset(2, delayReMoveOffset.Value, 0);
		}

		// Token: 0x06034F2C RID: 216876 RVA: 0x0071D418 File Offset: 0x0071B618
		public static Offset<IRemovePreloadResourcePhantomCharacter> EndIRemovePreloadResourcePhantomCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadResourcePhantomCharacter>(builder.EndTable());
		}

		// Token: 0x06034F2D RID: 216877 RVA: 0x0071D428 File Offset: 0x0071B628
		public IRemovePreloadResourcePhantomCharacterT UnPack()
		{
			IRemovePreloadResourcePhantomCharacterT removePreloadResourcePhantomCharacterT = new IRemovePreloadResourcePhantomCharacterT();
			this.UnPackTo(removePreloadResourcePhantomCharacterT);
			return removePreloadResourcePhantomCharacterT;
		}

		// Token: 0x06034F2E RID: 216878 RVA: 0x0071D444 File Offset: 0x0071B644
		public void UnPackTo(IRemovePreloadResourcePhantomCharacterT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.DelayReMove = ((this.DelayReMove != null) ? this.DelayReMove.Value.UnPack() : null);
		}

		// Token: 0x06034F2F RID: 216879 RVA: 0x0071D498 File Offset: 0x0071B698
		public static Offset<IRemovePreloadResourcePhantomCharacter> Pack(FlatBufferBuilder builder, IRemovePreloadResourcePhantomCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemovePreloadResourcePhantomCharacter>);
			}
			Offset<IDelayRemoveAfterSkillFinish> delayReMoveOffset = (_o.DelayReMove == null) ? default(Offset<IDelayRemoveAfterSkillFinish>) : IDelayRemoveAfterSkillFinish.Pack(builder, _o.DelayReMove);
			return IRemovePreloadResourcePhantomCharacter.CreateIRemovePreloadResourcePhantomCharacter(builder, _o.Type, _o.Id, delayReMoveOffset);
		}

		// Token: 0x040127CF RID: 75727
		private Table __p;
	}
}
