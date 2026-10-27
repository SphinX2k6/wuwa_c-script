using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200412D RID: 16685
	public struct IShowUiSynthetic : IFlatbufferObject
	{
		// Token: 0x17007633 RID: 30259
		// (get) Token: 0x06018758 RID: 100184 RVA: 0x00386F08 File Offset: 0x00385108
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018759 RID: 100185 RVA: 0x00386F15 File Offset: 0x00385115
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601875A RID: 100186 RVA: 0x00386F1C File Offset: 0x0038511C
		public static IShowUiSynthetic GetRootAsIShowUiSynthetic(ByteBuffer _bb)
		{
			return IShowUiSynthetic.GetRootAsIShowUiSynthetic(_bb, default(IShowUiSynthetic));
		}

		// Token: 0x0601875B RID: 100187 RVA: 0x00386F38 File Offset: 0x00385138
		public static IShowUiSynthetic GetRootAsIShowUiSynthetic(ByteBuffer _bb, IShowUiSynthetic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601875C RID: 100188 RVA: 0x00386F55 File Offset: 0x00385155
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601875D RID: 100189 RVA: 0x00386F64 File Offset: 0x00385164
		public IShowUiSynthetic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007634 RID: 30260
		// (get) Token: 0x0601875E RID: 100190 RVA: 0x00386F74 File Offset: 0x00385174
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

		// Token: 0x0601875F RID: 100191 RVA: 0x00386FB0 File Offset: 0x003851B0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007635 RID: 30261
		// (get) Token: 0x06018760 RID: 100192 RVA: 0x00386FF0 File Offset: 0x003851F0
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

		// Token: 0x06018761 RID: 100193 RVA: 0x0038701B File Offset: 0x0038521B
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06018762 RID: 100194 RVA: 0x0038702A File Offset: 0x0038522A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06018763 RID: 100195 RVA: 0x00387038 File Offset: 0x00385238
		public int ProductIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007636 RID: 30262
		// (get) Token: 0x06018764 RID: 100196 RVA: 0x00387078 File Offset: 0x00385278
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

		// Token: 0x06018765 RID: 100197 RVA: 0x003870A3 File Offset: 0x003852A3
		public Span<int> GetProductIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06018766 RID: 100198 RVA: 0x003870B2 File Offset: 0x003852B2
		public int[] GetProductIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17007637 RID: 30263
		// (get) Token: 0x06018767 RID: 100199 RVA: 0x003870C0 File Offset: 0x003852C0
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

		// Token: 0x06018768 RID: 100200 RVA: 0x003870FD File Offset: 0x003852FD
		public static Offset<IShowUiSynthetic> CreateIShowUiSynthetic(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset ProductIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IShowUiSynthetic.AddProductIds(builder, ProductIdsOffset);
			IShowUiSynthetic.AddEntityIds(builder, EntityIdsOffset);
			IShowUiSynthetic.AddNullMask(builder, NullMask);
			IShowUiSynthetic.AddType(builder, Type);
			return IShowUiSynthetic.EndIShowUiSynthetic(builder);
		}

		// Token: 0x06018769 RID: 100201 RVA: 0x00387129 File Offset: 0x00385329
		public static void StartIShowUiSynthetic(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601876A RID: 100202 RVA: 0x00387132 File Offset: 0x00385332
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601876B RID: 100203 RVA: 0x0038713D File Offset: 0x0038533D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601876C RID: 100204 RVA: 0x00387150 File Offset: 0x00385350
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601876D RID: 100205 RVA: 0x00387187 File Offset: 0x00385387
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601876E RID: 100206 RVA: 0x003871A1 File Offset: 0x003853A1
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601876F RID: 100207 RVA: 0x003871BF File Offset: 0x003853BF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018770 RID: 100208 RVA: 0x003871D8 File Offset: 0x003853D8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018771 RID: 100209 RVA: 0x003871E3 File Offset: 0x003853E3
		public static void AddProductIds(FlatBufferBuilder builder, VectorOffset productIdsOffset)
		{
			builder.AddOffset(2, productIdsOffset.Value, 0);
		}

		// Token: 0x06018772 RID: 100210 RVA: 0x003871F4 File Offset: 0x003853F4
		public static VectorOffset CreateProductIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018773 RID: 100211 RVA: 0x0038722B File Offset: 0x0038542B
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018774 RID: 100212 RVA: 0x00387245 File Offset: 0x00385445
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018775 RID: 100213 RVA: 0x00387263 File Offset: 0x00385463
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018776 RID: 100214 RVA: 0x0038727C File Offset: 0x0038547C
		public static void StartProductIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018777 RID: 100215 RVA: 0x00387287 File Offset: 0x00385487
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06018778 RID: 100216 RVA: 0x00387292 File Offset: 0x00385492
		public static Offset<IShowUiSynthetic> EndIShowUiSynthetic(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiSynthetic>(builder.EndTable());
		}

		// Token: 0x06018779 RID: 100217 RVA: 0x003872A0 File Offset: 0x003854A0
		public IShowUiSyntheticT UnPack()
		{
			IShowUiSyntheticT showUiSyntheticT = new IShowUiSyntheticT();
			this.UnPackTo(showUiSyntheticT);
			return showUiSyntheticT;
		}

		// Token: 0x0601877A RID: 100218 RVA: 0x003872BC File Offset: 0x003854BC
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

		// Token: 0x0601877B RID: 100219 RVA: 0x00387340 File Offset: 0x00385540
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

		// Token: 0x0400BD1F RID: 48415
		private Table __p;
	}
}
