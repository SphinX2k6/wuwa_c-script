using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C2B RID: 19499
	public struct IEntityOwnerLevelPlay : IFlatbufferObject
	{
		// Token: 0x17008A33 RID: 35379
		// (get) Token: 0x0601DDAC RID: 122284 RVA: 0x0042FC9A File Offset: 0x0042DE9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DDAD RID: 122285 RVA: 0x0042FCA7 File Offset: 0x0042DEA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DDAE RID: 122286 RVA: 0x0042FCB0 File Offset: 0x0042DEB0
		public static IEntityOwnerLevelPlay GetRootAsIEntityOwnerLevelPlay(ByteBuffer _bb)
		{
			return IEntityOwnerLevelPlay.GetRootAsIEntityOwnerLevelPlay(_bb, default(IEntityOwnerLevelPlay));
		}

		// Token: 0x0601DDAF RID: 122287 RVA: 0x0042FCCC File Offset: 0x0042DECC
		public static IEntityOwnerLevelPlay GetRootAsIEntityOwnerLevelPlay(ByteBuffer _bb, IEntityOwnerLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DDB0 RID: 122288 RVA: 0x0042FCE9 File Offset: 0x0042DEE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DDB1 RID: 122289 RVA: 0x0042FCF8 File Offset: 0x0042DEF8
		public IEntityOwnerLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A34 RID: 35380
		// (get) Token: 0x0601DDB2 RID: 122290 RVA: 0x0042FD08 File Offset: 0x0042DF08
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

		// Token: 0x17008A35 RID: 35381
		// (get) Token: 0x0601DDB3 RID: 122291 RVA: 0x0042FD44 File Offset: 0x0042DF44
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

		// Token: 0x0601DDB4 RID: 122292 RVA: 0x0042FD80 File Offset: 0x0042DF80
		public static Offset<IEntityOwnerLevelPlay> CreateIEntityOwnerLevelPlay(FlatBufferBuilder builder, EEntityOwnerType Type = EEntityOwnerType.Quest, int LevelPlayId = 0)
		{
			builder.StartTable(2);
			IEntityOwnerLevelPlay.AddLevelPlayId(builder, LevelPlayId);
			IEntityOwnerLevelPlay.AddType(builder, Type);
			return IEntityOwnerLevelPlay.EndIEntityOwnerLevelPlay(builder);
		}

		// Token: 0x0601DDB5 RID: 122293 RVA: 0x0042FD9D File Offset: 0x0042DF9D
		public static void StartIEntityOwnerLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DDB6 RID: 122294 RVA: 0x0042FDA6 File Offset: 0x0042DFA6
		public static void AddType(FlatBufferBuilder builder, EEntityOwnerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DDB7 RID: 122295 RVA: 0x0042FDB1 File Offset: 0x0042DFB1
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601DDB8 RID: 122296 RVA: 0x0042FDBC File Offset: 0x0042DFBC
		public static Offset<IEntityOwnerLevelPlay> EndIEntityOwnerLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<IEntityOwnerLevelPlay>(builder.EndTable());
		}

		// Token: 0x0601DDB9 RID: 122297 RVA: 0x0042FDCC File Offset: 0x0042DFCC
		public IEntityOwnerLevelPlayT UnPack()
		{
			IEntityOwnerLevelPlayT entityOwnerLevelPlayT = new IEntityOwnerLevelPlayT();
			this.UnPackTo(entityOwnerLevelPlayT);
			return entityOwnerLevelPlayT;
		}

		// Token: 0x0601DDBA RID: 122298 RVA: 0x0042FDE7 File Offset: 0x0042DFE7
		public void UnPackTo(IEntityOwnerLevelPlayT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
		}

		// Token: 0x0601DDBB RID: 122299 RVA: 0x0042FE04 File Offset: 0x0042E004
		public static Offset<IEntityOwnerLevelPlay> Pack(FlatBufferBuilder builder, IEntityOwnerLevelPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityOwnerLevelPlay>);
			}
			return IEntityOwnerLevelPlay.CreateIEntityOwnerLevelPlay(builder, _o.Type, _o.LevelPlayId);
		}

		// Token: 0x0400D682 RID: 54914
		private Table __p;
	}
}
