using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005171 RID: 20849
	public struct IEntityCategoryWeight : IFlatbufferObject
	{
		// Token: 0x17009846 RID: 38982
		// (get) Token: 0x06021B14 RID: 138004 RVA: 0x004ACD60 File Offset: 0x004AAF60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021B15 RID: 138005 RVA: 0x004ACD6D File Offset: 0x004AAF6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021B16 RID: 138006 RVA: 0x004ACD74 File Offset: 0x004AAF74
		public static IEntityCategoryWeight GetRootAsIEntityCategoryWeight(ByteBuffer _bb)
		{
			return IEntityCategoryWeight.GetRootAsIEntityCategoryWeight(_bb, default(IEntityCategoryWeight));
		}

		// Token: 0x06021B17 RID: 138007 RVA: 0x004ACD90 File Offset: 0x004AAF90
		public static IEntityCategoryWeight GetRootAsIEntityCategoryWeight(ByteBuffer _bb, IEntityCategoryWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021B18 RID: 138008 RVA: 0x004ACDAD File Offset: 0x004AAFAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021B19 RID: 138009 RVA: 0x004ACDBC File Offset: 0x004AAFBC
		public IEntityCategoryWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009847 RID: 38983
		// (get) Token: 0x06021B1A RID: 138010 RVA: 0x004ACDCC File Offset: 0x004AAFCC
		public IStaticEntitiyMatch? EntitiyMatch
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IStaticEntitiyMatch?(default(IStaticEntitiyMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009848 RID: 38984
		// (get) Token: 0x06021B1B RID: 138011 RVA: 0x004ACE2C File Offset: 0x004AB02C
		public int Weight
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

		// Token: 0x06021B1C RID: 138012 RVA: 0x004ACE68 File Offset: 0x004AB068
		public static Offset<IEntityCategoryWeight> CreateIEntityCategoryWeight(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> EntitiyMatchOffset = default(Offset<IStaticEntitiyMatch>), int Weight = 0)
		{
			builder.StartTable(2);
			IEntityCategoryWeight.AddWeight(builder, Weight);
			IEntityCategoryWeight.AddEntitiyMatch(builder, EntitiyMatchOffset);
			return IEntityCategoryWeight.EndIEntityCategoryWeight(builder);
		}

		// Token: 0x06021B1D RID: 138013 RVA: 0x004ACE85 File Offset: 0x004AB085
		public static void StartIEntityCategoryWeight(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021B1E RID: 138014 RVA: 0x004ACE8E File Offset: 0x004AB08E
		public static void AddEntitiyMatch(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> entitiyMatchOffset)
		{
			builder.AddOffset(0, entitiyMatchOffset.Value, 0);
		}

		// Token: 0x06021B1F RID: 138015 RVA: 0x004ACE9E File Offset: 0x004AB09E
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(1, weight, 0);
		}

		// Token: 0x06021B20 RID: 138016 RVA: 0x004ACEA9 File Offset: 0x004AB0A9
		public static Offset<IEntityCategoryWeight> EndIEntityCategoryWeight(FlatBufferBuilder builder)
		{
			return new Offset<IEntityCategoryWeight>(builder.EndTable());
		}

		// Token: 0x06021B21 RID: 138017 RVA: 0x004ACEB8 File Offset: 0x004AB0B8
		public IEntityCategoryWeightT UnPack()
		{
			IEntityCategoryWeightT entityCategoryWeightT = new IEntityCategoryWeightT();
			this.UnPackTo(entityCategoryWeightT);
			return entityCategoryWeightT;
		}

		// Token: 0x06021B22 RID: 138018 RVA: 0x004ACED4 File Offset: 0x004AB0D4
		public void UnPackTo(IEntityCategoryWeightT _o)
		{
			_o.EntitiyMatch = ((this.EntitiyMatch != null) ? this.EntitiyMatch.Value.UnPack() : null);
			_o.Weight = this.Weight;
		}

		// Token: 0x06021B23 RID: 138019 RVA: 0x004ACF1C File Offset: 0x004AB11C
		public static Offset<IEntityCategoryWeight> Pack(FlatBufferBuilder builder, IEntityCategoryWeightT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityCategoryWeight>);
			}
			Offset<IStaticEntitiyMatch> entitiyMatchOffset = (_o.EntitiyMatch == null) ? default(Offset<IStaticEntitiyMatch>) : IStaticEntitiyMatch.Pack(builder, _o.EntitiyMatch);
			return IEntityCategoryWeight.CreateIEntityCategoryWeight(builder, entitiyMatchOffset, _o.Weight);
		}

		// Token: 0x0400E237 RID: 57911
		private Table __p;
	}
}
