using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F8 RID: 29432
	public struct ITalkItemPhoneMessageVoice : IFlatbufferObject
	{
		// Token: 0x1700DD6D RID: 56685
		// (get) Token: 0x06034EBD RID: 216765 RVA: 0x0072AD89 File Offset: 0x00728F89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034EBE RID: 216766 RVA: 0x0072AD96 File Offset: 0x00728F96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034EBF RID: 216767 RVA: 0x0072ADA0 File Offset: 0x00728FA0
		public static ITalkItemPhoneMessageVoice GetRootAsITalkItemPhoneMessageVoice(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessageVoice.GetRootAsITalkItemPhoneMessageVoice(_bb, default(ITalkItemPhoneMessageVoice));
		}

		// Token: 0x06034EC0 RID: 216768 RVA: 0x0072ADBC File Offset: 0x00728FBC
		public static ITalkItemPhoneMessageVoice GetRootAsITalkItemPhoneMessageVoice(ByteBuffer _bb, ITalkItemPhoneMessageVoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034EC1 RID: 216769 RVA: 0x0072ADD9 File Offset: 0x00728FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034EC2 RID: 216770 RVA: 0x0072ADE8 File Offset: 0x00728FE8
		public ITalkItemPhoneMessageVoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD6E RID: 56686
		// (get) Token: 0x06034EC3 RID: 216771 RVA: 0x0072ADF8 File Offset: 0x00728FF8
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

		// Token: 0x1700DD6F RID: 56687
		// (get) Token: 0x06034EC4 RID: 216772 RVA: 0x0072AE34 File Offset: 0x00729034
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

		// Token: 0x1700DD70 RID: 56688
		// (get) Token: 0x06034EC5 RID: 216773 RVA: 0x0072AE70 File Offset: 0x00729070
		public bool AutoPlay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DD71 RID: 56689
		// (get) Token: 0x06034EC6 RID: 216774 RVA: 0x0072AEB0 File Offset: 0x007290B0
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

		// Token: 0x06034EC7 RID: 216775 RVA: 0x0072AEED File Offset: 0x007290ED
		public static Offset<ITalkItemPhoneMessageVoice> CreateITalkItemPhoneMessageVoice(FlatBufferBuilder builder, EPhoneMessageType Type = EPhoneMessageType.Voice, EPhoneMessageVoicePushCondition PushCondition = EPhoneMessageVoicePushCondition.PlayVoice, bool AutoPlay = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITalkItemPhoneMessageVoice.AddNullMask(builder, NullMask);
			ITalkItemPhoneMessageVoice.AddAutoPlay(builder, AutoPlay);
			ITalkItemPhoneMessageVoice.AddPushCondition(builder, PushCondition);
			ITalkItemPhoneMessageVoice.AddType(builder, Type);
			return ITalkItemPhoneMessageVoice.EndITalkItemPhoneMessageVoice(builder);
		}

		// Token: 0x06034EC8 RID: 216776 RVA: 0x0072AF19 File Offset: 0x00729119
		public static void StartITalkItemPhoneMessageVoice(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06034EC9 RID: 216777 RVA: 0x0072AF22 File Offset: 0x00729122
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034ECA RID: 216778 RVA: 0x0072AF2D File Offset: 0x0072912D
		public static void AddPushCondition(FlatBufferBuilder builder, EPhoneMessageVoicePushCondition pushCondition)
		{
			builder.AddByte(1, (byte)pushCondition, 0);
		}

		// Token: 0x06034ECB RID: 216779 RVA: 0x0072AF38 File Offset: 0x00729138
		public static void AddAutoPlay(FlatBufferBuilder builder, bool autoPlay)
		{
			builder.AddBool(2, autoPlay, false);
		}

		// Token: 0x06034ECC RID: 216780 RVA: 0x0072AF43 File Offset: 0x00729143
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06034ECD RID: 216781 RVA: 0x0072AF4E File Offset: 0x0072914E
		public static Offset<ITalkItemPhoneMessageVoice> EndITalkItemPhoneMessageVoice(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessageVoice>(builder.EndTable());
		}

		// Token: 0x06034ECE RID: 216782 RVA: 0x0072AF5C File Offset: 0x0072915C
		public ITalkItemPhoneMessageVoiceT UnPack()
		{
			ITalkItemPhoneMessageVoiceT talkItemPhoneMessageVoiceT = new ITalkItemPhoneMessageVoiceT();
			this.UnPackTo(talkItemPhoneMessageVoiceT);
			return talkItemPhoneMessageVoiceT;
		}

		// Token: 0x06034ECF RID: 216783 RVA: 0x0072AF77 File Offset: 0x00729177
		public void UnPackTo(ITalkItemPhoneMessageVoiceT _o)
		{
			_o.Type = this.Type;
			_o.PushCondition = this.PushCondition;
			_o.AutoPlay = this.AutoPlay;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034ED0 RID: 216784 RVA: 0x0072AFAC File Offset: 0x007291AC
		public static Offset<ITalkItemPhoneMessageVoice> Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageVoiceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemPhoneMessageVoice>);
			}
			return ITalkItemPhoneMessageVoice.CreateITalkItemPhoneMessageVoice(builder, _o.Type, _o.PushCondition, _o.AutoPlay, _o.NullMask);
		}

		// Token: 0x04011FB3 RID: 73651
		private Table __p;
	}
}
