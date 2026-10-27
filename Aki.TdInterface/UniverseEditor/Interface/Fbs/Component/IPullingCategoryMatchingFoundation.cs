using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057AB RID: 22443
	public struct IPullingCategoryMatchingFoundation : IFlatbufferObject
	{
		// Token: 0x1700A788 RID: 42888
		// (get) Token: 0x06025A98 RID: 154264 RVA: 0x00531FCD File Offset: 0x005301CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025A99 RID: 154265 RVA: 0x00531FDA File Offset: 0x005301DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025A9A RID: 154266 RVA: 0x00531FE4 File Offset: 0x005301E4
		public static IPullingCategoryMatchingFoundation GetRootAsIPullingCategoryMatchingFoundation(ByteBuffer _bb)
		{
			return IPullingCategoryMatchingFoundation.GetRootAsIPullingCategoryMatchingFoundation(_bb, default(IPullingCategoryMatchingFoundation));
		}

		// Token: 0x06025A9B RID: 154267 RVA: 0x00532000 File Offset: 0x00530200
		public static IPullingCategoryMatchingFoundation GetRootAsIPullingCategoryMatchingFoundation(ByteBuffer _bb, IPullingCategoryMatchingFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025A9C RID: 154268 RVA: 0x0053201D File Offset: 0x0053021D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025A9D RID: 154269 RVA: 0x0053202C File Offset: 0x0053022C
		public IPullingCategoryMatchingFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A789 RID: 42889
		// (get) Token: 0x06025A9E RID: 154270 RVA: 0x0053203C File Offset: 0x0053023C
		public EPullingFoundation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPullingFoundation.CategoryMatching;
				}
				return (EPullingFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A78A RID: 42890
		// (get) Token: 0x06025A9F RID: 154271 RVA: 0x00532078 File Offset: 0x00530278
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

		// Token: 0x06025AA0 RID: 154272 RVA: 0x005320B4 File Offset: 0x005302B4
		public ICategoryMatchingConfigBase? MatchingConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICategoryMatchingConfigBase?(default(ICategoryMatchingConfigBase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A78B RID: 42891
		// (get) Token: 0x06025AA1 RID: 154273 RVA: 0x00532114 File Offset: 0x00530314
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

		// Token: 0x1700A78C RID: 42892
		// (get) Token: 0x06025AA2 RID: 154274 RVA: 0x00532140 File Offset: 0x00530340
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

		// Token: 0x06025AA3 RID: 154275 RVA: 0x0053217D File Offset: 0x0053037D
		public static Offset<IPullingCategoryMatchingFoundation> CreateIPullingCategoryMatchingFoundation(FlatBufferBuilder builder, EPullingFoundation Type = EPullingFoundation.CategoryMatching, int InitMatchEntity = 0, VectorOffset MatchingConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IPullingCategoryMatchingFoundation.AddMatchingConfigs(builder, MatchingConfigsOffset);
			IPullingCategoryMatchingFoundation.AddInitMatchEntity(builder, InitMatchEntity);
			IPullingCategoryMatchingFoundation.AddNullMask(builder, NullMask);
			IPullingCategoryMatchingFoundation.AddType(builder, Type);
			return IPullingCategoryMatchingFoundation.EndIPullingCategoryMatchingFoundation(builder);
		}

		// Token: 0x06025AA4 RID: 154276 RVA: 0x005321A9 File Offset: 0x005303A9
		public static void StartIPullingCategoryMatchingFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025AA5 RID: 154277 RVA: 0x005321B2 File Offset: 0x005303B2
		public static void AddType(FlatBufferBuilder builder, EPullingFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025AA6 RID: 154278 RVA: 0x005321BD File Offset: 0x005303BD
		public static void AddInitMatchEntity(FlatBufferBuilder builder, int initMatchEntity)
		{
			builder.AddInt(1, initMatchEntity, 0);
		}

		// Token: 0x06025AA7 RID: 154279 RVA: 0x005321C8 File Offset: 0x005303C8
		public static void AddMatchingConfigs(FlatBufferBuilder builder, VectorOffset matchingConfigsOffset)
		{
			builder.AddOffset(2, matchingConfigsOffset.Value, 0);
		}

		// Token: 0x06025AA8 RID: 154280 RVA: 0x005321D8 File Offset: 0x005303D8
		public static VectorOffset CreateMatchingConfigsVector(FlatBufferBuilder builder, Offset<ICategoryMatchingConfigBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025AA9 RID: 154281 RVA: 0x00532218 File Offset: 0x00530418
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, Offset<ICategoryMatchingConfigBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICategoryMatchingConfigBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025AAA RID: 154282 RVA: 0x00532232 File Offset: 0x00530432
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICategoryMatchingConfigBase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICategoryMatchingConfigBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025AAB RID: 154283 RVA: 0x00532250 File Offset: 0x00530450
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICategoryMatchingConfigBase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025AAC RID: 154284 RVA: 0x00532269 File Offset: 0x00530469
		public static void StartMatchingConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025AAD RID: 154285 RVA: 0x00532274 File Offset: 0x00530474
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025AAE RID: 154286 RVA: 0x0053227F File Offset: 0x0053047F
		public static Offset<IPullingCategoryMatchingFoundation> EndIPullingCategoryMatchingFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IPullingCategoryMatchingFoundation>(builder.EndTable());
		}

		// Token: 0x06025AAF RID: 154287 RVA: 0x0053228C File Offset: 0x0053048C
		public IPullingCategoryMatchingFoundationT UnPack()
		{
			IPullingCategoryMatchingFoundationT pullingCategoryMatchingFoundationT = new IPullingCategoryMatchingFoundationT();
			this.UnPackTo(pullingCategoryMatchingFoundationT);
			return pullingCategoryMatchingFoundationT;
		}

		// Token: 0x06025AB0 RID: 154288 RVA: 0x005322A8 File Offset: 0x005304A8
		public void UnPackTo(IPullingCategoryMatchingFoundationT _o)
		{
			_o.Type = this.Type;
			_o.InitMatchEntity = this.InitMatchEntity;
			_o.MatchingConfigs = new List<ICategoryMatchingConfigBaseT>();
			for (int i = 0; i < this.MatchingConfigsLength; i++)
			{
				_o.MatchingConfigs.Add((this.MatchingConfigs(i) != null) ? this.MatchingConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025AB1 RID: 154289 RVA: 0x0053232C File Offset: 0x0053052C
		public static Offset<IPullingCategoryMatchingFoundation> Pack(FlatBufferBuilder builder, IPullingCategoryMatchingFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPullingCategoryMatchingFoundation>);
			}
			VectorOffset matchingConfigsOffset = default(VectorOffset);
			if (_o.MatchingConfigs != null)
			{
				Offset<ICategoryMatchingConfigBase>[] array = new Offset<ICategoryMatchingConfigBase>[_o.MatchingConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICategoryMatchingConfigBase.Pack(builder, _o.MatchingConfigs[i]);
				}
				matchingConfigsOffset = IPullingCategoryMatchingFoundation.CreateMatchingConfigsVector(builder, array);
			}
			return IPullingCategoryMatchingFoundation.CreateIPullingCategoryMatchingFoundation(builder, _o.Type, _o.InitMatchEntity, matchingConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400EC80 RID: 60544
		private Table __p;
	}
}
