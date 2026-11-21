using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005661 RID: 22113
	public struct IDynamicSpawnMonsterConfig : IFlatbufferObject
	{
		// Token: 0x17009EEC RID: 40684
		// (get) Token: 0x0602358D RID: 144781 RVA: 0x004DCE2F File Offset: 0x004DB02F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602358E RID: 144782 RVA: 0x004DCE3C File Offset: 0x004DB03C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602358F RID: 144783 RVA: 0x004DCE44 File Offset: 0x004DB044
		public static IDynamicSpawnMonsterConfig GetRootAsIDynamicSpawnMonsterConfig(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterConfig.GetRootAsIDynamicSpawnMonsterConfig(_bb, default(IDynamicSpawnMonsterConfig));
		}

		// Token: 0x06023590 RID: 144784 RVA: 0x004DCE60 File Offset: 0x004DB060
		public static IDynamicSpawnMonsterConfig GetRootAsIDynamicSpawnMonsterConfig(ByteBuffer _bb, IDynamicSpawnMonsterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023591 RID: 144785 RVA: 0x004DCE7D File Offset: 0x004DB07D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023592 RID: 144786 RVA: 0x004DCE8C File Offset: 0x004DB08C
		public IDynamicSpawnMonsterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EED RID: 40685
		// (get) Token: 0x06023593 RID: 144787 RVA: 0x004DCE9C File Offset: 0x004DB09C
		public int Id
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

		// Token: 0x17009EEE RID: 40686
		// (get) Token: 0x06023594 RID: 144788 RVA: 0x004DCED8 File Offset: 0x004DB0D8
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009EEF RID: 40687
		// (get) Token: 0x06023595 RID: 144789 RVA: 0x004DCF18 File Offset: 0x004DB118
		public TSpawnMonsterCompleteCondition CompleteConditionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TSpawnMonsterCompleteCondition.NONE;
				}
				return (TSpawnMonsterCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023596 RID: 144790 RVA: 0x004DCF54 File Offset: 0x004DB154
		public TTable? CompleteCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023597 RID: 144791 RVA: 0x004DCF9C File Offset: 0x004DB19C
		public IAllKillCondition CompleteConditionAsIAllKillCondition()
		{
			return this.CompleteCondition<IAllKillCondition>().Value;
		}

		// Token: 0x06023598 RID: 144792 RVA: 0x004DCFB8 File Offset: 0x004DB1B8
		public IDurationCondition CompleteConditionAsIDurationCondition()
		{
			return this.CompleteCondition<IDurationCondition>().Value;
		}

		// Token: 0x06023599 RID: 144793 RVA: 0x004DCFD4 File Offset: 0x004DB1D4
		public IQuantityRefillCondition CompleteConditionAsIQuantityRefillCondition()
		{
			return this.CompleteCondition<IQuantityRefillCondition>().Value;
		}

		// Token: 0x17009EF0 RID: 40688
		// (get) Token: 0x0602359A RID: 144794 RVA: 0x004DCFF0 File Offset: 0x004DB1F0
		public ISpawnMonsterPreDependOnPreceding? PreCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ISpawnMonsterPreDependOnPreceding?(default(ISpawnMonsterPreDependOnPreceding).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009EF1 RID: 40689
		// (get) Token: 0x0602359B RID: 144795 RVA: 0x004DD050 File Offset: 0x004DB250
		public float Interval
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009EF2 RID: 40690
		// (get) Token: 0x0602359C RID: 144796 RVA: 0x004DD094 File Offset: 0x004DB294
		public IRandomPoolChoose? MonsterChooseType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IRandomPoolChoose?(default(IRandomPoolChoose).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009EF3 RID: 40691
		// (get) Token: 0x0602359D RID: 144797 RVA: 0x004DD0F4 File Offset: 0x004DB2F4
		public ISpawnMonsterPoint? PointChooseType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ISpawnMonsterPoint?(default(ISpawnMonsterPoint).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009EF4 RID: 40692
		// (get) Token: 0x0602359E RID: 144798 RVA: 0x004DD154 File Offset: 0x004DB354
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602359F RID: 144799 RVA: 0x004DD194 File Offset: 0x004DB394
		public static Offset<IDynamicSpawnMonsterConfig> CreateIDynamicSpawnMonsterConfig(FlatBufferBuilder builder, int Id = 0, float DelayTime = 0f, TSpawnMonsterCompleteCondition CompleteCondition_type = TSpawnMonsterCompleteCondition.NONE, int CompleteConditionOffset = 0, Offset<ISpawnMonsterPreDependOnPreceding> PreConditionOffset = default(Offset<ISpawnMonsterPreDependOnPreceding>), float Interval = 0f, Offset<IRandomPoolChoose> MonsterChooseTypeOffset = default(Offset<IRandomPoolChoose>), Offset<ISpawnMonsterPoint> PointChooseTypeOffset = default(Offset<ISpawnMonsterPoint>), byte NullMask = 0)
		{
			builder.StartTable(9);
			IDynamicSpawnMonsterConfig.AddPointChooseType(builder, PointChooseTypeOffset);
			IDynamicSpawnMonsterConfig.AddMonsterChooseType(builder, MonsterChooseTypeOffset);
			IDynamicSpawnMonsterConfig.AddInterval(builder, Interval);
			IDynamicSpawnMonsterConfig.AddPreCondition(builder, PreConditionOffset);
			IDynamicSpawnMonsterConfig.AddCompleteCondition(builder, CompleteConditionOffset);
			IDynamicSpawnMonsterConfig.AddDelayTime(builder, DelayTime);
			IDynamicSpawnMonsterConfig.AddId(builder, Id);
			IDynamicSpawnMonsterConfig.AddNullMask(builder, NullMask);
			IDynamicSpawnMonsterConfig.AddCompleteConditionType(builder, CompleteCondition_type);
			return IDynamicSpawnMonsterConfig.EndIDynamicSpawnMonsterConfig(builder);
		}

		// Token: 0x060235A0 RID: 144800 RVA: 0x004DD1F4 File Offset: 0x004DB3F4
		public static void StartIDynamicSpawnMonsterConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060235A1 RID: 144801 RVA: 0x004DD1FE File Offset: 0x004DB3FE
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060235A2 RID: 144802 RVA: 0x004DD209 File Offset: 0x004DB409
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x060235A3 RID: 144803 RVA: 0x004DD21C File Offset: 0x004DB41C
		public static void AddCompleteConditionType(FlatBufferBuilder builder, TSpawnMonsterCompleteCondition completeConditionType)
		{
			builder.AddByte(2, (byte)completeConditionType, 0);
		}

		// Token: 0x060235A4 RID: 144804 RVA: 0x004DD227 File Offset: 0x004DB427
		public static void AddCompleteCondition(FlatBufferBuilder builder, int completeConditionOffset)
		{
			builder.AddOffset(3, completeConditionOffset, 0);
		}

		// Token: 0x060235A5 RID: 144805 RVA: 0x004DD232 File Offset: 0x004DB432
		public static void AddPreCondition(FlatBufferBuilder builder, Offset<ISpawnMonsterPreDependOnPreceding> preConditionOffset)
		{
			builder.AddOffset(4, preConditionOffset.Value, 0);
		}

		// Token: 0x060235A6 RID: 144806 RVA: 0x004DD242 File Offset: 0x004DB442
		public static void AddInterval(FlatBufferBuilder builder, float interval)
		{
			builder.AddFloat(5, interval, 0.0);
		}

		// Token: 0x060235A7 RID: 144807 RVA: 0x004DD255 File Offset: 0x004DB455
		public static void AddMonsterChooseType(FlatBufferBuilder builder, Offset<IRandomPoolChoose> monsterChooseTypeOffset)
		{
			builder.AddOffset(6, monsterChooseTypeOffset.Value, 0);
		}

		// Token: 0x060235A8 RID: 144808 RVA: 0x004DD265 File Offset: 0x004DB465
		public static void AddPointChooseType(FlatBufferBuilder builder, Offset<ISpawnMonsterPoint> pointChooseTypeOffset)
		{
			builder.AddOffset(7, pointChooseTypeOffset.Value, 0);
		}

		// Token: 0x060235A9 RID: 144809 RVA: 0x004DD275 File Offset: 0x004DB475
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060235AA RID: 144810 RVA: 0x004DD280 File Offset: 0x004DB480
		public static Offset<IDynamicSpawnMonsterConfig> EndIDynamicSpawnMonsterConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterConfig>(builder.EndTable());
		}

		// Token: 0x060235AB RID: 144811 RVA: 0x004DD290 File Offset: 0x004DB490
		public IDynamicSpawnMonsterConfigT UnPack()
		{
			IDynamicSpawnMonsterConfigT dynamicSpawnMonsterConfigT = new IDynamicSpawnMonsterConfigT();
			this.UnPackTo(dynamicSpawnMonsterConfigT);
			return dynamicSpawnMonsterConfigT;
		}

		// Token: 0x060235AC RID: 144812 RVA: 0x004DD2AC File Offset: 0x004DB4AC
		public void UnPackTo(IDynamicSpawnMonsterConfigT _o)
		{
			_o.Id = this.Id;
			_o.DelayTime = this.DelayTime;
			_o.CompleteCondition = new TSpawnMonsterCompleteConditionUnion();
			_o.CompleteCondition.Type = this.CompleteConditionType;
			switch (this.CompleteConditionType)
			{
			case TSpawnMonsterCompleteCondition.IAllKillCondition:
				_o.CompleteCondition.Value = ((this.CompleteCondition<IAllKillCondition>() != null) ? this.CompleteCondition<IAllKillCondition>().Value.UnPack() : null);
				break;
			case TSpawnMonsterCompleteCondition.IDurationCondition:
				_o.CompleteCondition.Value = ((this.CompleteCondition<IDurationCondition>() != null) ? this.CompleteCondition<IDurationCondition>().Value.UnPack() : null);
				break;
			case TSpawnMonsterCompleteCondition.IQuantityRefillCondition:
				_o.CompleteCondition.Value = ((this.CompleteCondition<IQuantityRefillCondition>() != null) ? this.CompleteCondition<IQuantityRefillCondition>().Value.UnPack() : null);
				break;
			}
			_o.PreCondition = ((this.PreCondition != null) ? this.PreCondition.Value.UnPack() : null);
			_o.Interval = this.Interval;
			_o.MonsterChooseType = ((this.MonsterChooseType != null) ? this.MonsterChooseType.Value.UnPack() : null);
			_o.PointChooseType = ((this.PointChooseType != null) ? this.PointChooseType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060235AD RID: 144813 RVA: 0x004DD460 File Offset: 0x004DB660
		public static Offset<IDynamicSpawnMonsterConfig> Pack(FlatBufferBuilder builder, IDynamicSpawnMonsterConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSpawnMonsterConfig>);
			}
			TSpawnMonsterCompleteCondition completeCondition_type = (_o.CompleteCondition == null) ? TSpawnMonsterCompleteCondition.NONE : _o.CompleteCondition.Type;
			int completeConditionOffset = (_o.CompleteCondition == null) ? 0 : TSpawnMonsterCompleteConditionUnion.Pack(builder, _o.CompleteCondition);
			Offset<ISpawnMonsterPreDependOnPreceding> preConditionOffset = (_o.PreCondition == null) ? default(Offset<ISpawnMonsterPreDependOnPreceding>) : ISpawnMonsterPreDependOnPreceding.Pack(builder, _o.PreCondition);
			Offset<IRandomPoolChoose> monsterChooseTypeOffset = (_o.MonsterChooseType == null) ? default(Offset<IRandomPoolChoose>) : IRandomPoolChoose.Pack(builder, _o.MonsterChooseType);
			Offset<ISpawnMonsterPoint> pointChooseTypeOffset = (_o.PointChooseType == null) ? default(Offset<ISpawnMonsterPoint>) : ISpawnMonsterPoint.Pack(builder, _o.PointChooseType);
			return IDynamicSpawnMonsterConfig.CreateIDynamicSpawnMonsterConfig(builder, _o.Id, _o.DelayTime, completeCondition_type, completeConditionOffset, preConditionOffset, _o.Interval, monsterChooseTypeOffset, pointChooseTypeOffset, _o.NullMask);
		}

		// Token: 0x0400ED5C RID: 60764
		private Table __p;
	}
}
