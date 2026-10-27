using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200407C RID: 16508
	public struct IRecallConditionByGroup : IFlatbufferObject
	{
		// Token: 0x1700747D RID: 29821
		// (get) Token: 0x0601800D RID: 98317 RVA: 0x003769FA File Offset: 0x00374BFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601800E RID: 98318 RVA: 0x00376A07 File Offset: 0x00374C07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601800F RID: 98319 RVA: 0x00376A10 File Offset: 0x00374C10
		public static IRecallConditionByGroup GetRootAsIRecallConditionByGroup(ByteBuffer _bb)
		{
			return IRecallConditionByGroup.GetRootAsIRecallConditionByGroup(_bb, default(IRecallConditionByGroup));
		}

		// Token: 0x06018010 RID: 98320 RVA: 0x00376A2C File Offset: 0x00374C2C
		public static IRecallConditionByGroup GetRootAsIRecallConditionByGroup(ByteBuffer _bb, IRecallConditionByGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018011 RID: 98321 RVA: 0x00376A49 File Offset: 0x00374C49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018012 RID: 98322 RVA: 0x00376A58 File Offset: 0x00374C58
		public IRecallConditionByGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700747E RID: 29822
		// (get) Token: 0x06018013 RID: 98323 RVA: 0x00376A68 File Offset: 0x00374C68
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

		// Token: 0x1700747F RID: 29823
		// (get) Token: 0x06018014 RID: 98324 RVA: 0x00376AA4 File Offset: 0x00374CA4
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

		// Token: 0x06018015 RID: 98325 RVA: 0x00376AE0 File Offset: 0x00374CE0
		public int GroupIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007480 RID: 29824
		// (get) Token: 0x06018016 RID: 98326 RVA: 0x00376B20 File Offset: 0x00374D20
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

		// Token: 0x06018017 RID: 98327 RVA: 0x00376B4B File Offset: 0x00374D4B
		public Span<int> GetGroupIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06018018 RID: 98328 RVA: 0x00376B5A File Offset: 0x00374D5A
		public int[] GetGroupIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06018019 RID: 98329 RVA: 0x00376B68 File Offset: 0x00374D68
		public static Offset<IRecallConditionByGroup> CreateIRecallConditionByGroup(FlatBufferBuilder builder, ERecallConditionType Type = ERecallConditionType.ByEntityType, ERecallOperation Operation = ERecallOperation.Include, VectorOffset GroupIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IRecallConditionByGroup.AddGroupIds(builder, GroupIdsOffset);
			IRecallConditionByGroup.AddOperation(builder, Operation);
			IRecallConditionByGroup.AddType(builder, Type);
			return IRecallConditionByGroup.EndIRecallConditionByGroup(builder);
		}

		// Token: 0x0601801A RID: 98330 RVA: 0x00376B8C File Offset: 0x00374D8C
		public static void StartIRecallConditionByGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601801B RID: 98331 RVA: 0x00376B95 File Offset: 0x00374D95
		public static void AddType(FlatBufferBuilder builder, ERecallConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601801C RID: 98332 RVA: 0x00376BA0 File Offset: 0x00374DA0
		public static void AddOperation(FlatBufferBuilder builder, ERecallOperation operation)
		{
			builder.AddByte(1, (byte)operation, 0);
		}

		// Token: 0x0601801D RID: 98333 RVA: 0x00376BAB File Offset: 0x00374DAB
		public static void AddGroupIds(FlatBufferBuilder builder, VectorOffset groupIdsOffset)
		{
			builder.AddOffset(2, groupIdsOffset.Value, 0);
		}

		// Token: 0x0601801E RID: 98334 RVA: 0x00376BBC File Offset: 0x00374DBC
		public static VectorOffset CreateGroupIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601801F RID: 98335 RVA: 0x00376BF3 File Offset: 0x00374DF3
		public static VectorOffset CreateGroupIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018020 RID: 98336 RVA: 0x00376C0D File Offset: 0x00374E0D
		public static VectorOffset CreateGroupIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018021 RID: 98337 RVA: 0x00376C2B File Offset: 0x00374E2B
		public static VectorOffset CreateGroupIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018022 RID: 98338 RVA: 0x00376C44 File Offset: 0x00374E44
		public static void StartGroupIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018023 RID: 98339 RVA: 0x00376C4F File Offset: 0x00374E4F
		public static Offset<IRecallConditionByGroup> EndIRecallConditionByGroup(FlatBufferBuilder builder)
		{
			return new Offset<IRecallConditionByGroup>(builder.EndTable());
		}

		// Token: 0x06018024 RID: 98340 RVA: 0x00376C5C File Offset: 0x00374E5C
		public IRecallConditionByGroupT UnPack()
		{
			IRecallConditionByGroupT recallConditionByGroupT = new IRecallConditionByGroupT();
			this.UnPackTo(recallConditionByGroupT);
			return recallConditionByGroupT;
		}

		// Token: 0x06018025 RID: 98341 RVA: 0x00376C78 File Offset: 0x00374E78
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

		// Token: 0x06018026 RID: 98342 RVA: 0x00376CCC File Offset: 0x00374ECC
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

		// Token: 0x0400BBFF RID: 48127
		private Table __p;
	}
}
