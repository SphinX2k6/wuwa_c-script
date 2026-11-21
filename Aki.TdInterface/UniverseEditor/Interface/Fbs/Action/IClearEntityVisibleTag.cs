using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F3 RID: 27123
	public struct IClearEntityVisibleTag : IFlatbufferObject
	{
		// Token: 0x1700C778 RID: 51064
		// (get) Token: 0x0602E85D RID: 190557 RVA: 0x0065875E File Offset: 0x0065695E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E85E RID: 190558 RVA: 0x0065876B File Offset: 0x0065696B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E85F RID: 190559 RVA: 0x00658774 File Offset: 0x00656974
		public static IClearEntityVisibleTag GetRootAsIClearEntityVisibleTag(ByteBuffer _bb)
		{
			return IClearEntityVisibleTag.GetRootAsIClearEntityVisibleTag(_bb, default(IClearEntityVisibleTag));
		}

		// Token: 0x0602E860 RID: 190560 RVA: 0x00658790 File Offset: 0x00656990
		public static IClearEntityVisibleTag GetRootAsIClearEntityVisibleTag(ByteBuffer _bb, IClearEntityVisibleTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E861 RID: 190561 RVA: 0x006587AD File Offset: 0x006569AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E862 RID: 190562 RVA: 0x006587BC File Offset: 0x006569BC
		public IClearEntityVisibleTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E863 RID: 190563 RVA: 0x006587CC File Offset: 0x006569CC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C779 RID: 51065
		// (get) Token: 0x0602E864 RID: 190564 RVA: 0x0065880C File Offset: 0x00656A0C
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

		// Token: 0x0602E865 RID: 190565 RVA: 0x00658837 File Offset: 0x00656A37
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602E866 RID: 190566 RVA: 0x00658846 File Offset: 0x00656A46
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602E867 RID: 190567 RVA: 0x00658854 File Offset: 0x00656A54
		public static Offset<IClearEntityVisibleTag> CreateIClearEntityVisibleTag(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IClearEntityVisibleTag.AddEntityIds(builder, EntityIdsOffset);
			return IClearEntityVisibleTag.EndIClearEntityVisibleTag(builder);
		}

		// Token: 0x0602E868 RID: 190568 RVA: 0x0065886A File Offset: 0x00656A6A
		public static void StartIClearEntityVisibleTag(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E869 RID: 190569 RVA: 0x00658873 File Offset: 0x00656A73
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602E86A RID: 190570 RVA: 0x00658884 File Offset: 0x00656A84
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E86B RID: 190571 RVA: 0x006588BB File Offset: 0x00656ABB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E86C RID: 190572 RVA: 0x006588D5 File Offset: 0x00656AD5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E86D RID: 190573 RVA: 0x006588F3 File Offset: 0x00656AF3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E86E RID: 190574 RVA: 0x0065890C File Offset: 0x00656B0C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E86F RID: 190575 RVA: 0x00658917 File Offset: 0x00656B17
		public static Offset<IClearEntityVisibleTag> EndIClearEntityVisibleTag(FlatBufferBuilder builder)
		{
			return new Offset<IClearEntityVisibleTag>(builder.EndTable());
		}

		// Token: 0x0602E870 RID: 190576 RVA: 0x00658924 File Offset: 0x00656B24
		public IClearEntityVisibleTagT UnPack()
		{
			IClearEntityVisibleTagT clearEntityVisibleTagT = new IClearEntityVisibleTagT();
			this.UnPackTo(clearEntityVisibleTagT);
			return clearEntityVisibleTagT;
		}

		// Token: 0x0602E871 RID: 190577 RVA: 0x00658940 File Offset: 0x00656B40
		public void UnPackTo(IClearEntityVisibleTagT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0602E872 RID: 190578 RVA: 0x0065897C File Offset: 0x00656B7C
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

		// Token: 0x04011763 RID: 71523
		private Table __p;
	}
}
