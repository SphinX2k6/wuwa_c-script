using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050FC RID: 20732
	public struct IDynamicSpawnMonsterConfig : IFlatbufferObject
	{
		// Token: 0x170096FF RID: 38655
		// (get) Token: 0x06021639 RID: 136761 RVA: 0x004A2EA3 File Offset: 0x004A10A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602163A RID: 136762 RVA: 0x004A2EB0 File Offset: 0x004A10B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602163B RID: 136763 RVA: 0x004A2EB8 File Offset: 0x004A10B8
		public static IDynamicSpawnMonsterConfig GetRootAsIDynamicSpawnMonsterConfig(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterConfig.GetRootAsIDynamicSpawnMonsterConfig(_bb, default(IDynamicSpawnMonsterConfig));
		}

		// Token: 0x0602163C RID: 136764 RVA: 0x004A2ED4 File Offset: 0x004A10D4
		public static IDynamicSpawnMonsterConfig GetRootAsIDynamicSpawnMonsterConfig(ByteBuffer _bb, IDynamicSpawnMonsterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602163D RID: 136765 RVA: 0x004A2EF1 File Offset: 0x004A10F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602163E RID: 136766 RVA: 0x004A2F00 File Offset: 0x004A1100
		public IDynamicSpawnMonsterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009700 RID: 38656
		// (get) Token: 0x0602163F RID: 136767 RVA: 0x004A2F10 File Offset: 0x004A1110
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

		// Token: 0x17009701 RID: 38657
		// (get) Token: 0x06021640 RID: 136768 RVA: 0x004A2F4C File Offset: 0x004A114C
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

		// Token: 0x17009702 RID: 38658
		// (get) Token: 0x06021641 RID: 136769 RVA: 0x004A2F8C File Offset: 0x004A118C
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

		// Token: 0x06021642 RID: 136770 RVA: 0x004A2FC8 File Offset: 0x004A11C8
		public TTable? CompleteCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021643 RID: 136771 RVA: 0x004A3010 File Offset: 0x004A1210
		public IAllKillCondition CompleteConditionAsIAllKillCondition()
		{
			return this.CompleteCondition<IAllKillCondition>().Value;
		}

		// Token: 0x06021644 RID: 136772 RVA: 0x004A302C File Offset: 0x004A122C
		public IDurationCondition CompleteConditionAsIDurationCondition()
		{
			return this.CompleteCondition<IDurationCondition>().Value;
		}

		// Token: 0x06021645 RID: 136773 RVA: 0x004A3048 File Offset: 0x004A1248
		public IQuantityRefillCondition CompleteConditionAsIQuantityRefillCondition()
		{
			return this.CompleteCondition<IQuantityRefillCondition>().Value;
		}

		// Token: 0x17009703 RID: 38659
		// (get) Token: 0x06021646 RID: 136774 RVA: 0x004A3064 File Offset: 0x004A1264
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

		// Token: 0x17009704 RID: 38660
		// (get) Token: 0x06021647 RID: 136775 RVA: 0x004A30C4 File Offset: 0x004A12C4
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

		// Token: 0x17009705 RID: 38661
		// (get) Token: 0x06021648 RID: 136776 RVA: 0x004A3108 File Offset: 0x004A1308
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

		// Token: 0x17009706 RID: 38662
		// (get) Token: 0x06021649 RID: 136777 RVA: 0x004A3168 File Offset: 0x004A1368
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

		// Token: 0x17009707 RID: 38663
		// (get) Token: 0x0602164A RID: 136778 RVA: 0x004A31C8 File Offset: 0x004A13C8
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

		// Token: 0x0602164B RID: 136779 RVA: 0x004A3208 File Offset: 0x004A1408
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

		// Token: 0x0602164C RID: 136780 RVA: 0x004A3268 File Offset: 0x004A1468
		public static void StartIDynamicSpawnMonsterConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602164D RID: 136781 RVA: 0x004A3272 File Offset: 0x004A1472
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602164E RID: 136782 RVA: 0x004A327D File Offset: 0x004A147D
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x0602164F RID: 136783 RVA: 0x004A3290 File Offset: 0x004A1490
		public static void AddCompleteConditionType(FlatBufferBuilder builder, TSpawnMonsterCompleteCondition completeConditionType)
		{
			builder.AddByte(2, (byte)completeConditionType, 0);
		}

		// Token: 0x06021650 RID: 136784 RVA: 0x004A329B File Offset: 0x004A149B
		public static void AddCompleteCondition(FlatBufferBuilder builder, int completeConditionOffset)
		{
			builder.AddOffset(3, completeConditionOffset, 0);
		}

		// Token: 0x06021651 RID: 136785 RVA: 0x004A32A6 File Offset: 0x004A14A6
		public static void AddPreCondition(FlatBufferBuilder builder, Offset<ISpawnMonsterPreDependOnPreceding> preConditionOffset)
		{
			builder.AddOffset(4, preConditionOffset.Value, 0);
		}

		// Token: 0x06021652 RID: 136786 RVA: 0x004A32B6 File Offset: 0x004A14B6
		public static void AddInterval(FlatBufferBuilder builder, float interval)
		{
			builder.AddFloat(5, interval, 0.0);
		}

		// Token: 0x06021653 RID: 136787 RVA: 0x004A32C9 File Offset: 0x004A14C9
		public static void AddMonsterChooseType(FlatBufferBuilder builder, Offset<IRandomPoolChoose> monsterChooseTypeOffset)
		{
			builder.AddOffset(6, monsterChooseTypeOffset.Value, 0);
		}

		// Token: 0x06021654 RID: 136788 RVA: 0x004A32D9 File Offset: 0x004A14D9
		public static void AddPointChooseType(FlatBufferBuilder builder, Offset<ISpawnMonsterPoint> pointChooseTypeOffset)
		{
			builder.AddOffset(7, pointChooseTypeOffset.Value, 0);
		}

		// Token: 0x06021655 RID: 136789 RVA: 0x004A32E9 File Offset: 0x004A14E9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06021656 RID: 136790 RVA: 0x004A32F4 File Offset: 0x004A14F4
		public static Offset<IDynamicSpawnMonsterConfig> EndIDynamicSpawnMonsterConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterConfig>(builder.EndTable());
		}

		// Token: 0x06021657 RID: 136791 RVA: 0x004A3304 File Offset: 0x004A1504
		public IDynamicSpawnMonsterConfigT UnPack()
		{
			IDynamicSpawnMonsterConfigT dynamicSpawnMonsterConfigT = new IDynamicSpawnMonsterConfigT();
			this.UnPackTo(dynamicSpawnMonsterConfigT);
			return dynamicSpawnMonsterConfigT;
		}

		// Token: 0x06021658 RID: 136792 RVA: 0x004A3320 File Offset: 0x004A1520
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

		// Token: 0x06021659 RID: 136793 RVA: 0x004A34D4 File Offset: 0x004A16D4
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

		// Token: 0x0400E15F RID: 57695
		private Table __p;
	}
}
