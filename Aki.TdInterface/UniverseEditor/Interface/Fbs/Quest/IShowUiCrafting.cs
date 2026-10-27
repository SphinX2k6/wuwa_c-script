using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004127 RID: 16679
	public struct IShowUiCrafting : IFlatbufferObject
	{
		// Token: 0x17007621 RID: 30241
		// (get) Token: 0x060186FC RID: 100092 RVA: 0x00386428 File Offset: 0x00384628
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060186FD RID: 100093 RVA: 0x00386435 File Offset: 0x00384635
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060186FE RID: 100094 RVA: 0x0038643C File Offset: 0x0038463C
		public static IShowUiCrafting GetRootAsIShowUiCrafting(ByteBuffer _bb)
		{
			return IShowUiCrafting.GetRootAsIShowUiCrafting(_bb, default(IShowUiCrafting));
		}

		// Token: 0x060186FF RID: 100095 RVA: 0x00386458 File Offset: 0x00384658
		public static IShowUiCrafting GetRootAsIShowUiCrafting(ByteBuffer _bb, IShowUiCrafting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018700 RID: 100096 RVA: 0x00386475 File Offset: 0x00384675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018701 RID: 100097 RVA: 0x00386484 File Offset: 0x00384684
		public IShowUiCrafting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007622 RID: 30242
		// (get) Token: 0x06018702 RID: 100098 RVA: 0x00386494 File Offset: 0x00384694
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

		// Token: 0x06018703 RID: 100099 RVA: 0x003864D0 File Offset: 0x003846D0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007623 RID: 30243
		// (get) Token: 0x06018704 RID: 100100 RVA: 0x00386510 File Offset: 0x00384710
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

		// Token: 0x06018705 RID: 100101 RVA: 0x0038653B File Offset: 0x0038473B
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06018706 RID: 100102 RVA: 0x0038654A File Offset: 0x0038474A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06018707 RID: 100103 RVA: 0x00386558 File Offset: 0x00384758
		public int ProductIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007624 RID: 30244
		// (get) Token: 0x06018708 RID: 100104 RVA: 0x00386598 File Offset: 0x00384798
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

		// Token: 0x06018709 RID: 100105 RVA: 0x003865C3 File Offset: 0x003847C3
		public Span<int> GetProductIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601870A RID: 100106 RVA: 0x003865D2 File Offset: 0x003847D2
		public int[] GetProductIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17007625 RID: 30245
		// (get) Token: 0x0601870B RID: 100107 RVA: 0x003865E0 File Offset: 0x003847E0
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

		// Token: 0x0601870C RID: 100108 RVA: 0x0038661D File Offset: 0x0038481D
		public static Offset<IShowUiCrafting> CreateIShowUiCrafting(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset ProductIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IShowUiCrafting.AddProductIds(builder, ProductIdsOffset);
			IShowUiCrafting.AddEntityIds(builder, EntityIdsOffset);
			IShowUiCrafting.AddNullMask(builder, NullMask);
			IShowUiCrafting.AddType(builder, Type);
			return IShowUiCrafting.EndIShowUiCrafting(builder);
		}

		// Token: 0x0601870D RID: 100109 RVA: 0x00386649 File Offset: 0x00384849
		public static void StartIShowUiCrafting(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601870E RID: 100110 RVA: 0x00386652 File Offset: 0x00384852
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601870F RID: 100111 RVA: 0x0038665D File Offset: 0x0038485D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06018710 RID: 100112 RVA: 0x00386670 File Offset: 0x00384870
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018711 RID: 100113 RVA: 0x003866A7 File Offset: 0x003848A7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018712 RID: 100114 RVA: 0x003866C1 File Offset: 0x003848C1
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018713 RID: 100115 RVA: 0x003866DF File Offset: 0x003848DF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018714 RID: 100116 RVA: 0x003866F8 File Offset: 0x003848F8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018715 RID: 100117 RVA: 0x00386703 File Offset: 0x00384903
		public static void AddProductIds(FlatBufferBuilder builder, VectorOffset productIdsOffset)
		{
			builder.AddOffset(2, productIdsOffset.Value, 0);
		}

		// Token: 0x06018716 RID: 100118 RVA: 0x00386714 File Offset: 0x00384914
		public static VectorOffset CreateProductIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018717 RID: 100119 RVA: 0x0038674B File Offset: 0x0038494B
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018718 RID: 100120 RVA: 0x00386765 File Offset: 0x00384965
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018719 RID: 100121 RVA: 0x00386783 File Offset: 0x00384983
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601871A RID: 100122 RVA: 0x0038679C File Offset: 0x0038499C
		public static void StartProductIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601871B RID: 100123 RVA: 0x003867A7 File Offset: 0x003849A7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601871C RID: 100124 RVA: 0x003867B2 File Offset: 0x003849B2
		public static Offset<IShowUiCrafting> EndIShowUiCrafting(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiCrafting>(builder.EndTable());
		}

		// Token: 0x0601871D RID: 100125 RVA: 0x003867C0 File Offset: 0x003849C0
		public IShowUiCraftingT UnPack()
		{
			IShowUiCraftingT showUiCraftingT = new IShowUiCraftingT();
			this.UnPackTo(showUiCraftingT);
			return showUiCraftingT;
		}

		// Token: 0x0601871E RID: 100126 RVA: 0x003867DC File Offset: 0x003849DC
		public void UnPackTo(IShowUiCraftingT _o)
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

		// Token: 0x0601871F RID: 100127 RVA: 0x00386860 File Offset: 0x00384A60
		public static Offset<IShowUiCrafting> Pack(FlatBufferBuilder builder, IShowUiCraftingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowUiCrafting>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IShowUiCrafting.CreateEntityIdsVector(builder, data);
			}
			VectorOffset productIdsOffset = default(VectorOffset);
			if (_o.ProductIds != null)
			{
				int[] data2 = _o.ProductIds.ToArray();
				productIdsOffset = IShowUiCrafting.CreateProductIdsVector(builder, data2);
			}
			return IShowUiCrafting.CreateIShowUiCrafting(builder, _o.Type, entityIdsOffset, productIdsOffset, _o.NullMask);
		}

		// Token: 0x0400BD15 RID: 48405
		private Table __p;
	}
}
