using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C8 RID: 17096
	public struct IHandInItemRange : IFlatbufferObject
	{
		// Token: 0x17007504 RID: 29956
		// (get) Token: 0x06017F93 RID: 98195 RVA: 0x0036C234 File Offset: 0x0036A434
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017F94 RID: 98196 RVA: 0x0036C241 File Offset: 0x0036A441
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017F95 RID: 98197 RVA: 0x0036C248 File Offset: 0x0036A448
		public static IHandInItemRange GetRootAsIHandInItemRange(ByteBuffer _bb)
		{
			return IHandInItemRange.GetRootAsIHandInItemRange(_bb, default(IHandInItemRange));
		}

		// Token: 0x06017F96 RID: 98198 RVA: 0x0036C264 File Offset: 0x0036A464
		public static IHandInItemRange GetRootAsIHandInItemRange(ByteBuffer _bb, IHandInItemRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017F97 RID: 98199 RVA: 0x0036C281 File Offset: 0x0036A481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017F98 RID: 98200 RVA: 0x0036C290 File Offset: 0x0036A490
		public IHandInItemRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007505 RID: 29957
		// (get) Token: 0x06017F99 RID: 98201 RVA: 0x0036C2A0 File Offset: 0x0036A4A0
		public EHandInItemType HandInType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHandInItemType.ItemIds;
				}
				return (EHandInItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017F9A RID: 98202 RVA: 0x0036C2DC File Offset: 0x0036A4DC
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007506 RID: 29958
		// (get) Token: 0x06017F9B RID: 98203 RVA: 0x0036C31C File Offset: 0x0036A51C
		public int ItemIdsLength
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

		// Token: 0x06017F9C RID: 98204 RVA: 0x0036C347 File Offset: 0x0036A547
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06017F9D RID: 98205 RVA: 0x0036C356 File Offset: 0x0036A556
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06017F9E RID: 98206 RVA: 0x0036C364 File Offset: 0x0036A564
		public static Offset<IHandInItemRange> CreateIHandInItemRange(FlatBufferBuilder builder, EHandInItemType HandInType = EHandInItemType.ItemIds, VectorOffset ItemIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHandInItemRange.AddItemIds(builder, ItemIdsOffset);
			IHandInItemRange.AddHandInType(builder, HandInType);
			return IHandInItemRange.EndIHandInItemRange(builder);
		}

		// Token: 0x06017F9F RID: 98207 RVA: 0x0036C381 File Offset: 0x0036A581
		public static void StartIHandInItemRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017FA0 RID: 98208 RVA: 0x0036C38A File Offset: 0x0036A58A
		public static void AddHandInType(FlatBufferBuilder builder, EHandInItemType handInType)
		{
			builder.AddByte(0, (byte)handInType, 0);
		}

		// Token: 0x06017FA1 RID: 98209 RVA: 0x0036C395 File Offset: 0x0036A595
		public static void AddItemIds(FlatBufferBuilder builder, VectorOffset itemIdsOffset)
		{
			builder.AddOffset(1, itemIdsOffset.Value, 0);
		}

		// Token: 0x06017FA2 RID: 98210 RVA: 0x0036C3A8 File Offset: 0x0036A5A8
		public static VectorOffset CreateItemIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017FA3 RID: 98211 RVA: 0x0036C3DF File Offset: 0x0036A5DF
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017FA4 RID: 98212 RVA: 0x0036C3F9 File Offset: 0x0036A5F9
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017FA5 RID: 98213 RVA: 0x0036C417 File Offset: 0x0036A617
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017FA6 RID: 98214 RVA: 0x0036C430 File Offset: 0x0036A630
		public static void StartItemIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017FA7 RID: 98215 RVA: 0x0036C43B File Offset: 0x0036A63B
		public static Offset<IHandInItemRange> EndIHandInItemRange(FlatBufferBuilder builder)
		{
			return new Offset<IHandInItemRange>(builder.EndTable());
		}

		// Token: 0x06017FA8 RID: 98216 RVA: 0x0036C448 File Offset: 0x0036A648
		public IHandInItemRangeT UnPack()
		{
			IHandInItemRangeT handInItemRangeT = new IHandInItemRangeT();
			this.UnPackTo(handInItemRangeT);
			return handInItemRangeT;
		}

		// Token: 0x06017FA9 RID: 98217 RVA: 0x0036C464 File Offset: 0x0036A664
		public void UnPackTo(IHandInItemRangeT _o)
		{
			_o.HandInType = this.HandInType;
			_o.ItemIds = new List<int>();
			for (int i = 0; i < this.ItemIdsLength; i++)
			{
				_o.ItemIds.Add(this.ItemIds(i));
			}
		}

		// Token: 0x06017FAA RID: 98218 RVA: 0x0036C4AC File Offset: 0x0036A6AC
		public static Offset<IHandInItemRange> Pack(FlatBufferBuilder builder, IHandInItemRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandInItemRange>);
			}
			VectorOffset itemIdsOffset = default(VectorOffset);
			if (_o.ItemIds != null)
			{
				int[] data = _o.ItemIds.ToArray();
				itemIdsOffset = IHandInItemRange.CreateItemIdsVector(builder, data);
			}
			return IHandInItemRange.CreateIHandInItemRange(builder, _o.HandInType, itemIdsOffset);
		}

		// Token: 0x0400C226 RID: 49702
		private Table __p;
	}
}
