using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E9 RID: 29417
	public struct ITalkItemPhoneMessageAttachment : IFlatbufferObject
	{
		// Token: 0x1700DD5B RID: 56667
		// (get) Token: 0x06034E5B RID: 216667 RVA: 0x0072A4D4 File Offset: 0x007286D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034E5C RID: 216668 RVA: 0x0072A4E1 File Offset: 0x007286E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034E5D RID: 216669 RVA: 0x0072A4E8 File Offset: 0x007286E8
		public static ITalkItemPhoneMessageAttachment GetRootAsITalkItemPhoneMessageAttachment(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessageAttachment.GetRootAsITalkItemPhoneMessageAttachment(_bb, default(ITalkItemPhoneMessageAttachment));
		}

		// Token: 0x06034E5E RID: 216670 RVA: 0x0072A504 File Offset: 0x00728704
		public static ITalkItemPhoneMessageAttachment GetRootAsITalkItemPhoneMessageAttachment(ByteBuffer _bb, ITalkItemPhoneMessageAttachment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034E5F RID: 216671 RVA: 0x0072A521 File Offset: 0x00728721
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034E60 RID: 216672 RVA: 0x0072A530 File Offset: 0x00728730
		public ITalkItemPhoneMessageAttachment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD5C RID: 56668
		// (get) Token: 0x06034E61 RID: 216673 RVA: 0x0072A540 File Offset: 0x00728740
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

		// Token: 0x1700DD5D RID: 56669
		// (get) Token: 0x06034E62 RID: 216674 RVA: 0x0072A57C File Offset: 0x0072877C
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

		// Token: 0x06034E63 RID: 216675 RVA: 0x0072A5B8 File Offset: 0x007287B8
		public static Offset<ITalkItemPhoneMessageAttachment> CreateITalkItemPhoneMessageAttachment(FlatBufferBuilder builder, EPhoneMessageType Type = EPhoneMessageType.Voice, int AttachmentId = 0)
		{
			builder.StartTable(2);
			ITalkItemPhoneMessageAttachment.AddAttachmentId(builder, AttachmentId);
			ITalkItemPhoneMessageAttachment.AddType(builder, Type);
			return ITalkItemPhoneMessageAttachment.EndITalkItemPhoneMessageAttachment(builder);
		}

		// Token: 0x06034E64 RID: 216676 RVA: 0x0072A5D5 File Offset: 0x007287D5
		public static void StartITalkItemPhoneMessageAttachment(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034E65 RID: 216677 RVA: 0x0072A5DE File Offset: 0x007287DE
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034E66 RID: 216678 RVA: 0x0072A5E9 File Offset: 0x007287E9
		public static void AddAttachmentId(FlatBufferBuilder builder, int attachmentId)
		{
			builder.AddInt(1, attachmentId, 0);
		}

		// Token: 0x06034E67 RID: 216679 RVA: 0x0072A5F4 File Offset: 0x007287F4
		public static Offset<ITalkItemPhoneMessageAttachment> EndITalkItemPhoneMessageAttachment(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessageAttachment>(builder.EndTable());
		}

		// Token: 0x06034E68 RID: 216680 RVA: 0x0072A604 File Offset: 0x00728804
		public ITalkItemPhoneMessageAttachmentT UnPack()
		{
			ITalkItemPhoneMessageAttachmentT talkItemPhoneMessageAttachmentT = new ITalkItemPhoneMessageAttachmentT();
			this.UnPackTo(talkItemPhoneMessageAttachmentT);
			return talkItemPhoneMessageAttachmentT;
		}

		// Token: 0x06034E69 RID: 216681 RVA: 0x0072A61F File Offset: 0x0072881F
		public void UnPackTo(ITalkItemPhoneMessageAttachmentT _o)
		{
			_o.Type = this.Type;
			_o.AttachmentId = this.AttachmentId;
		}

		// Token: 0x06034E6A RID: 216682 RVA: 0x0072A63C File Offset: 0x0072883C
		public static Offset<ITalkItemPhoneMessageAttachment> Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageAttachmentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemPhoneMessageAttachment>);
			}
			return ITalkItemPhoneMessageAttachment.CreateITalkItemPhoneMessageAttachment(builder, _o.Type, _o.AttachmentId);
		}

		// Token: 0x04011FA0 RID: 73632
		private Table __p;
	}
}
