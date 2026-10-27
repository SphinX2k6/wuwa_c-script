using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x020043FA RID: 17402
	public struct IMatchPhantomRole : IFlatbufferObject
	{
		// Token: 0x17007AC7 RID: 31431
		// (get) Token: 0x06019E74 RID: 106100 RVA: 0x003B4CB8 File Offset: 0x003B2EB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019E75 RID: 106101 RVA: 0x003B4CC5 File Offset: 0x003B2EC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019E76 RID: 106102 RVA: 0x003B4CCC File Offset: 0x003B2ECC
		public static IMatchPhantomRole GetRootAsIMatchPhantomRole(ByteBuffer _bb)
		{
			return IMatchPhantomRole.GetRootAsIMatchPhantomRole(_bb, default(IMatchPhantomRole));
		}

		// Token: 0x06019E77 RID: 106103 RVA: 0x003B4CE8 File Offset: 0x003B2EE8
		public static IMatchPhantomRole GetRootAsIMatchPhantomRole(ByteBuffer _bb, IMatchPhantomRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019E78 RID: 106104 RVA: 0x003B4D05 File Offset: 0x003B2F05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019E79 RID: 106105 RVA: 0x003B4D14 File Offset: 0x003B2F14
		public IMatchPhantomRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AC8 RID: 31432
		// (get) Token: 0x06019E7A RID: 106106 RVA: 0x003B4D24 File Offset: 0x003B2F24
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

		// Token: 0x17007AC9 RID: 31433
		// (get) Token: 0x06019E7B RID: 106107 RVA: 0x003B4D60 File Offset: 0x003B2F60
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

		// Token: 0x17007ACA RID: 31434
		// (get) Token: 0x06019E7C RID: 106108 RVA: 0x003B4D9C File Offset: 0x003B2F9C
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

		// Token: 0x17007ACB RID: 31435
		// (get) Token: 0x06019E7D RID: 106109 RVA: 0x003B4DD8 File Offset: 0x003B2FD8
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

		// Token: 0x06019E7E RID: 106110 RVA: 0x003B4E15 File Offset: 0x003B3015
		public static Offset<IMatchPhantomRole> CreateIMatchPhantomRole(FlatBufferBuilder builder, EMatchRoleType Type = EMatchRoleType.Player, int Id = 0, ECompare Compare = ECompare.Eq, byte NullMask = 0)
		{
			builder.StartTable(4);
			IMatchPhantomRole.AddId(builder, Id);
			IMatchPhantomRole.AddNullMask(builder, NullMask);
			IMatchPhantomRole.AddCompare(builder, Compare);
			IMatchPhantomRole.AddType(builder, Type);
			return IMatchPhantomRole.EndIMatchPhantomRole(builder);
		}

		// Token: 0x06019E7F RID: 106111 RVA: 0x003B4E41 File Offset: 0x003B3041
		public static void StartIMatchPhantomRole(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019E80 RID: 106112 RVA: 0x003B4E4A File Offset: 0x003B304A
		public static void AddType(FlatBufferBuilder builder, EMatchRoleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019E81 RID: 106113 RVA: 0x003B4E55 File Offset: 0x003B3055
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019E82 RID: 106114 RVA: 0x003B4E60 File Offset: 0x003B3060
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06019E83 RID: 106115 RVA: 0x003B4E6B File Offset: 0x003B306B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06019E84 RID: 106116 RVA: 0x003B4E76 File Offset: 0x003B3076
		public static Offset<IMatchPhantomRole> EndIMatchPhantomRole(FlatBufferBuilder builder)
		{
			return new Offset<IMatchPhantomRole>(builder.EndTable());
		}

		// Token: 0x06019E85 RID: 106117 RVA: 0x003B4E84 File Offset: 0x003B3084
		public IMatchPhantomRoleT UnPack()
		{
			IMatchPhantomRoleT matchPhantomRoleT = new IMatchPhantomRoleT();
			this.UnPackTo(matchPhantomRoleT);
			return matchPhantomRoleT;
		}

		// Token: 0x06019E86 RID: 106118 RVA: 0x003B4E9F File Offset: 0x003B309F
		public void UnPackTo(IMatchPhantomRoleT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Compare = this.Compare;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019E87 RID: 106119 RVA: 0x003B4ED4 File Offset: 0x003B30D4
		public static Offset<IMatchPhantomRole> Pack(FlatBufferBuilder builder, IMatchPhantomRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMatchPhantomRole>);
			}
			return IMatchPhantomRole.CreateIMatchPhantomRole(builder, _o.Type, _o.Id, _o.Compare, _o.NullMask);
		}

		// Token: 0x0400C34C RID: 49996
		private Table __p;
	}
}
