using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047C3 RID: 18371
	public struct IEntityOwnerLevelPlay : IFlatbufferObject
	{
		// Token: 0x170083F2 RID: 33778
		// (get) Token: 0x0601C5D7 RID: 116183 RVA: 0x004039FE File Offset: 0x00401BFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C5D8 RID: 116184 RVA: 0x00403A0B File Offset: 0x00401C0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C5D9 RID: 116185 RVA: 0x00403A14 File Offset: 0x00401C14
		public static IEntityOwnerLevelPlay GetRootAsIEntityOwnerLevelPlay(ByteBuffer _bb)
		{
			return IEntityOwnerLevelPlay.GetRootAsIEntityOwnerLevelPlay(_bb, default(IEntityOwnerLevelPlay));
		}

		// Token: 0x0601C5DA RID: 116186 RVA: 0x00403A30 File Offset: 0x00401C30
		public static IEntityOwnerLevelPlay GetRootAsIEntityOwnerLevelPlay(ByteBuffer _bb, IEntityOwnerLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C5DB RID: 116187 RVA: 0x00403A4D File Offset: 0x00401C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C5DC RID: 116188 RVA: 0x00403A5C File Offset: 0x00401C5C
		public IEntityOwnerLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083F3 RID: 33779
		// (get) Token: 0x0601C5DD RID: 116189 RVA: 0x00403A6C File Offset: 0x00401C6C
		public EEntityOwnerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityOwnerType.Quest;
				}
				return (EEntityOwnerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170083F4 RID: 33780
		// (get) Token: 0x0601C5DE RID: 116190 RVA: 0x00403AA8 File Offset: 0x00401CA8
		public int LevelPlayId
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

		// Token: 0x0601C5DF RID: 116191 RVA: 0x00403AE4 File Offset: 0x00401CE4
		public static Offset<IEntityOwnerLevelPlay> CreateIEntityOwnerLevelPlay(FlatBufferBuilder builder, EEntityOwnerType Type = EEntityOwnerType.Quest, int LevelPlayId = 0)
		{
			builder.StartTable(2);
			IEntityOwnerLevelPlay.AddLevelPlayId(builder, LevelPlayId);
			IEntityOwnerLevelPlay.AddType(builder, Type);
			return IEntityOwnerLevelPlay.EndIEntityOwnerLevelPlay(builder);
		}

		// Token: 0x0601C5E0 RID: 116192 RVA: 0x00403B01 File Offset: 0x00401D01
		public static void StartIEntityOwnerLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C5E1 RID: 116193 RVA: 0x00403B0A File Offset: 0x00401D0A
		public static void AddType(FlatBufferBuilder builder, EEntityOwnerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C5E2 RID: 116194 RVA: 0x00403B15 File Offset: 0x00401D15
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601C5E3 RID: 116195 RVA: 0x00403B20 File Offset: 0x00401D20
		public static Offset<IEntityOwnerLevelPlay> EndIEntityOwnerLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<IEntityOwnerLevelPlay>(builder.EndTable());
		}

		// Token: 0x0601C5E4 RID: 116196 RVA: 0x00403B30 File Offset: 0x00401D30
		public IEntityOwnerLevelPlayT UnPack()
		{
			IEntityOwnerLevelPlayT entityOwnerLevelPlayT = new IEntityOwnerLevelPlayT();
			this.UnPackTo(entityOwnerLevelPlayT);
			return entityOwnerLevelPlayT;
		}

		// Token: 0x0601C5E5 RID: 116197 RVA: 0x00403B4B File Offset: 0x00401D4B
		public void UnPackTo(IEntityOwnerLevelPlayT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
		}

		// Token: 0x0601C5E6 RID: 116198 RVA: 0x00403B68 File Offset: 0x00401D68
		public static Offset<IEntityOwnerLevelPlay> Pack(FlatBufferBuilder builder, IEntityOwnerLevelPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityOwnerLevelPlay>);
			}
			return IEntityOwnerLevelPlay.CreateIEntityOwnerLevelPlay(builder, _o.Type, _o.LevelPlayId);
		}

		// Token: 0x0400CC4C RID: 52300
		private Table __p;
	}
}
