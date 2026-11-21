using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D6 RID: 22230
	public struct IEntityCategoryWeight : IFlatbufferObject
	{
		// Token: 0x1700A035 RID: 41013
		// (get) Token: 0x06023A6C RID: 146028 RVA: 0x004E6D7F File Offset: 0x004E4F7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023A6D RID: 146029 RVA: 0x004E6D8C File Offset: 0x004E4F8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023A6E RID: 146030 RVA: 0x004E6D94 File Offset: 0x004E4F94
		public static IEntityCategoryWeight GetRootAsIEntityCategoryWeight(ByteBuffer _bb)
		{
			return IEntityCategoryWeight.GetRootAsIEntityCategoryWeight(_bb, default(IEntityCategoryWeight));
		}

		// Token: 0x06023A6F RID: 146031 RVA: 0x004E6DB0 File Offset: 0x004E4FB0
		public static IEntityCategoryWeight GetRootAsIEntityCategoryWeight(ByteBuffer _bb, IEntityCategoryWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023A70 RID: 146032 RVA: 0x004E6DCD File Offset: 0x004E4FCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023A71 RID: 146033 RVA: 0x004E6DDC File Offset: 0x004E4FDC
		public IEntityCategoryWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A036 RID: 41014
		// (get) Token: 0x06023A72 RID: 146034 RVA: 0x004E6DEC File Offset: 0x004E4FEC
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

		// Token: 0x1700A037 RID: 41015
		// (get) Token: 0x06023A73 RID: 146035 RVA: 0x004E6E4C File Offset: 0x004E504C
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

		// Token: 0x06023A74 RID: 146036 RVA: 0x004E6E88 File Offset: 0x004E5088
		public static Offset<IEntityCategoryWeight> CreateIEntityCategoryWeight(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> EntitiyMatchOffset = default(Offset<IStaticEntitiyMatch>), int Weight = 0)
		{
			builder.StartTable(2);
			IEntityCategoryWeight.AddWeight(builder, Weight);
			IEntityCategoryWeight.AddEntitiyMatch(builder, EntitiyMatchOffset);
			return IEntityCategoryWeight.EndIEntityCategoryWeight(builder);
		}

		// Token: 0x06023A75 RID: 146037 RVA: 0x004E6EA5 File Offset: 0x004E50A5
		public static void StartIEntityCategoryWeight(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023A76 RID: 146038 RVA: 0x004E6EAE File Offset: 0x004E50AE
		public static void AddEntitiyMatch(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> entitiyMatchOffset)
		{
			builder.AddOffset(0, entitiyMatchOffset.Value, 0);
		}

		// Token: 0x06023A77 RID: 146039 RVA: 0x004E6EBE File Offset: 0x004E50BE
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(1, weight, 0);
		}

		// Token: 0x06023A78 RID: 146040 RVA: 0x004E6EC9 File Offset: 0x004E50C9
		public static Offset<IEntityCategoryWeight> EndIEntityCategoryWeight(FlatBufferBuilder builder)
		{
			return new Offset<IEntityCategoryWeight>(builder.EndTable());
		}

		// Token: 0x06023A79 RID: 146041 RVA: 0x004E6ED8 File Offset: 0x004E50D8
		public IEntityCategoryWeightT UnPack()
		{
			IEntityCategoryWeightT entityCategoryWeightT = new IEntityCategoryWeightT();
			this.UnPackTo(entityCategoryWeightT);
			return entityCategoryWeightT;
		}

		// Token: 0x06023A7A RID: 146042 RVA: 0x004E6EF4 File Offset: 0x004E50F4
		public void UnPackTo(IEntityCategoryWeightT _o)
		{
			_o.EntitiyMatch = ((this.EntitiyMatch != null) ? this.EntitiyMatch.Value.UnPack() : null);
			_o.Weight = this.Weight;
		}

		// Token: 0x06023A7B RID: 146043 RVA: 0x004E6F3C File Offset: 0x004E513C
		public static Offset<IEntityCategoryWeight> Pack(FlatBufferBuilder builder, IEntityCategoryWeightT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityCategoryWeight>);
			}
			Offset<IStaticEntitiyMatch> entitiyMatchOffset = (_o.EntitiyMatch == null) ? default(Offset<IStaticEntitiyMatch>) : IStaticEntitiyMatch.Pack(builder, _o.EntitiyMatch);
			return IEntityCategoryWeight.CreateIEntityCategoryWeight(builder, entitiyMatchOffset, _o.Weight);
		}

		// Token: 0x0400EE35 RID: 60981
		private Table __p;
	}
}
