using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004865 RID: 18533
	public struct IMatchPlayerRole : IFlatbufferObject
	{
		// Token: 0x1700810F RID: 33039
		// (get) Token: 0x0601B65F RID: 112223 RVA: 0x003E114C File Offset: 0x003DF34C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B660 RID: 112224 RVA: 0x003E1159 File Offset: 0x003DF359
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B661 RID: 112225 RVA: 0x003E1160 File Offset: 0x003DF360
		public static IMatchPlayerRole GetRootAsIMatchPlayerRole(ByteBuffer _bb)
		{
			return IMatchPlayerRole.GetRootAsIMatchPlayerRole(_bb, default(IMatchPlayerRole));
		}

		// Token: 0x0601B662 RID: 112226 RVA: 0x003E117C File Offset: 0x003DF37C
		public static IMatchPlayerRole GetRootAsIMatchPlayerRole(ByteBuffer _bb, IMatchPlayerRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B663 RID: 112227 RVA: 0x003E1199 File Offset: 0x003DF399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B664 RID: 112228 RVA: 0x003E11A8 File Offset: 0x003DF3A8
		public IMatchPlayerRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008110 RID: 33040
		// (get) Token: 0x0601B665 RID: 112229 RVA: 0x003E11B8 File Offset: 0x003DF3B8
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

		// Token: 0x17008111 RID: 33041
		// (get) Token: 0x0601B666 RID: 112230 RVA: 0x003E11F4 File Offset: 0x003DF3F4
		public bool MatchPhantomSkill
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008112 RID: 33042
		// (get) Token: 0x0601B667 RID: 112231 RVA: 0x003E1234 File Offset: 0x003DF434
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

		// Token: 0x0601B668 RID: 112232 RVA: 0x003E1270 File Offset: 0x003DF470
		public static Offset<IMatchPlayerRole> CreateIMatchPlayerRole(FlatBufferBuilder builder, EMatchRoleType Type = EMatchRoleType.Player, bool MatchPhantomSkill = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMatchPlayerRole.AddNullMask(builder, NullMask);
			IMatchPlayerRole.AddMatchPhantomSkill(builder, MatchPhantomSkill);
			IMatchPlayerRole.AddType(builder, Type);
			return IMatchPlayerRole.EndIMatchPlayerRole(builder);
		}

		// Token: 0x0601B669 RID: 112233 RVA: 0x003E1294 File Offset: 0x003DF494
		public static void StartIMatchPlayerRole(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B66A RID: 112234 RVA: 0x003E129D File Offset: 0x003DF49D
		public static void AddType(FlatBufferBuilder builder, EMatchRoleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B66B RID: 112235 RVA: 0x003E12A8 File Offset: 0x003DF4A8
		public static void AddMatchPhantomSkill(FlatBufferBuilder builder, bool matchPhantomSkill)
		{
			builder.AddBool(1, matchPhantomSkill, false);
		}

		// Token: 0x0601B66C RID: 112236 RVA: 0x003E12B3 File Offset: 0x003DF4B3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601B66D RID: 112237 RVA: 0x003E12BE File Offset: 0x003DF4BE
		public static Offset<IMatchPlayerRole> EndIMatchPlayerRole(FlatBufferBuilder builder)
		{
			return new Offset<IMatchPlayerRole>(builder.EndTable());
		}

		// Token: 0x0601B66E RID: 112238 RVA: 0x003E12CC File Offset: 0x003DF4CC
		public IMatchPlayerRoleT UnPack()
		{
			IMatchPlayerRoleT matchPlayerRoleT = new IMatchPlayerRoleT();
			this.UnPackTo(matchPlayerRoleT);
			return matchPlayerRoleT;
		}

		// Token: 0x0601B66F RID: 112239 RVA: 0x003E12E7 File Offset: 0x003DF4E7
		public void UnPackTo(IMatchPlayerRoleT _o)
		{
			_o.Type = this.Type;
			_o.MatchPhantomSkill = this.MatchPhantomSkill;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B670 RID: 112240 RVA: 0x003E1310 File Offset: 0x003DF510
		public static Offset<IMatchPlayerRole> Pack(FlatBufferBuilder builder, IMatchPlayerRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMatchPlayerRole>);
			}
			return IMatchPlayerRole.CreateIMatchPlayerRole(builder, _o.Type, _o.MatchPhantomSkill, _o.NullMask);
		}

		// Token: 0x0400CD7C RID: 52604
		private Table __p;
	}
}
