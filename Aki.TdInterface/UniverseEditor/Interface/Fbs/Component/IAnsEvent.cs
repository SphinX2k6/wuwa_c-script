using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053DC RID: 21468
	public struct IAnsEvent : IFlatbufferObject
	{
		// Token: 0x170097E9 RID: 38889
		// (get) Token: 0x06021897 RID: 137367 RVA: 0x0049FF32 File Offset: 0x0049E132
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021898 RID: 137368 RVA: 0x0049FF3F File Offset: 0x0049E13F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021899 RID: 137369 RVA: 0x0049FF48 File Offset: 0x0049E148
		public static IAnsEvent GetRootAsIAnsEvent(ByteBuffer _bb)
		{
			return IAnsEvent.GetRootAsIAnsEvent(_bb, default(IAnsEvent));
		}

		// Token: 0x0602189A RID: 137370 RVA: 0x0049FF64 File Offset: 0x0049E164
		public static IAnsEvent GetRootAsIAnsEvent(ByteBuffer _bb, IAnsEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602189B RID: 137371 RVA: 0x0049FF81 File Offset: 0x0049E181
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602189C RID: 137372 RVA: 0x0049FF90 File Offset: 0x0049E190
		public IAnsEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097EA RID: 38890
		// (get) Token: 0x0602189D RID: 137373 RVA: 0x0049FFA0 File Offset: 0x0049E1A0
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

		// Token: 0x170097EB RID: 38891
		// (get) Token: 0x0602189E RID: 137374 RVA: 0x0049FFDC File Offset: 0x0049E1DC
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

		// Token: 0x0602189F RID: 137375 RVA: 0x004A0013 File Offset: 0x0049E213
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060218A0 RID: 137376 RVA: 0x004A0022 File Offset: 0x0049E222
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170097EC RID: 38892
		// (get) Token: 0x060218A1 RID: 137377 RVA: 0x004A0030 File Offset: 0x0049E230
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

		// Token: 0x170097ED RID: 38893
		// (get) Token: 0x060218A2 RID: 137378 RVA: 0x004A0090 File Offset: 0x0049E290
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060218A3 RID: 137379 RVA: 0x004A00D1 File Offset: 0x0049E2D1
		public static Offset<IAnsEvent> CreateIAnsEvent(FlatBufferBuilder builder, ESceneItemSeqEventCbType Type = ESceneItemSeqEventCbType.ANS, StringOffset EventNameOffset = default(StringOffset), Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>), float Duration = 0f)
		{
			builder.StartTable(4);
			IAnsEvent.AddDuration(builder, Duration);
			IAnsEvent.AddAction(builder, ActionOffset);
			IAnsEvent.AddEventName(builder, EventNameOffset);
			IAnsEvent.AddType(builder, Type);
			return IAnsEvent.EndIAnsEvent(builder);
		}

		// Token: 0x060218A4 RID: 137380 RVA: 0x004A00FD File Offset: 0x0049E2FD
		public static void StartIAnsEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060218A5 RID: 137381 RVA: 0x004A0106 File Offset: 0x0049E306
		public static void AddType(FlatBufferBuilder builder, ESceneItemSeqEventCbType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060218A6 RID: 137382 RVA: 0x004A0111 File Offset: 0x0049E311
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(1, eventNameOffset.Value, 0);
		}

		// Token: 0x060218A7 RID: 137383 RVA: 0x004A0121 File Offset: 0x0049E321
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(2, actionOffset.Value, 0);
		}

		// Token: 0x060218A8 RID: 137384 RVA: 0x004A0131 File Offset: 0x0049E331
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(3, duration, 0.0);
		}

		// Token: 0x060218A9 RID: 137385 RVA: 0x004A0144 File Offset: 0x0049E344
		public static Offset<IAnsEvent> EndIAnsEvent(FlatBufferBuilder builder)
		{
			return new Offset<IAnsEvent>(builder.EndTable());
		}

		// Token: 0x060218AA RID: 137386 RVA: 0x004A0154 File Offset: 0x0049E354
		public IAnsEventT UnPack()
		{
			IAnsEventT ansEventT = new IAnsEventT();
			this.UnPackTo(ansEventT);
			return ansEventT;
		}

		// Token: 0x060218AB RID: 137387 RVA: 0x004A0170 File Offset: 0x0049E370
		public void UnPackTo(IAnsEventT _o)
		{
			_o.Type = this.Type;
			_o.EventName = this.EventName;
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
			_o.Duration = this.Duration;
		}

		// Token: 0x060218AC RID: 137388 RVA: 0x004A01D0 File Offset: 0x0049E3D0
		public static Offset<IAnsEvent> Pack(FlatBufferBuilder builder, IAnsEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAnsEvent>);
			}
			StringOffset eventNameOffset = (_o.EventName == null) ? default(StringOffset) : builder.CreateString(_o.EventName);
			Offset<IActionInfo> actionOffset = (_o.Action == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.Action);
			return IAnsEvent.CreateIAnsEvent(builder, _o.Type, eventNameOffset, actionOffset, _o.Duration);
		}

		// Token: 0x0400E836 RID: 59446
		private Table __p;
	}
}
