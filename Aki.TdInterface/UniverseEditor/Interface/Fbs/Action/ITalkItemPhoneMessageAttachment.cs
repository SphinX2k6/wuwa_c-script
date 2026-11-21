using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ABE RID: 31422
	public struct ITalkItemPhoneMessageAttachment : IFlatbufferObject
	{
		// Token: 0x1700E954 RID: 59732
		// (get) Token: 0x06038161 RID: 229729 RVA: 0x0078B938 File Offset: 0x00789B38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038162 RID: 229730 RVA: 0x0078B945 File Offset: 0x00789B45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038163 RID: 229731 RVA: 0x0078B94C File Offset: 0x00789B4C
		public static ITalkItemPhoneMessageAttachment GetRootAsITalkItemPhoneMessageAttachment(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessageAttachment.GetRootAsITalkItemPhoneMessageAttachment(_bb, default(ITalkItemPhoneMessageAttachment));
		}

		// Token: 0x06038164 RID: 229732 RVA: 0x0078B968 File Offset: 0x00789B68
		public static ITalkItemPhoneMessageAttachment GetRootAsITalkItemPhoneMessageAttachment(ByteBuffer _bb, ITalkItemPhoneMessageAttachment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038165 RID: 229733 RVA: 0x0078B985 File Offset: 0x00789B85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038166 RID: 229734 RVA: 0x0078B994 File Offset: 0x00789B94
		public ITalkItemPhoneMessageAttachment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E955 RID: 59733
		// (get) Token: 0x06038167 RID: 229735 RVA: 0x0078B9A4 File Offset: 0x00789BA4
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

		// Token: 0x1700E956 RID: 59734
		// (get) Token: 0x06038168 RID: 229736 RVA: 0x0078B9E0 File Offset: 0x00789BE0
		public int AttachmentId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038169 RID: 229737 RVA: 0x0078BA1C File Offset: 0x00789C1C
		public static Offset<ITalkItemPhoneMessageAttachment> CreateITalkItemPhoneMessageAttachment(FlatBufferBuilder builder, EPhoneMessageType Type = EPhoneMessageType.Voice, int AttachmentId = 0)
		{
			builder.StartTable(2);
			ITalkItemPhoneMessageAttachment.AddAttachmentId(builder, AttachmentId);
			ITalkItemPhoneMessageAttachment.AddType(builder, Type);
			return ITalkItemPhoneMessageAttachment.EndITalkItemPhoneMessageAttachment(builder);
		}

		// Token: 0x0603816A RID: 229738 RVA: 0x0078BA39 File Offset: 0x00789C39
		public static void StartITalkItemPhoneMessageAttachment(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603816B RID: 229739 RVA: 0x0078BA42 File Offset: 0x00789C42
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603816C RID: 229740 RVA: 0x0078BA4D File Offset: 0x00789C4D
		public static void AddAttachmentId(FlatBufferBuilder builder, int attachmentId)
		{
			builder.AddInt(1, attachmentId, 0);
		}

		// Token: 0x0603816D RID: 229741 RVA: 0x0078BA58 File Offset: 0x00789C58
		public static Offset<ITalkItemPhoneMessageAttachment> EndITalkItemPhoneMessageAttachment(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessageAttachment>(builder.EndTable());
		}

		// Token: 0x0603816E RID: 229742 RVA: 0x0078BA68 File Offset: 0x00789C68
		public ITalkItemPhoneMessageAttachmentT UnPack()
		{
			ITalkItemPhoneMessageAttachmentT talkItemPhoneMessageAttachmentT = new ITalkItemPhoneMessageAttachmentT();
			this.UnPackTo(talkItemPhoneMessageAttachmentT);
			return talkItemPhoneMessageAttachmentT;
		}

		// Token: 0x0603816F RID: 229743 RVA: 0x0078BA83 File Offset: 0x00789C83
		public void UnPackTo(ITalkItemPhoneMessageAttachmentT _o)
		{
			_o.Type = this.Type;
			_o.AttachmentId = this.AttachmentId;
		}

		// Token: 0x06038170 RID: 229744 RVA: 0x0078BAA0 File Offset: 0x00789CA0
		public static Offset<ITalkItemPhoneMessageAttachment> Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageAttachmentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemPhoneMessageAttachment>);
			}
			return ITalkItemPhoneMessageAttachment.CreateITalkItemPhoneMessageAttachment(builder, _o.Type, _o.AttachmentId);
		}

		// Token: 0x04012FA3 RID: 77731
		private Table __p;
	}
}
