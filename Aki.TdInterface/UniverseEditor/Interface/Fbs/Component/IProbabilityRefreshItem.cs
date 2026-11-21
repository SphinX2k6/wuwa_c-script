using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D8B RID: 23947
	public struct IProbabilityRefreshItem : IFlatbufferObject
	{
		// Token: 0x1700B03F RID: 45119
		// (get) Token: 0x06027E0D RID: 163341 RVA: 0x00574688 File Offset: 0x00572888
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027E0E RID: 163342 RVA: 0x00574695 File Offset: 0x00572895
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027E0F RID: 163343 RVA: 0x0057469C File Offset: 0x0057289C
		public static IProbabilityRefreshItem GetRootAsIProbabilityRefreshItem(ByteBuffer _bb)
		{
			return IProbabilityRefreshItem.GetRootAsIProbabilityRefreshItem(_bb, default(IProbabilityRefreshItem));
		}

		// Token: 0x06027E10 RID: 163344 RVA: 0x005746B8 File Offset: 0x005728B8
		public static IProbabilityRefreshItem GetRootAsIProbabilityRefreshItem(ByteBuffer _bb, IProbabilityRefreshItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027E11 RID: 163345 RVA: 0x005746D5 File Offset: 0x005728D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027E12 RID: 163346 RVA: 0x005746E4 File Offset: 0x005728E4
		public IProbabilityRefreshItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B040 RID: 45120
		// (get) Token: 0x06027E13 RID: 163347 RVA: 0x005746F4 File Offset: 0x005728F4
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

		// Token: 0x1700B041 RID: 45121
		// (get) Token: 0x06027E14 RID: 163348 RVA: 0x00574730 File Offset: 0x00572930
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

		// Token: 0x1700B042 RID: 45122
		// (get) Token: 0x06027E15 RID: 163349 RVA: 0x0057476C File Offset: 0x0057296C
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

		// Token: 0x06027E16 RID: 163350 RVA: 0x005747C9 File Offset: 0x005729C9
		public static Offset<IProbabilityRefreshItem> CreateIProbabilityRefreshItem(FlatBufferBuilder builder, int Probability = 0, int RefreshEntityId = 0, Offset<IConditionGroup> AdditionalConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			IProbabilityRefreshItem.AddAdditionalCondition(builder, AdditionalConditionOffset);
			IProbabilityRefreshItem.AddRefreshEntityId(builder, RefreshEntityId);
			IProbabilityRefreshItem.AddProbability(builder, Probability);
			return IProbabilityRefreshItem.EndIProbabilityRefreshItem(builder);
		}

		// Token: 0x06027E17 RID: 163351 RVA: 0x005747ED File Offset: 0x005729ED
		public static void StartIProbabilityRefreshItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027E18 RID: 163352 RVA: 0x005747F6 File Offset: 0x005729F6
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(0, probability, 0);
		}

		// Token: 0x06027E19 RID: 163353 RVA: 0x00574801 File Offset: 0x00572A01
		public static void AddRefreshEntityId(FlatBufferBuilder builder, int refreshEntityId)
		{
			builder.AddInt(1, refreshEntityId, 0);
		}

		// Token: 0x06027E1A RID: 163354 RVA: 0x0057480C File Offset: 0x00572A0C
		public static void AddAdditionalCondition(FlatBufferBuilder builder, Offset<IConditionGroup> additionalConditionOffset)
		{
			builder.AddOffset(2, additionalConditionOffset.Value, 0);
		}

		// Token: 0x06027E1B RID: 163355 RVA: 0x0057481C File Offset: 0x00572A1C
		public static Offset<IProbabilityRefreshItem> EndIProbabilityRefreshItem(FlatBufferBuilder builder)
		{
			return new Offset<IProbabilityRefreshItem>(builder.EndTable());
		}

		// Token: 0x06027E1C RID: 163356 RVA: 0x0057482C File Offset: 0x00572A2C
		public IProbabilityRefreshItemT UnPack()
		{
			IProbabilityRefreshItemT probabilityRefreshItemT = new IProbabilityRefreshItemT();
			this.UnPackTo(probabilityRefreshItemT);
			return probabilityRefreshItemT;
		}

		// Token: 0x06027E1D RID: 163357 RVA: 0x00574848 File Offset: 0x00572A48
		public void UnPackTo(IProbabilityRefreshItemT _o)
		{
			_o.Probability = this.Probability;
			_o.RefreshEntityId = this.RefreshEntityId;
			_o.AdditionalCondition = ((this.AdditionalCondition != null) ? this.AdditionalCondition.Value.UnPack() : null);
		}

		// Token: 0x06027E1E RID: 163358 RVA: 0x0057489C File Offset: 0x00572A9C
		public static Offset<IProbabilityRefreshItem> Pack(FlatBufferBuilder builder, IProbabilityRefreshItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProbabilityRefreshItem>);
			}
			Offset<IConditionGroup> additionalConditionOffset = (_o.AdditionalCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.AdditionalCondition);
			return IProbabilityRefreshItem.CreateIProbabilityRefreshItem(builder, _o.Probability, _o.RefreshEntityId, additionalConditionOffset);
		}

		// Token: 0x0400F91C RID: 63772
		private Table __p;
	}
}
