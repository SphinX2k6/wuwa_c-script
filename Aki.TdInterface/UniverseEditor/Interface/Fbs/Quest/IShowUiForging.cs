using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200412A RID: 16682
	public struct IShowUiForging : IFlatbufferObject
	{
		// Token: 0x1700762A RID: 30250
		// (get) Token: 0x0601872A RID: 100138 RVA: 0x00386998 File Offset: 0x00384B98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601872B RID: 100139 RVA: 0x003869A5 File Offset: 0x00384BA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601872C RID: 100140 RVA: 0x003869AC File Offset: 0x00384BAC
		public static IShowUiForging GetRootAsIShowUiForging(ByteBuffer _bb)
		{
			return IShowUiForging.GetRootAsIShowUiForging(_bb, default(IShowUiForging));
		}

		// Token: 0x0601872D RID: 100141 RVA: 0x003869C8 File Offset: 0x00384BC8
		public static IShowUiForging GetRootAsIShowUiForging(ByteBuffer _bb, IShowUiForging obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601872E RID: 100142 RVA: 0x003869E5 File Offset: 0x00384BE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601872F RID: 100143 RVA: 0x003869F4 File Offset: 0x00384BF4
		public IShowUiForging __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700762B RID: 30251
		// (get) Token: 0x06018730 RID: 100144 RVA: 0x00386A04 File Offset: 0x00384C04
		public EShowUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowUiType.All;
				}
				return (EShowUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018731 RID: 100145 RVA: 0x00386A40 File Offset: 0x00384C40
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700762C RID: 30252
		// (get) Token: 0x06018732 RID: 100146 RVA: 0x00386A80 File Offset: 0x00384C80
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

		// Token: 0x06018733 RID: 100147 RVA: 0x00386AAB File Offset: 0x00384CAB
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06018734 RID: 100148 RVA: 0x00386ABA File Offset: 0x00384CBA
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06018735 RID: 100149 RVA: 0x00386AC8 File Offset: 0x00384CC8
		public int ProductIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700762D RID: 30253
		// (get) Token: 0x06018736 RID: 100150 RVA: 0x00386B08 File Offset: 0x00384D08
		public int ProductIdsLength
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

		// Token: 0x06018737 RID: 100151 RVA: 0x00386B33 File Offset: 0x00384D33
		public Span<int> GetProductIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06018738 RID: 100152 RVA: 0x00386B42 File Offset: 0x00384D42
		public int[] GetProductIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700762E RID: 30254
		// (get) Token: 0x06018739 RID: 100153 RVA: 0x00386B50 File Offset: 0x00384D50
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601873A RID: 100154 RVA: 0x00386B8D File Offset: 0x00384D8D
		public static Offset<IShowUiForging> CreateIShowUiForging(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset ProductIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IShowUiForging.AddProductIds(builder, ProductIdsOffset);
			IShowUiForging.AddEntityIds(builder, EntityIdsOffset);
			IShowUiForging.AddNullMask(builder, NullMask);
			IShowUiForging.AddType(builder, Type);
			return IShowUiForging.EndIShowUiForging(builder);
		}

		// Token: 0x0601873B RID: 100155 RVA: 0x00386BB9 File Offset: 0x00384DB9
		public static void StartIShowUiForging(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601873C RID: 100156 RVA: 0x00386BC2 File Offset: 0x00384DC2
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601873D RID: 100157 RVA: 0x00386BCD File Offset: 0x00384DCD
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601873E RID: 100158 RVA: 0x00386BE0 File Offset: 0x00384DE0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601873F RID: 100159 RVA: 0x00386C17 File Offset: 0x00384E17
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018740 RID: 100160 RVA: 0x00386C31 File Offset: 0x00384E31
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018741 RID: 100161 RVA: 0x00386C4F File Offset: 0x00384E4F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018742 RID: 100162 RVA: 0x00386C68 File Offset: 0x00384E68
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018743 RID: 100163 RVA: 0x00386C73 File Offset: 0x00384E73
		public static void AddProductIds(FlatBufferBuilder builder, VectorOffset productIdsOffset)
		{
			builder.AddOffset(2, productIdsOffset.Value, 0);
		}

		// Token: 0x06018744 RID: 100164 RVA: 0x00386C84 File Offset: 0x00384E84
		public static VectorOffset CreateProductIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018745 RID: 100165 RVA: 0x00386CBB File Offset: 0x00384EBB
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018746 RID: 100166 RVA: 0x00386CD5 File Offset: 0x00384ED5
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018747 RID: 100167 RVA: 0x00386CF3 File Offset: 0x00384EF3
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018748 RID: 100168 RVA: 0x00386D0C File Offset: 0x00384F0C
		public static void StartProductIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018749 RID: 100169 RVA: 0x00386D17 File Offset: 0x00384F17
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601874A RID: 100170 RVA: 0x00386D22 File Offset: 0x00384F22
		public static Offset<IShowUiForging> EndIShowUiForging(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiForging>(builder.EndTable());
		}

		// Token: 0x0601874B RID: 100171 RVA: 0x00386D30 File Offset: 0x00384F30
		public IShowUiForgingT UnPack()
		{
			IShowUiForgingT showUiForgingT = new IShowUiForgingT();
			this.UnPackTo(showUiForgingT);
			return showUiForgingT;
		}

		// Token: 0x0601874C RID: 100172 RVA: 0x00386D4C File Offset: 0x00384F4C
		public void UnPackTo(IShowUiForgingT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.ProductIds = new List<int>();
			for (int j = 0; j < this.ProductIdsLength; j++)
			{
				_o.ProductIds.Add(this.ProductIds(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601874D RID: 100173 RVA: 0x00386DD0 File Offset: 0x00384FD0
		public static Offset<IShowUiForging> Pack(FlatBufferBuilder builder, IShowUiForgingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowUiForging>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IShowUiForging.CreateEntityIdsVector(builder, data);
			}
			VectorOffset productIdsOffset = default(VectorOffset);
			if (_o.ProductIds != null)
			{
				int[] data2 = _o.ProductIds.ToArray();
				productIdsOffset = IShowUiForging.CreateProductIdsVector(builder, data2);
			}
			return IShowUiForging.CreateIShowUiForging(builder, _o.Type, entityIdsOffset, productIdsOffset, _o.NullMask);
		}

		// Token: 0x0400BD1A RID: 48410
		private Table __p;
	}
}
