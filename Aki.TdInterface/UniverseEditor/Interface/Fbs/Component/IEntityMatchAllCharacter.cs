using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005192 RID: 20882
	public struct IEntityMatchAllCharacter : IFlatbufferObject
	{
		// Token: 0x17009896 RID: 39062
		// (get) Token: 0x06021C7D RID: 138365 RVA: 0x004AFD7A File Offset: 0x004ADF7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021C7E RID: 138366 RVA: 0x004AFD87 File Offset: 0x004ADF87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021C7F RID: 138367 RVA: 0x004AFD90 File Offset: 0x004ADF90
		public static IEntityMatchAllCharacter GetRootAsIEntityMatchAllCharacter(ByteBuffer _bb)
		{
			return IEntityMatchAllCharacter.GetRootAsIEntityMatchAllCharacter(_bb, default(IEntityMatchAllCharacter));
		}

		// Token: 0x06021C80 RID: 138368 RVA: 0x004AFDAC File Offset: 0x004ADFAC
		public static IEntityMatchAllCharacter GetRootAsIEntityMatchAllCharacter(ByteBuffer _bb, IEntityMatchAllCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021C81 RID: 138369 RVA: 0x004AFDC9 File Offset: 0x004ADFC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021C82 RID: 138370 RVA: 0x004AFDD8 File Offset: 0x004ADFD8
		public IEntityMatchAllCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009897 RID: 39063
		// (get) Token: 0x06021C83 RID: 138371 RVA: 0x004AFDE8 File Offset: 0x004ADFE8
		public EEntityMatchType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityMatchType.Player;
				}
				return (EEntityMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021C84 RID: 138372 RVA: 0x004AFE24 File Offset: 0x004AE024
		public static Offset<IEntityMatchAllCharacter> CreateIEntityMatchAllCharacter(FlatBufferBuilder builder, EEntityMatchType Type = EEntityMatchType.Player)
		{
			builder.StartTable(1);
			IEntityMatchAllCharacter.AddType(builder, Type);
			return IEntityMatchAllCharacter.EndIEntityMatchAllCharacter(builder);
		}

		// Token: 0x06021C85 RID: 138373 RVA: 0x004AFE3A File Offset: 0x004AE03A
		public static void StartIEntityMatchAllCharacter(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021C86 RID: 138374 RVA: 0x004AFE43 File Offset: 0x004AE043
		public static void AddType(FlatBufferBuilder builder, EEntityMatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021C87 RID: 138375 RVA: 0x004AFE4E File Offset: 0x004AE04E
		public static Offset<IEntityMatchAllCharacter> EndIEntityMatchAllCharacter(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatchAllCharacter>(builder.EndTable());
		}

		// Token: 0x06021C88 RID: 138376 RVA: 0x004AFE5C File Offset: 0x004AE05C
		public IEntityMatchAllCharacterT UnPack()
		{
			IEntityMatchAllCharacterT entityMatchAllCharacterT = new IEntityMatchAllCharacterT();
			this.UnPackTo(entityMatchAllCharacterT);
			return entityMatchAllCharacterT;
		}

		// Token: 0x06021C89 RID: 138377 RVA: 0x004AFE77 File Offset: 0x004AE077
		public void UnPackTo(IEntityMatchAllCharacterT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021C8A RID: 138378 RVA: 0x004AFE88 File Offset: 0x004AE088
		public static Offset<IEntityMatchAllCharacter> Pack(FlatBufferBuilder builder, IEntityMatchAllCharacterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityMatchAllCharacter>);
			}
			return IEntityMatchAllCharacter.CreateIEntityMatchAllCharacter(builder, _o.Type);
		}

		// Token: 0x0400E26A RID: 57962
		private Table __p;
	}
}
