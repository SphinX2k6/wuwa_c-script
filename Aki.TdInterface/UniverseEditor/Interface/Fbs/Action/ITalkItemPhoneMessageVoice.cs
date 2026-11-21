using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ACD RID: 31437
	public struct ITalkItemPhoneMessageVoice : IFlatbufferObject
	{
		// Token: 0x1700E966 RID: 59750
		// (get) Token: 0x060381C3 RID: 229827 RVA: 0x0078C1ED File Offset: 0x0078A3ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060381C4 RID: 229828 RVA: 0x0078C1FA File Offset: 0x0078A3FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060381C5 RID: 229829 RVA: 0x0078C204 File Offset: 0x0078A404
		public static ITalkItemPhoneMessageVoice GetRootAsITalkItemPhoneMessageVoice(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessageVoice.GetRootAsITalkItemPhoneMessageVoice(_bb, default(ITalkItemPhoneMessageVoice));
		}

		// Token: 0x060381C6 RID: 229830 RVA: 0x0078C220 File Offset: 0x0078A420
		public static ITalkItemPhoneMessageVoice GetRootAsITalkItemPhoneMessageVoice(ByteBuffer _bb, ITalkItemPhoneMessageVoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060381C7 RID: 229831 RVA: 0x0078C23D File Offset: 0x0078A43D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060381C8 RID: 229832 RVA: 0x0078C24C File Offset: 0x0078A44C
		public ITalkItemPhoneMessageVoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E967 RID: 59751
		// (get) Token: 0x060381C9 RID: 229833 RVA: 0x0078C25C File Offset: 0x0078A45C
		public EPhoneMessageType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneMessageType.Voice;
				}
				return (EPhoneMessageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E968 RID: 59752
		// (get) Token: 0x060381CA RID: 229834 RVA: 0x0078C298 File Offset: 0x0078A498
		public EPhoneMessageVoicePushCondition PushCondition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPhoneMessageVoicePushCondition.PlayVoice;
				}
				return (EPhoneMessageVoicePushCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E969 RID: 59753
		// (get) Token: 0x060381CB RID: 229835 RVA: 0x0078C2D4 File Offset: 0x0078A4D4
		public bool AutoPlay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E96A RID: 59754
		// (get) Token: 0x060381CC RID: 229836 RVA: 0x0078C314 File Offset: 0x0078A514
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060381CD RID: 229837 RVA: 0x0078C351 File Offset: 0x0078A551
		public static Offset<ITalkItemPhoneMessageVoice> CreateITalkItemPhoneMessageVoice(FlatBufferBuilder builder, EPhoneMessageType Type = EPhoneMessageType.Voice, EPhoneMessageVoicePushCondition PushCondition = EPhoneMessageVoicePushCondition.PlayVoice, bool AutoPlay = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITalkItemPhoneMessageVoice.AddNullMask(builder, NullMask);
			ITalkItemPhoneMessageVoice.AddAutoPlay(builder, AutoPlay);
			ITalkItemPhoneMessageVoice.AddPushCondition(builder, PushCondition);
			ITalkItemPhoneMessageVoice.AddType(builder, Type);
			return ITalkItemPhoneMessageVoice.EndITalkItemPhoneMessageVoice(builder);
		}

		// Token: 0x060381CE RID: 229838 RVA: 0x0078C37D File Offset: 0x0078A57D
		public static void StartITalkItemPhoneMessageVoice(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060381CF RID: 229839 RVA: 0x0078C386 File Offset: 0x0078A586
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060381D0 RID: 229840 RVA: 0x0078C391 File Offset: 0x0078A591
		public static void AddPushCondition(FlatBufferBuilder builder, EPhoneMessageVoicePushCondition pushCondition)
		{
			builder.AddByte(1, (byte)pushCondition, 0);
		}

		// Token: 0x060381D1 RID: 229841 RVA: 0x0078C39C File Offset: 0x0078A59C
		public static void AddAutoPlay(FlatBufferBuilder builder, bool autoPlay)
		{
			builder.AddBool(2, autoPlay, false);
		}

		// Token: 0x060381D2 RID: 229842 RVA: 0x0078C3A7 File Offset: 0x0078A5A7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060381D3 RID: 229843 RVA: 0x0078C3B2 File Offset: 0x0078A5B2
		public static Offset<ITalkItemPhoneMessageVoice> EndITalkItemPhoneMessageVoice(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessageVoice>(builder.EndTable());
		}

		// Token: 0x060381D4 RID: 229844 RVA: 0x0078C3C0 File Offset: 0x0078A5C0
		public ITalkItemPhoneMessageVoiceT UnPack()
		{
			ITalkItemPhoneMessageVoiceT talkItemPhoneMessageVoiceT = new ITalkItemPhoneMessageVoiceT();
			this.UnPackTo(talkItemPhoneMessageVoiceT);
			return talkItemPhoneMessageVoiceT;
		}

		// Token: 0x060381D5 RID: 229845 RVA: 0x0078C3DB File Offset: 0x0078A5DB
		public void UnPackTo(ITalkItemPhoneMessageVoiceT _o)
		{
			_o.Type = this.Type;
			_o.PushCondition = this.PushCondition;
			_o.AutoPlay = this.AutoPlay;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060381D6 RID: 229846 RVA: 0x0078C410 File Offset: 0x0078A610
		public static Offset<ITalkItemPhoneMessageVoice> Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageVoiceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemPhoneMessageVoice>);
			}
			return ITalkItemPhoneMessageVoice.CreateITalkItemPhoneMessageVoice(builder, _o.Type, _o.PushCondition, _o.AutoPlay, _o.NullMask);
		}

		// Token: 0x04012FB6 RID: 77750
		private Table __p;
	}
}
