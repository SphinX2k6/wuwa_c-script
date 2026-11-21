using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200717B RID: 29051
	public struct ILookAtBubbleEntityConfig : IFlatbufferObject
	{
		// Token: 0x1700D4A1 RID: 54433
		// (get) Token: 0x060327E0 RID: 206816 RVA: 0x006D2F68 File Offset: 0x006D1168
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060327E1 RID: 206817 RVA: 0x006D2F75 File Offset: 0x006D1175
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060327E2 RID: 206818 RVA: 0x006D2F7C File Offset: 0x006D117C
		public static ILookAtBubbleEntityConfig GetRootAsILookAtBubbleEntityConfig(ByteBuffer _bb)
		{
			return ILookAtBubbleEntityConfig.GetRootAsILookAtBubbleEntityConfig(_bb, default(ILookAtBubbleEntityConfig));
		}

		// Token: 0x060327E3 RID: 206819 RVA: 0x006D2F98 File Offset: 0x006D1198
		public static ILookAtBubbleEntityConfig GetRootAsILookAtBubbleEntityConfig(ByteBuffer _bb, ILookAtBubbleEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060327E4 RID: 206820 RVA: 0x006D2FB5 File Offset: 0x006D11B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060327E5 RID: 206821 RVA: 0x006D2FC4 File Offset: 0x006D11C4
		public ILookAtBubbleEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4A2 RID: 54434
		// (get) Token: 0x060327E6 RID: 206822 RVA: 0x006D2FD4 File Offset: 0x006D11D4
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

		// Token: 0x060327E7 RID: 206823 RVA: 0x006D3010 File Offset: 0x006D1210
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D4A3 RID: 54435
		// (get) Token: 0x060327E8 RID: 206824 RVA: 0x006D3050 File Offset: 0x006D1250
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

		// Token: 0x060327E9 RID: 206825 RVA: 0x006D307B File Offset: 0x006D127B
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060327EA RID: 206826 RVA: 0x006D308A File Offset: 0x006D128A
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D4A4 RID: 54436
		// (get) Token: 0x060327EB RID: 206827 RVA: 0x006D3098 File Offset: 0x006D1298
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

		// Token: 0x060327EC RID: 206828 RVA: 0x006D30F5 File Offset: 0x006D12F5
		public static Offset<ILookAtBubbleEntityConfig> CreateILookAtBubbleEntityConfig(FlatBufferBuilder builder, int BubbleEntity = 0, VectorOffset RangeEntitiesOffset = default(VectorOffset), Offset<IEntityLookAtPerform> EntityLookAtPerformOffset = default(Offset<IEntityLookAtPerform>))
		{
			builder.StartTable(3);
			ILookAtBubbleEntityConfig.AddEntityLookAtPerform(builder, EntityLookAtPerformOffset);
			ILookAtBubbleEntityConfig.AddRangeEntities(builder, RangeEntitiesOffset);
			ILookAtBubbleEntityConfig.AddBubbleEntity(builder, BubbleEntity);
			return ILookAtBubbleEntityConfig.EndILookAtBubbleEntityConfig(builder);
		}

		// Token: 0x060327ED RID: 206829 RVA: 0x006D3119 File Offset: 0x006D1319
		public static void StartILookAtBubbleEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060327EE RID: 206830 RVA: 0x006D3122 File Offset: 0x006D1322
		public static void AddBubbleEntity(FlatBufferBuilder builder, int bubbleEntity)
		{
			builder.AddInt(0, bubbleEntity, 0);
		}

		// Token: 0x060327EF RID: 206831 RVA: 0x006D312D File Offset: 0x006D132D
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(1, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x060327F0 RID: 206832 RVA: 0x006D3140 File Offset: 0x006D1340
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060327F1 RID: 206833 RVA: 0x006D3177 File Offset: 0x006D1377
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060327F2 RID: 206834 RVA: 0x006D3191 File Offset: 0x006D1391
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060327F3 RID: 206835 RVA: 0x006D31AF File Offset: 0x006D13AF
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060327F4 RID: 206836 RVA: 0x006D31C8 File Offset: 0x006D13C8
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060327F5 RID: 206837 RVA: 0x006D31D3 File Offset: 0x006D13D3
		public static void AddEntityLookAtPerform(FlatBufferBuilder builder, Offset<IEntityLookAtPerform> entityLookAtPerformOffset)
		{
			builder.AddOffset(2, entityLookAtPerformOffset.Value, 0);
		}

		// Token: 0x060327F6 RID: 206838 RVA: 0x006D31E3 File Offset: 0x006D13E3
		public static Offset<ILookAtBubbleEntityConfig> EndILookAtBubbleEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtBubbleEntityConfig>(builder.EndTable());
		}

		// Token: 0x060327F7 RID: 206839 RVA: 0x006D31F0 File Offset: 0x006D13F0
		public ILookAtBubbleEntityConfigT UnPack()
		{
			ILookAtBubbleEntityConfigT lookAtBubbleEntityConfigT = new ILookAtBubbleEntityConfigT();
			this.UnPackTo(lookAtBubbleEntityConfigT);
			return lookAtBubbleEntityConfigT;
		}

		// Token: 0x060327F8 RID: 206840 RVA: 0x006D320C File Offset: 0x006D140C
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

		// Token: 0x060327F9 RID: 206841 RVA: 0x006D3284 File Offset: 0x006D1484
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

		// Token: 0x04012170 RID: 74096
		private Table __p;
	}
}
