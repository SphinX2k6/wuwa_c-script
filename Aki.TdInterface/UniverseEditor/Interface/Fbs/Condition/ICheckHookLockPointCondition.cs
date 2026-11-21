using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F35 RID: 20277
	public struct ICheckHookLockPointCondition : IFlatbufferObject
	{
		// Token: 0x170090DB RID: 37083
		// (get) Token: 0x0601F857 RID: 129111 RVA: 0x00462D94 File Offset: 0x00460F94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F858 RID: 129112 RVA: 0x00462DA1 File Offset: 0x00460FA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F859 RID: 129113 RVA: 0x00462DA8 File Offset: 0x00460FA8
		public static ICheckHookLockPointCondition GetRootAsICheckHookLockPointCondition(ByteBuffer _bb)
		{
			return ICheckHookLockPointCondition.GetRootAsICheckHookLockPointCondition(_bb, default(ICheckHookLockPointCondition));
		}

		// Token: 0x0601F85A RID: 129114 RVA: 0x00462DC4 File Offset: 0x00460FC4
		public static ICheckHookLockPointCondition GetRootAsICheckHookLockPointCondition(ByteBuffer _bb, ICheckHookLockPointCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F85B RID: 129115 RVA: 0x00462DE1 File Offset: 0x00460FE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F85C RID: 129116 RVA: 0x00462DF0 File Offset: 0x00460FF0
		public ICheckHookLockPointCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090DC RID: 37084
		// (get) Token: 0x0601F85D RID: 129117 RVA: 0x00462E00 File Offset: 0x00461000
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F85E RID: 129118 RVA: 0x00462E3C File Offset: 0x0046103C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170090DD RID: 37085
		// (get) Token: 0x0601F85F RID: 129119 RVA: 0x00462E7C File Offset: 0x0046107C
		public int EntityIdsLength
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

		// Token: 0x0601F860 RID: 129120 RVA: 0x00462EA7 File Offset: 0x004610A7
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601F861 RID: 129121 RVA: 0x00462EB6 File Offset: 0x004610B6
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x170090DE RID: 37086
		// (get) Token: 0x0601F862 RID: 129122 RVA: 0x00462EC4 File Offset: 0x004610C4
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

		// Token: 0x0601F863 RID: 129123 RVA: 0x00462F00 File Offset: 0x00461100
		public static Offset<ICheckHookLockPointCondition> CreateICheckHookLockPointCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, VectorOffset EntityIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ICheckHookLockPointCondition.AddEntityIds(builder, EntityIdsOffset);
			ICheckHookLockPointCondition.AddNullMask(builder, NullMask);
			ICheckHookLockPointCondition.AddType(builder, Type);
			return ICheckHookLockPointCondition.EndICheckHookLockPointCondition(builder);
		}

		// Token: 0x0601F864 RID: 129124 RVA: 0x00462F24 File Offset: 0x00461124
		public static void StartICheckHookLockPointCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F865 RID: 129125 RVA: 0x00462F2D File Offset: 0x0046112D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F866 RID: 129126 RVA: 0x00462F38 File Offset: 0x00461138
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601F867 RID: 129127 RVA: 0x00462F48 File Offset: 0x00461148
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F868 RID: 129128 RVA: 0x00462F7F File Offset: 0x0046117F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F869 RID: 129129 RVA: 0x00462F99 File Offset: 0x00461199
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F86A RID: 129130 RVA: 0x00462FB7 File Offset: 0x004611B7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F86B RID: 129131 RVA: 0x00462FD0 File Offset: 0x004611D0
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F86C RID: 129132 RVA: 0x00462FDB File Offset: 0x004611DB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601F86D RID: 129133 RVA: 0x00462FE6 File Offset: 0x004611E6
		public static Offset<ICheckHookLockPointCondition> EndICheckHookLockPointCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHookLockPointCondition>(builder.EndTable());
		}

		// Token: 0x0601F86E RID: 129134 RVA: 0x00462FF4 File Offset: 0x004611F4
		public ICheckHookLockPointConditionT UnPack()
		{
			ICheckHookLockPointConditionT checkHookLockPointConditionT = new ICheckHookLockPointConditionT();
			this.UnPackTo(checkHookLockPointConditionT);
			return checkHookLockPointConditionT;
		}

		// Token: 0x0601F86F RID: 129135 RVA: 0x00463010 File Offset: 0x00461210
		public void UnPackTo(ICheckHookLockPointConditionT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F870 RID: 129136 RVA: 0x00463064 File Offset: 0x00461264
		public static Offset<ICheckHookLockPointCondition> Pack(FlatBufferBuilder builder, ICheckHookLockPointConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHookLockPointCondition>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ICheckHookLockPointCondition.CreateEntityIdsVector(builder, data);
			}
			return ICheckHookLockPointCondition.CreateICheckHookLockPointCondition(builder, _o.Type, entityIdsOffset, _o.NullMask);
		}

		// Token: 0x0400DDB0 RID: 56752
		private Table __p;
	}
}
