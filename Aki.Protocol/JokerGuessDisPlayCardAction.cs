using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000868 RID: 2152
	public sealed class JokerGuessDisPlayCardAction : IMessage<JokerGuessDisPlayCardAction>, IMessage, IEquatable<JokerGuessDisPlayCardAction>, IDeepCloneable<JokerGuessDisPlayCardAction>, IBufferMessage
	{
		// Token: 0x0600BFB1 RID: 49073 RVA: 0x001C7334 File Offset: 0x001C5534
		[NullableContext(1)]
		public static JokerGuessDisPlayCardAction Create()
		{
			return new JokerGuessDisPlayCardAction();
		}

		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x0600BFB2 RID: 49074 RVA: 0x001C733B File Offset: 0x001C553B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x0600BFB3 RID: 49075 RVA: 0x001C733E File Offset: 0x001C553E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessDisPlayCardAction.Descriptor;
			}
		}

		// Token: 0x0600BFB4 RID: 49076 RVA: 0x001C7345 File Offset: 0x001C5545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDisPlayCardAction()
		{
		}

		// Token: 0x0600BFB5 RID: 49077 RVA: 0x001C734D File Offset: 0x001C554D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDisPlayCardAction(JokerGuessDisPlayCardAction other) : this()
		{
			this.jokerSkillId_ = other.jokerSkillId_;
			this.owner_ = other.owner_;
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFB6 RID: 49078 RVA: 0x001C738A File Offset: 0x001C558A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDisPlayCardAction Clone()
		{
			return new JokerGuessDisPlayCardAction(this);
		}

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x0600BFB7 RID: 49079 RVA: 0x001C7392 File Offset: 0x001C5592
		// (set) Token: 0x0600BFB8 RID: 49080 RVA: 0x001C739A File Offset: 0x001C559A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int JokerSkillId
		{
			get
			{
				return this.jokerSkillId_;
			}
			set
			{
				this.jokerSkillId_ = value;
			}
		}

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x0600BFB9 RID: 49081 RVA: 0x001C73A3 File Offset: 0x001C55A3
		// (set) Token: 0x0600BFBA RID: 49082 RVA: 0x001C73AB File Offset: 0x001C55AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessActor Owner
		{
			get
			{
				return this.owner_;
			}
			set
			{
				this.owner_ = value;
			}
		}

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x0600BFBB RID: 49083 RVA: 0x001C73B4 File Offset: 0x001C55B4
		// (set) Token: 0x0600BFBC RID: 49084 RVA: 0x001C73BC File Offset: 0x001C55BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardId
		{
			get
			{
				return this.cardId_;
			}
			set
			{
				this.cardId_ = value;
			}
		}

		// Token: 0x0600BFBD RID: 49085 RVA: 0x001C73C5 File Offset: 0x001C55C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessDisPlayCardAction);
		}

		// Token: 0x0600BFBE RID: 49086 RVA: 0x001C73D4 File Offset: 0x001C55D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessDisPlayCardAction other)
		{
			return other != null && (other == this || (this.JokerSkillId == other.JokerSkillId && this.Owner == other.Owner && this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFBF RID: 49087 RVA: 0x001C7430 File Offset: 0x001C5630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JokerSkillId != 0)
			{
				num ^= this.JokerSkillId.GetHashCode();
			}
			if (this.Owner != JokerGuessActor.Who)
			{
				num ^= this.Owner.GetHashCode();
			}
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BFC0 RID: 49088 RVA: 0x001C74A7 File Offset: 0x001C56A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BFC1 RID: 49089 RVA: 0x001C74B4 File Offset: 0x001C56B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFC2 RID: 49090 RVA: 0x001C74C0 File Offset: 0x001C56C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JokerSkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.JokerSkillId);
			}
			if (this.Owner != JokerGuessActor.Who)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Owner);
			}
			if (this.CardId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BFC3 RID: 49091 RVA: 0x001C7534 File Offset: 0x001C5734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JokerSkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.JokerSkillId);
			}
			if (this.Owner != JokerGuessActor.Who)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Owner);
			}
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BFC4 RID: 49092 RVA: 0x001C75A4 File Offset: 0x001C57A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessDisPlayCardAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JokerSkillId != 0)
			{
				this.JokerSkillId = other.JokerSkillId;
			}
			if (other.Owner != JokerGuessActor.Who)
			{
				this.Owner = other.Owner;
			}
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BFC5 RID: 49093 RVA: 0x001C7608 File Offset: 0x001C5808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFC6 RID: 49094 RVA: 0x001C7614 File Offset: 0x001C5814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CardId = input.ReadInt32();
						}
					}
					else
					{
						this.Owner = (JokerGuessActor)input.ReadEnum();
					}
				}
				else
				{
					this.JokerSkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005364 RID: 21348
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005365 RID: 21349
		public const int JokerSkillIdFieldNumber = 1;

		// Token: 0x04005366 RID: 21350
		private int jokerSkillId_;

		// Token: 0x04005367 RID: 21351
		public const int OwnerFieldNumber = 2;

		// Token: 0x04005368 RID: 21352
		private JokerGuessActor owner_;

		// Token: 0x04005369 RID: 21353
		public const int CardIdFieldNumber = 3;

		// Token: 0x0400536A RID: 21354
		private int cardId_;
	}
}
