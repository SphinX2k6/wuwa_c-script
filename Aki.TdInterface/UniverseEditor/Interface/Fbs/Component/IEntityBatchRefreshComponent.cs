using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056BE RID: 22206
	public struct IEntityBatchRefreshComponent : IFlatbufferObject
	{
		// Token: 0x17009FD5 RID: 40917
		// (get) Token: 0x0602393D RID: 145725 RVA: 0x004E46E4 File Offset: 0x004E28E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602393E RID: 145726 RVA: 0x004E46F1 File Offset: 0x004E28F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602393F RID: 145727 RVA: 0x004E46F8 File Offset: 0x004E28F8
		public static IEntityBatchRefreshComponent GetRootAsIEntityBatchRefreshComponent(ByteBuffer _bb)
		{
			return IEntityBatchRefreshComponent.GetRootAsIEntityBatchRefreshComponent(_bb, default(IEntityBatchRefreshComponent));
		}

		// Token: 0x06023940 RID: 145728 RVA: 0x004E4714 File Offset: 0x004E2914
		public static IEntityBatchRefreshComponent GetRootAsIEntityBatchRefreshComponent(ByteBuffer _bb, IEntityBatchRefreshComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023941 RID: 145729 RVA: 0x004E4731 File Offset: 0x004E2931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023942 RID: 145730 RVA: 0x004E4740 File Offset: 0x004E2940
		public IEntityBatchRefreshComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FD6 RID: 40918
		// (get) Token: 0x06023943 RID: 145731 RVA: 0x004E4750 File Offset: 0x004E2950
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009FD7 RID: 40919
		// (get) Token: 0x06023944 RID: 145732 RVA: 0x004E4790 File Offset: 0x004E2990
		public IConditionGroup? StartCondition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009FD8 RID: 40920
		// (get) Token: 0x06023945 RID: 145733 RVA: 0x004E47F0 File Offset: 0x004E29F0
		public IConditionGroup? EndCondition
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

		// Token: 0x17009FD9 RID: 40921
		// (get) Token: 0x06023946 RID: 145734 RVA: 0x004E4850 File Offset: 0x004E2A50
		public TEntityBatchRefresh EntityBatchRefreshType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TEntityBatchRefresh.NONE;
				}
				return (TEntityBatchRefresh)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023947 RID: 145735 RVA: 0x004E4890 File Offset: 0x004E2A90
		public TTable? EntityBatchRefresh<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023948 RID: 145736 RVA: 0x004E48D8 File Offset: 0x004E2AD8
		public IRandomBatchPoolRefresh EntityBatchRefreshAsIRandomBatchPoolRefresh()
		{
			return this.EntityBatchRefresh<IRandomBatchPoolRefresh>().Value;
		}

		// Token: 0x06023949 RID: 145737 RVA: 0x004E48F4 File Offset: 0x004E2AF4
		public IRandomBatchRefresh EntityBatchRefreshAsIRandomBatchRefresh()
		{
			return this.EntityBatchRefresh<IRandomBatchRefresh>().Value;
		}

		// Token: 0x0602394A RID: 145738 RVA: 0x004E4910 File Offset: 0x004E2B10
		public ISequenceBatchRefresh EntityBatchRefreshAsISequenceBatchRefresh()
		{
			return this.EntityBatchRefresh<ISequenceBatchRefresh>().Value;
		}

		// Token: 0x17009FDA RID: 40922
		// (get) Token: 0x0602394B RID: 145739 RVA: 0x004E492C File Offset: 0x004E2B2C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602394C RID: 145740 RVA: 0x004E4969 File Offset: 0x004E2B69
		public static Offset<IEntityBatchRefreshComponent> CreateIEntityBatchRefreshComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IConditionGroup> StartConditionOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> EndConditionOffset = default(Offset<IConditionGroup>), TEntityBatchRefresh EntityBatchRefresh_type = TEntityBatchRefresh.NONE, int EntityBatchRefreshOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IEntityBatchRefreshComponent.AddEntityBatchRefresh(builder, EntityBatchRefreshOffset);
			IEntityBatchRefreshComponent.AddEndCondition(builder, EndConditionOffset);
			IEntityBatchRefreshComponent.AddStartCondition(builder, StartConditionOffset);
			IEntityBatchRefreshComponent.AddNullMask(builder, NullMask);
			IEntityBatchRefreshComponent.AddEntityBatchRefreshType(builder, EntityBatchRefresh_type);
			IEntityBatchRefreshComponent.AddDisabled(builder, Disabled);
			return IEntityBatchRefreshComponent.EndIEntityBatchRefreshComponent(builder);
		}

		// Token: 0x0602394D RID: 145741 RVA: 0x004E49A5 File Offset: 0x004E2BA5
		public static void StartIEntityBatchRefreshComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602394E RID: 145742 RVA: 0x004E49AE File Offset: 0x004E2BAE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602394F RID: 145743 RVA: 0x004E49B9 File Offset: 0x004E2BB9
		public static void AddStartCondition(FlatBufferBuilder builder, Offset<IConditionGroup> startConditionOffset)
		{
			builder.AddOffset(1, startConditionOffset.Value, 0);
		}

		// Token: 0x06023950 RID: 145744 RVA: 0x004E49C9 File Offset: 0x004E2BC9
		public static void AddEndCondition(FlatBufferBuilder builder, Offset<IConditionGroup> endConditionOffset)
		{
			builder.AddOffset(2, endConditionOffset.Value, 0);
		}

		// Token: 0x06023951 RID: 145745 RVA: 0x004E49D9 File Offset: 0x004E2BD9
		public static void AddEntityBatchRefreshType(FlatBufferBuilder builder, TEntityBatchRefresh entityBatchRefreshType)
		{
			builder.AddByte(3, (byte)entityBatchRefreshType, 0);
		}

		// Token: 0x06023952 RID: 145746 RVA: 0x004E49E4 File Offset: 0x004E2BE4
		public static void AddEntityBatchRefresh(FlatBufferBuilder builder, int entityBatchRefreshOffset)
		{
			builder.AddOffset(4, entityBatchRefreshOffset, 0);
		}

		// Token: 0x06023953 RID: 145747 RVA: 0x004E49EF File Offset: 0x004E2BEF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06023954 RID: 145748 RVA: 0x004E49FA File Offset: 0x004E2BFA
		public static Offset<IEntityBatchRefreshComponent> EndIEntityBatchRefreshComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBatchRefreshComponent>(builder.EndTable());
		}

		// Token: 0x06023955 RID: 145749 RVA: 0x004E4A08 File Offset: 0x004E2C08
		public IEntityBatchRefreshComponentT UnPack()
		{
			IEntityBatchRefreshComponentT entityBatchRefreshComponentT = new IEntityBatchRefreshComponentT();
			this.UnPackTo(entityBatchRefreshComponentT);
			return entityBatchRefreshComponentT;
		}

		// Token: 0x06023956 RID: 145750 RVA: 0x004E4A24 File Offset: 0x004E2C24
		public void UnPackTo(IEntityBatchRefreshComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.StartCondition = ((this.StartCondition != null) ? this.StartCondition.Value.UnPack() : null);
			_o.EndCondition = ((this.EndCondition != null) ? this.EndCondition.Value.UnPack() : null);
			_o.EntityBatchRefresh = new TEntityBatchRefreshUnion();
			_o.EntityBatchRefresh.Type = this.EntityBatchRefreshType;
			switch (this.EntityBatchRefreshType)
			{
			case TEntityBatchRefresh.IRandomBatchPoolRefresh:
				_o.EntityBatchRefresh.Value = ((this.EntityBatchRefresh<IRandomBatchPoolRefresh>() != null) ? this.EntityBatchRefresh<IRandomBatchPoolRefresh>().Value.UnPack() : null);
				break;
			case TEntityBatchRefresh.IRandomBatchRefresh:
				_o.EntityBatchRefresh.Value = ((this.EntityBatchRefresh<IRandomBatchRefresh>() != null) ? this.EntityBatchRefresh<IRandomBatchRefresh>().Value.UnPack() : null);
				break;
			case TEntityBatchRefresh.ISequenceBatchRefresh:
				_o.EntityBatchRefresh.Value = ((this.EntityBatchRefresh<ISequenceBatchRefresh>() != null) ? this.EntityBatchRefresh<ISequenceBatchRefresh>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023957 RID: 145751 RVA: 0x004E4B8C File Offset: 0x004E2D8C
		public static Offset<IEntityBatchRefreshComponent> Pack(FlatBufferBuilder builder, IEntityBatchRefreshComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityBatchRefreshComponent>);
			}
			Offset<IConditionGroup> startConditionOffset = (_o.StartCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.StartCondition);
			Offset<IConditionGroup> endConditionOffset = (_o.EndCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.EndCondition);
			TEntityBatchRefresh entityBatchRefresh_type = (_o.EntityBatchRefresh == null) ? TEntityBatchRefresh.NONE : _o.EntityBatchRefresh.Type;
			int entityBatchRefreshOffset = (_o.EntityBatchRefresh == null) ? 0 : TEntityBatchRefreshUnion.Pack(builder, _o.EntityBatchRefresh);
			return IEntityBatchRefreshComponent.CreateIEntityBatchRefreshComponent(builder, _o.Disabled, startConditionOffset, endConditionOffset, entityBatchRefresh_type, entityBatchRefreshOffset, _o.NullMask);
		}

		// Token: 0x0400EDF6 RID: 60918
		private Table __p;
	}
}
