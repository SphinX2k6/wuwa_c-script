using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004862 RID: 18530
	public struct IMatchPhantomRole : IFlatbufferObject
	{
		// Token: 0x17008106 RID: 33030
		// (get) Token: 0x0601B641 RID: 112193 RVA: 0x003E0E33 File Offset: 0x003DF033
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B642 RID: 112194 RVA: 0x003E0E40 File Offset: 0x003DF040
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B643 RID: 112195 RVA: 0x003E0E48 File Offset: 0x003DF048
		public static IMatchPhantomRole GetRootAsIMatchPhantomRole(ByteBuffer _bb)
		{
			return IMatchPhantomRole.GetRootAsIMatchPhantomRole(_bb, default(IMatchPhantomRole));
		}

		// Token: 0x0601B644 RID: 112196 RVA: 0x003E0E64 File Offset: 0x003DF064
		public static IMatchPhantomRole GetRootAsIMatchPhantomRole(ByteBuffer _bb, IMatchPhantomRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B645 RID: 112197 RVA: 0x003E0E81 File Offset: 0x003DF081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B646 RID: 112198 RVA: 0x003E0E90 File Offset: 0x003DF090
		public IMatchPhantomRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008107 RID: 33031
		// (get) Token: 0x0601B647 RID: 112199 RVA: 0x003E0EA0 File Offset: 0x003DF0A0
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

		// Token: 0x17008108 RID: 33032
		// (get) Token: 0x0601B648 RID: 112200 RVA: 0x003E0EDC File Offset: 0x003DF0DC
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

		// Token: 0x17008109 RID: 33033
		// (get) Token: 0x0601B649 RID: 112201 RVA: 0x003E0F18 File Offset: 0x003DF118
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700810A RID: 33034
		// (get) Token: 0x0601B64A RID: 112202 RVA: 0x003E0F54 File Offset: 0x003DF154
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B64B RID: 112203 RVA: 0x003E0F91 File Offset: 0x003DF191
		public static Offset<IMatchPhantomRole> CreateIMatchPhantomRole(FlatBufferBuilder builder, EMatchRoleType Type = EMatchRoleType.Player, int Id = 0, ECompare Compare = ECompare.Eq, byte NullMask = 0)
		{
			builder.StartTable(4);
			IMatchPhantomRole.AddId(builder, Id);
			IMatchPhantomRole.AddNullMask(builder, NullMask);
			IMatchPhantomRole.AddCompare(builder, Compare);
			IMatchPhantomRole.AddType(builder, Type);
			return IMatchPhantomRole.EndIMatchPhantomRole(builder);
		}

		// Token: 0x0601B64C RID: 112204 RVA: 0x003E0FBD File Offset: 0x003DF1BD
		public static void StartIMatchPhantomRole(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B64D RID: 112205 RVA: 0x003E0FC6 File Offset: 0x003DF1C6
		public static void AddType(FlatBufferBuilder builder, EMatchRoleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B64E RID: 112206 RVA: 0x003E0FD1 File Offset: 0x003DF1D1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601B64F RID: 112207 RVA: 0x003E0FDC File Offset: 0x003DF1DC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601B650 RID: 112208 RVA: 0x003E0FE7 File Offset: 0x003DF1E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601B651 RID: 112209 RVA: 0x003E0FF2 File Offset: 0x003DF1F2
		public static Offset<IMatchPhantomRole> EndIMatchPhantomRole(FlatBufferBuilder builder)
		{
			return new Offset<IMatchPhantomRole>(builder.EndTable());
		}

		// Token: 0x0601B652 RID: 112210 RVA: 0x003E1000 File Offset: 0x003DF200
		public IMatchPhantomRoleT UnPack()
		{
			IMatchPhantomRoleT matchPhantomRoleT = new IMatchPhantomRoleT();
			this.UnPackTo(matchPhantomRoleT);
			return matchPhantomRoleT;
		}

		// Token: 0x0601B653 RID: 112211 RVA: 0x003E101B File Offset: 0x003DF21B
		public void UnPackTo(IMatchPhantomRoleT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Compare = this.Compare;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B654 RID: 112212 RVA: 0x003E1050 File Offset: 0x003DF250
		public static Offset<IMatchPhantomRole> Pack(FlatBufferBuilder builder, IMatchPhantomRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMatchPhantomRole>);
			}
			return IMatchPhantomRole.CreateIMatchPhantomRole(builder, _o.Type, _o.Id, _o.Compare, _o.NullMask);
		}

		// Token: 0x0400CD77 RID: 52599
		private Table __p;
	}
}
