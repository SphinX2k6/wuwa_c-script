using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005784 RID: 22404
	public struct IProbabilityRefreshItem : IFlatbufferObject
	{
		// Token: 0x1700A71B RID: 42779
		// (get) Token: 0x060258ED RID: 153837 RVA: 0x0052E4FC File Offset: 0x0052C6FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060258EE RID: 153838 RVA: 0x0052E509 File Offset: 0x0052C709
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060258EF RID: 153839 RVA: 0x0052E510 File Offset: 0x0052C710
		public static IProbabilityRefreshItem GetRootAsIProbabilityRefreshItem(ByteBuffer _bb)
		{
			return IProbabilityRefreshItem.GetRootAsIProbabilityRefreshItem(_bb, default(IProbabilityRefreshItem));
		}

		// Token: 0x060258F0 RID: 153840 RVA: 0x0052E52C File Offset: 0x0052C72C
		public static IProbabilityRefreshItem GetRootAsIProbabilityRefreshItem(ByteBuffer _bb, IProbabilityRefreshItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060258F1 RID: 153841 RVA: 0x0052E549 File Offset: 0x0052C749
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060258F2 RID: 153842 RVA: 0x0052E558 File Offset: 0x0052C758
		public IProbabilityRefreshItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A71C RID: 42780
		// (get) Token: 0x060258F3 RID: 153843 RVA: 0x0052E568 File Offset: 0x0052C768
		public int Probability
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

		// Token: 0x1700A71D RID: 42781
		// (get) Token: 0x060258F4 RID: 153844 RVA: 0x0052E5A4 File Offset: 0x0052C7A4
		public int RefreshEntityId
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

		// Token: 0x1700A71E RID: 42782
		// (get) Token: 0x060258F5 RID: 153845 RVA: 0x0052E5E0 File Offset: 0x0052C7E0
		public IConditionGroup? AdditionalCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060258F6 RID: 153846 RVA: 0x0052E63D File Offset: 0x0052C83D
		public static Offset<IProbabilityRefreshItem> CreateIProbabilityRefreshItem(FlatBufferBuilder builder, int Probability = 0, int RefreshEntityId = 0, Offset<IConditionGroup> AdditionalConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			IProbabilityRefreshItem.AddAdditionalCondition(builder, AdditionalConditionOffset);
			IProbabilityRefreshItem.AddRefreshEntityId(builder, RefreshEntityId);
			IProbabilityRefreshItem.AddProbability(builder, Probability);
			return IProbabilityRefreshItem.EndIProbabilityRefreshItem(builder);
		}

		// Token: 0x060258F7 RID: 153847 RVA: 0x0052E661 File Offset: 0x0052C861
		public static void StartIProbabilityRefreshItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060258F8 RID: 153848 RVA: 0x0052E66A File Offset: 0x0052C86A
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(0, probability, 0);
		}

		// Token: 0x060258F9 RID: 153849 RVA: 0x0052E675 File Offset: 0x0052C875
		public static void AddRefreshEntityId(FlatBufferBuilder builder, int refreshEntityId)
		{
			builder.AddInt(1, refreshEntityId, 0);
		}

		// Token: 0x060258FA RID: 153850 RVA: 0x0052E680 File Offset: 0x0052C880
		public static void AddAdditionalCondition(FlatBufferBuilder builder, Offset<IConditionGroup> additionalConditionOffset)
		{
			builder.AddOffset(2, additionalConditionOffset.Value, 0);
		}

		// Token: 0x060258FB RID: 153851 RVA: 0x0052E690 File Offset: 0x0052C890
		public static Offset<IProbabilityRefreshItem> EndIProbabilityRefreshItem(FlatBufferBuilder builder)
		{
			return new Offset<IProbabilityRefreshItem>(builder.EndTable());
		}

		// Token: 0x060258FC RID: 153852 RVA: 0x0052E6A0 File Offset: 0x0052C8A0
		public IProbabilityRefreshItemT UnPack()
		{
			IProbabilityRefreshItemT probabilityRefreshItemT = new IProbabilityRefreshItemT();
			this.UnPackTo(probabilityRefreshItemT);
			return probabilityRefreshItemT;
		}

		// Token: 0x060258FD RID: 153853 RVA: 0x0052E6BC File Offset: 0x0052C8BC
		public void UnPackTo(IProbabilityRefreshItemT _o)
		{
			_o.Probability = this.Probability;
			_o.RefreshEntityId = this.RefreshEntityId;
			_o.AdditionalCondition = ((this.AdditionalCondition != null) ? this.AdditionalCondition.Value.UnPack() : null);
		}

		// Token: 0x060258FE RID: 153854 RVA: 0x0052E710 File Offset: 0x0052C910
		public static Offset<IProbabilityRefreshItem> Pack(FlatBufferBuilder builder, IProbabilityRefreshItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProbabilityRefreshItem>);
			}
			Offset<IConditionGroup> additionalConditionOffset = (_o.AdditionalCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.AdditionalCondition);
			return IProbabilityRefreshItem.CreateIProbabilityRefreshItem(builder, _o.Probability, _o.RefreshEntityId, additionalConditionOffset);
		}

		// Token: 0x0400EC31 RID: 60465
		private Table __p;
	}
}
