using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C4 RID: 22724
	public struct IGroupAiMonsterEcology : IFlatbufferObject
	{
		// Token: 0x1700A4BD RID: 42173
		// (get) Token: 0x06024E36 RID: 151094 RVA: 0x00510BA2 File Offset: 0x0050EDA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024E37 RID: 151095 RVA: 0x00510BAF File Offset: 0x0050EDAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024E38 RID: 151096 RVA: 0x00510BB8 File Offset: 0x0050EDB8
		public static IGroupAiMonsterEcology GetRootAsIGroupAiMonsterEcology(ByteBuffer _bb)
		{
			return IGroupAiMonsterEcology.GetRootAsIGroupAiMonsterEcology(_bb, default(IGroupAiMonsterEcology));
		}

		// Token: 0x06024E39 RID: 151097 RVA: 0x00510BD4 File Offset: 0x0050EDD4
		public static IGroupAiMonsterEcology GetRootAsIGroupAiMonsterEcology(ByteBuffer _bb, IGroupAiMonsterEcology obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024E3A RID: 151098 RVA: 0x00510BF1 File Offset: 0x0050EDF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024E3B RID: 151099 RVA: 0x00510C00 File Offset: 0x0050EE00
		public IGroupAiMonsterEcology __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4BE RID: 42174
		// (get) Token: 0x06024E3C RID: 151100 RVA: 0x00510C10 File Offset: 0x0050EE10
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

		// Token: 0x1700A4BF RID: 42175
		// (get) Token: 0x06024E3D RID: 151101 RVA: 0x00510C4C File Offset: 0x0050EE4C
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

		// Token: 0x06024E3E RID: 151102 RVA: 0x00510C88 File Offset: 0x0050EE88
		public IGroupAiMonsterMember? Members(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IGroupAiMonsterMember?(default(IGroupAiMonsterMember).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A4C0 RID: 42176
		// (get) Token: 0x06024E3F RID: 151103 RVA: 0x00510CE8 File Offset: 0x0050EEE8
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

		// Token: 0x06024E40 RID: 151104 RVA: 0x00510D13 File Offset: 0x0050EF13
		public static Offset<IGroupAiMonsterEcology> CreateIGroupAiMonsterEcology(FlatBufferBuilder builder, EGroupAiMode Type = EGroupAiMode.Default, int Leader = 0, VectorOffset MembersOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGroupAiMonsterEcology.AddMembers(builder, MembersOffset);
			IGroupAiMonsterEcology.AddLeader(builder, Leader);
			IGroupAiMonsterEcology.AddType(builder, Type);
			return IGroupAiMonsterEcology.EndIGroupAiMonsterEcology(builder);
		}

		// Token: 0x06024E41 RID: 151105 RVA: 0x00510D37 File Offset: 0x0050EF37
		public static void StartIGroupAiMonsterEcology(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024E42 RID: 151106 RVA: 0x00510D40 File Offset: 0x0050EF40
		public static void AddType(FlatBufferBuilder builder, EGroupAiMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024E43 RID: 151107 RVA: 0x00510D4B File Offset: 0x0050EF4B
		public static void AddLeader(FlatBufferBuilder builder, int leader)
		{
			builder.AddInt(1, leader, 0);
		}

		// Token: 0x06024E44 RID: 151108 RVA: 0x00510D56 File Offset: 0x0050EF56
		public static void AddMembers(FlatBufferBuilder builder, VectorOffset membersOffset)
		{
			builder.AddOffset(2, membersOffset.Value, 0);
		}

		// Token: 0x06024E45 RID: 151109 RVA: 0x00510D68 File Offset: 0x0050EF68
		public static VectorOffset CreateMembersVector(FlatBufferBuilder builder, Offset<IGroupAiMonsterMember>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024E46 RID: 151110 RVA: 0x00510DA8 File Offset: 0x0050EFA8
		public static VectorOffset CreateMembersVectorBlock(FlatBufferBuilder builder, Offset<IGroupAiMonsterMember>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGroupAiMonsterMember>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024E47 RID: 151111 RVA: 0x00510DC2 File Offset: 0x0050EFC2
		public static VectorOffset CreateMembersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGroupAiMonsterMember>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGroupAiMonsterMember>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024E48 RID: 151112 RVA: 0x00510DE0 File Offset: 0x0050EFE0
		public static VectorOffset CreateMembersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGroupAiMonsterMember>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024E49 RID: 151113 RVA: 0x00510DF9 File Offset: 0x0050EFF9
		public static void StartMembersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024E4A RID: 151114 RVA: 0x00510E04 File Offset: 0x0050F004
		public static Offset<IGroupAiMonsterEcology> EndIGroupAiMonsterEcology(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiMonsterEcology>(builder.EndTable());
		}

		// Token: 0x06024E4B RID: 151115 RVA: 0x00510E14 File Offset: 0x0050F014
		public IGroupAiMonsterEcologyT UnPack()
		{
			IGroupAiMonsterEcologyT groupAiMonsterEcologyT = new IGroupAiMonsterEcologyT();
			this.UnPackTo(groupAiMonsterEcologyT);
			return groupAiMonsterEcologyT;
		}

		// Token: 0x06024E4C RID: 151116 RVA: 0x00510E30 File Offset: 0x0050F030
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

		// Token: 0x06024E4D RID: 151117 RVA: 0x00510EA8 File Offset: 0x0050F0A8
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

		// Token: 0x0400F138 RID: 61752
		private Table __p;
	}
}
