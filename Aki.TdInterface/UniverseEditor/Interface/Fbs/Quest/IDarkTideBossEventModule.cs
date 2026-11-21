using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E4 RID: 16868
	public struct IDarkTideBossEventModule : IFlatbufferObject
	{
		// Token: 0x170072EB RID: 29419
		// (get) Token: 0x06017678 RID: 95864 RVA: 0x003584F5 File Offset: 0x003566F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017679 RID: 95865 RVA: 0x00358502 File Offset: 0x00356702
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601767A RID: 95866 RVA: 0x0035850C File Offset: 0x0035670C
		public static IDarkTideBossEventModule GetRootAsIDarkTideBossEventModule(ByteBuffer _bb)
		{
			return IDarkTideBossEventModule.GetRootAsIDarkTideBossEventModule(_bb, default(IDarkTideBossEventModule));
		}

		// Token: 0x0601767B RID: 95867 RVA: 0x00358528 File Offset: 0x00356728
		public static IDarkTideBossEventModule GetRootAsIDarkTideBossEventModule(ByteBuffer _bb, IDarkTideBossEventModule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601767C RID: 95868 RVA: 0x00358545 File Offset: 0x00356745
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601767D RID: 95869 RVA: 0x00358554 File Offset: 0x00356754
		public IDarkTideBossEventModule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072EC RID: 29420
		// (get) Token: 0x0601767E RID: 95870 RVA: 0x00358564 File Offset: 0x00356764
		public EDarkTideModuleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDarkTideModuleType.BossEvent;
				}
				return (EDarkTideModuleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170072ED RID: 29421
		// (get) Token: 0x0601767F RID: 95871 RVA: 0x003585A0 File Offset: 0x003567A0
		public TDarkTideBossEvent EventTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TDarkTideBossEvent.NONE;
				}
				return (TDarkTideBossEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017680 RID: 95872 RVA: 0x003585DC File Offset: 0x003567DC
		public TTable? EventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017681 RID: 95873 RVA: 0x00358620 File Offset: 0x00356820
		public IDarkTideChonglouTrialBossEvent EventTypeAsIDarkTideChonglouTrialBossEvent()
		{
			return this.EventType<IDarkTideChonglouTrialBossEvent>().Value;
		}

		// Token: 0x06017682 RID: 95874 RVA: 0x0035863C File Offset: 0x0035683C
		public IDarkTideHaiweixiaArenaBossEvent EventTypeAsIDarkTideHaiweixiaArenaBossEvent()
		{
			return this.EventType<IDarkTideHaiweixiaArenaBossEvent>().Value;
		}

		// Token: 0x06017683 RID: 95875 RVA: 0x00358658 File Offset: 0x00356858
		public IDarkTideHecatePollutionBossEvent EventTypeAsIDarkTideHecatePollutionBossEvent()
		{
			return this.EventType<IDarkTideHecatePollutionBossEvent>().Value;
		}

		// Token: 0x06017684 RID: 95876 RVA: 0x00358674 File Offset: 0x00356874
		public IDarkTideMechaAssemblyBossEvent EventTypeAsIDarkTideMechaAssemblyBossEvent()
		{
			return this.EventType<IDarkTideMechaAssemblyBossEvent>().Value;
		}

		// Token: 0x06017685 RID: 95877 RVA: 0x00358690 File Offset: 0x00356890
		public IDarkTideWyvernPositionBossEvent EventTypeAsIDarkTideWyvernPositionBossEvent()
		{
			return this.EventType<IDarkTideWyvernPositionBossEvent>().Value;
		}

		// Token: 0x06017686 RID: 95878 RVA: 0x003586AC File Offset: 0x003568AC
		public IDarkTideXinjilemuChaseBossEvent EventTypeAsIDarkTideXinjilemuChaseBossEvent()
		{
			return this.EventType<IDarkTideXinjilemuChaseBossEvent>().Value;
		}

		// Token: 0x06017687 RID: 95879 RVA: 0x003586C7 File Offset: 0x003568C7
		public static Offset<IDarkTideBossEventModule> CreateIDarkTideBossEventModule(FlatBufferBuilder builder, EDarkTideModuleType Type = EDarkTideModuleType.BossEvent, TDarkTideBossEvent EventType_type = TDarkTideBossEvent.NONE, int EventTypeOffset = 0)
		{
			builder.StartTable(3);
			IDarkTideBossEventModule.AddEventType(builder, EventTypeOffset);
			IDarkTideBossEventModule.AddEventTypeType(builder, EventType_type);
			IDarkTideBossEventModule.AddType(builder, Type);
			return IDarkTideBossEventModule.EndIDarkTideBossEventModule(builder);
		}

		// Token: 0x06017688 RID: 95880 RVA: 0x003586EB File Offset: 0x003568EB
		public static void StartIDarkTideBossEventModule(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017689 RID: 95881 RVA: 0x003586F4 File Offset: 0x003568F4
		public static void AddType(FlatBufferBuilder builder, EDarkTideModuleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601768A RID: 95882 RVA: 0x003586FF File Offset: 0x003568FF
		public static void AddEventTypeType(FlatBufferBuilder builder, TDarkTideBossEvent eventTypeType)
		{
			builder.AddByte(1, (byte)eventTypeType, 0);
		}

		// Token: 0x0601768B RID: 95883 RVA: 0x0035870A File Offset: 0x0035690A
		public static void AddEventType(FlatBufferBuilder builder, int eventTypeOffset)
		{
			builder.AddOffset(2, eventTypeOffset, 0);
		}

		// Token: 0x0601768C RID: 95884 RVA: 0x00358715 File Offset: 0x00356915
		public static Offset<IDarkTideBossEventModule> EndIDarkTideBossEventModule(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideBossEventModule>(builder.EndTable());
		}

		// Token: 0x0601768D RID: 95885 RVA: 0x00358724 File Offset: 0x00356924
		public IDarkTideBossEventModuleT UnPack()
		{
			IDarkTideBossEventModuleT darkTideBossEventModuleT = new IDarkTideBossEventModuleT();
			this.UnPackTo(darkTideBossEventModuleT);
			return darkTideBossEventModuleT;
		}

		// Token: 0x0601768E RID: 95886 RVA: 0x00358740 File Offset: 0x00356940
		public void UnPackTo(IDarkTideBossEventModuleT _o)
		{
			_o.Type = this.Type;
			_o.EventType = new TDarkTideBossEventUnion();
			_o.EventType.Type = this.EventTypeType;
			switch (this.EventTypeType)
			{
			case TDarkTideBossEvent.IDarkTideChonglouTrialBossEvent:
				_o.EventType.Value = ((this.EventType<IDarkTideChonglouTrialBossEvent>() != null) ? this.EventType<IDarkTideChonglouTrialBossEvent>().Value.UnPack() : null);
				return;
			case TDarkTideBossEvent.IDarkTideHaiweixiaArenaBossEvent:
				_o.EventType.Value = ((this.EventType<IDarkTideHaiweixiaArenaBossEvent>() != null) ? this.EventType<IDarkTideHaiweixiaArenaBossEvent>().Value.UnPack() : null);
				return;
			case TDarkTideBossEvent.IDarkTideHecatePollutionBossEvent:
				_o.EventType.Value = ((this.EventType<IDarkTideHecatePollutionBossEvent>() != null) ? this.EventType<IDarkTideHecatePollutionBossEvent>().Value.UnPack() : null);
				return;
			case TDarkTideBossEvent.IDarkTideMechaAssemblyBossEvent:
				_o.EventType.Value = ((this.EventType<IDarkTideMechaAssemblyBossEvent>() != null) ? this.EventType<IDarkTideMechaAssemblyBossEvent>().Value.UnPack() : null);
				return;
			case TDarkTideBossEvent.IDarkTideWyvernPositionBossEvent:
				_o.EventType.Value = ((this.EventType<IDarkTideWyvernPositionBossEvent>() != null) ? this.EventType<IDarkTideWyvernPositionBossEvent>().Value.UnPack() : null);
				return;
			case TDarkTideBossEvent.IDarkTideXinjilemuChaseBossEvent:
				_o.EventType.Value = ((this.EventType<IDarkTideXinjilemuChaseBossEvent>() != null) ? this.EventType<IDarkTideXinjilemuChaseBossEvent>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601768F RID: 95887 RVA: 0x003588E8 File Offset: 0x00356AE8
		public static Offset<IDarkTideBossEventModule> Pack(FlatBufferBuilder builder, IDarkTideBossEventModuleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideBossEventModule>);
			}
			TDarkTideBossEvent eventType_type = (_o.EventType == null) ? TDarkTideBossEvent.NONE : _o.EventType.Type;
			int eventTypeOffset = (_o.EventType == null) ? 0 : TDarkTideBossEventUnion.Pack(builder, _o.EventType);
			return IDarkTideBossEventModule.CreateIDarkTideBossEventModule(builder, _o.Type, eventType_type, eventTypeOffset);
		}

		// Token: 0x0400C0B9 RID: 49337
		private Table __p;
	}
}
