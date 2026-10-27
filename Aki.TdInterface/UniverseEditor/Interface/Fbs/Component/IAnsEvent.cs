using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EB3 RID: 20147
	public struct IAnsEvent : IFlatbufferObject
	{
		// Token: 0x17009088 RID: 37000
		// (get) Token: 0x0601FB96 RID: 129942 RVA: 0x0046AAB6 File Offset: 0x00468CB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FB97 RID: 129943 RVA: 0x0046AAC3 File Offset: 0x00468CC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FB98 RID: 129944 RVA: 0x0046AACC File Offset: 0x00468CCC
		public static IAnsEvent GetRootAsIAnsEvent(ByteBuffer _bb)
		{
			return IAnsEvent.GetRootAsIAnsEvent(_bb, default(IAnsEvent));
		}

		// Token: 0x0601FB99 RID: 129945 RVA: 0x0046AAE8 File Offset: 0x00468CE8
		public static IAnsEvent GetRootAsIAnsEvent(ByteBuffer _bb, IAnsEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FB9A RID: 129946 RVA: 0x0046AB05 File Offset: 0x00468D05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FB9B RID: 129947 RVA: 0x0046AB14 File Offset: 0x00468D14
		public IAnsEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009089 RID: 37001
		// (get) Token: 0x0601FB9C RID: 129948 RVA: 0x0046AB24 File Offset: 0x00468D24
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

		// Token: 0x1700908A RID: 37002
		// (get) Token: 0x0601FB9D RID: 129949 RVA: 0x0046AB60 File Offset: 0x00468D60
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

		// Token: 0x0601FB9E RID: 129950 RVA: 0x0046AB97 File Offset: 0x00468D97
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601FB9F RID: 129951 RVA: 0x0046ABA6 File Offset: 0x00468DA6
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700908B RID: 37003
		// (get) Token: 0x0601FBA0 RID: 129952 RVA: 0x0046ABB4 File Offset: 0x00468DB4
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

		// Token: 0x1700908C RID: 37004
		// (get) Token: 0x0601FBA1 RID: 129953 RVA: 0x0046AC14 File Offset: 0x00468E14
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

		// Token: 0x0601FBA2 RID: 129954 RVA: 0x0046AC55 File Offset: 0x00468E55
		public static Offset<IAnsEvent> CreateIAnsEvent(FlatBufferBuilder builder, ESceneItemSeqEventCbType Type = ESceneItemSeqEventCbType.ANS, StringOffset EventNameOffset = default(StringOffset), Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>), float Duration = 0f)
		{
			builder.StartTable(4);
			IAnsEvent.AddDuration(builder, Duration);
			IAnsEvent.AddAction(builder, ActionOffset);
			IAnsEvent.AddEventName(builder, EventNameOffset);
			IAnsEvent.AddType(builder, Type);
			return IAnsEvent.EndIAnsEvent(builder);
		}

		// Token: 0x0601FBA3 RID: 129955 RVA: 0x0046AC81 File Offset: 0x00468E81
		public static void StartIAnsEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601FBA4 RID: 129956 RVA: 0x0046AC8A File Offset: 0x00468E8A
		public static void AddType(FlatBufferBuilder builder, ESceneItemSeqEventCbType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FBA5 RID: 129957 RVA: 0x0046AC95 File Offset: 0x00468E95
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(1, eventNameOffset.Value, 0);
		}

		// Token: 0x0601FBA6 RID: 129958 RVA: 0x0046ACA5 File Offset: 0x00468EA5
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(2, actionOffset.Value, 0);
		}

		// Token: 0x0601FBA7 RID: 129959 RVA: 0x0046ACB5 File Offset: 0x00468EB5
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(3, duration, 0.0);
		}

		// Token: 0x0601FBA8 RID: 129960 RVA: 0x0046ACC8 File Offset: 0x00468EC8
		public static Offset<IAnsEvent> EndIAnsEvent(FlatBufferBuilder builder)
		{
			return new Offset<IAnsEvent>(builder.EndTable());
		}

		// Token: 0x0601FBA9 RID: 129961 RVA: 0x0046ACD8 File Offset: 0x00468ED8
		public IAnsEventT UnPack()
		{
			IAnsEventT ansEventT = new IAnsEventT();
			this.UnPackTo(ansEventT);
			return ansEventT;
		}

		// Token: 0x0601FBAA RID: 129962 RVA: 0x0046ACF4 File Offset: 0x00468EF4
		public void UnPackTo(IAnsEventT _o)
		{
			_o.Type = this.Type;
			_o.EventName = this.EventName;
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
			_o.Duration = this.Duration;
		}

		// Token: 0x0601FBAB RID: 129963 RVA: 0x0046AD54 File Offset: 0x00468F54
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

		// Token: 0x0400DC9A RID: 56474
		private Table __p;
	}
}
