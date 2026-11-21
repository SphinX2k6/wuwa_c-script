using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004349 RID: 17225
	public struct IListenToEvent : IFlatbufferObject
	{
		// Token: 0x170075E0 RID: 30176
		// (get) Token: 0x060183EB RID: 99307 RVA: 0x003747FE File Offset: 0x003729FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060183EC RID: 99308 RVA: 0x0037480B File Offset: 0x00372A0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060183ED RID: 99309 RVA: 0x00374814 File Offset: 0x00372A14
		public static IListenToEvent GetRootAsIListenToEvent(ByteBuffer _bb)
		{
			return IListenToEvent.GetRootAsIListenToEvent(_bb, default(IListenToEvent));
		}

		// Token: 0x060183EE RID: 99310 RVA: 0x00374830 File Offset: 0x00372A30
		public static IListenToEvent GetRootAsIListenToEvent(ByteBuffer _bb, IListenToEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060183EF RID: 99311 RVA: 0x0037484D File Offset: 0x00372A4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060183F0 RID: 99312 RVA: 0x0037485C File Offset: 0x00372A5C
		public IListenToEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075E1 RID: 30177
		// (get) Token: 0x060183F1 RID: 99313 RVA: 0x0037486C File Offset: 0x00372A6C
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170075E2 RID: 30178
		// (get) Token: 0x060183F2 RID: 99314 RVA: 0x003748A8 File Offset: 0x00372AA8
		public IConditionGroup? PreConditions
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

		// Token: 0x170075E3 RID: 30179
		// (get) Token: 0x060183F3 RID: 99315 RVA: 0x00374908 File Offset: 0x00372B08
		public TCommonEventType EventTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TCommonEventType.NONE;
				}
				return (TCommonEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060183F4 RID: 99316 RVA: 0x00374944 File Offset: 0x00372B44
		public TTable? EventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060183F5 RID: 99317 RVA: 0x0037498C File Offset: 0x00372B8C
		public ICommonEventEntityStateChange EventTypeAsICommonEventEntityStateChange()
		{
			return this.EventType<ICommonEventEntityStateChange>().Value;
		}

		// Token: 0x060183F6 RID: 99318 RVA: 0x003749A8 File Offset: 0x00372BA8
		public ICommonEventVarValueChange EventTypeAsICommonEventVarValueChange()
		{
			return this.EventType<ICommonEventVarValueChange>().Value;
		}

		// Token: 0x060183F7 RID: 99319 RVA: 0x003749C3 File Offset: 0x00372BC3
		public static Offset<IListenToEvent> CreateIListenToEvent(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TCommonEventType EventType_type = TCommonEventType.NONE, int EventTypeOffset = 0)
		{
			builder.StartTable(4);
			IListenToEvent.AddEventType(builder, EventTypeOffset);
			IListenToEvent.AddPreConditions(builder, PreConditionsOffset);
			IListenToEvent.AddEventTypeType(builder, EventType_type);
			IListenToEvent.AddType(builder, Type);
			return IListenToEvent.EndIListenToEvent(builder);
		}

		// Token: 0x060183F8 RID: 99320 RVA: 0x003749EF File Offset: 0x00372BEF
		public static void StartIListenToEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060183F9 RID: 99321 RVA: 0x003749F8 File Offset: 0x00372BF8
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060183FA RID: 99322 RVA: 0x00374A03 File Offset: 0x00372C03
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060183FB RID: 99323 RVA: 0x00374A13 File Offset: 0x00372C13
		public static void AddEventTypeType(FlatBufferBuilder builder, TCommonEventType eventTypeType)
		{
			builder.AddByte(2, (byte)eventTypeType, 0);
		}

		// Token: 0x060183FC RID: 99324 RVA: 0x00374A1E File Offset: 0x00372C1E
		public static void AddEventType(FlatBufferBuilder builder, int eventTypeOffset)
		{
			builder.AddOffset(3, eventTypeOffset, 0);
		}

		// Token: 0x060183FD RID: 99325 RVA: 0x00374A29 File Offset: 0x00372C29
		public static Offset<IListenToEvent> EndIListenToEvent(FlatBufferBuilder builder)
		{
			return new Offset<IListenToEvent>(builder.EndTable());
		}

		// Token: 0x060183FE RID: 99326 RVA: 0x00374A38 File Offset: 0x00372C38
		public IListenToEventT UnPack()
		{
			IListenToEventT listenToEventT = new IListenToEventT();
			this.UnPackTo(listenToEventT);
			return listenToEventT;
		}

		// Token: 0x060183FF RID: 99327 RVA: 0x00374A54 File Offset: 0x00372C54
		public void UnPackTo(IListenToEventT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.EventType = new TCommonEventTypeUnion();
			_o.EventType.Type = this.EventTypeType;
			TCommonEventType eventTypeType = this.EventTypeType;
			if (eventTypeType == TCommonEventType.ICommonEventEntityStateChange)
			{
				_o.EventType.Value = ((this.EventType<ICommonEventEntityStateChange>() != null) ? this.EventType<ICommonEventEntityStateChange>().Value.UnPack() : null);
				return;
			}
			if (eventTypeType != TCommonEventType.ICommonEventVarValueChange)
			{
				return;
			}
			_o.EventType.Value = ((this.EventType<ICommonEventVarValueChange>() != null) ? this.EventType<ICommonEventVarValueChange>().Value.UnPack() : null);
		}

		// Token: 0x06018400 RID: 99328 RVA: 0x00374B38 File Offset: 0x00372D38
		public static Offset<IListenToEvent> Pack(FlatBufferBuilder builder, IListenToEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IListenToEvent>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TCommonEventType eventType_type = (_o.EventType == null) ? TCommonEventType.NONE : _o.EventType.Type;
			int eventTypeOffset = (_o.EventType == null) ? 0 : TCommonEventTypeUnion.Pack(builder, _o.EventType);
			return IListenToEvent.CreateIListenToEvent(builder, _o.Type, preConditionsOffset, eventType_type, eventTypeOffset);
		}

		// Token: 0x0400C2C5 RID: 49861
		private Table __p;
	}
}
