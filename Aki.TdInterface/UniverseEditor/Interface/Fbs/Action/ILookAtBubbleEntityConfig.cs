using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A59 RID: 27225
	public struct ILookAtBubbleEntityConfig : IFlatbufferObject
	{
		// Token: 0x1700C9F6 RID: 51702
		// (get) Token: 0x0602FABA RID: 195258 RVA: 0x0067CEA8 File Offset: 0x0067B0A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FABB RID: 195259 RVA: 0x0067CEB5 File Offset: 0x0067B0B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FABC RID: 195260 RVA: 0x0067CEBC File Offset: 0x0067B0BC
		public static ILookAtBubbleEntityConfig GetRootAsILookAtBubbleEntityConfig(ByteBuffer _bb)
		{
			return ILookAtBubbleEntityConfig.GetRootAsILookAtBubbleEntityConfig(_bb, default(ILookAtBubbleEntityConfig));
		}

		// Token: 0x0602FABD RID: 195261 RVA: 0x0067CED8 File Offset: 0x0067B0D8
		public static ILookAtBubbleEntityConfig GetRootAsILookAtBubbleEntityConfig(ByteBuffer _bb, ILookAtBubbleEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FABE RID: 195262 RVA: 0x0067CEF5 File Offset: 0x0067B0F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FABF RID: 195263 RVA: 0x0067CF04 File Offset: 0x0067B104
		public ILookAtBubbleEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9F7 RID: 51703
		// (get) Token: 0x0602FAC0 RID: 195264 RVA: 0x0067CF14 File Offset: 0x0067B114
		public int BubbleEntity
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FAC1 RID: 195265 RVA: 0x0067CF50 File Offset: 0x0067B150
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C9F8 RID: 51704
		// (get) Token: 0x0602FAC2 RID: 195266 RVA: 0x0067CF90 File Offset: 0x0067B190
		public int RangeEntitiesLength
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

		// Token: 0x0602FAC3 RID: 195267 RVA: 0x0067CFBB File Offset: 0x0067B1BB
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602FAC4 RID: 195268 RVA: 0x0067CFCA File Offset: 0x0067B1CA
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700C9F9 RID: 51705
		// (get) Token: 0x0602FAC5 RID: 195269 RVA: 0x0067CFD8 File Offset: 0x0067B1D8
		public IEntityLookAtPerform? EntityLookAtPerform
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IEntityLookAtPerform?(default(IEntityLookAtPerform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602FAC6 RID: 195270 RVA: 0x0067D035 File Offset: 0x0067B235
		public static Offset<ILookAtBubbleEntityConfig> CreateILookAtBubbleEntityConfig(FlatBufferBuilder builder, int BubbleEntity = 0, VectorOffset RangeEntitiesOffset = default(VectorOffset), Offset<IEntityLookAtPerform> EntityLookAtPerformOffset = default(Offset<IEntityLookAtPerform>))
		{
			builder.StartTable(3);
			ILookAtBubbleEntityConfig.AddEntityLookAtPerform(builder, EntityLookAtPerformOffset);
			ILookAtBubbleEntityConfig.AddRangeEntities(builder, RangeEntitiesOffset);
			ILookAtBubbleEntityConfig.AddBubbleEntity(builder, BubbleEntity);
			return ILookAtBubbleEntityConfig.EndILookAtBubbleEntityConfig(builder);
		}

		// Token: 0x0602FAC7 RID: 195271 RVA: 0x0067D059 File Offset: 0x0067B259
		public static void StartILookAtBubbleEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602FAC8 RID: 195272 RVA: 0x0067D062 File Offset: 0x0067B262
		public static void AddBubbleEntity(FlatBufferBuilder builder, int bubbleEntity)
		{
			builder.AddInt(0, bubbleEntity, 0);
		}

		// Token: 0x0602FAC9 RID: 195273 RVA: 0x0067D06D File Offset: 0x0067B26D
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(1, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x0602FACA RID: 195274 RVA: 0x0067D080 File Offset: 0x0067B280
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FACB RID: 195275 RVA: 0x0067D0B7 File Offset: 0x0067B2B7
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FACC RID: 195276 RVA: 0x0067D0D1 File Offset: 0x0067B2D1
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FACD RID: 195277 RVA: 0x0067D0EF File Offset: 0x0067B2EF
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FACE RID: 195278 RVA: 0x0067D108 File Offset: 0x0067B308
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FACF RID: 195279 RVA: 0x0067D113 File Offset: 0x0067B313
		public static void AddEntityLookAtPerform(FlatBufferBuilder builder, Offset<IEntityLookAtPerform> entityLookAtPerformOffset)
		{
			builder.AddOffset(2, entityLookAtPerformOffset.Value, 0);
		}

		// Token: 0x0602FAD0 RID: 195280 RVA: 0x0067D123 File Offset: 0x0067B323
		public static Offset<ILookAtBubbleEntityConfig> EndILookAtBubbleEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtBubbleEntityConfig>(builder.EndTable());
		}

		// Token: 0x0602FAD1 RID: 195281 RVA: 0x0067D130 File Offset: 0x0067B330
		public ILookAtBubbleEntityConfigT UnPack()
		{
			ILookAtBubbleEntityConfigT lookAtBubbleEntityConfigT = new ILookAtBubbleEntityConfigT();
			this.UnPackTo(lookAtBubbleEntityConfigT);
			return lookAtBubbleEntityConfigT;
		}

		// Token: 0x0602FAD2 RID: 195282 RVA: 0x0067D14C File Offset: 0x0067B34C
		public void UnPackTo(ILookAtBubbleEntityConfigT _o)
		{
			_o.BubbleEntity = this.BubbleEntity;
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.EntityLookAtPerform = ((this.EntityLookAtPerform != null) ? this.EntityLookAtPerform.Value.UnPack() : null);
		}

		// Token: 0x0602FAD3 RID: 195283 RVA: 0x0067D1C4 File Offset: 0x0067B3C4
		public static Offset<ILookAtBubbleEntityConfig> Pack(FlatBufferBuilder builder, ILookAtBubbleEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtBubbleEntityConfig>);
			}
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = ILookAtBubbleEntityConfig.CreateRangeEntitiesVector(builder, data);
			}
			Offset<IEntityLookAtPerform> entityLookAtPerformOffset = (_o.EntityLookAtPerform == null) ? default(Offset<IEntityLookAtPerform>) : IEntityLookAtPerform.Pack(builder, _o.EntityLookAtPerform);
			return ILookAtBubbleEntityConfig.CreateILookAtBubbleEntityConfig(builder, _o.BubbleEntity, rangeEntitiesOffset, entityLookAtPerformOffset);
		}

		// Token: 0x04011278 RID: 70264
		private Table __p;
	}
}
