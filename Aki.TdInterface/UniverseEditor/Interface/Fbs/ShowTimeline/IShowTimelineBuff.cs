using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FB5 RID: 16309
	public struct IShowTimelineBuff : IFlatbufferObject
	{
		// Token: 0x17006E53 RID: 28243
		// (get) Token: 0x060163D9 RID: 91097 RVA: 0x0032FD46 File Offset: 0x0032DF46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060163DA RID: 91098 RVA: 0x0032FD53 File Offset: 0x0032DF53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060163DB RID: 91099 RVA: 0x0032FD5C File Offset: 0x0032DF5C
		public static IShowTimelineBuff GetRootAsIShowTimelineBuff(ByteBuffer _bb)
		{
			return IShowTimelineBuff.GetRootAsIShowTimelineBuff(_bb, default(IShowTimelineBuff));
		}

		// Token: 0x060163DC RID: 91100 RVA: 0x0032FD78 File Offset: 0x0032DF78
		public static IShowTimelineBuff GetRootAsIShowTimelineBuff(ByteBuffer _bb, IShowTimelineBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060163DD RID: 91101 RVA: 0x0032FD95 File Offset: 0x0032DF95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060163DE RID: 91102 RVA: 0x0032FDA4 File Offset: 0x0032DFA4
		public IShowTimelineBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E54 RID: 28244
		// (get) Token: 0x060163DF RID: 91103 RVA: 0x0032FDB4 File Offset: 0x0032DFB4
		public EShowTimelineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineType.Checkpoint;
				}
				return (EShowTimelineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060163E0 RID: 91104 RVA: 0x0032FDF0 File Offset: 0x0032DFF0
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17006E55 RID: 28245
		// (get) Token: 0x060163E1 RID: 91105 RVA: 0x0032FE30 File Offset: 0x0032E030
		public int BuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060163E2 RID: 91106 RVA: 0x0032FE5B File Offset: 0x0032E05B
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x060163E3 RID: 91107 RVA: 0x0032FE6A File Offset: 0x0032E06A
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(6);
		}

		// Token: 0x060163E4 RID: 91108 RVA: 0x0032FE78 File Offset: 0x0032E078
		public IShowTimelineRoleBuff? RoleBuffs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IShowTimelineRoleBuff?(default(IShowTimelineRoleBuff).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006E56 RID: 28246
		// (get) Token: 0x060163E5 RID: 91109 RVA: 0x0032FED8 File Offset: 0x0032E0D8
		public int RoleBuffsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17006E57 RID: 28247
		// (get) Token: 0x060163E6 RID: 91110 RVA: 0x0032FF04 File Offset: 0x0032E104
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

		// Token: 0x060163E7 RID: 91111 RVA: 0x0032FF41 File Offset: 0x0032E141
		public static Offset<IShowTimelineBuff> CreateIShowTimelineBuff(FlatBufferBuilder builder, EShowTimelineType Type = EShowTimelineType.Checkpoint, VectorOffset BuffIdsOffset = default(VectorOffset), VectorOffset RoleBuffsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IShowTimelineBuff.AddRoleBuffs(builder, RoleBuffsOffset);
			IShowTimelineBuff.AddBuffIds(builder, BuffIdsOffset);
			IShowTimelineBuff.AddNullMask(builder, NullMask);
			IShowTimelineBuff.AddType(builder, Type);
			return IShowTimelineBuff.EndIShowTimelineBuff(builder);
		}

		// Token: 0x060163E8 RID: 91112 RVA: 0x0032FF6D File Offset: 0x0032E16D
		public static void StartIShowTimelineBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060163E9 RID: 91113 RVA: 0x0032FF76 File Offset: 0x0032E176
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060163EA RID: 91114 RVA: 0x0032FF81 File Offset: 0x0032E181
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(1, buffIdsOffset.Value, 0);
		}

		// Token: 0x060163EB RID: 91115 RVA: 0x0032FF94 File Offset: 0x0032E194
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060163EC RID: 91116 RVA: 0x0032FFCB File Offset: 0x0032E1CB
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x060163ED RID: 91117 RVA: 0x0032FFE5 File Offset: 0x0032E1E5
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x060163EE RID: 91118 RVA: 0x00330003 File Offset: 0x0032E203
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060163EF RID: 91119 RVA: 0x0033001C File Offset: 0x0032E21C
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x060163F0 RID: 91120 RVA: 0x00330027 File Offset: 0x0032E227
		public static void AddRoleBuffs(FlatBufferBuilder builder, VectorOffset roleBuffsOffset)
		{
			builder.AddOffset(2, roleBuffsOffset.Value, 0);
		}

		// Token: 0x060163F1 RID: 91121 RVA: 0x00330038 File Offset: 0x0032E238
		public static VectorOffset CreateRoleBuffsVector(FlatBufferBuilder builder, Offset<IShowTimelineRoleBuff>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060163F2 RID: 91122 RVA: 0x00330078 File Offset: 0x0032E278
		public static VectorOffset CreateRoleBuffsVectorBlock(FlatBufferBuilder builder, Offset<IShowTimelineRoleBuff>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IShowTimelineRoleBuff>>(data);
			return builder.EndVector();
		}

		// Token: 0x060163F3 RID: 91123 RVA: 0x00330092 File Offset: 0x0032E292
		public static VectorOffset CreateRoleBuffsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IShowTimelineRoleBuff>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IShowTimelineRoleBuff>>(data);
			return builder.EndVector();
		}

		// Token: 0x060163F4 RID: 91124 RVA: 0x003300B0 File Offset: 0x0032E2B0
		public static VectorOffset CreateRoleBuffsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IShowTimelineRoleBuff>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060163F5 RID: 91125 RVA: 0x003300C9 File Offset: 0x0032E2C9
		public static void StartRoleBuffsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060163F6 RID: 91126 RVA: 0x003300D4 File Offset: 0x0032E2D4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060163F7 RID: 91127 RVA: 0x003300DF File Offset: 0x0032E2DF
		public static Offset<IShowTimelineBuff> EndIShowTimelineBuff(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineBuff>(builder.EndTable());
		}

		// Token: 0x060163F8 RID: 91128 RVA: 0x003300EC File Offset: 0x0032E2EC
		public IShowTimelineBuffT UnPack()
		{
			IShowTimelineBuffT showTimelineBuffT = new IShowTimelineBuffT();
			this.UnPackTo(showTimelineBuffT);
			return showTimelineBuffT;
		}

		// Token: 0x060163F9 RID: 91129 RVA: 0x00330108 File Offset: 0x0032E308
		public void UnPackTo(IShowTimelineBuffT _o)
		{
			_o.Type = this.Type;
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
			_o.RoleBuffs = new List<IShowTimelineRoleBuffT>();
			for (int j = 0; j < this.RoleBuffsLength; j++)
			{
				_o.RoleBuffs.Add((this.RoleBuffs(j) != null) ? this.RoleBuffs(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060163FA RID: 91130 RVA: 0x003301B0 File Offset: 0x0032E3B0
		public static Offset<IShowTimelineBuff> Pack(FlatBufferBuilder builder, IShowTimelineBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineBuff>);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IShowTimelineBuff.CreateBuffIdsVector(builder, data);
			}
			VectorOffset roleBuffsOffset = default(VectorOffset);
			if (_o.RoleBuffs != null)
			{
				Offset<IShowTimelineRoleBuff>[] array = new Offset<IShowTimelineRoleBuff>[_o.RoleBuffs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IShowTimelineRoleBuff.Pack(builder, _o.RoleBuffs[i]);
				}
				roleBuffsOffset = IShowTimelineBuff.CreateRoleBuffsVector(builder, array);
			}
			return IShowTimelineBuff.CreateIShowTimelineBuff(builder, _o.Type, buffIdsOffset, roleBuffsOffset, _o.NullMask);
		}

		// Token: 0x0400BAA7 RID: 47783
		private Table __p;
	}
}
