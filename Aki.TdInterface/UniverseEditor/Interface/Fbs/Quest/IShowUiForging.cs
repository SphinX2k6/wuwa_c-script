using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200456B RID: 17771
	public struct IShowUiForging : IFlatbufferObject
	{
		// Token: 0x17007C30 RID: 31792
		// (get) Token: 0x06019DCD RID: 105933 RVA: 0x003B09A0 File Offset: 0x003AEBA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019DCE RID: 105934 RVA: 0x003B09AD File Offset: 0x003AEBAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019DCF RID: 105935 RVA: 0x003B09B4 File Offset: 0x003AEBB4
		public static IShowUiForging GetRootAsIShowUiForging(ByteBuffer _bb)
		{
			return IShowUiForging.GetRootAsIShowUiForging(_bb, default(IShowUiForging));
		}

		// Token: 0x06019DD0 RID: 105936 RVA: 0x003B09D0 File Offset: 0x003AEBD0
		public static IShowUiForging GetRootAsIShowUiForging(ByteBuffer _bb, IShowUiForging obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019DD1 RID: 105937 RVA: 0x003B09ED File Offset: 0x003AEBED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019DD2 RID: 105938 RVA: 0x003B09FC File Offset: 0x003AEBFC
		public IShowUiForging __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C31 RID: 31793
		// (get) Token: 0x06019DD3 RID: 105939 RVA: 0x003B0A0C File Offset: 0x003AEC0C
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

		// Token: 0x06019DD4 RID: 105940 RVA: 0x003B0A48 File Offset: 0x003AEC48
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C32 RID: 31794
		// (get) Token: 0x06019DD5 RID: 105941 RVA: 0x003B0A88 File Offset: 0x003AEC88
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

		// Token: 0x06019DD6 RID: 105942 RVA: 0x003B0AB3 File Offset: 0x003AECB3
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06019DD7 RID: 105943 RVA: 0x003B0AC2 File Offset: 0x003AECC2
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06019DD8 RID: 105944 RVA: 0x003B0AD0 File Offset: 0x003AECD0
		public int ProductIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C33 RID: 31795
		// (get) Token: 0x06019DD9 RID: 105945 RVA: 0x003B0B10 File Offset: 0x003AED10
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

		// Token: 0x06019DDA RID: 105946 RVA: 0x003B0B3B File Offset: 0x003AED3B
		public Span<int> GetProductIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06019DDB RID: 105947 RVA: 0x003B0B4A File Offset: 0x003AED4A
		public int[] GetProductIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17007C34 RID: 31796
		// (get) Token: 0x06019DDC RID: 105948 RVA: 0x003B0B58 File Offset: 0x003AED58
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

		// Token: 0x06019DDD RID: 105949 RVA: 0x003B0B95 File Offset: 0x003AED95
		public static Offset<IShowUiForging> CreateIShowUiForging(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset ProductIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IShowUiForging.AddProductIds(builder, ProductIdsOffset);
			IShowUiForging.AddEntityIds(builder, EntityIdsOffset);
			IShowUiForging.AddNullMask(builder, NullMask);
			IShowUiForging.AddType(builder, Type);
			return IShowUiForging.EndIShowUiForging(builder);
		}

		// Token: 0x06019DDE RID: 105950 RVA: 0x003B0BC1 File Offset: 0x003AEDC1
		public static void StartIShowUiForging(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019DDF RID: 105951 RVA: 0x003B0BCA File Offset: 0x003AEDCA
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019DE0 RID: 105952 RVA: 0x003B0BD5 File Offset: 0x003AEDD5
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06019DE1 RID: 105953 RVA: 0x003B0BE8 File Offset: 0x003AEDE8
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019DE2 RID: 105954 RVA: 0x003B0C1F File Offset: 0x003AEE1F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DE3 RID: 105955 RVA: 0x003B0C39 File Offset: 0x003AEE39
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DE4 RID: 105956 RVA: 0x003B0C57 File Offset: 0x003AEE57
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019DE5 RID: 105957 RVA: 0x003B0C70 File Offset: 0x003AEE70
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019DE6 RID: 105958 RVA: 0x003B0C7B File Offset: 0x003AEE7B
		public static void AddProductIds(FlatBufferBuilder builder, VectorOffset productIdsOffset)
		{
			builder.AddOffset(2, productIdsOffset.Value, 0);
		}

		// Token: 0x06019DE7 RID: 105959 RVA: 0x003B0C8C File Offset: 0x003AEE8C
		public static VectorOffset CreateProductIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019DE8 RID: 105960 RVA: 0x003B0CC3 File Offset: 0x003AEEC3
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DE9 RID: 105961 RVA: 0x003B0CDD File Offset: 0x003AEEDD
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DEA RID: 105962 RVA: 0x003B0CFB File Offset: 0x003AEEFB
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019DEB RID: 105963 RVA: 0x003B0D14 File Offset: 0x003AEF14
		public static void StartProductIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019DEC RID: 105964 RVA: 0x003B0D1F File Offset: 0x003AEF1F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06019DED RID: 105965 RVA: 0x003B0D2A File Offset: 0x003AEF2A
		public static Offset<IShowUiForging> EndIShowUiForging(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiForging>(builder.EndTable());
		}

		// Token: 0x06019DEE RID: 105966 RVA: 0x003B0D38 File Offset: 0x003AEF38
		public IShowUiForgingT UnPack()
		{
			IShowUiForgingT showUiForgingT = new IShowUiForgingT();
			this.UnPackTo(showUiForgingT);
			return showUiForgingT;
		}

		// Token: 0x06019DEF RID: 105967 RVA: 0x003B0D54 File Offset: 0x003AEF54
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

		// Token: 0x06019DF0 RID: 105968 RVA: 0x003B0DD8 File Offset: 0x003AEFD8
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

		// Token: 0x0400C703 RID: 50947
		private Table __p;
	}
}
