using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006382 RID: 25474
	public struct IClearEntityVisibleTag : IFlatbufferObject
	{
		// Token: 0x1700BDF0 RID: 48624
		// (get) Token: 0x0602C0F3 RID: 180467 RVA: 0x0060D60A File Offset: 0x0060B80A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C0F4 RID: 180468 RVA: 0x0060D617 File Offset: 0x0060B817
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C0F5 RID: 180469 RVA: 0x0060D620 File Offset: 0x0060B820
		public static IClearEntityVisibleTag GetRootAsIClearEntityVisibleTag(ByteBuffer _bb)
		{
			return IClearEntityVisibleTag.GetRootAsIClearEntityVisibleTag(_bb, default(IClearEntityVisibleTag));
		}

		// Token: 0x0602C0F6 RID: 180470 RVA: 0x0060D63C File Offset: 0x0060B83C
		public static IClearEntityVisibleTag GetRootAsIClearEntityVisibleTag(ByteBuffer _bb, IClearEntityVisibleTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C0F7 RID: 180471 RVA: 0x0060D659 File Offset: 0x0060B859
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C0F8 RID: 180472 RVA: 0x0060D668 File Offset: 0x0060B868
		public IClearEntityVisibleTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C0F9 RID: 180473 RVA: 0x0060D678 File Offset: 0x0060B878
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BDF1 RID: 48625
		// (get) Token: 0x0602C0FA RID: 180474 RVA: 0x0060D6B8 File Offset: 0x0060B8B8
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602C0FB RID: 180475 RVA: 0x0060D6E3 File Offset: 0x0060B8E3
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602C0FC RID: 180476 RVA: 0x0060D6F2 File Offset: 0x0060B8F2
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602C0FD RID: 180477 RVA: 0x0060D700 File Offset: 0x0060B900
		public static Offset<IClearEntityVisibleTag> CreateIClearEntityVisibleTag(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IClearEntityVisibleTag.AddEntityIds(builder, EntityIdsOffset);
			return IClearEntityVisibleTag.EndIClearEntityVisibleTag(builder);
		}

		// Token: 0x0602C0FE RID: 180478 RVA: 0x0060D716 File Offset: 0x0060B916
		public static void StartIClearEntityVisibleTag(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C0FF RID: 180479 RVA: 0x0060D71F File Offset: 0x0060B91F
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602C100 RID: 180480 RVA: 0x0060D730 File Offset: 0x0060B930
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C101 RID: 180481 RVA: 0x0060D767 File Offset: 0x0060B967
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C102 RID: 180482 RVA: 0x0060D781 File Offset: 0x0060B981
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C103 RID: 180483 RVA: 0x0060D79F File Offset: 0x0060B99F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C104 RID: 180484 RVA: 0x0060D7B8 File Offset: 0x0060B9B8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C105 RID: 180485 RVA: 0x0060D7C3 File Offset: 0x0060B9C3
		public static Offset<IClearEntityVisibleTag> EndIClearEntityVisibleTag(FlatBufferBuilder builder)
		{
			return new Offset<IClearEntityVisibleTag>(builder.EndTable());
		}

		// Token: 0x0602C106 RID: 180486 RVA: 0x0060D7D0 File Offset: 0x0060B9D0
		public IClearEntityVisibleTagT UnPack()
		{
			IClearEntityVisibleTagT clearEntityVisibleTagT = new IClearEntityVisibleTagT();
			this.UnPackTo(clearEntityVisibleTagT);
			return clearEntityVisibleTagT;
		}

		// Token: 0x0602C107 RID: 180487 RVA: 0x0060D7EC File Offset: 0x0060B9EC
		public void UnPackTo(IClearEntityVisibleTagT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0602C108 RID: 180488 RVA: 0x0060D828 File Offset: 0x0060BA28
		public static Offset<IClearEntityVisibleTag> Pack(FlatBufferBuilder builder, IClearEntityVisibleTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClearEntityVisibleTag>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IClearEntityVisibleTag.CreateEntityIdsVector(builder, data);
			}
			return IClearEntityVisibleTag.CreateIClearEntityVisibleTag(builder, entityIdsOffset);
		}

		// Token: 0x0401094E RID: 67918
		private Table __p;
	}
}
