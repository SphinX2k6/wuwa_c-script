using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F0B RID: 16139
	public struct IListenToEvent : IFlatbufferObject
	{
		// Token: 0x17006FF1 RID: 28657
		// (get) Token: 0x06016D94 RID: 93588 RVA: 0x0034B632 File Offset: 0x00349832
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016D95 RID: 93589 RVA: 0x0034B63F File Offset: 0x0034983F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016D96 RID: 93590 RVA: 0x0034B648 File Offset: 0x00349848
		public static IListenToEvent GetRootAsIListenToEvent(ByteBuffer _bb)
		{
			return IListenToEvent.GetRootAsIListenToEvent(_bb, default(IListenToEvent));
		}

		// Token: 0x06016D97 RID: 93591 RVA: 0x0034B664 File Offset: 0x00349864
		public static IListenToEvent GetRootAsIListenToEvent(ByteBuffer _bb, IListenToEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016D98 RID: 93592 RVA: 0x0034B681 File Offset: 0x00349881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016D99 RID: 93593 RVA: 0x0034B690 File Offset: 0x00349890
		public IListenToEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FF2 RID: 28658
		// (get) Token: 0x06016D9A RID: 93594 RVA: 0x0034B6A0 File Offset: 0x003498A0
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

		// Token: 0x17006FF3 RID: 28659
		// (get) Token: 0x06016D9B RID: 93595 RVA: 0x0034B6DC File Offset: 0x003498DC
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

		// Token: 0x17006FF4 RID: 28660
		// (get) Token: 0x06016D9C RID: 93596 RVA: 0x0034B73C File Offset: 0x0034993C
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

		// Token: 0x06016D9D RID: 93597 RVA: 0x0034B778 File Offset: 0x00349978
		public TTable? EventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016D9E RID: 93598 RVA: 0x0034B7C0 File Offset: 0x003499C0
		public ICommonEventEntityStateChange EventTypeAsICommonEventEntityStateChange()
		{
			return this.EventType<ICommonEventEntityStateChange>().Value;
		}

		// Token: 0x06016D9F RID: 93599 RVA: 0x0034B7DC File Offset: 0x003499DC
		public ICommonEventVarValueChange EventTypeAsICommonEventVarValueChange()
		{
			return this.EventType<ICommonEventVarValueChange>().Value;
		}

		// Token: 0x06016DA0 RID: 93600 RVA: 0x0034B7F7 File Offset: 0x003499F7
		public static Offset<IListenToEvent> CreateIListenToEvent(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TCommonEventType EventType_type = TCommonEventType.NONE, int EventTypeOffset = 0)
		{
			builder.StartTable(4);
			IListenToEvent.AddEventType(builder, EventTypeOffset);
			IListenToEvent.AddPreConditions(builder, PreConditionsOffset);
			IListenToEvent.AddEventTypeType(builder, EventType_type);
			IListenToEvent.AddType(builder, Type);
			return IListenToEvent.EndIListenToEvent(builder);
		}

		// Token: 0x06016DA1 RID: 93601 RVA: 0x0034B823 File Offset: 0x00349A23
		public static void StartIListenToEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016DA2 RID: 93602 RVA: 0x0034B82C File Offset: 0x00349A2C
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016DA3 RID: 93603 RVA: 0x0034B837 File Offset: 0x00349A37
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016DA4 RID: 93604 RVA: 0x0034B847 File Offset: 0x00349A47
		public static void AddEventTypeType(FlatBufferBuilder builder, TCommonEventType eventTypeType)
		{
			builder.AddByte(2, (byte)eventTypeType, 0);
		}

		// Token: 0x06016DA5 RID: 93605 RVA: 0x0034B852 File Offset: 0x00349A52
		public static void AddEventType(FlatBufferBuilder builder, int eventTypeOffset)
		{
			builder.AddOffset(3, eventTypeOffset, 0);
		}

		// Token: 0x06016DA6 RID: 93606 RVA: 0x0034B85D File Offset: 0x00349A5D
		public static Offset<IListenToEvent> EndIListenToEvent(FlatBufferBuilder builder)
		{
			return new Offset<IListenToEvent>(builder.EndTable());
		}

		// Token: 0x06016DA7 RID: 93607 RVA: 0x0034B86C File Offset: 0x00349A6C
		public IListenToEventT UnPack()
		{
			IListenToEventT listenToEventT = new IListenToEventT();
			this.UnPackTo(listenToEventT);
			return listenToEventT;
		}

		// Token: 0x06016DA8 RID: 93608 RVA: 0x0034B888 File Offset: 0x00349A88
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

		// Token: 0x06016DA9 RID: 93609 RVA: 0x0034B96C File Offset: 0x00349B6C
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

		// Token: 0x0400B8E8 RID: 47336
		private Table __p;
	}
}
