using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004565 RID: 17765
	public struct IShowUiCook : IFlatbufferObject
	{
		// Token: 0x17007C1E RID: 31774
		// (get) Token: 0x06019D71 RID: 105841 RVA: 0x003AFEBD File Offset: 0x003AE0BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019D72 RID: 105842 RVA: 0x003AFECA File Offset: 0x003AE0CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019D73 RID: 105843 RVA: 0x003AFED4 File Offset: 0x003AE0D4
		public static IShowUiCook GetRootAsIShowUiCook(ByteBuffer _bb)
		{
			return IShowUiCook.GetRootAsIShowUiCook(_bb, default(IShowUiCook));
		}

		// Token: 0x06019D74 RID: 105844 RVA: 0x003AFEF0 File Offset: 0x003AE0F0
		public static IShowUiCook GetRootAsIShowUiCook(ByteBuffer _bb, IShowUiCook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019D75 RID: 105845 RVA: 0x003AFF0D File Offset: 0x003AE10D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019D76 RID: 105846 RVA: 0x003AFF1C File Offset: 0x003AE11C
		public IShowUiCook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C1F RID: 31775
		// (get) Token: 0x06019D77 RID: 105847 RVA: 0x003AFF2C File Offset: 0x003AE12C
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

		// Token: 0x06019D78 RID: 105848 RVA: 0x003AFF68 File Offset: 0x003AE168
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C20 RID: 31776
		// (get) Token: 0x06019D79 RID: 105849 RVA: 0x003AFFA8 File Offset: 0x003AE1A8
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

		// Token: 0x06019D7A RID: 105850 RVA: 0x003AFFD3 File Offset: 0x003AE1D3
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06019D7B RID: 105851 RVA: 0x003AFFE2 File Offset: 0x003AE1E2
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06019D7C RID: 105852 RVA: 0x003AFFF0 File Offset: 0x003AE1F0
		public int ProductIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C21 RID: 31777
		// (get) Token: 0x06019D7D RID: 105853 RVA: 0x003B0030 File Offset: 0x003AE230
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

		// Token: 0x06019D7E RID: 105854 RVA: 0x003B005B File Offset: 0x003AE25B
		public Span<int> GetProductIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06019D7F RID: 105855 RVA: 0x003B006A File Offset: 0x003AE26A
		public int[] GetProductIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17007C22 RID: 31778
		// (get) Token: 0x06019D80 RID: 105856 RVA: 0x003B0078 File Offset: 0x003AE278
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

		// Token: 0x06019D81 RID: 105857 RVA: 0x003B00B5 File Offset: 0x003AE2B5
		public static Offset<IShowUiCook> CreateIShowUiCook(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset ProductIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IShowUiCook.AddProductIds(builder, ProductIdsOffset);
			IShowUiCook.AddEntityIds(builder, EntityIdsOffset);
			IShowUiCook.AddNullMask(builder, NullMask);
			IShowUiCook.AddType(builder, Type);
			return IShowUiCook.EndIShowUiCook(builder);
		}

		// Token: 0x06019D82 RID: 105858 RVA: 0x003B00E1 File Offset: 0x003AE2E1
		public static void StartIShowUiCook(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019D83 RID: 105859 RVA: 0x003B00EA File Offset: 0x003AE2EA
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019D84 RID: 105860 RVA: 0x003B00F5 File Offset: 0x003AE2F5
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06019D85 RID: 105861 RVA: 0x003B0108 File Offset: 0x003AE308
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019D86 RID: 105862 RVA: 0x003B013F File Offset: 0x003AE33F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D87 RID: 105863 RVA: 0x003B0159 File Offset: 0x003AE359
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D88 RID: 105864 RVA: 0x003B0177 File Offset: 0x003AE377
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019D89 RID: 105865 RVA: 0x003B0190 File Offset: 0x003AE390
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019D8A RID: 105866 RVA: 0x003B019B File Offset: 0x003AE39B
		public static void AddProductIds(FlatBufferBuilder builder, VectorOffset productIdsOffset)
		{
			builder.AddOffset(2, productIdsOffset.Value, 0);
		}

		// Token: 0x06019D8B RID: 105867 RVA: 0x003B01AC File Offset: 0x003AE3AC
		public static VectorOffset CreateProductIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019D8C RID: 105868 RVA: 0x003B01E3 File Offset: 0x003AE3E3
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D8D RID: 105869 RVA: 0x003B01FD File Offset: 0x003AE3FD
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019D8E RID: 105870 RVA: 0x003B021B File Offset: 0x003AE41B
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019D8F RID: 105871 RVA: 0x003B0234 File Offset: 0x003AE434
		public static void StartProductIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019D90 RID: 105872 RVA: 0x003B023F File Offset: 0x003AE43F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06019D91 RID: 105873 RVA: 0x003B024A File Offset: 0x003AE44A
		public static Offset<IShowUiCook> EndIShowUiCook(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiCook>(builder.EndTable());
		}

		// Token: 0x06019D92 RID: 105874 RVA: 0x003B0258 File Offset: 0x003AE458
		public IShowUiCookT UnPack()
		{
			IShowUiCookT showUiCookT = new IShowUiCookT();
			this.UnPackTo(showUiCookT);
			return showUiCookT;
		}

		// Token: 0x06019D93 RID: 105875 RVA: 0x003B0274 File Offset: 0x003AE474
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

		// Token: 0x06019D94 RID: 105876 RVA: 0x003B02F8 File Offset: 0x003AE4F8
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

		// Token: 0x0400C6F9 RID: 50937
		private Table __p;
	}
}
