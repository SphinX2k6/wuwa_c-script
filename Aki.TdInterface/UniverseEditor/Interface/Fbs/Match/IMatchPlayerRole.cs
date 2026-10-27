using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x020043FD RID: 17405
	public struct IMatchPlayerRole : IFlatbufferObject
	{
		// Token: 0x17007AD0 RID: 31440
		// (get) Token: 0x06019E92 RID: 106130 RVA: 0x003B4FD0 File Offset: 0x003B31D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019E93 RID: 106131 RVA: 0x003B4FDD File Offset: 0x003B31DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019E94 RID: 106132 RVA: 0x003B4FE4 File Offset: 0x003B31E4
		public static IMatchPlayerRole GetRootAsIMatchPlayerRole(ByteBuffer _bb)
		{
			return IMatchPlayerRole.GetRootAsIMatchPlayerRole(_bb, default(IMatchPlayerRole));
		}

		// Token: 0x06019E95 RID: 106133 RVA: 0x003B5000 File Offset: 0x003B3200
		public static IMatchPlayerRole GetRootAsIMatchPlayerRole(ByteBuffer _bb, IMatchPlayerRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019E96 RID: 106134 RVA: 0x003B501D File Offset: 0x003B321D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019E97 RID: 106135 RVA: 0x003B502C File Offset: 0x003B322C
		public IMatchPlayerRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AD1 RID: 31441
		// (get) Token: 0x06019E98 RID: 106136 RVA: 0x003B503C File Offset: 0x003B323C
		public EMatchRoleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMatchRoleType.Player;
				}
				return (EMatchRoleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007AD2 RID: 31442
		// (get) Token: 0x06019E99 RID: 106137 RVA: 0x003B5078 File Offset: 0x003B3278
		public bool MatchPhantomSkill
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007AD3 RID: 31443
		// (get) Token: 0x06019E9A RID: 106138 RVA: 0x003B50B8 File Offset: 0x003B32B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019E9B RID: 106139 RVA: 0x003B50F4 File Offset: 0x003B32F4
		public static Offset<IMatchPlayerRole> CreateIMatchPlayerRole(FlatBufferBuilder builder, EMatchRoleType Type = EMatchRoleType.Player, bool MatchPhantomSkill = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMatchPlayerRole.AddNullMask(builder, NullMask);
			IMatchPlayerRole.AddMatchPhantomSkill(builder, MatchPhantomSkill);
			IMatchPlayerRole.AddType(builder, Type);
			return IMatchPlayerRole.EndIMatchPlayerRole(builder);
		}

		// Token: 0x06019E9C RID: 106140 RVA: 0x003B5118 File Offset: 0x003B3318
		public static void StartIMatchPlayerRole(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019E9D RID: 106141 RVA: 0x003B5121 File Offset: 0x003B3321
		public static void AddType(FlatBufferBuilder builder, EMatchRoleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019E9E RID: 106142 RVA: 0x003B512C File Offset: 0x003B332C
		public static void AddMatchPhantomSkill(FlatBufferBuilder builder, bool matchPhantomSkill)
		{
			builder.AddBool(1, matchPhantomSkill, false);
		}

		// Token: 0x06019E9F RID: 106143 RVA: 0x003B5137 File Offset: 0x003B3337
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06019EA0 RID: 106144 RVA: 0x003B5142 File Offset: 0x003B3342
		public static Offset<IMatchPlayerRole> EndIMatchPlayerRole(FlatBufferBuilder builder)
		{
			return new Offset<IMatchPlayerRole>(builder.EndTable());
		}

		// Token: 0x06019EA1 RID: 106145 RVA: 0x003B5150 File Offset: 0x003B3350
		public IMatchPlayerRoleT UnPack()
		{
			IMatchPlayerRoleT matchPlayerRoleT = new IMatchPlayerRoleT();
			this.UnPackTo(matchPlayerRoleT);
			return matchPlayerRoleT;
		}

		// Token: 0x06019EA2 RID: 106146 RVA: 0x003B516B File Offset: 0x003B336B
		public void UnPackTo(IMatchPlayerRoleT _o)
		{
			_o.Type = this.Type;
			_o.MatchPhantomSkill = this.MatchPhantomSkill;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019EA3 RID: 106147 RVA: 0x003B5194 File Offset: 0x003B3394
		public static Offset<IMatchPlayerRole> Pack(FlatBufferBuilder builder, IMatchPlayerRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMatchPlayerRole>);
			}
			return IMatchPlayerRole.CreateIMatchPlayerRole(builder, _o.Type, _o.MatchPhantomSkill, _o.NullMask);
		}

		// Token: 0x0400C351 RID: 50001
		private Table __p;
	}
}
