using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E9B RID: 20123
	public struct IAnEvent : IFlatbufferObject
	{
		// Token: 0x1700904D RID: 36941
		// (get) Token: 0x0601FAAE RID: 129710 RVA: 0x00468DF7 File Offset: 0x00466FF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FAAF RID: 129711 RVA: 0x00468E04 File Offset: 0x00467004
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FAB0 RID: 129712 RVA: 0x00468E0C File Offset: 0x0046700C
		public static IAnEvent GetRootAsIAnEvent(ByteBuffer _bb)
		{
			return IAnEvent.GetRootAsIAnEvent(_bb, default(IAnEvent));
		}

		// Token: 0x0601FAB1 RID: 129713 RVA: 0x00468E28 File Offset: 0x00467028
		public static IAnEvent GetRootAsIAnEvent(ByteBuffer _bb, IAnEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FAB2 RID: 129714 RVA: 0x00468E45 File Offset: 0x00467045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FAB3 RID: 129715 RVA: 0x00468E54 File Offset: 0x00467054
		public IAnEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700904E RID: 36942
		// (get) Token: 0x0601FAB4 RID: 129716 RVA: 0x00468E64 File Offset: 0x00467064
		public ESceneItemSeqEventCbType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneItemSeqEventCbType.ANS;
				}
				return (ESceneItemSeqEventCbType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700904F RID: 36943
		// (get) Token: 0x0601FAB5 RID: 129717 RVA: 0x00468EA0 File Offset: 0x004670A0
		public string EventName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FAB6 RID: 129718 RVA: 0x00468ED7 File Offset: 0x004670D7
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601FAB7 RID: 129719 RVA: 0x00468EE6 File Offset: 0x004670E6
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009050 RID: 36944
		// (get) Token: 0x0601FAB8 RID: 129720 RVA: 0x00468EF4 File Offset: 0x004670F4
		public IActionInfo? Action
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601FAB9 RID: 129721 RVA: 0x00468F51 File Offset: 0x00467151
		public static Offset<IAnEvent> CreateIAnEvent(FlatBufferBuilder builder, ESceneItemSeqEventCbType Type = ESceneItemSeqEventCbType.ANS, StringOffset EventNameOffset = default(StringOffset), Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>))
		{
			builder.StartTable(3);
			IAnEvent.AddAction(builder, ActionOffset);
			IAnEvent.AddEventName(builder, EventNameOffset);
			IAnEvent.AddType(builder, Type);
			return IAnEvent.EndIAnEvent(builder);
		}

		// Token: 0x0601FABA RID: 129722 RVA: 0x00468F75 File Offset: 0x00467175
		public static void StartIAnEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FABB RID: 129723 RVA: 0x00468F7E File Offset: 0x0046717E
		public static void AddType(FlatBufferBuilder builder, ESceneItemSeqEventCbType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FABC RID: 129724 RVA: 0x00468F89 File Offset: 0x00467189
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(1, eventNameOffset.Value, 0);
		}

		// Token: 0x0601FABD RID: 129725 RVA: 0x00468F99 File Offset: 0x00467199
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(2, actionOffset.Value, 0);
		}

		// Token: 0x0601FABE RID: 129726 RVA: 0x00468FA9 File Offset: 0x004671A9
		public static Offset<IAnEvent> EndIAnEvent(FlatBufferBuilder builder)
		{
			return new Offset<IAnEvent>(builder.EndTable());
		}

		// Token: 0x0601FABF RID: 129727 RVA: 0x00468FB8 File Offset: 0x004671B8
		public IAnEventT UnPack()
		{
			IAnEventT anEventT = new IAnEventT();
			this.UnPackTo(anEventT);
			return anEventT;
		}

		// Token: 0x0601FAC0 RID: 129728 RVA: 0x00468FD4 File Offset: 0x004671D4
		public void UnPackTo(IAnEventT _o)
		{
			_o.Type = this.Type;
			_o.EventName = this.EventName;
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
		}

		// Token: 0x0601FAC1 RID: 129729 RVA: 0x00469028 File Offset: 0x00467228
		public static Offset<IAnEvent> Pack(FlatBufferBuilder builder, IAnEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAnEvent>);
			}
			StringOffset eventNameOffset = (_o.EventName == null) ? default(StringOffset) : builder.CreateString(_o.EventName);
			Offset<IActionInfo> actionOffset = (_o.Action == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.Action);
			return IAnEvent.CreateIAnEvent(builder, _o.Type, eventNameOffset, actionOffset);
		}

		// Token: 0x0400DC74 RID: 56436
		private Table __p;
	}
}
