using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E8D RID: 16013
	public struct IHandInItemRange : IFlatbufferObject
	{
		// Token: 0x17006F1C RID: 28444
		// (get) Token: 0x0601695C RID: 92508 RVA: 0x003434B0 File Offset: 0x003416B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601695D RID: 92509 RVA: 0x003434BD File Offset: 0x003416BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601695E RID: 92510 RVA: 0x003434C4 File Offset: 0x003416C4
		public static IHandInItemRange GetRootAsIHandInItemRange(ByteBuffer _bb)
		{
			return IHandInItemRange.GetRootAsIHandInItemRange(_bb, default(IHandInItemRange));
		}

		// Token: 0x0601695F RID: 92511 RVA: 0x003434E0 File Offset: 0x003416E0
		public static IHandInItemRange GetRootAsIHandInItemRange(ByteBuffer _bb, IHandInItemRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016960 RID: 92512 RVA: 0x003434FD File Offset: 0x003416FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016961 RID: 92513 RVA: 0x0034350C File Offset: 0x0034170C
		public IHandInItemRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F1D RID: 28445
		// (get) Token: 0x06016962 RID: 92514 RVA: 0x0034351C File Offset: 0x0034171C
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

		// Token: 0x06016963 RID: 92515 RVA: 0x00343558 File Offset: 0x00341758
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006F1E RID: 28446
		// (get) Token: 0x06016964 RID: 92516 RVA: 0x00343598 File Offset: 0x00341798
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

		// Token: 0x06016965 RID: 92517 RVA: 0x003435C3 File Offset: 0x003417C3
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06016966 RID: 92518 RVA: 0x003435D2 File Offset: 0x003417D2
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06016967 RID: 92519 RVA: 0x003435E0 File Offset: 0x003417E0
		public static Offset<IHandInItemRange> CreateIHandInItemRange(FlatBufferBuilder builder, EHandInItemType HandInType = EHandInItemType.ItemIds, VectorOffset ItemIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHandInItemRange.AddItemIds(builder, ItemIdsOffset);
			IHandInItemRange.AddHandInType(builder, HandInType);
			return IHandInItemRange.EndIHandInItemRange(builder);
		}

		// Token: 0x06016968 RID: 92520 RVA: 0x003435FD File Offset: 0x003417FD
		public static void StartIHandInItemRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016969 RID: 92521 RVA: 0x00343606 File Offset: 0x00341806
		public static void AddHandInType(FlatBufferBuilder builder, EHandInItemType handInType)
		{
			builder.AddByte(0, (byte)handInType, 0);
		}

		// Token: 0x0601696A RID: 92522 RVA: 0x00343611 File Offset: 0x00341811
		public static void AddItemIds(FlatBufferBuilder builder, VectorOffset itemIdsOffset)
		{
			builder.AddOffset(1, itemIdsOffset.Value, 0);
		}

		// Token: 0x0601696B RID: 92523 RVA: 0x00343624 File Offset: 0x00341824
		public static VectorOffset CreateItemIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601696C RID: 92524 RVA: 0x0034365B File Offset: 0x0034185B
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601696D RID: 92525 RVA: 0x00343675 File Offset: 0x00341875
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601696E RID: 92526 RVA: 0x00343693 File Offset: 0x00341893
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601696F RID: 92527 RVA: 0x003436AC File Offset: 0x003418AC
		public static void StartItemIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016970 RID: 92528 RVA: 0x003436B7 File Offset: 0x003418B7
		public static Offset<IHandInItemRange> EndIHandInItemRange(FlatBufferBuilder builder)
		{
			return new Offset<IHandInItemRange>(builder.EndTable());
		}

		// Token: 0x06016971 RID: 92529 RVA: 0x003436C4 File Offset: 0x003418C4
		public IHandInItemRangeT UnPack()
		{
			IHandInItemRangeT handInItemRangeT = new IHandInItemRangeT();
			this.UnPackTo(handInItemRangeT);
			return handInItemRangeT;
		}

		// Token: 0x06016972 RID: 92530 RVA: 0x003436E0 File Offset: 0x003418E0
		public void UnPackTo(IHandInItemRangeT _o)
		{
			_o.HandInType = this.HandInType;
			_o.ItemIds = new List<int>();
			for (int i = 0; i < this.ItemIdsLength; i++)
			{
				_o.ItemIds.Add(this.ItemIds(i));
			}
		}

		// Token: 0x06016973 RID: 92531 RVA: 0x00343728 File Offset: 0x00341928
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

		// Token: 0x0400B84D RID: 47181
		private Table __p;
	}
}
