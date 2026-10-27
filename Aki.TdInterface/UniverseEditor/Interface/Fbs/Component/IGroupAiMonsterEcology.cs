using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200533E RID: 21310
	public struct IGroupAiMonsterEcology : IFlatbufferObject
	{
		// Token: 0x17009C85 RID: 40069
		// (get) Token: 0x06022D82 RID: 142722 RVA: 0x004D3CCE File Offset: 0x004D1ECE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022D83 RID: 142723 RVA: 0x004D3CDB File Offset: 0x004D1EDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022D84 RID: 142724 RVA: 0x004D3CE4 File Offset: 0x004D1EE4
		public static IGroupAiMonsterEcology GetRootAsIGroupAiMonsterEcology(ByteBuffer _bb)
		{
			return IGroupAiMonsterEcology.GetRootAsIGroupAiMonsterEcology(_bb, default(IGroupAiMonsterEcology));
		}

		// Token: 0x06022D85 RID: 142725 RVA: 0x004D3D00 File Offset: 0x004D1F00
		public static IGroupAiMonsterEcology GetRootAsIGroupAiMonsterEcology(ByteBuffer _bb, IGroupAiMonsterEcology obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022D86 RID: 142726 RVA: 0x004D3D1D File Offset: 0x004D1F1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022D87 RID: 142727 RVA: 0x004D3D2C File Offset: 0x004D1F2C
		public IGroupAiMonsterEcology __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C86 RID: 40070
		// (get) Token: 0x06022D88 RID: 142728 RVA: 0x004D3D3C File Offset: 0x004D1F3C
		public EGroupAiMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupAiMode.Default;
				}
				return (EGroupAiMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009C87 RID: 40071
		// (get) Token: 0x06022D89 RID: 142729 RVA: 0x004D3D78 File Offset: 0x004D1F78
		public int Leader
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

		// Token: 0x06022D8A RID: 142730 RVA: 0x004D3DB4 File Offset: 0x004D1FB4
		public IGroupAiMonsterMember? Members(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IGroupAiMonsterMember?(default(IGroupAiMonsterMember).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C88 RID: 40072
		// (get) Token: 0x06022D8B RID: 142731 RVA: 0x004D3E14 File Offset: 0x004D2014
		public int MembersLength
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

		// Token: 0x06022D8C RID: 142732 RVA: 0x004D3E3F File Offset: 0x004D203F
		public static Offset<IGroupAiMonsterEcology> CreateIGroupAiMonsterEcology(FlatBufferBuilder builder, EGroupAiMode Type = EGroupAiMode.Default, int Leader = 0, VectorOffset MembersOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGroupAiMonsterEcology.AddMembers(builder, MembersOffset);
			IGroupAiMonsterEcology.AddLeader(builder, Leader);
			IGroupAiMonsterEcology.AddType(builder, Type);
			return IGroupAiMonsterEcology.EndIGroupAiMonsterEcology(builder);
		}

		// Token: 0x06022D8D RID: 142733 RVA: 0x004D3E63 File Offset: 0x004D2063
		public static void StartIGroupAiMonsterEcology(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022D8E RID: 142734 RVA: 0x004D3E6C File Offset: 0x004D206C
		public static void AddType(FlatBufferBuilder builder, EGroupAiMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022D8F RID: 142735 RVA: 0x004D3E77 File Offset: 0x004D2077
		public static void AddLeader(FlatBufferBuilder builder, int leader)
		{
			builder.AddInt(1, leader, 0);
		}

		// Token: 0x06022D90 RID: 142736 RVA: 0x004D3E82 File Offset: 0x004D2082
		public static void AddMembers(FlatBufferBuilder builder, VectorOffset membersOffset)
		{
			builder.AddOffset(2, membersOffset.Value, 0);
		}

		// Token: 0x06022D91 RID: 142737 RVA: 0x004D3E94 File Offset: 0x004D2094
		public static VectorOffset CreateMembersVector(FlatBufferBuilder builder, Offset<IGroupAiMonsterMember>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022D92 RID: 142738 RVA: 0x004D3ED4 File Offset: 0x004D20D4
		public static VectorOffset CreateMembersVectorBlock(FlatBufferBuilder builder, Offset<IGroupAiMonsterMember>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGroupAiMonsterMember>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D93 RID: 142739 RVA: 0x004D3EEE File Offset: 0x004D20EE
		public static VectorOffset CreateMembersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGroupAiMonsterMember>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGroupAiMonsterMember>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D94 RID: 142740 RVA: 0x004D3F0C File Offset: 0x004D210C
		public static VectorOffset CreateMembersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGroupAiMonsterMember>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022D95 RID: 142741 RVA: 0x004D3F25 File Offset: 0x004D2125
		public static void StartMembersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022D96 RID: 142742 RVA: 0x004D3F30 File Offset: 0x004D2130
		public static Offset<IGroupAiMonsterEcology> EndIGroupAiMonsterEcology(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiMonsterEcology>(builder.EndTable());
		}

		// Token: 0x06022D97 RID: 142743 RVA: 0x004D3F40 File Offset: 0x004D2140
		public IGroupAiMonsterEcologyT UnPack()
		{
			IGroupAiMonsterEcologyT groupAiMonsterEcologyT = new IGroupAiMonsterEcologyT();
			this.UnPackTo(groupAiMonsterEcologyT);
			return groupAiMonsterEcologyT;
		}

		// Token: 0x06022D98 RID: 142744 RVA: 0x004D3F5C File Offset: 0x004D215C
		public void UnPackTo(IGroupAiMonsterEcologyT _o)
		{
			_o.Type = this.Type;
			_o.Leader = this.Leader;
			_o.Members = new List<IGroupAiMonsterMemberT>();
			for (int i = 0; i < this.MembersLength; i++)
			{
				_o.Members.Add((this.Members(i) != null) ? this.Members(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06022D99 RID: 142745 RVA: 0x004D3FD4 File Offset: 0x004D21D4
		public static Offset<IGroupAiMonsterEcology> Pack(FlatBufferBuilder builder, IGroupAiMonsterEcologyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiMonsterEcology>);
			}
			VectorOffset membersOffset = default(VectorOffset);
			if (_o.Members != null)
			{
				Offset<IGroupAiMonsterMember>[] array = new Offset<IGroupAiMonsterMember>[_o.Members.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IGroupAiMonsterMember.Pack(builder, _o.Members[i]);
				}
				membersOffset = IGroupAiMonsterEcology.CreateMembersVector(builder, array);
			}
			return IGroupAiMonsterEcology.CreateIGroupAiMonsterEcology(builder, _o.Type, _o.Leader, membersOffset);
		}

		// Token: 0x0400E508 RID: 58632
		private Table __p;
	}
}
