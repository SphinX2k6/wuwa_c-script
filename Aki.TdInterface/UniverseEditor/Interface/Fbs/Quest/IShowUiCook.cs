using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004124 RID: 16676
	public struct IShowUiCook : IFlatbufferObject
	{
		// Token: 0x17007618 RID: 30232
		// (get) Token: 0x060186CE RID: 100046 RVA: 0x00385EB5 File Offset: 0x003840B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060186CF RID: 100047 RVA: 0x00385EC2 File Offset: 0x003840C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060186D0 RID: 100048 RVA: 0x00385ECC File Offset: 0x003840CC
		public static IShowUiCook GetRootAsIShowUiCook(ByteBuffer _bb)
		{
			return IShowUiCook.GetRootAsIShowUiCook(_bb, default(IShowUiCook));
		}

		// Token: 0x060186D1 RID: 100049 RVA: 0x00385EE8 File Offset: 0x003840E8
		public static IShowUiCook GetRootAsIShowUiCook(ByteBuffer _bb, IShowUiCook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060186D2 RID: 100050 RVA: 0x00385F05 File Offset: 0x00384105
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060186D3 RID: 100051 RVA: 0x00385F14 File Offset: 0x00384114
		public IShowUiCook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007619 RID: 30233
		// (get) Token: 0x060186D4 RID: 100052 RVA: 0x00385F24 File Offset: 0x00384124
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

		// Token: 0x060186D5 RID: 100053 RVA: 0x00385F60 File Offset: 0x00384160
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700761A RID: 30234
		// (get) Token: 0x060186D6 RID: 100054 RVA: 0x00385FA0 File Offset: 0x003841A0
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

		// Token: 0x060186D7 RID: 100055 RVA: 0x00385FCB File Offset: 0x003841CB
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060186D8 RID: 100056 RVA: 0x00385FDA File Offset: 0x003841DA
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060186D9 RID: 100057 RVA: 0x00385FE8 File Offset: 0x003841E8
		public int ProductIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700761B RID: 30235
		// (get) Token: 0x060186DA RID: 100058 RVA: 0x00386028 File Offset: 0x00384228
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

		// Token: 0x060186DB RID: 100059 RVA: 0x00386053 File Offset: 0x00384253
		public Span<int> GetProductIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060186DC RID: 100060 RVA: 0x00386062 File Offset: 0x00384262
		public int[] GetProductIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700761C RID: 30236
		// (get) Token: 0x060186DD RID: 100061 RVA: 0x00386070 File Offset: 0x00384270
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

		// Token: 0x060186DE RID: 100062 RVA: 0x003860AD File Offset: 0x003842AD
		public static Offset<IShowUiCook> CreateIShowUiCook(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset ProductIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IShowUiCook.AddProductIds(builder, ProductIdsOffset);
			IShowUiCook.AddEntityIds(builder, EntityIdsOffset);
			IShowUiCook.AddNullMask(builder, NullMask);
			IShowUiCook.AddType(builder, Type);
			return IShowUiCook.EndIShowUiCook(builder);
		}

		// Token: 0x060186DF RID: 100063 RVA: 0x003860D9 File Offset: 0x003842D9
		public static void StartIShowUiCook(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060186E0 RID: 100064 RVA: 0x003860E2 File Offset: 0x003842E2
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060186E1 RID: 100065 RVA: 0x003860ED File Offset: 0x003842ED
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x060186E2 RID: 100066 RVA: 0x00386100 File Offset: 0x00384300
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060186E3 RID: 100067 RVA: 0x00386137 File Offset: 0x00384337
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060186E4 RID: 100068 RVA: 0x00386151 File Offset: 0x00384351
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060186E5 RID: 100069 RVA: 0x0038616F File Offset: 0x0038436F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060186E6 RID: 100070 RVA: 0x00386188 File Offset: 0x00384388
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060186E7 RID: 100071 RVA: 0x00386193 File Offset: 0x00384393
		public static void AddProductIds(FlatBufferBuilder builder, VectorOffset productIdsOffset)
		{
			builder.AddOffset(2, productIdsOffset.Value, 0);
		}

		// Token: 0x060186E8 RID: 100072 RVA: 0x003861A4 File Offset: 0x003843A4
		public static VectorOffset CreateProductIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060186E9 RID: 100073 RVA: 0x003861DB File Offset: 0x003843DB
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060186EA RID: 100074 RVA: 0x003861F5 File Offset: 0x003843F5
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060186EB RID: 100075 RVA: 0x00386213 File Offset: 0x00384413
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060186EC RID: 100076 RVA: 0x0038622C File Offset: 0x0038442C
		public static void StartProductIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060186ED RID: 100077 RVA: 0x00386237 File Offset: 0x00384437
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060186EE RID: 100078 RVA: 0x00386242 File Offset: 0x00384442
		public static Offset<IShowUiCook> EndIShowUiCook(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiCook>(builder.EndTable());
		}

		// Token: 0x060186EF RID: 100079 RVA: 0x00386250 File Offset: 0x00384450
		public IShowUiCookT UnPack()
		{
			IShowUiCookT showUiCookT = new IShowUiCookT();
			this.UnPackTo(showUiCookT);
			return showUiCookT;
		}

		// Token: 0x060186F0 RID: 100080 RVA: 0x0038626C File Offset: 0x0038446C
		public void UnPackTo(IShowUiCookT _o)
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

		// Token: 0x060186F1 RID: 100081 RVA: 0x003862F0 File Offset: 0x003844F0
		public static Offset<IShowUiCook> Pack(FlatBufferBuilder builder, IShowUiCookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowUiCook>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IShowUiCook.CreateEntityIdsVector(builder, data);
			}
			VectorOffset productIdsOffset = default(VectorOffset);
			if (_o.ProductIds != null)
			{
				int[] data2 = _o.ProductIds.ToArray();
				productIdsOffset = IShowUiCook.CreateProductIdsVector(builder, data2);
			}
			return IShowUiCook.CreateIShowUiCook(builder, _o.Type, entityIdsOffset, productIdsOffset, _o.NullMask);
		}

		// Token: 0x0400BD10 RID: 48400
		private Table __p;
	}
}
