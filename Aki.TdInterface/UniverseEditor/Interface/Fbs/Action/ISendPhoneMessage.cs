using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200773B RID: 30523
	public struct ISendPhoneMessage : IFlatbufferObject
	{
		// Token: 0x1700DFC2 RID: 57282
		// (get) Token: 0x060358DB RID: 219355 RVA: 0x0072D939 File Offset: 0x0072BB39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060358DC RID: 219356 RVA: 0x0072D946 File Offset: 0x0072BB46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060358DD RID: 219357 RVA: 0x0072D950 File Offset: 0x0072BB50
		public static ISendPhoneMessage GetRootAsISendPhoneMessage(ByteBuffer _bb)
		{
			return ISendPhoneMessage.GetRootAsISendPhoneMessage(_bb, default(ISendPhoneMessage));
		}

		// Token: 0x060358DE RID: 219358 RVA: 0x0072D96C File Offset: 0x0072BB6C
		public static ISendPhoneMessage GetRootAsISendPhoneMessage(ByteBuffer _bb, ISendPhoneMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060358DF RID: 219359 RVA: 0x0072D989 File Offset: 0x0072BB89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060358E0 RID: 219360 RVA: 0x0072D998 File Offset: 0x0072BB98
		public ISendPhoneMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFC3 RID: 57283
		// (get) Token: 0x060358E1 RID: 219361 RVA: 0x0072D9A8 File Offset: 0x0072BBA8
		public EPhoneSystemInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneSystemInteractType.SendPhoneMessage;
				}
				return (EPhoneSystemInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DFC4 RID: 57284
		// (get) Token: 0x060358E2 RID: 219362 RVA: 0x0072D9E4 File Offset: 0x0072BBE4
		public IPhoneRecordActionConfig? PhoneRecordActionConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPhoneRecordActionConfig?(default(IPhoneRecordActionConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060358E3 RID: 219363 RVA: 0x0072DA41 File Offset: 0x0072BC41
		public static Offset<ISendPhoneMessage> CreateISendPhoneMessage(FlatBufferBuilder builder, EPhoneSystemInteractType Type = EPhoneSystemInteractType.SendPhoneMessage, Offset<IPhoneRecordActionConfig> PhoneRecordActionConfigOffset = default(Offset<IPhoneRecordActionConfig>))
		{
			builder.StartTable(2);
			ISendPhoneMessage.AddPhoneRecordActionConfig(builder, PhoneRecordActionConfigOffset);
			ISendPhoneMessage.AddType(builder, Type);
			return ISendPhoneMessage.EndISendPhoneMessage(builder);
		}

		// Token: 0x060358E4 RID: 219364 RVA: 0x0072DA5E File Offset: 0x0072BC5E
		public static void StartISendPhoneMessage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060358E5 RID: 219365 RVA: 0x0072DA67 File Offset: 0x0072BC67
		public static void AddType(FlatBufferBuilder builder, EPhoneSystemInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060358E6 RID: 219366 RVA: 0x0072DA72 File Offset: 0x0072BC72
		public static void AddPhoneRecordActionConfig(FlatBufferBuilder builder, Offset<IPhoneRecordActionConfig> phoneRecordActionConfigOffset)
		{
			builder.AddOffset(1, phoneRecordActionConfigOffset.Value, 0);
		}

		// Token: 0x060358E7 RID: 219367 RVA: 0x0072DA82 File Offset: 0x0072BC82
		public static Offset<ISendPhoneMessage> EndISendPhoneMessage(FlatBufferBuilder builder)
		{
			return new Offset<ISendPhoneMessage>(builder.EndTable());
		}

		// Token: 0x060358E8 RID: 219368 RVA: 0x0072DA90 File Offset: 0x0072BC90
		public ISendPhoneMessageT UnPack()
		{
			ISendPhoneMessageT sendPhoneMessageT = new ISendPhoneMessageT();
			this.UnPackTo(sendPhoneMessageT);
			return sendPhoneMessageT;
		}

		// Token: 0x060358E9 RID: 219369 RVA: 0x0072DAAC File Offset: 0x0072BCAC
		public void UnPackTo(ISendPhoneMessageT _o)
		{
			_o.Type = this.Type;
			_o.PhoneRecordActionConfig = ((this.PhoneRecordActionConfig != null) ? this.PhoneRecordActionConfig.Value.UnPack() : null);
		}

		// Token: 0x060358EA RID: 219370 RVA: 0x0072DAF4 File Offset: 0x0072BCF4
		public static Offset<ISendPhoneMessage> Pack(FlatBufferBuilder builder, ISendPhoneMessageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendPhoneMessage>);
			}
			Offset<IPhoneRecordActionConfig> phoneRecordActionConfigOffset = (_o.PhoneRecordActionConfig == null) ? default(Offset<IPhoneRecordActionConfig>) : IPhoneRecordActionConfig.Pack(builder, _o.PhoneRecordActionConfig);
			return ISendPhoneMessage.CreateISendPhoneMessage(builder, _o.Type, phoneRecordActionConfigOffset);
		}

		// Token: 0x04012954 RID: 76116
		private Table __p;
	}
}
