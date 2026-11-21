using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005499 RID: 21657
	public struct ICategoryMatchingFoundation : IFlatbufferObject
	{
		// Token: 0x17009A43 RID: 39491
		// (get) Token: 0x0602213B RID: 139579 RVA: 0x004B29F5 File Offset: 0x004B0BF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602213C RID: 139580 RVA: 0x004B2A02 File Offset: 0x004B0C02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602213D RID: 139581 RVA: 0x004B2A0C File Offset: 0x004B0C0C
		public static ICategoryMatchingFoundation GetRootAsICategoryMatchingFoundation(ByteBuffer _bb)
		{
			return ICategoryMatchingFoundation.GetRootAsICategoryMatchingFoundation(_bb, default(ICategoryMatchingFoundation));
		}

		// Token: 0x0602213E RID: 139582 RVA: 0x004B2A28 File Offset: 0x004B0C28
		public static ICategoryMatchingFoundation GetRootAsICategoryMatchingFoundation(ByteBuffer _bb, ICategoryMatchingFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602213F RID: 139583 RVA: 0x004B2A45 File Offset: 0x004B0C45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022140 RID: 139584 RVA: 0x004B2A54 File Offset: 0x004B0C54
		public ICategoryMatchingFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A44 RID: 39492
		// (get) Token: 0x06022141 RID: 139585 RVA: 0x004B2A64 File Offset: 0x004B0C64
		public EItemFoundation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemFoundation.CategoryMatching;
				}
				return (EItemFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009A45 RID: 39493
		// (get) Token: 0x06022142 RID: 139586 RVA: 0x004B2AA0 File Offset: 0x004B0CA0
		public int InitMatchEntity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022143 RID: 139587 RVA: 0x004B2ADC File Offset: 0x004B0CDC
		public ICategoryMatchingConfig? MatchingConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICategoryMatchingConfig?(default(ICategoryMatchingConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009A46 RID: 39494
		// (get) Token: 0x06022144 RID: 139588 RVA: 0x004B2B3C File Offset: 0x004B0D3C
		public int MatchingConfigsLength
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

		// Token: 0x17009A47 RID: 39495
		// (get) Token: 0x06022145 RID: 139589 RVA: 0x004B2B68 File Offset: 0x004B0D68
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

		// Token: 0x06022146 RID: 139590 RVA: 0x004B2BA5 File Offset: 0x004B0DA5
		public static Offset<ICategoryMatchingFoundation> CreateICategoryMatchingFoundation(FlatBufferBuilder builder, EItemFoundation Type = EItemFoundation.CategoryMatching, int InitMatchEntity = 0, VectorOffset MatchingConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ICategoryMatchingFoundation.AddMatchingConfigs(builder, MatchingConfigsOffset);
			ICategoryMatchingFoundation.AddInitMatchEntity(builder, InitMatchEntity);
			ICategoryMatchingFoundation.AddNullMask(builder, NullMask);
			ICategoryMatchingFoundation.AddType(builder, Type);
			return ICategoryMatchingFoundation.EndICategoryMatchingFoundation(builder);
		}

		// Token: 0x06022147 RID: 139591 RVA: 0x004B2BD1 File Offset: 0x004B0DD1
		public static void StartICategoryMatchingFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022148 RID: 139592 RVA: 0x004B2BDA File Offset: 0x004B0DDA
		public static void AddType(FlatBufferBuilder builder, EItemFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022149 RID: 139593 RVA: 0x004B2BE5 File Offset: 0x004B0DE5
		public static void AddInitMatchEntity(FlatBufferBuilder builder, int initMatchEntity)
		{
			builder.AddInt(1, initMatchEntity, 0);
		}

		// Token: 0x0602214A RID: 139594 RVA: 0x004B2BF0 File Offset: 0x004B0DF0
		public static void AddMatchingConfigs(FlatBufferBuilder builder, VectorOffset matchingConfigsOffset)
		{
			builder.AddOffset(2, matchingConfigsOffset.Value, 0);
		}

		// Token: 0x0602214B RID: 139595 RVA: 0x004B2C00 File Offset: 0x004B0E00
		public static VectorOffset CreateMatchingConfigsVector(FlatBufferBuilder builder, Offset<ICategoryMatchingConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602214C RID: 139596 RVA: 0x004B2C40 File Offset: 0x004B0E40
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, Offset<ICategoryMatchingConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICategoryMatchingConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602214D RID: 139597 RVA: 0x004B2C5A File Offset: 0x004B0E5A
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICategoryMatchingConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICategoryMatchingConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602214E RID: 139598 RVA: 0x004B2C78 File Offset: 0x004B0E78
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICategoryMatchingConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602214F RID: 139599 RVA: 0x004B2C91 File Offset: 0x004B0E91
		public static void StartMatchingConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022150 RID: 139600 RVA: 0x004B2C9C File Offset: 0x004B0E9C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06022151 RID: 139601 RVA: 0x004B2CA7 File Offset: 0x004B0EA7
		public static Offset<ICategoryMatchingFoundation> EndICategoryMatchingFoundation(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingFoundation>(builder.EndTable());
		}

		// Token: 0x06022152 RID: 139602 RVA: 0x004B2CB4 File Offset: 0x004B0EB4
		public ICategoryMatchingFoundationT UnPack()
		{
			ICategoryMatchingFoundationT categoryMatchingFoundationT = new ICategoryMatchingFoundationT();
			this.UnPackTo(categoryMatchingFoundationT);
			return categoryMatchingFoundationT;
		}

		// Token: 0x06022153 RID: 139603 RVA: 0x004B2CD0 File Offset: 0x004B0ED0
		public void UnPackTo(ICategoryMatchingFoundationT _o)
		{
			_o.Type = this.Type;
			_o.InitMatchEntity = this.InitMatchEntity;
			_o.MatchingConfigs = new List<ICategoryMatchingConfigT>();
			for (int i = 0; i < this.MatchingConfigsLength; i++)
			{
				_o.MatchingConfigs.Add((this.MatchingConfigs(i) != null) ? this.MatchingConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022154 RID: 139604 RVA: 0x004B2D54 File Offset: 0x004B0F54
		public static Offset<ICategoryMatchingFoundation> Pack(FlatBufferBuilder builder, ICategoryMatchingFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICategoryMatchingFoundation>);
			}
			VectorOffset matchingConfigsOffset = default(VectorOffset);
			if (_o.MatchingConfigs != null)
			{
				Offset<ICategoryMatchingConfig>[] array = new Offset<ICategoryMatchingConfig>[_o.MatchingConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICategoryMatchingConfig.Pack(builder, _o.MatchingConfigs[i]);
				}
				matchingConfigsOffset = ICategoryMatchingFoundation.CreateMatchingConfigsVector(builder, array);
			}
			return ICategoryMatchingFoundation.CreateICategoryMatchingFoundation(builder, _o.Type, _o.InitMatchEntity, matchingConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400E9A8 RID: 59816
		private Table __p;
	}
}
