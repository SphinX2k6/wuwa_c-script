using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB0 RID: 28592
	public struct IHideSpecifyDataLayers : IFlatbufferObject
	{
		// Token: 0x1700D164 RID: 53604
		// (get) Token: 0x060317FF RID: 202751 RVA: 0x006B58D2 File Offset: 0x006B3AD2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031800 RID: 202752 RVA: 0x006B58DF File Offset: 0x006B3ADF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031801 RID: 202753 RVA: 0x006B58E8 File Offset: 0x006B3AE8
		public static IHideSpecifyDataLayers GetRootAsIHideSpecifyDataLayers(ByteBuffer _bb)
		{
			return IHideSpecifyDataLayers.GetRootAsIHideSpecifyDataLayers(_bb, default(IHideSpecifyDataLayers));
		}

		// Token: 0x06031802 RID: 202754 RVA: 0x006B5904 File Offset: 0x006B3B04
		public static IHideSpecifyDataLayers GetRootAsIHideSpecifyDataLayers(ByteBuffer _bb, IHideSpecifyDataLayers obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031803 RID: 202755 RVA: 0x006B5921 File Offset: 0x006B3B21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031804 RID: 202756 RVA: 0x006B5930 File Offset: 0x006B3B30
		public IHideSpecifyDataLayers __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D165 RID: 53605
		// (get) Token: 0x06031805 RID: 202757 RVA: 0x006B5940 File Offset: 0x006B3B40
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031806 RID: 202758 RVA: 0x006B597C File Offset: 0x006B3B7C
		public int DataLayers(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D166 RID: 53606
		// (get) Token: 0x06031807 RID: 202759 RVA: 0x006B59BC File Offset: 0x006B3BBC
		public int DataLayersLength
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

		// Token: 0x06031808 RID: 202760 RVA: 0x006B59E7 File Offset: 0x006B3BE7
		public Span<int> GetDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06031809 RID: 202761 RVA: 0x006B59F6 File Offset: 0x006B3BF6
		public int[] GetDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0603180A RID: 202762 RVA: 0x006B5A04 File Offset: 0x006B3C04
		public static Offset<IHideSpecifyDataLayers> CreateIHideSpecifyDataLayers(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset DataLayersOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHideSpecifyDataLayers.AddDataLayers(builder, DataLayersOffset);
			IHideSpecifyDataLayers.AddType(builder, Type);
			return IHideSpecifyDataLayers.EndIHideSpecifyDataLayers(builder);
		}

		// Token: 0x0603180B RID: 202763 RVA: 0x006B5A21 File Offset: 0x006B3C21
		public static void StartIHideSpecifyDataLayers(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603180C RID: 202764 RVA: 0x006B5A2A File Offset: 0x006B3C2A
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603180D RID: 202765 RVA: 0x006B5A35 File Offset: 0x006B3C35
		public static void AddDataLayers(FlatBufferBuilder builder, VectorOffset dataLayersOffset)
		{
			builder.AddOffset(1, dataLayersOffset.Value, 0);
		}

		// Token: 0x0603180E RID: 202766 RVA: 0x006B5A48 File Offset: 0x006B3C48
		public static VectorOffset CreateDataLayersVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603180F RID: 202767 RVA: 0x006B5A7F File Offset: 0x006B3C7F
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031810 RID: 202768 RVA: 0x006B5A99 File Offset: 0x006B3C99
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031811 RID: 202769 RVA: 0x006B5AB7 File Offset: 0x006B3CB7
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031812 RID: 202770 RVA: 0x006B5AD0 File Offset: 0x006B3CD0
		public static void StartDataLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031813 RID: 202771 RVA: 0x006B5ADB File Offset: 0x006B3CDB
		public static Offset<IHideSpecifyDataLayers> EndIHideSpecifyDataLayers(FlatBufferBuilder builder)
		{
			return new Offset<IHideSpecifyDataLayers>(builder.EndTable());
		}

		// Token: 0x06031814 RID: 202772 RVA: 0x006B5AE8 File Offset: 0x006B3CE8
		public IHideSpecifyDataLayersT UnPack()
		{
			IHideSpecifyDataLayersT hideSpecifyDataLayersT = new IHideSpecifyDataLayersT();
			this.UnPackTo(hideSpecifyDataLayersT);
			return hideSpecifyDataLayersT;
		}

		// Token: 0x06031815 RID: 202773 RVA: 0x006B5B04 File Offset: 0x006B3D04
		public void UnPackTo(IHideSpecifyDataLayersT _o)
		{
			_o.Type = this.Type;
			_o.DataLayers = new List<int>();
			for (int i = 0; i < this.DataLayersLength; i++)
			{
				_o.DataLayers.Add(this.DataLayers(i));
			}
		}

		// Token: 0x06031816 RID: 202774 RVA: 0x006B5B4C File Offset: 0x006B3D4C
		public static Offset<IHideSpecifyDataLayers> Pack(FlatBufferBuilder builder, IHideSpecifyDataLayersT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideSpecifyDataLayers>);
			}
			VectorOffset dataLayersOffset = default(VectorOffset);
			if (_o.DataLayers != null)
			{
				int[] data = _o.DataLayers.ToArray();
				dataLayersOffset = IHideSpecifyDataLayers.CreateDataLayersVector(builder, data);
			}
			return IHideSpecifyDataLayers.CreateIHideSpecifyDataLayers(builder, _o.Type, dataLayersOffset);
		}

		// Token: 0x04011EDC RID: 73436
		private Table __p;
	}
}
