using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005159 RID: 20825
	public struct IEntityBatchRefreshComponent : IFlatbufferObject
	{
		// Token: 0x170097E8 RID: 38888
		// (get) Token: 0x060219E9 RID: 137705 RVA: 0x004AA758 File Offset: 0x004A8958
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060219EA RID: 137706 RVA: 0x004AA765 File Offset: 0x004A8965
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060219EB RID: 137707 RVA: 0x004AA76C File Offset: 0x004A896C
		public static IEntityBatchRefreshComponent GetRootAsIEntityBatchRefreshComponent(ByteBuffer _bb)
		{
			return IEntityBatchRefreshComponent.GetRootAsIEntityBatchRefreshComponent(_bb, default(IEntityBatchRefreshComponent));
		}

		// Token: 0x060219EC RID: 137708 RVA: 0x004AA788 File Offset: 0x004A8988
		public static IEntityBatchRefreshComponent GetRootAsIEntityBatchRefreshComponent(ByteBuffer _bb, IEntityBatchRefreshComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060219ED RID: 137709 RVA: 0x004AA7A5 File Offset: 0x004A89A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060219EE RID: 137710 RVA: 0x004AA7B4 File Offset: 0x004A89B4
		public IEntityBatchRefreshComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097E9 RID: 38889
		// (get) Token: 0x060219EF RID: 137711 RVA: 0x004AA7C4 File Offset: 0x004A89C4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170097EA RID: 38890
		// (get) Token: 0x060219F0 RID: 137712 RVA: 0x004AA804 File Offset: 0x004A8A04
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

		// Token: 0x170097EB RID: 38891
		// (get) Token: 0x060219F1 RID: 137713 RVA: 0x004AA864 File Offset: 0x004A8A64
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

		// Token: 0x170097EC RID: 38892
		// (get) Token: 0x060219F2 RID: 137714 RVA: 0x004AA8C4 File Offset: 0x004A8AC4
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

		// Token: 0x060219F3 RID: 137715 RVA: 0x004AA904 File Offset: 0x004A8B04
		public TTable? EntityBatchRefresh<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060219F4 RID: 137716 RVA: 0x004AA94C File Offset: 0x004A8B4C
		public IRandomBatchPoolRefresh EntityBatchRefreshAsIRandomBatchPoolRefresh()
		{
			return this.EntityBatchRefresh<IRandomBatchPoolRefresh>().Value;
		}

		// Token: 0x060219F5 RID: 137717 RVA: 0x004AA968 File Offset: 0x004A8B68
		public IRandomBatchRefresh EntityBatchRefreshAsIRandomBatchRefresh()
		{
			return this.EntityBatchRefresh<IRandomBatchRefresh>().Value;
		}

		// Token: 0x060219F6 RID: 137718 RVA: 0x004AA984 File Offset: 0x004A8B84
		public ISequenceBatchRefresh EntityBatchRefreshAsISequenceBatchRefresh()
		{
			return this.EntityBatchRefresh<ISequenceBatchRefresh>().Value;
		}

		// Token: 0x170097ED RID: 38893
		// (get) Token: 0x060219F7 RID: 137719 RVA: 0x004AA9A0 File Offset: 0x004A8BA0
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

		// Token: 0x060219F8 RID: 137720 RVA: 0x004AA9DD File Offset: 0x004A8BDD
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

		// Token: 0x060219F9 RID: 137721 RVA: 0x004AAA19 File Offset: 0x004A8C19
		public static void StartIEntityBatchRefreshComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060219FA RID: 137722 RVA: 0x004AAA22 File Offset: 0x004A8C22
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060219FB RID: 137723 RVA: 0x004AAA2D File Offset: 0x004A8C2D
		public static void AddStartCondition(FlatBufferBuilder builder, Offset<IConditionGroup> startConditionOffset)
		{
			builder.AddOffset(1, startConditionOffset.Value, 0);
		}

		// Token: 0x060219FC RID: 137724 RVA: 0x004AAA3D File Offset: 0x004A8C3D
		public static void AddEndCondition(FlatBufferBuilder builder, Offset<IConditionGroup> endConditionOffset)
		{
			builder.AddOffset(2, endConditionOffset.Value, 0);
		}

		// Token: 0x060219FD RID: 137725 RVA: 0x004AAA4D File Offset: 0x004A8C4D
		public static void AddEntityBatchRefreshType(FlatBufferBuilder builder, TEntityBatchRefresh entityBatchRefreshType)
		{
			builder.AddByte(3, (byte)entityBatchRefreshType, 0);
		}

		// Token: 0x060219FE RID: 137726 RVA: 0x004AAA58 File Offset: 0x004A8C58
		public static void AddEntityBatchRefresh(FlatBufferBuilder builder, int entityBatchRefreshOffset)
		{
			builder.AddOffset(4, entityBatchRefreshOffset, 0);
		}

		// Token: 0x060219FF RID: 137727 RVA: 0x004AAA63 File Offset: 0x004A8C63
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06021A00 RID: 137728 RVA: 0x004AAA6E File Offset: 0x004A8C6E
		public static Offset<IEntityBatchRefreshComponent> EndIEntityBatchRefreshComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBatchRefreshComponent>(builder.EndTable());
		}

		// Token: 0x06021A01 RID: 137729 RVA: 0x004AAA7C File Offset: 0x004A8C7C
		public IEntityBatchRefreshComponentT UnPack()
		{
			IEntityBatchRefreshComponentT entityBatchRefreshComponentT = new IEntityBatchRefreshComponentT();
			this.UnPackTo(entityBatchRefreshComponentT);
			return entityBatchRefreshComponentT;
		}

		// Token: 0x06021A02 RID: 137730 RVA: 0x004AAA98 File Offset: 0x004A8C98
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

		// Token: 0x06021A03 RID: 137731 RVA: 0x004AAC00 File Offset: 0x004A8E00
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

		// Token: 0x0400E1F9 RID: 57849
		private Table __p;
	}
}
