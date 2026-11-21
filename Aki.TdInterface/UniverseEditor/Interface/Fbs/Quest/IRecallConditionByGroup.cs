using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044BD RID: 17597
	public struct IRecallConditionByGroup : IFlatbufferObject
	{
		// Token: 0x17007A7F RID: 31359
		// (get) Token: 0x060196A6 RID: 104102 RVA: 0x003A0832 File Offset: 0x0039EA32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060196A7 RID: 104103 RVA: 0x003A083F File Offset: 0x0039EA3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060196A8 RID: 104104 RVA: 0x003A0848 File Offset: 0x0039EA48
		public static IRecallConditionByGroup GetRootAsIRecallConditionByGroup(ByteBuffer _bb)
		{
			return IRecallConditionByGroup.GetRootAsIRecallConditionByGroup(_bb, default(IRecallConditionByGroup));
		}

		// Token: 0x060196A9 RID: 104105 RVA: 0x003A0864 File Offset: 0x0039EA64
		public static IRecallConditionByGroup GetRootAsIRecallConditionByGroup(ByteBuffer _bb, IRecallConditionByGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060196AA RID: 104106 RVA: 0x003A0881 File Offset: 0x0039EA81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060196AB RID: 104107 RVA: 0x003A0890 File Offset: 0x0039EA90
		public IRecallConditionByGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A80 RID: 31360
		// (get) Token: 0x060196AC RID: 104108 RVA: 0x003A08A0 File Offset: 0x0039EAA0
		public ERecallConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERecallConditionType.ByEntityType;
				}
				return (ERecallConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007A81 RID: 31361
		// (get) Token: 0x060196AD RID: 104109 RVA: 0x003A08DC File Offset: 0x0039EADC
		public ERecallOperation Operation
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ERecallOperation.Include;
				}
				return (ERecallOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060196AE RID: 104110 RVA: 0x003A0918 File Offset: 0x0039EB18
		public int GroupIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A82 RID: 31362
		// (get) Token: 0x060196AF RID: 104111 RVA: 0x003A0958 File Offset: 0x0039EB58
		public int GroupIdsLength
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

		// Token: 0x060196B0 RID: 104112 RVA: 0x003A0983 File Offset: 0x0039EB83
		public Span<int> GetGroupIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060196B1 RID: 104113 RVA: 0x003A0992 File Offset: 0x0039EB92
		public int[] GetGroupIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x060196B2 RID: 104114 RVA: 0x003A09A0 File Offset: 0x0039EBA0
		public static Offset<IRecallConditionByGroup> CreateIRecallConditionByGroup(FlatBufferBuilder builder, ERecallConditionType Type = ERecallConditionType.ByEntityType, ERecallOperation Operation = ERecallOperation.Include, VectorOffset GroupIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IRecallConditionByGroup.AddGroupIds(builder, GroupIdsOffset);
			IRecallConditionByGroup.AddOperation(builder, Operation);
			IRecallConditionByGroup.AddType(builder, Type);
			return IRecallConditionByGroup.EndIRecallConditionByGroup(builder);
		}

		// Token: 0x060196B3 RID: 104115 RVA: 0x003A09C4 File Offset: 0x0039EBC4
		public static void StartIRecallConditionByGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060196B4 RID: 104116 RVA: 0x003A09CD File Offset: 0x0039EBCD
		public static void AddType(FlatBufferBuilder builder, ERecallConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060196B5 RID: 104117 RVA: 0x003A09D8 File Offset: 0x0039EBD8
		public static void AddOperation(FlatBufferBuilder builder, ERecallOperation operation)
		{
			builder.AddByte(1, (byte)operation, 0);
		}

		// Token: 0x060196B6 RID: 104118 RVA: 0x003A09E3 File Offset: 0x0039EBE3
		public static void AddGroupIds(FlatBufferBuilder builder, VectorOffset groupIdsOffset)
		{
			builder.AddOffset(2, groupIdsOffset.Value, 0);
		}

		// Token: 0x060196B7 RID: 104119 RVA: 0x003A09F4 File Offset: 0x0039EBF4
		public static VectorOffset CreateGroupIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060196B8 RID: 104120 RVA: 0x003A0A2B File Offset: 0x0039EC2B
		public static VectorOffset CreateGroupIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060196B9 RID: 104121 RVA: 0x003A0A45 File Offset: 0x0039EC45
		public static VectorOffset CreateGroupIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060196BA RID: 104122 RVA: 0x003A0A63 File Offset: 0x0039EC63
		public static VectorOffset CreateGroupIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060196BB RID: 104123 RVA: 0x003A0A7C File Offset: 0x0039EC7C
		public static void StartGroupIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060196BC RID: 104124 RVA: 0x003A0A87 File Offset: 0x0039EC87
		public static Offset<IRecallConditionByGroup> EndIRecallConditionByGroup(FlatBufferBuilder builder)
		{
			return new Offset<IRecallConditionByGroup>(builder.EndTable());
		}

		// Token: 0x060196BD RID: 104125 RVA: 0x003A0A94 File Offset: 0x0039EC94
		public IRecallConditionByGroupT UnPack()
		{
			IRecallConditionByGroupT recallConditionByGroupT = new IRecallConditionByGroupT();
			this.UnPackTo(recallConditionByGroupT);
			return recallConditionByGroupT;
		}

		// Token: 0x060196BE RID: 104126 RVA: 0x003A0AB0 File Offset: 0x0039ECB0
		public void UnPackTo(IRecallConditionByGroupT _o)
		{
			_o.Type = this.Type;
			_o.Operation = this.Operation;
			_o.GroupIds = new List<int>();
			for (int i = 0; i < this.GroupIdsLength; i++)
			{
				_o.GroupIds.Add(this.GroupIds(i));
			}
		}

		// Token: 0x060196BF RID: 104127 RVA: 0x003A0B04 File Offset: 0x0039ED04
		public static Offset<IRecallConditionByGroup> Pack(FlatBufferBuilder builder, IRecallConditionByGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallConditionByGroup>);
			}
			VectorOffset groupIdsOffset = default(VectorOffset);
			if (_o.GroupIds != null)
			{
				int[] data = _o.GroupIds.ToArray();
				groupIdsOffset = IRecallConditionByGroup.CreateGroupIdsVector(builder, data);
			}
			return IRecallConditionByGroup.CreateIRecallConditionByGroup(builder, _o.Type, _o.Operation, groupIdsOffset);
		}

		// Token: 0x0400C5E6 RID: 50662
		private Table __p;
	}
}
