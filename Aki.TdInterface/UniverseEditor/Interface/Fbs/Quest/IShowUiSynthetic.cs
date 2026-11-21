using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200456E RID: 17774
	public struct IShowUiSynthetic : IFlatbufferObject
	{
		// Token: 0x17007C39 RID: 31801
		// (get) Token: 0x06019DFB RID: 105979 RVA: 0x003B0F10 File Offset: 0x003AF110
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019DFC RID: 105980 RVA: 0x003B0F1D File Offset: 0x003AF11D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019DFD RID: 105981 RVA: 0x003B0F24 File Offset: 0x003AF124
		public static IShowUiSynthetic GetRootAsIShowUiSynthetic(ByteBuffer _bb)
		{
			return IShowUiSynthetic.GetRootAsIShowUiSynthetic(_bb, default(IShowUiSynthetic));
		}

		// Token: 0x06019DFE RID: 105982 RVA: 0x003B0F40 File Offset: 0x003AF140
		public static IShowUiSynthetic GetRootAsIShowUiSynthetic(ByteBuffer _bb, IShowUiSynthetic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019DFF RID: 105983 RVA: 0x003B0F5D File Offset: 0x003AF15D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019E00 RID: 105984 RVA: 0x003B0F6C File Offset: 0x003AF16C
		public IShowUiSynthetic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C3A RID: 31802
		// (get) Token: 0x06019E01 RID: 105985 RVA: 0x003B0F7C File Offset: 0x003AF17C
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

		// Token: 0x06019E02 RID: 105986 RVA: 0x003B0FB8 File Offset: 0x003AF1B8
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C3B RID: 31803
		// (get) Token: 0x06019E03 RID: 105987 RVA: 0x003B0FF8 File Offset: 0x003AF1F8
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

		// Token: 0x06019E04 RID: 105988 RVA: 0x003B1023 File Offset: 0x003AF223
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06019E05 RID: 105989 RVA: 0x003B1032 File Offset: 0x003AF232
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06019E06 RID: 105990 RVA: 0x003B1040 File Offset: 0x003AF240
		public int ProductIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C3C RID: 31804
		// (get) Token: 0x06019E07 RID: 105991 RVA: 0x003B1080 File Offset: 0x003AF280
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

		// Token: 0x06019E08 RID: 105992 RVA: 0x003B10AB File Offset: 0x003AF2AB
		public Span<int> GetProductIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06019E09 RID: 105993 RVA: 0x003B10BA File Offset: 0x003AF2BA
		public int[] GetProductIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17007C3D RID: 31805
		// (get) Token: 0x06019E0A RID: 105994 RVA: 0x003B10C8 File Offset: 0x003AF2C8
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

		// Token: 0x06019E0B RID: 105995 RVA: 0x003B1105 File Offset: 0x003AF305
		public static Offset<IShowUiSynthetic> CreateIShowUiSynthetic(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset ProductIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IShowUiSynthetic.AddProductIds(builder, ProductIdsOffset);
			IShowUiSynthetic.AddEntityIds(builder, EntityIdsOffset);
			IShowUiSynthetic.AddNullMask(builder, NullMask);
			IShowUiSynthetic.AddType(builder, Type);
			return IShowUiSynthetic.EndIShowUiSynthetic(builder);
		}

		// Token: 0x06019E0C RID: 105996 RVA: 0x003B1131 File Offset: 0x003AF331
		public static void StartIShowUiSynthetic(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019E0D RID: 105997 RVA: 0x003B113A File Offset: 0x003AF33A
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019E0E RID: 105998 RVA: 0x003B1145 File Offset: 0x003AF345
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06019E0F RID: 105999 RVA: 0x003B1158 File Offset: 0x003AF358
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019E10 RID: 106000 RVA: 0x003B118F File Offset: 0x003AF38F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019E11 RID: 106001 RVA: 0x003B11A9 File Offset: 0x003AF3A9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019E12 RID: 106002 RVA: 0x003B11C7 File Offset: 0x003AF3C7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019E13 RID: 106003 RVA: 0x003B11E0 File Offset: 0x003AF3E0
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019E14 RID: 106004 RVA: 0x003B11EB File Offset: 0x003AF3EB
		public static void AddProductIds(FlatBufferBuilder builder, VectorOffset productIdsOffset)
		{
			builder.AddOffset(2, productIdsOffset.Value, 0);
		}

		// Token: 0x06019E15 RID: 106005 RVA: 0x003B11FC File Offset: 0x003AF3FC
		public static VectorOffset CreateProductIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019E16 RID: 106006 RVA: 0x003B1233 File Offset: 0x003AF433
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019E17 RID: 106007 RVA: 0x003B124D File Offset: 0x003AF44D
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019E18 RID: 106008 RVA: 0x003B126B File Offset: 0x003AF46B
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019E19 RID: 106009 RVA: 0x003B1284 File Offset: 0x003AF484
		public static void StartProductIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019E1A RID: 106010 RVA: 0x003B128F File Offset: 0x003AF48F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06019E1B RID: 106011 RVA: 0x003B129A File Offset: 0x003AF49A
		public static Offset<IShowUiSynthetic> EndIShowUiSynthetic(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiSynthetic>(builder.EndTable());
		}

		// Token: 0x06019E1C RID: 106012 RVA: 0x003B12A8 File Offset: 0x003AF4A8
		public IShowUiSyntheticT UnPack()
		{
			IShowUiSyntheticT showUiSyntheticT = new IShowUiSyntheticT();
			this.UnPackTo(showUiSyntheticT);
			return showUiSyntheticT;
		}

		// Token: 0x06019E1D RID: 106013 RVA: 0x003B12C4 File Offset: 0x003AF4C4
		public void UnPackTo(IShowUiSyntheticT _o)
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

		// Token: 0x06019E1E RID: 106014 RVA: 0x003B1348 File Offset: 0x003AF548
		public static Offset<IShowUiSynthetic> Pack(FlatBufferBuilder builder, IShowUiSyntheticT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowUiSynthetic>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IShowUiSynthetic.CreateEntityIdsVector(builder, data);
			}
			VectorOffset productIdsOffset = default(VectorOffset);
			if (_o.ProductIds != null)
			{
				int[] data2 = _o.ProductIds.ToArray();
				productIdsOffset = IShowUiSynthetic.CreateProductIdsVector(builder, data2);
			}
			return IShowUiSynthetic.CreateIShowUiSynthetic(builder, _o.Type, entityIdsOffset, productIdsOffset, _o.NullMask);
		}

		// Token: 0x0400C708 RID: 50952
		private Table __p;
	}
}
